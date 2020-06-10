namespace Restaurante
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
            this.grbAlimentos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHS = new System.Windows.Forms.TextBox();
            this.txtHQ = new System.Windows.Forms.TextBox();
            this.txtHE = new System.Windows.Forms.TextBox();
            this.txtPapas = new System.Windows.Forms.TextBox();
            this.txtRefresco = new System.Windows.Forms.TextBox();
            this.txtPostres = new System.Windows.Forms.TextBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbMesas = new System.Windows.Forms.ComboBox();
            this.grbAlimentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAlimentos
            // 
            this.grbAlimentos.Controls.Add(this.txtPostres);
            this.grbAlimentos.Controls.Add(this.label6);
            this.grbAlimentos.Controls.Add(this.txtRefresco);
            this.grbAlimentos.Controls.Add(this.txtPapas);
            this.grbAlimentos.Controls.Add(this.label5);
            this.grbAlimentos.Controls.Add(this.txtHE);
            this.grbAlimentos.Controls.Add(this.label4);
            this.grbAlimentos.Controls.Add(this.txtHQ);
            this.grbAlimentos.Controls.Add(this.label3);
            this.grbAlimentos.Controls.Add(this.txtHS);
            this.grbAlimentos.Controls.Add(this.label2);
            this.grbAlimentos.Controls.Add(this.label1);
            this.grbAlimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAlimentos.Location = new System.Drawing.Point(12, 12);
            this.grbAlimentos.Name = "grbAlimentos";
            this.grbAlimentos.Size = new System.Drawing.Size(326, 304);
            this.grbAlimentos.TabIndex = 0;
            this.grbAlimentos.TabStop = false;
            this.grbAlimentos.Text = "Cantidad de Alimentos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hamburguesa Sencilla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hamburguesa c/ Queso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hamburguesas Especiales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Papas Fritas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Refrescos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Postres";
            // 
            // txtHS
            // 
            this.txtHS.Location = new System.Drawing.Point(242, 36);
            this.txtHS.Name = "txtHS";
            this.txtHS.Size = new System.Drawing.Size(55, 30);
            this.txtHS.TabIndex = 1;
            this.txtHS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHQ
            // 
            this.txtHQ.Location = new System.Drawing.Point(242, 76);
            this.txtHQ.Name = "txtHQ";
            this.txtHQ.Size = new System.Drawing.Size(44, 30);
            this.txtHQ.TabIndex = 2;
            this.txtHQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHE
            // 
            this.txtHE.Location = new System.Drawing.Point(269, 118);
            this.txtHE.Name = "txtHE";
            this.txtHE.Size = new System.Drawing.Size(41, 30);
            this.txtHE.TabIndex = 3;
            this.txtHE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPapas
            // 
            this.txtPapas.Location = new System.Drawing.Point(133, 158);
            this.txtPapas.Name = "txtPapas";
            this.txtPapas.Size = new System.Drawing.Size(42, 30);
            this.txtPapas.TabIndex = 4;
            this.txtPapas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRefresco
            // 
            this.txtRefresco.Location = new System.Drawing.Point(111, 199);
            this.txtRefresco.Name = "txtRefresco";
            this.txtRefresco.Size = new System.Drawing.Size(47, 30);
            this.txtRefresco.TabIndex = 5;
            this.txtRefresco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPostres
            // 
            this.txtPostres.Location = new System.Drawing.Point(90, 241);
            this.txtPostres.Name = "txtPostres";
            this.txtPostres.Size = new System.Drawing.Size(37, 30);
            this.txtPostres.TabIndex = 6;
            this.txtPostres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.Location = new System.Drawing.Point(394, 91);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(107, 64);
            this.btnCapturar.TabIndex = 1;
            this.btnCapturar.Text = "Tomar Orden";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(394, 161);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(107, 48);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Total";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(450, 366);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 49);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbMesas
            // 
            this.cmbMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMesas.FormattingEnabled = true;
            this.cmbMesas.Items.AddRange(new object[] {
            "Mesa 1",
            "Mesa 2",
            "Mesa 3",
            "Mesa 4",
            "Mesa 5"});
            this.cmbMesas.Location = new System.Drawing.Point(23, 351);
            this.cmbMesas.Name = "cmbMesas";
            this.cmbMesas.Size = new System.Drawing.Size(215, 33);
            this.cmbMesas.TabIndex = 4;
            this.cmbMesas.Text = "Seleccionar Mesa";
            this.cmbMesas.SelectedIndexChanged += new System.EventHandler(this.cmbMesas_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 427);
            this.Controls.Add(this.cmbMesas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.grbAlimentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbAlimentos.ResumeLayout(false);
            this.grbAlimentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAlimentos;
        private System.Windows.Forms.TextBox txtPostres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRefresco;
        private System.Windows.Forms.TextBox txtPapas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbMesas;
    }
}

