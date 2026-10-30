using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_pt2
{
    internal class Cola
    {
        public NodoCliente Frente;
        public NodoCliente Ultimo;

        static int countCliente = 0;
        static int setid()
        {
            countCliente++;
            return countCliente;
        }


        public bool EstaVacia()
        {
            return Frente == null;
        }

        public void Encolar()
        {
            NodoCliente nuevo = new NodoCliente(setid());
            if (EstaVacia()) Frente = nuevo;
            else Ultimo.siguiente = nuevo;
            Ultimo = nuevo;
        }

        public void Encolar(int id)
        {
            NodoCliente nuevo = new NodoCliente(id);
            if (EstaVacia()) Frente = nuevo;
            else Ultimo.siguiente = nuevo;
            Ultimo = nuevo;
        }

        public void EncolarT(NodoCliente nc)
        {
            if (nc == null) return; 

            if (EstaVacia())
            {
                Frente = nc;
            }
            else
            {
                Ultimo.siguiente = nc;
            }

            NodoCliente aux = nc;
            while (aux.siguiente != null)
            {
                aux = aux.siguiente;
            }
            Ultimo = aux;
        }

        public string Desencolar()
        {
            string d;
            if (EstaVacia()) return "Esta vacia";
            else d = Frente.cliente.ToString(); 
            Frente = Frente.siguiente;
            return d;
        }

        public List<int> Listar()
        {
            List<int> lista = new List<int>();
            NodoCliente aux = Frente;
            while(aux != null)
            {
                lista.Add(aux.cliente);
                aux = aux.siguiente;
            }
            return lista;
        }

        public int Contar()
        {
            int count = 0;
            NodoCliente aux = Frente;
            while (aux != null)
            {
                count++;
                aux = aux.siguiente;
            }
            return count;
        }

    }
}
