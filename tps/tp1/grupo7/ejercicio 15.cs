//ejercicio 15: calcular los Días que faltan para el 25/12/2020
// Obtenemos la fecha actual
DateTime hoy = DateTime.Now;

// Creamos la fecha correspondiente al 25 de diciembre de 2020
DateTime navidad = new DateTime(2020, 12, 25);

// Calculamos la diferencia entre Navidad y la fecha actual
TimeSpan diferencia = navidad - hoy;

// Mostramos la cantidad de días de diferencia
Console.WriteLine("Faltan " + diferencia.Days + " días.");