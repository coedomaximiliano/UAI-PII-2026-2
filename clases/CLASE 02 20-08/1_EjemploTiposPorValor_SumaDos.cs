// ============================================================
// Clase 2 - Programación y Estructuras de Datos
// Ejemplo práctico: tipos por valor
// ------------------------------------------------------------
// Método visto en la slide "Ejemplo práctico: tipos por valor":
//
//   public int SumaDos(int valor)
//   {
//       int resultado;
//       resultado = valor + 2;
//       return resultado;
//   }
//
// Este archivo agrega un Main() que lo llama y demuestra, con
// resultados reales, por qué "valor" es una COPIA del argumento
// (int es un tipo por valor) y jamás afecta a la variable original.
// ============================================================

using System;

class EjemploTiposPorValor
{
    public int SumaDos(int valor)
    {
        int resultado;
        resultado = valor + 2;

        // Si modificáramos "valor" acá adentro, por ejemplo:
        //     valor = 1000;
        // esa modificación NO se vería reflejada afuera del método,
        // porque "valor" es una copia local, apilada en el Stack
        // solo mientras dura esta llamada.
        return resultado;
    }

    static void Main(string[] args)
    {
        EjemploTiposPorValor ejemplo = new EjemploTiposPorValor();

        int x = 5;
        Console.WriteLine("Valor de x ANTES de llamar a SumaDos: " + x);

        int resultado = ejemplo.SumaDos(x);

        Console.WriteLine("Resultado devuelto por SumaDos(x): " + resultado);
        Console.WriteLine("Valor de x DESPUÉS de llamar a SumaDos: " + x);
    }
}

// ------------------------------------------------------------
// Resultado explicado (ejecución con x = 5):
//
//   Valor de x ANTES de llamar a SumaDos: 5
//   Resultado devuelto por SumaDos(x): 7
//   Valor de x DESPUÉS de llamar a SumaDos: 5
//
// Explicación:
// Al llamar a "ejemplo.SumaDos(x)", el parámetro "valor" recibe una
// COPIA del dato de x (porque int es un tipo por valor). Dentro del
// método se trabaja sobre esa copia: "resultado = valor + 2" da 7,
// y ese 7 es lo que se devuelve.
// Pero x, la variable original del método Main, nunca se toca: por
// eso sigue valiendo 5 después de la llamada, aunque adentro de
// SumaDos se haya usado su valor para calcular otra cosa.
//
// Esto es justamente lo que distingue a los tipos por valor de los
// tipos por referencia: con un tipo por referencia (como se ve en
// el ejemplo de la clase con "MiEntero" / RetornaValor), modificar
// el parámetro SÍ puede afectar al objeto original, porque tanto el
// parámetro como la variable original apuntan al mismo dato en el
// Heap.
// ============================================================
