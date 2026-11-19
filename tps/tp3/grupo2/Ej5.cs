using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp3Ej5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int minimo = Convert.ToInt32(txtMinimo.Text);
            int maximo = Convert.ToInt32(txtMaximo.Text);

            lstPrimos.Items.Clear();

            for (int num = minimo; num <= maximo; num++)
            {
                int divisores = 0;

                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        divisores++;
                    }
                }

                if (divisores == 2)
                {
                    lstPrimos.Items.Add(num);
                }
            }
        }
    }
}
