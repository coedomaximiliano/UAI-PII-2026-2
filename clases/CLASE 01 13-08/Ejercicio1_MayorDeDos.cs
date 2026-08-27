// ============================================================
// Clase 1 - Programación y Estructuras de Datos
// Ejercicio 1
// ------------------------------------------------------------
// Enunciado:
// Escribir un programa de consola en C# que solicite por teclado
// dos números enteros, y muestre por pantalla cuál de los dos es
// mayor, utilizando el operador condicional (?:).
// ============================================================

using System;

class Ejercicio1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer número:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int b = Convert.ToInt32(Console.ReadLine());

        // Operador condicional (?:): si (a > b) es true, mayor = a; si no, mayor = b.
        int mayor = (a > b) ? a : b;

        Console.WriteLine("El mayor es: " + mayor);
    }
}

// ------------------------------------------------------------
// Resultado explicado (ejemplo de ejecución):
//
//   Ingrese el primer número:
//   12
//   Ingrese el segundo número:
//   27
//   El mayor es: 27
//
// Explicación:
// El programa lee dos enteros desde la consola con Console.ReadLine()
// (que siempre devuelve un string) y los convierte a int con
// Convert.ToInt32(). Luego, el operador condicional compara "a > b":
// como 12 no es mayor que 27, la expresión evalúa a "false" y la
// variable "mayor" toma el valor de "b" (27), que es lo que se
// imprime por consola.
//
// Si a y b fueran iguales, el resultado mostrado sería b (por cómo
// está planteada la condición ">"), ya que no se cumple a > b.
// ============================================================
