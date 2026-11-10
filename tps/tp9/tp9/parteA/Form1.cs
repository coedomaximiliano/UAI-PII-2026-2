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

namespace parteA
{
    public partial class Form1 : Form
    {
        string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archivo.txt");

        string rutaAux = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
          "archivoAux.txt"
);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(ruta, FileMode.Append);
            StreamWriter EscritorArchivo = new StreamWriter(archivo);

            string reg;

            reg = txtLegajo.Text + ";" + txtApeNom.Text + ";" + txtCat.Text;

            reg = String.Format("{0};{1};{2}", txtLegajo.Text, txtApeNom.Text, txtCat.Text);

            EscritorArchivo.WriteLine(reg);

            EscritorArchivo.Close();

            archivo.Close();

            txtLegajo.Text = "";
            txtApeNom.Text = "";
            txtCat.Text = "";

            txtLegajo.Focus();

            listar();
        }

        private void listar()
        {
            listListado.Items.Clear();

            if (File.Exists(ruta))
            {
                using (StreamReader lector = new StreamReader(ruta))
                {
                    ListarRecursivo(lector);
                } ;
            }
        }

        public void ListarRecursivo(StreamReader lector)
        {
            if (lector.EndOfStream) return;

            string reg = lector.ReadLine();
            listListado.Items.Add(reg);

            ListarRecursivo(lector);

        }


        private void btnBaja_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(ruta,FileMode.Open);
            FileStream archivoAux = new FileStream(rutaAux, FileMode.Create);

            StreamReader lectorArchivo = new StreamReader(archivo);
            StreamWriter EscritorArchivoAux = new StreamWriter(archivoAux);

            string[] vectorRegAux = new string[0];
            string reg;
            string legajo;  

            while(lectorArchivo.Peek() > -1) 
            {
                reg = lectorArchivo.ReadLine();

                vectorRegAux = reg.Split(';');
                legajo = vectorRegAux[0];

                if(legajo != txtLegajo.Text)
                {
                    EscritorArchivoAux.WriteLine(reg);
                }
            }

            //Cierro archivos

            lectorArchivo.Close();
            archivo.Close();
            EscritorArchivoAux.Close();
            archivoAux.Close();
            //PISO EL ARCHIVO AORIGINAL CON EL AUX
            File.Delete(ruta);
            File.Move(rutaAux, ruta);
            txtLegajo.Text = "";
            txtApeNom.Text = "";
            txtCat.Text = "";
            txtLegajo.Focus();
            listar();

        }

        private void btnModificación_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(ruta, FileMode.Open);
            FileStream archivoAux = new FileStream(rutaAux, FileMode.Create);

            StreamReader LectorArchivo = new StreamReader(archivo);
            StreamWriter EscritorArchivoAux = new StreamWriter(archivoAux);

            string[] vectorRegAux = new string[0];
            string reg = "";
            string legajo;

            while (LectorArchivo.Peek() > -1)
            {
                reg = LectorArchivo.ReadLine();
                vectorRegAux = reg.Split(';');
                legajo = vectorRegAux[0];

                if (legajo == txtLegajo.Text)
                {
                    reg = string.Format("{0};{1},{2}", txtLegajo.Text, txtApeNom.Text, txtCat.Text);
                }
                EscritorArchivoAux.WriteLine(reg);
            }
            LectorArchivo.Close();
            archivo.Close();
            EscritorArchivoAux.Close();
            archivoAux.Close();
            //PISO EL ARCHIVO AORIGINAL CON EL AUX
            File.Delete(ruta);
            File.Move(rutaAux, ruta);
            txtLegajo.Text = "";
            txtApeNom.Text = "";
            txtCat.Text = "";
            txtLegajo.Focus();
            listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listListado_Click(object sender, EventArgs e)
        {
            if(listListado.SelectedItems != null)
            {
                string seleccionado = listListado.SelectedItem.ToString();
                string [] vectorLista = new string[0];
                vectorLista = seleccionado.Split(';');
                txtLegajo.Text = vectorLista[0];
                txtApeNom.Text = vectorLista[1];
                txtCat.Text = vectorLista[2];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
