using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Nadador
    {
        public Nadador(string n, bool esh)
        {
            Nombre = n;
            EsHombre = esh;
        }
        public string Nombre;
        public bool EsHombre;

        public override string ToString()
        {
            return $"{Nombre}";
        }
    }
}
