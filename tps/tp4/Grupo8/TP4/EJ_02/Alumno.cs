using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_02
{
    internal class Alumno
    {

        public Alumno(string n, string ap, int dni, DateTime fn, string dir, int tel)
        {
            this.Nombre = n;
            this.Apellido = ap;
            this.Dni = dni;
            this.FechNac = fn;
            this.Direccion = dir;
            this.Telefono = tel;
        }

        public string Nombre;
        public string Apellido;
        public int Dni;
        public DateTime FechNac;
        public string Direccion;
        public int Telefono;

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }

    }
}
