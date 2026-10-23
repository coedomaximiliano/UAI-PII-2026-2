namespace EJ_06_Listas
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.NudEdad = new System.Windows.Forms.NumericUpDown();
            this.BtnCalcularRec = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudEdad)).BeginInit();
            this.SuspendLayout();

            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(466, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(303, 433);
            this.listBox1.TabIndex = 0;

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese edad:";

            this.BtnRegistrar.Location = new System.Drawing.Point(345, 32);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(100, 50);
            this.BtnRegistrar.TabIndex = 3;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);

            this.BtnEliminar.Location = new System.Drawing.Point(345, 88);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 50);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);

            this.BtnActualizar.Location = new System.Drawing.Point(345, 144);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(100, 50);
            this.BtnActualizar.TabIndex = 6;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese nombre:";

            this.TBNombre.Location = new System.Drawing.Point(12, 72);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(126, 20);
            this.TBNombre.TabIndex = 9;

            this.NudEdad.Location = new System.Drawing.Point(12, 25);
            this.NudEdad.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NudEdad.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NudEdad.Name = "NudEdad";
            this.NudEdad.Size = new System.Drawing.Size(120, 20);
            this.NudEdad.TabIndex = 10;
            this.NudEdad.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});

            this.BtnCalcularRec.Location = new System.Drawing.Point(310, 343);
            this.BtnCalcularRec.Name = "BtnCalcularRec";
            this.BtnCalcularRec.Size = new System.Drawing.Size(135, 63);
            this.BtnCalcularRec.TabIndex = 11;
            this.BtnCalcularRec.Text = "CALCULAR RECAUDACIÓN";
            this.BtnCalcularRec.UseVisualStyleBackColor = true;
            this.BtnCalcularRec.Click += new System.EventHandler(this.BtnCalcularRec_Click);

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 343);
            this.label3.Name = "label3";
            this.label3.TabIndex = 12;
            this.label3.Text = "Recaudación: ";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 496);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCalcularRec);
            this.Controls.Add(this.NudEdad);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Cine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.NumericUpDown NudEdad;
        private System.Windows.Forms.Button BtnCalcularRec;
        private System.Windows.Forms.Label label3;
    }
}
