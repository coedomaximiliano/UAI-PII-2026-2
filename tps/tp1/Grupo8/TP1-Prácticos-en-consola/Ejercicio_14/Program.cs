using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime f1, f2;
            int diasEntre;

            Console.Write("Ingrese la primera fecha (dd/mm/aaaa):");
            f1 = DateTime.Parse(Console.ReadLine());
            Console.Write("\nIngrese la segunda fecha (dd/mm/aaaa):");
            f2 = DateTime.Parse(Console.ReadLine());
            diasEntre = (f2 - f1).Days;
            Console.WriteLine($"\nLa cantidad de días entre las dos fechas es: {diasEntre}");
        }
    }
}
