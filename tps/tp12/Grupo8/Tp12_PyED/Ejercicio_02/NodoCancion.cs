using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class NodoCancion
    {
        public int Numero;
        public string Nombre;
        public int Duracion; //duración en segundos
        public NodoCancion Siguiente;

        public NodoCancion(string nombre, int duracion)
        {
            Nombre = nombre;
            Duracion = duracion;
            Siguiente = null;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} ({2} seg)", Numero, Nombre, Duracion);
        }
    }
}
