using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class ColaConPrioridad
    {
        NodoColaConPrioridad Frente;
        NodoColaConPrioridad Ultimo;

        public bool EstaVacia()
        {
            return Frente == null;
        }

        public void Encolar(int prioridad, string cliente)
        {
            NodoColaConPrioridad nuevo = new NodoColaConPrioridad(prioridad, cliente);
            if(EstaVacia() || nuevo.prioridad < Frente.prioridad)
            {
                nuevo.siguiente = Frente;
                Frente = nuevo;
                if (Ultimo == null) Ultimo = nuevo;
                return;
            }
            NodoColaConPrioridad aux = Frente;
            while(aux.siguiente != null && aux.siguiente.prioridad <= prioridad)
            {
                aux = aux.siguiente;
            }
            nuevo.siguiente = aux.siguiente;
            aux.siguiente = nuevo;
            if(aux == Ultimo) Ultimo = nuevo;
        }

        public string Desencolar()
        {
            if (EstaVacia()) throw new Exception();
            string c = Frente.cliente;
            Frente = Frente.siguiente;
            if (EstaVacia()) Ultimo = null;
            return c;
        }

        public string VerFrente()
        {
            if (EstaVacia()) return "Está vacía";
            else return Frente.cliente;
        }

        public List<NodoColaConPrioridad> Listar()
        {
            List<NodoColaConPrioridad> lista = new List<NodoColaConPrioridad>();
            NodoColaConPrioridad aux = Frente;
            while (aux != null)
            {
                lista.Add(aux);
                aux = aux.siguiente;
            }
            return lista;
        }




    }
}
