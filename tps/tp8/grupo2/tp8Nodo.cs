
namespace tp9
{
    public class Nodo
    {
        public string Dato { get; set; }

        public Nodo? Izquierdo { get; set; }

        public Nodo? Derecho { get; set; }

        public Nodo(string dato)
        {
            Dato = dato;
            Izquierdo = null;
            Derecho = null;
        }
    }
}
