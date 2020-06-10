namespace WindowsFormsApp1
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
            this.lblRadio = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCalcularArea = new System.Windows.Forms.Button();
            this.btnCalcularPerimetro = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpObjetos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radMoneda = new System.Windows.Forms.RadioButton();
            this.radRueda = new System.Windows.Forms.RadioButton();
            this.grpObjetos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadio.Location = new System.Drawing.Point(62, 92);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(62, 25);
            this.lblRadio.TabIndex = 0;
            this.lblRadio.Text = "Radio\r\n";
            // 
            // txtRadio
            // 
            this.txtRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRadio.Location = new System.Drawing.Point(165, 89);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(189, 30);
            this.txtRadio.TabIndex = 1;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(408, 81);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(164, 46);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCalcularArea
            // 
            this.btnCalcularArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularArea.Location = new System.Drawing.Point(408, 133);
            this.btnCalcularArea.Name = "btnCalcularArea";
            this.btnCalcularArea.Size = new System.Drawing.Size(164, 46);
            this.btnCalcularArea.TabIndex = 3;
            this.btnCalcularArea.Text = "Calcular Area";
            this.btnCalcularArea.UseVisualStyleBackColor = true;
            this.btnCalcularArea.Click += new System.EventHandler(this.btnCalcularArea_Click);
            // 
            // btnCalcularPerimetro
            // 
            this.btnCalcularPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPerimetro.Location = new System.Drawing.Point(408, 183);
            this.btnCalcularPerimetro.Name = "btnCalcularPerimetro";
            this.btnCalcularPerimetro.Size = new System.Drawing.Size(164, 70);
            this.btnCalcularPerimetro.TabIndex = 4;
            this.btnCalcularPerimetro.Text = "Calcular Perimetro";
            this.btnCalcularPerimetro.UseVisualStyleBackColor = true;
            this.btnCalcularPerimetro.Click += new System.EventHandler(this.btnCalcularPerimetro_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(408, 258);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(164, 46);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grpObjetos
            // 
            this.grpObjetos.Controls.Add(this.label2);
            this.grpObjetos.Controls.Add(this.label1);
            this.grpObjetos.Controls.Add(this.radMoneda);
            this.grpObjetos.Controls.Add(this.radRueda);
            this.grpObjetos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpObjetos.Location = new System.Drawing.Point(67, 133);
            this.grpObjetos.Name = "grpObjetos";
            this.grpObjetos.Size = new System.Drawing.Size(302, 188);
            this.grpObjetos.TabIndex = 6;
            this.grpObjetos.TabStop = false;
            this.grpObjetos.Text = "Objetos";
            this.grpObjetos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Radio 10.2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Radio 1.4";
            // 
            // radMoneda
            // 
            this.radMoneda.AutoSize = true;
            this.radMoneda.Location = new System.Drawing.Point(7, 93);
            this.radMoneda.Name = "radMoneda";
            this.radMoneda.Size = new System.Drawing.Size(105, 29);
            this.radMoneda.TabIndex = 1;
            this.radMoneda.TabStop = true;
            this.radMoneda.Text = "Moneda";
            this.radMoneda.UseVisualStyleBackColor = true;
            this.radMoneda.CheckedChanged += new System.EventHandler(this.radMoneda_CheckedChanged);
            // 
            // radRueda
            // 
            this.radRueda.AutoSize = true;
            this.radRueda.Location = new System.Drawing.Point(7, 32);
            this.radRueda.Name = "radRueda";
            this.radRueda.Size = new System.Drawing.Size(90, 29);
            this.radRueda.TabIndex = 0;
            this.radRueda.TabStop = true;
            this.radRueda.Text = "Rueda";
            this.radRueda.UseVisualStyleBackColor = true;
            this.radRueda.CheckedChanged += new System.EventHandler(this.radRueda_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 367);
            this.Controls.Add(this.grpObjetos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcularPerimetro);
            this.Controls.Add(this.btnCalcularArea);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblRadio);
            this.Name = "Form1";
            this.Text = "Circunferencia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpObjetos.ResumeLayout(false);
            this.grpObjetos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCalcularArea;
        private System.Windows.Forms.Button btnCalcularPerimetro;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpObjetos;
        private System.Windows.Forms.RadioButton radMoneda;
        private System.Windows.Forms.RadioButton radRueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

