using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioDos
{

    internal class Program
    {
        static int[] piezasNecesarias = new int[201];
        public static void CrearArchivos(string ruta) 
        {
            if (!File.Exists(ruta))
            {
                File.Create(ruta).Close();
            }
        }

        public static void CargarArchivos()
        {
            //Cargo Pedidos
            using (StreamWriter sw = new StreamWriter("Pedidos.txt", false))
            {
                sw.WriteLine("1;100;20");
                sw.WriteLine("1;101;30");
                sw.WriteLine("1;102;15");
                sw.WriteLine("2;100;10");
                sw.WriteLine("2;103;25");
                sw.WriteLine("3;101;40");
            }

            //Cargo Stock Modelos
            using (StreamWriter sw = new StreamWriter("Modelos.txt", false))
            {
                sw.WriteLine("1;Modelo A;50");
                sw.WriteLine("2;Modelo B;20");
                sw.WriteLine("3;Modelo C;30");
            }

            //Cargo Stock Piezas
            using (StreamWriter sw = new StreamWriter("Piezas.txt", false))
            {
                sw.WriteLine("1;Rueda;100");
                sw.WriteLine("2;Motor;30");
                sw.WriteLine("3;Puerta;80");
                sw.WriteLine("4;Asiento;100");
            }

            //Cargo 
            using (StreamWriter sw = new StreamWriter("Composicion.txt", false))
            {
                    sw.WriteLine("1;1;4");
                    sw.WriteLine("1;2;1");
                    sw.WriteLine("1;3;2");

                    sw.WriteLine("2;1;4");
                    sw.WriteLine("2;2;1");
                    sw.WriteLine("2;4;5");

                    sw.WriteLine("3;1;4");
                    sw.WriteLine("3;2;1");
                    sw.WriteLine("3;3;4");
            }
        }

        public static void ProcesarPedidos()
        {
            using (StreamReader sr = new StreamReader("Pedidos.txt"))
            {
                string linea = sr.ReadLine();

                Console.WriteLine("=============== STOCK DE MODELOS ===============");
                Console.WriteLine();

                Console.WriteLine(
                    "Modelo".PadRight(12) +
                    "Stock inicial".PadRight(18) +
                    "Pedidos".PadRight(14) +
                    "Stock final".PadRight(16) +
                    "A fabricar".PadRight(16) +
                    "Se adeudan"
                );

                Console.WriteLine(new string('-', 90));

                while (linea != null)
                {
                    string[] datos = linea.Split(';');

                    int modeloActual = int.Parse(datos[0]);
                    int totalPedido = 0;

                    // Corte de control
                    while (linea != null && int.Parse(datos[0]) == modeloActual)
                    {
                        totalPedido += int.Parse(datos[2]);

                        linea = sr.ReadLine();

                        if (linea != null)
                        {
                            datos = linea.Split(';');
                        }
                    }

                    int stock = BuscarStock(modeloActual);
                    int stockFinal = 0;
                    int aFabricar = 0;
                    int seAdeudan = 0;

                    if (totalPedido > stock)
                    {
                        aFabricar = totalPedido - stock;
                        seAdeudan = aFabricar;
                    }
                    else
                    {
                        stockFinal = stock - totalPedido;
                    }

                    // Mostrar resultado en tabla
                    Console.WriteLine(
                        modeloActual.ToString().PadRight(12) +
                        stock.ToString().PadRight(18) +
                        totalPedido.ToString().PadRight(14) +
                        stockFinal.ToString().PadRight(16) +
                        aFabricar.ToString().PadRight(16) +
                        seAdeudan.ToString()
                    );

                    // Acumular las piezas necesarias
                    if (aFabricar > 0)
                    {
                        ProcesarComposicion(modeloActual, aFabricar);
                    }
                }

                Console.WriteLine();
            }
        }

        public static int BuscarStock(int modeloBuscado)
        {
            using(StreamReader sr = new StreamReader("Modelos.txt"))
            {
                string linea;

                while ((linea = sr.ReadLine()) != null)
                {
                    string[] datos = linea.Split(';');

                    int modelo = int.Parse(datos[0]);
                    int stock = int.Parse(datos[2]);

                    if (modelo == modeloBuscado)
                    {
                        return stock;
                    }
                }
                return 0;
            }
        }

static void ProcesarComposicion(int modeloBuscado, int cantidadFabricar)
        {
            using (StreamReader sr = new StreamReader("Composicion.txt"))
            {
                string linea;

                while((linea = sr.ReadLine()) != null)
                {
                    string []  datos = linea.Split(';');

                    int modelo = int.Parse(datos[0]);
                    int pieza = int.Parse(datos[1]);
                    int cantidadPorAuto = int.Parse(datos[2]);

                    if(modelo == modeloBuscado)
                    {
                        piezasNecesarias[pieza] += cantidadFabricar * cantidadPorAuto;
                    }
                }
            }
        }

        static void ProcesarPiezas()
        {
            using (StreamReader sr = new StreamReader("Piezas.txt"))
            {
                string linea;

                Console.WriteLine("============== STOCK DE PIEZAS ==============");
                Console.WriteLine();

                Console.WriteLine(
                    "Pieza".PadRight(20) +
                    "Stock inicial".PadRight(18) +
                    "Stock final".PadRight(18) +
                    "Cantidad a comprar"
                );

                Console.WriteLine(new string('-', 80));

                while ((linea = sr.ReadLine()) != null)
                {
                    string[] datos = linea.Split(';');

                    int pieza = int.Parse(datos[0]);
                    string descripcion = datos[1];
                    int stock = int.Parse(datos[2]);

                    int necesarias = piezasNecesarias[pieza];
                    int comprar = 0;
                    int stockFinal = 0;

                    if (necesarias > stock)
                    {
                        comprar = necesarias - stock;
                    }
                    else
                    {
                        stockFinal = stock - necesarias;
                    }

                    Console.WriteLine(
                        (pieza + " - " + descripcion).PadRight(20) +
                        stock.ToString().PadRight(18) +
                        stockFinal.ToString().PadRight(18) +
                        comprar.ToString()
                    );
                }
            }
        }

        static void Main(string[] args)
        {
            CrearArchivos("Pedidos.txt");
            CrearArchivos("Modelos.txt");
            CrearArchivos("Piezas.txt");
            CrearArchivos("Composicion.txt");

            //CargarArchivos();

            ProcesarPedidos();
            ProcesarPiezas();

            Console.ReadKey();




        }
    }
}
