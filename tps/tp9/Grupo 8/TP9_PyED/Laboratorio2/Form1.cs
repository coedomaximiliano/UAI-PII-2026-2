using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laboratorio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Unidades = Directory.GetLogicalDrives();
            int i;
            for (i = 0; i < Unidades.Length; i++)
            {
                lstUnidades.Items.Add(Unidades[i]);
            }
        }

        private void btnContenido_Click(object sender, EventArgs e)
        {
            lstContenido.Items.Clear();

            DateTime creacion;
            int i;
            string Ruta = txtRuta.Text;

            string[] carpetas;
            string[] archivos;

            if (Directory.Exists(Ruta))
            {
                carpetas = Directory.GetDirectories(Ruta);
                creacion = Directory.GetCreationTime(Ruta);
                archivos = Directory.GetFiles(Ruta);

                for (i = 0; i < carpetas.Length; i++)
                {
                    lstContenido.Items.Add("Carpeta: " + Path.GetFileName(carpetas[i]));
                }

                for (i = 0; i < archivos.Length; i++)
                {
                    lstContenido.Items.Add("Archivo: " + Path.GetFileName(archivos[i]));
                }

                lblCreacion.Text = "Fecha de creación: " + creacion.ToString("dd/MM/yyyy");
            }
            else
            {
                MessageBox.Show("La carpeta " + Ruta + " no existe", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblCreacion.Text = "";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
