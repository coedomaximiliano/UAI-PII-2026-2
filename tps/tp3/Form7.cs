using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej7
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            dgvPlazo.Columns.Add("Monto", "Monto");
            dgvPlazo.Columns.Add("Tasa", "Tasa");
            dgvPlazo.Columns.Add("Días", "Días");
            dgvPlazo.Columns.Add("Interés", "Interés");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbMonto.Text, out int monto) && int.TryParse(tbTasa.Text, out int tasa) && int.TryParse(tbDias.Text, out int dias))
            {
                float resultado = (monto * tasa * dias) / 36500;
                dgvPlazo.Rows.Add(monto, tasa, dias, resultado);

                tbMonto.Clear();
                tbTasa.Clear();
                tbDias.Clear();
            }
        }
    }
}
