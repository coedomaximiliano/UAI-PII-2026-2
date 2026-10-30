namespace Ejercicio4
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
            this.LbColaGral = new System.Windows.Forms.ListBox();
            this.LbColaHombres = new System.Windows.Forms.ListBox();
            this.LbColaMujeres = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RbHombre = new System.Windows.Forms.RadioButton();
            this.RbMujer = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnEncolar = new System.Windows.Forms.Button();
            this.BtnDesencolar = new System.Windows.Forms.Button();
            this.BtnVerFrente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbColaGral
            // 
            this.LbColaGral.FormattingEnabled = true;
            this.LbColaGral.Location = new System.Drawing.Point(432, 12);
            this.LbColaGral.Name = "LbColaGral";
            this.LbColaGral.Size = new System.Drawing.Size(356, 225);
            this.LbColaGral.TabIndex = 0;
            // 
            // LbColaHombres
            // 
            this.LbColaHombres.FormattingEnabled = true;
            this.LbColaHombres.Location = new System.Drawing.Point(432, 252);
            this.LbColaHombres.Name = "LbColaHombres";
            this.LbColaHombres.Size = new System.Drawing.Size(175, 186);
            this.LbColaHombres.TabIndex = 1;
            // 
            // LbColaMujeres
            // 
            this.LbColaMujeres.FormattingEnabled = true;
            this.LbColaMujeres.Location = new System.Drawing.Point(613, 252);
            this.LbColaMujeres.Name = "LbColaMujeres";
            this.LbColaMujeres.Size = new System.Drawing.Size(175, 186);
            this.LbColaMujeres.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese Nombre:";
            // 
            // RbHombre
            // 
            this.RbHombre.AutoSize = true;
            this.RbHombre.Location = new System.Drawing.Point(12, 51);
            this.RbHombre.Name = "RbHombre";
            this.RbHombre.Size = new System.Drawing.Size(75, 17);
            this.RbHombre.TabIndex = 4;
            this.RbHombre.TabStop = true;
            this.RbHombre.Text = "Es hombre";
            this.RbHombre.UseVisualStyleBackColor = true;
            // 
            // RbMujer
            // 
            this.RbMujer.AutoSize = true;
            this.RbMujer.Location = new System.Drawing.Point(12, 74);
            this.RbMujer.Name = "RbMujer";
            this.RbMujer.Size = new System.Drawing.Size(65, 17);
            this.RbMujer.TabIndex = 5;
            this.RbMujer.TabStop = true;
            this.RbMujer.Text = "Es mujer";
            this.RbMujer.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // BtnEncolar
            // 
            this.BtnEncolar.Location = new System.Drawing.Point(12, 113);
            this.BtnEncolar.Name = "BtnEncolar";
            this.BtnEncolar.Size = new System.Drawing.Size(100, 41);
            this.BtnEncolar.TabIndex = 7;
            this.BtnEncolar.Text = "Encolar";
            this.BtnEncolar.UseVisualStyleBackColor = true;
            this.BtnEncolar.Click += new System.EventHandler(this.BtnEncolar_Click);
            // 
            // BtnDesencolar
            // 
            this.BtnDesencolar.Location = new System.Drawing.Point(12, 160);
            this.BtnDesencolar.Name = "BtnDesencolar";
            this.BtnDesencolar.Size = new System.Drawing.Size(100, 41);
            this.BtnDesencolar.TabIndex = 8;
            this.BtnDesencolar.Text = "Desencolar";
            this.BtnDesencolar.UseVisualStyleBackColor = true;
            this.BtnDesencolar.Click += new System.EventHandler(this.BtnDesencolar_Click);
            // 
            // BtnVerFrente
            // 
            this.BtnVerFrente.Location = new System.Drawing.Point(12, 207);
            this.BtnVerFrente.Name = "BtnVerFrente";
            this.BtnVerFrente.Size = new System.Drawing.Size(100, 41);
            this.BtnVerFrente.TabIndex = 9;
            this.BtnVerFrente.Text = "Ver frente";
            this.BtnVerFrente.UseVisualStyleBackColor = true;
            this.BtnVerFrente.Click += new System.EventHandler(this.BtnVerFrente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnVerFrente);
            this.Controls.Add(this.BtnDesencolar);
            this.Controls.Add(this.BtnEncolar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RbMujer);
            this.Controls.Add(this.RbHombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbColaMujeres);
            this.Controls.Add(this.LbColaHombres);
            this.Controls.Add(this.LbColaGral);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbColaGral;
        private System.Windows.Forms.ListBox LbColaHombres;
        private System.Windows.Forms.ListBox LbColaMujeres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RbHombre;
        private System.Windows.Forms.RadioButton RbMujer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnEncolar;
        private System.Windows.Forms.Button BtnDesencolar;
        private System.Windows.Forms.Button BtnVerFrente;
        private System.Windows.Forms.Label label2;
    }
}

