/*Ejercicio 5
Dados los datos necesarios de un Rectángulo calcular la superficie. */
int Base;
int altura;
Console.WriteLine("Ingresar la base del rectángulo: ");
Base = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresar la altura del rectángulo: ");
altura = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"La superficie del cuadrado es: {Base * altura}");