
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    // ==========================================
    // PUNTO DE ENTRADA
    // ==========================================

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSupermercado());
        }
    }

    // ==========================================
    // CLASE CLIENTE
    // ==========================================

    public class Cliente
    {
        public string Nombre;

        public Cliente(string nombre)
        {
            Nombre = nombre;
        }
    }

    // ==========================================
    // CLASE CAJA
    // ==========================================

    public class Caja
    {
        public int Numero;
        public bool Abierta;
        public Cliente Actual;

        public Queue<Cliente> Cola =
            new Queue<Cliente>();

        public decimal Recaudacion;

        public Caja(int numero, bool abierta)
        {
            Numero = numero;
            Abierta = abierta;
        }

        // CANTIDAD TOTAL DE CLIENTES
        public int CantidadClientes()
        {
            int cantidad = Cola.Count;

            if (Actual != null)
                cantidad++;

            return cantidad;
        }
    }

    // ==========================================
    // FORMULARIO PRINCIPAL
    // ==========================================

    public class FormSupermercado : Form
    {
        private List<Caja> cajas = new List<Caja>();

        private Label[] lblEstado = new Label[3];
        private Label[] lblCola = new Label[3];
        private Label[] lblActual = new Label[3];
        private Label[] lblRecaudacion = new Label[3];

        private TextBox[] txtImporte = new TextBox[3];

        private Button[] btnAbrir = new Button[3];
        private Button[] btnCerrar = new Button[3];
        private Button[] btnCobrar = new Button[3];

        private Label lblResumen;

        private bool jornadaFinalizada = false;

        // ======================================
        // CONSTRUCTOR
        // ======================================

        public FormSupermercado()
        {
            Text = "Supermercado - Sistema de Cajas";
            Size = new Size(970, 460);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            // CAJA 1 CERRADA
            // CAJAS 2 Y 3 ABIERTAS

            cajas.Add(new Caja(1, false));
            cajas.Add(new Caja(2, true));
            cajas.Add(new Caja(3, true));

            for (int i = 0; i < 3; i++)
            {
                CrearPanelCaja(i);
            }

            // BOTON NUEVO CLIENTE

            Button btnNuevo = new Button();
            btnNuevo.Text = "Ingresar nuevo cliente\na línea de Cajas";
            btnNuevo.Location = new Point(300, 290);
            btnNuevo.Size = new Size(155, 55);
            btnNuevo.Click += BtnNuevo_Click;
            Controls.Add(btnNuevo);

            // BOTON FINALIZAR JORNADA

            Button btnFinalizar = new Button();
            btnFinalizar.Text = "Finalizar jornada";
            btnFinalizar.Location = new Point(465, 290);
            btnFinalizar.Size = new Size(140, 55);
            btnFinalizar.Click += BtnFinalizar_Click;
            Controls.Add(btnFinalizar);

            // RESUMEN DE RECAUDACION

            lblResumen = new Label();
            lblResumen.Location = new Point(660, 290);
            lblResumen.Size = new Size(250, 100);
            lblResumen.Text = "Importe total por caja:";
            Controls.Add(lblResumen);

            ActualizarPantalla();
        }

        // ======================================
        // CREAR PANEL DE CADA CAJA
        // ======================================

        private void CrearPanelCaja(int indice)
        {
            Caja caja = cajas[indice];

            GroupBox grupo = new GroupBox();

            grupo.Text = "Caja " + caja.Numero;
            grupo.Location = new Point(15 + indice * 310, 15);
            grupo.Size = new Size(290, 250);

            Controls.Add(grupo);

            // BOTON CERRAR

            btnCerrar[indice] = new Button();
            btnCerrar[indice].Text = "Cerrar";
            btnCerrar[indice].Location = new Point(205, 25);
            btnCerrar[indice].Size = new Size(70, 25);

            int n = indice;

            btnCerrar[indice].Click += delegate
            {
                CerrarCaja(n);
            };

            grupo.Controls.Add(btnCerrar[indice]);

            // BOTON ABRIR

            btnAbrir[indice] = new Button();
            btnAbrir[indice].Text = "Abrir";
            btnAbrir[indice].Location = new Point(205, 55);
            btnAbrir[indice].Size = new Size(70, 25);

            btnAbrir[indice].Click += delegate
            {
                AbrirCaja(n);
            };

            grupo.Controls.Add(btnAbrir[indice]);

            // ESTADO

            lblEstado[indice] = new Label();
            lblEstado[indice].Location = new Point(15, 65);
            lblEstado[indice].Size = new Size(175, 20);

            grupo.Controls.Add(lblEstado[indice]);

            // CLIENTES EN COLA

            lblCola[indice] = new Label();
            lblCola[indice].Location = new Point(15, 100);
            lblCola[indice].Size = new Size(250, 20);

            grupo.Controls.Add(lblCola[indice]);

            // CLIENTE ACTUAL

            lblActual[indice] = new Label();
            lblActual[indice].Location = new Point(15, 130);
            lblActual[indice].Size = new Size(260, 30);

            grupo.Controls.Add(lblActual[indice]);

            // IMPORTE

            Label lblImporte = new Label();
            lblImporte.Text = "$";
            lblImporte.Location = new Point(15, 180);
            lblImporte.Size = new Size(20, 25);

            grupo.Controls.Add(lblImporte);

            txtImporte[indice] = new TextBox();
            txtImporte[indice].Location = new Point(35, 177);
            txtImporte[indice].Size = new Size(100, 25);

            grupo.Controls.Add(txtImporte[indice]);

            // BOTON COBRAR

            btnCobrar[indice] = new Button();
            btnCobrar[indice].Text = "Cobrar";
            btnCobrar[indice].Location = new Point(150, 175);
            btnCobrar[indice].Size = new Size(100, 30);

            btnCobrar[indice].Click += delegate
            {
                FinalizarCobro(n);
            };

            grupo.Controls.Add(btnCobrar[indice]);

            // RECAUDACION

            lblRecaudacion[indice] = new Label();
            lblRecaudacion[indice].Location = new Point(15, 215);
            lblRecaudacion[indice].Size = new Size(260, 20);

            grupo.Controls.Add(lblRecaudacion[indice]);
        }

        // ======================================
        // AGREGAR CLIENTE
        // ======================================

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (jornadaFinalizada)
                return;

            string nombre = "";

            if (!PedirNombre(ref nombre))
                return;

            Cliente cliente = new Cliente(nombre);

            Caja destino = BuscarCajaMenorCarga();

            if (destino == null)
            {
                MessageBox.Show("No hay cajas abiertas");
                return;
            }

            destino.Cola.Enqueue(cliente);

            IniciarCobro(destino);

            ActualizarPantalla();

            MessageBox.Show(
                nombre + " fue asignado a la Caja " +
                destino.Numero);
        }

        // ======================================
        // SOLICITAR NOMBRE DEL CLIENTE
        // ======================================

        private bool PedirNombre(ref string nombre)
        {
            Form ventana = new Form();

            ventana.Text = "Nuevo cliente";
            ventana.Size = new Size(300, 150);
            ventana.StartPosition = FormStartPosition.CenterParent;
            ventana.FormBorderStyle = FormBorderStyle.FixedDialog;
            ventana.MaximizeBox = false;
            ventana.MinimizeBox = false;

            Label etiqueta = new Label();
            etiqueta.Text = "Ingrese el nombre del cliente:";
            etiqueta.Location = new Point(15, 15);
            etiqueta.Size = new Size(250, 20);

            ventana.Controls.Add(etiqueta);

            TextBox txtNombre = new TextBox();
            txtNombre.Location = new Point(15, 40);
            txtNombre.Size = new Size(250, 25);

            ventana.Controls.Add(txtNombre);

            Button aceptar = new Button();
            aceptar.Text = "Aceptar";
            aceptar.Location = new Point(15, 75);
            aceptar.DialogResult = DialogResult.OK;

            ventana.Controls.Add(aceptar);

            Button cancelar = new Button();
            cancelar.Text = "Cancelar";
            cancelar.Location = new Point(110, 75);
            cancelar.DialogResult = DialogResult.Cancel;

            ventana.Controls.Add(cancelar);

            ventana.AcceptButton = aceptar;
            ventana.CancelButton = cancelar;

            if (ventana.ShowDialog(this) == DialogResult.OK)
            {
                nombre = txtNombre.Text.Trim();

                if (nombre == "")
                {
                    MessageBox.Show("Ingrese un nombre válido");
                    return false;
                }

                return true;
            }

            return false;
        }

        // ======================================
        // BUSCAR CAJA CON MENOS CLIENTES
        // ======================================

        private Caja BuscarCajaMenorCarga()
        {
            Caja menor = null;

            foreach (Caja caja in cajas)
            {
                if (caja.Abierta)
                {
                    if (menor == null ||
                        caja.CantidadClientes() <
                        menor.CantidadClientes())
                    {
                        menor = caja;
                    }
                }
            }

            return menor;
        }

        // ======================================
        // INICIAR COBRO
        // ======================================

        private void IniciarCobro(Caja caja)
        {
            if (caja.Abierta &&
                caja.Actual == null &&
                caja.Cola.Count > 0)
            {
                caja.Actual = caja.Cola.Dequeue();
            }
        }

        // ======================================
        // FINALIZAR COBRO
        // ======================================

        private void FinalizarCobro(int indice)
        {
            if (jornadaFinalizada)
                return;

            Caja caja = cajas[indice];

            if (!caja.Abierta)
            {
                MessageBox.Show("La caja está cerrada");
                return;
            }

            if (caja.Actual == null)
            {
                MessageBox.Show("No hay ningún cliente cobrando");
                return;
            }

            decimal importe;

            if (!decimal.TryParse(
                txtImporte[indice].Text,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out importe) || importe < 0)
            {
                MessageBox.Show("Ingrese un importe válido");
                return;
            }

            // SUMAR RECAUDACION

            caja.Recaudacion += importe;

            MessageBox.Show(
                "Cobro finalizado: " +
                caja.Actual.Nombre +
                "\nImporte: $" + importe.ToString("N2"));

            // RETIRAR CLIENTE ACTUAL

            caja.Actual = null;

            txtImporte[indice].Clear();

            // SIGUIENTE CLIENTE

            IniciarCobro(caja);

            ActualizarPantalla();
        }

        // ======================================
        // ABRIR CAJA
        // ======================================

        private void AbrirCaja(int indice)
        {
            if (jornadaFinalizada)
                return;

            Caja caja = cajas[indice];

            if (caja.Abierta)
            {
                MessageBox.Show("La caja ya está abierta");
                return;
            }

            caja.Abierta = true;

            IniciarCobro(caja);

            ActualizarPantalla();
        }

        // ======================================
        // CERRAR CAJA
        // ======================================

        private void CerrarCaja(int indice)
        {
            if (jornadaFinalizada)
                return;

            Caja caja = cajas[indice];

            if (!caja.Abierta)
            {
                MessageBox.Show("La caja ya está cerrada");
                return;
            }

            // GUARDAR CLIENTES PENDIENTES

            Queue<Cliente> pendientes =
                new Queue<Cliente>();

            if (caja.Actual != null)
            {
                pendientes.Enqueue(caja.Actual);
                caja.Actual = null;
            }

            while (caja.Cola.Count > 0)
            {
                pendientes.Enqueue(caja.Cola.Dequeue());
            }

            // VERIFICAR SI HAY OTRA CAJA ABIERTA

            caja.Abierta = false;

            if (pendientes.Count > 0 &&
                BuscarCajaMenorCarga() == null)
            {
                caja.Abierta = true;

                while (pendientes.Count > 0)
                    caja.Cola.Enqueue(pendientes.Dequeue());

                IniciarCobro(caja);

                MessageBox.Show(
                    "No se puede cerrar la última caja abierta " +
                    "porque tiene clientes pendientes.");

                ActualizarPantalla();
                return;
            }

            // REDISTRIBUIR CLIENTES

            while (pendientes.Count > 0)
            {
                Cliente cliente = pendientes.Dequeue();

                Caja destino = BuscarCajaMenorCarga();

                if (destino != null)
                {
                    destino.Cola.Enqueue(cliente);

                    IniciarCobro(destino);
                }
            }

            ActualizarPantalla();

            MessageBox.Show(
                "Caja " + caja.Numero +
                " cerrada correctamente.");
        }

        // ======================================
        // ACTUALIZAR PANTALLA
        // ======================================

        private void ActualizarPantalla()
        {
            foreach (Caja caja in cajas)
            {
                int i = caja.Numero - 1;

                if (caja.Abierta)
                {
                    lblEstado[i].Text = "Abierta";
                    lblEstado[i].ForeColor = Color.Green;
                }
                else
                {
                    lblEstado[i].Text = "Cerrada";
                    lblEstado[i].ForeColor = Color.Red;
                }

                lblCola[i].Text =
                    "Clientes en cola: " + caja.Cola.Count;

                if (caja.Actual != null)
                {
                    lblActual[i].Text =
                        "¿Cobrando? " + caja.Actual.Nombre;
                }
                else
                {
                    lblActual[i].Text = "¿Cobrando? No";
                }

                lblRecaudacion[i].Text =
                    "Recaudado: $" +
                    caja.Recaudacion.ToString("N2");

                btnAbrir[i].Enabled =
                    !caja.Abierta && !jornadaFinalizada;

                btnCerrar[i].Enabled =
                    caja.Abierta && !jornadaFinalizada;

                btnCobrar[i].Enabled =
                    caja.Abierta &&
                    caja.Actual != null &&
                    !jornadaFinalizada;
            }

            lblResumen.Text =
                "Importe total por caja:\n\n" +
                "Caja 1: $" + cajas[0].Recaudacion.ToString("N2") +
                "\nCaja 2: $" + cajas[1].Recaudacion.ToString("N2") +
                "\nCaja 3: $" + cajas[2].Recaudacion.ToString("N2");
        }

        // ======================================
        // FINALIZAR JORNADA
        // ======================================

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            if (jornadaFinalizada)
                return;

            string mensaje = "RECAUDACION FINAL\n\n";

            decimal total = 0;

            foreach (Caja caja in cajas)
            {
                mensaje +=
                    "Caja " + caja.Numero +
                    ": $" + caja.Recaudacion.ToString("N2") +
                    "\n";

                total += caja.Recaudacion;
            }

            mensaje +=
                "\nTOTAL RECAUDADO: $" +
                total.ToString("N2");

            MessageBox.Show(
                mensaje,
                "Finalización de jornada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            jornadaFinalizada = true;

            ActualizarPantalla();
        }
    }
}
