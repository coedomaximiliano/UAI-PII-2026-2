namespace TP10_PyED
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grillaAlumnos = new System.Windows.Forms.DataGridView();
            this.GBAlumnos = new System.Windows.Forms.GroupBox();
            this.txtNombreS = new System.Windows.Forms.TextBox();
            this.txtApellidoS = new System.Windows.Forms.TextBox();
            this.numDniAlumno = new System.Windows.Forms.NumericUpDown();
            this.lblDniAlumno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.cmdGuardarAlumno = new System.Windows.Forms.Button();
            this.cmdModifAlumno = new System.Windows.Forms.Button();
            this.cmdBorrarAlumno = new System.Windows.Forms.Button();
            this.lblNotas = new System.Windows.Forms.Label();
            this.grillaNotas = new System.Windows.Forms.DataGridView();
            this.GBNotas = new System.Windows.Forms.GroupBox();
            this.numDniNota = new System.Windows.Forms.NumericUpDown();
            this.numNota = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblDniNota = new System.Windows.Forms.Label();
            this.lblNotaValor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmdGuardarNota = new System.Windows.Forms.Button();
            this.cmdModifNota = new System.Windows.Forms.Button();
            this.cmdBorrarNota = new System.Windows.Forms.Button();
            this.lblPromedios = new System.Windows.Forms.Label();
            this.grillaPromedios = new System.Windows.Forms.DataGridView();
            this.cmdOrdenar = new System.Windows.Forms.Button();
            this.cmdPromedios = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAlumnos)).BeginInit();
            this.GBAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDniAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaNotas)).BeginInit();
            this.GBNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDniNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPromedios)).BeginInit();
            this.SuspendLayout();
            //
            // grillaAlumnos
            //
            this.grillaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAlumnos.Location = new System.Drawing.Point(15, 25);
            this.grillaAlumnos.Name = "grillaAlumnos";
            this.grillaAlumnos.RowTemplate.Height = 24;
            this.grillaAlumnos.Size = new System.Drawing.Size(420, 330);
            this.grillaAlumnos.TabIndex = 0;
            this.grillaAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaAlumnos.SelectionChanged += new System.EventHandler(this.grillaAlumnos_SelectionChanged);
            //
            // GBAlumnos
            //
            this.GBAlumnos.Controls.Add(this.cmdGuardarAlumno);
            this.GBAlumnos.Controls.Add(this.numDniAlumno);
            this.GBAlumnos.Controls.Add(this.txtApellidoS);
            this.GBAlumnos.Controls.Add(this.txtNombreS);
            this.GBAlumnos.Controls.Add(this.lblApellido);
            this.GBAlumnos.Controls.Add(this.lblNombre);
            this.GBAlumnos.Controls.Add(this.lblDniAlumno);
            this.GBAlumnos.Location = new System.Drawing.Point(455, 25);
            this.GBAlumnos.Name = "GBAlumnos";
            this.GBAlumnos.Size = new System.Drawing.Size(400, 230);
            this.GBAlumnos.TabIndex = 1;
            this.GBAlumnos.TabStop = false;
            this.GBAlumnos.Text = "Alumnos";
            //
            // lblDniAlumno
            //
            this.lblDniAlumno.AutoSize = true;
            this.lblDniAlumno.Location = new System.Drawing.Point(20, 40);
            this.lblDniAlumno.Name = "lblDniAlumno";
            this.lblDniAlumno.Size = new System.Drawing.Size(36, 17);
            this.lblDniAlumno.TabIndex = 0;
            this.lblDniAlumno.Text = "DNI";
            //
            // lblNombre
            //
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 85);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            //
            // lblApellido
            //
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(20, 130);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 17);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            //
            // numDniAlumno
            //
            this.numDniAlumno.Location = new System.Drawing.Point(115, 36);
            this.numDniAlumno.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numDniAlumno.Name = "numDniAlumno";
            this.numDniAlumno.Size = new System.Drawing.Size(260, 22);
            this.numDniAlumno.TabIndex = 3;
            this.numDniAlumno.ThousandsSeparator = true;
            //
            // txtNombreS
            //
            this.txtNombreS.Location = new System.Drawing.Point(115, 81);
            this.txtNombreS.Name = "txtNombreS";
            this.txtNombreS.Size = new System.Drawing.Size(260, 22);
            this.txtNombreS.TabIndex = 4;
            //
            // txtApellidoS
            //
            this.txtApellidoS.Location = new System.Drawing.Point(115, 126);
            this.txtApellidoS.Name = "txtApellidoS";
            this.txtApellidoS.Size = new System.Drawing.Size(260, 22);
            this.txtApellidoS.TabIndex = 5;
            //
            // cmdGuardarAlumno
            //
            this.cmdGuardarAlumno.Location = new System.Drawing.Point(115, 180);
            this.cmdGuardarAlumno.Name = "cmdGuardarAlumno";
            this.cmdGuardarAlumno.Size = new System.Drawing.Size(150, 34);
            this.cmdGuardarAlumno.TabIndex = 6;
            this.cmdGuardarAlumno.Text = "Guardar";
            this.cmdGuardarAlumno.UseVisualStyleBackColor = true;
            this.cmdGuardarAlumno.Click += new System.EventHandler(this.cmdGuardarAlumno_Click);
            //
            // cmdModifAlumno
            //
            this.cmdModifAlumno.Location = new System.Drawing.Point(80, 400);
            this.cmdModifAlumno.Name = "cmdModifAlumno";
            this.cmdModifAlumno.Size = new System.Drawing.Size(150, 33);
            this.cmdModifAlumno.TabIndex = 7;
            this.cmdModifAlumno.Text = "Modif Alumno";
            this.cmdModifAlumno.UseVisualStyleBackColor = true;
            this.cmdModifAlumno.Click += new System.EventHandler(this.cmdModifAlumno_Click);
            //
            // cmdBorrarAlumno
            //
            this.cmdBorrarAlumno.Location = new System.Drawing.Point(250, 400);
            this.cmdBorrarAlumno.Name = "cmdBorrarAlumno";
            this.cmdBorrarAlumno.Size = new System.Drawing.Size(150, 33);
            this.cmdBorrarAlumno.TabIndex = 8;
            this.cmdBorrarAlumno.Text = "Borrar";
            this.cmdBorrarAlumno.UseVisualStyleBackColor = true;
            this.cmdBorrarAlumno.Click += new System.EventHandler(this.cmdBorrarAlumno_Click);
            //
            // lblNotas
            //
            this.lblNotas.AutoSize = true;
            this.lblNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotas.Location = new System.Drawing.Point(15, 445);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(80, 28);
            this.lblNotas.TabIndex = 9;
            this.lblNotas.Text = "Notas";
            //
            // grillaNotas
            //
            this.grillaNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaNotas.Location = new System.Drawing.Point(15, 490);
            this.grillaNotas.Name = "grillaNotas";
            this.grillaNotas.RowTemplate.Height = 24;
            this.grillaNotas.Size = new System.Drawing.Size(420, 280);
            this.grillaNotas.TabIndex = 10;
            this.grillaNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaNotas.SelectionChanged += new System.EventHandler(this.grillaNotas_SelectionChanged);
            //
            // GBNotas
            //
            this.GBNotas.Controls.Add(this.cmdGuardarNota);
            this.GBNotas.Controls.Add(this.numDniNota);
            this.GBNotas.Controls.Add(this.numNota);
            this.GBNotas.Controls.Add(this.dtpFecha);
            this.GBNotas.Controls.Add(this.lblDniNota);
            this.GBNotas.Controls.Add(this.lblNotaValor);
            this.GBNotas.Controls.Add(this.lblFecha);
            this.GBNotas.Location = new System.Drawing.Point(455, 490);
            this.GBNotas.Name = "GBNotas";
            this.GBNotas.Size = new System.Drawing.Size(400, 220);
            this.GBNotas.TabIndex = 11;
            this.GBNotas.TabStop = false;
            this.GBNotas.Text = "Notas del alumno";
            //
            // lblDniNota
            //
            this.lblDniNota.AutoSize = true;
            this.lblDniNota.Location = new System.Drawing.Point(20, 40);
            this.lblDniNota.Name = "lblDniNota";
            this.lblDniNota.Size = new System.Drawing.Size(36, 17);
            this.lblDniNota.TabIndex = 0;
            this.lblDniNota.Text = "DNI";
            //
            // lblNotaValor
            //
            this.lblNotaValor.AutoSize = true;
            this.lblNotaValor.Location = new System.Drawing.Point(20, 85);
            this.lblNotaValor.Name = "lblNotaValor";
            this.lblNotaValor.Size = new System.Drawing.Size(42, 17);
            this.lblNotaValor.TabIndex = 1;
            this.lblNotaValor.Text = "Nota";
            //
            // lblFecha
            //
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(20, 130);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 17);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            //
            // numDniNota
            //
            this.numDniNota.Location = new System.Drawing.Point(115, 36);
            this.numDniNota.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numDniNota.Name = "numDniNota";
            this.numDniNota.Size = new System.Drawing.Size(260, 22);
            this.numDniNota.TabIndex = 3;
            this.numDniNota.ThousandsSeparator = true;
            //
            // numNota
            //
            this.numNota.Location = new System.Drawing.Point(115, 81);
            this.numNota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numNota.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNota.Name = "numNota";
            this.numNota.Size = new System.Drawing.Size(260, 22);
            this.numNota.TabIndex = 4;
            this.numNota.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            //
            // dtpFecha
            //
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(115, 126);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(260, 22);
            this.dtpFecha.TabIndex = 5;
            //
            // cmdGuardarNota
            //
            this.cmdGuardarNota.Location = new System.Drawing.Point(115, 170);
            this.cmdGuardarNota.Name = "cmdGuardarNota";
            this.cmdGuardarNota.Size = new System.Drawing.Size(150, 34);
            this.cmdGuardarNota.TabIndex = 6;
            this.cmdGuardarNota.Text = "Guardar";
            this.cmdGuardarNota.UseVisualStyleBackColor = true;
            this.cmdGuardarNota.Click += new System.EventHandler(this.cmdGuardarNota_Click);
            //
            // cmdModifNota
            //
            this.cmdModifNota.Location = new System.Drawing.Point(80, 790);
            this.cmdModifNota.Name = "cmdModifNota";
            this.cmdModifNota.Size = new System.Drawing.Size(150, 33);
            this.cmdModifNota.TabIndex = 12;
            this.cmdModifNota.Text = "Modif Nota";
            this.cmdModifNota.UseVisualStyleBackColor = true;
            this.cmdModifNota.Click += new System.EventHandler(this.cmdModifNota_Click);
            //
            // cmdBorrarNota
            //
            this.cmdBorrarNota.Location = new System.Drawing.Point(250, 790);
            this.cmdBorrarNota.Name = "cmdBorrarNota";
            this.cmdBorrarNota.Size = new System.Drawing.Size(150, 33);
            this.cmdBorrarNota.TabIndex = 13;
            this.cmdBorrarNota.Text = "Borrar Nota";
            this.cmdBorrarNota.UseVisualStyleBackColor = true;
            this.cmdBorrarNota.Click += new System.EventHandler(this.cmdBorrarNota_Click);
            //
            // lblPromedios
            //
            this.lblPromedios.AutoSize = true;
            this.lblPromedios.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedios.Location = new System.Drawing.Point(15, 840);
            this.lblPromedios.Name = "lblPromedios";
            this.lblPromedios.Size = new System.Drawing.Size(135, 28);
            this.lblPromedios.TabIndex = 15;
            this.lblPromedios.Text = "Promedios";
            //
            // grillaPromedios
            //
            this.grillaPromedios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPromedios.Location = new System.Drawing.Point(15, 885);
            this.grillaPromedios.Name = "grillaPromedios";
            this.grillaPromedios.RowTemplate.Height = 24;
            this.grillaPromedios.Size = new System.Drawing.Size(420, 280);
            this.grillaPromedios.TabIndex = 16;
            this.grillaPromedios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            //
            // cmdOrdenar
            //
            this.cmdOrdenar.Location = new System.Drawing.Point(455, 885);
            this.cmdOrdenar.Name = "cmdOrdenar";
            this.cmdOrdenar.Size = new System.Drawing.Size(150, 33);
            this.cmdOrdenar.TabIndex = 17;
            this.cmdOrdenar.Text = "Ordenar Archivos";
            this.cmdOrdenar.UseVisualStyleBackColor = true;
            this.cmdOrdenar.Click += new System.EventHandler(this.cmdOrdenar_Click);
            //
            // cmdPromedios
            //
            this.cmdPromedios.Location = new System.Drawing.Point(625, 885);
            this.cmdPromedios.Name = "cmdPromedios";
            this.cmdPromedios.Size = new System.Drawing.Size(150, 33);
            this.cmdPromedios.TabIndex = 18;
            this.cmdPromedios.Text = "Promedios";
            this.cmdPromedios.UseVisualStyleBackColor = true;
            this.cmdPromedios.Click += new System.EventHandler(this.cmdPromedios_Click);
            //
            // cmdSalir
            //
            this.cmdSalir.Location = new System.Drawing.Point(705, 1190);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(150, 33);
            this.cmdSalir.TabIndex = 19;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(874, 1250);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdPromedios);
            this.Controls.Add(this.cmdOrdenar);
            this.Controls.Add(this.grillaPromedios);
            this.Controls.Add(this.lblPromedios);
            this.Controls.Add(this.cmdBorrarNota);
            this.Controls.Add(this.cmdModifNota);
            this.Controls.Add(this.grillaNotas);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.cmdBorrarAlumno);
            this.Controls.Add(this.cmdModifAlumno);
            this.Controls.Add(this.GBNotas);
            this.Controls.Add(this.GBAlumnos);
            this.Controls.Add(this.grillaAlumnos);
            this.Name = "Form1";
            this.Text = "TP10 - Corte de Control y Apareo de Archivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaAlumnos;
        private System.Windows.Forms.GroupBox GBAlumnos;
        private System.Windows.Forms.TextBox txtNombreS;
        private System.Windows.Forms.TextBox txtApellidoS;
        private System.Windows.Forms.NumericUpDown numDniAlumno;
        private System.Windows.Forms.Label lblDniAlumno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button cmdGuardarAlumno;
        private System.Windows.Forms.Button cmdModifAlumno;
        private System.Windows.Forms.Button cmdBorrarAlumno;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.DataGridView grillaNotas;
        private System.Windows.Forms.GroupBox GBNotas;
        private System.Windows.Forms.NumericUpDown numDniNota;
        private System.Windows.Forms.NumericUpDown numNota;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblDniNota;
        private System.Windows.Forms.Label lblNotaValor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button cmdGuardarNota;
        private System.Windows.Forms.Button cmdModifNota;
        private System.Windows.Forms.Button cmdBorrarNota;
        private System.Windows.Forms.Label lblPromedios;
        private System.Windows.Forms.DataGridView grillaPromedios;
        private System.Windows.Forms.Button cmdOrdenar;
        private System.Windows.Forms.Button cmdPromedios;
        private System.Windows.Forms.Button cmdSalir;
    }
}
