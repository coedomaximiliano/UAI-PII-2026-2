using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp3Ej11
{
    public partial class Form1 : Form
    {
        Button[] botones;
        string turno = "X";
        bool terminado = false;

        public Form1()
        {
            InitializeComponent();

            botones = new Button[]
            {
                btn1, btn2, btn3,
                btn4, btn5, btn6,
                btn7, btn8, btn9
            };

            foreach (Button boton in botones)
            {
                boton.Click += boton_Click;
            }

            lblTurno.Text = "Turno: X";
        }

        private void boton_Click(object sender, EventArgs e)
        {
            if (terminado)
                return;

            Button boton = (Button)sender;

            if (boton.Text != "")
                return;

            boton.Text = turno;

            if (HayGanador())
            {
                MessageBox.Show("¡Ganó el jugador " + turno + "!");
                terminado = true;
                lblTurno.Text = "Ganador: " + turno;
            }
            else if (Empate())
            {
                MessageBox.Show("¡Empate!");
                terminado = true;
                lblTurno.Text = "Empate";
            }
            else
            {
                if (turno == "X")
                    turno = "O";
                else
                    turno = "X";

                lblTurno.Text = "Turno: " + turno;
            }
        }

        private bool HayGanador()
        {
            int[,] combinaciones =
            {
                {0,1,2}, {3,4,5}, {6,7,8},
                {0,3,6}, {1,4,7}, {2,5,8},
                {0,4,8}, {2,4,6}
            };

            for (int i = 0; i < 8; i++)
            {
                int a = combinaciones[i, 0];
                int b = combinaciones[i, 1];
                int c = combinaciones[i, 2];

                if (botones[a].Text != "" &&
                    botones[a].Text == botones[b].Text &&
                    botones[b].Text == botones[c].Text)
                {
                    return true;
                }
            }

            return false;
        }

        private bool Empate()
        {
            foreach (Button boton in botones)
            {
                if (boton.Text == "")
                    return false;
            }

            return true;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            foreach (Button boton in botones)
            {
                boton.Text = "";
            }

            turno = "X";
            terminado = false;
            lblTurno.Text = "Turno: X";
        }
    }
}
