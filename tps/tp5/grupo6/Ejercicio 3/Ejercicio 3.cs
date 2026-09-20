using System;

public class Expediente
{
    public DateTime Fecha {  get; set; }
    public int Numero {  get; set; }
    public string Caratula {  get; set; }

    public Expediente (DateTime fecha, int numero, string caratula)
    {
        Fecha = fecha;
        Numero = numero;
        Caratula = caratula;
    }
}

public class NodoPila
{
    public Expediente Dato;
    public NodoPila Siguiente;
}

public class Pila
{
    private NodoPila tope;

    public void Apilar(Expediente dato)
    {
        NodoPila nuevo = new NodoPila();
        nuevo.Dato = dato;
        nuevo.Siguiente = tope;
        tope = nuevo;
    }

    public Expediente Desapilar()
    {
        if (EstaVacia())
        {
            throw new InvalidOperationException("Pila vacia");
        }
        Expediente dato = tope.Dato;
        tope = tope.Siguiente;
        return dato;
    }

    public Expediente VerTope()
    {
        if (EstaVacia())
        {
            throw new InvalidOperationException("Pila vacia");
        }
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
        Console.WriteLine("=== MESA DE ENTRADA DEL JUZGADO ===\n");

        Pila pilaExpedientes = new Pila();
        DateTime fechaDelDia = new DateTime(2026, 9, 20);

        Console.WriteLine($"Apilando expedientes correspondientes al día {fechaDelDia:dd/MM/yyyy}...\n");

        ApilarOrdenado(pilaExpedientes, new Expediente(new DateTime(2026, 9, 20), 105, "Perez c/ Gomez s/ Daños"));
        ApilarOrdenado(pilaExpedientes, new Expediente(new DateTime(2026, 9, 20), 101, "Gimenez s/ Sucesión"));
        ApilarOrdenado(pilaExpedientes, new Expediente(new DateTime(2026, 9, 21), 110, "Lopez c/ AFIP"));
        ApilarOrdenado(pilaExpedientes, new Expediente(new DateTime(2026, 9, 20), 103, "Estado Nacional s/ Expropiación"));

        Console.WriteLine("--- ESTADO FINAL DE LA PILA (De Tope a Base) ---");
        while (!pilaExpedientes.EstaVacia())
        {
            Expediente exp = pilaExpedientes.Desapilar();
            Console.WriteLine($"Nro: {exp.Numero} | Fecha: {exp.Fecha:dd/MM/yyyy} | Carátula: {exp.Caratula}");
        }
    }

    static void ApilarOrdenado(Pila principal, Expediente nuevoExp)
    {
        DateTime fechaTarget = new DateTime(2026, 9, 20);
        if (nuevoExp.Fecha.Date != fechaTarget.Date)
        {
            Console.WriteLine($"[Rechazado] Exp. {nuevoExp.Numero} no corresponde a la fecha actual.");
            return;
        }

        Pila pilaAux = new Pila();

        while (!principal.EstaVacia() && principal.VerTope().Numero < nuevoExp.Numero)
        {
            pilaAux.Apilar(principal.Desapilar());
        }

        principal.Apilar(nuevoExp);

        while (!pilaAux.EstaVacia())
        {
            principal.Apilar(pilaAux.Desapilar());
        }

        Console.WriteLine($"[Apilado] Exp. {nuevoExp.Numero} ingresado con éxito.");
    }
}