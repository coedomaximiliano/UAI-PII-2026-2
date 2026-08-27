using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Enunciado: Dados los lados de un triangulo calcular el perímetro


namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l1, l2, l3, perimetro;
            Console.Write("ingrese el primer lado (cm): ");
            l1 = int.Parse(Console.ReadLine());
            Console.Write("\ningrese el segundo lado (cm): ");
            l2 = int.Parse(Console.ReadLine());
            Console.Write("\ningrese el tercer lado (cm): ");
            l3 = int.Parse(Console.ReadLine());
            perimetro = l1 + l2 + l3;
            Console.WriteLine($"\nEl perímetro del triángulo es {perimetro} cm");
            Console.ReadLine();
        }
    }
}
