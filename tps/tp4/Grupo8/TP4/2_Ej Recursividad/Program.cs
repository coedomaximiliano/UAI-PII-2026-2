using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ej_Recursividad
{
    internal class Program
    {

        static int Factorial(int n)
        {
            if(n <= 1) return 1;

            return n  * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"El factorial de {n} es {Factorial(n)}");
        }
    }
}
