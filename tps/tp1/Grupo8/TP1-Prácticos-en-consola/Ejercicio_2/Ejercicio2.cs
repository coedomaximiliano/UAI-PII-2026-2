using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Enunciado: Desarrollar una aplicación de consola que tomando 2 números informe cuantos números hay entre los dos


namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1 = 0, v2 = 0, r;

            Console.Write("ingrese el primer valor: ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("ingrese el segundo valor: ");
            v2 = int.Parse(Console.ReadLine());
            r = v2 - v1;
            Console.WriteLine($"Hay {r} números entre {v1} y {v2}");
            Console.ReadLine();
        }
    }
}
