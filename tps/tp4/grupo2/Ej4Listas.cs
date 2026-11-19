using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        List<Chico> chicos = new List<Chico>();
        int turno = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private Chico CrearChico()
        {
            return new Chico(
                txtNombre.Text,
                txtApellido.Text,
                Convert.ToInt32(txtEdad.Text),
                txtDNI.Text
            );
        }

        private void Mostrar()
        {
            lstChicos.Items.Clear();

            for (int i = 0; i < chicos.Count; i++)
            {
                lstChicos.Items.Add(
                    chicos[i].Nombre + " " +
                    chicos[i].Apellido + " - Edad: " +
                    chicos[i].Edad + " - DNI: " +
                    chicos[i].DNI);
            }

            if (chicos.Count == 0)
                turno = 0;
            else
                turno %= chicos.Count;
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtDNI.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            chicos.Add(CrearChico());
            Mostrar();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int pos = lstChicos.SelectedIndex;

            if (pos >= 0)
            {
                chicos.RemoveAt(pos);
                Mostrar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int pos = lstChicos.SelectedIndex;

            if (pos >= 0)
            {
                chicos[pos] = CrearChico();
                Mostrar();
                Limpiar();
            }
        }

        private void btnAgregarDespues_Click(object sender, EventArgs e)
        {
            int pos = lstChicos.SelectedIndex;

            if (pos >= 0)
            {
                chicos.Insert(pos + 1, CrearChico());
                Mostrar();
                Limpiar();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (chicos.Count > 0)
            {
                turno = (turno + 1) % chicos.Count;

                lstChicos.SelectedIndex = turno;

                MessageBox.Show(
                    "Turno de: " +
                    chicos[turno].Nombre + " " +
                    chicos[turno].Apellido);
            }
        }

        private void lstChicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pos = lstChicos.SelectedIndex;

            if (pos >= 0)
            {
                txtNombre.Text = chicos[pos].Nombre;
                txtApellido.Text = chicos[pos].Apellido;
                txtEdad.Text = chicos[pos].Edad.ToString();
                txtDNI.Text = chicos[pos].DNI;
            }
        }
    }

    public class Chico
    {
        public string Nombre;
        public string Apellido;
        public int Edad;
        public string DNI;

        public Chico(string nombre, string apellido,
            int edad, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            DNI = dni;
        }
    }
}
