using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ejercicio_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListaReproduccion lista = new ListaReproduccion();
        NodoCancion Reproduciendo = null; //nodo de la canción que está sonando
        int SegundosRestantes; //contador de la reproducción simulada

        void Enlazar() //enlaza la lista con la listbox usando el listar recursivo
        {
            ListaCanciones.DataSource = null;
            ListaCanciones.DataSource = lista.Listar();
            lblTotalCanciones.Text = "Total de canciones: " + lista.Contar(); //el contar también es recursivo
        }

        void MostrarReproduciendo() //actualiza el label con la canción en curso
        {
            if (Reproduciendo == null)
            {
                LblReproduciendo.Text = "Detenido";
                return;
            }
            LblReproduciendo.Text = "Reproduciendo: " + Reproduciendo.Nombre + " (quedan " + SegundosRestantes + " seg)";
        }

        bool LeerCancion(out int duracion) //valida los textbox y avisa si hay error
        {
            if (TbNombre.Text == "")
            {
                MessageBox.Show("Escriba el nombre de la canción");
                duracion = 0;
                return false;
            }
            if (!int.TryParse(TbDuracion.Text, out duracion))
            {
                MessageBox.Show("La duración debe ser un número de segundos");
                return false;
            }
            return true;
        }

        void Limpiar() //limpia los textbox
        {
            TbNombre.Text = "";
            TbDuracion.Text = "";
            TbPosicion.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; //1 tick = 1 segundo de reproducción
            Enlazar();
        }

        private void BtnAgregarPrincipio_Click(object sender, EventArgs e)
        {
            int duracion;
            if (LeerCancion(out duracion)) //valida los datos
            {
                lista.AgregarAlPrincipio(TbNombre.Text, duracion);
                Limpiar();
                Enlazar();
            }
        }

        private void BtnAgregarFinal_Click(object sender, EventArgs e)
        {
            int duracion;
            if (LeerCancion(out duracion))
            {
                lista.AgregarAlFinal(TbNombre.Text, duracion);
                Limpiar();
                Enlazar();
            }
        }

        private void BtnAgregarPosicion_Click(object sender, EventArgs e)
        {
            int duracion, posicion;
            if (LeerCancion(out duracion) && int.TryParse(TbPosicion.Text, out posicion)) //valida duración y posición
            {
                lista.AgregarEnPosicion(posicion, TbNombre.Text, duracion);
                Limpiar();
                Enlazar();
            }
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            if (ListaCanciones.SelectedItem == null) //si no hay nada seleccionado avisa
            {
                MessageBox.Show("Debe seleccionar una canción");
                return;
            }
            NodoCancion elegida = lista.BuscarPosicion(ListaCanciones.SelectedIndex + 1); //busca el nodo según la posición seleccionada
            lista.QuitarPosicion(elegida.Numero);
            if (Reproduciendo == elegida) //si se quitó la que sonaba pasa a la primera
            {
                Reproduciendo = lista.Primero();
                SegundosRestantes = Reproduciendo != null ? Reproduciendo.Duracion : 0;
            }
            Enlazar();
            MostrarReproduciendo();
        }

        private void BtnIntercambiar_Click(object sender, EventArgs e)
        {
            if (ListaCanciones.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una canción");
                return;
            }
            NodoCancion elegida = lista.BuscarPosicion(ListaCanciones.SelectedIndex + 1);
            lista.IntercambiarDerecha(elegida.Numero); //alterna el orden con la canción de su derecha
            Enlazar();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (lista.EstaVacia()) //no se puede reproducir una lista vacía
            {
                MessageBox.Show("La lista de reproducción está vacía");
                return;
            }
            if (Reproduciendo == null) //si no estaba sonando arranca la primera
            {
                Reproduciendo = lista.Primero();
                SegundosRestantes = Reproduciendo.Duracion;
            }
            timer1.Enabled = true; //el timer hace avanzar la reproducción
            MostrarReproduciendo();
        }

        private void BtnPausa_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false; //frena el timer dejando la canción a mitad
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false; //corta la reproducción y vuelve al inicio
            Reproduciendo = null;
            MostrarReproduciendo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SegundosRestantes--; //pasa un segundo de la canción
            if (SegundosRestantes > 0)
            {
                MostrarReproduciendo();
                return;
            }
            //al terminar la canción pasa a la siguiente; por ser circular,
            //desde la última vuelve a la primera y repite la lista
            Reproduciendo = Reproduciendo.Siguiente;
            SegundosRestantes = Reproduciendo.Duracion;
            MostrarReproduciendo();
        }
    }
}
