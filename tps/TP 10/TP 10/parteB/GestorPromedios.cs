using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace parteB
{
    // Los archivos se ordenan por DNI antes del apareo.
    public class PromedioAlumno
    {
        public long Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Cantidad { get; set; }
        public decimal Promedio { get; set; }
    }

    public class GestorPromedios
    {
        public readonly string RutaAlumnos;
        public readonly string RutaNotas;
        public readonly string RutaPromedios;
        public GestorPromedios(string directorio)
        {
            RutaAlumnos = Path.Combine(directorio, "alumnos.txt");
            RutaNotas = Path.Combine(directorio, "notas.txt");
            RutaPromedios = Path.Combine(directorio, "promedios.txt");
        }

        private static long DniDe(string linea)
        {
            long dni;
            if (!long.TryParse(linea.Split(';')[0], out dni))
                throw new InvalidDataException("DNI inválido en registro: " + linea);
            return dni;
        }

        public void OrdenarArchivos()
        {
            Ordenar(RutaAlumnos);
            Ordenar(RutaNotas);
        }
        private static void Ordenar(string ruta)
        {
            if (!File.Exists(ruta)) File.WriteAllText(ruta, "");
            var registros = File.ReadAllLines(ruta).Where(x => !string.IsNullOrWhiteSpace(x))
                .OrderBy(DniDe).ToArray();
            File.WriteAllLines(ruta, registros);
        }

        // Apareo secuencial: las notas se leen una sola vez, sin recorrer
        // un vector completo para cada alumno. Corte de control por DNI.
        public List<PromedioAlumno> Calcular()
        {
            OrdenarArchivos();
            var resultado = new List<PromedioAlumno>();
            using (var alumnos = new StreamReader(RutaAlumnos))
            using (var notas = new StreamReader(RutaNotas))
            {
                string lineaNota = notas.ReadLine();
                string lineaAlumno;
                while ((lineaAlumno = alumnos.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(lineaAlumno)) continue;
                    string[] a = lineaAlumno.Split(';');
                    if (a.Length < 3) throw new InvalidDataException("Alumno inválido: " + lineaAlumno);
                    long dni = DniDe(lineaAlumno);
                    decimal suma = 0;
                    int cantidad = 0;
                    while (lineaNota != null && DniDe(lineaNota) < dni)
                        lineaNota = notas.ReadLine();
                    while (lineaNota != null && DniDe(lineaNota) == dni)
                    {
                        string[] n = lineaNota.Split(';');
                        decimal valor;
                        if (n.Length < 2 || !decimal.TryParse(n[1], NumberStyles.Number,
                            CultureInfo.CurrentCulture, out valor) &&
                            !decimal.TryParse(n[1], NumberStyles.Number, CultureInfo.InvariantCulture, out valor))
                            throw new InvalidDataException("Nota inválida: " + lineaNota);
                        suma += valor;
                        cantidad++;
                        lineaNota = notas.ReadLine();
                    }
                    resultado.Add(new PromedioAlumno {
                        Dni = dni, Nombre = a[1], Apellido = a[2], Cantidad = cantidad,
                        Promedio = cantidad == 0 ? 0 : Math.Round(suma / cantidad, 2)
                    });
                }
            }
            return resultado;
        }

        public void Guardar(IEnumerable<PromedioAlumno> promedios)
        {
            File.WriteAllLines(RutaPromedios, promedios.Select(p => string.Join(";",
                p.Dni, p.Nombre, p.Apellido, p.Cantidad,
                p.Promedio.ToString(CultureInfo.InvariantCulture))));
        }
        public List<PromedioAlumno> Leer()
        {
            var resultado = new List<PromedioAlumno>();
            if (!File.Exists(RutaPromedios)) return resultado;
            foreach (string linea in File.ReadAllLines(RutaPromedios))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                string[] p = linea.Split(';');
                if (p.Length != 5) continue;
                long dni; int cantidad; decimal promedio;
                if (long.TryParse(p[0], out dni) && int.TryParse(p[3], out cantidad) &&
                    decimal.TryParse(p[4], NumberStyles.Number, CultureInfo.InvariantCulture, out promedio))
                    resultado.Add(new PromedioAlumno { Dni = dni, Nombre = p[1], Apellido = p[2],
                        Cantidad = cantidad, Promedio = promedio });
            }
            return resultado;
        }
    }
}
