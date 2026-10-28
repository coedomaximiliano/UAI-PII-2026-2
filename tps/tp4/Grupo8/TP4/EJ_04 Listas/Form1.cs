using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ_04_Listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        listaNiños lista = new listaNiños();
        Random Azar = new Random();

        private void ActualizarPantalla()
        {
            lista.Listar(LstNinios);
            LbRonda.Text = lista.RecorrerUnaVuelta();
        }

        private void LimpiarCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            NudEdad.Value = 9;
        }

        private bool CamposValidos()
        {
            int dni;

            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese nombre y apellido", "UAI");
                return false;
            }
            if (!int.TryParse(textBox3.Text, out dni) || dni <= 0)
            {
                MessageBox.Show("El DNI debe ser un número válido", "UAI");
                return false;
            }
            return true;
        }

        private bool HayUnoSeleccionado()
        {
            if (LstNinios.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un chico de la lista", "UAI");
                return false;
            }
            return true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!CamposValidos()) return;

            int dni = int.Parse(textBox3.Text);
            if (lista.ExisteDni(dni))
            {
                MessageBox.Show("Ya hay un chico inscripto con ese DNI", "UAI");
                return;
            }

            ninio n = new ninio(textBox1.Text.Trim(), textBox2.Text.Trim(), (int)NudEdad.Value, dni);
            lista.Agregar(n);
            LimpiarCampos();
            ActualizarPantalla();
        }

        private void BtnAgregarDespues_Click(object sender, EventArgs e)
        {
            if (!HayUnoSeleccionado()) return;
            if (!CamposValidos()) return;

            int dni = int.Parse(textBox3.Text);
            if (lista.ExisteDni(dni))
            {
                MessageBox.Show("Ya hay un chico inscripto con ese DNI", "UAI");
                return;
            }

            ninio n = new ninio(textBox1.Text.Trim(), textBox2.Text.Trim(), (int)NudEdad.Value, dni);
            lista.AgregarDespues(LstNinios.SelectedIndex, n);
            LimpiarCampos();
            ActualizarPantalla();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (!HayUnoSeleccionado()) return;
            if (!CamposValidos()) return;

            int indice = LstNinios.SelectedIndex;
            int dni = int.Parse(textBox3.Text);
            ninio actual = lista.ObtenerNinio(indice);

            if (dni != actual.Dni && lista.ExisteDni(dni))
            {
                MessageBox.Show("Ya hay un chico inscripto con ese DNI", "UAI");
                return;
            }

            lista.Modificar(indice, textBox1.Text.Trim(), textBox2.Text.Trim(), (int)NudEdad.Value, dni);
            LimpiarCampos();
            ActualizarPantalla();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!HayUnoSeleccionado()) return;

            lista.Eliminar(LstNinios.SelectedIndex);
            LimpiarCampos();
            ActualizarPantalla();
        }

        private void LstNinios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstNinios.SelectedIndex < 0) return;

            ninio n = lista.ObtenerNinio(LstNinios.SelectedIndex);
            textBox1.Text = n.Nombre;
            textBox2.Text = n.Apellido;
            NudEdad.Value = n.Edad;
            textBox3.Text = n.Dni.ToString();
        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {
            if (lista.Cantidad < 2)
            {
                MessageBox.Show("Se necesitan al menos 2 chicos para jugar", "UAI");
                return;
            }

            int salto = Azar.Next(2, 8);
            ninio ganador = lista.JuegoEliminacion(salto);

            MessageBox.Show("Se contó de a " + salto + Environment.NewLine + Environment.NewLine +
                            "Eliminados, en orden:" + Environment.NewLine + lista.Eliminados, "UAI");

            LblGanador.Text = "Ganador: " + ganador.ToString();
            ActualizarPantalla();
        }
    }
}
