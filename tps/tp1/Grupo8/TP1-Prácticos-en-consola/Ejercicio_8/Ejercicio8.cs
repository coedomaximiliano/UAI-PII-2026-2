using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Enunciado: Calcular el factorial de 6.

namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 6;
            int factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"El factorial de {numero} es {factorial}");
            Console.ReadLine();
        }
    }
}
