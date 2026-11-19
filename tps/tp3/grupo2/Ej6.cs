using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp3Ej6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtN.Text);

            int a = 0;
            int b = 1;

            lstFibonacci.Items.Clear();

            for (int i = 1; i <= n; i++)
            {
                lstFibonacci.Items.Add(a);

                int siguiente = a + b;

                a = b;
                b = siguiente;
            }
        }
    }
}
