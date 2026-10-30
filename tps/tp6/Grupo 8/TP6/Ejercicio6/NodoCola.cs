using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class NodoCola
    {
        public Persona persona;
        public NodoCola siguiente;

        public NodoCola(Persona p)
        {
            persona = p;
            siguiente = null;
        }

    }
}
