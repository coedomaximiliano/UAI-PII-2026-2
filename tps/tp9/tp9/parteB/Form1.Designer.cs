namespace parteB
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAlu = new System.Windows.Forms.DataGridView();
            this.colDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nupdAlu = new System.Windows.Forms.NumericUpDown();
            this.txtNomAlu = new System.Windows.Forms.TextBox();
            this.txtApeAlu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardarAlu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarNota = new System.Windows.Forms.Button();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.nupdNota = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnModAlu = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBorrarNota = new System.Windows.Forms.Button();
            this.btnModNota = new System.Windows.Forms.Button();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdAlu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdNota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumnos";
            // 
            // dgvAlu
            // 
            this.dgvAlu.AllowUserToAddRows = false;
            this.dgvAlu.AllowUserToDeleteRows = false;
            this.dgvAlu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDNI,
            this.colNombre,
            this.colApellido});
            this.dgvAlu.Location = new System.Drawing.Point(12, 28);
            this.dgvAlu.Name = "dgvAlu";
            this.dgvAlu.RowHeadersWidth = 51;
            this.dgvAlu.RowTemplate.Height = 24;
            this.dgvAlu.Size = new System.Drawing.Size(806, 253);
            this.dgvAlu.TabIndex = 1;
            this.dgvAlu.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlu_CellValueChanged);
            this.dgvAlu.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvAlu_CurrentCellDirtyStateChanged);
            // 
            // colDNI
            // 
            this.colDNI.HeaderText = "DNI";
            this.colDNI.MinimumWidth = 6;
            this.colDNI.Name = "colDNI";
            this.colDNI.ReadOnly = true;
            this.colDNI.Width = 125;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 125;
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.MinimumWidth = 6;
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            this.colApellido.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Nota,
            this.Fecha});
            this.dataGridView2.Location = new System.Drawing.Point(12, 343);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(806, 259);
            this.dataGridView2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Notas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Apellido";
            // 
            // nupdAlu
            // 
            this.nupdAlu.Location = new System.Drawing.Point(102, 21);
            this.nupdAlu.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nupdAlu.Name = "nupdAlu";
            this.nupdAlu.Size = new System.Drawing.Size(120, 22);
            this.nupdAlu.TabIndex = 7;
            // 
            // txtNomAlu
            // 
            this.txtNomAlu.Location = new System.Drawing.Point(102, 50);
            this.txtNomAlu.Name = "txtNomAlu";
            this.txtNomAlu.Size = new System.Drawing.Size(120, 22);
            this.txtNomAlu.TabIndex = 8;
            // 
            // txtApeAlu
            // 
            this.txtApeAlu.Location = new System.Drawing.Point(102, 85);
            this.txtApeAlu.Name = "txtApeAlu";
            this.txtApeAlu.Size = new System.Drawing.Size(120, 22);
            this.txtApeAlu.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardarAlu);
            this.groupBox1.Controls.Add(this.txtApeAlu);
            this.groupBox1.Controls.Add(this.txtNomAlu);
            this.groupBox1.Controls.Add(this.nupdAlu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(834, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 178);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnGuardarAlu
            // 
            this.btnGuardarAlu.Location = new System.Drawing.Point(77, 134);
            this.btnGuardarAlu.Name = "btnGuardarAlu";
            this.btnGuardarAlu.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarAlu.TabIndex = 10;
            this.btnGuardarAlu.Text = "Guardar";
            this.btnGuardarAlu.UseVisualStyleBackColor = true;
            this.btnGuardarAlu.Click += new System.EventHandler(this.btnGuardarAlu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Controls.Add(this.btnGuardarNota);
            this.groupBox2.Controls.Add(this.txtNota);
            this.groupBox2.Controls.Add(this.nupdNota);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(834, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 178);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(102, 85);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(120, 22);
            this.dtpFecha.TabIndex = 11;
            this.dtpFecha.Value = new System.DateTime(2026, 10, 26, 0, 0, 0, 0);
            // 
            // btnGuardarNota
            // 
            this.btnGuardarNota.Location = new System.Drawing.Point(77, 134);
            this.btnGuardarNota.Name = "btnGuardarNota";
            this.btnGuardarNota.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarNota.TabIndex = 10;
            this.btnGuardarNota.Text = "Guardar";
            this.btnGuardarNota.UseVisualStyleBackColor = true;
            this.btnGuardarNota.Click += new System.EventHandler(this.btnGuardarNota_Click);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(102, 50);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(120, 22);
            this.txtNota.TabIndex = 8;
            // 
            // nupdNota
            // 
            this.nupdNota.Location = new System.Drawing.Point(102, 21);
            this.nupdNota.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nupdNota.Name = "nupdNota";
            this.nupdNota.Size = new System.Drawing.Size(120, 22);
            this.nupdNota.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nota";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "DNI";
            // 
            // btnModAlu
            // 
            this.btnModAlu.Location = new System.Drawing.Point(12, 287);
            this.btnModAlu.Name = "btnModAlu";
            this.btnModAlu.Size = new System.Drawing.Size(140, 23);
            this.btnModAlu.TabIndex = 11;
            this.btnModAlu.Text = "Modif Alumno";
            this.btnModAlu.UseVisualStyleBackColor = true;
            this.btnModAlu.Click += new System.EventHandler(this.btnModAlu_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(158, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Borrar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBorrarNota
            // 
            this.btnBorrarNota.Location = new System.Drawing.Point(158, 608);
            this.btnBorrarNota.Name = "btnBorrarNota";
            this.btnBorrarNota.Size = new System.Drawing.Size(95, 23);
            this.btnBorrarNota.TabIndex = 14;
            this.btnBorrarNota.Text = "Borrar";
            this.btnBorrarNota.UseVisualStyleBackColor = true;
            this.btnBorrarNota.Click += new System.EventHandler(this.btnBorrarNota_Click);
            // 
            // btnModNota
            // 
            this.btnModNota.Location = new System.Drawing.Point(12, 608);
            this.btnModNota.Name = "btnModNota";
            this.btnModNota.Size = new System.Drawing.Size(140, 23);
            this.btnModNota.TabIndex = 13;
            this.btnModNota.Text = "Modif Nota";
            this.btnModNota.UseVisualStyleBackColor = true;
            this.btnModNota.Click += new System.EventHandler(this.btnModNota_Click);
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            this.DNI.Width = 125;
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.MinimumWidth = 6;
            this.Nota.Name = "Nota";
            this.Nota.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 643);
            this.Controls.Add(this.btnBorrarNota);
            this.Controls.Add(this.btnModNota);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnModAlu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dgvAlu);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Manejo de Directorios";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdAlu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAlu;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupdAlu;
        private System.Windows.Forms.TextBox txtNomAlu;
        private System.Windows.Forms.TextBox txtApeAlu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardarAlu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnGuardarNota;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.NumericUpDown nupdNota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnModAlu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnBorrarNota;
        private System.Windows.Forms.Button btnModNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}

