using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ColaConPrioridad cola = new ColaConPrioridad();

        public void Enlazar()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = cola.Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Enlazar();
        }

        private void BtnEncolar_Click(object sender, EventArgs e)
        {
            cola.Encolar(int.Parse(NudPrioridad.Value.ToString()), TbCliente.Text);
            Enlazar();
        }

        private void BtnDesencolar_Click(object sender, EventArgs e)
        {
            LblDesencolada.Text = cola.Desencolar();
            Enlazar();
        }

        private void BtnVerFrente_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{cola.VerFrente()}");
        }
    }
}
