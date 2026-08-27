using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int longitud;
            Console.Write("Ingrese un mensaje de texto: ");
            string mensaje = Console.ReadLine();
            longitud = mensaje.Length;
            Console.WriteLine($"La longitud del mensaje es de {longitud} caracteres");
        }
    }
}
