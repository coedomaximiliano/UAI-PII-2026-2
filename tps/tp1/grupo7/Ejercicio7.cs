/* Si 1Byte tiene 8 bits, desarrolle una solución programática que permita
calcular cuántos bits hay en cualquier combinación de x KBytes. Explique
cómo llegó a esa conclusión. */


using System;

 namespace Ejercio7KB
 {
    class Progam
    {
    static void Main()
        {
        Console.Write("Ingrese la cantidad de kbytes (x): ");
        string entrada = Console.ReadLine();
      
        if (double.TryParse(entrada, out double kbytes) && kbytes >= 0){
            double bits = kbytes * 1024 * 8;
                
                Console.WriteLine($"{kbytes} Kb equivalen a {bits} bits. ");
        }
        else 

    {
                Console.WriteLine("ingrese un numero valido. ");
   
               }
          }
     }
}