using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase1, frase2;

            Console.Write("Ingrese la primera frase: ");
            frase1 = Console.ReadLine();
            Console.Write("\nIngrese la segunda frase: ");
            frase2 = Console.ReadLine();
            Console.WriteLine(frase1 + " " + frase2);
            Console.ReadLine();
        }
    }
}
