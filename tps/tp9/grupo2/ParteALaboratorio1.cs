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

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        string archivo = Path.Combine(Application.StartupPath, "archivo.txt");

        public Form1()
        {
            InitializeComponent();
            Listar();
        }

        private void Listar()
        {
            lstListado.Items.Clear();

            if (File.Exists(archivo))
            {
                foreach (string linea in File.ReadAllLines(archivo))
                    lstListado.Items.Add(linea);
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (txtLeg.Text == "" || txtApynom.Text == "" || txtCat.Text == "")
            {
                MessageBox.Show("Completá todos los campos.");
                return;
            }

            if (File.Exists(archivo))
            {
                bool existe = File.ReadAllLines(archivo)
                    .Any(x => x.Split(';')[0] == txtLeg.Text);

                if (existe)
                {
                    MessageBox.Show("Ese legajo ya existe.");
                    return;
                }
            }

            string registro = txtLeg.Text + ";" +
                              txtApynom.Text + ";" +
                              txtCat.Text;

            File.AppendAllText(archivo, registro + Environment.NewLine);

            Limpiar();
            Listar();
            MessageBox.Show("Alumno agregado.");
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (txtLeg.Text == "")
            {
                MessageBox.Show("Ingresá el legajo.");
                return;
            }

            if (!File.Exists(archivo))
                return;

            var registros = File.ReadAllLines(archivo)
                .Where(x => x.Split(';')[0] != txtLeg.Text)
                .ToArray();

            File.WriteAllLines(archivo, registros);

            Limpiar();
            Listar();
            MessageBox.Show("Registro eliminado si existía.");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtLeg.Text == "" || txtApynom.Text == "" || txtCat.Text == "")
            {
                MessageBox.Show("Completá todos los campos.");
                return;
            }

            if (!File.Exists(archivo))
                return;

            string[] registros = File.ReadAllLines(archivo);
            bool encontrado = false;

            for (int i = 0; i < registros.Length; i++)
            {
                string[] datos = registros[i].Split(';');

                if (datos[0] == txtLeg.Text)
                {
                    registros[i] = txtLeg.Text + ";" +
                                   txtApynom.Text + ";" +
                                   txtCat.Text;
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                File.WriteAllLines(archivo, registros);
                MessageBox.Show("Registro modificado.");
            }
            else
                MessageBox.Show("No se encontró ese legajo.");

            Limpiar();
            Listar();
        }

        private void lstListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListado.SelectedItem != null)
            {
                string[] datos = lstListado.SelectedItem.ToString().Split(';');

                txtLeg.Text = datos[0];
                txtApynom.Text = datos[1];
                txtCat.Text = datos[2];
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Limpiar()
        {
            txtLeg.Clear();
            txtApynom.Clear();
            txtCat.Clear();
            txtLeg.Focus();
        }

        private void btnBaja_Click_1(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {

        }
    }
}
