namespace Tp12_PyED
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
            this.components = new System.ComponentModel.Container();
            this.PbCombi = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbPasajero = new System.Windows.Forms.TextBox();
            this.BtnAnotar = new System.Windows.Forms.Button();
            this.BtnSubir = new System.Windows.Forms.Button();
            this.Pasajeros = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PbCombi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PbCombi
            // 
            this.PbCombi.Image = global::Tp12_PyED.Properties.Resources.OIP_2819780340;
            this.PbCombi.Location = new System.Drawing.Point(-87, 18);
            this.PbCombi.Name = "PbCombi";
            this.PbCombi.Size = new System.Drawing.Size(500, 290);
            this.PbCombi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCombi.TabIndex = 0;
            this.PbCombi.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Pasajeros);
            this.groupBox1.Controls.Add(this.BtnSubir);
            this.groupBox1.Controls.Add(this.BtnAnotar);
            this.groupBox1.Controls.Add(this.TbPasajero);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(419, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 296);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Terminal obelisco";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pasajero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "En espera:";
            // 
            // TbPasajero
            // 
            this.TbPasajero.Location = new System.Drawing.Point(63, 20);
            this.TbPasajero.Name = "TbPasajero";
            this.TbPasajero.Size = new System.Drawing.Size(304, 20);
            this.TbPasajero.TabIndex = 2;
            // 
            // BtnAnotar
            // 
            this.BtnAnotar.Location = new System.Drawing.Point(292, 46);
            this.BtnAnotar.Name = "BtnAnotar";
            this.BtnAnotar.Size = new System.Drawing.Size(75, 23);
            this.BtnAnotar.TabIndex = 3;
            this.BtnAnotar.Text = "Anotar";
            this.BtnAnotar.UseVisualStyleBackColor = true;
            this.BtnAnotar.Click += new System.EventHandler(this.BtnAnotar_Click);
            // 
            // BtnSubir
            // 
            this.BtnSubir.Location = new System.Drawing.Point(264, 267);
            this.BtnSubir.Name = "BtnSubir";
            this.BtnSubir.Size = new System.Drawing.Size(103, 23);
            this.BtnSubir.TabIndex = 4;
            this.BtnSubir.Text = "Subir a la combi!";
            this.BtnSubir.UseVisualStyleBackColor = true;
            this.BtnSubir.Click += new System.EventHandler(this.BtnSubir_Click);
            // 
            // Pasajeros
            // 
            this.Pasajeros.FormattingEnabled = true;
            this.Pasajeros.Location = new System.Drawing.Point(6, 85);
            this.Pasajeros.Name = "Pasajeros";
            this.Pasajeros.Size = new System.Drawing.Size(361, 173);
            this.Pasajeros.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 332);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PbCombi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbCombi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbCombi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox Pasajeros;
        private System.Windows.Forms.Button BtnSubir;
        private System.Windows.Forms.Button BtnAnotar;
        private System.Windows.Forms.TextBox TbPasajero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

