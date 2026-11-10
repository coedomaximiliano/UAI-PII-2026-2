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

namespace parteB
{
    public partial class Form1 : Form
    {
        string rutaAlu = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "alumnos.txt");
        string rutaAluAux = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "alumnosAux.txt");

        string rutaNotas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "notas.txt");
        string rutaNotasAux = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "notasAux.txt");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardarAlu_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(rutaAlu, FileMode.Append);
            StreamWriter EscritorArchivo = new StreamWriter(archivo);

            string registro;

            registro = nupdAlu.Value.ToString() + ";" + txtNomAlu.Text + ";" + txtApeAlu.Text;

            EscritorArchivo.WriteLine(registro);
            EscritorArchivo.Close();
            archivo.Close();

            nupdAlu.Value = 0;
            txtNomAlu.Text = "";
            txtApeAlu.Text = "";

            nupdAlu.Focus();

            MostrarAlumnos();


        }

        private void MostrarAlumnos()
        {
            dgvAlu.Rows.Clear();

            if (File.Exists(rutaAlu))
            {
                FileStream archivo = new FileStream(rutaAlu, FileMode.Open);
                StreamReader lector = new StreamReader(archivo);

                string registro;
                string[] datos;

                while (!lector.EndOfStream)
                {
                    registro = lector.ReadLine();
                    datos = registro.Split(';');

                    dgvAlu.Rows.Add(datos[0], datos[1], datos[2]);
                }
                lector.Close();
            }
        }

        private void MostrarNotas()
        {
            dataGridView2.Rows.Clear();

            if (File.Exists(rutaNotas))
            {
                FileStream archivo = new FileStream(rutaNotas, FileMode.Open);
                StreamReader lector = new StreamReader(archivo);

                string registro;
                string[] datos;

                while (!lector.EndOfStream)
                {
                    registro = lector.ReadLine();
                    datos = registro.Split(';');

                    dataGridView2.Rows.Add(datos[0], datos[1], datos[2]);
                }
                lector.Close();
            }
        }

        private void dgvAlu_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvAlu_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(rutaAlu, FileMode.Open);
            FileStream archivoAux = new FileStream(rutaAluAux, FileMode.Create);

            StreamReader lectorArchivo = new StreamReader(archivo);
            StreamWriter EscritorArchivoAux = new StreamWriter(archivoAux);

            string[] vectorRegAux = new string[0];
            string registro;
            string dni;

            while(lectorArchivo.Peek() > -1)
            {
                registro = lectorArchivo.ReadLine();
                vectorRegAux = registro.Split(';');
                dni = vectorRegAux[0];

                if (dni != nupdAlu.Value.ToString())
                {
                    EscritorArchivoAux.WriteLine(registro);
                }
            }

            lectorArchivo.Close();
            archivo.Close();
            EscritorArchivoAux.Close();
            archivoAux.Close();
            //PISO EL ARCHIVO AORIGINAL CON EL AUX
            File.Delete(rutaAlu);
            File.Move(rutaAluAux, rutaAlu);
            txtNomAlu.Text = "";
            txtApeAlu.Text = "";
            nupdAlu.Value = 0;
            nupdAlu.Focus();
            MostrarAlumnos();
        }

        private void btnModAlu_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(rutaAlu, FileMode.Open);
            FileStream archivoAux = new FileStream(rutaAluAux, FileMode.Create);

            StreamReader lectorArchivo = new StreamReader(archivo);
            StreamWriter EscritorArchivoAux = new StreamWriter(archivoAux);

            string[] vectorRegAux = new string[0];
            string reg = "";
            string dni;

            while(lectorArchivo.Peek() > -1)
            {
                reg = lectorArchivo.ReadLine();
                vectorRegAux = reg.Split(';');
                dni = vectorRegAux[0];
                
                if(dni == nupdAlu.Value.ToString())
                {
                    reg = nupdAlu.Value.ToString() + ";" + txtNomAlu.Text + ";"+ txtApeAlu.Text;
                }
                EscritorArchivoAux.WriteLine(reg);
            }
            lectorArchivo.Close();
            archivo.Close();
            EscritorArchivoAux.Close();
            archivoAux.Close();
            //PISO EL ARCHIVO AORIGINAL CON EL AUX
            File.Delete(rutaAlu);
            File.Move(rutaAluAux, rutaAlu);
            txtNomAlu.Text = "";
            txtApeAlu.Text = "";
            nupdAlu.Value = 0;
            nupdAlu.Focus();
            MostrarAlumnos();

        }

        private void btnGuardarNota_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(rutaAlu, FileMode.Open);
            StreamReader lector = new StreamReader(archivo);

            string registro;
            string[] vectorReg;
            bool encontrado = false;

            while (!lector.EndOfStream)
            {
                registro = lector.ReadLine();
                vectorReg = registro.Split(';');

                if (vectorReg[0] == nupdNota.Value.ToString())
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado == true)
            {
                FileStream archivoNotas = new FileStream(rutaNotas, FileMode.Append);
                StreamWriter escritor = new StreamWriter(archivoNotas);

                registro = String.Format("{0};{1};{2}",
                    nupdNota.Value,
                    txtNota.Text,
                    dtpFecha.Value.ToString("dd/MM/yyyy"));

                escritor.WriteLine(registro);

                escritor.Close();
                archivoNotas.Close();

                MessageBox.Show("Nota guardada correctamente");
            }
            else
            {
                MessageBox.Show("El alumno no existe");
            }

            MostrarNotas();
        }

        private void btnModNota_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(rutaNotas, FileMode.Open);
            FileStream archivoAux = new FileStream(rutaNotasAux, FileMode.Create);

            StreamReader lectorArchivo = new StreamReader(archivo);
            StreamWriter EscritorArchivoAux = new StreamWriter(archivoAux);

            string[] vectorRegAux = new string[0];
            string reg = "";
            string dni;

            while (lectorArchivo.Peek() > -1)
            {
                reg = lectorArchivo.ReadLine();
                vectorRegAux = reg.Split(';');
                dni = vectorRegAux[0];

                if (dni == nupdNota.Value.ToString())
                {
                    reg = nupdNota.Value.ToString() + ";" + txtNota.Text + ";" + dtpFecha.Value.ToString("dd/mm/yyyy");
                }
                EscritorArchivoAux.WriteLine(reg);
            }
            lectorArchivo.Close();
            archivo.Close();
            EscritorArchivoAux.Close();
            archivoAux.Close();
            //PISO EL ARCHIVO AORIGINAL CON EL AUX
            File.Delete(rutaNotas);
            File.Move(rutaNotasAux, rutaNotas);
            txtNota.Text = "";
            nupdNota.Value = 0;
            nupdNota.Focus();
            MostrarNotas();
        }

        private void btnBorrarNota_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(rutaNotas, FileMode.Open);
            FileStream archivoAux = new FileStream(rutaNotasAux, FileMode.Create);

            StreamReader lectorArchivo = new StreamReader(archivo);
            StreamWriter EscritorArchivoAux = new StreamWriter(archivoAux);

            string[] vectorRegAux = new string[0];
            string registro;
            string dni;

            while (lectorArchivo.Peek() > -1)
            {
                registro = lectorArchivo.ReadLine();
                vectorRegAux = registro.Split(';');
                dni = vectorRegAux[0];

                if (dni != nupdNota.Value.ToString())
                {
                    EscritorArchivoAux.WriteLine(registro);
                }
            }

            lectorArchivo.Close();
            archivo.Close();
            EscritorArchivoAux.Close();
            archivoAux.Close();
            //PISO EL ARCHIVO AORIGINAL CON EL AUX
            File.Delete(rutaNotas);
            File.Move(rutaNotasAux, rutaNotas);
            txtNota.Text = "";
            nupdNota.Value = 0;
            nupdNota.Focus();
            MostrarNotas();
        }
    }
}
