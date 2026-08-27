/*Ejercicio 6
Si la circunferencia de un círculo es pi * Diámetro, desarrollar una
aplicación que dada la circunferencia calcule el diámetro.*/
int circunferencia;
Console.WriteLine("Ingrese la circunferencia del círculo: ");
circunferencia = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"El diámetro del círculo es: {circunferencia / Math.PI}");