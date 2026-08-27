using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Si la circunferencia de un círculo es pi * Diámetro, desarrollar una aplicación que dada la circunferencia calcule el diámetro.

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float circunferencia, diametro;
            float pi = 3.14f;
            Console.Write("Ingrese la circunferencia (cm): ");
            circunferencia = float.Parse(Console.ReadLine());
            diametro = circunferencia / pi;
            Console.WriteLine($"El diámetro del círculo es {diametro} cm");
            Console.ReadLine();
        }
    }
}
