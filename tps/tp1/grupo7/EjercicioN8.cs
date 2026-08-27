
/*Calcular el factorial de 6*/


using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercio8
{
    class Progam
    {
        static void Main()
        {
            int Num = 6;
            long Factorial = 1;

            for (int i = 1; i <= Num; i++)
            {
                Factorial *= i;

            }
            Console.WriteLine($"el factorial del {Num} es :{Factorial} ");
        }
    }
}

