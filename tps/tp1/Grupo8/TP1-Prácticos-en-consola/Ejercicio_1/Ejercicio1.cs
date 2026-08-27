using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Enunciado: Dados dos valores ingresados por teclado mostrar la suma de ambos

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1 = 0, v2 = 0, r;
            Console.Write("ingrese el primer valor: ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("\ningrese el segundo valor: ");
            v2 = int.Parse(Console.ReadLine());
            r = v1 + v2;
            Console.Write($"La suma de {v1} + {v2} es {r}");
            Console.ReadLine();
        }
    }
}
