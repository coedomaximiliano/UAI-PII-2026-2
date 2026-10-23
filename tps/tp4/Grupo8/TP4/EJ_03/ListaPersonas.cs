using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ_03
{
    internal class ListaPersonas
    {
        public NodoPersona NodoInicial;

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
            NodoPersona aux = null;

            while (i < listrandom)
            {
                NodoPersona nuevo = new NodoPersona();
                nuevo.persona = new Persona();
                nuevo.persona.nombre = $"Persona {i + 1}";

                if (NodoInicial == null)
                {
                    NodoInicial = nuevo;
                }
                else
                {
                    aux.Siguiente = nuevo;
                }

                aux = nuevo;
                i++;
            }
        }

        public void registrarPersona(Persona p)
        {
            NodoPersona nodo = new NodoPersona();
            nodo.persona = p;

            if(NodoInicial == null)
            {
                NodoInicial = nodo;
            }
            else
            {
                nodo.Siguiente = NodoInicial;
                NodoInicial = nodo;
            }

        }

        public void eliminarPersona(int indice)
        {
            if (NodoInicial == null || indice < 0) return;

            if(indice == 0)
            {
                NodoInicial = NodoInicial.Siguiente;
                return;
            }

            NodoPersona aux = NodoInicial;
            int i = 0;
            while(i < indice - 1)
            {
                if(aux.Siguiente == null)
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
                return;
            }
        }

        public void ActualizarDatos(int indice, Persona p)
        {
            if (indice < 0) return;

            if (NodoInicial == null)
            {
                NodoInicial = new NodoPersona();
                NodoInicial.persona = p;
            }

            if (indice == 0)
            {
                NodoInicial.persona = p;
                return;
            }

            NodoPersona aux = NodoInicial;
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
                aux.Siguiente.persona = p;
            }
            else
            {
                MessageBox.Show("El elemento a modificar está fuera de rango");
                return;
            }
        }

        public void AgregarDespuesDelSeleccionado(int indice, Persona p)
        {
            if (NodoInicial == null)
            {
                NodoInicial = new NodoPersona();
                NodoInicial.persona = p;
                return;
            }

            if (indice < 0)
            {
                MessageBox.Show("Seleccioná un elemento de la lista", "UAI");
                return;
            }

            NodoPersona aux = NodoInicial;
            int i = 0;
            while (i < indice)
            {
                if (aux.Siguiente == null)
                {
                    MessageBox.Show("El elemento a agregar está fuera de rango", "UAI");
                    return;
                }
                aux = aux.Siguiente;
                i++;
            }

            NodoPersona nuevo = new NodoPersona();
            nuevo.persona = p;
            nuevo.Siguiente = aux.Siguiente;
            aux.Siguiente = nuevo;
        }

        public List<Persona> MostrarLista()
        {
            List<Persona > lista = new List<Persona>();
            NodoPersona actual = NodoInicial;
            while (actual != null)
            {
                lista.Add(actual.persona);
                actual = actual.Siguiente;
            }
            return lista;
        }

    }
}
