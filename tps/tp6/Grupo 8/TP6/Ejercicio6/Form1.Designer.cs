namespace Ejercicio6
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
            this.LbGral = new System.Windows.Forms.ListBox();
            this.LbPasan = new System.Windows.Forms.ListBox();
            this.LbColados = new System.Windows.Forms.ListBox();
            this.BtnDesencolar = new System.Windows.Forms.Button();
            this.BtnVerColaFinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbGral
            // 
            this.LbGral.FormattingEnabled = true;
            this.LbGral.Location = new System.Drawing.Point(130, 12);
            this.LbGral.Name = "LbGral";
            this.LbGral.Size = new System.Drawing.Size(315, 251);
            this.LbGral.TabIndex = 0;
            // 
            // LbPasan
            // 
            this.LbPasan.FormattingEnabled = true;
            this.LbPasan.Location = new System.Drawing.Point(130, 269);
            this.LbPasan.Name = "LbPasan";
            this.LbPasan.Size = new System.Drawing.Size(157, 173);
            this.LbPasan.TabIndex = 1;
            // 
            // LbColados
            // 
            this.LbColados.FormattingEnabled = true;
            this.LbColados.Location = new System.Drawing.Point(293, 269);
            this.LbColados.Name = "LbColados";
            this.LbColados.Size = new System.Drawing.Size(152, 173);
            this.LbColados.TabIndex = 2;
            // 
            // BtnDesencolar
            // 
            this.BtnDesencolar.Location = new System.Drawing.Point(10, 12);
            this.BtnDesencolar.Name = "BtnDesencolar";
            this.BtnDesencolar.Size = new System.Drawing.Size(114, 53);
            this.BtnDesencolar.TabIndex = 3;
            this.BtnDesencolar.Text = "Desencolar";
            this.BtnDesencolar.UseVisualStyleBackColor = true;
            this.BtnDesencolar.Click += new System.EventHandler(this.BtnDesencolar_Click);
            // 
            // BtnVerColaFinal
            // 
            this.BtnVerColaFinal.Location = new System.Drawing.Point(10, 71);
            this.BtnVerColaFinal.Name = "BtnVerColaFinal";
            this.BtnVerColaFinal.Size = new System.Drawing.Size(114, 53);
            this.BtnVerColaFinal.TabIndex = 4;
            this.BtnVerColaFinal.Text = "Ver cola final";
            this.BtnVerColaFinal.UseVisualStyleBackColor = true;
            this.BtnVerColaFinal.Click += new System.EventHandler(this.BtnVerColaFinal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 451);
            this.Controls.Add(this.BtnVerColaFinal);
            this.Controls.Add(this.BtnDesencolar);
            this.Controls.Add(this.LbColados);
            this.Controls.Add(this.LbPasan);
            this.Controls.Add(this.LbGral);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LbGral;
        private System.Windows.Forms.ListBox LbPasan;
        private System.Windows.Forms.ListBox LbColados;
        private System.Windows.Forms.Button BtnDesencolar;
        private System.Windows.Forms.Button BtnVerColaFinal;
    }
}

