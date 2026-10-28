using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ_02
{
    internal class ListaAlumnos
    {
        public NodoAlumno NodoInicial = null;

        public void RegistarAlumno(Alumno a)
        {
            NodoAlumno nodo = new NodoAlumno();
            nodo.alumno = a;

            if (NodoInicial == null)
            {
                NodoInicial = nodo;
            }
            else
            {
                nodo.Siguiente = NodoInicial;
                NodoInicial = nodo;
            }
        }

        public void EiminarAlumnoSeleccionado(int indice)
        {
            if (NodoInicial == null || indice < 0) return;

            if (indice == 0)
            {
                NodoInicial = NodoInicial.Siguiente;
                return;
            }

            NodoAlumno aux = NodoInicial;
            int i = 0;
            while (i < indice - 1)
            {
                if (aux.Siguiente == null)
                {
                    MessageBox.Show("El elemento a borrar está fuera de rango");
                    return;
                }

                aux = aux.Siguiente;
                i++;
            }
            if (aux.Siguiente != null)
            {
                aux.Siguiente = aux.Siguiente.Siguiente;
            }
            else
            {
                MessageBox.Show("El elemento a borrar está fuera de rango");
            }
        }

        public void ActualizarAlumno(int indice, Alumno a)
        {
            if (NodoInicial == null || indice < 0) return;

            if (indice == 0)
            {
                NodoInicial.alumno = a;
                return;
            }

            NodoAlumno aux = NodoInicial;
            int i = 0;
            while (i < indice - 1)
            {
                if (aux.Siguiente == null)
                {
                    MessageBox.Show("El elemento a modificar está fuera de rango");
                    return;
                }

                aux = aux.Siguiente;
                i++;
            }
            if (aux.Siguiente != null)
            {
                aux.Siguiente.alumno = a;
            }
            else
            {
                MessageBox.Show("El elemento a modificar está fuera de rango");
            }
        }

        public void AgregarDespuesDelSeleccionado(int indice, Alumno a)
        {
            if (indice < 0) return;

            if (NodoInicial == null)
            {
                NodoInicial = new NodoAlumno();
                NodoInicial.alumno = a;
                return;
            }

            int i = 0;
            NodoAlumno aux = NodoInicial;

            while (i < indice)
            {
                if (aux.Siguiente == null)
                {
                    MessageBox.Show("");
                    return;
                }

                aux = aux.Siguiente;
                i++;
            }
            if (aux != null)
            {
                NodoAlumno nuevo = new NodoAlumno();
                nuevo.alumno = a;
                nuevo.Siguiente = aux.Siguiente;
                aux.Siguiente = nuevo;

            }

        }

        public void AgregarAntesDelSeleccionado(int indice, Alumno a)
        {
            if (indice < 0) return;

            if (NodoInicial == null || indice == 0)
            {
                RegistarAlumno(a);
                return;
            }

            int i = 0;
            NodoAlumno aux = NodoInicial;

            while (i < indice - 1)
            {
                if (aux.Siguiente == null)
                {
                    MessageBox.Show("");
                    return;
                }

                aux = aux.Siguiente;
                i++;
            }
            if (aux.Siguiente != null)
            {
                NodoAlumno nuevo = new NodoAlumno();
                nuevo.alumno = a;
                nuevo.Siguiente = aux.Siguiente;
                aux.Siguiente = nuevo;

            }
        }

        public List<Alumno> MostrarLista()
        {
            List<Alumno> ListaAl = new List<Alumno>();
            NodoAlumno actual = NodoInicial;
            while (actual != null)
            {
                ListaAl.Add(actual.alumno);
                actual = actual.Siguiente;
            }
            return ListaAl;
        }

    }

}
