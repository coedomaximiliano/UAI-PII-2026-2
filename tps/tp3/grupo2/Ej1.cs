using System;
using System.Windows.Forms;

namespace Tp3_Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            double num1, num2, suma;

            num1 = Convert.ToDouble(
                Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el primer número"));

            num2 = Convert.ToDouble(
                Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el segundo número"));

            suma = num1 + num2;

            MessageBox.Show("La suma es: " + suma);
        }

       
    }
}