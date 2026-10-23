using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_03
{
    internal class Cine
    {
        public ListaPersonas Personas = new ListaPersonas();

        public int recTotal = 0;

        public void CalcularRecTotal()
        {
            recTotal = 0;

            NodoPersona aux = Personas.NodoInicial;

            while (aux != null)
            {
                recTotal += aux.persona.precioentrada;
                aux = aux.Siguiente;
            }
        }
    }
}
