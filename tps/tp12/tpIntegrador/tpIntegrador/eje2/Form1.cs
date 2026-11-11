using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eje2
{
    public partial class Form1 : Form
    {
        GestorCanciones gestor = new GestorCanciones();
        Cancion cancionActual = null;
        int segundosTranscurridos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Actualizar()
        {
            listBox1.Items.Clear();
            gestor.Mostrar((nombre,duracion) => listBox1.Items.Add(nombre + " - " + duracion + " s"));

            lblTotalCanciones.Text = ("Total canciones: " + gestor.ContarCanciones().ToString());

        }

        private void btnAgregarInicio_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() != "")
            {
                gestor.AgregarInicio(txtNombre.Text, (int)nudDuracion.Value);
                Actualizar();
                txtNombre.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese el nombre de la canción");
            }
        }

        private void btnAgregarFinal_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() != "")
            {
                gestor.AgregarAlFinal(txtNombre.Text, ((int)nudDuracion.Value));
                Actualizar();
            }
            else
            {
                MessageBox.Show("Ingrese el nombre de la canción");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int posicion = listBox1.SelectedIndex + 1;

                gestor.Eliminar(posicion);
                Actualizar();
            }
            else
            {
                MessageBox.Show("Seleccione una canción");
            }
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() != "")
            {
                string nombre = txtNombre.Text;
                int duracion = (int)nudDuracion.Value;
                int posicion = (int)nudPosicion.Value;

                if (gestor.AgregarEnPosicion(nombre, duracion, posicion))
                {
                    Actualizar();
                }
                else
                {
                    MessageBox.Show("Posición inválida");
                }
            }
            else
            {
                MessageBox.Show("Ingrese el nombre de la canción");
            }

        }

        private void btnIntercambiar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una canción");
                return;
            }

            int posicion = listBox1.SelectedIndex + 1;

            if (gestor.IntercambiarDerecha(posicion))
            {
                Actualizar();
            }
            else
            {
                MessageBox.Show("No se puede intercambiar la última canción");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cancionActual == null)
            {
                timer1.Stop();
                return;
            }

            segundosTranscurridos++;

            progressBar1.Value = Math.Min(
                segundosTranscurridos,
                cancionActual.Duracion
            );

            lblTiempo.Text = segundosTranscurridos + " / " +
                             cancionActual.Duracion + " s";

            if (segundosTranscurridos >= cancionActual.Duracion)
            {
                SiguienteCancion();
            }
        }

        private void SiguienteCancion()
        {
            if (cancionActual.Siguiente != null)
            {
                cancionActual = cancionActual.Siguiente;
            }
            else
            {
                cancionActual = gestor.Primero;
            }

            segundosTranscurridos = 0;

            lblCancionActual.Text = cancionActual.Nombre;

            progressBar1.Maximum = cancionActual.Duracion;
            progressBar1.Value = 0;

            lblTiempo.Text = "0 / " + cancionActual.Duracion + " s";
        }

        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            if (gestor.EstaVacia())
            {
                MessageBox.Show("No hay canciones para reproducir");
                return;
            }

            cancionActual = gestor.Primero;
            segundosTranscurridos = 0;

            lblCancionActual.Text = cancionActual.Nombre;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = cancionActual.Duracion;
            progressBar1.Value = 0;

            lblTiempo.Text = "0 / " + cancionActual.Duracion + " s";

            timer1.Start();

            btnEliminar.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (gestor.EstaVacia())
            {
                MessageBox.Show("No hay canciones para pausar");
                return;
            }
            timer1.Stop();

            cancionActual = null;
            segundosTranscurridos = 0;

            lblCancionActual.Text = "Sin reproducción";
            lblTiempo.Text = "0 / 0 s";
            progressBar1.Value = 0;

            btnEliminar.Enabled = true;
        }
    }
}
