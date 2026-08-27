//ejercicio 10: ingresar una frase y mostrar la Segunda mitad + primera mitad
// Pedimos al usuario que ingrese una frase
Console.Write("Ingrese una frase: ");

// Guardamos la frase ingresada por el usuario
string x = Console.ReadLine();

// Calculamos la mitad de la cantidad de caracteres de la frase
int mitad = x.Length / 2;

// Obtenemos la segunda mitad de la frase desde la posición "mitad"
string segundaMitad = x.Substring(mitad);

// Obtenemos la primera mitad de la frase desde la posición 0 hasta "mitad"
string primeraMitad = x.Substring(0, mitad);

// Unimos la segunda mitad con la primera mitad
string resultado = segundaMitad + primeraMitad;

// Mostramos el resultado final
Console.WriteLine("Resultado: " + resultado);