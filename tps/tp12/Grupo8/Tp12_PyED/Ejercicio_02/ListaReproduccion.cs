using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    // Lista enlazada CIRCULAR: el Siguiente del último nodo no apunta a null,
    // sino que apunta de nuevo al primero (arma un anillo).
    // Por convención se guarda una referencia al ÚLTIMO nodo:
    // el primero es siempre Ultimo.Siguiente.
    internal class ListaReproduccion
    {
        public NodoCancion Ultimo;

        public bool EstaVacia() //chequea si está vacía
        {
            return Ultimo == null;
        }

        public NodoCancion Primero() //devuelve el primer nodo del anillo
        {
            return EstaVacia() ? null : Ultimo.Siguiente;
        }

        public void AgregarAlPrincipio(string nombre, int duracion)
        {
            NodoCancion nuevo = new NodoCancion(nombre, duracion);
            nuevo.Numero = ProximoNumero();
            if (EstaVacia()) //si está vacía el único nodo se apunta a sí mismo
            {
                Ultimo = nuevo;
                Ultimo.Siguiente = Ultimo;
            }
            else
            {
                nuevo.Siguiente = Ultimo.Siguiente; //el nuevo apunta al actual primero
                Ultimo.Siguiente = nuevo; //el último apunta al nuevo, que queda primero
            }
        }

        public void AgregarAlFinal(string nombre, int duracion)
        {
            NodoCancion nuevo = new NodoCancion(nombre, duracion);
            nuevo.Numero = ProximoNumero();
            if (EstaVacia())
            {
                Ultimo = nuevo;
                Ultimo.Siguiente = Ultimo;
            }
            else
            {
                nuevo.Siguiente = Ultimo.Siguiente; //el nuevo apunta al primero (cierra el anillo)
                Ultimo.Siguiente = nuevo; //el viejo último apunta al nuevo
                Ultimo = nuevo; //el nuevo pasa a ser el último
            }
        }

        public void AgregarEnPosicion(int n, string nombre, int duracion)
        {
            if (n <= 1 || EstaVacia()) //si es la primera posición se agrega al principio
            {
                AgregarAlPrincipio(nombre, duracion);
                return;
            }
            NodoCancion anterior = BuscarPosicion(n - 1); //busca el nodo anterior a la posición n
            if (anterior == null) //si la posición no existe se agrega al final
            {
                AgregarAlFinal(nombre, duracion);
                return;
            }
            NodoCancion nuevo = new NodoCancion(nombre, duracion);
            nuevo.Numero = ProximoNumero();
            nuevo.Siguiente = anterior.Siguiente; //el nuevo intercala entre el anterior y su siguiente
            anterior.Siguiente = nuevo;
            if (anterior == Ultimo) Ultimo = nuevo; //si se agregó después del último, el nuevo pasa a ser el último
        }

        public void QuitarPosicion(int numero)
        {
            if (EstaVacia()) return;
            NodoCancion primero = Ultimo.Siguiente;
            if (primero.Numero == numero && primero == Ultimo) //hay un solo nodo: la lista queda vacía
            {
                Ultimo = null;
                return;
            }
            if (primero.Numero == numero) //el que se quita es el primero
            {
                Ultimo.Siguiente = primero.Siguiente; //el último pasa a apuntar al segundo
                return;
            }
            NodoCancion anterior = BuscarAnterior(primero, primero, numero);
            if (anterior != null) //si lo encontró intercala el nodo fuera del anillo
            {
                if (anterior.Siguiente == Ultimo) Ultimo = anterior; //si era el último, el anterior pasa a ser el último
                anterior.Siguiente = anterior.Siguiente.Siguiente;
            }
        }

        public void IntercambiarDerecha(int numero)
        {
            if (EstaVacia()) return;
            NodoCancion nodo = BuscarNodo(Ultimo.Siguiente, Ultimo.Siguiente, numero);
            if (nodo != null && nodo != Ultimo) //la última canción no tiene derecha
            {
                //se intercambian los datos entre los dos nodos (los enlaces quedan iguales)
                int numAux = nodo.Numero;
                string nomAux = nodo.Nombre;
                int durAux = nodo.Duracion;
                nodo.Numero = nodo.Siguiente.Numero;
                nodo.Nombre = nodo.Siguiente.Nombre;
                nodo.Duracion = nodo.Siguiente.Duracion;
                nodo.Siguiente.Numero = numAux;
                nodo.Siguiente.Nombre = nomAux;
                nodo.Siguiente.Duracion = durAux;
            }
        }

        public NodoCancion BuscarPosicion(int n) //devuelve el nodo que está en la posición n (empezando en 1)
        {
            if (EstaVacia()) return null;
            return BuscarPosicion(Ultimo.Siguiente, Ultimo.Siguiente, n);
        }

        private NodoCancion BuscarPosicion(NodoCancion nodo, NodoCancion primero, int n)
        {
            if (n == 1) return nodo; //llegó a la posición pedida
            if (nodo.Siguiente == primero) return null; //dio la vuelta y no llegó
            return BuscarPosicion(nodo.Siguiente, primero, n - 1);
        }

        private NodoCancion BuscarNodo(NodoCancion nodo, NodoCancion primero, int numero)
        {
            if (nodo.Numero == numero) return nodo; //es el buscado
            if (nodo.Siguiente == primero) return null; //dio la vuelta y no está
            return BuscarNodo(nodo.Siguiente, primero, numero);
        }

        private NodoCancion BuscarAnterior(NodoCancion nodo, NodoCancion primero, int numero)
        {
            if (nodo.Siguiente.Numero == numero) return nodo; //el siguiente es el buscado
            if (nodo.Siguiente == primero) return null; //dio la vuelta y no está
            return BuscarAnterior(nodo.Siguiente, primero, numero);
        }

        private int ProximoNumero()
        {
            if (EstaVacia()) return 1;
            int max = BuscarMaximo(Ultimo.Siguiente, Ultimo.Siguiente, Ultimo.Siguiente.Numero);
            return max + 1; //busco el maximo y le sumo uno
        }

        private int BuscarMaximo(NodoCancion nodo, NodoCancion primero, int max)
        {
            if (nodo.Numero > max) max = nodo.Numero;
            if (nodo.Siguiente == primero) return max; //corta al llegar al último
            return BuscarMaximo(nodo.Siguiente, primero, max);
        }

        public List<string> Listar() //recorrido RECURSIVO que arma la lista para la listbox
        {
            List<string> lista = new List<string>();
            if (EstaVacia()) return lista;
            Listar(Ultimo.Siguiente, Ultimo.Siguiente, lista);
            return lista;
        }

        private void Listar(NodoCancion nodo, NodoCancion primero, List<string> lista)
        {
            lista.Add(nodo.ToString()); //agrega el nodo actual a la lista
            if (nodo.Siguiente != primero) //si el siguiente no es el primero sigue; corta al dar la vuelta
                Listar(nodo.Siguiente, primero, lista);
        }

        public int Contar() //función RECURSIVA que cuenta la cantidad de canciones
        {
            if (EstaVacia()) return 0;
            return Contar(Ultimo.Siguiente, Ultimo.Siguiente);
        }

        private int Contar(NodoCancion nodo, NodoCancion primero)
        {
            if (nodo.Siguiente == primero) return 1; //es el último: corta la vuelta
            return 1 + Contar(nodo.Siguiente, primero); //cuenta el actual y sigue con el siguiente
        }
    }
}
