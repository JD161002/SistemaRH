namespace SistemaRH
{
    partial class formAsistencia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label1 = new Label();
            dtpHoraSalida = new DateTimePicker();
            dtpHoraIngreso = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            Fecha = new Label();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            btnMostrar = new Button();
            pictureBox1 = new PictureBox();
            forEntrevista = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DarkGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 139);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(447, 178);
            dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Location = new Point(137, 107);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 23);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Value = new DateTime(2023, 10, 25, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpHoraSalida);
            groupBox1.Controls.Add(dtpHoraIngreso);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Fecha);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(27, 333);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 225);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Asistencia";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(137, 72);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(146, 23);
            txtApellido.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(137, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(146, 23);
            txtNombre.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(16, 76);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 8;
            label4.Text = "Apellido Trabajador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(16, 41);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 7;
            label1.Text = "ID Trabajador";
            // 
            // dtpHoraSalida
            // 
            dtpHoraSalida.CustomFormat = "";
            dtpHoraSalida.Format = DateTimePickerFormat.Time;
            dtpHoraSalida.Location = new Point(137, 180);
            dtpHoraSalida.Name = "dtpHoraSalida";
            dtpHoraSalida.Size = new Size(80, 23);
            dtpHoraSalida.TabIndex = 6;
            // 
            // dtpHoraIngreso
            // 
            dtpHoraIngreso.CustomFormat = "";
            dtpHoraIngreso.Format = DateTimePickerFormat.Time;
            dtpHoraIngreso.Location = new Point(137, 141);
            dtpHoraIngreso.Name = "dtpHoraIngreso";
            dtpHoraIngreso.Size = new Size(80, 23);
            dtpHoraIngreso.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(16, 180);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Hora Salida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(16, 141);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 3;
            label2.Text = "Hora Ingreso";
            // 
            // Fecha
            // 
            Fecha.AutoSize = true;
            Fecha.ForeColor = SystemColors.ButtonFace;
            Fecha.Location = new Point(16, 107);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(38, 15);
            Fecha.TabIndex = 2;
            Fecha.Text = "Fecha";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(589, 426);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Registrar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(578, 259);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(111, 37);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(589, 495);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 33);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(570, 154);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(119, 39);
            btnMostrar.TabIndex = 6;
            btnMostrar.Text = "Mostrar Asistencias";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(152, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(428, 113);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // forEntrevista
            // 
            forEntrevista.Location = new Point(589, 371);
            forEntrevista.Name = "forEntrevista";
            forEntrevista.Size = new Size(100, 27);
            forEntrevista.TabIndex = 9;
            forEntrevista.Text = "Modificar";
            forEntrevista.UseVisualStyleBackColor = true;
            forEntrevista.Click += forEntrevista_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(746, 570);
            Controls.Add(forEntrevista);
            Controls.Add(pictureBox1);
            Controls.Add(btnMostrar);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Asistencias";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label Fecha;
        private DateTimePicker dtpHoraSalida;
        private DateTimePicker dtpHoraIngreso;
        private Button btnAgregar;
        private Button btnEliminar;
        private Label label4;
        private Label label1;
        private Button btnSalir;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnMostrar;
        private PictureBox pictureBox1;
        private Button forEntrevista;
    }
}