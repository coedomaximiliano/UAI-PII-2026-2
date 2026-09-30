using System;

namespace Ejercicio1
{
    class Pila
    {
        private int[] contenedores;
        private int tope;
        private int capacidad;

        public Pila(int n)
        {
            capacidad = n;
            contenedores = new int[capacidad];
            tope = -1;
        }

        public void Push(int numero)
        {
            if (tope == capacidad - 1)
            {
                Console.WriteLine("La pila está llena.");
                return;
            }

            tope++;
            contenedores[tope] = numero;
        }

        public int Pop()
        {
            if (tope == -1)
            {
                Console.WriteLine("La pila está vacía.");
                return -1;
            }

            int numero = contenedores[tope];
            tope--;

            return numero;
        }

        public bool EstaVacia()
        {
            return tope == -1;
        }

        public void RetirarContenedor(int numero)
        {
            Pila auxiliar = new Pila(capacidad);
            bool encontrado = false;

            while (!EstaVacia())
            {
                int actual = Pop();

                if (actual == numero)
                {
                    encontrado = true;
                    Console.WriteLine("Contenedor " + numero + " retirado.");
                    break;
                }

                auxiliar.Push(actual);
            }

            while (!auxiliar.EstaVacia())
            {
                Push(auxiliar.Pop());
            }

            if (!encontrado)
            {
                Console.WriteLine("El contenedor no se encontró.");
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("Pila de contenedores:");

            for (int i = tope; i >= 0; i--)
            {
                Console.WriteLine(contenedores[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pila almacen = new Pila(5);

            almacen.Push(10);
            almacen.Push(20);
            almacen.Push(30);
            almacen.Push(40);
            almacen.Push(50);

            Console.WriteLine("Pila original:");
            almacen.Mostrar();

            Console.WriteLine();

            almacen.RetirarContenedor(30);

            Console.WriteLine();
            Console.WriteLine("Pila después del retiro:");
            almacen.Mostrar();

            Console.ReadKey();
        }
    }
}