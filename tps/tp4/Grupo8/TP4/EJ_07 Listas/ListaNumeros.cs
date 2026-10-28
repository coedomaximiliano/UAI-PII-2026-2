using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_07_Listas
{
    internal class ListaNumeros
    {
        public NodoNumero NodoInicial = null;

        public NodoNumero BuscarUltimo(NodoNumero n)
        {
            if (n == null)
            {
                return null;
            }

            if (n.Siguiente != null) return BuscarUltimo(n.Siguiente);
            return n;
        }

        public NodoNumero BuscarNodo(NodoNumero n, int numero)
        {
            if (n == null) return null;

            if (n.numero == numero) return n;

            return BuscarNodo(n.Siguiente, numero);
        }

        public NodoNumero BuscarAnterior(NodoNumero n, int numero)
        {
            if (n == null) return null;

            if (n.Siguiente != null && n.Siguiente.numero == numero)
                return n;

            return BuscarAnterior(n.Siguiente, numero);
        }

        public void AgregarAlFinal(int numero)
        {
            NodoNumero nodo = new NodoNumero();
            nodo.numero = numero;

            if (NodoInicial == null)
            {
                NodoInicial = nodo;
                return;
            }

            NodoNumero ultimo = BuscarUltimo(NodoInicial);
            ultimo.Siguiente = nodo;
        }

        public bool ExisteNumero(int numero)
        {
            NodoNumero aux = NodoInicial;
            while (aux != null)
            {
                if (aux.numero == numero) return true;
                aux = aux.Siguiente;
            }
            return false;
        }

        public void IntercambiarDerecha(int numero)
        {
            NodoNumero nodo = BuscarNodo(NodoInicial, numero);
            if (nodo == null || nodo.Siguiente == null) return;

            NodoNumero anterior = BuscarAnterior(NodoInicial, numero);
            NodoNumero siguiente = nodo.Siguiente;

            nodo.Siguiente = siguiente.Siguiente;
            siguiente.Siguiente = nodo;

            if (anterior == null)
            {
                NodoInicial = siguiente;
            }
            else
            {
                anterior.Siguiente = siguiente;
            }
        }

        public void IntercambiarIzquierda(int numero)
        {
            NodoNumero anterior = BuscarAnterior(NodoInicial, numero);
            if (anterior == null) return;

            NodoNumero nodo = anterior.Siguiente;
            NodoNumero anteAnterior = BuscarAnterior(NodoInicial, anterior.numero);

            anterior.Siguiente = nodo.Siguiente;
            nodo.Siguiente = anterior;

            if (anteAnterior == null)
            {
                NodoInicial = nodo;
            }
            else
            {
                anteAnterior.Siguiente = nodo;
            }
        }

        public void Intercambiar(int numero1, int numero2)
        {
            NodoNumero nodo1 = BuscarNodo(NodoInicial, numero1);
            NodoNumero nodo2 = BuscarNodo(NodoInicial, numero2);

            if (nodo1 == null || nodo2 == null) return;

            int aux = nodo1.numero;
            nodo1.numero = nodo2.numero;
            nodo2.numero = aux;
        }

        public int ObtenerNumero(int indice)
        {
            NodoNumero aux = NodoInicial;
            int i = 0;

            while (i < indice)
            {
                aux = aux.Siguiente;
                i++;
            }
            return aux.numero;
        }

        public List<int> MostrarLista()
        {
            List<int> lista = new List<int>();
            NodoNumero actual = NodoInicial;
            while (actual != null)
            {
                lista.Add(actual.numero);
                actual = actual.Siguiente;
            }
            return lista;
        }
    }
}
