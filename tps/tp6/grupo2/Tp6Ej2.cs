using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;


namespace ejercicio6b
{
    internal class Program
    {
        static void Main()
        {
            ColaPrioridad cola = new ColaPrioridad();

            cola.Enqueue("Juan", 3);
            cola.Enqueue("Maria", 1);
            cola.Enqueue("Pedro", 2);
            cola.Enqueue("Ana", 1);
            cola.Enqueue("Carlos", 3);

            Console.WriteLine("COLA CON PRIORIDAD:");
            cola.Mostrar();

            Console.WriteLine("\nORDEN DE ATENCION:");

            while (cola.Count > 0)
            {
                Cliente c = cola.Dequeue();

                Console.WriteLine(
                    c.Nombre + " - Prioridad: " + c.Prioridad);
            }

            Console.Read();
        }
    }

    public class Cliente
    {
        public string Nombre;
        public int Prioridad;

        public Cliente(string nombre, int prioridad)
        {
            Nombre = nombre;
            Prioridad = prioridad;
        }
    }

    public class ColaPrioridad
    {
        private Queue<Cliente> cola = new Queue<Cliente>();

        public int Count
        {
            get { return cola.Count; }
        }

        // AGREGAR CLIENTE SEGUN PRIORIDAD
        public void Enqueue(string nombre, int prioridad)
        {
            if (prioridad < 1 || prioridad > 3)
                throw new ArgumentException("Prioridad inválida");

            Queue<Cliente> auxiliar = new Queue<Cliente>();

            Cliente nuevo = new Cliente(nombre, prioridad);

            bool agregado = false;

            while (cola.Count > 0)
            {
                Cliente actual = cola.Dequeue();

                if (!agregado && actual.Prioridad > prioridad)
                {
                    auxiliar.Enqueue(nuevo);
                    agregado = true;
                }

                auxiliar.Enqueue(actual);
            }

            if (!agregado)
                auxiliar.Enqueue(nuevo);

            cola = auxiliar;
        }

        // RETIRAR PRIMERO
        public Cliente Dequeue()
        {
            return cola.Dequeue();
        }

        // MOSTRAR COLA
        public void Mostrar()
        {
            foreach (Cliente c in cola)
            {
                Console.WriteLine(
                    c.Nombre + " - Prioridad: " + c.Prioridad);
            }
        }
    }
}