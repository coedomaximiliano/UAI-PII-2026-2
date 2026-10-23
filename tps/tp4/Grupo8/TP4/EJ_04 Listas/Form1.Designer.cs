namespace EJ_04_Listas
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NudEdad = new System.Windows.Forms.NumericUpDown();
            this.LbRonda = new System.Windows.Forms.Label();
            this.LblGanador = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnJugar = new System.Windows.Forms.Button();
            this.BtnAgregarDespues = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LstNinios = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudEdad)).BeginInit();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese nombre:";

            this.textBox1.Location = new System.Drawing.Point(15, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 1;

            this.textBox2.Location = new System.Drawing.Point(15, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 3;

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese apellido:";

            this.textBox3.Location = new System.Drawing.Point(15, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(119, 20);
            this.textBox3.TabIndex = 5;

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese edad:";

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingrese DNI:";

            this.NudEdad.Location = new System.Drawing.Point(14, 119);
            this.NudEdad.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.NudEdad.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NudEdad.Name = "NudEdad";
            this.NudEdad.Size = new System.Drawing.Size(120, 20);
            this.NudEdad.TabIndex = 7;
            this.NudEdad.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});

            this.LbRonda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbRonda.AutoSize = false;
            this.LbRonda.Font = new System.Drawing.Font("Nirmala UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRonda.Location = new System.Drawing.Point(175, 9);
            this.LbRonda.Name = "LbRonda";
            this.LbRonda.Size = new System.Drawing.Size(490, 48);
            this.LbRonda.TabIndex = 8;
            this.LbRonda.Text = "Lista niños";

            this.LblGanador.AutoSize = true;
            this.LblGanador.Font = new System.Drawing.Font("Ubuntu Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGanador.Location = new System.Drawing.Point(175, 335);
            this.LblGanador.Name = "LblGanador";
            this.LblGanador.Size = new System.Drawing.Size(72, 20);
            this.LblGanador.TabIndex = 9;
            this.LblGanador.Text = "";

            this.BtnAgregar.Location = new System.Drawing.Point(15, 195);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(120, 40);
            this.BtnAgregar.TabIndex = 10;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);

            this.BtnJugar.Location = new System.Drawing.Point(15, 385);
            this.BtnJugar.Name = "BtnJugar";
            this.BtnJugar.Size = new System.Drawing.Size(120, 40);
            this.BtnJugar.TabIndex = 14;
            this.BtnJugar.Text = "Jugar";
            this.BtnJugar.UseVisualStyleBackColor = true;
            this.BtnJugar.Click += new System.EventHandler(this.BtnJugar_Click);

            this.BtnAgregarDespues.Location = new System.Drawing.Point(15, 241);
            this.BtnAgregarDespues.Name = "BtnAgregarDespues";
            this.BtnAgregarDespues.Size = new System.Drawing.Size(120, 40);
            this.BtnAgregarDespues.TabIndex = 11;
            this.BtnAgregarDespues.Text = "Agregar después";
            this.BtnAgregarDespues.UseVisualStyleBackColor = true;
            this.BtnAgregarDespues.Click += new System.EventHandler(this.BtnAgregarDespues_Click);

            this.BtnModificar.Location = new System.Drawing.Point(15, 287);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(120, 40);
            this.BtnModificar.TabIndex = 12;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);

            this.BtnEliminar.Location = new System.Drawing.Point(15, 333);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(120, 40);
            this.BtnEliminar.TabIndex = 13;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);

            this.LstNinios.FormattingEnabled = true;
            this.LstNinios.Location = new System.Drawing.Point(175, 65);
            this.LstNinios.Name = "LstNinios";
            this.LstNinios.Size = new System.Drawing.Size(490, 251);
            this.LstNinios.TabIndex = 15;
            this.LstNinios.SelectedIndexChanged += new System.EventHandler(this.LstNinios_SelectedIndexChanged);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.LstNinios);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregarDespues);
            this.Controls.Add(this.BtnJugar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.LblGanador);
            this.Controls.Add(this.LbRonda);
            this.Controls.Add(this.NudEdad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NudEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudEdad;
        private System.Windows.Forms.Label LbRonda;
        private System.Windows.Forms.Label LblGanador;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnJugar;
        private System.Windows.Forms.Button BtnAgregarDespues;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.ListBox LstNinios;
    }
}
