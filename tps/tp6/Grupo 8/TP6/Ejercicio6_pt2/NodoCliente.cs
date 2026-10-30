using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_pt2
{
    internal class NodoCliente
    {
        public NodoCliente(int c)
        {
            this.cliente = c;
            siguiente = null;
        }

        public int cliente;
        public NodoCliente siguiente;
    }
}
