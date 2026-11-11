using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10_PyED
{
    public class GestorPromedios
    {
        string archivo;

        public GestorPromedios()
        {
            archivo = "promedios.txt";
        }

        public List<Promedio> Calcular(GestorAlumnos gestorAlumnos, GestorNotas gestorNotas)
        {
            List<Promedio> promedios = new List<Promedio>();

            List<Alumno> alumnos = gestorAlumnos.Ordenar();
            List<Nota> notas = gestorNotas.Ordenar();

            int mae = 0;
            int nov = 0;

            while (mae < alumnos.Count && nov < notas.Count)
            {
                if (alumnos[mae].DNI < notas[nov].DNI)
                {
                    Promedio promedio = new Promedio(alumnos[mae].DNI, alumnos[mae].Apellido);
                    promedio.ValorPromedio = 0;
                    promedios.Add(promedio);

                    mae++;
                }
                else if (alumnos[mae].DNI > notas[nov].DNI)
                {
                    nov++;
                }
                else
                {
                    Promedio promedio = new Promedio(alumnos[mae].DNI, alumnos[mae].Apellido);
                    int acumulador = 0;
                    int contador = 0;

                    while (nov < notas.Count && notas[nov].DNI == alumnos[mae].DNI)
                    {
                        contador++;
                        acumulador += notas[nov].Valor;
                        nov++;
                    }

                    promedio.ValorPromedio = contador == 0 ? 0 : Math.Round((double)acumulador / contador, 2, MidpointRounding.AwayFromZero);
                    promedios.Add(promedio);

                    mae++;
                }
            }

            while (mae < alumnos.Count)
            {
                Promedio promedio = new Promedio(alumnos[mae].DNI, alumnos[mae].Apellido);
                promedio.ValorPromedio = 0;
                promedios.Add(promedio);

                mae++;
            }

            return promedios;
        }

        public void Guardar(List<Promedio> promedios)
        {
            FileStream fs = new FileStream(archivo, FileMode.Create, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                foreach (Promedio unPromedio in promedios)
                {
                    writer.WriteLine(unPromedio.GenerarRegistro());
                }
            }
            fs.Close();
        }

        public List<Promedio> Lista()
        {
            List<Promedio> lista = new List<Promedio>();

            if (!File.Exists(archivo))
            {
                return lista;
            }

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);

            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Promedio unPromedio = new Promedio(linea);
                    lista.Add(unPromedio);
                    linea = reader.ReadLine();
                }
            }

            fs.Close();

            return lista;
        }
    }
}
