using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp12_PyED
{
    internal class Cola
    {
        NodoCola Frente;
        NodoCola Ultimo;

        public bool EstaVacia() //chequea si está vacía
        {
            return Frente == null;
        }

        public void Anotar(string p) 
        {
            NodoCola nuevo = new NodoCola(p);
            if (EstaVacia()) //si está vacia el frente y el ultimo son lo mismo 
            {
                Frente = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;  //caso contrario se agrega al final de la fila 
                Ultimo = nuevo;
            }
        }

        public string Subir() //se extrae el dato del frente y luego el siguiente se convierte en el frente
        {
            string dato = Frente.Pasajero;
            Frente = Frente.Siguiente;
            return dato;
        }

        public List<string> Listar()
        {
            List<string> lista = new List<string>();
            NodoCola aux = Frente;
            while (aux != null)  //recorre toda la cola, extrae los datos de cada nodo y los agrega a una lista que se retorna
            {
                lista.Add(aux.Pasajero);
                aux = aux.Siguiente;
            }
            return lista;
        }

    }
}
