using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ_05_Listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListaPaciente lista = new ListaPaciente();

        private void ActualizarListado()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = lista.MostrarLista();
            listBox1.DisplayMember = "ToString";
        }

        private void LimpiarCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private bool HayUnoSeleccionado()
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un paciente", "UAI");
                return false;
            }
            return true;
        }

        private bool CamposValidos()
        {
            int telefono;

            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese nombre y apellido", "UAI");
                return false;
            }
            if (!int.TryParse(textBox4.Text, out telefono) || telefono <= 0)
            {
                MessageBox.Show("El teléfono debe ser un número válido", "UAI");
                return false;
            }
            return true;
        }

        private void BtnRegistrarP_Click(object sender, EventArgs e)
        {
            if (!CamposValidos()) return;

            Paciente p = new Paciente(textBox1.Text, textBox2.Text, textBox3.Text, int.Parse(textBox4.Text));
            lista.AgregarAlFinal(p);
            ActualizarListado();
            LimpiarCampos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!HayUnoSeleccionado()) return;

            lista.Eliminar(listBox1.SelectedIndex);
            ActualizarListado();
            LimpiarCampos();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!HayUnoSeleccionado()) return;
            if (!CamposValidos()) return;

            lista.Actualizar(listBox1.SelectedIndex, textBox1.Text, textBox2.Text, textBox3.Text, int.Parse(textBox4.Text));
            ActualizarListado();
            LimpiarCampos();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) return;

            Paciente p = lista.ObtenerPaciente(listBox1.SelectedIndex);
            textBox1.Text = p.Nombres;
            textBox2.Text = p.Apellidos;
            textBox3.Text = p.Dirección;
            textBox4.Text = p.Teléfono.ToString();
        }
    }
}
