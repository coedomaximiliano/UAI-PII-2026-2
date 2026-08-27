using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "Hola Mundo!", primeraMitad, SegundaMitad;
            int mitad;
            mitad = x.Length / 2;
            primeraMitad = x.Substring(0, mitad);
            SegundaMitad = x.Substring(mitad);

            Console.WriteLine(primeraMitad + SegundaMitad);
        }
    }
}
