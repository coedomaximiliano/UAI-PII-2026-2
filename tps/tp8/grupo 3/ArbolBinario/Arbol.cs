using System.Collections.Generic;

namespace ArbolBinario
{
    internal class Arbol
    {
        public Nodo Raiz { get; private set; }

        public bool AgregarRaiz(int dato)
        {
            if (Raiz != null) return false;
            Raiz = new Nodo(dato);
            return true;
        }

        public bool AgregarIzquierda(Nodo padre, int dato)
        {
            if (padre == null || padre.Izquierdo != null) return false;
            padre.Izquierdo = new Nodo(dato);
            return true;
        }

        public bool AgregarDerecha(Nodo padre, int dato)
        {
            if (padre == null || padre.Derecho != null) return false;
            padre.Derecho = new Nodo(dato);
            return true;
        }

        public List<int> RecorrerPreorden()
        {
            List<int> resultado = new List<int>();
            Preorden(Raiz, resultado);
            return resultado;
        }

        public List<int> RecorrerInorden()
        {
            List<int> resultado = new List<int>();
            Inorden(Raiz, resultado);
            return resultado;
        }

        public List<int> RecorrerPostorden()
        {
            List<int> resultado = new List<int>();
            Postorden(Raiz, resultado);
            return resultado;
        }

        private void Preorden(Nodo actual, List<int> resultado)
        {
            if (actual == null) return;
            resultado.Add(actual.Dato);
            Preorden(actual.Izquierdo, resultado);
            Preorden(actual.Derecho, resultado);
        }

        private void Inorden(Nodo actual, List<int> resultado)
        {
            if (actual == null) return;
            Inorden(actual.Izquierdo, resultado);
            resultado.Add(actual.Dato);
            Inorden(actual.Derecho, resultado);
        }

        private void Postorden(Nodo actual, List<int> resultado)
        {
            if (actual == null) return;
            Postorden(actual.Izquierdo, resultado);
            Postorden(actual.Derecho, resultado);
            resultado.Add(actual.Dato);
        }
    }
}
