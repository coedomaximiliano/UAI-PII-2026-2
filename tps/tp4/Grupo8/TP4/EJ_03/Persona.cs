using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_03
{
    internal class Persona
    {
        static Random rnd = new Random();

        public string nombre;
        public int edad;
        public int precioentrada;

        public Persona()
        {
            this.nombre = "N/A";
            this.edad = RndEdad();
            this.precioentrada = calcularprecioentrada(this.edad);
        }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.precioentrada = calcularprecioentrada(edad);
        }

        public void ModificarEdad(int nuevaEdad)
        {
            this.edad = nuevaEdad;
            this.precioentrada = calcularprecioentrada(nuevaEdad);
        }

        public static int RndEdad()
        {
            return rnd.Next(5, 61);
        }

        private static int calcularprecioentrada(int edad)
        {
            int Precio;

            if (edad >= 5 && edad <= 12)
            {
                Precio = 500;
            }
            else if (edad >= 13 && edad <= 17)
            {
                Precio = 1000;
            }
            else
            {
                Precio = 1500;
            }

            return Precio;
        }

        public override string ToString()
        {
            return $"{edad:D2} años | {nombre} - Entrada: ${precioentrada}";
        }

    }
}
