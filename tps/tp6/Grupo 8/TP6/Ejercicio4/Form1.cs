using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Cola ColaGral = new Cola();
        Cola ColaHombres = new Cola();
        Cola ColaMujeres = new Cola();

        void Enlazar()
        {
            LbColaGral.DataSource = null;
            LbColaHombres.DataSource = null;
            LbColaMujeres.DataSource = null;

            LbColaGral.DataSource = ColaGral.Listar();
            LbColaHombres.DataSource = ColaHombres.Listar();
            LbColaMujeres.DataSource = ColaMujeres.Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Enlazar();
            RbHombre.Checked = true;
        }

        private void BtnEncolar_Click(object sender, EventArgs e)
        {
            Nadador n = new Nadador(textBox1.Text, RbHombre.Checked);
            ColaGral.Encolar(n);
            if (RbHombre.Checked)
            {
                ColaHombres.Encolar(n);
            }
            else
            {
                ColaMujeres.Encolar(n);
            }
            Enlazar();
        }

        private void BtnDesencolar_Click(object sender, EventArgs e)
        {
            Nadador n = ColaGral.Desencolar();
            if (n.EsHombre)
            {
                ColaHombres.Desencolar();
            }
            else
            {
                ColaMujeres.Desencolar();
            }
            label2.Text = n.ToString();
            Enlazar();
        }

        private void BtnVerFrente_Click(object sender, EventArgs e)
        {
            string alldata = "";
            if (ColaGral.EstaVacia()) alldata = "ListaVacía";
            else if (ColaHombres.EstaVacia()) alldata = $"Gral: {ColaGral.VerTope()}\nHombres: N/A\nMujeres: {ColaMujeres.VerTope()}";
            else if (ColaMujeres.EstaVacia()) alldata = $"Gral: {ColaGral.VerTope()}\nHombres: {ColaHombres.VerTope()}\nMujeres: N/A";

            MessageBox.Show($"{alldata}");
        }
    }
}
