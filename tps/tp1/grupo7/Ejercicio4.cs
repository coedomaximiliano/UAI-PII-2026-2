/*
 Ejercicio 4
    Dados los datos necesarios de un Cuadrado calcular la superficie
 */

using System;
namespace Proyecto
{
    class programa
    {
        static void Main()
        {
            Console.WriteLine("Ingrese la Altura del cuadrado");
            int Altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Base del cuadrado");
            int Base = int.Parse(Console.ReadLine());

            int superficie = Altura * Base;

            Console.WriteLine("La superficie del cuadrado es: " + superficie);
        }
    }
}