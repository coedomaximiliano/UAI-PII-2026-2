using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6_pt2
{

    public partial class Form1 : Form
    {

        long Total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        Caja caja1 = new Caja();
        Caja caja2 = new Caja();
        Caja caja3 = new Caja();


        string ComprobarEstado(Caja caja)
        {
            string estado;
            switch (caja.abierta)
            {
                case true:
                    estado = "Abierta";
                    break;
                default:
                    estado = "Cerrada";
                    break;
            }
            return estado;
        }

        void Abrir(Caja caja)
        {
            caja.abierta = true;
            if(caja == caja1)
            {
                BtnAbrirCaja1.Enabled = false;
                TbPrecioC1.Enabled = true;
                BtnCerrarCaja1.Enabled = true;
            }
            if (caja == caja2)
            {
                BtnAbrirCaja2.Enabled = false;
                TbPrecioC2.Enabled = true;
                BtnCerrarCaja2.Enabled = true;

            }
            if (caja == caja3)
            {
                BtnAbrirCaja3.Enabled = false;
                TbPrecioC3.Enabled = true;
                BtnCerrarCaja3.Enabled = true;

            }
            MarcarEstado();
        }

        void TPSR(Caja CPrincipal, Caja Caux1, Caja Caux2)
        {
            if (Caux1.abierta && !Caux2.abierta)
            {
                Caux1.cola.EncolarT(CPrincipal.traspasarTodo());
            }
            else if (!Caux1.abierta && Caux2.abierta)
            {
                Caux2.cola.EncolarT(CPrincipal.traspasarTodo());
            }
            else if (Caux1.abierta && Caux2.abierta)
            {
                int cantidad = CPrincipal.cola.Contar();
                if (cantidad % 2 == 0)
                {
                    Caux1.cola.EncolarT(CPrincipal.traspasarMitad());
                    Caux2.cola.EncolarT(CPrincipal.traspasarTodo());
                }
                else
                {
                    Caux2.cola.EncolarT(CPrincipal.traspasarTodo());
                }
            }
        }

        void Traspasar(Caja caja)
        {
            if (!caja.cola.EstaVacia())
            {
                if (caja == caja1)
                {
                    if ((!caja2.abierta && !caja3.abierta))
                    {
                        MessageBox.Show("Error! No hay otras cajas para atender tus clientes\nAtiendelos a todos para poder cerrar");
                        throw new Exception();
                    }
                    else
                    {
                        TPSR(caja, caja2, caja3);
                    }
                }
                if (caja == caja2)
                {
                    if ((!caja1.abierta && !caja3.abierta))
                    {
                        MessageBox.Show("Error! No hay otras cajas para atender tus clientes\nAtiendelos a todos para poder cerrar");
                        throw new Exception();
                    }
                    else
                    {
                        TPSR(caja, caja1, caja3);
                    }
                }
                if (caja == caja3)
                {
                    if ((!caja2.abierta && !caja1.abierta))
                    {
                        MessageBox.Show("Error! No hay otras cajas para atender tus clientes\nAtiendelos a todos para poder cerrar");
                        throw new Exception();
                    }
                    else
                    {
                        TPSR(caja, caja2, caja1);
                    }
                }
            }
            caja.Vaciar();
            MarcarClientesEnCola();
        }

        void Cerrar(Caja caja)
        {
            try
            {
                Traspasar(caja);
            }
            catch
            {
                return;
            }
            caja.abierta = !true;
            if (caja == caja1)
            {
                BtnAbrirCaja1.Enabled = !false;
                TbPrecioC1.Enabled = !true;
                BtnCerrarCaja1.Enabled = !true;
                BtnCobrarCaja1.Enabled = false;

            }
            if (caja == caja2)
            {
                BtnAbrirCaja2.Enabled = !false;
                TbPrecioC2.Enabled = !true;
                BtnCerrarCaja2.Enabled = !true;
                BtnCobrarCaja2.Enabled = false;

            }
            if (caja == caja3)
            {
                BtnAbrirCaja3.Enabled = !false;
                TbPrecioC3.Enabled = !true;
                BtnCerrarCaja3.Enabled = !true;
                BtnCobrarCaja3.Enabled = false;
            }
            MarcarEstado();
        }

        void MarcarEstado()
        {
            LblEstadoCaja1.Text = $"({ComprobarEstado(caja1)})";
            LblEstadoCaja2.Text = $"({ComprobarEstado(caja2)})";
            LblEstadoCaja3.Text = $"({ComprobarEstado(caja3)})";
        }

        void MarcarClientesEnCola()
        {
            LblClientesEnColaCaja1.Text = $"Clientes en cola: {caja1.cola.Contar()}";
            LblClientesEnColaCaja2.Text = $"Clientes en cola: {caja2.cola.Contar()}";
            LblClientesEnColaCaja3.Text = $"Clientes en cola: {caja3.cola.Contar()}";
        }
        Cola gral = new Cola();

        void IngresarEnCaja(Caja c)
        {
            if (c.abierta == true)
            {
                gral.Encolar();
                string itemDesencolado = gral.Desencolar()?.ToString();

                if (itemDesencolado != null && int.TryParse(itemDesencolado, out int numeroCliente))
                {
                    c.cola.Encolar(numeroCliente);
                }
                else
                {
                    c.cola.Encolar(Convert.ToInt32(gral.Desencolar()));
                }
            }
            else
            {
                MessageBox.Show("La caja esta cerrada");
            }
        }

        void Ingresar()
        {
            try
            {
                if (!caja1.abierta && !caja2.abierta && !caja3.abierta)
                {
                    MessageBox.Show("No hay ninguna caja abierta en este momento.");
                    return;
                }

                Caja cajaSeleccionada = null;
                int minClientes = int.MaxValue;

                if (caja1.abierta && caja1.cola.Contar() < minClientes)
                {
                    minClientes = caja1.cola.Contar();
                    cajaSeleccionada = caja1;
                }
                if (caja2.abierta && caja2.cola.Contar() < minClientes)
                {
                    minClientes = caja2.cola.Contar();
                    cajaSeleccionada = caja2;
                }
                if (caja3.abierta && caja3.cola.Contar() < minClientes)
                {
                    minClientes = caja3.cola.Contar();
                    cajaSeleccionada = caja3;
                }

                if (cajaSeleccionada != null)
                {
                    IngresarEnCaja(cajaSeleccionada);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error inesperado: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnAbrirCaja1_Click(object sender, EventArgs e)
        {
            Abrir(caja1);
        }

        private void BtnCerrarCaja1_Click(object sender, EventArgs e)
        {
            Cerrar(caja1);
        }

        private void BtnCerrarCaja2_Click(object sender, EventArgs e)
        {
            Cerrar(caja2);
        }

        private void BtnAbrirCaja2_Click(object sender, EventArgs e)
        {
            Abrir(caja2);
        }

        private void BtnCerrarCaja3_Click(object sender, EventArgs e)
        {
            Cerrar(caja3);
        }

        private void BtnAbrirCaja3_Click(object sender, EventArgs e)
        {
            Abrir(caja3);
        }

        private void BtnIngresarCliente_Click(object sender, EventArgs e)
        {
            Ingresar();
            MarcarClientesEnCola();
        }

        void Cobrar(Caja c, TextBox tb)
        {
            if (!c.cola.EstaVacia())
            {
                int monto = int.Parse(tb.Text);
                c.recaudacion += monto;
                Total += monto;
                tb.Text = "";
                c.cola.Desencolar();
            }
            else
            {
                MessageBox.Show("Error! la caja está vacia");
                tb.Text = "";
            }
        }

        private void BtnCobrarCaja1_Click(object sender, EventArgs e)
        {
            try
            {
                Cobrar(caja1, TbPrecioC1);
            }
            catch
            {
                MessageBox.Show("Error! Ingrese un numero valido");
                TbPrecioC1.Text = "";
            }
            MarcarClientesEnCola();
        }

        void validarEmpty(TextBox tb, Button btn)
        {
            if (tb.Text == "")
            {
                btn.Enabled = false;
            }
            else
            {
                btn.Enabled = true;
            }
        }

        private void TbPrecioC1_TextChanged(object sender, EventArgs e)
        {
            validarEmpty(TbPrecioC1, BtnCobrarCaja1);
        }

        private void TbPrecioC2_TextChanged(object sender, EventArgs e)
        {
            validarEmpty(TbPrecioC2, BtnCobrarCaja2);
        }

        private void TbPrecioC3_TextChanged(object sender, EventArgs e)
        {
            validarEmpty(TbPrecioC3, BtnCobrarCaja3);
        }

        private void BtnCobrarCaja2_Click(object sender, EventArgs e)
        {
            try
            {
                Cobrar(caja2, TbPrecioC2);
            }
            catch
            {
                MessageBox.Show("Error! Ingrese un numero valido");
            }
            MarcarClientesEnCola();
            TbPrecioC3.Text = "";
        }

        void ResetearRec(Caja c1, Caja c2, Caja c3, long t)
        {
            c1.recaudacion = 0;
            c2.recaudacion = 0;
            c3.recaudacion = 0;
            t = 0;
        }

        private void BtnCobrarCaja3_Click(object sender, EventArgs e)
        {
            try
            {
                Cobrar(caja3, TbPrecioC3);
            }
            catch
            {
                MessageBox.Show("Error! Ingrese un numero valido");
            }
            MarcarClientesEnCola();
            TbPrecioC3.Text = "";
        }

        private void BtnFinalizarJornada_Click(object sender, EventArgs e)
        {
            Cerrar(caja1);
            Cerrar(caja2);
            Cerrar(caja3);

            LblImporteTotal.Text = $"Importe total por caja:\nCaja 1: ${caja1.recaudacion}\nCaja 2: ${caja2.recaudacion}\nCaja 3: ${caja3.recaudacion}\n\nTotal: ${Total}";
            ResetearRec(caja1, caja2, caja3, Total);
        }
    }
}
