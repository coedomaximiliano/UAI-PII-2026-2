/*Ejercicio 10
Dada una frase cualquiera llamada x, mostrar como resultado una frase
formada por la segunda mitad de x más la primer mitad de x. (usar el
método substring)*/
Console.WriteLine("Ingrese una frase: ");
string x = Console.ReadLine();
int mitad = x.Length / 2;
string primeraMitad = x.Substring(0, mitad);
string segundaMitad = x.Substring(mitad);

Console.WriteLine($"Resultado: {segundaMitad + primeraMitad}");