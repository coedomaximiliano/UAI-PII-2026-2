namespace EJ_02
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
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBDireccion = new System.Windows.Forms.TextBox();
            this.DTPFechNac = new System.Windows.Forms.DateTimePicker();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnAddDespues = new System.Windows.Forms.Button();
            this.BtnAddAntes = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(438, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(312, 420);
            this.listBox1.TabIndex = 0;

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese nombre:";

            this.TBNombre.Location = new System.Drawing.Point(12, 25);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(149, 20);
            this.TBNombre.TabIndex = 2;

            this.TBApellido.Location = new System.Drawing.Point(12, 65);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(149, 20);
            this.TBApellido.TabIndex = 4;

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese apellido:";

            this.TBDni.Location = new System.Drawing.Point(15, 110);
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(149, 20);
            this.TBDni.TabIndex = 6;

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = " Ingrese DNI";

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingrese fecha de nac:";

            this.TBTelefono.Location = new System.Drawing.Point(15, 227);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(149, 20);
            this.TBTelefono.TabIndex = 10;

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ingrese dirección:";

            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = " Ingrese teléfono";

            this.TBDireccion.Location = new System.Drawing.Point(15, 188);
            this.TBDireccion.Name = "TBDireccion";
            this.TBDireccion.Size = new System.Drawing.Size(149, 20);
            this.TBDireccion.TabIndex = 8;

            this.DTPFechNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechNac.Location = new System.Drawing.Point(15, 149);
            this.DTPFechNac.Name = "DTPFechNac";
            this.DTPFechNac.Size = new System.Drawing.Size(149, 20);
            this.DTPFechNac.TabIndex = 12;

            this.BtnRegistrar.Location = new System.Drawing.Point(301, 14);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(131, 48);
            this.BtnRegistrar.TabIndex = 14;
            this.BtnRegistrar.Text = "Registrar Alumno";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);

            this.BtnEliminar.Location = new System.Drawing.Point(301, 67);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(131, 48);
            this.BtnEliminar.TabIndex = 15;
            this.BtnEliminar.Text = "Eliminar Seleccionado";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);

            this.BtnActualizar.Location = new System.Drawing.Point(301, 121);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(131, 48);
            this.BtnActualizar.TabIndex = 16;
            this.BtnActualizar.Text = "Actualizar Seleccionado";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);

            this.BtnAddDespues.Location = new System.Drawing.Point(301, 175);
            this.BtnAddDespues.Name = "BtnAddDespues";
            this.BtnAddDespues.Size = new System.Drawing.Size(131, 48);
            this.BtnAddDespues.TabIndex = 17;
            this.BtnAddDespues.Text = "Agregar Despues del Seleccionado";
            this.BtnAddDespues.UseVisualStyleBackColor = true;
            this.BtnAddDespues.Click += new System.EventHandler(this.BtnAddDespues_Click);

            this.BtnAddAntes.Location = new System.Drawing.Point(301, 229);
            this.BtnAddAntes.Name = "BtnAddAntes";
            this.BtnAddAntes.Size = new System.Drawing.Size(131, 48);
            this.BtnAddAntes.TabIndex = 18;
            this.BtnAddAntes.Text = " Agregar Antes del Seleccionado";
            this.BtnAddAntes.UseVisualStyleBackColor = true;
            this.BtnAddAntes.Click += new System.EventHandler(this.BtnAddAntes_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 445);
            this.Controls.Add(this.BtnAddAntes);
            this.Controls.Add(this.BtnAddDespues);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.DTPFechNac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBDni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBDireccion;
        private System.Windows.Forms.DateTimePicker DTPFechNac;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnAddDespues;
        private System.Windows.Forms.Button BtnAddAntes;
    }
}
