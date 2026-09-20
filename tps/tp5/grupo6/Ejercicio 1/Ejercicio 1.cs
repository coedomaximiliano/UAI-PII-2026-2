using System;

public class NodoPila
{
    public int Dato;
    public NodoPila Siguiente;
}

public class Pila
{
    private NodoPila tope;

    public void Push(int dato)
    {
        NodoPila nuevo = new NodoPila();
        nuevo.Dato = dato;
        nuevo.Siguiente = tope;
        tope = nuevo;
    }

    public int Pop()
    {
        if (EstaVacia())
            throw new InvalidOperationException("Pila vacia");

        int dato = tope.Dato;
        tope = tope.Siguiente;
        return dato;
    }

    public int VerTope()
    {
        if (EstaVacia())
            throw new InvalidOperationException("Pila vacia");

        return tope.Dato;
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
        Console.WriteLine("ALMACÉN DE CONTENEDORES");

        Pila almacen = new Pila();

        Console.WriteLine("--- Ingresando contenedores al almacén ---");
        almacen.Push(101);
        almacen.Push(102);
        almacen.Push(103);
        almacen.Push(104);
        almacen.Push(105);

        int idABuscar = 103;
        Console.WriteLine($"\n--- Orden de retiro: Contenedor ID {idABuscar}");

        RetirarContenedor( almacen, idABuscar);
    }

    static void RetirarContenedor(Pila almacen, int idBuscado)
    {
        Pila pilaAuxilar = new Pila();
        bool encontrado = false;

        while (!almacen.EstaVacia())
        {
            int actual = almacen.Pop();

            if (actual == idBuscado)
            {
                encontrado = true;
                Console.WriteLine($"\n>>> Contenedor {idBuscado} encontrado y retirado del sistema <<<\n");
                break;
            }

            pilaAuxilar.Push(actual);
            Console.WriteLine($"Moviendo contenedor {actual} a la pila auxiliar");
        }

        if (!encontrado)
        {
            Console.WriteLine($"El contenedor {idBuscado} no existe en el almacén");
        }

        Console.WriteLine("Regresando los contenedores desde la pila auxiliar al almacen");
        while (!pilaAuxilar.EstaVacia())
        {
            int contenedorAux = pilaAuxilar.Pop();
            almacen.Push(contenedorAux);
        }
    }
}