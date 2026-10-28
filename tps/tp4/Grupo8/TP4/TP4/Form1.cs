using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListaPacientes lista = new ListaPacientes();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void ActualizarListado()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = lista.ObtenerListaNormal();
            listBox1.DisplayMember = "ToString";
        }

        private void LimpiarCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void BtnRegistrarP_Click(object sender, EventArgs e)
        {
            int telefono;
            if (!int.TryParse(textBox4.Text, out telefono))
            {
                MessageBox.Show("El teléfono debe ser numérico", "UAI");
                return;
            }

            Paciente p = new Paciente(textBox1.Text, textBox2.Text, textBox3.Text, telefono);
            lista.AgregarAlPrincipio(p);
            ActualizarListado();
            LimpiarCampos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un paciente", "UAI");
                return;
            }

            Paciente seleccionado = (Paciente)listBox1.SelectedItem;
            lista.Eliminar(seleccionado.Codigo);
            ActualizarListado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un paciente", "UAI");
                return;
            }

            int telefono;
            if (!int.TryParse(textBox4.Text, out telefono))
            {
                MessageBox.Show("El teléfono debe ser numérico", "UAI");
                return;
            }

            Paciente seleccionado = (Paciente)listBox1.SelectedItem;
            lista.Actualizar(seleccionado.Codigo, textBox1.Text, textBox2.Text, textBox3.Text, telefono);
            ActualizarListado();
            LimpiarCampos();
        }

        private void BtnAgregarDspsSeleccionado_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un paciente", "UAI");
                return;
            }

            int telefono;
            if (!int.TryParse(textBox4.Text, out telefono))
            {
                MessageBox.Show("El teléfono debe ser numérico", "UAI");
                return;
            }

            Paciente seleccionado = (Paciente)listBox1.SelectedItem;
            Paciente nuevo = new Paciente(textBox1.Text, textBox2.Text, textBox3.Text, telefono);
            lista.AgregarDespuesDe(seleccionado.Codigo, nuevo);
            ActualizarListado();
            LimpiarCampos();
        }
    }
}
