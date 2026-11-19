using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        ListaSimple<Paciente> pacientes = new ListaSimple<Paciente>();

        public Form1()
        {
            InitializeComponent();
        }

        public class Paciente
        {
            public string Codigo;
            public string Nombres;
            public string Apellido;
            public string Direccion;
            public string Telefono;

            public override string ToString()
            {
                return "Codigo: " + Codigo +
                       " | Nombre: " + Nombres +
                       " | Apellido: " + Apellido +
                       " | Direccion: " + Direccion +
                       " | Telefono: " + Telefono;
            }
        }

        private Paciente LeerPaciente()
        {
            Paciente nuevo = new Paciente();

            nuevo.Codigo = txtCodigo.Text;
            nuevo.Nombres = txtNombres.Text;
            nuevo.Apellido = txtApellido.Text;
            nuevo.Direccion = txtDireccion.Text;
            nuevo.Telefono = txtTelefono.Text;

            return nuevo;
        }

        private void Limpiar()
        {
            txtCodigo.Clear();
            txtNombres.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }

        private void MostrarPacientes()
        {
            lstPacientes.Items.Clear();

            for (int i = 0; i < pacientes.Cantidad; i++)
            {
                lstPacientes.Items.Add(
                    i + " - " + pacientes.Obtener(i));
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            pacientes.Agregar(LeerPaciente());
            MostrarPacientes();
            Limpiar();

            MessageBox.Show("Paciente registrado correctamente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int posicion;

            if (!int.TryParse(txtPosicion.Text, out posicion))
            {
                MessageBox.Show("Ingrese una posicion valida");
                return;
            }

            if (pacientes.Eliminar(posicion))
            {
                MostrarPacientes();
                MessageBox.Show("Paciente eliminado");
            }
            else
            {
                MessageBox.Show("La posicion no existe");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int posicion;

            if (!int.TryParse(txtPosicion.Text, out posicion))
            {
                MessageBox.Show("Ingrese una posicion valida");
                return;
            }

            if (pacientes.Actualizar(posicion, LeerPaciente()))
            {
                MostrarPacientes();
                Limpiar();
                MessageBox.Show("Paciente actualizado");
            }
            else
            {
                MessageBox.Show("La posicion no existe");
            }
        }

        private void btnAgregarDespues_Click(object sender, EventArgs e)
        {
            int posicion;

            if (!int.TryParse(txtPosicion.Text, out posicion))
            {
                MessageBox.Show("Ingrese una posicion valida");
                return;
            }

            if (pacientes.AgregarDespues(posicion, LeerPaciente()))
            {
                MostrarPacientes();
                Limpiar();
                MessageBox.Show("Paciente agregado despues");
            }
            else
            {
                MessageBox.Show("La posicion no existe");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarPacientes();
        }
    }
}
