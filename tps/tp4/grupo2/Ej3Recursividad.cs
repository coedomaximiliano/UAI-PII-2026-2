using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int[] vector = { 8, 3, 9, 1, 5, 2, 7, 4, 6 };

            lblVectorOriginal.Text = MostrarVector(vector);

            Ordenar(vector, vector.Length);

            lblVectorOrdenado.Text = MostrarVector(vector);
        }

        private string MostrarVector(int[] vector)
        {
            string resultado = "";

            for (int i = 0; i < vector.Length; i++)
            {
                resultado += vector[i] + " ";
            }

            return resultado;
        }

        private void Ordenar(int[] vector, int n)
        {
            if (n <= 1)
            {
                return;
            }

            for (int i = 0; i < n - 1; i++)
            {
                if (vector[i] > vector[i + 1])
                {
                    int auxiliar = vector[i];
                    vector[i] = vector[i + 1];
                    vector[i + 1] = auxiliar;
                }
            }

            Ordenar(vector, n - 1);
        }
    }
}
