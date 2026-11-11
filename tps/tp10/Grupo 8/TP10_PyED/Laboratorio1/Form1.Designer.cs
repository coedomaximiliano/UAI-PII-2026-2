namespace Laboratorio1
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
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblApellYNom = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.txtLeg = new System.Windows.Forms.TextBox();
            this.txtApellYNom = new System.Windows.Forms.TextBox();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.lstListado = new System.Windows.Forms.ListBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblLegajo
            //
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(27, 42);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(50, 17);
            this.lblLegajo.TabIndex = 0;
            this.lblLegajo.Text = "legajo";
            //
            // lblApellYNom
            //
            this.lblApellYNom.AutoSize = true;
            this.lblApellYNom.Location = new System.Drawing.Point(27, 92);
            this.lblApellYNom.Name = "lblApellYNom";
            this.lblApellYNom.Size = new System.Drawing.Size(115, 17);
            this.lblApellYNom.TabIndex = 1;
            this.lblApellYNom.Text = "apellido y nombre";
            //
            // lblCat
            //
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(27, 142);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(64, 17);
            this.lblCat.TabIndex = 2;
            this.lblCat.Text = "categoria";
            //
            // txtLeg
            //
            this.txtLeg.Location = new System.Drawing.Point(150, 37);
            this.txtLeg.Name = "txtLeg";
            this.txtLeg.Size = new System.Drawing.Size(200, 22);
            this.txtLeg.TabIndex = 3;
            //
            // txtApellYNom
            //
            this.txtApellYNom.Location = new System.Drawing.Point(150, 87);
            this.txtApellYNom.Name = "txtApellYNom";
            this.txtApellYNom.Size = new System.Drawing.Size(200, 22);
            this.txtApellYNom.TabIndex = 4;
            //
            // txtCat
            //
            this.txtCat.Location = new System.Drawing.Point(150, 137);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(200, 22);
            this.txtCat.TabIndex = 5;
            //
            // lstListado
            //
            this.lstListado.FormattingEnabled = true;
            this.lstListado.Location = new System.Drawing.Point(27, 190);
            this.lstListado.Name = "lstListado";
            this.lstListado.Size = new System.Drawing.Size(323, 216);
            this.lstListado.TabIndex = 6;
            this.lstListado.Click += new System.EventHandler(this.lstListado_Click);
            //
            // btnAlta
            //
            this.btnAlta.Location = new System.Drawing.Point(27, 435);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(90, 33);
            this.btnAlta.TabIndex = 7;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            //
            // btnBaja
            //
            this.btnBaja.Location = new System.Drawing.Point(143, 435);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(90, 33);
            this.btnBaja.TabIndex = 8;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            //
            // btnModificar
            //
            this.btnModificar.Location = new System.Drawing.Point(260, 435);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 33);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificacion";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            //
            // btnSalir
            //
            this.btnSalir.Location = new System.Drawing.Point(377, 435);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 33);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 491);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.lstListado);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.txtApellYNom);
            this.Controls.Add(this.txtLeg);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblApellYNom);
            this.Controls.Add(this.lblLegajo);
            this.Name = "Form1";
            this.Text = "archivo secuencial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblApellYNom;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.TextBox txtLeg;
        private System.Windows.Forms.TextBox txtApellYNom;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.ListBox lstListado;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
    }
}
