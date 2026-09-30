using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio3
{
    class Expediente
    {
        public DateTime Fecha;
        public int Numero;
        public string Caratula;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Expediente> pila = new Stack<Expediente>();
            List<Expediente> lista = new List<Expediente>();

            Console.Write("Ingrese la cantidad de expedientes: ");
            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Expediente exp = new Expediente();

                Console.WriteLine("\nExpediente " + (i + 1));

                Console.Write("Fecha (dd/mm/aaaa): ");
                exp.Fecha = DateTime.Parse(Console.ReadLine());

                Console.Write("Numero de expediente: ");
                exp.Numero = int.Parse(Console.ReadLine());

                Console.Write("Caratula: ");
                exp.Caratula = Console.ReadLine();

                lista.Add(exp);
            }

            // Ordenar por fecha y luego por numero de expediente
            lista = lista.OrderByDescending(x => x.Fecha)
                         .ThenByDescending(x => x.Numero)
                         .ToList();

            // Apilar los expedientes
            foreach (Expediente exp in lista)
            {
                pila.Push(exp);
            }

            Console.WriteLine("\nEXPEDIENTES APILADOS:");

            while (pila.Count > 0)
            {
                Expediente exp = pila.Pop();

                Console.WriteLine(
                    exp.Fecha.ToString("dd/MM/yyyy") +
                    " - Nro: " + exp.Numero +
                    " - Caratula: " + exp.Caratula
                );
            }

            Console.ReadKey();
        }
    }
}