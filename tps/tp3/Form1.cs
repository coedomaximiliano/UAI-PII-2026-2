using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                //int v1 = Convert.ToInt32(textBox1.Text);
                //int v2 = Convert.ToInt32(textBox2.Text);
                if ((int.TryParse(textBox1.Text, out int v1) && (int.TryParse(textBox2.Text, out int v2))))
                {
                    MessageBox.Show($"La suma de los valores es {v1 + v2}");
                }
                else
                {
                    MessageBox.Show("No se pueden sumar los valores.");
                }
            }
        }
    }
}
