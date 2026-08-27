// ============================================================
// Clase 2 - Programación y Estructuras de Datos
// Demo integrador de las diapositivas 11 a 18
// ------------------------------------------------------------
// 11) Boxing y Unboxing
// 12) El tipo Object
// 13) El tipo String
// 14) El tipo Date (DateTime)
// 15) Conversión de tipos — Excepciones de Convert
// 16) Conversión de tipos — Implícitas y explícitas
// 17) Convert vs Parse
// 18) Generación de números aleatorios — Random
//
// Cada bloque de este programa corresponde a una de esas
// diapositivas: se puede ejecutar completo, o comentar los
// bloques que no se necesiten para ver cada tema por separado.
// ============================================================

using System;

class Demo
{
    static void Main(string[] args)
    {
        Slide11_BoxingYUnboxing();
        Slide12_TipoObject();
        Slide13_TipoString();
        Slide14_TipoDate();
        Slide15_ExcepcionesDeConvert();
        Slide16_ConversionesImplicitasYExplicitas();
        Slide17_ConvertVsParse();
        Slide18_NumerosAleatorios();
    }

    // ------------------------------------------------------------
    // 11) Boxing y Unboxing
    // ------------------------------------------------------------
    static void Slide11_BoxingYUnboxing()
    {
        Console.WriteLine("== 11) Boxing y Unboxing ==");

        int i = 123;
        object o = i;              // Boxing: el valor por valor "i" pasa al Heap dentro de un object.
        Console.WriteLine("Boxing: i = " + i + "  ->  o = " + o);

        int i2 = (int)o;           // Unboxing: se extrae el valor original, con conversión explícita.
        Console.WriteLine("Unboxing: o = " + o + "  ->  i2 = " + i2);

        Console.WriteLine();
    }

    // ------------------------------------------------------------
    // 12) El tipo Object
    // ------------------------------------------------------------
    static void Slide12_TipoObject()
    {
        Console.WriteLine("== 12) El tipo Object ==");

        int a = 10;
        int b = 10;
        int c = 20;

        // Equals(): compara igualdad. Para tipos por valor como int,
        // compara el valor (no la posición de memoria).
        Console.WriteLine("a.Equals(b): " + a.Equals(b));   // true, mismo valor
        Console.WriteLine("a.Equals(c): " + a.Equals(c));   // false

        // GetHashCode(): número que identifica al objeto (usado en
        // diccionarios / HashSet). Si Equals() da true, el hash debe coincidir.
        Console.WriteLine("a.GetHashCode(): " + a.GetHashCode());
        Console.WriteLine("b.GetHashCode(): " + b.GetHashCode());

        // GetType(): tipo real en tiempo de ejecución.
        Console.WriteLine("a.GetType(): " + a.GetType());

        // ToString(): representación en texto (Console.WriteLine lo
        // llama automáticamente cuando le pasamos un objeto).
        Console.WriteLine("a.ToString(): " + a.ToString());

        // Finalize() NO se llama nunca a mano en C#: es el destructor
        // que invoca el Garbage Collector antes de liberar el objeto
        // de memoria. Por eso no hay una línea de código que lo
        // "ejecute" en este demo.

        Console.WriteLine();
    }

    // ------------------------------------------------------------
    // 13) El tipo String
    // ------------------------------------------------------------
    static void Slide13_TipoString()
    {
        Console.WriteLine("== 13) El tipo String ==");

        string cadena = "Caracteres";
        Console.WriteLine("cadena = \"" + cadena + "\"");
        Console.WriteLine("Length: " + cadena.Length);
        Console.WriteLine("Chars[0]: " + cadena[0]);   // primer carácter

        string variable = "hola mundo";
        string salida = string.Format("El valor de {0}", variable);
        Console.WriteLine(salida);

        Console.WriteLine();
    }

    // ------------------------------------------------------------
    // 14) El tipo Date (DateTime)
    // ------------------------------------------------------------
    static void Slide14_TipoDate()
    {
        Console.WriteLine("== 14) El tipo Date (DateTime) ==");

        DateTime fecha = new DateTime(2026, 8, 20);
        Console.WriteLine("fecha: " + fecha.ToString("dd-MM-yyyy"));

        DateTime fechaMasUnAnio = fecha.AddYears(5);
        DateTime fechaMenosUnDia = fecha.AddDays(-1);

        Console.WriteLine("fecha.AddYears(5): " + fechaMasUnAnio.ToString("dd-MM-yyyy"));
        Console.WriteLine("fecha.AddDays(-1): " + fechaMenosUnDia.ToString("dd-MM-yyyy"));
        Console.WriteLine("string.Format: " + string.Format("{0:dd-MM-yyyy}", fecha));

        Console.WriteLine();
    }

