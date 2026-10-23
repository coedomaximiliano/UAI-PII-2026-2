using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Ej_Recursividad
{
    internal class Program
    {
        public int Contar(int n)
        {
            if(n == 0) return 0;

            Console.Write($"{n}, ");
            return Contar(n - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int n = int.Parse(Console.ReadLine());

            Program p = new Program();
            p.Contar(n);
        }
    }
}
