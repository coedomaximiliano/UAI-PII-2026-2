using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime FechAct = DateTime.Now;
            Console.WriteLine($"La fecha y hora actual es: {FechAct.ToString("yyyy/MM/dd")}");
        }
    }
    
}
