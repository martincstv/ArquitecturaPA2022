namespace Presentacion
{
    partial class Form_PersonalVacunado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Nuevo = new System.Windows.Forms.Button();
            this.comboBox_Genero = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Direccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.textBox_NumeroDosis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Cedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_SumatoriaNumeroDosis = new System.Windows.Forms.TextBox();
            this.dataGridView_ListaPersonasVacunadas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaPersonasVacunadas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_Nuevo);
            this.groupBox1.Controls.Add(this.comboBox_Genero);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox_Direccion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTimePicker_FechaNacimiento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button_Eliminar);
            this.groupBox1.Controls.Add(this.button_Guardar);
            this.groupBox1.Controls.Add(this.textBox_NumeroDosis);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_Telefono);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_Cedula);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_Apellido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Nombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 549);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERSONA VACUNADA";
            // 
            // button_Nuevo
            // 
            this.button_Nuevo.Location = new System.Drawing.Point(37, 489);
            this.button_Nuevo.Name = "button_Nuevo";
            this.button_Nuevo.Size = new System.Drawing.Size(100, 23);
            this.button_Nuevo.TabIndex = 10;
            this.button_Nuevo.Text = "Nuevo";
            this.button_Nuevo.UseVisualStyleBackColor = true;
            this.button_Nuevo.Click += new System.EventHandler(this.button_Nuevo_Click);
            // 
            // comboBox_Genero
            // 
            this.comboBox_Genero.FormattingEnabled = true;
            this.comboBox_Genero.Location = new System.Drawing.Point(37, 254);
            this.comboBox_Genero.Name = "comboBox_Genero";
            this.comboBox_Genero.Size = new System.Drawing.Size(225, 24);
            this.comboBox_Genero.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "GENERO";
            // 
            // textBox_Direccion
            // 
            this.textBox_Direccion.Location = new System.Drawing.Point(37, 432);
            this.textBox_Direccion.Multiline = true;
            this.textBox_Direccion.Name = "textBox_Direccion";
            this.textBox_Direccion.Size = new System.Drawing.Size(225, 51);
            this.textBox_Direccion.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "DIRECCIÓN";
            // 
            // dateTimePicker_FechaNacimiento
            // 
            this.dateTimePicker_FechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_FechaNacimiento.Location = new System.Drawing.Point(37, 388);
            this.dateTimePicker_FechaNacimiento.Name = "dateTimePicker_FechaNacimiento";
            this.dateTimePicker_FechaNacimiento.Size = new System.Drawing.Size(225, 24);
            this.dateTimePicker_FechaNacimiento.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "FECHA NACIMIENTO";
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Location = new System.Drawing.Point(37, 517);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(100, 23);
            this.button_Eliminar.TabIndex = 9;
            this.button_Eliminar.Text = "Eliminar";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(162, 517);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(100, 23);
            this.button_Guardar.TabIndex = 8;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // textBox_NumeroDosis
            // 
            this.textBox_NumeroDosis.Location = new System.Drawing.Point(37, 344);
            this.textBox_NumeroDosis.MaxLength = 1;
            this.textBox_NumeroDosis.Name = "textBox_NumeroDosis";
            this.textBox_NumeroDosis.Size = new System.Drawing.Size(225, 22);
            this.textBox_NumeroDosis.TabIndex = 5;
            this.textBox_NumeroDosis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NumeroDosis_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "NUMERO DOSIS";
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Location = new System.Drawing.Point(37, 300);
            this.textBox_Telefono.MaxLength = 10;
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.Size = new System.Drawing.Size(225, 22);
            this.textBox_Telefono.TabIndex = 4;
            this.textBox_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Telefono_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "TELEFONO";
            // 
            // textBox_Cedula
            // 
            this.textBox_Cedula.Location = new System.Drawing.Point(37, 210);
            this.textBox_Cedula.MaxLength = 10;
            this.textBox_Cedula.Name = "textBox_Cedula";
            this.textBox_Cedula.Size = new System.Drawing.Size(225, 22);
            this.textBox_Cedula.TabIndex = 2;
            this.textBox_Cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Cedula_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "CEDULA";
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(37, 166);
            this.textBox_Apellido.MaxLength = 50;
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(225, 22);
            this.textBox_Apellido.TabIndex = 1;
            this.textBox_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Apellido_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "APELLIDO";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nombre.Location = new System.Drawing.Point(37, 122);
            this.textBox_Nombre.MaxLength = 50;
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(225, 22);
            this.textBox_Nombre.TabIndex = 0;
            this.textBox_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(37, 78);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(225, 22);
            this.textBox_Id.TabIndex = 3;
            this.textBox_Id.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox_SumatoriaNumeroDosis);
            this.groupBox2.Controls.Add(this.dataGridView_ListaPersonasVacunadas);
            this.groupBox2.Location = new System.Drawing.Point(318, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(892, 549);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTA PERSONAS VACUNADAS";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(571, 524);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "SUMATORIA NUMERO DOSIS";
            // 
            // textBox_SumatoriaNumeroDosis
            // 
            this.textBox_SumatoriaNumeroDosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SumatoriaNumeroDosis.Location = new System.Drawing.Point(786, 521);
            this.textBox_SumatoriaNumeroDosis.Name = "textBox_SumatoriaNumeroDosis";
            this.textBox_SumatoriaNumeroDosis.ReadOnly = true;
            this.textBox_SumatoriaNumeroDosis.Size = new System.Drawing.Size(100, 22);
            this.textBox_SumatoriaNumeroDosis.TabIndex = 1;
            // 
            // dataGridView_ListaPersonasVacunadas
            // 
            this.dataGridView_ListaPersonasVacunadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ListaPersonasVacunadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ListaPersonasVacunadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListaPersonasVacunadas.Location = new System.Drawing.Point(6, 21);
            this.dataGridView_ListaPersonasVacunadas.Name = "dataGridView_ListaPersonasVacunadas";
            this.dataGridView_ListaPersonasVacunadas.RowHeadersWidth = 51;
            this.dataGridView_ListaPersonasVacunadas.RowTemplate.Height = 24;
            this.dataGridView_ListaPersonasVacunadas.Size = new System.Drawing.Size(880, 494);
            this.dataGridView_ListaPersonasVacunadas.TabIndex = 1;
            this.dataGridView_ListaPersonasVacunadas.TabStop = false;
            this.dataGridView_ListaPersonasVacunadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ListaPersonasVacunadas_CellClick);
            // 
            // Form_PersonalVacunado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 573);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_PersonalVacunado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Vacunado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_PersonalVacunado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaPersonasVacunadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.TextBox textBox_NumeroDosis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Telefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Cedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_ListaPersonasVacunadas;
        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Direccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaNacimiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_SumatoriaNumeroDosis;
        private System.Windows.Forms.ComboBox comboBox_Genero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_Nuevo;
    }
}

