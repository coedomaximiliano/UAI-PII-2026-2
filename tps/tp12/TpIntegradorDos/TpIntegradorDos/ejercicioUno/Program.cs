using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ejercicioUno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un texto)");
            string text = Console.ReadLine();

            using (FileStream fs = new FileStream("texto.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(text);
                }
            }

            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string backup = "texto." + fecha + ".back";

            File.Copy("texto.txt", backup, true);

            Console.WriteLine("Backup realizado correctamente");
        }
    }
}
