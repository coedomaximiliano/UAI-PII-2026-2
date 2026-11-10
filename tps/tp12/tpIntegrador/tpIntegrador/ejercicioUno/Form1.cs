using System;
using System.Windows.Forms;

namespace ejercicioUno
{
    public partial class Form1 : Form
    {
        GestorCombi gestor = new GestorCombi();

        int pasajerosEnCombi = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Agrega pasajeros a la lista de espera.
        private void btnAnotar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPasajero.Text))
            {
                MessageBox.Show("Ingrese un pasajero");
                return;
            }

            gestor.Anotar(txtPasajero.Text.Trim());

            txtPasajero.Clear();

            Actualizar();
        }

        // Quita un pasajero de la espera y lo sube a la combi.
        private void btnSubir_Click(object sender, EventArgs e)
        {
            // Controla que no se superen los 19 lugares.
            if (pasajerosEnCombi == 19)
            {
                MessageBox.Show("La combi está llena");
                return;
            }

            Pasajero pasajero = gestor.SubirPasajero();

            if (pasajero != null)
            {
                // Incrementa la cantidad de pasajeros
                // que están dentro de la combi.
                pasajerosEnCombi++;

                Actualizar();

                if (pasajerosEnCombi == 19)
                {
                    MessageBox.Show(
                        "La combi está llena. Puede emprender viaje.");
                }
                else if (gestor.ContarPasajeros() == 0)
                {
                    MessageBox.Show(
                        "La combi espera más pasajeros");
                }
            }
            else
            {
                // Si nadie espera y la combi está vacía,
                // debe dirigirse a Puerto Madero.
                if (pasajerosEnCombi == 0)
                {
                    MessageBox.Show(
                        "La combi debe ir a la terminal de Puerto Madero");
                }
                else
                {
                    MessageBox.Show(
                        "La combi espera más pasajeros");
                }
            }
        }

        // Actualiza el ListBox con los pasajeros en espera.
        private void Actualizar()
        {
            lsbPasajeros.Items.Clear();

            gestor.MostrarLista(nombre =>
                lsbPasajeros.Items.Add(nombre));
        }
    }
}