using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6_Ej5
{
    internal class ColaPrioridad
    {
        private NodoCliente Frente;

        public bool EstaVacia()
        {
            return Frente == null;
        }

        public void Encolar(string nombre, int prioridad)
        {
            if (prioridad < 1 || prioridad > 3)
            {
                Console.WriteLine("Prioridad invalida");
                return;
            }

            NodoCliente nuevo = new NodoCliente();
            nuevo.Nombre = nombre;
            nuevo.Prioridad = prioridad;
            nuevo.Siguiente = null;

            if (EstaVacia() || prioridad < Frente.Prioridad)
            {
                nuevo.Siguiente = Frente;
                Frente = nuevo;
            }
            else
            {
                NodoCliente actual = Frente;

                while (actual.Siguiente != null &&
                       actual.Siguiente.Prioridad <= prioridad)
                {
                    actual = actual.Siguiente;
                }

                nuevo.Siguiente = actual.Siguiente;
                actual.Siguiente = nuevo;
            }
        }

        public string Desencolar()
        {
            if (EstaVacia())
            {
                return "Cola vacia";
            }

            string nombre = Frente.Nombre;
            Frente = Frente.Siguiente;

            return nombre;
        }

        public void MostrarCola()
        {
            NodoCliente actual = Frente;

            while (actual != null)
            {
                Console.WriteLine(actual.Nombre +
                    " - Prioridad: " + actual.Prioridad);

                actual = actual.Siguiente;
            }
        }
    }
}
