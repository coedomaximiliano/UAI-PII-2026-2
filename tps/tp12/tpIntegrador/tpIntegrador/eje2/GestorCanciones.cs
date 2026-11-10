using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje2
{
    internal class GestorCanciones
    {
        public Cancion Primero;

        public bool EstaVacia()
        {
            return Primero == null;
        }

        public void AgregarInicio(string nombre, int duracion)
        {
            Cancion nuevo = new Cancion();
            nuevo.Nombre = nombre;
            nuevo.Duracion = duracion;

            nuevo.Siguiente = Primero;
            Primero = nuevo;
        }

        public void AgregarAlFinal(string nombre, int duracion)
        {
            Cancion nuevo = new Cancion();
            nuevo.Nombre = nombre;
            nuevo.Duracion = duracion;

            if(Primero == null)
            {
                Primero = nuevo;
            }else
            {
                Cancion ultimo = BuscarUltimo();
                ultimo.Siguiente = nuevo;
            }
        }

        public Cancion BuscarUltimo()
        {
            if (EstaVacia())
            {
                return null;
            }
            else
            {
                return BuscarUltimoRecursivo(Primero);

            }
        }

        public Cancion BuscarUltimoRecursivo(Cancion actual)
        {
            if (actual.Siguiente == null)
            {
                return actual;
            }
            else
            {
                return BuscarUltimoRecursivo(actual.Siguiente);
            }
        }

        public void Mostrar(Action<string, int> visitar)
        {
            MostrarRecursivo(Primero, visitar);
        }

        public void MostrarRecursivo(Cancion n, Action <string, int> visitar)
        {
            if (n == null) 
            { 
                return; 
            }else
            {
                visitar(n.Nombre, n.Duracion);
                MostrarRecursivo(n.Siguiente, visitar);
            }

        }

        public bool Eliminar(int posicion)
        {
            if (EstaVacia() || posicion < 1)
            {
                return false;
            }
            
            if (posicion == 1)
            {
                Primero = Primero.Siguiente;
                return true;
            }

            return EliminarRecursivo(Primero, posicion);
        }

        public bool EliminarRecursivo(Cancion actual, int posicion)
        {
            if(actual == null || actual.Siguiente == null)
            {
                return false;
            } 

            if (posicion == 2)
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
                return true;
            }

            return EliminarRecursivo(actual.Siguiente, posicion - 1);
        }

        public bool AgregarEnPosicion(string nombre, int duracion, int posicion)
        {
            if (posicion < 1)
            {
                return false;
            }

            Cancion nuevo = new Cancion();
            nuevo.Nombre = nombre;
            nuevo.Duracion = duracion;

            if (posicion == 1)
            {
                nuevo.Siguiente = Primero;
                Primero = nuevo;
                return true;
            }

            return AgregarPosicionRecursivo(Primero, nuevo, posicion);
        }

        private bool AgregarPosicionRecursivo(Cancion actual, Cancion nuevo, int posicion)
        {
            if (actual == null)
            {
                return false;
            }

            if (posicion == 2)
            {
                nuevo.Siguiente = actual.Siguiente;
                actual.Siguiente = nuevo;
                return true;
            }

            return AgregarPosicionRecursivo(actual.Siguiente, nuevo, posicion - 1);
        }

        public bool IntercambiarDerecha(int posicion)
        {
            if (EstaVacia() || posicion < 1)
            {
                return false;
            }

            return IntercambiarRecursivo(Primero, posicion);
        }

        private bool IntercambiarRecursivo(Cancion actual, int posicion)
        {
            if (actual == null || actual.Siguiente == null)
            {
                return false;
            }

            if (posicion == 1)
            {
                string nombreAux = actual.Nombre;
                int duracionAux = actual.Duracion;

                actual.Nombre = actual.Siguiente.Nombre;
                actual.Duracion = actual.Siguiente.Duracion;

                actual.Siguiente.Nombre = nombreAux;
                actual.Siguiente.Duracion = duracionAux;

                return true;
            }

            return IntercambiarRecursivo(actual.Siguiente, posicion - 1);
        }

        public int ContarCanciones()
        {
            return ContarRecursivo(Primero);
        }

        private int ContarRecursivo(Cancion actual)
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
