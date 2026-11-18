using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp12_PyED
{
    internal class NodoCola
    {
        public string Pasajero;
        public NodoCola Siguiente;

        public NodoCola(string p)
        {
            Pasajero = p;
            Siguiente = null;
        }
    }
}
