using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Cola
    {
        public NodoCola Frente;
        public NodoCola Ultimo;

        public bool EstaVacia()
        {
            return Frente == null;
        }

        public void Encolar(Nadador nadador)
        {
            NodoCola nuevo = new NodoCola();
            nuevo.nadador = nadador;
            nuevo.Siguiente = null;

            if (EstaVacia()) Frente = nuevo;
            else
            {
                Ultimo.Siguiente = nuevo;
            }
            Ultimo = nuevo;
        }

        public Nadador Desencolar()
        {
            if (EstaVacia()) throw new Exception();
            Nadador n = Frente.nadador;
            Frente = Frente.Siguiente;
            if (EstaVacia())
            {
                Ultimo = null;
            }
            return n;
        }

        public Nadador VerTope()
        {
            if (EstaVacia()) throw new Exception();
            return Frente.nadador;
        }

        public List<Nadador> Listar()
        {
            List<Nadador> lista = new List<Nadador>();
            NodoCola aux = Frente;
            while (aux != null)
            {
                lista.Add(aux.nadador);
                aux = aux.Siguiente;
            }
            return lista;
        }
    }
}
