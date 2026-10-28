using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pila p = new Pila();
        

        void enlazar()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = p.Listar();

        }

        private void BtnPush_Click(object sender, EventArgs e)
        {
            Expediente ex = new Expediente(int.Parse(TBNum.Text), TBCar.Text, DTPFecha.Value);
            p.Push(ex);
            enlazar();
        }

        private void BtnPop_Click(object sender, EventArgs e)
        {
            LabelExpediente.Text = p.Pop();
            enlazar();            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            p.Clear();
            enlazar();
        }

        private void BtnOrderNum_Click(object sender, EventArgs e)
        {
            p.OrdenarPorNumero();
            enlazar();
        }

        private void BtnOrderFecha_Click(object sender, EventArgs e)
        {
            p.OrdenarPorFecha();
            enlazar();
        }
    }
}
