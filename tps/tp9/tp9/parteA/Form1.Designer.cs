namespace parteA
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtApeNom = new System.Windows.Forms.TextBox();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.listListado = new System.Windows.Forms.ListBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificación = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Legajo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido y Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoría";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(192, 13);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(178, 22);
            this.txtLegajo.TabIndex = 3;
            // 
            // txtApeNom
            // 
            this.txtApeNom.Location = new System.Drawing.Point(192, 47);
            this.txtApeNom.Name = "txtApeNom";
            this.txtApeNom.Size = new System.Drawing.Size(178, 22);
            this.txtApeNom.TabIndex = 4;
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(192, 82);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(178, 22);
            this.txtCat.TabIndex = 5;
            // 
            // listListado
            // 
            this.listListado.FormattingEnabled = true;
            this.listListado.ItemHeight = 16;
            this.listListado.Location = new System.Drawing.Point(13, 119);
            this.listListado.Name = "listListado";
            this.listListado.Size = new System.Drawing.Size(357, 196);
            this.listListado.TabIndex = 6;
            this.listListado.Click += new System.EventHandler(this.listListado_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(12, 337);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 7;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(102, 337);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 8;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificación
            // 
            this.btnModificación.Location = new System.Drawing.Point(190, 337);
            this.btnModificación.Name = "btnModificación";
            this.btnModificación.Size = new System.Drawing.Size(97, 23);
            this.btnModificación.TabIndex = 9;
            this.btnModificación.Text = "Modificación";
            this.btnModificación.UseVisualStyleBackColor = true;
            this.btnModificación.Click += new System.EventHandler(this.btnModificación_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(295, 337);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 370);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificación);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.listListado);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.txtApeNom);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Archivo Secuencial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtApeNom;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.ListBox listListado;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificación;
        private System.Windows.Forms.Button btnSalir;
    }
}

