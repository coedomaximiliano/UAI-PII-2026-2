using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace parteB
{
    public partial class Form1
    {
        private GestorPromedios gestor;
        private List<PromedioAlumno> calculados = new List<PromedioAlumno>();
        private DataGridView tablaPromedios;

        private void PrepararAmpliacion()
        {
            gestor = new GestorPromedios(AppDomain.CurrentDomain.BaseDirectory);
            Text = "TP 10 - Archivos, apareo y gestor de promedios";
            ClientSize = new Size(1180, 850);
            AutoScroll = true;
            AutoScrollMinSize = new Size(1130, 950);
            MinimumSize = new Size(850, 650);
            var titulo = new Label { Text = "GESTOR DE PROMEDIOS - APAREO Y CORTE DE CONTROL",
                Location = new Point(850, 238), Size = new Size(260, 32), Font = new Font(Font, FontStyle.Bold) };
            Controls.Add(titulo);
            var ordenar = new Button { Text = "Ordenar archivos", Location = new Point(850, 272), Size = new Size(220, 34) };
            ordenar.Click += (s, e) => Ejecutar(() => { gestor.OrdenarArchivos(); MostrarAlumnos(); MostrarNotas();
                MessageBox.Show("Archivos ordenados por DNI."); });
            Controls.Add(ordenar);
            var calcular = new Button { Text = "Calcular promedios", Location = new Point(850, 311), Size = new Size(220, 34) };
            calcular.Click += (s, e) => Ejecutar(() => { calculados = gestor.Calcular(); MostrarPromedios(calculados);
                MostrarAlumnos(); MostrarNotas(); });
            Controls.Add(calcular);
            var guardar = new Button { Text = "Guardar promedios", Location = new Point(850, 350), Size = new Size(220, 34) };
            guardar.Click += (s, e) => Ejecutar(() => { if (calculados.Count == 0) calculados = gestor.Calcular();
                gestor.Guardar(calculados); MostrarPromedios(calculados);
                MessageBox.Show("Promedios guardados en promedios.txt"); });
            Controls.Add(guardar);
            var recargar = new Button { Text = "Leer promedios guardados", Location = new Point(850, 389), Size = new Size(220, 34) };
            recargar.Click += (s, e) => Ejecutar(() => MostrarPromedios(gestor.Leer()));
            Controls.Add(recargar);
            tablaPromedios = new DataGridView { Location = new Point(12, 700), Size = new Size(1065, 210),
                ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
            tablaPromedios.Columns.Add("DniProm", "DNI");
            tablaPromedios.Columns.Add("NomProm", "Nombre");
            tablaPromedios.Columns.Add("ApeProm", "Apellido");
            tablaPromedios.Columns.Add("CantProm", "Cantidad de notas");
            tablaPromedios.Columns.Add("ValorProm", "Promedio");
            Controls.Add(tablaPromedios);
            Ejecutar(() => { MostrarAlumnos(); MostrarNotas(); MostrarPromedios(gestor.Leer()); });
        }
        private void MostrarPromedios(IEnumerable<PromedioAlumno> datos)
        {
            tablaPromedios.Rows.Clear();
            foreach (var p in datos)
                tablaPromedios.Rows.Add(p.Dni, p.Nombre, p.Apellido, p.Cantidad,
                    p.Cantidad == 0 ? "Sin notas" : p.Promedio.ToString("0.00"));
        }
        private void Ejecutar(Action accion)
        {
            try { accion(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
