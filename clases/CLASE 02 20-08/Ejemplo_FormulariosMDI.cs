// ============================================================
// Clase 2 - Programación y Estructuras de Datos
// Ejemplo práctico: Formularios MDI
// ------------------------------------------------------------
// MDI (Multiple Document Interface) es un modelo de formularios
// donde existe un formulario padre (contenedor) que aloja dentro
// de sí varios formularios hijo.
//
// Se establece asignando IsMdiContainer = true en el formulario
// padre. Cada formulario hijo se abre indicando su MdiParent:
//
//   Form2 hijo = new Form2();
//   hijo.MdiParent = this;
//   hijo.Show();
//
// Se usa en aplicaciones donde conviven varias ventanas internas
// dentro de una misma ventana principal (por ejemplo, un editor
// con varios documentos abiertos a la vez).
//
// Nota: este archivo está escrito 100% por código (sin diseñador),
// para que se pueda leer de punta a punta. En Visual Studio se
// puede crear un proyecto "Aplicación de Windows Forms (.NET
// Framework)" y pegar este código en Program.cs.
// ============================================================

using System;
using System.Windows.Forms;

// ------------------------------------------------------------
// FORMULARIO PADRE (contenedor MDI)
// ------------------------------------------------------------
class FormularioPrincipal : Form
{
    private int contadorDocumentos = 0;

    public FormularioPrincipal()
    {
        this.Text = "Editor - Formulario principal (MDI)";
        this.Width = 700;
        this.Height = 500;

        // Esta es la línea clave: convierte a este formulario en el
        // CONTENEDOR de los formularios hijo.
        this.IsMdiContainer = true;

        // Menú para poder abrir varios "documentos" (formularios hijo).
        MenuStrip menu = new MenuStrip();
        ToolStripMenuItem menuArchivo = new ToolStripMenuItem("Archivo");

        ToolStripMenuItem itemNuevo = new ToolStripMenuItem("Nuevo documento");
        itemNuevo.Click += ItemNuevo_Click;

        ToolStripMenuItem itemCascada = new ToolStripMenuItem("Organizar en cascada");
        itemCascada.Click += (s, e) => this.LayoutMdi(MdiLayout.Cascade);

        ToolStripMenuItem itemSalir = new ToolStripMenuItem("Salir");
        itemSalir.Click += (s, e) => this.Close();

        menuArchivo.DropDownItems.Add(itemNuevo);
        menuArchivo.DropDownItems.Add(itemCascada);
        menuArchivo.DropDownItems.Add(itemSalir);
        menu.Items.Add(menuArchivo);

        this.MainMenuStrip = menu;
        this.Controls.Add(menu);
    }

    // Cada clic en "Nuevo documento" crea y muestra un nuevo
    // formulario hijo dentro de este formulario padre.
    private void ItemNuevo_Click(object sender, EventArgs e)
    {
        contadorDocumentos++;

        FormularioDocumento hijo = new FormularioDocumento(contadorDocumentos);

        // Esta es la línea que convierte a "hijo" en un formulario
        // MDI hijo de "this" (el formulario principal).
        hijo.MdiParent = this;

        hijo.Show();
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new FormularioPrincipal());
    }
}

// ------------------------------------------------------------
// FORMULARIO HIJO (un "documento" dentro del padre)
// ------------------------------------------------------------
class FormularioDocumento : Form
{
    public FormularioDocumento(int numero)
    {
        this.Text = "Documento " + numero;
        this.Width = 300;
        this.Height = 200;

        TextBox txtContenido = new TextBox();
        txtContenido.Multiline = true;
        txtContenido.Dock = DockStyle.Fill;
        txtContenido.Text = "Este es el documento número " + numero + ".";

        this.Controls.Add(txtContenido);
    }
}

// ============================================================
// Resultado explicado (ejemplo de uso):
//
//   1) Se abre el "Formulario principal", que ocupa toda la
//      ventana y tiene un menú "Archivo".
//   2) El usuario hace clic en Archivo > Nuevo documento tres
//      veces seguidas -> aparecen "Documento 1", "Documento 2" y
//      "Documento 3" como tres ventanas INTERNAS, todas contenidas
//      dentro del formulario principal (no son ventanas sueltas de
//      Windows, no aparecen por separado en la barra de tareas).
//   3) El usuario hace clic en "Organizar en cascada" -> las tres
//      ventanas hijo se acomodan una detrás de otra, desplazadas,
//      típico de los editores estilo MDI.
//   4) Cada Documento N tiene su propio TextBox independiente: se
//      puede escribir en el Documento 1 sin que afecte al 2 o al 3.
//
// Explicación:
// "IsMdiContainer = true" es lo que habilita a FormularioPrincipal
// para actuar como "escritorio" interno de otros formularios. Sin
// esa línea, "hijo.MdiParent = this" lanzaría una excepción, porque
// "this" no sería un contenedor MDI válido.
// Cada vez que se crea un FormularioDocumento y se le asigna
// MdiParent, ese formulario deja de ser una ventana independiente y
// pasa a vivir "adentro" del área de cliente del formulario padre,
// igual que ocurre en programas como versiones antiguas de Word o
// Excel, donde cada documento abierto es una ventana interna dentro
// de la ventana principal de la aplicación.
// ============================================================
