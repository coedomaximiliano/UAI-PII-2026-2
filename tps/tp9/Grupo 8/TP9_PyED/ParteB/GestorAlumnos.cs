using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParteB
{
    public class GestorAlumnos
    {
        string archivo;
        string auxiliar;

        public GestorAlumnos()
        {
            archivo = "alumnos.txt";
            auxiliar = "alumnosAux.txt";
        }

        public Alumno Buscar(long dni)
        {
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Alumno unAlumno = new Alumno(linea);

                    if (unAlumno.DNI == dni)
                    {
                        fs.Close();
                        return unAlumno;
                    }

                    linea = reader.ReadLine();
                }
            }
            fs.Close();
            return null;
        }

        public bool Alta(Alumno unAlumno)
        {
            if (Buscar(unAlumno.DNI) != null)
            {
                return false;
            }

            FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(unAlumno.GenerarRegistro());
            }
            fs.Close();
            return true;
        }

        public bool Baja(long dni)
        {
            bool encontrado = false;

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Alumno unAlumno = new Alumno(linea);

                    if (unAlumno.DNI == dni)
                    {
                        encontrado = true;
                    }

                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            if (encontrado)
            {
                CopiarSin(dni);

                ReemplazarOriginal();
            }

            return encontrado;
        }

        public bool Modificar(long dniAnterior, Alumno conDatosNuevos)
        {
            Alumno buscado = Buscar(dniAnterior);
            if (buscado == null)
            {
                return false;
            }

            if (dniAnterior != conDatosNuevos.DNI && Buscar(conDatosNuevos.DNI) != null)
            {
                return false;
            }

            bool encontrado = false;

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            using (StreamWriter writer = new StreamWriter(auxiliar, false))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Alumno unAlumno = new Alumno(linea);

                    if (unAlumno.DNI == dniAnterior)
                    {
                        linea = conDatosNuevos.GenerarRegistro();
                        encontrado = true;
                    }

                    writer.WriteLine(linea);

                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            if (encontrado)
            {
                if (dniAnterior != conDatosNuevos.DNI)
                {
                    GestorNotas gestorNotas = new GestorNotas();
                    gestorNotas.CambiarDNI(dniAnterior, conDatosNuevos.DNI);
                }

                ReemplazarOriginal();
            }

            return encontrado;
        }

        private void CopiarSin(long dni)
        {
            string output = string.Empty;
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();

                while (linea != null)
                {
                    Alumno unAlumno = new Alumno(linea);

                    if (unAlumno.DNI != dni)
                    {
                        output += linea + Environment.NewLine;
                    }

                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            fs = new FileStream(auxiliar, FileMode.Create, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(output);
            }
            fs.Close();
        }

        private void ReemplazarOriginal()
        {
            File.Delete(archivo);
            File.Move(auxiliar, archivo);
        }

        public List<Alumno> Lista()
        {
            List<Alumno> lista = new List<Alumno>();

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);

            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Alumno unAlumno = new Alumno(linea);
                    lista.Add(unAlumno);
                    linea = reader.ReadLine();
                }
            }

            fs.Close();

            return lista;
        }
    }
}
