namespace grados
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
            this.grpGrados = new System.Windows.Forms.GroupBox();
            this.radFah = new System.Windows.Forms.RadioButton();
            this.radCentigrados = new System.Windows.Forms.RadioButton();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.grpGrados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGrados
            // 
            this.grpGrados.Controls.Add(this.radFah);
            this.grpGrados.Controls.Add(this.radCentigrados);
            this.grpGrados.Location = new System.Drawing.Point(12, 126);
            this.grpGrados.Name = "grpGrados";
            this.grpGrados.Size = new System.Drawing.Size(200, 100);
            this.grpGrados.TabIndex = 0;
            this.grpGrados.TabStop = false;
            this.grpGrados.Text = "Grados";
            // 
            // radFah
            // 
            this.radFah.AutoSize = true;
            this.radFah.Location = new System.Drawing.Point(6, 56);
            this.radFah.Name = "radFah";
            this.radFah.Size = new System.Drawing.Size(89, 21);
            this.radFah.TabIndex = 1;
            this.radFah.TabStop = true;
            this.radFah.Text = "Farenheit";
            this.radFah.UseVisualStyleBackColor = true;
            // 
            // radCentigrados
            // 
            this.radCentigrados.AutoSize = true;
            this.radCentigrados.Location = new System.Drawing.Point(6, 29);
            this.radCentigrados.Name = "radCentigrados";
            this.radCentigrados.Size = new System.Drawing.Size(105, 21);
            this.radCentigrados.TabIndex = 0;
            this.radCentigrados.TabStop = true;
            this.radCentigrados.Text = "Centigrados";
            this.radCentigrados.UseVisualStyleBackColor = true;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(218, 126);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(151, 41);
            this.btnConvertir.TabIndex = 1;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(218, 182);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(151, 41);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese la cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(155, 57);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 322);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.grpGrados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpGrados.ResumeLayout(false);
            this.grpGrados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGrados;
        private System.Windows.Forms.RadioButton radFah;
        private System.Windows.Forms.RadioButton radCentigrados;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}

