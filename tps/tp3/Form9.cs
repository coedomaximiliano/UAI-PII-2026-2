using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej9
{
    public partial class Form9 : Form
    {
        Random rdm1 = new Random();
        int[] cantidades = new int[13];
        int totalTiradas = 0;
        public Form9()
        {
            InitializeComponent();
            dgvDados.Columns.Add("Números","Números");
            dgvDados.Columns.Add("Cantidad", "Cantidad");
            dgvDados.Columns.Add("Porcentaje", "Porcentaje");

            for (int i = 2; i < 13; i++)
            {
                dgvDados.Rows.Add(i, 0, "0%");
            }
        }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            lblDado1.Text = "El número del dado es: ";
            int dado1 = rdm1.Next(1, 7);
            lblDado1.Text += dado1;

            lblDado2.Text = "El número del dado es: ";
            //Random rdm2 = new Random();
            int dado2 = rdm1.Next(1, 7);
            lblDado2.Text += dado2;

            int suma = dado1 + dado2;
            totalTiradas++;
            cantidades[suma]++;
            for (int i = 2; i <= 12; i++)
            {
                double porcentaje = (double)cantidades[i] / totalTiradas * 100;

                dgvDados.Rows[i - 2].Cells[1].Value = cantidades[i];
                dgvDados.Rows[i - 2].Cells[2].Value = porcentaje.ToString("0.00") + "%";
            }
        }
    }
}
