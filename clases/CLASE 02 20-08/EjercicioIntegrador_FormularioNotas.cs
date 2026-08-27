// ============================================================
// Clase 2 - Programación y Estructuras de Datos
// Ejercicio integrador
// ------------------------------------------------------------
// Enunciado:
// Desarrollar una mini aplicación de Windows Forms para calcular
// el promedio de notas de un alumno:
//   - Un formulario con un TextBox para ingresar una nota, un
//     Button "Agregar nota" y un Label para mostrar los resultados.
//   - Cada clic en "Agregar nota" debe convertir el texto ingresado
//     a un valor numérico (validando el formato) y guardarlo en
//     una lista.
//   - Un segundo botón "Calcular promedio" debe recorrer la lista
//     y mostrar el promedio en el Label.
//   - Utilizar boxing/unboxing y conversión de tipos vistos en la
//     clase de hoy.
//
// Nota: este archivo está escrito 100% por código (sin diseñador),
// para que se pueda leer y entender de punta a punta. En Visual
// Studio se puede crear un proyecto "Aplicación de Windows Forms
// (.NET Framework)" y pegar este código en Program.cs.
// ============================================================

using System;
using System.Collections.Generic;
using System.Windows.Forms;

class FormularioNotas : Form
{
    // Lista donde se van acumulando las notas cargadas.
    private List<double> notas = new List<double>();

    private TextBox txtNota;
    private Button btnAgregar;
    private Button btnPromedio;
    private Label lblResultado;

    public FormularioNotas()
    {
        this.Text = "Promedio de notas";
        this.Width = 360;
        this.Height = 220;

        Label lblTitulo = new Label();
        lblTitulo.Text = "Ingrese una nota:";
        lblTitulo.Location = new System.Drawing.Point(20, 20);
        lblTitulo.AutoSize = true;

        txtNota = new TextBox();
        txtNota.Location = new System.Drawing.Point(20, 45);
        txtNota.Width = 100;

        btnAgregar = new Button();
        btnAgregar.Text = "Agregar nota";
        btnAgregar.Location = new System.Drawing.Point(140, 43);
        btnAgregar.Click += btnAgregar_Click;

        btnPromedio = new Button();
        btnPromedio.Text = "Calcular promedio";
        btnPromedio.Location = new System.Drawing.Point(20, 80);
        btnPromedio.Click += btnPromedio_Click;

        lblResultado = new Label();
        lblResultado.Location = new System.Drawing.Point(20, 120);
        lblResultado.AutoSize = true;
        lblResultado.Text = "Notas cargadas: 0";

        this.Controls.Add(lblTitulo);
        this.Controls.Add(txtNota);
        this.Controls.Add(btnAgregar);
        this.Controls.Add(btnPromedio);
        this.Controls.Add(lblResultado);
    }

    // Evento Click del botón "Agregar nota".
    private void btnAgregar_Click(object sender, EventArgs e)
    {
        // Conversión de tipos validando el formato: double.TryParse()
        // no lanza excepción si el texto no es un número válido,
        // sino que devuelve false.
        double nota;
        bool esValido = double.TryParse(txtNota.Text, out nota);

        if (!esValido)
        {
            MessageBox.Show("Ingrese un número válido para la nota.");
            return;
        }

        notas.Add(nota);
        txtNota.Clear();
        txtNota.Focus();

        lblResultado.Text = "Notas cargadas: " + notas.Count;
    }

    // Evento Click del botón "Calcular promedio".
    private void btnPromedio_Click(object sender, EventArgs e)
    {
        if (notas.Count == 0)
        {
            lblResultado.Text = "Todavía no se cargó ninguna nota.";
            return;
        }

        double suma = 0;
        foreach (double n in notas)
        {
            suma += n;
        }
        double promedio = suma / notas.Count;

        // "object resumen = promedio;" sería un ejemplo de boxing
        // (el double, tipo por valor, pasaría a vivir en un object).
        object resumen = promedio;
        lblResultado.Text = "Promedio de " + notas.Count + " nota(s): " + resumen;
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new FormularioNotas());
    }
}

// ------------------------------------------------------------
// Resultado explicado (ejemplo de uso):
//
//   1) El usuario escribe "7" en el TextBox y hace clic en
//      "Agregar nota" -> el Label muestra "Notas cargadas: 1".
//   2) Repite con "5", "9" y "8" -> "Notas cargadas: 4".
//   3) Hace clic en "Calcular promedio" -> el Label muestra
//      "Promedio de 4 nota(s): 7,25"
//      (porque (7 + 5 + 9 + 8) / 4 = 29 / 4 = 7.25).
//
// Explicación:
// double.TryParse() es la forma segura de convertir texto a número
// en una interfaz gráfica: si el usuario escribe algo que no es un
// número (por ejemplo "siete"), TryParse devuelve false y el
// programa muestra un aviso en lugar de romperse con una excepción
// (a diferencia de Convert.ToDouble(), que sí lanzaría
// FormatException con un texto inválido).
// El promedio se calcula recorriendo la lista de notas (double) y
// dividiendo la suma por la cantidad de elementos. Al asignar ese
// promedio a una variable "object" (resumen), se está haciendo
// boxing: el valor por valor (double) pasa a alojarse dentro de una
// referencia de tipo object, tal como se vio en la clase con
// "object o = i;".
// ============================================================
