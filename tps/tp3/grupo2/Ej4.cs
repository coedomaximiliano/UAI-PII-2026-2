
using System;
using System.Windows.Forms;

namespace Tp3_Ej4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtNumero1.Text);
            double b = Convert.ToDouble(txtNumero2.Text);

            txtResultado.Text = (a + b).ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El botón Restar funciona");

            double a = Convert.ToDouble(txtNumero1.Text);
            double b = Convert.ToDouble(txtNumero2.Text);

            txtResultado.Text = (a - b).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtNumero1.Text);
            double b = Convert.ToDouble(txtNumero2.Text);

            txtResultado.Text = (a * b).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtNumero1.Text);
            double b = Convert.ToDouble(txtNumero2.Text);

            if (b != 0)
                txtResultado.Text = (a / b).ToString();
            else
                MessageBox.Show("No se puede dividir por cero");
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtNumero1.Text);
            double b = Convert.ToDouble(txtNumero2.Text);

            txtResultado.Text = Math.Pow(a, b).ToString();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtNumero1.Text);

            if (a >= 0)
                txtResultado.Text = Math.Sqrt(a).ToString();
            else
                MessageBox.Show("No existe raíz real de un número negativo");
        }

        
    }
}
