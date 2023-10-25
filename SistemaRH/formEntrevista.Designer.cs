namespace SistemaRH
{
    partial class formEntrevista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEntrevista));
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            txtOferta = new TextBox();
            txtCandidato = new TextBox();
            txtEntrevistador = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            checkBox1 = new CheckBox();
            btnAgregar = new Button();
            btnDeshabilitar = new Button();
            btnMostrar = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(0, 64, 0);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(527, 199);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtOferta);
            groupBox1.Controls.Add(txtCandidato);
            groupBox1.Controls.Add(txtEntrevistador);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(17, 365);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(527, 184);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Entrevista";
            // 
            // txtOferta
            // 
            txtOferta.Location = new Point(99, 145);
            txtOferta.Name = "txtOferta";
            txtOferta.Size = new Size(180, 23);
            txtOferta.TabIndex = 10;
            // 
            // txtCandidato
            // 
            txtCandidato.Location = new Point(99, 111);
            txtCandidato.Name = "txtCandidato";
            txtCandidato.Size = new Size(180, 23);
            txtCandidato.TabIndex = 9;
            // 
            // txtEntrevistador
            // 
            txtEntrevistador.Location = new Point(99, 73);
            txtEntrevistador.Name = "txtEntrevistador";
            txtEntrevistador.Size = new Size(180, 23);
            txtEntrevistador.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(17, 148);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 7;
            label6.Text = "Oferta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(17, 109);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 5;
            label4.Text = "Candidato";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(17, 73);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 4;
            label3.Text = "Entrevistador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(17, 37);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(87, 33);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.ButtonFace;
            checkBox1.Location = new Point(359, 33);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(115, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Estado Entrevista";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(628, 433);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(96, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(628, 226);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(96, 35);
            btnDeshabilitar.TabIndex = 3;
            btnDeshabilitar.Text = "Deshabilitar";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            btnDeshabilitar.Click += btnDeshabilitar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(628, 174);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(96, 31);
            btnMostrar.TabIndex = 4;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(628, 501);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(96, 32);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(131, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(430, 115);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(628, 387);
            button1.Name = "button1";
            button1.Size = new Size(96, 30);
            button1.TabIndex = 7;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Location = new Point(628, 280);
            button2.Name = "button2";
            button2.Size = new Size(93, 30);
            button2.TabIndex = 8;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // formEntrevista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(771, 561);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnMostrar);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnAgregar);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "formEntrevista";
            Text = "Entrevista";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private CheckBox checkBox1;
        private TextBox txtOferta;
        private TextBox txtCandidato;
        private TextBox txtEntrevistador;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Button btnAgregar;
        private Button btnDeshabilitar;
        private Button btnMostrar;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
    }
}