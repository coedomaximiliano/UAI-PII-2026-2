using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6_Ej6
{
    internal class Cola
    {
        private NodoPersona Frente;
        private NodoPersona Fin;

        public bool EstaVacia()
        {
            return Frente == null;
        }

        public void Encolar(string nombre, int ticket)
        {
            NodoPersona nuevo = new NodoPersona();
            nuevo.Nombre = nombre;
            nuevo.Ticket = ticket;
            nuevo.Siguiente = null;

            if (EstaVacia())
            {
                Frente = nuevo;
            }
            else
            {
                Fin.Siguiente = nuevo;
            }

            Fin = nuevo;
        }

        public NodoPersona Desencolar()
        {
            if (EstaVacia())
            {
                return null;
            }

            NodoPersona auxiliar = Frente;
            Frente = Frente.Siguiente;

            if (Frente == null)
            {
                Fin = null;
            }

            auxiliar.Siguiente = null;
            return auxiliar;
        }

        public int Cantidad()
        {
            int contador = 0;
            NodoPersona actual = Frente;

            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }

            return contador;
        }

        public int UltimoTicket()
        {
            int maximo = 0;
            NodoPersona actual = Frente;

            while (actual != null)
            {
                if (actual.Ticket > maximo)
                {
                    maximo = actual.Ticket;
                }

                actual = actual.Siguiente;
            }

            return maximo;
        }

        public void MostrarCola()
        {
            NodoPersona actual = Frente;

            while (actual != null)
            {
                Console.WriteLine(actual.Nombre +
                    " - Ticket: " + actual.Ticket);

                actual = actual.Siguiente;
            }
        }
    }
}
