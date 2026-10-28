using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    internal class Pila
    {
        NodoExpediente Tope;

        public bool EstaVacia()
        {
            return Tope == null;
        }

        public void Push(Expediente ex)
        {
            NodoExpediente nuevo = new NodoExpediente();
            nuevo.expediente = ex;
            if (!EstaVacia())
            {
                nuevo.Siguiente  = Tope;
            }
            Tope = nuevo;
            
        }

        public string Pop()
        {
            Expediente expe = Tope.expediente;
            Tope = Tope.Siguiente;
            return expe.ToString2(); ;
        }

        public void Clear()
        {
            Tope = null;
            GC.Collect();
        }

        public List<Expediente> Listar()
        {
            List<Expediente> lista = new List<Expediente>();
            NodoExpediente aux = Tope;
            while(aux != null)
            {
                lista.Add(aux.expediente);
                aux = aux.Siguiente;
            }
            return lista;
        }

        public void OrdenarPorNumero()
        {
            List<Expediente> lista = new List<Expediente>();
            NodoExpediente aux = Tope;
            while(aux != null)
            {
                lista.Add(aux.expediente);
                aux = aux.Siguiente;
            }
            lista.Sort(CompararPorNumero);
            Tope = null;
            foreach(Expediente e in lista)
            {
                Push(e);
            }
        }

        private int CompararPorNumero(Expediente a, Expediente b)
        {
            return b.numero.CompareTo(a.numero);
        }

        private int CompararPorFecha(Expediente a, Expediente b)
        {
            return b.Fecha.CompareTo(a.Fecha);
        }

        public void OrdenarPorFecha()
        {
            List<Expediente> lista = new List<Expediente>();
            NodoExpediente aux = Tope;
            while (aux != null)
            {
                lista.Add(aux.expediente);
                aux = aux.Siguiente;
            }
            lista.Sort(CompararPorFecha);
            Tope = null;
            foreach (Expediente e in lista)
            {
                Push(e);
            }
        }


    }
}
