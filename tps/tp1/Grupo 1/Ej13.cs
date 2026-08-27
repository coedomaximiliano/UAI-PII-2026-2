/*Ejercicio 13
Dada una fecha mostrarla en el formato AAAAMMDD.*/
Console.Write("Ingrese una fecha (dd/mm/aaaa): ");
DateTime fecha = DateTime.Parse(Console.ReadLine());
string fechaFormateada = fecha.ToString("yyyy/MM/dd");
Console.WriteLine(fechaFormateada);