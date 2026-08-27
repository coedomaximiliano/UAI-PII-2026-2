/*Dadas dos frases concatenarlas y mostrar el resultado. */

using System;
namespace LasFrases
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese la primera Frase: ");
            string frase1 = Console.ReadLine();

            Console.Write("Ingrese la segunda frase: ");
            string frase2 = Console.ReadLine();

            string resultado = $"{frase1}{frase2}";

            Console.WriteLine($"\n frases conectada : {resultado}");
        }
    }
}
