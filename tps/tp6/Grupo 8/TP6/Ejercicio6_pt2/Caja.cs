using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_pt2
{
    internal class Caja
    {
        public Caja()
        {
            abierta = false;
            cola = new Cola();
            recaudacion = 0;
        }

        public NodoCliente traspasarTodo()
        {
            return cola.Frente;
        }

        public NodoCliente traspasarMitad()
        {
            if (cola.EstaVacia()) return null;

            int total = cola.Contar(); 

            if (total % 2 != 0)
            {
                NodoCliente todo = cola.Frente;
                Vaciar();
                return todo;
            }

            int mitad = total / 2;
            NodoCliente aux1 = cola.Frente;
            NodoCliente inicioPrimeraMitad = cola.Frente;

            for (int i = 0; i < mitad - 1; i++)
            {
                aux1 = aux1.siguiente;
            }

            cola.Frente = aux1.siguiente; 
            aux1.siguiente = null;        

            return inicioPrimeraMitad;
        }

        public void Vaciar()
        {
            cola.Frente = null;
            cola.Ultimo = null; 
        }

        public bool abierta;
        public Cola cola;

        public long recaudacion;
    }
}
