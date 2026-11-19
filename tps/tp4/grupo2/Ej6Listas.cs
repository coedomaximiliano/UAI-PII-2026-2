using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        ListaDoble lista = new ListaDoble();
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

            Nodo actual = lista.Primero;

            while (actual != null)
            {
                lstPersonas.Items.Add(
                    "Edad: " + actual.Edad +
                    " - Entrada: $" + Precio(actual.Edad));

                actual = actual.Siguiente;
            }

            lblTotal.Text = "Total: $" + total;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lista = new ListaDoble();
            total = 0;

            int cantidad = azar.Next(0, 51);

            for (int i = 0; i < cantidad; i++)
            {
                int edad = azar.Next(5, 61);
                lista.Agregar(edad);
                total += Precio(edad);
            }

            Mostrar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int edad = Convert.ToInt32(txtEdad.Text);

            if (edad >= 5 && edad <= 60)
            {
                lista.Agregar(edad);
                total += Precio(edad);
                Mostrar();
                txtEdad.Clear();
            }
            else
                MessageBox.Show("Edad inválida.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int pos = lstPersonas.SelectedIndex;

            if (pos >= 0)
            {
                int edad = lista.Obtener(pos).Edad;

                total -= Precio(edad);
                lista.Eliminar(pos);

                Mostrar();
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
                    total -= Precio(lista.Obtener(pos).Edad);

                    lista.Modificar(pos, edad);

                    total += Precio(edad);

                    Mostrar();
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

        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pos = lstPersonas.SelectedIndex;

            if (pos >= 0)
                txtEdad.Text = lista.Obtener(pos).Edad.ToString();
        }
    }

    public class Nodo
    {
        public int Edad;
        public Nodo Anterior;
        public Nodo Siguiente;

        public Nodo(int edad)
        {
            Edad = edad;
        }
    }

    public class ListaDoble
    {
        public Nodo Primero;
        public Nodo Ultimo;

        public void Agregar(int edad)
        {
            Nodo nuevo = new Nodo(edad);

            if (Primero == null)
            {
                Primero = Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                nuevo.Anterior = Ultimo;
                Ultimo = nuevo;
            }
        }

        public Nodo Obtener(int pos)
        {
            Nodo actual = Primero;

            for (int i = 0; i < pos; i++)
                actual = actual.Siguiente;

            return actual;
        }

        public void Eliminar(int pos)
        {
            Nodo actual = Obtener(pos);

            if (actual.Anterior != null)
                actual.Anterior.Siguiente = actual.Siguiente;
            else
                Primero = actual.Siguiente;

            if (actual.Siguiente != null)
                actual.Siguiente.Anterior = actual.Anterior;
            else
                Ultimo = actual.Anterior;
        }

        public void Modificar(int pos, int edad)
        {
            Obtener(pos).Edad = edad;
        }
    }
}
