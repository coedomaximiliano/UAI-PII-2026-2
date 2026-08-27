// ============================================================
// Clase 1 - Programación y Estructuras de Datos
// Ejercicio integrador (más completo)
// ------------------------------------------------------------
// Enunciado:
// Desarrollar una aplicación de consola en C# para gestionar las
// notas de un curso:
//   1) Declarar un array de tipo double de tamaño 5 para almacenar notas.
//   2) Solicitar cada nota por teclado y cargarla en el array con un ciclo for.
//   3) Recorrer el array para calcular el promedio de las notas.
//   4) Solicitar también el porcentaje de asistencia del alumno.
//   5) Usando operadores lógicos, determinar si el alumno aprueba:
//      promedio >= 4 Y asistencia >= 75%.
//   6) Mostrar por consola un resumen final con el promedio y la
//      condición del alumno.
// ============================================================

using System;

class EjercicioIntegrador
{
    static void Main(string[] args)
    {
        double[] notas = new double[5];
        double suma = 0;

        // 1) y 2): cargar las 5 notas por teclado
        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine("Ingrese nota " + (i + 1) + ":");
            notas[i] = Convert.ToDouble(Console.ReadLine());
            suma += notas[i];
        }

        // 3) calcular el promedio
        double promedio = suma / notas.Length;

        // 4) pedir la asistencia
        Console.WriteLine("Ingrese % de asistencia:");
        double asistencia = Convert.ToDouble(Console.ReadLine());

        // 5) condición de aprobación: promedio >= 4 Y asistencia >= 75
        bool aprueba = (promedio >= 4) && (asistencia >= 75);

        // 6) resumen final
        Console.WriteLine("----- Resumen -----");
        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine("Asistencia: " + asistencia + "%");
        Console.WriteLine("Condición: " + (aprueba ? "Aprobado" : "No aprobado"));
    }
}

// ------------------------------------------------------------
// Resultado explicado (ejemplo de ejecución):
//
//   Ingrese nota 1:
//   7
//   Ingrese nota 2:
//   5
//   Ingrese nota 3:
//   6
//   Ingrese nota 4:
//   8
//   Ingrese nota 5:
//   9
//   Ingrese % de asistencia:
//   80
//   ----- Resumen -----
//   Promedio: 7
//   Asistencia: 80%
//   Condición: Aprobado
//
// Explicación:
// Las 5 notas ingresadas (7, 5, 6, 8, 9) se van sumando dentro del
// ciclo for y se acumulan en "suma" (7+5+6+8+9 = 35). El promedio es
// 35 / 5 = 7.
// Como el promedio (7) es mayor o igual a 4 Y la asistencia (80) es
// mayor o igual a 75, el operador "&&" evalúa la expresión completa
// como true, por lo que "aprueba" es true y el programa muestra
// "Aprobado".
//
// Si cualquiera de las dos condiciones fuera falsa (por ejemplo,
// promedio 3.5 aunque la asistencia sea 90%, o promedio 8 con
// asistencia 60%), el resultado final sería "No aprobado", porque el
// "&&" exige que AMBAS condiciones se cumplan al mismo tiempo.
// ============================================================
