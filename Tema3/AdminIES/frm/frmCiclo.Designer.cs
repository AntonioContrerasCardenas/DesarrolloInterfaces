namespace AdminIES.frm
{
    partial class frmCiclo
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
            txtId = new TextBox();
            txtNombreCiclo = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            btnCancelar = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 38);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 39);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre Ciclo";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(50, 67);
            txtId.Name = "txtId";
            txtId.Size = new Size(205, 23);
            txtId.TabIndex = 2;
            // 
            // txtNombreCiclo
            // 
            txtNombreCiclo.Location = new Point(295, 67);
            txtNombreCiclo.Name = "txtNombreCiclo";
            txtNombreCiclo.Size = new Size(447, 23);
            txtNombreCiclo.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(46, 125);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(194, 125);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(358, 125);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(548, 125);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, nombre });
            dataGridView1.Location = new Point(45, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(697, 150);
            dataGridView1.TabIndex = 8;
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
            // frmCiclo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancelar);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombreCiclo);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCiclo";
            Text = "frmCiclo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtId;
        private TextBox txtNombreCiclo;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnBorrar;
        private Button btnCancelar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
    }
}