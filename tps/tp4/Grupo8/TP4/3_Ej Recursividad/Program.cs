using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Ej_Recursividad
{
    internal class Program
    {
        static void Ordenar(int[] n, int desde)
        {
            if (desde >= n.Length - 1)
            {
                return;
            }

            int posMenor = desde;

            for (int i = desde + 1; i < n.Length; i++)
            {
                if (n[i] < n[posMenor])
                {
                    posMenor = i;
                }
            }

            int aux = n[desde];
            n[desde] = n[posMenor];
            n[posMenor] = aux;

            Ordenar(n, desde + 1);
        }

        static void Mostrar(int[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                Console.Write(n[i] + " ");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese cuantos numeros desea cargar: ");
            int a = int.Parse(Console.ReadLine());
            int[] n = new int[a];

            for (int i = 0; i < a; i++)
            {
                Console.Write("\nIngrese un numero: ");
                n[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nVector desordenado:");
            Mostrar(n);

            Ordenar(n, 0);

            Console.WriteLine("\nVector ordenado:");
            Mostrar(n);

            Console.ReadKey();
        }
    }
}
