using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Cola
    {
        private NodoPersona Frente;
        private NodoPersona Fin;

        public bool EstaVacia()
        {
            return Frente == null;
        }

        public void Encolar(string nombre, char sexo)
        {
            NodoPersona nuevo = new NodoPersona();
            nuevo.Nombre = nombre;
            nuevo.Sexo = sexo;
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

        public void MostrarCola()
        {
            NodoPersona actual = Frente;

            while (actual != null)
            {
                Console.WriteLine(actual.Nombre + " - " + actual.Sexo);
                actual = actual.Siguiente;
            }
        }
    }
}
