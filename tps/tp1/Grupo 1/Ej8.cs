/*Ejercicio 8
Calcular el factorial de 6.*/
int resultado = 1;
for (int i = 6; i > 0; i--)
{
    resultado *= i;
}
Console.WriteLine($"El resultado del factorial de 6 es: {resultado}");