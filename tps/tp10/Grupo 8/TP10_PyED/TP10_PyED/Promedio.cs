namespace TP10_PyED
{
    public class Promedio
    {

        public Promedio(long dni, string apellido)
        {
            this.DNI = dni;
            this.Apellido = apellido;
        }

        public Promedio(string linea)
        {
            string[] datos = linea.Split(';');

            this.DNI = long.Parse(datos[0]);
            this.Apellido = datos[1];
            this.ValorPromedio = double.Parse(datos[2]);
        }

        public long DNI { get; set; }
        public string Apellido { get; set; }
        public double ValorPromedio { get; set; }

        public string GenerarRegistro()
        {
            return DNI + ";" + Apellido + ";" + ValorPromedio;
        }

        public override string ToString()
        {
            return DNI + " - " + Apellido + " - " + ValorPromedio;
        }
    }
}
