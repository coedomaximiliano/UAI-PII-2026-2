using System;
using System.Collections.Generic;

namespace tp9
{
    public class ArbolBinario
    {
        public Nodo? Raiz { get; private set; }

        public bool EstaVacio
        {
            get { return Raiz == null; }
        }

        // Agregar nodo raíz
        public bool AgregarRaiz(string dato)
        {
            if (string.IsNullOrWhiteSpace(dato) || Raiz != null)
                return false;

            Raiz = new Nodo(dato);
            return true;
        }

        // Agregar rama izquierda
        public bool AgregarIzquierdo(Nodo padre, string dato)
        {
            if (padre == null || string.IsNullOrWhiteSpace(dato)
                || padre.Izquierdo != null)
                return false;

            padre.Izquierdo = new Nodo(dato);
            return true;
        }

        // Agregar rama derecha
        public bool AgregarDerecho(Nodo padre, string dato)
        {
            if (padre == null || string.IsNullOrWhiteSpace(dato)
                || padre.Derecho != null)
                return false;

            padre.Derecho = new Nodo(dato);
            return true;
        }

        // RECORRIDO PREORDEN
        public List<string> Preorden()
        {
            List<string> resultado = new List<string>();
            RecorrerPreorden(Raiz, resultado);
            return resultado;
        }

        private void RecorrerPreorden(Nodo? actual,
            List<string> resultado)
        {
            if (actual == null)
                return;

            resultado.Add(actual.Dato);

            RecorrerPreorden(actual.Izquierdo, resultado);
            RecorrerPreorden(actual.Derecho, resultado);
        }

        // RECORRIDO INORDEN
        public List<string> Inorden()
        {
            List<string> resultado = new List<string>();
            RecorrerInorden(Raiz, resultado);
            return resultado;
        }

        private void RecorrerInorden(Nodo? actual,
            List<string> resultado)
        {
            if (actual == null)
                return;

            RecorrerInorden(actual.Izquierdo, resultado);

            resultado.Add(actual.Dato);

            RecorrerInorden(actual.Derecho, resultado);
        }

        // RECORRIDO POSORDEN
        public List<string> Posorden()
        {
            List<string> resultado = new List<string>();
            RecorrerPosorden(Raiz, resultado);
            return resultado;
        }

        private void RecorrerPosorden(Nodo? actual,
            List<string> resultado)
        {
            if (actual == null)
                return;

            RecorrerPosorden(actual.Izquierdo, resultado);

            RecorrerPosorden(actual.Derecho, resultado);

            resultado.Add(actual.Dato);
        }
    }
}