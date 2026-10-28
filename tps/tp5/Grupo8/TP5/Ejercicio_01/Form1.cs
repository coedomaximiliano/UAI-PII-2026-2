using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Almacen a = new Almacen();

        private void Form1_Load(object sender, EventArgs e)
        {
            Enlazar();
        }

        void Enlazar()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = a.Listar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                a.Push(int.Parse(textBox1.Text));
                Enlazar();
            }
            catch
            {
                MessageBox.Show("Ingrese un id valido");
            }
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            IDLabel.Text = a.Pop().ToString();
            Enlazar();
        }
    }
}
