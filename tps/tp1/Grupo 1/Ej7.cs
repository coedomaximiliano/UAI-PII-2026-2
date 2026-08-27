/*Ejercicio 7
Si 1Byte tiene 8 bits, desarrolle una solución programática que permita
calcular cuántos bits hay en cualquier combinación de x KBytes. Explique
cómo llegó a esa conclusión.*/
int kbyte;
Console.WriteLine("Ingrese la cantidad de KBytes: ");
kbyte = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"La cantidad de bits es: {kbyte * 8192}");