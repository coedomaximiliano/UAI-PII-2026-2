using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp3Ej7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double monto = Convert.ToDouble(txtMonto.Text);
            double tasa = Convert.ToDouble(txtTasa.Text);
            double dias = Convert.ToDouble(txtDias.Text);

            double interes = monto * tasa * dias / 36500;

            double total = monto + interes;

            dgvResultados.Rows.Clear();
            dgvResultados.Columns.Clear();

            dgvResultados.Columns.Add("Monto", "Monto");
            dgvResultados.Columns.Add("Tasa", "Tasa");
            dgvResultados.Columns.Add("Dias", "Días");
            dgvResultados.Columns.Add("Interes", "Interés");
            dgvResultados.Columns.Add("Total", "Total");

            dgvResultados.Rows.Add(
                monto,
                tasa,
                dias,
                interes,
                total
            );
        }
    }
}
