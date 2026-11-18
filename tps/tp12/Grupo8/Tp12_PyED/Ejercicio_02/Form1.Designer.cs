namespace Ejercicio_02
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.TbDuracion = new System.Windows.Forms.TextBox();
            this.TbPosicion = new System.Windows.Forms.TextBox();
            this.BtnAgregarPrincipio = new System.Windows.Forms.Button();
            this.BtnAgregarFinal = new System.Windows.Forms.Button();
            this.BtnAgregarPosicion = new System.Windows.Forms.Button();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.BtnIntercambiar = new System.Windows.Forms.Button();
            this.ListaCanciones = new System.Windows.Forms.ListBox();
            this.lblTotalCanciones = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnPausa = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.LblReproduciendo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.lblTotalCanciones);
            this.groupBox1.Controls.Add(this.BtnIntercambiar);
            this.groupBox1.Controls.Add(this.BtnQuitar);
            this.groupBox1.Controls.Add(this.ListaCanciones);
            this.groupBox1.Controls.Add(this.BtnAgregarPosicion);
            this.groupBox1.Controls.Add(this.BtnAgregarFinal);
            this.groupBox1.Controls.Add(this.BtnAgregarPrincipio);
            this.groupBox1.Controls.Add(this.TbPosicion);
            this.groupBox1.Controls.Add(this.TbDuracion);
            this.groupBox1.Controls.Add(this.TbNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de reproducción";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Canción:";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duración (seg):";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Posición:";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "En la lista:";
            //
            // TbNombre
            //
            this.TbNombre.Location = new System.Drawing.Point(75, 19);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(170, 20);
            this.TbNombre.TabIndex = 4;
            //
            // TbDuracion
            //
            this.TbDuracion.Location = new System.Drawing.Point(355, 19);
            this.TbDuracion.Name = "TbDuracion";
            this.TbDuracion.Size = new System.Drawing.Size(60, 20);
            this.TbDuracion.TabIndex = 5;
            //
            // TbPosicion
            //
            this.TbPosicion.Location = new System.Drawing.Point(345, 49);
            this.TbPosicion.Name = "TbPosicion";
            this.TbPosicion.Size = new System.Drawing.Size(40, 20);
            this.TbPosicion.TabIndex = 6;
            //
            // BtnAgregarPrincipio
            //
            this.BtnAgregarPrincipio.Location = new System.Drawing.Point(10, 48);
            this.BtnAgregarPrincipio.Name = "BtnAgregarPrincipio";
            this.BtnAgregarPrincipio.Size = new System.Drawing.Size(140, 23);
            this.BtnAgregarPrincipio.TabIndex = 7;
            this.BtnAgregarPrincipio.Text = "Agregar al principio";
            this.BtnAgregarPrincipio.UseVisualStyleBackColor = true;
            this.BtnAgregarPrincipio.Click += new System.EventHandler(this.BtnAgregarPrincipio_Click);
            //
            // BtnAgregarFinal
            //
            this.BtnAgregarFinal.Location = new System.Drawing.Point(160, 48);
            this.BtnAgregarFinal.Name = "BtnAgregarFinal";
            this.BtnAgregarFinal.Size = new System.Drawing.Size(110, 23);
            this.BtnAgregarFinal.TabIndex = 8;
            this.BtnAgregarFinal.Text = "Agregar al final";
            this.BtnAgregarFinal.UseVisualStyleBackColor = true;
            this.BtnAgregarFinal.Click += new System.EventHandler(this.BtnAgregarFinal_Click);
            //
            // BtnAgregarPosicion
            //
            this.BtnAgregarPosicion.Location = new System.Drawing.Point(390, 48);
            this.BtnAgregarPosicion.Name = "BtnAgregarPosicion";
            this.BtnAgregarPosicion.Size = new System.Drawing.Size(160, 23);
            this.BtnAgregarPosicion.TabIndex = 9;
            this.BtnAgregarPosicion.Text = "Agregar en posición";
            this.BtnAgregarPosicion.UseVisualStyleBackColor = true;
            this.BtnAgregarPosicion.Click += new System.EventHandler(this.BtnAgregarPosicion_Click);
            //
            // ListaCanciones
            //
            this.ListaCanciones.FormattingEnabled = true;
            this.ListaCanciones.Location = new System.Drawing.Point(10, 103);
            this.ListaCanciones.Name = "ListaCanciones";
            this.ListaCanciones.Size = new System.Drawing.Size(540, 134);
            this.ListaCanciones.TabIndex = 10;
            //
            // lblTotalCanciones
            //
            this.lblTotalCanciones.AutoSize = true;
            this.lblTotalCanciones.Location = new System.Drawing.Point(10, 246);
            this.lblTotalCanciones.Name = "lblTotalCanciones";
            this.lblTotalCanciones.Size = new System.Drawing.Size(101, 13);
            this.lblTotalCanciones.TabIndex = 11;
            this.lblTotalCanciones.Text = "Total de canciones: 0";
            //
            // BtnQuitar
            //
            this.BtnQuitar.Location = new System.Drawing.Point(310, 242);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(115, 23);
            this.BtnQuitar.TabIndex = 12;
            this.BtnQuitar.Text = "Quitar seleccionada";
            this.BtnQuitar.UseVisualStyleBackColor = true;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            //
            // BtnIntercambiar
            //
            this.BtnIntercambiar.Location = new System.Drawing.Point(432, 242);
            this.BtnIntercambiar.Name = "BtnIntercambiar";
            this.BtnIntercambiar.Size = new System.Drawing.Size(118, 23);
            this.BtnIntercambiar.TabIndex = 13;
            this.BtnIntercambiar.Text = "Intercambiar con der.";
            this.BtnIntercambiar.UseVisualStyleBackColor = true;
            this.BtnIntercambiar.Click += new System.EventHandler(this.BtnIntercambiar_Click);
            //
            // groupBox2
            //
            this.groupBox2.Controls.Add(this.LblReproduciendo);
            this.groupBox2.Controls.Add(this.BtnStop);
            this.groupBox2.Controls.Add(this.BtnPausa);
            this.groupBox2.Controls.Add(this.BtnPlay);
            this.groupBox2.Location = new System.Drawing.Point(12, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reproducción";
            //
            // BtnPlay
            //
            this.BtnPlay.Location = new System.Drawing.Point(10, 20);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(80, 23);
            this.BtnPlay.TabIndex = 0;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            //
            // BtnPausa
            //
            this.BtnPausa.Location = new System.Drawing.Point(100, 20);
            this.BtnPausa.Name = "BtnPausa";
            this.BtnPausa.Size = new System.Drawing.Size(80, 23);
            this.BtnPausa.TabIndex = 1;
            this.BtnPausa.Text = "Pausa";
            this.BtnPausa.UseVisualStyleBackColor = true;
            this.BtnPausa.Click += new System.EventHandler(this.BtnPausa_Click);
            //
            // BtnStop
            //
            this.BtnStop.Location = new System.Drawing.Point(190, 20);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(80, 23);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            //
            // LblReproduciendo
            //
            this.LblReproduciendo.AutoSize = true;
            this.LblReproduciendo.Location = new System.Drawing.Point(10, 55);
            this.LblReproduciendo.Name = "LblReproduciendo";
            this.LblReproduciendo.Size = new System.Drawing.Size(53, 13);
            this.LblReproduciendo.TabIndex = 3;
            this.LblReproduciendo.Text = "Detenido";
            //
            // timer1
            //
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 415);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Reproductor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.TextBox TbDuracion;
        private System.Windows.Forms.TextBox TbPosicion;
        private System.Windows.Forms.Button BtnAgregarPrincipio;
        private System.Windows.Forms.Button BtnAgregarFinal;
        private System.Windows.Forms.Button BtnAgregarPosicion;
        private System.Windows.Forms.ListBox ListaCanciones;
        private System.Windows.Forms.Label lblTotalCanciones;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.Button BtnIntercambiar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnPausa;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Label LblReproduciendo;
        private System.Windows.Forms.Timer timer1;
    }
}
