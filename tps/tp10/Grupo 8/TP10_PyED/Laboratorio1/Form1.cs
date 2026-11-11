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

namespace Laboratorio1
{
    public partial class Form1 : Form
    {
        const string ARCHIVO = "archivo.txt";
        const string ARCHIVO_AUX = "archivoAux.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(ARCHIVO, FileMode.Append, FileAccess.Write);
            StreamWriter EscritorArchivo = new StreamWriter(archivo);

            string reg;
            reg = String.Format("{0};{1};{2}", txtLeg.Text, txtApellYNom.Text, txtCat.Text);

            EscritorArchivo.WriteLine(reg);

            EscritorArchivo.Close();
            archivo.Close();

            txtLeg.Text = "";
            txtApellYNom.Text = "";
            txtCat.Text = "";
            txtLeg.Focus();
            listar();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(ARCHIVO, FileMode.OpenOrCreate, FileAccess.Read);
            FileStream archivoAux = new FileStream(ARCHIVO_AUX, FileMode.Create, FileAccess.Write);

            StreamReader LectorArchivo = new StreamReader(archivo);
            StreamWriter EscritorArchivoAux = new StreamWriter(archivoAux);

            String[] VectorRegAux = new String[0];
            string reg;
            string legajo;

            while (LectorArchivo.Peek() > -1)
            {
                reg = LectorArchivo.ReadLine();
                VectorRegAux = reg.Split(';');
                legajo = VectorRegAux[0];

                if (legajo != txtLeg.Text)
                {
                    EscritorArchivoAux.WriteLine(reg);
                }
            }

            LectorArchivo.Close();
            archivo.Close();
            EscritorArchivoAux.Close();
            archivoAux.Close();

            File.Delete(ARCHIVO);
            File.Move(ARCHIVO_AUX, ARCHIVO);

            txtLeg.Text = "";
            txtApellYNom.Text = "";
            txtCat.Text = "";
            txtLeg.Focus();
            listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(ARCHIVO, FileMode.OpenOrCreate, FileAccess.Read);
            FileStream archivoAux = new FileStream(ARCHIVO_AUX, FileMode.Create, FileAccess.Write);

            StreamReader LectorArchivo = new StreamReader(archivo);
            StreamWriter EscritorArchivoAux = new StreamWriter(archivoAux);

            String[] VectorRegAux = new String[0];
            string reg;
            string legajo;

            while (LectorArchivo.Peek() > -1)
            {
                reg = LectorArchivo.ReadLine();
                VectorRegAux = reg.Split(';');
                legajo = VectorRegAux[0];

                if (legajo == txtLeg.Text)
                {
                    reg = String.Format("{0};{1};{2}", txtLeg.Text, txtApellYNom.Text, txtCat.Text);
                }

                EscritorArchivoAux.WriteLine(reg);
            }

            LectorArchivo.Close();
            archivo.Close();
            EscritorArchivoAux.Close();
            archivoAux.Close();

            File.Delete(ARCHIVO);
            File.Move(ARCHIVO_AUX, ARCHIVO);

            txtLeg.Text = "";
            txtApellYNom.Text = "";
            txtCat.Text = "";
            txtLeg.Focus();
            listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listar()
        {
            lstListado.Items.Clear();

            if (!File.Exists(ARCHIVO))
            {
                return;
            }

            FileStream archivo = new FileStream(ARCHIVO, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader LectorArchivo = new StreamReader(archivo);

            string reg;

            while (LectorArchivo.Peek() > -1)
            {
                reg = LectorArchivo.ReadLine();
                lstListado.Items.Add(reg);
            }

            LectorArchivo.Close();
            archivo.Close();
        }

        private void lstListado_Click(object sender, EventArgs e)
        {
            if (lstListado.SelectedItem != null)
            {
                string seleccionado = lstListado.SelectedItem.ToString();
                string[] vectorLista = new String[0];
                vectorLista = seleccionado.Split(';');

                txtLeg.Text = vectorLista[0];
                txtApellYNom.Text = vectorLista[1];
                txtCat.Text = vectorLista[2];
            }
        }
    }
}
