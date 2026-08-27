using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Enunciado: Dados los datos necesarios de un Cuadrado calcular la superficie

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l1, l2, superficie;
            Console.Write("ingrese el primer lado (cm): ");
            l1 = int.Parse(Console.ReadLine());
            Console.Write("ingrese el segundo lado (cm): ");
            l2 = int.Parse(Console.ReadLine());
            superficie = l1 * l2;
            Console.WriteLine($"La superficie del cuadrado es {superficie} cm²");
            Console.ReadLine();
        }
    }
}
