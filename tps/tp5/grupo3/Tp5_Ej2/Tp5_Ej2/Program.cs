using System;
using System.Collections.Generic;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pueblos = new Stack<string>();

            Console.Write("Ingrese la cantidad de pueblos: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("\nCAMINO DE IDA:");

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese el pueblo " + (i + 1) + ": ");
                string pueblo = Console.ReadLine();

                pueblos.Push(pueblo);
                Console.WriteLine("Pasando por: " + pueblo);
            }

            Console.WriteLine("\nCAMINO DE VUELTA:");

            while (pueblos.Count > 0)
            {
                Console.WriteLine("Pasando por: " + pueblos.Pop());
            }

            Console.ReadKey();
        }
    }
}