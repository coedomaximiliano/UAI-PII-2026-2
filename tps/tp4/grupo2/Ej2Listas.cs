using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        List<Alumno> alumnos = new List<Alumno>();

        public Form1()
        {
            InitializeComponent();
        }

        private Alumno CrearAlumno()
        {
            return new Alumno(
                txtNombre.Text,
                txtApellido.Text,
                txtDNI.Text,
                dtpFecha.Value,
                txtDireccion.Text,
                txtTelefono.Text
            );
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }

        private void Mostrar()
        {
            lstAlumnos.Items.Clear();

            for (int i = 0; i < alumnos.Count; i++)
            {
                lstAlumnos.Items.Add(
                    alumnos[i].Nombre + " " +
                    alumnos[i].Apellido + " - DNI: " +
                    alumnos[i].DNI);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            alumnos.Add(CrearAlumno());
            Mostrar();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int pos = lstAlumnos.SelectedIndex;

            if (pos >= 0)
            {
                alumnos.RemoveAt(pos);
                Mostrar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int pos = lstAlumnos.SelectedIndex;

            if (pos >= 0)
            {
                alumnos[pos] = CrearAlumno();
                Mostrar();
                Limpiar();
            }
        }

        private void btnAgregarAntes_Click(object sender, EventArgs e)
        {
            int pos = lstAlumnos.SelectedIndex;

            if (pos >= 0)
            {
                alumnos.Insert(pos, CrearAlumno());
                Mostrar();
                Limpiar();
            }
        }

        private void btnAgregarDespues_Click(object sender, EventArgs e)
        {
            int pos = lstAlumnos.SelectedIndex;

            if (pos >= 0)
            {
                alumnos.Insert(pos + 1, CrearAlumno());
                Mostrar();
                Limpiar();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void lstAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pos = lstAlumnos.SelectedIndex;

            if (pos >= 0)
            {
                Alumno a = alumnos[pos];

                txtNombre.Text = a.Nombre;
                txtApellido.Text = a.Apellido;
                txtDNI.Text = a.DNI;
                dtpFecha.Value = a.FechaNacimiento;
                txtDireccion.Text = a.Direccion;
                txtTelefono.Text = a.Telefono;
            }
        }
    }

    public class Alumno
    {
        public string Nombre, Apellido, DNI;
        public DateTime FechaNacimiento;
        public string Direccion, Telefono;

        public Alumno(string nombre, string apellido,
            string dni, DateTime fecha, string direccion,
            string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            FechaNacimiento = fecha;
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
