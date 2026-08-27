/*Ejercicio 14
 Dadas dos fechas calcular la diferencia en días entre una y la otra.*/
Console.Write("Ingrese la primera fecha (dd/mm/aaaa): ");
DateTime fecha1 = DateTime.Parse(Console.ReadLine());

Console.Write("Ingrese la segunda fecha (dd/mm/aaaa): ");
DateTime fecha2 = DateTime.Parse(Console.ReadLine());

int diferencia = Math.Abs((fecha2 - fecha1).Days);

Console.WriteLine($"La diferencia es de {diferencia} días.");