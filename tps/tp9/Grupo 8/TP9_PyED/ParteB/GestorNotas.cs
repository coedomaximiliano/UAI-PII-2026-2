using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParteB
{
    public class GestorNotas
    {
        string archivo;
        string auxiliar;

        public GestorNotas()
        {
            archivo = "notas.txt";
            auxiliar = "notasAux.txt";
        }

        public Nota Buscar(long dni, DateTime fecha)
        {
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Nota unaNota = new Nota(linea);

                    if (unaNota.DNI == dni && unaNota.Fecha.Date == fecha.Date)
                    {
                        fs.Close();
                        return unaNota;
                    }

                    linea = reader.ReadLine();
                }
            }
            fs.Close();
            return null;
        }

        public bool Alta(Nota unaNota, GestorAlumnos gestorAlumnos)
        {
            if (gestorAlumnos.Buscar(unaNota.DNI) == null)
            {
                return false;
            }

            if (Buscar(unaNota.DNI, unaNota.Fecha) != null)
            {
                return false;
            }

            FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(unaNota.GenerarRegistro());
            }
            fs.Close();
            return true;
        }

        public bool Baja(long dni, DateTime fecha)
        {
            bool encontrado = false;
            string output = string.Empty;

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Nota unaNota = new Nota(linea);

                    if (unaNota.DNI == dni && unaNota.Fecha.Date == fecha.Date)
                    {
                        encontrado = true;
                    }
                    else
                    {
                        output += linea + Environment.NewLine;
                    }

                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            if (encontrado)
            {
                fs = new FileStream(auxiliar, FileMode.Create, FileAccess.Write);
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write(output);
                }
                fs.Close();

                ReemplazarOriginal();
            }

            return encontrado;
        }

        public bool Modificar(long dni, DateTime fecha, Nota conDatosNuevos, GestorAlumnos gestorAlumnos)
        {
            if ((dni != conDatosNuevos.DNI || fecha.Date != conDatosNuevos.Fecha.Date) &&
                Buscar(conDatosNuevos.DNI, conDatosNuevos.Fecha) != null)
            {
                return false;
            }

            if (gestorAlumnos.Buscar(conDatosNuevos.DNI) == null)
            {
                return false;
            }

            bool encontrado = false;
            string output = string.Empty;

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Nota unaNota = new Nota(linea);

                    if (unaNota.DNI == dni && unaNota.Fecha.Date == fecha.Date)
                    {
                        output += conDatosNuevos.GenerarRegistro() + Environment.NewLine;
                        encontrado = true;
                    }
                    else
                    {
                        output += linea + Environment.NewLine;
                    }

                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            if (encontrado)
            {
                fs = new FileStream(auxiliar, FileMode.Create, FileAccess.Write);
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write(output);
                }
                fs.Close();

                ReemplazarOriginal();
            }

            return encontrado;
        }

        public List<Nota> NotasDeAlumno(long dni)
        {
            List<Nota> lista = new List<Nota>();

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Nota unaNota = new Nota(linea);

                    if (unaNota.DNI == dni)
                    {
                        lista.Add(unaNota);
                    }

                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            return lista;
        }

        public void CambiarDNI(long dniAnterior, long dniNuevo)
        {
            bool cambio = false;
            string output = string.Empty;

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Nota unaNota = new Nota(linea);

                    if (unaNota.DNI == dniAnterior)
                    {
                        unaNota.DNI = dniNuevo;
                        output += unaNota.GenerarRegistro() + Environment.NewLine;
                        cambio = true;
                    }
                    else
                    {
                        output += linea + Environment.NewLine;
                    }

                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            if (cambio)
            {
                fs = new FileStream(auxiliar, FileMode.Create, FileAccess.Write);
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write(output);
                }
                fs.Close();

                ReemplazarOriginal();
            }
        }

        private void ReemplazarOriginal()
        {
            File.Delete(archivo);
            File.Move(auxiliar, archivo);
        }

        public List<Nota> Lista()
        {
            List<Nota> lista = new List<Nota>();

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);

            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Nota unaNota = new Nota(linea);
                    lista.Add(unaNota);
                    linea = reader.ReadLine();
                }
            }

            fs.Close();

            return lista;
        }
    }
}
