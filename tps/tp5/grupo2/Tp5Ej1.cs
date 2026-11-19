using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;





using System;
using System.Collections.Generic;

namespace ejercicio5b
{
    internal class Program
    {
        static void Main()
        {
            PilaPueblos recorrido = new PilaPueblos();

            recorrido.AgregarPueblo("Pueblo A");
            recorrido.AgregarPueblo("Pueblo B");
            recorrido.AgregarPueblo("Pueblo C");
            recorrido.AgregarPueblo("Pueblo D");

            recorrido.MostrarIdaYVuelta();

            Console.Read();
        }
    }

    public class PilaPueblos
    {
        private Stack<string> pueblos = new Stack<string>();

        // AGREGAR PUEBLO
        public void AgregarPueblo(string nombre)
        {
            pueblos.Push(nombre);
        }

        // MOSTRAR CAMINO DE IDA Y VUELTA
        public void MostrarIdaYVuelta()
        {
            Stack<string> auxiliar = new Stack<string>();

            Console.WriteLine("CAMINO DE IDA:");

            foreach (string pueblo in pueblos)
            {
                Console.WriteLine(pueblo);
                auxiliar.Push(pueblo);
            }

            Console.WriteLine("\nCAMINO DE VUELTA:");

            while (auxiliar.Count > 0)
            {
                Console.WriteLine(auxiliar.Pop());
            }
        }
    }
}
