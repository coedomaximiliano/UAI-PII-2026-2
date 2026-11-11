namespace Laboratorio2
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
            this.lblRuta = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnContenido = new System.Windows.Forms.Button();
            this.lstContenido = new System.Windows.Forms.ListBox();
            this.lstUnidades = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCreacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblRuta
            //
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(15, 30);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(38, 17);
            this.lblRuta.TabIndex = 0;
            this.lblRuta.Text = "Ruta";
            //
            // txtRuta
            //
            this.txtRuta.Location = new System.Drawing.Point(15, 60);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(420, 22);
            this.txtRuta.TabIndex = 1;
            this.txtRuta.Text = "C:\\";
            //
            // btnContenido
            //
            this.btnContenido.Location = new System.Drawing.Point(452, 58);
            this.btnContenido.Name = "btnContenido";
            this.btnContenido.Size = new System.Drawing.Size(110, 30);
            this.btnContenido.TabIndex = 2;
            this.btnContenido.Text = "Contenido";
            this.btnContenido.UseVisualStyleBackColor = true;
            this.btnContenido.Click += new System.EventHandler(this.btnContenido_Click);
            //
            // lstContenido
            //
            this.lstContenido.FormattingEnabled = true;
            this.lstContenido.Location = new System.Drawing.Point(15, 105);
            this.lstContenido.Name = "lstContenido";
            this.lstContenido.Size = new System.Drawing.Size(547, 374);
            this.lstContenido.TabIndex = 3;
            //
            // lstUnidades
            //
            this.lstUnidades.FormattingEnabled = true;
            this.lstUnidades.Location = new System.Drawing.Point(601, 105);
            this.lstUnidades.Name = "lstUnidades";
            this.lstUnidades.Size = new System.Drawing.Size(190, 374);
            this.lstUnidades.TabIndex = 4;
            //
            // btnSalir
            //
            this.btnSalir.Location = new System.Drawing.Point(601, 520);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(190, 33);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            //
            // lblCreacion
            //
            this.lblCreacion.AutoSize = true;
            this.lblCreacion.Location = new System.Drawing.Point(601, 60);
            this.lblCreacion.Name = "lblCreacion";
            this.lblCreacion.Size = new System.Drawing.Size(0, 17);
            this.lblCreacion.TabIndex = 6;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 576);
            this.Controls.Add(this.lblCreacion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstUnidades);
            this.Controls.Add(this.lstContenido);
            this.Controls.Add(this.btnContenido);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.lblRuta);
            this.Name = "Form1";
            this.Text = "Manejo de directorios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnContenido;
        private System.Windows.Forms.ListBox lstContenido;
        private System.Windows.Forms.ListBox lstUnidades;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCreacion;
    }
}