    // ------------------------------------------------------------
    // 15) Conversión de tipos — Excepciones de Convert
    // ------------------------------------------------------------
    static void Slide15_ExcepcionesDeConvert()
    {
        Console.WriteLine("== 15) Excepciones de Convert ==");

        // FormatException: la cadena no tiene el formato correcto.
        try
        {
            int valor = Convert.ToInt32("no-es-un-numero");
        }
        catch (FormatException)
        {
            Console.WriteLine("FormatException: \"no-es-un-numero\" no tiene formato numérico.");
        }

        // OverflowException: el valor no entra en el tipo destino.
        try
        {
            double numeroGrande = 99999999999999d;
            int valor = Convert.ToInt32(numeroGrande);
        }
        catch (OverflowException)
        {
            Console.WriteLine("OverflowException: el número es demasiado grande para un int.");
        }

        // InvalidCastException: conversión no permitida entre esos tipos.
        try
        {
            object fecha = DateTime.Now;
            int valor = Convert.ToInt32(fecha);
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("InvalidCastException: no se puede convertir un DateTime a int.");
        }

        Console.WriteLine();
    }

    // ------------------------------------------------------------
    // 16) Conversión de tipos — Implícitas y explícitas
    // ------------------------------------------------------------
    static void Slide16_ConversionesImplicitasYExplicitas()
    {
        Console.WriteLine("== 16) Conversiones implícitas y explícitas ==");

        // Implícita: de un tipo entero menor (int) a uno mayor (long).
        // No hace falta ningún cast, no se pierden datos.
        long valorGrande;
        int entero = 5;
        valorGrande = entero;
        Console.WriteLine("Implícita: int " + entero + " -> long " + valorGrande);

        // Explícita: de un tipo con decimales (double) a uno sin
        // decimales (int). Puede haber pérdida de datos, por eso
        // el programador tiene que pedirlo explícitamente con (int).
        double valorGrande2 = 5555.5555;
        int entero2;
        entero2 = (int)valorGrande2;
        Console.WriteLine("Explícita: double " + valorGrande2 + " -> int " + entero2 + " (se pierde la parte decimal)");

        Console.WriteLine();
    }

    // ------------------------------------------------------------
    // 17) Convert vs Parse
    // ------------------------------------------------------------
    static void Slide17_ConvertVsParse()
    {
        Console.WriteLine("== 17) Convert vs Parse ==");

        string valorUsuario = "123";
        int valorA = Convert.ToInt32(valorUsuario);
        int valorB = Int32.Parse(valorUsuario);
        Console.WriteLine("Convert.ToInt32(\"123\"): " + valorA);
        Console.WriteLine("Int32.Parse(\"123\"): " + valorB);

        // Diferencia clave con un valor null:
        string valorNulo = null;

        int conConvert = Convert.ToInt32(valorNulo);
        Console.WriteLine("Convert.ToInt32(null): " + conConvert + "  (no lanza excepción, devuelve 0)");

        try
        {
            int conParse = Int32.Parse(valorNulo);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Int32.Parse(null): lanza ArgumentNullException/FormatException.");
        }

        Console.WriteLine();
    }

    // ------------------------------------------------------------
    // 18) Generación de números aleatorios — Random
    // ------------------------------------------------------------
    static void Slide18_NumerosAleatorios()
    {
        Console.WriteLine("== 18) Generación de números aleatorios ==");

        Random r = new Random();
        int numero = r.Next(1, 101);   // entre 1 y 100 (101 exclusivo)
        Console.WriteLine("Número aleatorio entre 1 y 100: " + numero);

        Console.WriteLine();
    }
}

// ============================================================
// Resultado explicado (ejemplo de una ejecución completa):
//
//   == 11) Boxing y Unboxing ==
//   Boxing: i = 123  ->  o = 123
//   Unboxing: o = 123  ->  i2 = 123
//
//   == 12) El tipo Object ==
//   a.Equals(b): True
//   a.Equals(c): False
//   a.GetHashCode(): 10
//   b.GetHashCode(): 10
//   a.GetType(): System.Int32
//   a.ToString(): 10
//
//   == 13) El tipo String ==
//   cadena = "Caracteres"
//   Length: 10
//   Chars[0]: C
//   El valor de hola mundo
//
//   == 14) El tipo Date (DateTime) ==
//   fecha: 20-08-2026
//   fecha.AddYears(5): 20-08-2031
//   fecha.AddDays(-1): 19-08-2026
//   string.Format: 20-08-2026
//
//   == 15) Excepciones de Convert ==
//   FormatException: "no-es-un-numero" no tiene formato numérico.
//   OverflowException: el número es demasiado grande para un int.
//   InvalidCastException: no se puede convertir un DateTime a int.
//
//   == 16) Conversiones implícitas y explícitas ==
//   Implícita: int 5 -> long 5
//   Explícita: double 5555,5555 -> int 5555 (se pierde la parte decimal)
//
//   == 17) Convert vs Parse ==
//   Convert.ToInt32("123"): 123
//   Int32.Parse("123"): 123
//   Convert.ToInt32(null): 0  (no lanza excepción, devuelve 0)
//   Int32.Parse(null): lanza ArgumentNullException/FormatException.
//
//   == 18) Generación de números aleatorios ==
//   Número aleatorio entre 1 y 100: 57   (este valor cambia en cada ejecución)
//
// Explicación general:
// El programa recorre, en orden, cada uno de los temas de las
// diapositivas 11 a 18, mostrando por consola el resultado de cada
// operación con una etiqueta que indica de qué slide viene. Los
// bloques de "excepciones" usan try/catch a propósito para forzar
// cada error (FormatException, OverflowException, InvalidCastException,
// y la diferencia entre Convert y Parse frente a un valor null) y
// mostrar el mensaje sin que el programa se corte.
// ============================================================
