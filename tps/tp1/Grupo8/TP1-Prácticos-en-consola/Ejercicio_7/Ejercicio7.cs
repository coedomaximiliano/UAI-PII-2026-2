using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kb, bytes, bits ;

            Console.Write("Ingrese la cantidad de kilobytes (KB): ");
            kb = int.Parse(Console.ReadLine());
            bytes = kb * 1024;
            bits = bytes * 8;
            Console.WriteLine($"La cantidad de bytes es {bytes} Bytes");
            Console.WriteLine($"La cantidad de bits es {bits} Bits");
            Console.ReadLine();
            //1 kb tiene 2^10 bytes (1024) y 1 byte tiene 8 bits, por lo tanto, 1 kb tiene 1024 * 8 = 8192 bits.
        }
    }
}
