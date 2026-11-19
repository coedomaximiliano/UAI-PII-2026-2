using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp3Ej9
{
    public partial class Form1 : Form
    {
        Random azar = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(txtCantidad.Text);

            if (cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad mayor a cero");
                return;
            }

            int[] frecuencias = new int[13];

            for (int i = 1; i <= cantidad; i++)
            {
                int dado1 = azar.Next(1, 7);
                int dado2 = azar.Next(1, 7);

                int suma = dado1 + dado2;

                frecuencias[suma]++;
            }

            dgvResultados.Rows.Clear();
            dgvResultados.Columns.Clear();

            dgvResultados.AutoGenerateColumns = false;

            dgvResultados.Columns.Add("Suma", "Suma");
            dgvResultados.Columns.Add("Cantidad", "Cantidad de veces");
            dgvResultados.Columns.Add("Porcentaje", "Porcentaje");

            for (int i = 2; i <= 12; i++)
            {
                double porcentaje = frecuencias[i] * 100.0 / cantidad;

                dgvResultados.Rows.Add(
                    i,
                    frecuencias[i],
                    porcentaje.ToString("0.00") + "%"
                );
            }

            dgvResultados.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
