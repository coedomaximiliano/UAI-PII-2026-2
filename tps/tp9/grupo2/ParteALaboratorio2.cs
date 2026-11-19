using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarUnidades();
        }

        private void CargarUnidades()
        {
            lstUnidades.Items.Clear();

            string[] unidades = Directory.GetLogicalDrives();

            foreach (string unidad in unidades)
                lstUnidades.Items.Add(unidad);
        }

        private void lstUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUnidades.SelectedItem != null)
                txtRuta.Text = lstUnidades.SelectedItem.ToString();
        }

        private void btnContenido_Click(object sender, EventArgs e)
        {
            lstContenido.Items.Clear();

            string ruta = txtRuta.Text;

            if (!Directory.Exists(ruta))
            {
                MessageBox.Show("La ruta no existe.");
                return;
            }

            try
            {
                string[] carpetas = Directory.GetDirectories(ruta);
                string[] archivos = Directory.GetFiles(ruta);

                foreach (string carpeta in carpetas)
                {
                    lstContenido.Items.Add(
                        "Carpeta: " + Path.GetFileName(carpeta));
                }

                foreach (string archivo in archivos)
                {
                    lstContenido.Items.Add(
                        "Archivo: " + Path.GetFileName(archivo));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo acceder: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstUnidades_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {

        }

        private void lstContenido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
