namespace TP4
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnRegistrarP = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnAgregarDspsSeleccionado = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Ingrese nombre";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese apellido:";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese dirección:";

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingrese teléfono:";

            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 4;

            this.textBox2.Location = new System.Drawing.Point(12, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 20);
            this.textBox2.TabIndex = 5;

            this.textBox3.Location = new System.Drawing.Point(12, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 20);
            this.textBox3.TabIndex = 7;

            this.textBox4.Location = new System.Drawing.Point(12, 146);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(118, 20);
            this.textBox4.TabIndex = 6;

            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(462, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(326, 342);
            this.listBox1.TabIndex = 8;

            this.BtnRegistrarP.Location = new System.Drawing.Point(162, 16);
            this.BtnRegistrarP.Name = "BtnRegistrarP";
            this.BtnRegistrarP.Size = new System.Drawing.Size(114, 49);
            this.BtnRegistrarP.TabIndex = 9;
            this.BtnRegistrarP.Text = " Registar paciente";
            this.BtnRegistrarP.UseVisualStyleBackColor = true;
            this.BtnRegistrarP.Click += new System.EventHandler(this.BtnRegistrarP_Click);

            this.BtnEliminar.Location = new System.Drawing.Point(162, 68);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(114, 49);
            this.BtnEliminar.TabIndex = 10;
            this.BtnEliminar.Text = "Eliminar Paciente";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);

            this.button3.Location = new System.Drawing.Point(162, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 49);
            this.button3.TabIndex = 11;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);

            this.BtnAgregarDspsSeleccionado.Location = new System.Drawing.Point(162, 175);
            this.BtnAgregarDspsSeleccionado.Name = "BtnAgregarDspsSeleccionado";
            this.BtnAgregarDspsSeleccionado.Size = new System.Drawing.Size(114, 49);
            this.BtnAgregarDspsSeleccionado.TabIndex = 12;
            this.BtnAgregarDspsSeleccionado.Text = "Agregar Dsps Seleccionado.";
            this.BtnAgregarDspsSeleccionado.UseVisualStyleBackColor = true;
            this.BtnAgregarDspsSeleccionado.Click += new System.EventHandler(this.BtnAgregarDspsSeleccionado_Click);

            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAgregarDspsSeleccionado);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnRegistrarP);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnRegistrarP;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnAgregarDspsSeleccionado;
        private System.Windows.Forms.Timer timer1;
    }
}
