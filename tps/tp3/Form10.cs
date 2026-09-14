using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej10
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();

            string[] escalas = { "Celsius", "Fahrenheit", "Kelvin", "Rankine" };
            cmbEscalaInicial.Items.AddRange(escalas);
            cmbEscalaFinal.Items.AddRange(escalas);

            cmbEscalaInicial.SelectedIndex = 0;
            cmbEscalaFinal.SelectedIndex = 1;

            dgvHistorial.ColumnCount = 4;
            dgvHistorial.Columns[0].Name = "Valor Inicial";
            dgvHistorial.Columns[1].Name = "Escala Inicial";
            dgvHistorial.Columns[2].Name = "Valor Convertido";
            dgvHistorial.Columns[3].Name = "Escala Final";

            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.AllowUserToAddRows = false; 
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(tbValor.Text, out double valorInicial))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string escalaInicial = cmbEscalaInicial.SelectedItem.ToString();
            string escalaFinal = cmbEscalaFinal.SelectedItem.ToString();

            double valorEnCelsius = ConvertirACelsius(valorInicial, escalaInicial);
            double valorFinal = ConvertirDesdeCelsius(valorEnCelsius, escalaFinal);

            dgvHistorial.Rows.Add(
                Math.Round(valorInicial, 2),
                escalaInicial,
                Math.Round(valorFinal, 2),
                escalaFinal
            );

            tbValor.Clear();
            tbValor.Focus();
        }

        private double ConvertirACelsius(double valor, string escala)
        {
            switch (escala)
            {
                case "Fahrenheit":
                    return (valor - 32) * 5.0 / 9.0;
                case "Kelvin":
                    return valor - 273.15;
                case "Rankine":
                    return (valor - 491.67) * 5.0 / 9.0;
                default:
                    return valor;
            }
        }

        private double ConvertirDesdeCelsius(double valorCelsius, string escala)
        {
            switch (escala)
            {
                case "Fahrenheit":
                    return (valorCelsius * 9.0 / 5.0) + 32;
                case "Kelvin":
                    return valorCelsius + 273.15;
                case "Rankine":
                    return (valorCelsius + 273.15) * 9.0 / 5.0;
                default:
                    return valorCelsius;
            }
        }
    }
}
