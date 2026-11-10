namespace ejercicioUno
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnotar = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.lsbPasajeros = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasajero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ejercicioUno.Properties.Resources.mercedes;
            this.pictureBox1.Location = new System.Drawing.Point(22, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(689, 478);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnotar
            // 
            this.btnAnotar.Location = new System.Drawing.Point(345, 62);
            this.btnAnotar.Name = "btnAnotar";
            this.btnAnotar.Size = new System.Drawing.Size(75, 23);
            this.btnAnotar.TabIndex = 1;
            this.btnAnotar.Text = "Anotar";
            this.btnAnotar.UseVisualStyleBackColor = true;
            this.btnAnotar.Click += new System.EventHandler(this.btnAnotar_Click);
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(294, 315);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(126, 23);
            this.btnSubir.TabIndex = 2;
            this.btnSubir.Text = "Subir a la combi!";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // lsbPasajeros
            // 
            this.lsbPasajeros.FormattingEnabled = true;
            this.lsbPasajeros.ItemHeight = 16;
            this.lsbPasajeros.Location = new System.Drawing.Point(26, 109);
            this.lsbPasajeros.Name = "lsbPasajeros";
            this.lsbPasajeros.Size = new System.Drawing.Size(394, 196);
            this.lsbPasajeros.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pasajero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "En espera";
            // 
            // txtPasajero
            // 
            this.txtPasajero.Location = new System.Drawing.Point(91, 34);
            this.txtPasajero.Name = "txtPasajero";
            this.txtPasajero.Size = new System.Drawing.Size(329, 22);
            this.txtPasajero.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPasajero);
            this.groupBox1.Controls.Add(this.lsbPasajeros);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSubir);
            this.groupBox1.Controls.Add(this.btnAnotar);
            this.groupBox1.Location = new System.Drawing.Point(717, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 344);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Terminal Obelisco";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnotar;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.ListBox lsbPasajeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasajero;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

