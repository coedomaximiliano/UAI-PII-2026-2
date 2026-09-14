using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbCantidad.Text.Length > 0 && tbNumeros.Text.Length > 0)
            {
                int cant = Convert.ToInt32(tbCantidad.Text);

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void tbNumeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
