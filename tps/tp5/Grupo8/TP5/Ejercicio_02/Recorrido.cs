using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class Recorrido
    {
        NodoPueblo actual;
        public bool volviendo = false;

        bool EstaVacia()
        {
            return actual == null;
        }

        public void Push(string n)
        {
            NodoPueblo nuevo = new NodoPueblo();
            nuevo.nombre = n;
            if (EstaVacia())
            {
                actual = nuevo;
            }
            else
            {
                nuevo.siguiente = actual;
                actual = nuevo;
            }
        }

        public string Pop() 
        {
            if(EstaVacia())
            {
                throw new Exception();
            }
            string nom = actual.nombre;
            actual = actual.siguiente;
            return nom;
        }

        public void invertir()
        {
            if (EstaVacia())
            {
                return;
            }

            List<string> lista = new List<string>();

            while(!EstaVacia())
            {
                lista.Add(Pop());
            }
            foreach (string n in lista)
            {
                Push(n);
            }

            volviendo = !volviendo;
        }

        public List<string> Listar()
        {
            NodoPueblo aux = actual;
            List<string> lista = new List<string>();
            while(aux != null)
            {
                lista.Add(aux.nombre);
                aux = aux.siguiente;
            }
            return lista;
        }


    }
}
