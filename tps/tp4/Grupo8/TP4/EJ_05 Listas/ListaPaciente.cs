using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_05_Listas
{
    internal class ListaPaciente
    {
        NodoPaciente Primero;
        NodoPaciente Ultimo;
        int cantidad = 0;

        public void AgregarAlFinal(Paciente p)
        {
            NodoPaciente nuevo = new NodoPaciente(p);
            nuevo.paciente.Codigo = ProximoID();

            if(Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                nuevo.Anterior = Ultimo;
                Ultimo.Siguiente = nuevo;
                Ultimo = nuevo;
            }
            cantidad++;
        }

        public void AgregarAlPrincipio(Paciente p)
        {
            NodoPaciente nuevo = new NodoPaciente(p);
            nuevo.paciente.Codigo = ProximoID();

            if(Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                nuevo.Siguiente = Primero;
                Primero.Anterior = nuevo;
                Primero = nuevo;
            }
            cantidad++;
        }

        public void Eliminar(int indice)
        {
            if (Primero == null || indice < 0 || indice >= cantidad) return;

            if(indice == 0)
            {
                Primero = Primero.Siguiente;
                if (Primero != null)
                {
                    Primero.Anterior = null;
                }
                else
                {
                    Ultimo = null;
                }
            }
            else
            {
                NodoPaciente aux = BuscarNodo(indice);

                aux.Anterior.Siguiente = aux.Siguiente;
                if (aux.Siguiente != null)
                {
                    aux.Siguiente.Anterior = aux.Anterior;
                }
                else
                {
                    Ultimo = aux.Anterior;
                }
            }
            cantidad--;
        }

        public void Actualizar(int indice, string nombres, string apellidos, string direccion, int telefono)
        {
            if (Primero == null || indice < 0 || indice >= cantidad) return;

            NodoPaciente nodo = BuscarNodo(indice);
            nodo.paciente.Nombres = nombres;
            nodo.paciente.Apellidos = apellidos;
            nodo.paciente.Dirección = direccion;
            nodo.paciente.Teléfono = telefono;
        }

        public int ProximoID()
        {
            if (Primero == null)
            {
                return 1;
            }
            int max = BuscarMaximo(Primero, Primero.paciente.Codigo);
            return max + 1;
        }

        public int BuscarMaximo(NodoPaciente n, int cod)
        {
            if (n == null) return cod;

            int max = n.paciente.Codigo > cod ? n.paciente.Codigo : cod;

            if (n.Siguiente != null)
            {
                return BuscarMaximo(n.Siguiente, max);
            }
            return max;
        }

        public NodoPaciente BuscarNodo(int indice)
        {
            NodoPaciente aux = Primero;
            int i = 0;
            while (i < indice)
            {
                aux = aux.Siguiente;
                i++;
            }
            return aux;
        }

        public Paciente ObtenerPaciente(int indice)
        {
            return BuscarNodo(indice).paciente;
        }

        public List<Paciente> MostrarLista()
        {
            List<Paciente> lista = new List<Paciente>();
            NodoPaciente actual = Primero;
            while (actual != null)
            {
                lista.Add(actual.paciente);
                actual = actual.Siguiente;
            }
            return lista;
        }
    }
}
