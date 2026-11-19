using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tp9
{
    public partial class Form1 : Form
    {
        ArbolBinario arbol = new ArbolBinario();

        TreeView treeViewArbol = new TreeView();

        TextBox txtDato = new TextBox();

        Label lblResultado = new Label();

        public Form1()
        {
            InitializeComponent();

            CrearInterfaz();
        }

        // CREAR INTERFAZ
        private void CrearInterfaz()
        {
            this.Text = "TP9 - Arbol Binario";
            this.Width = 850;
            this.Height = 570;
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblTitulo = new Label();

            lblTitulo.Text = "TP 9 - ARBOL BINARIO";
            lblTitulo.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTitulo.Location = new Point(25, 20);
            lblTitulo.AutoSize = true;

            Label lblDato = new Label();

            lblDato.Text = "Dato del nodo:";
            lblDato.Location = new Point(28, 75);
            lblDato.AutoSize = true;

            txtDato.Location = new Point(125, 70);
            txtDato.Width = 220;

            // BOTON AGREGAR RAIZ
            Button btnRaiz = new Button();

            btnRaiz.Text = "Agregar raiz";
            btnRaiz.Location = new Point(365, 68);
            btnRaiz.Size = new Size(125, 35);

            btnRaiz.Click += BtnRaiz_Click;

            // BOTON RAMA IZQUIERDA
            Button btnIzquierdo = new Button();

            btnIzquierdo.Text = "Agregar izquierda";
            btnIzquierdo.Location = new Point(28, 120);
            btnIzquierdo.Size = new Size(155, 35);

            btnIzquierdo.Click += BtnIzquierdo_Click;

            // BOTON RAMA DERECHA
            Button btnDerecho = new Button();

            btnDerecho.Text = "Agregar derecha";
            btnDerecho.Location = new Point(195, 120);
            btnDerecho.Size = new Size(155, 35);

            btnDerecho.Click += BtnDerecho_Click;

            // TREEVIEW
            treeViewArbol.Location = new Point(28, 180);
            treeViewArbol.Size = new Size(360, 300);
            treeViewArbol.HideSelection = false;

            // TITULO DE RECORRIDOS
            Label lblRecorridos = new Label();

            lblRecorridos.Text = "Recorridos del arbol:";
            lblRecorridos.Font = new Font("Arial", 11, FontStyle.Bold);
            lblRecorridos.Location = new Point(425, 180);
            lblRecorridos.AutoSize = true;

            // BOTON PREORDEN
            Button btnPreorden = new Button();

            btnPreorden.Text = "Preorden";
            btnPreorden.Location = new Point(425, 220);
            btnPreorden.Size = new Size(130, 35);

            btnPreorden.Click += BtnPreorden_Click;

            // BOTON INORDEN
            Button btnInorden = new Button();

            btnInorden.Text = "Inorden";
            btnInorden.Location = new Point(425, 265);
            btnInorden.Size = new Size(130, 35);

            btnInorden.Click += BtnInorden_Click;

            // BOTON POSORDEN
            Button btnPosorden = new Button();

            btnPosorden.Text = "Posorden";
            btnPosorden.Location = new Point(425, 310);
            btnPosorden.Size = new Size(130, 35);

            btnPosorden.Click += BtnPosorden_Click;

            // RESULTADOS
            lblResultado.Location = new Point(425, 365);
            lblResultado.Size = new Size(370, 115);
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
            lblResultado.Padding = new Padding(8);
            lblResultado.Text = "Aqui apareceran los resultados.";

            // AGREGAR CONTROLES AL FORMULARIO
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblDato);
            this.Controls.Add(txtDato);
            this.Controls.Add(btnRaiz);
            this.Controls.Add(btnIzquierdo);
            this.Controls.Add(btnDerecho);
            this.Controls.Add(treeViewArbol);
            this.Controls.Add(lblRecorridos);
            this.Controls.Add(btnPreorden);
            this.Controls.Add(btnInorden);
            this.Controls.Add(btnPosorden);
            this.Controls.Add(lblResultado);
        }

        // AGREGAR RAIZ
        private void BtnRaiz_Click(object sender, EventArgs e)
        {
            string dato = txtDato.Text.Trim();

            if (!arbol.AgregarRaiz(dato))
            {
                MessageBox.Show(
                    arbol.EstaVacio
                    ? "Ingrese un dato para la raiz."
                    : "El arbol ya tiene una raiz.");

                return;
            }

            TreeNode nuevo = new TreeNode(dato);

            nuevo.Tag = arbol.Raiz;

            treeViewArbol.Nodes.Add(nuevo);

            treeViewArbol.SelectedNode = nuevo;

            txtDato.Clear();

            lblResultado.Text = "Se agrego la raiz: " + dato;
        }

        // AGREGAR RAMA IZQUIERDA
        private void BtnIzquierdo_Click(object sender, EventArgs e)
        {
            AgregarHijo(true);
        }

        // AGREGAR RAMA DERECHA
        private void BtnDerecho_Click(object sender, EventArgs e)
        {
            AgregarHijo(false);
        }

        // AGREGAR HIJOS
        private void AgregarHijo(bool izquierda)
        {
            if (treeViewArbol.SelectedNode == null)
            {
                MessageBox.Show("Primero seleccione un nodo.");
                return;
            }

            string dato = txtDato.Text.Trim();

            if (string.IsNullOrWhiteSpace(dato))
            {
                MessageBox.Show("Ingrese el dato del nuevo nodo.");
                return;
            }

            Nodo padre = (Nodo)treeViewArbol.SelectedNode.Tag;

            bool agregado;

            if (izquierda)
            {
                agregado = arbol.AgregarIzquierdo(padre, dato);
            }
            else
            {
                agregado = arbol.AgregarDerecho(padre, dato);
            }

            if (!agregado)
            {
                MessageBox.Show(
                    izquierda
                    ? "El nodo ya tiene una rama izquierda."
                    : "El nodo ya tiene una rama derecha.");

                return;
            }

            TreeNode nuevo = new TreeNode(dato);

            nuevo.Tag = izquierda
                ? padre.Izquierdo
                : padre.Derecho;

            if (izquierda)
            {
                treeViewArbol.SelectedNode.Nodes.Insert(0, nuevo);
            }
            else
            {
                treeViewArbol.SelectedNode.Nodes.Add(nuevo);
            }

            treeViewArbol.SelectedNode.Expand();

            treeViewArbol.SelectedNode = nuevo;

            txtDato.Clear();

            lblResultado.Text = "Nodo agregado correctamente.";
        }

        // RECORRIDO PREORDEN
        private void BtnPreorden_Click(object sender, EventArgs e)
        {
            if (arbol.EstaVacio)
            {
                MessageBox.Show("El arbol esta vacio.");
                return;
            }

            lblResultado.Text = "PREORDEN:\r\n" +
                string.Join(" - ", arbol.Preorden());
        }

        // RECORRIDO INORDEN
        private void BtnInorden_Click(object sender, EventArgs e)
        {
            if (arbol.EstaVacio)
            {
                MessageBox.Show("El arbol esta vacio.");
                return;
            }

            lblResultado.Text = "INORDEN:\r\n" +
                string.Join(" - ", arbol.Inorden());
        }

        // RECORRIDO POSORDEN
        private void BtnPosorden_Click(object sender, EventArgs e)
        {
            if (arbol.EstaVacio)
            {
                MessageBox.Show("El arbol esta vacio.");
                return;
            }

            lblResultado.Text = "POSORDEN:\r\n" +
                string.Join(" - ", arbol.Posorden());
        }
    }
}