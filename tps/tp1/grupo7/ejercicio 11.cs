//ejercicio 11 : Escribir un programa que pida al usuario ingresar una frase y luego muestre la cantidad de caracteres que tiene la frase ingresada.
// Pedimos al usuario que ingrese una frase
Console.Write("Ingrese una frase: ");
// Guardamos la frase ingresada por el usuario
string frase = Console.ReadLine();
// Mostramos la cantidad de caracteres usando Length
Console.WriteLine("La frase tiene " + frase.Length + " caracteres.");