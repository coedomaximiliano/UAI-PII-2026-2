using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cola colaInicial = new Cola();
            Cola colaHombres = new Cola();
            Cola colaMujeres = new Cola();

            colaInicial.Encolar("Juan", 'H');
            colaInicial.Encolar("Sofia", 'M');
            colaInicial.Encolar("Carlos", 'H');
            colaInicial.Encolar("Maria", 'M');
            colaInicial.Encolar("Pedro", 'H');
            colaInicial.Encolar("Lucia", 'M');

            Console.WriteLine("COLA INICIAL:");
            colaInicial.MostrarCola();

            while (!colaInicial.EstaVacia())
            {
                NodoPersona persona = colaInicial.Desencolar();

                if (persona.Sexo == 'H')
                {
                    colaHombres.Encolar(persona.Nombre, persona.Sexo);
                }
                else
                {
                    colaMujeres.Encolar(persona.Nombre, persona.Sexo);
                }
            }

            Console.WriteLine("\nCOLA DE HOMBRES:");
            colaHombres.MostrarCola();

            Console.WriteLine("\nCOLA DE MUJERES:");
            colaMujeres.MostrarCola();

            Console.ReadKey();
        }
    }
}
