using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cine cine = new Cine();

        private void Form1_Load(object sender, EventArgs e)
        {
            cine.Personas = new ListaPersonas();
            listBox1.DataSource = null;
            listBox1.DataSource = cine.Personas.MostrarLista();
            listBox1.DisplayMember = null;
            listBox1.DisplayMember = "ToString";
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(NudEdad.Value < 5 || NudEdad.Value > 60 || TBNombre.Text == "")
                {
                    MessageBox.Show("Error, complete los campos correctamente!");
                }
                else
                {
                    Persona p = new Persona(TBNombre.Text ,int.Parse(NudEdad.Value.ToString()));
                    cine.Personas.registrarPersona(p);
                    listBox1.DataSource = null;
                    listBox1.DataSource = cine.Personas.MostrarLista();
                    listBox1.DisplayMember = null;
                    listBox1.DisplayMember = "ToString";
                }
            }
            catch
            {
                MessageBox.Show("Error, complete los campos correctamente!");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            cine.Personas.eliminarPersona(listBox1.SelectedIndex);
            listBox1.DataSource = null;
            listBox1.DataSource = cine.Personas.MostrarLista();
            listBox1.DisplayMember = null;
            listBox1.DisplayMember = "ToString";
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona(TBNombre.Text, int.Parse(NudEdad.Value.ToString()));
            cine.Personas.ActualizarDatos(listBox1.SelectedIndex, p);
            listBox1.DataSource = null;
            listBox1.DataSource = cine.Personas.MostrarLista();
            listBox1.DisplayMember = null;
            listBox1.DisplayMember = "ToString";
        }

        private void BtnAddDespuesSelected_Click(object sender, EventArgs e)
        {
            Persona p = new Persona(TBNombre.Text, int.Parse(NudEdad.Value.ToString()));
            cine.Personas.AgregarDespuesDelSeleccionado(listBox1.SelectedIndex, p);
            listBox1.DataSource = null;
            listBox1.DataSource = cine.Personas.MostrarLista();
            listBox1.DisplayMember = null;
            listBox1.DisplayMember = "ToString";
        }

        private void BtnCalcularRec_Click(object sender, EventArgs e)
        {
            cine.CalcularRecTotal();
            label3.Text = $"Recaudación Total: ${cine.recTotal}";
        }
    }
}
