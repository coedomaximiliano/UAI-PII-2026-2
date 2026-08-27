/*Ejercicio 1
Dados dos valores ingresados por teclado mostrar la suma de ambos.*/
Console.WriteLine("Ingrese un número: ");
int numero = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ingrese otro número: ");
int numero2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"La suma es {numero + numero2}");
Console.ReadKey();