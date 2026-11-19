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

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        string archivoAlumnos =
            Path.Combine(Application.StartupPath, "alumnos.txt");

        string archivoNotas =
            Path.Combine(Application.StartupPath, "notas.txt");

        public Form1()
        {
            InitializeComponent();

            dgvAlumnos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvNotas.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            nudNota.Minimum = 1;
            nudNota.Maximum = 10;

            CargarAlumnos();
            CargarNotas();
        }

        // ---------------- ALUMNOS ----------------

        private void CargarAlumnos()
        {
            dgvAlumnos.Rows.Clear();
            dgvAlumnos.Columns.Clear();

            dgvAlumnos.Columns.Add("DNI", "DNI");
            dgvAlumnos.Columns.Add("Nombre", "Nombre");
            dgvAlumnos.Columns.Add("Apellido", "Apellido");

            if (!File.Exists(archivoAlumnos))
                return;

            foreach (string linea in File.ReadAllLines(archivoAlumnos))
            {
                if (linea.Trim() == "") continue;

                string[] d = linea.Split(';');

                dgvAlumnos.Rows.Add(d[0], d[1], d[2]);
            }
        }

        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "" || txtNombre.Text == "" ||
                txtApellido.Text == "")
            {
                MessageBox.Show("Completá todos los campos.");
                return;
            }

            if (File.Exists(archivoAlumnos))
            {
                bool existe = File.ReadAllLines(archivoAlumnos)
                    .Any(x => x.Split(';')[0] == txtDni.Text);

                if (existe)
                {
                    MessageBox.Show("Ese DNI ya está registrado.");
                    return;
                }
            }

            string registro = txtDni.Text + ";" +
                              txtNombre.Text + ";" +
                              txtApellido.Text;

            File.AppendAllText(archivoAlumnos,
                registro + Environment.NewLine);

            LimpiarAlumno();
            CargarAlumnos();

            MessageBox.Show("Alumno guardado.");
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            if (!File.Exists(archivoAlumnos))
                return;

            string[] registros = File.ReadAllLines(archivoAlumnos);
            bool encontrado = false;

            for (int i = 0; i < registros.Length; i++)
            {
                string[] d = registros[i].Split(';');

                if (d[0] == txtDni.Text)
                {
                    registros[i] = txtDni.Text + ";" +
                                   txtNombre.Text + ";" +
                                   txtApellido.Text;

                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                File.WriteAllLines(archivoAlumnos, registros);
                MessageBox.Show("Alumno modificado.");
            }
            else
                MessageBox.Show("No se encontró el alumno.");

            LimpiarAlumno();
            CargarAlumnos();
        }

        private void btnBorrarAlumno_Click(object sender, EventArgs e)
        {
            if (!File.Exists(archivoAlumnos))
                return;

            string dni = txtDni.Text;

            string[] registros = File.ReadAllLines(archivoAlumnos)
                .Where(x => x.Split(';')[0] != dni)
                .ToArray();

            File.WriteAllLines(archivoAlumnos, registros);

            // También borrar sus notas
            if (File.Exists(archivoNotas))
            {
                string[] notas = File.ReadAllLines(archivoNotas)
                    .Where(x => x.Split(';')[0] != dni)
                    .ToArray();

                File.WriteAllLines(archivoNotas, notas);
            }

            LimpiarAlumno();
            CargarAlumnos();
            CargarNotas();

            MessageBox.Show("Alumno eliminado.");
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtDni.Text =
                    dgvAlumnos.Rows[e.RowIndex].Cells[0].Value.ToString();

                txtNombre.Text =
                    dgvAlumnos.Rows[e.RowIndex].Cells[1].Value.ToString();

                txtApellido.Text =
                    dgvAlumnos.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void LimpiarAlumno()
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
        }

        // ---------------- NOTAS ----------------

        private void CargarNotas()
        {
            dgvNotas.Rows.Clear();
            dgvNotas.Columns.Clear();

            dgvNotas.Columns.Add("DNI", "DNI");
            dgvNotas.Columns.Add("Nota", "Nota");
            dgvNotas.Columns.Add("Fecha", "Fecha");

            if (!File.Exists(archivoNotas))
                return;

            foreach (string linea in File.ReadAllLines(archivoNotas))
            {
                if (linea.Trim() == "") continue;

                string[] d = linea.Split(';');

                dgvNotas.Rows.Add(d[0], d[1], d[2]);
            }
        }

        private void btnGuardarNota_Click(object sender, EventArgs e)
        {
            if (txtDniNota.Text == "")
            {
                MessageBox.Show("Ingresá el DNI del alumno.");
                return;
            }

            bool existeAlumno = File.Exists(archivoAlumnos) &&
                File.ReadAllLines(archivoAlumnos)
                .Any(x => x.Split(';')[0] == txtDniNota.Text);

            if (!existeAlumno)
            {
                MessageBox.Show("No existe un alumno con ese DNI.");
                return;
            }

            string registro = txtDniNota.Text + ";" +
                nudNota.Value + ";" +
                dtpFecha.Value.ToString("dd/MM/yyyy");

            File.AppendAllText(archivoNotas,
                registro + Environment.NewLine);

            CargarNotas();

            MessageBox.Show("Nota guardada.");
        }

        private void btnModificarNota_Click(object sender, EventArgs e)
        {
            if (!File.Exists(archivoNotas))
                return;

            if (dgvNotas.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná una nota.");
                return;
            }

            string dniOriginal =
                dgvNotas.CurrentRow.Cells[0].Value.ToString();

            string notaOriginal =
                dgvNotas.CurrentRow.Cells[1].Value.ToString();

            string fechaOriginal =
                dgvNotas.CurrentRow.Cells[2].Value.ToString();

            string[] registros = File.ReadAllLines(archivoNotas);
            bool encontrado = false;

            for (int i = 0; i < registros.Length; i++)
            {
                string[] d = registros[i].Split(';');

                if (d[0] == dniOriginal &&
                    d[1] == notaOriginal &&
                    d[2] == fechaOriginal)
                {
                    registros[i] = txtDniNota.Text + ";" +
                        nudNota.Value + ";" +
                        dtpFecha.Value.ToString("dd/MM/yyyy");

                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                File.WriteAllLines(archivoNotas, registros);
                MessageBox.Show("Nota modificada.");
            }

            CargarNotas();
        }

        private void btnBorrarNota_Click(object sender, EventArgs e)
        {
            if (!File.Exists(archivoNotas) ||
                dgvNotas.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná una nota.");
                return;
            }

            string dni = dgvNotas.CurrentRow.Cells[0].Value.ToString();
            string nota = dgvNotas.CurrentRow.Cells[1].Value.ToString();
            string fecha = dgvNotas.CurrentRow.Cells[2].Value.ToString();

            string[] registros = File.ReadAllLines(archivoNotas)
                .Where(x =>
                {
                    string[] d = x.Split(';');

                    return !(d[0] == dni &&
                             d[1] == nota &&
                             d[2] == fecha);
                })
                .ToArray();

            File.WriteAllLines(archivoNotas, registros);

            CargarNotas();
            MessageBox.Show("Nota eliminada.");
        }

        private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtDniNota.Text =
                    dgvNotas.Rows[e.RowIndex].Cells[0].Value.ToString();

                nudNota.Value = Convert.ToDecimal(
                    dgvNotas.Rows[e.RowIndex].Cells[1].Value);

                dtpFecha.Value = DateTime.Parse(
                    dgvNotas.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
