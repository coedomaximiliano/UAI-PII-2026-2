using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6_Ej5  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColaPrioridad cola = new ColaPrioridad();

            cola.Encolar("Juan", 3);
            cola.Encolar("Sofia", 1);
            cola.Encolar("Carlos", 2);
            cola.Encolar("Maria", 1);
            cola.Encolar("Pedro", 3);
            cola.Encolar("Lucia", 2);

            Console.WriteLine("COLA CON PRIORIDAD:");
            cola.MostrarCola();

            Console.WriteLine("\nAtendiendo cliente:");
            Console.WriteLine(cola.Desencolar());

            Console.WriteLine("\nCOLA ACTUALIZADA:");
            cola.MostrarCola();

            Console.ReadKey();
        }
    }
}
