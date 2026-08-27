// ============================================================
// Clase 1 - Programación y Estructuras de Datos
// Ejercicio 2
// ------------------------------------------------------------
// Enunciado:
// Escribir un programa de consola en C# que declare un array de
// 5 números enteros, lo recorra con un ciclo for sumando sus
// valores, y muestre por pantalla el promedio.
// ============================================================

using System;

class Ejercicio2
{
    static void Main(string[] args)
    {
        int[] numeros = { 8, 3, 10, 5, 4 };
        int suma = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }

        // Se castea a double antes de dividir para no perder los decimales
        // (una división entre dos int en C# trunca el resultado).
        double promedio = suma / (double)numeros.Length;

        Console.WriteLine("El promedio es: " + promedio);
    }
}

// ------------------------------------------------------------
// Resultado explicado (ejecución con el array del ejemplo):
//
//   El promedio es: 6
//
// Explicación:
// El array numeros = {8, 3, 10, 5, 4} tiene 5 elementos. El ciclo for
// recorre cada posición (i = 0 hasta 4) y va acumulando su valor en
// "suma": 8 + 3 + 10 + 5 + 4 = 30.
// El promedio es suma / cantidad de elementos = 30 / 5 = 6.
//
// Nota importante: si no se hiciera el cast a (double), la división
// "suma / numeros.Length" sería una división entera (int / int) y
// truncaría cualquier resultado con decimales. Por ejemplo, con el
// array {8, 3, 10, 5, 5} la suma sería 31 y 31 / 5 daría 6 en vez de
// 6,2 si no se castea a double.
// ============================================================
