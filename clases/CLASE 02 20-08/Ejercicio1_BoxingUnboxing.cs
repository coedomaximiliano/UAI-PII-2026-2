// ============================================================
// Clase 2 - Programación y Estructuras de Datos
// Ejercicio 1
// ------------------------------------------------------------
// Enunciado:
// Escribir un programa de consola en C# que declare una variable
// int, la convierta a object (boxing) y luego la reconvierta a
// int (unboxing). Mostrar por consola el tipo (GetType()) en cada
// paso.
// ============================================================

using System;

class Ejercicio1
{
    static void Main(string[] args)
    {
        int numero = 42;
        Console.WriteLine("Valor original: " + numero);
        Console.WriteLine("Tipo original: " + numero.GetType());

        // Boxing: el valor por valor "numero" pasa a vivir dentro
        // de un object en el Heap.
        object caja = numero;
        Console.WriteLine("Valor boxeado: " + caja);
        Console.WriteLine("Tipo boxeado: " + caja.GetType());

        // Unboxing: se extrae el valor original desde el object,
        // con conversión explícita (cast).
        int numero2 = (int)caja;
        Console.WriteLine("Valor unboxeado: " + numero2);
        Console.WriteLine("Tipo unboxeado: " + numero2.GetType());
    }
}

// ------------------------------------------------------------
// Resultado explicado (ejecución con numero = 42):
//
//   Valor original: 42
//   Tipo original: System.Int32
//   Valor boxeado: 42
//   Tipo boxeado: System.Int32
//   Valor unboxeado: 42
//   Tipo unboxeado: System.Int32
//
// Explicación:
// GetType() siempre devuelve el tipo REAL del dato (System.Int32),
// más allá de que esté guardado dentro de una variable "object".
// Lo que cambia entre los tres pasos no es el tipo del dato en sí,
// sino DÓNDE y CÓMO se lo está manejando:
//   - "numero" es un tipo por valor, vive en el Stack.
//   - "caja" es una referencia (object) que apunta a una copia de
//     ese valor, ahora alojada en el Heap (boxing).
//   - "numero2" vuelve a ser un tipo por valor en el Stack, con el
//     valor extraído del object mediante el cast (int) (unboxing).
//
// Si se intentara hacer unboxing a un tipo distinto del que
// realmente contiene el object (por ejemplo, "double numero3 =
// (double)caja;" cuando caja contiene un int), C# lanzaría un
// InvalidCastException en tiempo de ejecución.
// ============================================================
