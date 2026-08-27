
using System;
    
namespace Ejercicio6
{
    class progman
        {
        static void Main()
        {
        Console.Write("ingrese la circunferencia del circulo: ");
        string entrada = Console.ReadLine();

        if (double.TryParse (entrada,out double circunferencia) && circunferencia > 0)
        {
        double diametro = circunferencia / Math.PI;
        Console.WriteLine($"El diametro del circulo es: {diametro:F2}");

        }
        else
        {
                Console.WriteLine("por favor, ingrese un numero valido y mayor a cero.");
            }
        }
    }
}


