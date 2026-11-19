using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;


namespace ejercicio6a
{
    internal class Program
    {
        static void Main()
        {
            Queue<Persona> colaInicial = new Queue<Persona>();

            // CARGAR PERSONAS
            colaInicial.Enqueue(new Persona("Juan", "H"));
            colaInicial.Enqueue(new Persona("Maria", "M"));
            colaInicial.Enqueue(new Persona("Pedro", "H"));
            colaInicial.Enqueue(new Persona("Ana", "M"));
            colaInicial.Enqueue(new Persona("Carlos", "H"));

            Queue<Persona> hombres = new Queue<Persona>();
            Queue<Persona> mujeres = new Queue<Persona>();

            // MOSTRAR COLA INICIAL
            Console.WriteLine("COLA INICIAL:");
            Mostrar(colaInicial);

            // SEPARAR POR SEXO
            while (colaInicial.Count > 0)
            {
                Persona p = colaInicial.Dequeue();

                if (p.Sexo == "H")
                    hombres.Enqueue(p);
                else
                    mujeres.Enqueue(p);
            }

            // MOSTRAR NUEVAS COLAS
            Console.WriteLine("\nCOLA DE HOMBRES:");
            Mostrar(hombres);

            Console.WriteLine("\nCOLA DE MUJERES:");
            Mostrar(mujeres);

            Console.Read();
        }

        static void Mostrar(Queue<Persona> cola)
        {
            foreach (Persona p in cola)
            {
                Console.WriteLine(p.Nombre);
            }
        }
    }

    public class Persona
    {
        public string Nombre;
        public string Sexo;

        public Persona(string nombre, string sexo)
        {
            Nombre = nombre;
            Sexo = sexo;
        }
    }
}