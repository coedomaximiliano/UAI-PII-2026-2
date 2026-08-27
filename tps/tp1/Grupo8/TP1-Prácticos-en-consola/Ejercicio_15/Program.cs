using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Informar cuantos días faltan para el 25/12/2020

namespace Ejercicio_15
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            DateTime Hoy = DateTime.Now;
            int DiasFaltantes = 0;
            DateTime FechEjercicio = new DateTime(2020, 12, 25);

            DiasFaltantes = (FechEjercicio - Hoy).Days;

            if(DiasFaltantes <= 0)
            {
                Console.WriteLine($"Han pasado {DiasFaltantes * -1} desde el {FechEjercicio.ToString("dd/MM/yyyy")}");
            }
            else
            {
                Console.WriteLine($"Faltan {DiasFaltantes} Dias para el {FechEjercicio.ToString("dd/MM/yyyy")}");
            }
        }
    }
}
