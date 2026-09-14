using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Ingrese un valor en ambas entradas.");
            }
            if ((int.TryParse(textBox1.Text, out int v1)) && (int.TryParse(textBox2.Text, out int v2)))
            {
                textBox3.Text = Convert.ToString(Math.Pow(v1, v2));
            }
            else
            {
                MessageBox.Show("No se puede realizar la potencia.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Ingrese un valor en ambas entradas.");
            }
            if ((int.TryParse(textBox1.Text, out int v1)) && (int.TryParse(textBox2.Text, out int v2)))
            {
                textBox3.Text = Convert.ToString(v1 + v2);
            }
            else
            {
                MessageBox.Show("No se pueden sumar los valores.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Ingrese un valor en ambas entradas.");
            }
            if ((int.TryParse(textBox1.Text, out int v1)) && (int.TryParse(textBox2.Text, out int v2)))
            {
                textBox3.Text = Convert.ToString(v1 - v2);
            }
            else
            {
                MessageBox.Show("No se pueden restar los valores.");
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Ingrese un valor en ambas entradas.");
            }
            if ((int.TryParse(textBox1.Text, out int v1)) && (int.TryParse(textBox2.Text, out int v2)))
            {
                textBox3.Text = Convert.ToString(v1 * v2);
            }
            else
            {
                MessageBox.Show("No se pueden multiplicar estos valores.");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Ingrese un valor en ambas entradas.");
            }
            if ((int.TryParse(textBox1.Text, out int v1)) && (int.TryParse(textBox2.Text, out int v2)) && v2!=0)
            {
                textBox3.Text = Convert.ToString(v1 / v2);
            }
            else
            {
                MessageBox.Show("No se puede dividir por cero.");
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Ingrese un valor en la primer entrada.");
            }
            if (int.TryParse(textBox1.Text, out int v1) && v1>0)
            {
                textBox3.Text = Convert.ToString(Math.Sqrt(v1));
            }
            else
            {
                MessageBox.Show("No se puede hacer la raíz cuadrada de un número negativo.");
            }
        }
    }
}
