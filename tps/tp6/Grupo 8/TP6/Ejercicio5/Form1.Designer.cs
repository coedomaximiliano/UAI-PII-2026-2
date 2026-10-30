namespace Ejercicio5
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NudPrioridad = new System.Windows.Forms.NumericUpDown();
            this.BtnEncolar = new System.Windows.Forms.Button();
            this.BtnDesencolar = new System.Windows.Forms.Button();
            this.BtnVerFrente = new System.Windows.Forms.Button();
            this.LblDesencolada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrioridad)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(159, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 394);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese cliente:";
            // 
            // TbCliente
            // 
            this.TbCliente.Location = new System.Drawing.Point(12, 25);
            this.TbCliente.Name = "TbCliente";
            this.TbCliente.Size = new System.Drawing.Size(100, 20);
            this.TbCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese prioridad:";
            // 
            // NudPrioridad
            // 
            this.NudPrioridad.Location = new System.Drawing.Point(12, 67);
            this.NudPrioridad.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NudPrioridad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudPrioridad.Name = "NudPrioridad";
            this.NudPrioridad.Size = new System.Drawing.Size(100, 20);
            this.NudPrioridad.TabIndex = 4;
            this.NudPrioridad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnEncolar
            // 
            this.BtnEncolar.Location = new System.Drawing.Point(12, 93);
            this.BtnEncolar.Name = "BtnEncolar";
            this.BtnEncolar.Size = new System.Drawing.Size(100, 38);
            this.BtnEncolar.TabIndex = 5;
            this.BtnEncolar.Text = "Encolar";
            this.BtnEncolar.UseVisualStyleBackColor = true;
            this.BtnEncolar.Click += new System.EventHandler(this.BtnEncolar_Click);
            // 
            // BtnDesencolar
            // 
            this.BtnDesencolar.Location = new System.Drawing.Point(12, 137);
            this.BtnDesencolar.Name = "BtnDesencolar";
            this.BtnDesencolar.Size = new System.Drawing.Size(100, 38);
            this.BtnDesencolar.TabIndex = 6;
            this.BtnDesencolar.Text = "Desencolar";
            this.BtnDesencolar.UseVisualStyleBackColor = true;
            this.BtnDesencolar.Click += new System.EventHandler(this.BtnDesencolar_Click);
            // 
            // BtnVerFrente
            // 
            this.BtnVerFrente.Location = new System.Drawing.Point(12, 181);
            this.BtnVerFrente.Name = "BtnVerFrente";
            this.BtnVerFrente.Size = new System.Drawing.Size(100, 38);
            this.BtnVerFrente.TabIndex = 7;
            this.BtnVerFrente.Text = "Ver frente";
            this.BtnVerFrente.UseVisualStyleBackColor = true;
            this.BtnVerFrente.Click += new System.EventHandler(this.BtnVerFrente_Click);
            // 
            // LblDesencolada
            // 
            this.LblDesencolada.AutoSize = true;
            this.LblDesencolada.Location = new System.Drawing.Point(416, 9);
            this.LblDesencolada.Name = "LblDesencolada";
            this.LblDesencolada.Size = new System.Drawing.Size(27, 13);
            this.LblDesencolada.TabIndex = 8;
            this.LblDesencolada.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblDesencolada);
            this.Controls.Add(this.BtnVerFrente);
            this.Controls.Add(this.BtnDesencolar);
            this.Controls.Add(this.BtnEncolar);
            this.Controls.Add(this.NudPrioridad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudPrioridad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NudPrioridad;
        private System.Windows.Forms.Button BtnEncolar;
        private System.Windows.Forms.Button BtnDesencolar;
        private System.Windows.Forms.Button BtnVerFrente;
        private System.Windows.Forms.Label LblDesencolada;
    }
}

