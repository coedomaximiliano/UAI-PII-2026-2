using System;

namespace TP10_PyED
{
    public class Nota
    {
        public long DNI { get; set; }
        public int Valor { get; set; }
        public DateTime Fecha { get; set; }

        public Nota(long dni, int valor, DateTime fecha)
        {
            this.DNI = dni;
            this.Valor = valor;
            this.Fecha = fecha;
        }

        public Nota(string linea)
        {
            string[] datos = linea.Split(';');

            this.DNI = long.Parse(datos[0]);
            this.Valor = int.Parse(datos[1]);
            this.Fecha = DateTime.ParseExact(datos[2], "dd/MM/yyyy", null);
        }

        public string GenerarRegistro()
        {
            return DNI + ";" + Valor + ";" + Fecha.ToString("dd/MM/yyyy");
        }

        public override string ToString()
        {
            return DNI + ";" + Valor + ";" + Fecha.ToString("dd/MM/yyyy");
        }
    }
}
