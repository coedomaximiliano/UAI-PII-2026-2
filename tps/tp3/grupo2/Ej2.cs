using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp3Ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            double num1, num2, suma;

            num1 = Convert.ToDouble(txtNumero1.Text);
            num2 = Convert.ToDouble(txtNumero2.Text);

            suma = num1 + num2;

            lblResultado.Text = "Resultado: " + suma;
        }
    }
}
