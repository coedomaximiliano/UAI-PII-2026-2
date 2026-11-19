using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;


namespace ejercicio5c
{
    internal class Program
    {
        static void Main()
        {
            Juzgado juzgado = new Juzgado();

            juzgado.AgregarExpediente(
                new Expediente("18/11/2026", 103, "Caso A"));

            juzgado.AgregarExpediente(
                new Expediente("18/11/2026", 101, "Caso B"));

            juzgado.AgregarExpediente(
                new Expediente("17/11/2026", 105, "Caso C"));

            juzgado.AgregarExpediente(
                new Expediente("18/11/2026", 102, "Caso D"));

            juzgado.OrdenarExpedientes();

            juzgado.MostrarExpedientes();

            Console.Read();
        }
    }

    // CLASE EXPEDIENTE
    public class Expediente
    {
        public DateTime Fecha;
        public int Numero;
        public string Caratula;

        public Expediente(string fecha, int numero, string caratula)
        {
            Fecha = DateTime.ParseExact(
                fecha,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture);

            Numero = numero;
            Caratula = caratula;
        }
    }

    // CLASE JUZGADO
    public class Juzgado
    {
        private Stack<Expediente> expedientes =
            new Stack<Expediente>();

        // AGREGAR EXPEDIENTE
        public void AgregarExpediente(Expediente expediente)
        {
            expedientes.Push(expediente);
        }

        // ORDENAR EXPEDIENTES
        public void OrdenarExpedientes()
        {
            List<Expediente> lista = new List<Expediente>();

            while (expedientes.Count > 0)
            {
                lista.Add(expedientes.Pop());
            }

            lista.Sort((a, b) =>
            {
                int resultado = a.Fecha.CompareTo(b.Fecha);

                if (resultado == 0)
                    return a.Numero.CompareTo(b.Numero);

                return resultado;
            });

            foreach (Expediente e in lista)
            {
                expedientes.Push(e);
            }
        }

        // MOSTRAR EXPEDIENTES
        public void MostrarExpedientes()
        {
            Stack<Expediente> auxiliar =
                new Stack<Expediente>(expedientes);

            Console.WriteLine("EXPEDIENTES ORDENADOS:");

            while (auxiliar.Count > 0)
            {
                Expediente e = auxiliar.Pop();

                Console.WriteLine(
                    "Fecha: " + e.Fecha.ToString("dd/MM/yyyy") +
                    " | Numero: " + e.Numero +
                    " | Caratula: " + e.Caratula);
            }
        }
    }
}