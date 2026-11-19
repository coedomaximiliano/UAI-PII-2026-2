using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        List<int> personas = new List<int>();
        Random azar = new Random();
        double total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private double Precio(int edad)
        {
            if (edad < 12)
                return 2000;
            else if (edad < 18)
                return 3000;
            else
                return 5000;
        }

        private void Mostrar()
        {
            lstPersonas.Items.Clear();

            foreach (int edad in personas)
            {
                lstPersonas.Items.Add(
                    "Edad: " + edad +
                    " - Entrada: $" + Precio(edad));
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            personas.Clear();
            total = 0;

            int cantidad = azar.Next(0, 51);

            for (int i = 0; i < cantidad; i++)
            {
                int edad = azar.Next(5, 61);
                personas.Add(edad);
                total += Precio(edad);
            }

            Mostrar();
            lblTotal.Text = "Total: $" + total;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int edad = Convert.ToInt32(txtEdad.Text);

            if (edad >= 5 && edad <= 60)
            {
                personas.Add(edad);
                total += Precio(edad);
                Mostrar();
                lblTotal.Text = "Total: $" + total;
                txtEdad.Clear();
            }
            else
                MessageBox.Show("Edad inválida (mínimo 5 años).");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int pos = lstPersonas.SelectedIndex;

            if (pos >= 0)
            {
                total -= Precio(personas[pos]);
                personas.RemoveAt(pos);
                Mostrar();
                lblTotal.Text = "Total: $" + total;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int pos = lstPersonas.SelectedIndex;

            if (pos >= 0)
            {
                int edad = Convert.ToInt32(txtEdad.Text);

                if (edad >= 5 && edad <= 60)
                {
                    total -= Precio(personas[pos]);
                    personas[pos] = edad;
                    total += Precio(edad);

                    Mostrar();
                    lblTotal.Text = "Total: $" + total;
                    txtEdad.Clear();
                }
                else
                    MessageBox.Show("Edad inválida.");
            }
        }

        private void btnAgregarDespues_Click(object sender, EventArgs e)
        {
            int pos = lstPersonas.SelectedIndex;

            if (pos >= 0)
            {
                int edad = Convert.ToInt32(txtEdad.Text);

                if (edad >= 5 && edad <= 60)
                {
                    personas.Insert(pos + 1, edad);
                    total += Precio(edad);

                    Mostrar();
                    lblTotal.Text = "Total: $" + total;
                    txtEdad.Clear();
                }
                else
                    MessageBox.Show("Edad inválida.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnRecaudacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recaudación total: $" + total);
        }
    }
}
