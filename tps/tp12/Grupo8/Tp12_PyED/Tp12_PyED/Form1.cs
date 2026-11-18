using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tp12_PyED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cola cola = new Cola();
        List<string> PasajerosABordo = new List<string>();

        bool HayLugar() //chequea si hay lugares disponibles
        {
            return PasajerosABordo.Count < PasajerosABordo.Capacity;
        }

        void Enlazar() // enlaza la cola con la listbox usando el metodo listar
        {
            Pasajeros.DataSource = null;
            Pasajeros.DataSource = cola.Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10000; //se define intervalo de ticks del timer
            PasajerosABordo.Capacity = 19; //se define la capacidad y se enlaza a la cola 
            Enlazar();
        }

        private void BtnAnotar_Click(object sender, EventArgs e) //se anota el contenido de la textbox 
        {
            cola.Anotar(TbPasajero.Text);
            TbPasajero.Text = "";
            Enlazar();
        }

        private void BtnSubir_Click(object sender, EventArgs e)
        {
            if (HayLugar()) //si hay lugar los sube, si no hay lugar no hace nada y muestra un messagebox
            {
                PasajerosABordo.Add(cola.Subir()); //se agrega a los pasajeros de la combi el dato retornado por el metodo Subir()
                Enlazar();
            }
            else
            {
                MessageBox.Show("La combi está llena");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cola.EstaVacia() && PasajerosABordo.Count == 0)  //si la cola esta vacia y no hay pasajeros a bordo el bondi se va y no se pueden anotar ni subir pasajeros
            {
                MessageBox.Show("Partiendo hasta la terminal de puerto madero");
                BtnSubir.Enabled = false;
                BtnAnotar.Enabled = false;
                TbPasajero.Enabled = false;
            }
            if (PasajerosABordo.Count > 0) //si hay mas de 0 pasajeros a bordo el tintervalo cambia a 2000 ms
            {
                timer1.Interval = 2000;
            }
            if (!HayLugar()) //si no hay lugar (está lleno) se va con todos los pasajeros y el timer se desactiva
            {
                MessageBox.Show("Emprendiendo viaje");
                timer1.Enabled = false;
            }
        }
    }
}
