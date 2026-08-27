/*
 
 Ejercicio 3
Dados los lados de un triangulo calcular el perímetro.
 */
using System; //  Libreria para poder usar la clase Console

namespace PruebaPrograma
{
    public class Program// Clase principal / organizacion del codigo
    {
        static void Main() // Metodo principal / punto de entrada del programa
        {

            Console.WriteLine("Ingrese el primer lado del triangulo: "); 
            int lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Segundo lado del Triangulo: ");
            int lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer lado del triangulo: ");
            int lado3 = int.Parse(Console.ReadLine());

            int perimetro = lado1+lado2+lado3;

            Console.WriteLine("El Perimetro del triangulo es: " + perimetro);
        }
    }
}