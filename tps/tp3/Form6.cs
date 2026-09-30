using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej6
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        int n;
        private void tbNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbNum.Text, out n))
            {
                MessageBox.Show("Ingrese un número válido.");
            }
            if (n <= 0)
            {
                MessageBox.Show("Ingresar un número mayor a 0.");
            }
            int anterior = 0;
            int actual = 1;
            for (int i = 0; i < n; i++)
            {
                tbSerie.AppendText(anterior + " ");
                int siguiente = anterior + actual;
                anterior = actual;
                actual = siguiente;
            }
        }
    }
}
