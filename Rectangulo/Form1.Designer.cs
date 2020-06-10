namespace Rectangulo
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
            this.btnCalcularArea = new System.Windows.Forms.Button();
            this.btnModLar = new System.Windows.Forms.Button();
            this.btnModAnc = new System.Windows.Forms.Button();
            this.btnConsLar = new System.Windows.Forms.Button();
            this.btnConsAnc = new System.Windows.Forms.Button();
            this.lblAncho = new System.Windows.Forms.Label();
            this.lblLargo = new System.Windows.Forms.Label();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcularArea
            // 
            this.btnCalcularArea.Location = new System.Drawing.Point(231, 52);
            this.btnCalcularArea.Name = "btnCalcularArea";
            this.btnCalcularArea.Size = new System.Drawing.Size(138, 23);
            this.btnCalcularArea.TabIndex = 0;
            this.btnCalcularArea.Text = "Calcular Area";
            this.btnCalcularArea.UseVisualStyleBackColor = true;
            this.btnCalcularArea.Click += new System.EventHandler(this.btnCalcularArea_Click);
            // 
            // btnModLar
            // 
            this.btnModLar.Location = new System.Drawing.Point(231, 110);
            this.btnModLar.Name = "btnModLar";
            this.btnModLar.Size = new System.Drawing.Size(138, 37);
            this.btnModLar.TabIndex = 1;
            this.btnModLar.Text = "Modificar Largo";
            this.btnModLar.UseVisualStyleBackColor = true;
            this.btnModLar.Click += new System.EventHandler(this.btnModLar_Click);
            // 
            // btnModAnc
            // 
            this.btnModAnc.Location = new System.Drawing.Point(231, 81);
            this.btnModAnc.Name = "btnModAnc";
            this.btnModAnc.Size = new System.Drawing.Size(138, 23);
            this.btnModAnc.TabIndex = 2;
            this.btnModAnc.Text = "Modificar Ancho";
            this.btnModAnc.UseVisualStyleBackColor = true;
            this.btnModAnc.Click += new System.EventHandler(this.btnModAnc_Click);
            // 
            // btnConsLar
            // 
            this.btnConsLar.Location = new System.Drawing.Point(231, 182);
            this.btnConsLar.Name = "btnConsLar";
            this.btnConsLar.Size = new System.Drawing.Size(138, 36);
            this.btnConsLar.TabIndex = 3;
            this.btnConsLar.Text = "Consultar Largo";
            this.btnConsLar.UseVisualStyleBackColor = true;
            this.btnConsLar.Click += new System.EventHandler(this.btnConsLar_Click);
            // 
            // btnConsAnc
            // 
            this.btnConsAnc.Location = new System.Drawing.Point(231, 153);
            this.btnConsAnc.Name = "btnConsAnc";
            this.btnConsAnc.Size = new System.Drawing.Size(138, 23);
            this.btnConsAnc.TabIndex = 4;
            this.btnConsAnc.Text = "Consultar Ancho";
            this.btnConsAnc.UseVisualStyleBackColor = true;
            this.btnConsAnc.Click += new System.EventHandler(this.btnConsAnc_Click);
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(25, 55);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(48, 17);
            this.lblAncho.TabIndex = 5;
            this.lblAncho.Text = "Ancho";
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Location = new System.Drawing.Point(24, 87);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(45, 17);
            this.lblLargo.TabIndex = 6;
            this.lblLargo.Text = "Largo";
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(76, 84);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(100, 22);
            this.txtLargo.TabIndex = 7;
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(76, 52);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(100, 22);
            this.txtAncho.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 250);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.txtLargo);
            this.Controls.Add(this.lblLargo);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.btnConsAnc);
            this.Controls.Add(this.btnConsLar);
            this.Controls.Add(this.btnModAnc);
            this.Controls.Add(this.btnModLar);
            this.Controls.Add(this.btnCalcularArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularArea;
        private System.Windows.Forms.Button btnModLar;
        private System.Windows.Forms.Button btnModAnc;
        private System.Windows.Forms.Button btnConsLar;
        private System.Windows.Forms.Button btnConsAnc;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.Label lblLargo;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.TextBox txtAncho;
    }
}

