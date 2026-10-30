using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class NodoColaConPrioridad
    {
        public int prioridad;
        public string cliente;
        public NodoColaConPrioridad siguiente;

        public NodoColaConPrioridad(int p, string c)
        {
            prioridad = p;
            cliente = c;
            siguiente = null;
        }

        public override string ToString()
        {
            return $"{cliente} | Prioridad: {prioridad}";
        }
    }
}
