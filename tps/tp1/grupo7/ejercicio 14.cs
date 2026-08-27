//ejercicio 14: Crear un programa que pida al usuario dos fechas y calcule la cantidad de días que hay entre ellas.
// Pedimos al usuario que ingrese la primera fecha
Console.Write("Ingrese la primera fecha (dd/MM/yyyy): ");

// Leemos la primera fecha y la convertimos a DateTime
DateTime fecha1 = DateTime.Parse(Console.ReadLine());

// Pedimos al usuario que ingrese la segunda fecha
Console.Write("Ingrese la segunda fecha (dd/MM/yyyy): ");

// Leemos la segunda fecha y la convertimos a DateTime
DateTime fecha2 = DateTime.Parse(Console.ReadLine());

// Restamos las dos fechas y guardamos el resultado en un TimeSpan
TimeSpan diferencia = fecha2 - fecha1;

// Mostramos la cantidad de días de diferencia
Console.WriteLine("La diferencia es de " + Math.Abs(diferencia.Days) + " días.");