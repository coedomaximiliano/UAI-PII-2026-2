using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero;

            if (!int.TryParse(txtNumero.Text, out numero))
            {
                MessageBox.Show("Ingrese un numero valido");
                return;
            }

            if (numero < 0 || numero > 20)
            {
                MessageBox.Show("Ingrese un numero entre 0 y 20");
                return;
            }

            long resultado = Factorial(numero);

            lblResultado.Text = "Factorial: " + resultado;
        }

        private long Factorial(int numero)
        {
            if (numero == 0 || numero == 1)
            {
                return 1;
            }

            return numero * Factorial(numero - 1);
        }
    }
}
