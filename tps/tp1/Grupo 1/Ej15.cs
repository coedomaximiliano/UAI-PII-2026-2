/*Ejercicio 15
Informar cuantos días faltan para el 25/12/2026.*/
DateTime fecha = DateTime.Now;
DateTime navidad = new DateTime(2026,12,25);      
int diferencia = (navidad - fecha).Days;
Console.WriteLine($"Faltan {diferencia} días para el 25/12/2026");