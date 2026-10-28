using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    internal class ListaPacientes
    {
        NodoPaciente NodoInicial = null;

        public void AgregarAlPrincipio(Paciente p)
        {
            NodoPaciente nodo = new NodoPaciente();
            nodo.paciente = p;
            nodo.paciente.Codigo = ProximoID();

            if (NodoInicial == null)
            {
                NodoInicial = nodo;
            }
            else
            {
                nodo.siguiente = NodoInicial;
                NodoInicial = nodo;
            }
        }

        public void AgregarAlFinal(Paciente p)
        {
            NodoPaciente nodo = new NodoPaciente();
            nodo.paciente = p;
            nodo.paciente.Codigo = ProximoID();

            if (NodoInicial == null)
            {
                NodoInicial = nodo;
                return;
            }
            NodoPaciente ultimo = BuscarUltimo(NodoInicial);
            ultimo.siguiente = nodo;
        }

        public void AgregarDespuesDe(int codigoReferencia, Paciente p)
        {
            NodoPaciente referencia = BuscarNodo(NodoInicial, codigoReferencia);
            if (referencia == null)
            {
                return;
            }

            NodoPaciente nodo = new NodoPaciente();
            nodo.paciente = p;
            nodo.paciente.Codigo = ProximoID();
            nodo.siguiente = referencia.siguiente;
            referencia.siguiente = nodo;
        }

        public void QuitarPrimero()
        {
            if (NodoInicial != null)
            {
                NodoInicial = NodoInicial.siguiente;
            }
        }

        public void Eliminar(int codigo)
        {
            if (NodoInicial == null)
            {
                return;
            }

            if (NodoInicial.paciente.Codigo == codigo)
            {
                NodoInicial = NodoInicial.siguiente;
                return;
            }

            NodoPaciente anterior = BuscarAnterior(NodoInicial, codigo);
            if (anterior != null)
            {
                anterior.siguiente = anterior.siguiente.siguiente;
            }
        }

        public void Actualizar(int codigo, string nombres, string apellidos, string direccion, int telefono)
        {
            NodoPaciente nodo = BuscarNodo(NodoInicial, codigo);
            if (nodo != null)
            {
                nodo.paciente.Nombres = nombres;
                nodo.paciente.Apellidos = apellidos;
                nodo.paciente.Dirección = direccion;
                nodo.paciente.Teléfono = telefono;
            }
        }

        public int ProximoID()
        {
            if (NodoInicial == null)
            {
                return 1;
            }
            int max = BuscarMaximo(NodoInicial, NodoInicial.paciente.Codigo);
            return max + 1;
        }

        public int BuscarMaximo(NodoPaciente n, int cod)
        {
            if (n == null) return cod;

            int max = n.paciente.Codigo > cod ? n.paciente.Codigo : cod;

            if (n.siguiente != null)
            {
                return BuscarMaximo(n.siguiente, max);
            }
            return max;
        }

        public NodoPaciente BuscarUltimo(NodoPaciente n)
        {
            if (n == null)
            {
                return null;
            }

            if (n.siguiente != null) return BuscarUltimo(n.siguiente);
            return n;
        }

        public NodoPaciente BuscarAnterior(NodoPaciente n, int cod)
        {
            if (n == null) return null;

            if (n.siguiente != null && n.siguiente.paciente.Codigo == cod)
                return n;

            return BuscarAnterior(n.siguiente, cod);
        }

        public NodoPaciente BuscarNodo(NodoPaciente n, int cod)
        {
            if (n == null) return null;

            if (n.paciente.Codigo == cod) return n;

            return BuscarNodo(n.siguiente, cod);
        }

        public List<Paciente> ObtenerListaNormal()
        {
            List<Paciente> listaNormal = new List<Paciente>();
            NodoPaciente actual = NodoInicial;

            while (actual != null)
            {
                listaNormal.Add(actual.paciente);
                actual = actual.siguiente;
            }

            return listaNormal;
        }

    }
}
