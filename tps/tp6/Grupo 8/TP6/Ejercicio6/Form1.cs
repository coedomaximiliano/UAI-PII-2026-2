using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cola colaGral = new Cola();
        Cola colaPasan = new Cola();
        Cola colaColados = new Cola();
        void Enlazar()
        {
            LbColados.DataSource = null;
            LbGral.DataSource = null;
            LbPasan.DataSource = null;

            LbColados.DataSource = colaColados.Listar();
            LbGral.DataSource = colaGral.Listar();
            LbPasan.DataSource = colaPasan.Listar();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colaGral.GenerarCola();
            Enlazar();
            BtnVerColaFinal.Enabled = false;
        }

        private void BtnDesencolar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona aux = colaGral.Desencolar();
                if (aux.ConTicket) colaPasan.Encolar(aux);
                else colaColados.Encolar(aux);
                Enlazar();
                ComprobarVacia();
            }
            catch
            {
                MessageBox.Show("La cola está vacía");
            }
        }

        void ComprobarVacia()
        {
            if (colaGral.EstaVacia())
            {
                BtnVerColaFinal.Enabled = true;
                BtnDesencolar.Enabled = false;
            }
        }

        private void BtnVerColaFinal_Click(object sender, EventArgs e)
        {
            colaGral = colaPasan;
            Enlazar();
            LbColados.DataSource = null;
            LbPasan.DataSource = null;
            colaPasan.vaciar();
            colaColados.vaciar();
            LbColados.Enabled = false;
            LbPasan.Enabled = false;
            BtnVerColaFinal.Enabled = false;
        }
    }
}
