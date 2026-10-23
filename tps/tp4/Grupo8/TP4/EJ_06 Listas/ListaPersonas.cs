using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ_06_Listas
{
    internal class ListaPersonas
    {
        public NodoPersona Primero;
        public NodoPersona Ultimo;

        static Random rnd = new Random();

        private static int rndpersonas()
        {
            return rnd.Next(0, 51);
        }

        public int listrandom = rndpersonas();

        public ListaPersonas()
        {
            CrearLista();
        }

        private void CrearLista()
        {
            int i = 0;

            while (i < listrandom)
            {
                NodoPersona nuevo = new NodoPersona();
                nuevo.persona = new Persona();
                nuevo.persona.nombre = $"Persona {i + 1}";

                if (Primero == null)
                {
                    Primero = nuevo;
                    Ultimo = nuevo;
                }
                else
                {
                    nuevo.Anterior = Ultimo;
                    Ultimo.Siguiente = nuevo;
                    Ultimo = nuevo;
                }

                i++;
            }
        }

        public void registrarPersona(Persona p)
        {
            NodoPersona nodo = new NodoPersona();
            nodo.persona = p;

            if (Primero == null)
            {
                Primero = nodo;
                Ultimo = nodo;
            }
            else
            {
                nodo.Siguiente = Primero;
                Primero.Anterior = nodo;
                Primero = nodo;
            }
        }

        public void eliminarPersona(int indice)
        {
            if (Primero == null || indice < 0) return;

            if (indice == 0)
            {
                Primero = Primero.Siguiente;
                if (Primero == null)
                {
                    Ultimo = null;
                }
                else
                {
                    Primero.Anterior = null;
                }
                return;
            }

            NodoPersona aux = BuscarNodo(indice);
            if (aux == null)
            {
                MessageBox.Show("El elemento a borrar está fuera de rango");
                return;
            }

            aux.Anterior.Siguiente = aux.Siguiente;
            if (aux.Siguiente == null)
            {
                Ultimo = aux.Anterior;
            }
            else
            {
                aux.Siguiente.Anterior = aux.Anterior;
            }
        }

        public void ActualizarDatos(int indice, Persona p)
        {
            if (Primero == null || indice < 0) return;

            if (indice == 0)
            {
                Primero.persona = p;
                return;
            }

            NodoPersona aux = BuscarNodo(indice);
            if (aux == null)
            {
                MessageBox.Show("El elemento a modificar está fuera de rango");
                return;
            }

            aux.persona = p;
        }

        private NodoPersona BuscarNodo(int indice)
        {
            NodoPersona aux = Primero;
            int i = 0;

            while (i < indice)
            {
                if (aux.Siguiente == null) return null;

                aux = aux.Siguiente;
                i++;
            }
            return aux;
        }

        public List<Persona> MostrarLista()
        {
            List<Persona> lista = new List<Persona>();
            NodoPersona actual = Primero;
            while (actual != null)
            {
                lista.Add(actual.persona);
                actual = actual.Siguiente;
            }
            return lista;
        }

    }
}
