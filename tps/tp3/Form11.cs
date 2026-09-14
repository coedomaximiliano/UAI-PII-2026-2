using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej11
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        bool turnoX = true;
        int jugadas = 0;
        private void boton_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            /*
             Este evento se le asigna a cada bóton en su evento de click, esto evita realizar el mismo código para cada botón
            */

            if(boton.Text != "")
            {
                return;
            }

            if (turnoX)
            {
                boton.Text = "X";
            }
            else
            {
                boton.Text = "O";
            }

            jugadas++;

            if (hayGanador())
            {
                if (turnoX)
                {
                    MessageBox.Show("Ganó X!");
                }
                else
                {
                    MessageBox.Show("Ganó O!");
                }

                return;
            }

            if (jugadas == 9)
            {
                MessageBox.Show("Empate");
                return;
            }

            turnoX = !turnoX;
            if (turnoX)
            {
                lblTurno.Text = "Turno de X";
            }
            else
            {
                lblTurno.Text = "Turno de O";
            }
        }

        private bool hayGanador()
        {
            if (btn1.Text != "" && btn1.Text == btn2.Text && btn2.Text == btn3.Text) return true;
            if (btn4.Text != "" && btn4.Text == btn5.Text && btn5.Text == btn6.Text) return true;
            if (btn7.Text != "" && btn7.Text == btn8.Text && btn8.Text == btn9.Text) return true;

            if (btn1.Text != "" && btn1.Text == btn4.Text && btn4.Text == btn7.Text) return true;
            if (btn2.Text != "" && btn2.Text == btn5.Text && btn5.Text == btn8.Text) return true;
            if (btn3.Text != "" && btn3.Text == btn6.Text && btn6.Text == btn9.Text) return true;

            if (btn1.Text != "" && btn1.Text == btn5.Text && btn5.Text == btn9.Text) return true;
            if (btn3.Text != "" && btn3.Text == btn5.Text && btn5.Text == btn7.Text) return true;

            return false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            turnoX = true;
            jugadas = 0;
        }
    }
}
