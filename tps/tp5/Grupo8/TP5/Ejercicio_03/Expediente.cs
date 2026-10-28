using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    internal class Expediente
    {
        public Expediente(int n, string c, DateTime f)
        {
            this.numero = n;
            this.caratula = c;
            this.Fecha = f;
        }
        public Expediente() { }

        public int numero;
        public string caratula;
        public DateTime Fecha;

        public string ToString2()
        {
            return $"Numero: {numero} \nCaratula: {caratula}\nFecha: {Fecha.ToString()}";
        }

        public override string ToString()
        {
            return $"Exp n°{numero} | {Fecha.ToString()} | {caratula}";
        }

    }
}
