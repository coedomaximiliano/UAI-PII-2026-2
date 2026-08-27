// ============================================================
// Clase 2 - Programación y Estructuras de Datos
// Ejercicio 2
// ------------------------------------------------------------
// Enunciado:
// Escribir un programa de consola en C# que solicite por teclado
// un número decimal grande y lo convierta a int usando
// Convert.ToInt32() y también con una conversión explícita (cast).
// Comparar los resultados y generar además un número aleatorio
// entre 1 y 50 con la clase Random.
// ============================================================

using System;

class Ejercicio2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número decimal grande (ej: 5555.5555):");
        double valorGrande = Convert.ToDouble(Console.ReadLine());

        // Conversión con Convert.ToInt32(): redondea al entero más cercano.
        int conConvert = Convert.ToInt32(valorGrande);

        // Conversión explícita (cast): trunca la parte decimal (no redondea).
        int conCast = (int)valorGrande;

        Console.WriteLine("Valor ingresado: " + valorGrande);
        Console.WriteLine("Convert.ToInt32(): " + conConvert + "  (redondea)");
        Console.WriteLine("Cast (int): " + conCast + "  (trunca, descarta los decimales)");

        // Número aleatorio entre 1 y 50 (50 exclusivo en Next, por eso 51)
        Random rnd = new Random();
        int aleatorio = rnd.Next(1, 51);
        Console.WriteLine("Número aleatorio (1-50): " + aleatorio);
    }
}

// ------------------------------------------------------------
// Resultado explicado (ejemplo de ejecución con 5555.5555):
//
//   Ingrese un número decimal grande (ej: 5555.5555):
//   5555.5555
//   Valor ingresado: 5555.5555
//   Convert.ToInt32(): 5556  (redondea)
//   Cast (int): 5555  (trunca, descarta los decimales)
//   Número aleatorio (1-50): 27
//
// Explicación:
// Convert.ToInt32() redondea al entero más cercano (5555.5555 se
// redondea "hacia arriba" a 5556, porque la parte decimal es mayor
// a 0.5). En cambio, el cast (int) simplemente descarta todo lo que
// esté después de la coma, sin redondear: por eso da 5555.
// Esta diferencia es importante: si no se tiene en cuenta, un
// cast puede "perder" información silenciosamente (no lanza
// ningún error, solo trunca).
// El número aleatorio final varía en cada ejecución porque Random
// genera una secuencia distinta cada vez que se corre el programa
// (semilla basada en el reloj del sistema).
// ============================================================
