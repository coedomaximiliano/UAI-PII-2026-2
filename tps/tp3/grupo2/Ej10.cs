using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp3Ej10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbEscalaInicial.Items.AddRange(
                new string[] { "Celsius", "Fahrenheit", "Kelvin", "Rankine" });

            cmbEscalaFinal.Items.AddRange(
                new string[] { "Celsius", "Fahrenheit", "Kelvin", "Rankine" });
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double cantidad = Convert.ToDouble(txtCantidad.Text);

            string inicial = cmbEscalaInicial.Text;
            string final = cmbEscalaFinal.Text;

            double celsius = 0;
            double resultado = 0;

            // Convertir la temperatura inicial a Celsius

            switch (inicial)
            {
                case "Celsius":
                    celsius = cantidad;
                    break;

                case "Fahrenheit":
                    celsius = (cantidad - 32) * 5 / 9;
                    break;

                case "Kelvin":
                    celsius = cantidad - 273.15;
                    break;

                case "Rankine":
                    celsius = (cantidad - 491.67) * 5 / 9;
                    break;
            }

            // Convertir de Celsius a la escala final

            switch (final)
            {
                case "Celsius":
                    resultado = celsius;
                    break;

                case "Fahrenheit":
                    resultado = (celsius * 9 / 5) + 32;
                    break;

                case "Kelvin":
                    resultado = celsius + 273.15;
                    break;

                case "Rankine":
                    resultado = (celsius + 273.15) * 9 / 5;
                    break;
            }

            dgvResultados.Rows.Clear();
            dgvResultados.Columns.Clear();

            dgvResultados.Columns.Add("Cantidad", "Temperatura ingresada");
            dgvResultados.Columns.Add("Inicial", "Escala inicial");
            dgvResultados.Columns.Add("Resultado", "Resultado");
            dgvResultados.Columns.Add("Final", "Escala final");

            dgvResultados.Rows.Add(
                cantidad,
                inicial,
                resultado,
                final
            );

            dgvResultados.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
