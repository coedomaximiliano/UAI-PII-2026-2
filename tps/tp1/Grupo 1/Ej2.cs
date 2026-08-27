//Ejercicio 2
//Desarrollar una aplicación de consola que tomando 2 números informe
//cuantos números hay entre los dos.
int numero = 0;
int numero2 = 0;
Console.WriteLine("Ingrese un número por favor: ");
numero = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ingrese otro número por favor: ");
numero2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(numero2 - numero);
Console.ReadKey();