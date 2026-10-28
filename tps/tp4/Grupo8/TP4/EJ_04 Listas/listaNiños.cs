using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ_04_Listas
{
    internal class listaNiños
    {
        public NodoNinio Ultimo;

        public int Cantidad;

        public string Eliminados;

        public void Agregar(ninio n)
        {
            NodoNinio nodo = new NodoNinio(n);

            if (Ultimo == null)
            {
                Ultimo = nodo;
                Ultimo.Siguiente = Ultimo;
            }
            else
            {
                nodo.Siguiente = Ultimo.Siguiente;
                Ultimo.Siguiente = nodo;
                Ultimo = nodo;
            }
            Cantidad++;
        }

        private NodoNinio ObtenerNodo(int indice)
        {
            NodoNinio Actual = Ultimo.Siguiente;
            for (int i = 0; i < indice; i++)
            {
                Actual = Actual.Siguiente;
            }
            return Actual;
        }

        public ninio ObtenerNinio(int indice)
        {
            return ObtenerNodo(indice).ninio;
        }

        public bool ExisteDni(int dni)
        {
            if (Ultimo == null) return false;

            NodoNinio Primero = Ultimo.Siguiente;
            NodoNinio Actual = Primero;
            do
            {
                if (Actual.ninio.Dni == dni) return true;
                Actual = Actual.Siguiente;
            } while (Actual != Primero);

            return false;
        }

        public void AgregarDespues(int indice, ninio n)
        {
            NodoNinio Seleccionado = ObtenerNodo(indice);
            NodoNinio nodo = new NodoNinio(n);

            nodo.Siguiente = Seleccionado.Siguiente;
            Seleccionado.Siguiente = nodo;

            if (Seleccionado == Ultimo) Ultimo = nodo;

            Cantidad++;
        }

        public void Eliminar(int indice)
        {
            if (Cantidad == 1)
            {
                Ultimo = null;
                Cantidad = 0;
                return;
            }

            NodoNinio Anterior;
            NodoNinio Actual;

            if (indice == 0)
            {
                Anterior = Ultimo;
                Actual = Ultimo.Siguiente;
            }
            else
            {
                Anterior = ObtenerNodo(indice - 1);
                Actual = Anterior.Siguiente;
            }

            Anterior.Siguiente = Actual.Siguiente;
            if (Actual == Ultimo) Ultimo = Anterior;
            Cantidad--;
        }

        public void Modificar(int indice, string nombre, string apellido, int edad, int dni)
        {
            ninio n = ObtenerNodo(indice).ninio;
            n.Nombre = nombre;
            n.Apellido = apellido;
            n.Edad = edad;
            n.Dni = dni;
        }

        public void Listar(ListBox lb)
        {
            lb.Items.Clear();
            if (Ultimo == null) return;

            NodoNinio Primero = Ultimo.Siguiente;
            NodoNinio Actual = Primero;
            do
            {
                lb.Items.Add(Actual.ninio.ToString() + " | DNI " + Actual.ninio.Dni);
                Actual = Actual.Siguiente;
            } while (Actual != Primero);
        }

        public string RecorrerUnaVuelta()
        {
            if (Ultimo == null) return "";

            string orden = "";
            NodoNinio Primero = Ultimo.Siguiente;
            NodoNinio Actual = Primero;
            do
            {
                orden += Actual.ninio.ToString() + " --> ";
                Actual = Actual.Siguiente;
            } while (Actual != Primero);

            return orden + "vuelve a " + Primero.ninio.ToString();
        }

        public ninio JuegoEliminacion(int salto)
        {
            Eliminados = "";
            if (Ultimo == null) return null;

            NodoNinio Anterior = Ultimo;
            NodoNinio Actual = Ultimo;

            while (Cantidad > 1)
            {
                for (int i = 1; i <= salto; i++)
                {
                    Anterior = Actual;
                    Actual = Actual.Siguiente;
                }

                Eliminados += Actual.ninio.ToString() + Environment.NewLine;

                Anterior.Siguiente = Actual.Siguiente;
                if (Actual == Ultimo) Ultimo = Anterior;

                Actual = Anterior;
                Cantidad--;
            }

            return Actual.ninio;
        }
    }
}
