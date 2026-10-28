using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ_07_Listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListaNumeros lista = new ListaNumeros();

        private void ActualizarListado()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = lista.MostrarLista();
            listBox1.DisplayMember = "ToString";
        }

        private void LimpiarCampos()
        {
            TBNumero1.Text = "";
            TBNumero2.Text = "";
        }

        private bool HayUnoSeleccionado()
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un número de la lista", "UAI");
                return false;
            }
            return true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            int numero;
            if (!int.TryParse(TBNumero1.Text, out numero))
            {
                MessageBox.Show("Ingrese un número válido", "UAI");
                return;
            }
            if (lista.ExisteNumero(numero))
            {
                MessageBox.Show("El número ya está en la lista", "UAI");
                return;
            }

            lista.AgregarAlFinal(numero);
            ActualizarListado();
            LimpiarCampos();
        }

        private void BtnIntercambiarDerecha_Click(object sender, EventArgs e)
        {
            if (!HayUnoSeleccionado()) return;

            lista.IntercambiarDerecha(lista.ObtenerNumero(listBox1.SelectedIndex));
            ActualizarListado();
        }

        private void BtnIntercambiarIzquierda_Click(object sender, EventArgs e)
        {
            if (!HayUnoSeleccionado()) return;

            lista.IntercambiarIzquierda(lista.ObtenerNumero(listBox1.SelectedIndex));
            ActualizarListado();
        }

        private void BtnIntercambiar_Click(object sender, EventArgs e)
        {
            int numero1, numero2;

            if (!int.TryParse(TBNumero1.Text, out numero1) || !int.TryParse(TBNumero2.Text, out numero2))
            {
                MessageBox.Show("Ingrese los dos números", "UAI");
                return;
            }

            lista.Intercambiar(numero1, numero2);
            ActualizarListado();
            LimpiarCampos();
        }
    }
}
