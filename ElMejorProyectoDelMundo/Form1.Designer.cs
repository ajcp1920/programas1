namespace ElMejorProyectoDelMundo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgListaEmpleados = new System.Windows.Forms.DataGridView();
            this.gbEmpleados = new System.Windows.Forms.GroupBox();
            this.btnText = new System.Windows.Forms.Button();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.radID = new System.Windows.Forms.RadioButton();
            this.radNombre = new System.Windows.Forms.RadioButton();
            this.radPuesto = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaEmpleados)).BeginInit();
            this.gbEmpleados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgListaEmpleados
            // 
            this.dgListaEmpleados.AllowUserToAddRows = false;
            this.dgListaEmpleados.BackgroundColor = System.Drawing.Color.White;
            this.dgListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgListaEmpleados.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgListaEmpleados.Location = new System.Drawing.Point(13, 317);
            this.dgListaEmpleados.Name = "dgListaEmpleados";
            this.dgListaEmpleados.RowHeadersVisible = false;
            this.dgListaEmpleados.RowHeadersWidth = 51;
            this.dgListaEmpleados.RowTemplate.Height = 24;
            this.dgListaEmpleados.Size = new System.Drawing.Size(680, 220);
            this.dgListaEmpleados.TabIndex = 14;
            this.dgListaEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventoClick);
            // 
            // gbEmpleados
            // 
            this.gbEmpleados.BackColor = System.Drawing.Color.Black;
            this.gbEmpleados.Controls.Add(this.btnText);
            this.gbEmpleados.Controls.Add(this.txtPuesto);
            this.gbEmpleados.Controls.Add(this.txtID);
            this.gbEmpleados.Controls.Add(this.label5);
            this.gbEmpleados.Controls.Add(this.btnModificar);
            this.gbEmpleados.Controls.Add(this.btnEliminar);
            this.gbEmpleados.Controls.Add(this.btnAgregar);
            this.gbEmpleados.Controls.Add(this.txtSueldo);
            this.gbEmpleados.Controls.Add(this.txtTelefono);
            this.gbEmpleados.Controls.Add(this.txtNombreEmpleado);
            this.gbEmpleados.Controls.Add(this.label4);
            this.gbEmpleados.Controls.Add(this.label3);
            this.gbEmpleados.Controls.Add(this.label2);
            this.gbEmpleados.Controls.Add(this.label1);
            this.gbEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmpleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbEmpleados.Location = new System.Drawing.Point(12, 67);
            this.gbEmpleados.Name = "gbEmpleados";
            this.gbEmpleados.Size = new System.Drawing.Size(921, 244);
            this.gbEmpleados.TabIndex = 2;
            this.gbEmpleados.TabStop = false;
            this.gbEmpleados.Text = "Datos de los Empleados";
            this.gbEmpleados.Enter += new System.EventHandler(this.gbEmpleados_Enter);
            // 
            // btnText
            // 
            this.btnText.BackColor = System.Drawing.Color.White;
            this.btnText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnText.Location = new System.Drawing.Point(639, 153);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(157, 67);
            this.btnText.TabIndex = 9;
            this.btnText.Text = "Borrar Campos";
            this.btnText.UseVisualStyleBackColor = false;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // txtPuesto
            // 
            this.txtPuesto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPuesto.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPuesto.Location = new System.Drawing.Point(90, 113);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(175, 30);
            this.txtPuesto.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtID.Location = new System.Drawing.Point(57, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(48, 30);
            this.txtID.TabIndex = 1;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(7, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificar.Location = new System.Drawing.Point(639, 70);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(157, 35);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(639, 111);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 35);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(639, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(157, 35);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtSueldo
            // 
            this.txtSueldo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSueldo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSueldo.Location = new System.Drawing.Point(214, 192);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 30);
            this.txtSueldo.TabIndex = 5;
            this.txtSueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.Location = new System.Drawing.Point(101, 149);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(214, 30);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombreEmpleado.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(90, 77);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(295, 30);
            this.txtNombreEmpleado.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(7, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sueldo p/ semana  $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puesto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(240, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(424, 55);
            this.label6.TabIndex = 4;
            this.label6.Text = "Taqueria \"Antigua\"";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.White;
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrdenar.Location = new System.Drawing.Point(40, 138);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(135, 35);
            this.btnOrdenar.TabIndex = 13;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click_1);
            // 
            // radID
            // 
            this.radID.AutoSize = true;
            this.radID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radID.Location = new System.Drawing.Point(6, 29);
            this.radID.Name = "radID";
            this.radID.Size = new System.Drawing.Size(52, 29);
            this.radID.TabIndex = 10;
            this.radID.TabStop = true;
            this.radID.Text = "ID";
            this.radID.UseVisualStyleBackColor = true;
            // 
            // radNombre
            // 
            this.radNombre.AutoSize = true;
            this.radNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radNombre.Location = new System.Drawing.Point(6, 66);
            this.radNombre.Name = "radNombre";
            this.radNombre.Size = new System.Drawing.Size(102, 29);
            this.radNombre.TabIndex = 11;
            this.radNombre.TabStop = true;
            this.radNombre.Text = "Nombre";
            this.radNombre.UseVisualStyleBackColor = true;
            // 
            // radPuesto
            // 
            this.radPuesto.AutoSize = true;
            this.radPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPuesto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radPuesto.Location = new System.Drawing.Point(6, 103);
            this.radPuesto.Name = "radPuesto";
            this.radPuesto.Size = new System.Drawing.Size(94, 29);
            this.radPuesto.TabIndex = 12;
            this.radPuesto.TabStop = true;
            this.radPuesto.Text = "Puesto";
            this.radPuesto.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.radPuesto);
            this.groupBox1.Controls.Add(this.btnOrdenar);
            this.groupBox1.Controls.Add(this.radID);
            this.groupBox1.Controls.Add(this.radNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(699, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 219);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenar por:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(40, 178);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 35);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(945, 617);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgListaEmpleados);
            this.Controls.Add(this.gbEmpleados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tacos \"Antigua\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaEmpleados)).EndInit();
            this.gbEmpleados.ResumeLayout(false);
            this.gbEmpleados.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListaEmpleados;
        private System.Windows.Forms.GroupBox gbEmpleados;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.RadioButton radID;
        private System.Windows.Forms.RadioButton radNombre;
        private System.Windows.Forms.RadioButton radPuesto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}

