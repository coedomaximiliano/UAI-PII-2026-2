using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp3Ej8
{
    public partial class Form1 : Form
    {
        Random azar = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            int dado = azar.Next(1, 7);

            lblResultado.Text = dado.ToString();
        }
    }
}
