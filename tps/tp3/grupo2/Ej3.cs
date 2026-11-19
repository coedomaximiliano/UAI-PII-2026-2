using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp3_Ej3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n;
            double numero, suma = 0;

            n = Convert.ToInt32(txtCantidad.Text);

            txtNumeros.Clear();

            for (int i = 1; i <= n; i++)
            {
                numero = Convert.ToDouble(
                     Microsoft.VisualBasic.Interaction.InputBox(
            "Ingrese el número " + i));

                txtNumeros.Text += numero + Environment.NewLine;

                suma += numero;
            }

            lblResultado.Text = "La suma es: " + suma;
            MessageBox.Show("La suma es: " + suma);
        }
    }
}
