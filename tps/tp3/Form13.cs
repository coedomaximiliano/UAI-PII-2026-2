using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej13
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();

            archivo.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(archivo.FileName);
            }
        }
    }
}
