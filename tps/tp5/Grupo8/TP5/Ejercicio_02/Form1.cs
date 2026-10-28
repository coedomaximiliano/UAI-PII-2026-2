using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Recorrido r = new Recorrido();

        void Enlazar()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = r.Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Enlazar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(r.volviendo == true)
            {
                r.invertir();
                Enlazar();
            }
            else
            {
                MessageBox.Show("Este es el camino de ida");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (r.volviendo != true)
            {
                r.invertir();
                Enlazar();
            }
            else
            {
                MessageBox.Show("Este es el camino de vuelta");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            r.Push(textBox1.Text);
            Enlazar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = r.Pop();
            Enlazar();
        }
    }
}
