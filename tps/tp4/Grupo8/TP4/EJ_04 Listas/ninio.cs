using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_04_Listas
{
    internal class ninio
    {
        public string Nombre;
        public string Apellido;
        public int Edad;
        public int Dni;

        public ninio(string n, string ap, int e, int dni)
        {
            this.Nombre = n;
            this.Apellido = ap;
            this.Edad = e;
            this.Dni = dni;
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} | {Edad} años";
        }
    }
}
