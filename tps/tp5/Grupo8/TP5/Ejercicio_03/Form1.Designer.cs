namespace Ejercicio_03
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
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.TBNum = new System.Windows.Forms.TextBox();
            this.TBCar = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelx = new System.Windows.Forms.Label();
            this.BtnPush = new System.Windows.Forms.Button();
            this.BtnPop = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LabelExpediente = new System.Windows.Forms.Label();
            this.BtnOrderNum = new System.Windows.Forms.Button();
            this.BtnOrderFecha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DTPFecha
            // 
            this.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFecha.Location = new System.Drawing.Point(12, 25);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(188, 20);
            this.DTPFecha.TabIndex = 0;
            // 
            // TBNum
            // 
            this.TBNum.Location = new System.Drawing.Point(9, 64);
            this.TBNum.Name = "TBNum";
            this.TBNum.Size = new System.Drawing.Size(188, 20);
            this.TBNum.TabIndex = 1;
            // 
            // TBCar
            // 
            this.TBCar.Location = new System.Drawing.Point(12, 103);
            this.TBCar.Name = "TBCar";
            this.TBCar.Size = new System.Drawing.Size(188, 20);
            this.TBCar.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(206, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 433);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese una fecha de expedientes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese Num de expediente:";
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Location = new System.Drawing.Point(12, 87);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(87, 13);
            this.labelx.TabIndex = 6;
            this.labelx.Text = "Ingrese Caratula:";
            // 
            // BtnPush
            // 
            this.BtnPush.Location = new System.Drawing.Point(15, 145);
            this.BtnPush.Name = "BtnPush";
            this.BtnPush.Size = new System.Drawing.Size(185, 31);
            this.BtnPush.TabIndex = 7;
            this.BtnPush.Text = "Push";
            this.BtnPush.UseVisualStyleBackColor = true;
            this.BtnPush.Click += new System.EventHandler(this.BtnPush_Click);
            // 
            // BtnPop
            // 
            this.BtnPop.Location = new System.Drawing.Point(15, 182);
            this.BtnPop.Name = "BtnPop";
            this.BtnPop.Size = new System.Drawing.Size(185, 31);
            this.BtnPop.TabIndex = 8;
            this.BtnPop.Text = "Pop";
            this.BtnPop.UseVisualStyleBackColor = true;
            this.BtnPop.Click += new System.EventHandler(this.BtnPop_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(12, 219);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(185, 31);
            this.BtnClear.TabIndex = 9;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LabelExpediente
            // 
            this.LabelExpediente.AutoSize = true;
            this.LabelExpediente.Location = new System.Drawing.Point(492, 9);
            this.LabelExpediente.Name = "LabelExpediente";
            this.LabelExpediente.Size = new System.Drawing.Size(84, 13);
            this.LabelExpediente.TabIndex = 10;
            this.LabelExpediente.Text = "Expediente_pop";
            // 
            // BtnOrderNum
            // 
            this.BtnOrderNum.Location = new System.Drawing.Point(15, 282);
            this.BtnOrderNum.Name = "BtnOrderNum";
            this.BtnOrderNum.Size = new System.Drawing.Size(185, 31);
            this.BtnOrderNum.TabIndex = 11;
            this.BtnOrderNum.Text = "Ordenar x Num";
            this.BtnOrderNum.UseVisualStyleBackColor = true;
            this.BtnOrderNum.Click += new System.EventHandler(this.BtnOrderNum_Click);
            // 
            // BtnOrderFecha
            // 
            this.BtnOrderFecha.Location = new System.Drawing.Point(15, 319);
            this.BtnOrderFecha.Name = "BtnOrderFecha";
            this.BtnOrderFecha.Size = new System.Drawing.Size(185, 31);
            this.BtnOrderFecha.TabIndex = 12;
            this.BtnOrderFecha.Text = "Ordenar x Fecha";
            this.BtnOrderFecha.UseVisualStyleBackColor = true;
            this.BtnOrderFecha.Click += new System.EventHandler(this.BtnOrderFecha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.BtnOrderFecha);
            this.Controls.Add(this.BtnOrderNum);
            this.Controls.Add(this.LabelExpediente);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnPop);
            this.Controls.Add(this.BtnPush);
            this.Controls.Add(this.labelx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TBCar);
            this.Controls.Add(this.TBNum);
            this.Controls.Add(this.DTPFecha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.TextBox TBNum;
        private System.Windows.Forms.TextBox TBCar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Button BtnPush;
        private System.Windows.Forms.Button BtnPop;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label LabelExpediente;
        private System.Windows.Forms.Button BtnOrderNum;
        private System.Windows.Forms.Button BtnOrderFecha;
    }
}

