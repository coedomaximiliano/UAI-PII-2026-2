using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Enunciado: Dados los datos necesarios de un Rectángulo calcular la superficie

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseR, altura, superficie;
            Console.Write("Ingrese la base (cm): ");
            baseR = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura (cm): ");
            altura = int.Parse(Console.ReadLine());
            superficie = baseR * altura;
            Console.WriteLine($"La superficie del rectángulo es {superficie} cm²");
            Console.ReadLine();
        }
    }
}
