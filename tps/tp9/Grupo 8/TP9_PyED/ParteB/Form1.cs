using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParteB
{
    public partial class Form1 : Form
    {
        GestorAlumnos gestorAlumnos = new GestorAlumnos();
        GestorNotas gestorNotas = new GestorNotas();

        public Form1()
        {
            InitializeComponent();
            LlenarGrillaAlumnos();
            LlenarGrillaNotas();
        }

        private void LlenarGrillaAlumnos()
        {
            this.grillaAlumnos.DataSource = null;
            this.grillaAlumnos.DataSource = gestorAlumnos.Lista();
        }

        private void cmdGuardarAlumno_Click(object sender, EventArgs e)
        {
            if (txtNombreS.Text == "" || txtApellidoS.Text == "")
            {
                MessageBox.Show("Complete nombre y apellido", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Alumno alumno = new Alumno((long)this.numDniAlumno.Value)
            {
                Apellido = this.txtApellidoS.Text,
                Nombre = this.txtNombreS.Text
            };

            if (gestorAlumnos.Alta(alumno))
            {
                LimpiarPanelAlumnos();
                LlenarGrillaAlumnos();
            }
            else
            {
                MessageBox.Show("Ya existe un alumno con ese DNI", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdModifAlumno_Click(object sender, EventArgs e)
        {
            if (grillaAlumnos.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione un alumno en la grilla", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNombreS.Text == "" || txtApellidoS.Text == "")
            {
                MessageBox.Show("Complete nombre y apellido", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Alumno seleccionado = (Alumno)grillaAlumnos.SelectedRows[0].DataBoundItem;

            Alumno conDatosNuevos = new Alumno((long)this.numDniAlumno.Value)
            {
                Apellido = this.txtApellidoS.Text,
                Nombre = this.txtNombreS.Text
            };

            if (gestorAlumnos.Modificar(seleccionado.DNI, conDatosNuevos))
            {
                LimpiarPanelAlumnos();
                LlenarGrillaAlumnos();
                LlenarGrillaNotas();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el alumno (¿el nuevo DNI ya existe?)", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdBorrarAlumno_Click(object sender, EventArgs e)
        {
            if (grillaAlumnos.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione un alumno en la grilla", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Alumno seleccionado = (Alumno)grillaAlumnos.SelectedRows[0].DataBoundItem;

            if (MessageBox.Show("¿Confirma la baja del alumno " + seleccionado + "?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gestorAlumnos.Baja(seleccionado.DNI);

                LimpiarPanelAlumnos();
                LlenarGrillaAlumnos();
                LlenarGrillaNotas();
            }
        }

        private void grillaAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            if (grillaAlumnos.SelectedRows.Count == 1)
            {
                Alumno seleccionado = (Alumno)grillaAlumnos.SelectedRows[0].DataBoundItem;

                numDniAlumno.Value = seleccionado.DNI;
                txtNombreS.Text = seleccionado.Nombre;
                txtApellidoS.Text = seleccionado.Apellido;
            }
        }

        private void LimpiarPanelAlumnos()
        {
            numDniAlumno.Value = 0;
            txtNombreS.Text = "";
            txtApellidoS.Text = "";
        }

        private void LlenarGrillaNotas()
        {
            this.grillaNotas.DataSource = null;
            this.grillaNotas.DataSource = gestorNotas.Lista();
        }

        private void cmdGuardarNota_Click(object sender, EventArgs e)
        {
            Alumno alumnoAsociado = gestorAlumnos.Buscar((long)this.numDniNota.Value);

            if (alumnoAsociado == null)
            {
                MessageBox.Show("No existe un alumno con ese DNI. Debe ser un alumno de la lista.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Nota nota = new Nota((long)this.numDniNota.Value, (int)this.numNota.Value, this.dtpFecha.Value.Date);

            if (gestorNotas.Alta(nota, gestorAlumnos))
            {
                LlenarGrillaNotas();
            }
            else
            {
                MessageBox.Show("Ya existe una nota de ese alumno en esa fecha", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdModifNota_Click(object sender, EventArgs e)
        {
            if (grillaNotas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una nota en la grilla", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Nota seleccionada = (Nota)grillaNotas.SelectedRows[0].DataBoundItem;

            Nota conDatosNuevos = new Nota((long)this.numDniNota.Value, (int)this.numNota.Value, this.dtpFecha.Value.Date);

            if (gestorNotas.Modificar(seleccionada.DNI, seleccionada.Fecha, conDatosNuevos, gestorAlumnos))
            {
                LlenarGrillaNotas();
            }
            else
            {
                MessageBox.Show("No se pudo modificar la nota (¿el nuevo dni+fecha ya existe? ¿existe el alumno?)", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdBorrarNota_Click(object sender, EventArgs e)
        {
            if (grillaNotas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una nota en la grilla", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Nota seleccionada = (Nota)grillaNotas.SelectedRows[0].DataBoundItem;

            if (MessageBox.Show("¿Confirma la baja de la nota " + seleccionada + "?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gestorNotas.Baja(seleccionada.DNI, seleccionada.Fecha);
                LlenarGrillaNotas();
            }
        }

        private void grillaNotas_SelectionChanged(object sender, EventArgs e)
        {
            if (grillaNotas.SelectedRows.Count == 1)
            {
                Nota seleccionada = (Nota)grillaNotas.SelectedRows[0].DataBoundItem;

                numDniNota.Value = seleccionada.DNI;
                numNota.Value = seleccionada.Valor;
                dtpFecha.Value = seleccionada.Fecha;
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
