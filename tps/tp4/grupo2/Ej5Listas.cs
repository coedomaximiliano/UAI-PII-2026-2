using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        ListaDoble lista = new ListaDoble();

        public Form1()
        {
            InitializeComponent();
        }

        private Paciente CrearPaciente()
        {
            return new Paciente(
                txtCodigo.Text,
                txtNombre.Text,
                txtApellido.Text,
                txtDireccion.Text,
                txtTelefono.Text
            );
        }

        private void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }

        private void Mostrar()
        {
            lstPacientes.Items.Clear();

            Nodo actual = lista.Primero;

            while (actual != null)
            {
                lstPacientes.Items.Add(
                    actual.Dato.Codigo + " - " +
                    actual.Dato.Nombre + " " +
                    actual.Dato.Apellido);

                actual = actual.Siguiente;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            lista.Agregar(CrearPaciente());
            Mostrar();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int pos = lstPacientes.SelectedIndex;

            if (pos >= 0)
            {
                lista.Eliminar(pos);
                Mostrar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int pos = lstPacientes.SelectedIndex;

            if (pos >= 0)
            {
                lista.Modificar(pos, CrearPaciente());
                Mostrar();
                Limpiar();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void lstPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pos = lstPacientes.SelectedIndex;

            if (pos >= 0)
            {
                Paciente p = lista.Obtener(pos).Dato;

                txtCodigo.Text = p.Codigo;
                txtNombre.Text = p.Nombre;
                txtApellido.Text = p.Apellido;
                txtDireccion.Text = p.Direccion;
                txtTelefono.Text = p.Telefono;
            }
        }

    }

    public class Paciente
    {
        public string Codigo, Nombre, Apellido;
        public string Direccion, Telefono;

        public Paciente(string codigo, string nombre,
            string apellido, string direccion, string telefono)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
        }
    }

    public class Nodo
    {
        public Paciente Dato;
        public Nodo Anterior;
        public Nodo Siguiente;

        public Nodo(Paciente dato)
        {
            Dato = dato;
        }
    }

    public class ListaDoble
    {
        public Nodo Primero;
        public Nodo Ultimo;

        public void Agregar(Paciente dato)
        {
            Nodo nuevo = new Nodo(dato);

            if (Primero == null)
            {
                Primero = Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                nuevo.Anterior = Ultimo;
                Ultimo = nuevo;
            }
        }

        public Nodo Obtener(int pos)
        {
            Nodo actual = Primero;

            for (int i = 0; i < pos; i++)
                actual = actual.Siguiente;

            return actual;
        }

        public void Eliminar(int pos)
        {
            Nodo actual = Obtener(pos);

            if (actual.Anterior != null)
                actual.Anterior.Siguiente = actual.Siguiente;
            else
                Primero = actual.Siguiente;

            if (actual.Siguiente != null)
                actual.Siguiente.Anterior = actual.Anterior;
            else
                Ultimo = actual.Anterior;
        }

        public void Modificar(int pos, Paciente dato)
        {
            Obtener(pos).Dato = dato;
        }
    }
}
