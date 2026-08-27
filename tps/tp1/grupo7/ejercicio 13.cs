//ejercicio 13: Escribe un programa que pida al usuario una fecha y la muestre en el formato año, mes y día (AAAAMMDD).
// Pedimos al usuario que ingrese una fecha
Console.Write("Ingrese una fecha (dd/MM/yyyy): ");

// Leemos la fecha ingresada y la convertimos a DateTime
DateTime fecha = DateTime.Parse(Console.ReadLine());

// Mostramos la fecha con el formato año, mes y día
Console.WriteLine("Fecha en formato AAAAMMDD: " + fecha.ToString("yyyyMMdd"));