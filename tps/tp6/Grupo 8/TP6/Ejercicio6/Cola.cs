using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Cola
    {
        NodoCola Frente;
        NodoCola Ultimo;

        public void vaciar()
        {
            Frente = null;
            Ultimo = null;
        }

        public bool EstaVacia()
        {
            return Frente == null;
        }

        public void Encolar(Persona persona)
        {
            NodoCola nuevo = new NodoCola(persona);
            if (EstaVacia()) Frente = nuevo;
            else Ultimo.siguiente = nuevo;
            Ultimo = nuevo;
        }

        public Persona Desencolar()
        {
            if (EstaVacia()) throw new Exception();
            Persona p = Frente.persona;
            Frente = Frente.siguiente;
            return p;
        }

        public string VerFrente()
        {
            if (EstaVacia()) return "La cola está vacía";
            return Frente.persona.ToString();
        }

        public List<string> Listar()
        {
            
            List<string> lista = new List<string>();
            NodoCola aux = Frente;
            while(aux != null)
            {
                lista.Add(aux.persona.ToString());
                aux = aux.siguiente;
            }
            return lista;
        }

        public void GenerarCola()
        {
            string extra;
            for(int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 1:
                        extra = "pa";
                        break;
                    case 2:
                        extra = "zo";
                        break;
                    case 3:
                        extra = "rra";
                        break;
                    default:
                        extra = "";
                        break;
                }
                Encolar(new Persona($"Juan{extra}"));
                Encolar(new Persona($"Marta{extra}"));
                Encolar(new Persona($"Domi{extra}"));
                Encolar(new Persona($"Jere{extra}"));
                Encolar(new Persona($"Maru{extra}"));
            }
        }
    }
}
