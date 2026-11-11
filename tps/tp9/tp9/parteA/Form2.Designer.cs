namespace parteA
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnContenido = new System.Windows.Forms.Button();
            this.lstUnidades = new System.Windows.Forms.ListBox();
            this.lstContenido = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(12, 12);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(468, 22);
            this.txtRuta.TabIndex = 0;
            // 
            // btnContenido
            // 
            this.btnContenido.Location = new System.Drawing.Point(487, 12);
            this.btnContenido.Name = "btnContenido";
            this.btnContenido.Size = new System.Drawing.Size(87, 23);
            this.btnContenido.TabIndex = 1;
            this.btnContenido.Text = "Contenido";
            this.btnContenido.UseVisualStyleBackColor = true;
            this.btnContenido.Click += new System.EventHandler(this.btnContenido_Click);
            // 
            // lstUnidades
            // 
            this.lstUnidades.FormattingEnabled = true;
            this.lstUnidades.ItemHeight = 16;
            this.lstUnidades.Location = new System.Drawing.Point(609, 12);
            this.lstUnidades.Name = "lstUnidades";
            this.lstUnidades.Size = new System.Drawing.Size(179, 116);
            this.lstUnidades.TabIndex = 2;
            // 
            // lstContenido
            // 
            this.lstContenido.FormattingEnabled = true;
            this.lstContenido.ItemHeight = 16;
            this.lstContenido.Location = new System.Drawing.Point(12, 40);
            this.lstContenido.Name = "lstContenido";
            this.lstContenido.Size = new System.Drawing.Size(468, 404);
            this.lstContenido.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(676, 421);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstContenido);
            this.Controls.Add(this.lstUnidades);
            this.Controls.Add(this.btnContenido);
            this.Controls.Add(this.txtRuta);
            this.Name = "Form2";
            this.Text = "Manejo de Directorios";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnContenido;
        private System.Windows.Forms.ListBox lstUnidades;
        private System.Windows.Forms.ListBox lstContenido;
        private System.Windows.Forms.Button btnSalir;
    }
}