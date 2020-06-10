namespace _4._1
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.radRectangulo = new System.Windows.Forms.RadioButton();
            this.radCircunferencia = new System.Windows.Forms.RadioButton();
            this.radTriangulo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.grbFigura = new System.Windows.Forms.GroupBox();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.grbFigura.SuspendLayout();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(398, 167);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(171, 58);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular Area";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(420, 268);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 43);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // radRectangulo
            // 
            this.radRectangulo.AutoSize = true;
            this.radRectangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRectangulo.Location = new System.Drawing.Point(14, 41);
            this.radRectangulo.Name = "radRectangulo";
            this.radRectangulo.Size = new System.Drawing.Size(131, 29);
            this.radRectangulo.TabIndex = 0;
            this.radRectangulo.TabStop = true;
            this.radRectangulo.Text = "Rectangulo";
            this.radRectangulo.UseVisualStyleBackColor = true;
            this.radRectangulo.CheckedChanged += new System.EventHandler(this.radRectangulo_CheckedChanged);
            // 
            // radCircunferencia
            // 
            this.radCircunferencia.AutoSize = true;
            this.radCircunferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCircunferencia.Location = new System.Drawing.Point(14, 76);
            this.radCircunferencia.Name = "radCircunferencia";
            this.radCircunferencia.Size = new System.Drawing.Size(159, 29);
            this.radCircunferencia.TabIndex = 1;
            this.radCircunferencia.TabStop = true;
            this.radCircunferencia.Text = "Circunferencia";
            this.radCircunferencia.UseVisualStyleBackColor = true;
            this.radCircunferencia.CheckedChanged += new System.EventHandler(this.radCircunferencia_CheckedChanged);
            // 
            // radTriangulo
            // 
            this.radTriangulo.AutoSize = true;
            this.radTriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTriangulo.Location = new System.Drawing.Point(14, 108);
            this.radTriangulo.Name = "radTriangulo";
            this.radTriangulo.Size = new System.Drawing.Size(115, 29);
            this.radTriangulo.TabIndex = 2;
            this.radTriangulo.TabStop = true;
            this.radTriangulo.Text = "Triangulo";
            this.radTriangulo.UseVisualStyleBackColor = true;
            this.radTriangulo.CheckedChanged += new System.EventHandler(this.radTriangulo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Largo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ancho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Radio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Altura";
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(84, 40);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(72, 30);
            this.txtLargo.TabIndex = 4;
            this.txtLargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(90, 82);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(66, 30);
            this.txtAncho.TabIndex = 5;
            this.txtAncho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(90, 131);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(66, 30);
            this.txtRadio.TabIndex = 6;
            this.txtRadio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(84, 179);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(72, 30);
            this.txtAltura.TabIndex = 7;
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbFigura
            // 
            this.grbFigura.Controls.Add(this.radRectangulo);
            this.grbFigura.Controls.Add(this.radCircunferencia);
            this.grbFigura.Controls.Add(this.radTriangulo);
            this.grbFigura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFigura.Location = new System.Drawing.Point(41, 43);
            this.grbFigura.Name = "grbFigura";
            this.grbFigura.Size = new System.Drawing.Size(200, 161);
            this.grbFigura.TabIndex = 8;
            this.grbFigura.TabStop = false;
            this.grbFigura.Text = "Tipo de Figura";
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.label1);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Controls.Add(this.txtAltura);
            this.grbDatos.Controls.Add(this.label3);
            this.grbDatos.Controls.Add(this.label4);
            this.grbDatos.Controls.Add(this.txtRadio);
            this.grbDatos.Controls.Add(this.txtLargo);
            this.grbDatos.Controls.Add(this.txtAncho);
            this.grbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatos.Location = new System.Drawing.Point(41, 210);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(200, 221);
            this.grbDatos.TabIndex = 9;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos de la figura";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 443);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.grbFigura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbFigura.ResumeLayout(false);
            this.grbFigura.PerformLayout();
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radTriangulo;
        private System.Windows.Forms.RadioButton radCircunferencia;
        private System.Windows.Forms.RadioButton radRectangulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.GroupBox grbFigura;
        private System.Windows.Forms.GroupBox grbDatos;
    }
}

