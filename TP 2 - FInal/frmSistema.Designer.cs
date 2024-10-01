namespace TP_2___FInal
{
    partial class frmSistema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tareas = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblCate = new System.Windows.Forms.Label();
            this.lblespecial = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnModificarTarea = new System.Windows.Forms.Button();
            this.btnBorrarTarea = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtDescDesa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.txtTareaValor = new System.Windows.Forms.TextBox();
            this.txtTareaNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Equipo = new System.Windows.Forms.GroupBox();
            this.btnModifEquipo = new System.Windows.Forms.Button();
            this.btnBorrarEquipo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewEquipos = new System.Windows.Forms.DataGridView();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnFinalizarProyec = new System.Windows.Forms.Button();
            this.btnModificarProyect = new System.Windows.Forms.Button();
            this.btnBorrarProyect = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridViewProyecto = new System.Windows.Forms.DataGridView();
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Tareas.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Equipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipos)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // Tareas
            // 
            this.Tareas.Controls.Add(this.groupBox6);
            this.Tareas.Controls.Add(this.btnModificarTarea);
            this.Tareas.Controls.Add(this.btnBorrarTarea);
            this.Tareas.Controls.Add(this.button1);
            this.Tareas.Controls.Add(this.dataGridView1);
            this.Tareas.Controls.Add(this.groupBox1);
            this.Tareas.Controls.Add(this.txtTareaValor);
            this.Tareas.Controls.Add(this.txtTareaNombre);
            this.Tareas.Controls.Add(this.label2);
            this.Tareas.Controls.Add(this.label1);
            this.Tareas.Location = new System.Drawing.Point(12, 181);
            this.Tareas.Name = "Tareas";
            this.Tareas.Size = new System.Drawing.Size(1062, 238);
            this.Tareas.TabIndex = 0;
            this.Tareas.TabStop = false;
            this.Tareas.Text = "Tareas";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblCate);
            this.groupBox6.Controls.Add(this.lblespecial);
            this.groupBox6.Controls.Add(this.label);
            this.groupBox6.Location = new System.Drawing.Point(421, 185);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(626, 47);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Descripcion:";
            // 
            // lblCate
            // 
            this.lblCate.AutoSize = true;
            this.lblCate.Location = new System.Drawing.Point(72, 22);
            this.lblCate.Name = "lblCate";
            this.lblCate.Size = new System.Drawing.Size(10, 13);
            this.lblCate.TabIndex = 12;
            this.lblCate.Text = "-";
            this.lblCate.Click += new System.EventHandler(this.lblCate_Click);
            // 
            // lblespecial
            // 
            this.lblespecial.AutoSize = true;
            this.lblespecial.Location = new System.Drawing.Point(279, 22);
            this.lblespecial.Name = "lblespecial";
            this.lblespecial.Size = new System.Drawing.Size(10, 13);
            this.lblespecial.TabIndex = 11;
            this.lblespecial.Text = "-";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(11, 22);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(55, 13);
            this.label.TabIndex = 10;
            this.label.Text = "Categoria:";
            // 
            // btnModificarTarea
            // 
            this.btnModificarTarea.Location = new System.Drawing.Point(68, 197);
            this.btnModificarTarea.Name = "btnModificarTarea";
            this.btnModificarTarea.Size = new System.Drawing.Size(75, 23);
            this.btnModificarTarea.TabIndex = 7;
            this.btnModificarTarea.Text = "Modificar";
            this.btnModificarTarea.UseVisualStyleBackColor = true;
            this.btnModificarTarea.Click += new System.EventHandler(this.btnModificarTarea_Click);
            // 
            // btnBorrarTarea
            // 
            this.btnBorrarTarea.Location = new System.Drawing.Point(226, 197);
            this.btnBorrarTarea.Name = "btnBorrarTarea";
            this.btnBorrarTarea.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarTarea.TabIndex = 8;
            this.btnBorrarTarea.Text = "Borrar";
            this.btnBorrarTarea.UseVisualStyleBackColor = true;
            this.btnBorrarTarea.Click += new System.EventHandler(this.btnBorrarTarea_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(420, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(627, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtDescDesa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboCategoria);
            this.groupBox1.Location = new System.Drawing.Point(174, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 157);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha de entrega:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 116);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // txtDescDesa
            // 
            this.txtDescDesa.Location = new System.Drawing.Point(6, 65);
            this.txtDescDesa.Name = "txtDescDesa";
            this.txtDescDesa.Size = new System.Drawing.Size(176, 20);
            this.txtDescDesa.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descripcion:";
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(6, 19);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboCategoria.TabIndex = 0;
            this.comboCategoria.SelectedIndexChanged += new System.EventHandler(this.comboCategoria_SelectedIndexChanged);
            // 
            // txtTareaValor
            // 
            this.txtTareaValor.Location = new System.Drawing.Point(64, 70);
            this.txtTareaValor.Name = "txtTareaValor";
            this.txtTareaValor.Size = new System.Drawing.Size(100, 20);
            this.txtTareaValor.TabIndex = 3;
            // 
            // txtTareaNombre
            // 
            this.txtTareaNombre.Location = new System.Drawing.Point(64, 42);
            this.txtTareaNombre.Name = "txtTareaNombre";
            this.txtTareaNombre.Size = new System.Drawing.Size(100, 20);
            this.txtTareaNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // Equipo
            // 
            this.Equipo.Controls.Add(this.btnModifEquipo);
            this.Equipo.Controls.Add(this.btnBorrarEquipo);
            this.Equipo.Controls.Add(this.button2);
            this.Equipo.Controls.Add(this.dataGridViewEquipos);
            this.Equipo.Controls.Add(this.txtNombreEquipo);
            this.Equipo.Controls.Add(this.label8);
            this.Equipo.Location = new System.Drawing.Point(12, 12);
            this.Equipo.Name = "Equipo";
            this.Equipo.Size = new System.Drawing.Size(530, 163);
            this.Equipo.TabIndex = 7;
            this.Equipo.TabStop = false;
            this.Equipo.Text = "Equipos";
            // 
            // btnModifEquipo
            // 
            this.btnModifEquipo.Location = new System.Drawing.Point(8, 103);
            this.btnModifEquipo.Name = "btnModifEquipo";
            this.btnModifEquipo.Size = new System.Drawing.Size(75, 23);
            this.btnModifEquipo.TabIndex = 11;
            this.btnModifEquipo.Text = "Modificar";
            this.btnModifEquipo.UseVisualStyleBackColor = true;
            this.btnModifEquipo.Click += new System.EventHandler(this.btnModifEquipo_Click);
            // 
            // btnBorrarEquipo
            // 
            this.btnBorrarEquipo.Location = new System.Drawing.Point(89, 55);
            this.btnBorrarEquipo.Name = "btnBorrarEquipo";
            this.btnBorrarEquipo.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarEquipo.TabIndex = 9;
            this.btnBorrarEquipo.Text = "Borrar";
            this.btnBorrarEquipo.UseVisualStyleBackColor = true;
            this.btnBorrarEquipo.Click += new System.EventHandler(this.btnBorrarEquipo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Crear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewEquipos
            // 
            this.dataGridViewEquipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipos.Location = new System.Drawing.Point(190, 19);
            this.dataGridViewEquipos.Name = "dataGridViewEquipos";
            this.dataGridViewEquipos.Size = new System.Drawing.Size(321, 126);
            this.dataGridViewEquipos.TabIndex = 5;
            this.dataGridViewEquipos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEquipos_CellContentClick);
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(68, 29);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEquipo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnFinalizarProyec);
            this.groupBox4.Controls.Add(this.btnModificarProyect);
            this.groupBox4.Controls.Add(this.btnBorrarProyect);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.dataGridViewProyecto);
            this.groupBox4.Controls.Add(this.txtNombreProyecto);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(548, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(526, 163);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Proyecto:";
            // 
            // btnFinalizarProyec
            // 
            this.btnFinalizarProyec.Location = new System.Drawing.Point(99, 103);
            this.btnFinalizarProyec.Name = "btnFinalizarProyec";
            this.btnFinalizarProyec.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizarProyec.TabIndex = 13;
            this.btnFinalizarProyec.Text = "Finalizar";
            this.btnFinalizarProyec.UseVisualStyleBackColor = true;
            this.btnFinalizarProyec.Click += new System.EventHandler(this.btnFinalizarProyec_Click);
            // 
            // btnModificarProyect
            // 
            this.btnModificarProyect.Location = new System.Drawing.Point(8, 103);
            this.btnModificarProyect.Name = "btnModificarProyect";
            this.btnModificarProyect.Size = new System.Drawing.Size(75, 23);
            this.btnModificarProyect.TabIndex = 11;
            this.btnModificarProyect.Text = "Modificar";
            this.btnModificarProyect.UseVisualStyleBackColor = true;
            this.btnModificarProyect.Click += new System.EventHandler(this.btnModificarProyect_Click);
            // 
            // btnBorrarProyect
            // 
            this.btnBorrarProyect.Location = new System.Drawing.Point(99, 55);
            this.btnBorrarProyect.Name = "btnBorrarProyect";
            this.btnBorrarProyect.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarProyect.TabIndex = 9;
            this.btnBorrarProyect.Text = "Borrar";
            this.btnBorrarProyect.UseVisualStyleBackColor = true;
            this.btnBorrarProyect.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(8, 55);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Crear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridViewProyecto
            // 
            this.dataGridViewProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProyecto.Location = new System.Drawing.Point(190, 26);
            this.dataGridViewProyecto.Name = "dataGridViewProyecto";
            this.dataGridViewProyecto.Size = new System.Drawing.Size(321, 126);
            this.dataGridViewProyecto.TabIndex = 5;
            this.dataGridViewProyecto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProyecto_CellContentClick);
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.Location = new System.Drawing.Point(69, 26);
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProyecto.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nombre:";
            // 
            // frmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1094, 444);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Equipo);
            this.Controls.Add(this.Tareas);
            this.Name = "frmSistema";
            this.Text = "Sistema";
            this.Load += new System.EventHandler(this.frmSistema_Load);
            this.Tareas.ResumeLayout(false);
            this.Tareas.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Equipo.ResumeLayout(false);
            this.Equipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProyecto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Tareas;
        private System.Windows.Forms.TextBox txtTareaNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTareaValor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtDescDesa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Equipo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewEquipos;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBorrarTarea;
        private System.Windows.Forms.Button btnModificarTarea;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnBorrarEquipo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBorrarProyect;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridViewProyecto;
        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCate;
        private System.Windows.Forms.Label lblespecial;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnModifEquipo;
        private System.Windows.Forms.Button btnFinalizarProyec;
        private System.Windows.Forms.Button btnModificarProyect;
    }
}