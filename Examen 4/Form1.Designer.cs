namespace Examen_4
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
            this.btnRey = new System.Windows.Forms.Button();
            this.btnReina = new System.Windows.Forms.Button();
            this.btnAlfil = new System.Windows.Forms.Button();
            this.btnCaballo = new System.Windows.Forms.Button();
            this.btnTorre = new System.Windows.Forms.Button();
            this.btnPeon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRey
            // 
            this.btnRey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRey.Location = new System.Drawing.Point(41, 77);
            this.btnRey.Name = "btnRey";
            this.btnRey.Size = new System.Drawing.Size(115, 52);
            this.btnRey.TabIndex = 0;
            this.btnRey.Text = "Rey";
            this.btnRey.UseVisualStyleBackColor = true;
            this.btnRey.Click += new System.EventHandler(this.btnRey_Click);
            // 
            // btnReina
            // 
            this.btnReina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReina.Location = new System.Drawing.Point(162, 77);
            this.btnReina.Name = "btnReina";
            this.btnReina.Size = new System.Drawing.Size(115, 52);
            this.btnReina.TabIndex = 1;
            this.btnReina.Text = "Reina";
            this.btnReina.UseVisualStyleBackColor = true;
            this.btnReina.Click += new System.EventHandler(this.btnReina_Click);
            // 
            // btnAlfil
            // 
            this.btnAlfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlfil.Location = new System.Drawing.Point(283, 77);
            this.btnAlfil.Name = "btnAlfil";
            this.btnAlfil.Size = new System.Drawing.Size(115, 52);
            this.btnAlfil.TabIndex = 2;
            this.btnAlfil.Text = "Alfil";
            this.btnAlfil.UseVisualStyleBackColor = true;
            this.btnAlfil.Click += new System.EventHandler(this.btnAlfil_Click);
            // 
            // btnCaballo
            // 
            this.btnCaballo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaballo.Location = new System.Drawing.Point(404, 77);
            this.btnCaballo.Name = "btnCaballo";
            this.btnCaballo.Size = new System.Drawing.Size(115, 52);
            this.btnCaballo.TabIndex = 3;
            this.btnCaballo.Text = "Caballo";
            this.btnCaballo.UseVisualStyleBackColor = true;
            this.btnCaballo.Click += new System.EventHandler(this.btnCaballo_Click);
            // 
            // btnTorre
            // 
            this.btnTorre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTorre.Location = new System.Drawing.Point(525, 77);
            this.btnTorre.Name = "btnTorre";
            this.btnTorre.Size = new System.Drawing.Size(115, 52);
            this.btnTorre.TabIndex = 4;
            this.btnTorre.Text = "Torre";
            this.btnTorre.UseVisualStyleBackColor = true;
            this.btnTorre.Click += new System.EventHandler(this.btnTorre_Click);
            // 
            // btnPeon
            // 
            this.btnPeon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeon.Location = new System.Drawing.Point(646, 77);
            this.btnPeon.Name = "btnPeon";
            this.btnPeon.Size = new System.Drawing.Size(115, 52);
            this.btnPeon.TabIndex = 5;
            this.btnPeon.Text = "Peon";
            this.btnPeon.UseVisualStyleBackColor = true;
            this.btnPeon.Click += new System.EventHandler(this.btnPeon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione la pieza para conocer su movimiento";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(356, 164);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 214);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPeon);
            this.Controls.Add(this.btnTorre);
            this.Controls.Add(this.btnCaballo);
            this.Controls.Add(this.btnAlfil);
            this.Controls.Add(this.btnReina);
            this.Controls.Add(this.btnRey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRey;
        private System.Windows.Forms.Button btnReina;
        private System.Windows.Forms.Button btnAlfil;
        private System.Windows.Forms.Button btnCaballo;
        private System.Windows.Forms.Button btnTorre;
        private System.Windows.Forms.Button btnPeon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
    }
}

