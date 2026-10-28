using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Almacen
    {
        NodoContenedor Tope;

        public bool EstaVacia()
        {
            return Tope == null;
        }

        public void Push(int id)
        {
            NodoContenedor nuevo = new NodoContenedor();
            nuevo.id = id;
            if(EstaVacia())
            {
                Tope = nuevo;
            }
            else
            {
                nuevo.Siguiente = Tope;
                Tope = nuevo;
            }
        }

        public int Pop()
        {
            if(EstaVacia())
            {
                throw new Exception();
            }
            int n = Tope.id;
            Tope = Tope.Siguiente;
            return n;
        }

        public List<int> Listar()
        {
            List<int> Lista = new List<int>();
            NodoContenedor aux = Tope;
            while(aux != null)
            {
                Lista.Add(aux.id);
                aux = aux.Siguiente;
            }
            return Lista;
        }
    }
}
