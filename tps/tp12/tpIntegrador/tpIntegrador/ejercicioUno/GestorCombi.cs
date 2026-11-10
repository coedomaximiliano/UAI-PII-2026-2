using System;

namespace ejercicioUno
{
    internal class GestorCombi
    {
        Pasajero Frente;
        Pasajero Ultimo;

        // Agrega un pasajero al final de la cola.
        public void Anotar(string nombre)
        {
            Pasajero nuevo = new Pasajero();
            nuevo.Nombre = nombre;

            if (Frente == null)
            {
                Frente = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                Ultimo = nuevo;
            }
        }

        // Quita al primer pasajero de la cola.
        public Pasajero SubirPasajero()
        {
            if (Frente == null)
            {
                return null;
            }

            Pasajero aux = Frente;
            Frente = Frente.Siguiente;

            if (Frente == null)
            {
                Ultimo = null;
            }

            aux.Siguiente = null;
            return aux;
        }

        // Inicia el recorrido para mostrar los pasajeros.
        public void MostrarLista(Action<string> visitar)
        {
            MostrarRecursivo(Frente, visitar);
        }

        private void MostrarRecursivo(Pasajero actual,
                                     Action<string> visitar)
        {
            if (actual == null)
            {
                return;
            }
            else
            {
                visitar(actual.Nombre);
                MostrarRecursivo(actual.Siguiente, visitar);
            }
        }

        // Devuelve la cantidad de pasajeros en espera.
        public int ContarPasajeros()
        {
            return ContarRecursivo(Frente);
        }

        private int ContarRecursivo(Pasajero actual)
        {
            if (actual == null)
            {
                return 0;
            }
            else
            {
                return 1 + ContarRecursivo(actual.Siguiente);
            }
        }
    }
}