/*Ejercicio 3
Dados los lados de un triangulo calcular el perímetro*/
int ladoA;
int ladoB;
int ladoC;
Console.WriteLine("Ingresa un lado: ");
ladoA = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ingresa otro lado: ");
ladoB = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ingresa otro lado: ");
ladoC = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"El perímetro del triángulo es: {ladoA + ladoB + ladoC}");
Console.ReadKey();