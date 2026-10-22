using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6_Ej6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cola cola = new Cola();
            Cola retirados = new Cola();

            cola.Encolar("Juan", 1);
            cola.Encolar("Sofia", 0);
            cola.Encolar("Carlos", 2);
            cola.Encolar("Maria", 0);
            cola.Encolar("Pedro", 3);

            Console.WriteLine("COLA INICIAL:");
            cola.MostrarCola();

            int cantidad = cola.Cantidad();
            int ultimoTicket = cola.UltimoTicket();

            for (int i = 0; i < cantidad; i++)
            {
                NodoPersona persona = cola.Desencolar();

                if (persona.Ticket != 0)
                {
                    cola.Encolar(persona.Nombre, persona.Ticket);
                }
                else
                {
                    ultimoTicket++;
                    retirados.Encolar(persona.Nombre, ultimoTicket);
                }
            }

            Console.WriteLine("\nPERSONAS RETIRADAS:");
            retirados.MostrarCola();

            Console.WriteLine("\nCOLA FINAL:");
            cola.MostrarCola();

            Console.ReadKey();
        }
    }
}
