namespace ArbolBinario
{
    internal class Nodo
    {
        public int Dato { get; private set; }
        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }

        public Nodo(int dato)
        {
            Dato = dato;
        }
    }
}
