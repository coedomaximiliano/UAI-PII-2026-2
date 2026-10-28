using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_05_Listas
{
    internal class Paciente
    {

        public Paciente(string n, string apellido, string direccion, int tel)
        {
            this.Nombres = n;
            this.Apellidos = apellido;
            this.Dirección = direccion;
            this.Teléfono = tel;
        }

        public int Codigo;
        public string Nombres;
        public string Apellidos;
        public string Dirección;
        public int Teléfono;

        public override string ToString()
        {
            return $"{Codigo} - {Nombres} {Apellidos}";
        }

    }
}
