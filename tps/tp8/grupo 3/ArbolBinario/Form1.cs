using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArbolBinario
{
    public class Form1 : Form
    {
        private readonly Arbol arbol = new Arbol();
        private readonly TreeView treeView1 = new TreeView();
        private readonly TextBox txtDato = new TextBox();
        private readonly Label lblResultado = new Label();
        private readonly Label lblEstado = new Label();

        public Form1()
        {
            Text = "Árbol binario - TDA y TreeView";
            ClientSize = new Size(850, 550);
            MinimumSize = new Size(800, 550);
            StartPosition = FormStartPosition.CenterScreen;
            Font = new Font("Segoe UI", 10F);

            Label titulo = new Label { Text = "Árbol binario", Font = new Font("Segoe UI", 18F, FontStyle.Bold), Location = new Point(20, 15), AutoSize = true };
            Controls.Add(titulo);
            Label instrucciones = new Label { Text = "Ingresá un número. Para agregar hijos, seleccioná primero el nodo padre.", Location = new Point(22, 58), AutoSize = true };
            Controls.Add(instrucciones);
            Label etiqueta = new Label { Text = "Dato:", Location = new Point(22, 101), AutoSize = true };
            Controls.Add(etiqueta);
            txtDato.Location = new Point(75, 98);
            txtDato.Size = new Size(120, 26);
            Controls.Add(txtDato);

            CrearBoton("Agregar raíz", 215, 95, 125, AgregarRaiz);
            CrearBoton("Hijo izquierdo", 350, 95, 145, AgregarIzquierda);
            CrearBoton("Hijo derecho", 505, 95, 145, AgregarDerecha);
            CrearBoton("Cargar ejemplo", 660, 95, 155, CargarEjemplo);

            treeView1.Location = new Point(22, 150);
            treeView1.Size = new Size(390, 310);
            treeView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            treeView1.HideSelection = false;
            treeView1.AfterSelect += (s, e) => lblEstado.Text = "Seleccionado: " + ((Nodo)e.Node.Tag).Dato;
            Controls.Add(treeView1);

            Label recorridos = new Label { Text = "Recorridos", Font = new Font("Segoe UI", 13F, FontStyle.Bold), Location = new Point(445, 150), AutoSize = true };
            Controls.Add(recorridos);
            CrearBoton("Preorden", 445, 195, 115, (s, e) => MostrarRecorrido("Preorden", arbol.RecorrerPreorden()));
            CrearBoton("Inorden", 575, 195, 105, (s, e) => MostrarRecorrido("Inorden", arbol.RecorrerInorden()));
            CrearBoton("Postorden", 690, 195, 125, (s, e) => MostrarRecorrido("Postorden", arbol.RecorrerPostorden()));
            lblResultado.Location = new Point(445, 250);
            lblResultado.Size = new Size(370, 155);
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
            lblResultado.Padding = new Padding(10);
            lblResultado.Text = "Seleccioná un recorrido para ver el resultado.";
            Controls.Add(lblResultado);
            lblEstado.Location = new Point(22, 475);
            lblEstado.Size = new Size(780, 30);
            lblEstado.Text = "Todavía no hay nodos. Podés empezar agregando la raíz.";
            Controls.Add(lblEstado);
        }

        private void CrearBoton(string texto, int x, int y, int ancho, EventHandler accion)
        {
            Button boton = new Button { Text = texto, Location = new Point(x, y), Size = new Size(ancho, 34) };
            boton.Click += accion;
            Controls.Add(boton);
        }

        private bool LeerDato(out int dato)
        {
            if (int.TryParse(txtDato.Text.Trim(), out dato)) return true;
            MessageBox.Show("Ingresá un número entero válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private Nodo NodoSeleccionado()
        {
            if (treeView1.SelectedNode != null) return (Nodo)treeView1.SelectedNode.Tag;
            MessageBox.Show("Primero seleccioná un nodo del árbol.", "Seleccionar nodo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return null;
        }

        private void AgregarRaiz(object sender, EventArgs e)
        {
            int dato;
            if (!LeerDato(out dato)) return;
            if (!arbol.AgregarRaiz(dato)) { MessageBox.Show("El árbol ya tiene raíz."); return; }
            ActualizarArbol(arbol.Raiz);
        }

        private void AgregarIzquierda(object sender, EventArgs e)
        {
            int dato;
            if (!LeerDato(out dato)) return;
            Nodo padre = NodoSeleccionado();
            if (padre == null) return;
            if (!arbol.AgregarIzquierda(padre, dato)) { MessageBox.Show("Ese nodo ya tiene hijo izquierdo."); return; }
            ActualizarArbol(padre.Izquierdo);
        }

        private void AgregarDerecha(object sender, EventArgs e)
        {
            int dato;
            if (!LeerDato(out dato)) return;
            Nodo padre = NodoSeleccionado();
            if (padre == null) return;
            if (!arbol.AgregarDerecha(padre, dato)) { MessageBox.Show("Ese nodo ya tiene hijo derecho."); return; }
            ActualizarArbol(padre.Derecho);
        }

        private void CargarEjemplo(object sender, EventArgs e)
        {
            if (arbol.Raiz != null) { MessageBox.Show("El árbol ya contiene nodos. Reiniciá la aplicación para cargar el ejemplo."); return; }
            arbol.AgregarRaiz(8);
            arbol.AgregarIzquierda(arbol.Raiz, 4);
            arbol.AgregarDerecha(arbol.Raiz, 12);
            Nodo n4 = arbol.Raiz.Izquierdo;
            Nodo n12 = arbol.Raiz.Derecho;
            arbol.AgregarIzquierda(n4, 2);
            arbol.AgregarDerecha(n4, 6);
            arbol.AgregarIzquierda(n12, 10);
            arbol.AgregarDerecha(n12, 14);
            arbol.AgregarIzquierda(n4.Izquierdo, 1);
            arbol.AgregarDerecha(n4.Izquierdo, 3);
            arbol.AgregarIzquierda(n4.Derecho, 5);
            arbol.AgregarDerecha(n4.Derecho, 7);
            arbol.AgregarIzquierda(n12.Izquierdo, 9);
            arbol.AgregarDerecha(n12.Izquierdo, 11);
            arbol.AgregarIzquierda(n12.Derecho, 13);
            arbol.AgregarDerecha(n12.Derecho, 15);
            ActualizarArbol(arbol.Raiz);
            lblEstado.Text = "Ejemplo de 4 niveles y 15 nodos cargado.";
        }

        private TreeNode CrearNodoVisual(Nodo actual)
        {
            TreeNode visual = new TreeNode(actual.Dato.ToString()) { Tag = actual };
            if (actual.Izquierdo != null) visual.Nodes.Add(CrearNodoVisual(actual.Izquierdo));
            if (actual.Derecho != null) visual.Nodes.Add(CrearNodoVisual(actual.Derecho));
            return visual;
        }

        private TreeNode BuscarVisual(TreeNode visual, Nodo buscado)
        {
            if (ReferenceEquals(visual.Tag, buscado)) return visual;
            foreach (TreeNode hijo in visual.Nodes)
            {
                TreeNode encontrado = BuscarVisual(hijo, buscado);
                if (encontrado != null) return encontrado;
            }
            return null;
        }

        private void ActualizarArbol(Nodo seleccionado)
        {
            treeView1.Nodes.Clear();
            if (arbol.Raiz == null) return;
            TreeNode raizVisual = CrearNodoVisual(arbol.Raiz);
            treeView1.Nodes.Add(raizVisual);
            treeView1.ExpandAll();
            treeView1.SelectedNode = BuscarVisual(raizVisual, seleccionado);
            txtDato.Clear();
            txtDato.Focus();
        }

        private void MostrarRecorrido(string nombre, List<int> resultado)
        {
            lblResultado.Text = nombre + ":" + Environment.NewLine + Environment.NewLine +
                (resultado.Count == 0 ? "El árbol está vacío." : string.Join(", ", resultado));
        }
    }
}
