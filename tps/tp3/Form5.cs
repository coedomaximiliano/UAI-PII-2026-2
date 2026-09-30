using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej5
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnPrimos_Click(object sender, EventArgs e)
        {
            lbPrimos.Items.Clear();

            if (int.TryParse(tbMin.Text, out int min) && int.TryParse(tbMax.Text, out int max))
            {
                if (min > max)
                {
                    MessageBox.Show("El número mínimo no puede ser mayor que el máximo");
                    return;
                }
                for (int i = min;i <= max;i++)
                {
                    if (esPrimo(i))
                    {
                        lbPrimos.Items.Add(i);
                    }
                }
            }
        }

        private bool esPrimo(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % 2 == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
