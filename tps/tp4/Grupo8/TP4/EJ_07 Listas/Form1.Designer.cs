namespace EJ_07_Listas
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBNumero1 = new System.Windows.Forms.TextBox();
            this.TBNumero2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnIntercambiarDerecha = new System.Windows.Forms.Button();
            this.BtnIntercambiarIzquierda = new System.Windows.Forms.Button();
            this.BtnIntercambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese número:";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.TabIndex = 1;
            this.label2.Text = "Número a intercambiar:";

            this.TBNumero1.Location = new System.Drawing.Point(12, 29);
            this.TBNumero1.Name = "TBNumero1";
            this.TBNumero1.Size = new System.Drawing.Size(118, 20);
            this.TBNumero1.TabIndex = 4;

            this.TBNumero2.Location = new System.Drawing.Point(12, 68);
            this.TBNumero2.Name = "TBNumero2";
            this.TBNumero2.Size = new System.Drawing.Size(118, 20);
            this.TBNumero2.TabIndex = 5;

            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(462, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(326, 342);
            this.listBox1.TabIndex = 8;

            this.BtnAgregar.Location = new System.Drawing.Point(162, 16);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(114, 49);
            this.BtnAgregar.TabIndex = 9;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);

            this.BtnIntercambiarDerecha.Location = new System.Drawing.Point(162, 68);
            this.BtnIntercambiarDerecha.Name = "BtnIntercambiarDerecha";
            this.BtnIntercambiarDerecha.Size = new System.Drawing.Size(114, 49);
            this.BtnIntercambiarDerecha.TabIndex = 10;
            this.BtnIntercambiarDerecha.Text = "Intercambiar Derecha";
            this.BtnIntercambiarDerecha.UseVisualStyleBackColor = true;
            this.BtnIntercambiarDerecha.Click += new System.EventHandler(this.BtnIntercambiarDerecha_Click);

            this.BtnIntercambiarIzquierda.Location = new System.Drawing.Point(162, 120);
            this.BtnIntercambiarIzquierda.Name = "BtnIntercambiarIzquierda";
            this.BtnIntercambiarIzquierda.Size = new System.Drawing.Size(114, 49);
            this.BtnIntercambiarIzquierda.TabIndex = 11;
            this.BtnIntercambiarIzquierda.Text = "Intercambiar Izquierda";
            this.BtnIntercambiarIzquierda.UseVisualStyleBackColor = true;
            this.BtnIntercambiarIzquierda.Click += new System.EventHandler(this.BtnIntercambiarIzquierda_Click);

            this.BtnIntercambiar.Location = new System.Drawing.Point(162, 172);
            this.BtnIntercambiar.Name = "BtnIntercambiar";
            this.BtnIntercambiar.Size = new System.Drawing.Size(114, 49);
            this.BtnIntercambiar.TabIndex = 12;
            this.BtnIntercambiar.Text = "Intercambiar";
            this.BtnIntercambiar.UseVisualStyleBackColor = true;
            this.BtnIntercambiar.Click += new System.EventHandler(this.BtnIntercambiar_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnIntercambiar);
            this.Controls.Add(this.BtnIntercambiarIzquierda);
            this.Controls.Add(this.BtnIntercambiarDerecha);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TBNumero2);
            this.Controls.Add(this.TBNumero1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Intercambiar Números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBNumero1;
        private System.Windows.Forms.TextBox TBNumero2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnIntercambiarDerecha;
        private System.Windows.Forms.Button BtnIntercambiarIzquierda;
        private System.Windows.Forms.Button BtnIntercambiar;
    }
}
