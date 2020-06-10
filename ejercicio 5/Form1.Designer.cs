namespace ejercicio_5
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
            this.btnCrear1 = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCrearFecha = new System.Windows.Forms.Button();
            this.btnConsultarFecha = new System.Windows.Forms.Button();
            this.lblFechaHoy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCrear1
            // 
            this.btnCrear1.Location = new System.Drawing.Point(214, 6);
            this.btnCrear1.Name = "btnCrear1";
            this.btnCrear1.Size = new System.Drawing.Size(118, 23);
            this.btnCrear1.TabIndex = 0;
            this.btnCrear1.Text = "Crear Fecha";
            this.btnCrear1.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(338, 6);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(126, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar Fecha";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnCrearFecha
            // 
            this.btnCrearFecha.Location = new System.Drawing.Point(306, 118);
            this.btnCrearFecha.Name = "btnCrearFecha";
            this.btnCrearFecha.Size = new System.Drawing.Size(127, 23);
            this.btnCrearFecha.TabIndex = 2;
            this.btnCrearFecha.Text = "Crear Fecha";
            this.btnCrearFecha.UseVisualStyleBackColor = true;
            // 
            // btnConsultarFecha
            // 
            this.btnConsultarFecha.Location = new System.Drawing.Point(439, 118);
            this.btnConsultarFecha.Name = "btnConsultarFecha";
            this.btnConsultarFecha.Size = new System.Drawing.Size(142, 23);
            this.btnConsultarFecha.TabIndex = 3;
            this.btnConsultarFecha.Text = "Consultar Fecha";
            this.btnConsultarFecha.UseVisualStyleBackColor = true;
            // 
            // lblFechaHoy
            // 
            this.lblFechaHoy.AutoSize = true;
            this.lblFechaHoy.Location = new System.Drawing.Point(24, 9);
            this.lblFechaHoy.Name = "lblFechaHoy";
            this.lblFechaHoy.Size = new System.Drawing.Size(140, 17);
            this.lblFechaHoy.TabIndex = 7;
            this.lblFechaHoy.Text = "Fecha del dia de hoy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Crear una fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Año";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 22);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 22);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 22);
            this.textBox3.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 175);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFechaHoy);
            this.Controls.Add(this.btnConsultarFecha);
            this.Controls.Add(this.btnCrearFecha);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCrear1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCrearFecha;
        private System.Windows.Forms.Button btnConsultarFecha;
        private System.Windows.Forms.Label lblFechaHoy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

