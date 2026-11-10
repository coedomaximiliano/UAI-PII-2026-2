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

namespace parteA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
            if (Directory.Exists(Ruta))
            {
                string [] carpetas = Directory.GetDirectories(Ruta);
                creacion = Directory.GetCreationTime(Ruta);
                string [] archivos = Directory.GetFiles(Ruta);

                for (i = 1; i < carpetas.Length - 1;i++)
                {
                    lstContenido.Items.Add("Carpeta: " + Path.GetFileName(carpetas[i]));
                }
                //IMPRIMO LOS ARCHIVOS
                for (i = 1; i < archivos.Length - 1; i++)
                {
                    lstContenido.Items.Add("Archivo: " + Path.GetFileName(archivos[i]));
                }
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
