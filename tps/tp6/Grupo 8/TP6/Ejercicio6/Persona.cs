using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Persona
    {
        public string nombre;
        public bool ConTicket;

        private static Random rnd = new Random();

        public Persona(string n)
        {
            nombre = n;
            int r = rnd.Next(0, 100);
            this.ConTicket = (r % 2 == 0);
        }

        public override string ToString()
        {
            string cs;
            if (this.ConTicket) cs = "con";
            else cs = "sin"; 
            return $"{nombre} | {cs} Ticket";
        }
    }
}
