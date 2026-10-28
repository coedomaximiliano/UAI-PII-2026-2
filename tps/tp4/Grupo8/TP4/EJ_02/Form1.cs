using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListaAlumnos lista = new ListaAlumnos();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno a = new Alumno(TBNombre.Text, TBApellido.Text, int.Parse(TBDni.Text), DTPFechNac.Value, TBDireccion.Text, int.Parse(TBTelefono.Text));
                lista.RegistarAlumno(a);
                listBox1.DataSource = null;
                listBox1.DataSource = lista.MostrarLista();
                listBox1.DisplayMember = null;
                listBox1.DisplayMember = "ToString";

                TBNombre.Text = "";
                TBApellido.Text = "";
                TBDni.Text = "";
                DTPFechNac.Value = DateTime.Now;
                TBTelefono.Text = "";
                TBDireccion.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Complete todos los campos!");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            lista.EiminarAlumnoSeleccionado(listBox1.SelectedIndex);
            listBox1.DataSource = null;
            listBox1.DataSource = lista.MostrarLista();
            listBox1.DisplayMember = null;
            listBox1.DisplayMember = "ToString";
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno a = new Alumno(TBNombre.Text, TBApellido.Text, int.Parse(TBDni.Text), DTPFechNac.Value, TBDireccion.Text, int.Parse(TBTelefono.Text));
                lista.ActualizarAlumno(listBox1.SelectedIndex, a);
                listBox1.DataSource = null;
                listBox1.DataSource = lista.MostrarLista();
                listBox1.DisplayMember = null;
                listBox1.DisplayMember = "ToString";

                TBNombre.Text = "";
                TBApellido.Text = "";
                TBDni.Text = "";
                DTPFechNac.Value = DateTime.Now;
                TBTelefono.Text = "";
                TBDireccion.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Complete todos los campos!");
            }
        }

        private void BtnAddDespues_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno a = new Alumno(TBNombre.Text, TBApellido.Text, int.Parse(TBDni.Text), DTPFechNac.Value, TBDireccion.Text, int.Parse(TBTelefono.Text));
                lista.AgregarDespuesDelSeleccionado(listBox1.SelectedIndex, a);
                listBox1.DataSource = null;
                listBox1.DataSource = lista.MostrarLista();
                listBox1.DisplayMember = null;
                listBox1.DisplayMember = "ToString";

                TBNombre.Text = "";
                TBApellido.Text = "";
                TBDni.Text = "";
                DTPFechNac.Value = DateTime.Now;
                TBTelefono.Text = "";
                TBDireccion.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Complete todos los campos!");
            }
        }

        private void BtnAddAntes_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno a = new Alumno(TBNombre.Text, TBApellido.Text, int.Parse(TBDni.Text), DTPFechNac.Value, TBDireccion.Text, int.Parse(TBTelefono.Text));
                lista.AgregarAntesDelSeleccionado(listBox1.SelectedIndex, a);
                listBox1.DataSource = null;
                listBox1.DataSource = lista.MostrarLista();
                listBox1.DisplayMember = null;
                listBox1.DisplayMember = "ToString";

                TBNombre.Text = "";
                TBApellido.Text = "";
                TBDni.Text = "";
                DTPFechNac.Value = DateTime.Now;
                TBTelefono.Text = "";
                TBDireccion.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Complete todos los campos!");
            }
        }
    }
}
