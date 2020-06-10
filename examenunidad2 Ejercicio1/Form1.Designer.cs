namespace examenunidad2_Ejercicio1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procesador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Audifonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.txtProcesador = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chbAudifonos = new System.Windows.Forms.CheckBox();
            this.chbCargador = new System.Windows.Forms.CheckBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de serie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tamaño de pantalla";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Modelo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Procesador";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dispositivos:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.NumeroModelo,
            this.NumeroSerie,
            this.Capacidad,
            this.Tamano,
            this.Modelo,
            this.Procesador,
            this.Audifonos,
            this.Cargador});
            this.dataGridView1.Location = new System.Drawing.Point(16, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1162, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // NumeroModelo
            // 
            this.NumeroModelo.HeaderText = "Numero de Modelo";
            this.NumeroModelo.MinimumWidth = 6;
            this.NumeroModelo.Name = "NumeroModelo";
            this.NumeroModelo.Width = 125;
            // 
            // NumeroSerie
            // 
            this.NumeroSerie.HeaderText = "Numero de Serie";
            this.NumeroSerie.MinimumWidth = 6;
            this.NumeroSerie.Name = "NumeroSerie";
            this.NumeroSerie.Width = 125;
            // 
            // Capacidad
            // 
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.MinimumWidth = 6;
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.Width = 125;
            // 
            // Tamano
            // 
            this.Tamano.HeaderText = "Tamaño de pantalla";
            this.Tamano.MinimumWidth = 6;
            this.Tamano.Name = "Tamano";
            this.Tamano.Width = 125;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            this.Modelo.Width = 125;
            // 
            // Procesador
            // 
            this.Procesador.HeaderText = "Procesador";
            this.Procesador.MinimumWidth = 6;
            this.Procesador.Name = "Procesador";
            this.Procesador.Width = 125;
            // 
            // Audifonos
            // 
            this.Audifonos.HeaderText = "Audifonos";
            this.Audifonos.MinimumWidth = 6;
            this.Audifonos.Name = "Audifonos";
            this.Audifonos.Width = 125;
            // 
            // Cargador
            // 
            this.Cargador.HeaderText = "Cargador";
            this.Cargador.MinimumWidth = 6;
            this.Cargador.Name = "Cargador";
            this.Cargador.Width = 125;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(147, 62);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 22);
            this.txtModelo.TabIndex = 10;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(133, 98);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 22);
            this.txtSerie.TabIndex = 11;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(95, 140);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(100, 22);
            this.txtCapacidad.TabIndex = 12;
            // 
            // txtPantalla
            // 
            this.txtPantalla.Location = new System.Drawing.Point(154, 179);
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.Size = new System.Drawing.Size(100, 22);
            this.txtPantalla.TabIndex = 13;
            // 
            // txtProcesador
            // 
            this.txtProcesador.Location = new System.Drawing.Point(447, 22);
            this.txtProcesador.Name = "txtProcesador";
            this.txtProcesador.Size = new System.Drawing.Size(100, 22);
            this.txtProcesador.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 16;
            // 
            // chbAudifonos
            // 
            this.chbAudifonos.AutoSize = true;
            this.chbAudifonos.Location = new System.Drawing.Point(362, 98);
            this.chbAudifonos.Name = "chbAudifonos";
            this.chbAudifonos.Size = new System.Drawing.Size(93, 21);
            this.chbAudifonos.TabIndex = 17;
            this.chbAudifonos.Text = "Audifonos";
            this.chbAudifonos.UseVisualStyleBackColor = true;
            // 
            // chbCargador
            // 
            this.chbCargador.AutoSize = true;
            this.chbCargador.Location = new System.Drawing.Point(476, 98);
            this.chbCargador.Name = "chbCargador";
            this.chbCargador.Size = new System.Drawing.Size(89, 21);
            this.chbCargador.TabIndex = 18;
            this.chbCargador.Text = "Cargador";
            this.chbCargador.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(355, 165);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(192, 45);
            this.btnInsertar.TabIndex = 19;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 519);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.chbCargador);
            this.Controls.Add(this.chbAudifonos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtProcesador);
            this.Controls.Add(this.txtPantalla);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procesador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Audifonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargador;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.TextBox txtProcesador;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chbAudifonos;
        private System.Windows.Forms.CheckBox chbCargador;
        private System.Windows.Forms.Button btnInsertar;
    }
}

