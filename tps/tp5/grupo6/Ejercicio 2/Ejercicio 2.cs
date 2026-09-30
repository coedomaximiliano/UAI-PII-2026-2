using System;

public class NodoPila
{
    public string Dato;
    public NodoPila Siguiente;
}

public class Pila
{
    private NodoPila tope;

    public void Apilar(string dato)
    {
        NodoPila nuevo = new NodoPila();
        nuevo.Dato = dato;
        nuevo.Siguiente = tope;
        tope = nuevo;
    }

    public string Desapilar()
    {
        if (EstaVacia())
        {
            throw new InvalidOperationException("Pila vacia");
        }

        string dato = tope.Dato;
        tope = tope.Siguiente;
        return dato;
    }

    public bool EstaVacia()
    {
        return tope == null;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pila camino = new Pila();

        string[] viajeIda = { "Pueblo Origen", "Pueblo A", "Pueblo B", "Pueblo C", "Pueblo Destino" };
        Console.WriteLine("RECORRIDO DE IDA");
        foreach (string pueblo in viajeIda)
        {
            Console.WriteLine($"Pasando por: {pueblo}");
            camino.Apilar(pueblo);
        }

        Console.WriteLine("\nDestino alcanzado. Emprendiendo el regreso.\n");

        Console.WriteLine("RECORRIDO DE VUELTA");
        while (!camino.EstaVacia())
        {
            string puebloVuelta = camino.Desapilar();
            Console.WriteLine($"Regresando por: {puebloVuelta}");
        }
    }
}