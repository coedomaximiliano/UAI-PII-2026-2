using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        List<int> numeros = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            lstNumeros.Items.Clear();

            foreach (int n in numeros)
                lstNumeros.Items.Add(n);
        }

        private void IntercambiarDerecha(int numero)
        {
            if (numero >= 0 && numero < numeros.Count - 1)
            {
                int aux = numeros[numero];
                numeros[numero] = numeros[numero + 1];
                numeros[numero + 1] = aux;
                Mostrar();
            }
            else
                MessageBox.Show("No se puede intercambiar.");
        }

        private void IntercambiarIzquierda(int numero)
        {
            if (numero > 0 && numero < numeros.Count)
            {
                int aux = numeros[numero];
                numeros[numero] = numeros[numero - 1];
                numeros[numero - 1] = aux;
                Mostrar();
            }
            else
                MessageBox.Show("No se puede intercambiar.");
        }

        private void Intercambiar(int numero1, int numero2)
        {
            if (numero1 >= 0 && numero1 < numeros.Count &&
                numero2 >= 0 && numero2 < numeros.Count)
            {
                int aux = numeros[numero1];
                numeros[numero1] = numeros[numero2];
                numeros[numero2] = aux;
                Mostrar();
            }
            else
                MessageBox.Show("Posiciones inválidas.");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            numeros.Add(Convert.ToInt32(txtNumero1.Text));
            Mostrar();
            txtNumero1.Clear();
        }

        private void btnIntercambiarDerecha_Click(object sender, EventArgs e)
        {
            IntercambiarDerecha(lstNumeros.SelectedIndex);
        }

        private void btnIntercambiarIzquierda_Click(object sender, EventArgs e)
        {
            IntercambiarIzquierda(lstNumeros.SelectedIndex);
        }

        private void btnIntercambiar_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txtNumero1.Text);
            int n2 = Convert.ToInt32(txtNumero2.Text);

            Intercambiar(n1, n2);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
