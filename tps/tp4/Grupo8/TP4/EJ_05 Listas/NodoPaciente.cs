using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_05_Listas
{
    internal class NodoPaciente
    {
        public NodoPaciente(Paciente p)
        {
            this.paciente = p;
        }

        public NodoPaciente Anterior;
        public Paciente paciente;
        public NodoPaciente Siguiente;
    }
}
