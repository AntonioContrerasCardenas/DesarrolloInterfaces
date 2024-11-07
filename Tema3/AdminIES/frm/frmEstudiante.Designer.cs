namespace AdminIES.frm
{
    partial class frmEstudiante
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
            label1 = new Label();
            label2 = new Label();
            txtClave = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtPrimerApellido = new TextBox();
            txtSegundoApellido = new TextBox();
            label5 = new Label();
            txtCorreo = new TextBox();
            label6 = new Label();
            cmbCiclo = new ComboBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            btnCancelar = new Button();
            btnExaminar = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            primerapellido = new DataGridViewTextBoxColumn();
            segundoapellido = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            foto = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 47);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Clave";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(553, 47);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(250, 78);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(160, 23);
            txtClave.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(553, 78);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(351, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 143);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 4;
            label3.Text = "Primer Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(617, 143);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 5;
            label4.Text = "Segundo Apellido";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(251, 171);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(296, 23);
            txtPrimerApellido.TabIndex = 6;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(618, 176);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(286, 23);
            txtSegundoApellido.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(252, 227);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 8;
            label5.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(253, 256);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(651, 23);
            txtCorreo.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(251, 319);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 10;
            label6.Text = "Ciclo";
            // 
            // cmbCiclo
            // 
            cmbCiclo.FormattingEnabled = true;
            cmbCiclo.Location = new Point(253, 348);
            cmbCiclo.Name = "cmbCiclo";
            cmbCiclo.Size = new Size(649, 23);
            cmbCiclo.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(262, 407);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(418, 407);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(571, 407);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 14;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(746, 405);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(50, 405);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(128, 23);
            btnExaminar.TabIndex = 16;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(25, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 273);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, nombre, primerapellido, segundoapellido, email, foto });
            dataGridView1.Location = new Point(39, 464);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(894, 150);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            // 
            // nombre
            // 
            nombre.HeaderText = "nombre";
            nombre.Name = "nombre";
            // 
            // primerapellido
            // 
            primerapellido.HeaderText = "primerapellido";
            primerapellido.Name = "primerapellido";
            // 
            // segundoapellido
            // 
            segundoapellido.HeaderText = "segundoapellido";
            segundoapellido.Name = "segundoapellido";
            // 
            // email
            // 
            email.HeaderText = "email";
            email.Name = "email";
            // 
            // foto
            // 
            foto.HeaderText = "foto";
            foto.Name = "foto";
            // 
            // frmEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 622);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(btnExaminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(cmbCiclo);
            Controls.Add(label6);
            Controls.Add(txtCorreo);
            Controls.Add(label5);
            Controls.Add(txtSegundoApellido);
            Controls.Add(txtPrimerApellido);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(txtClave);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEstudiante";
            Text = "frmEstudiante";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtClave;
        private TextBox txtNombre;
        private Label label3;
        private Label label4;
        private TextBox txtPrimerApellido;
        private TextBox txtSegundoApellido;
        private Label label5;
        private TextBox txtCorreo;
        private Label label6;
        private ComboBox cmbCiclo;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnBorrar;
        private Button btnCancelar;
        private Button btnExaminar;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn primerapellido;
        private DataGridViewTextBoxColumn segundoapellido;
        private DataGridViewTextBoxColumn email;
        private DataGridViewImageColumn foto;
    }
}