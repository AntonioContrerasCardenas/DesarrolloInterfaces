namespace U3_E9_Serializacion_XML
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtDni = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtDireccion = new TextBox();
            txtEdad = new TextBox();
            txtTelefono = new TextBox();
            txtNumeroCuenta = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 346);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(929, 182);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 43);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 1;
            label1.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(239, 40);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(167, 23);
            txtDni.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(468, 42);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(546, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(149, 23);
            txtNombre.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 110);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(486, 115);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 6;
            label4.Text = "Edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(161, 178);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 7;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(426, 186);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 8;
            label6.Text = "Numero de cuenta";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(239, 110);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(167, 23);
            txtDireccion.TabIndex = 9;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(546, 107);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(149, 23);
            txtEdad.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(239, 178);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(167, 23);
            txtTelefono.TabIndex = 11;
            // 
            // txtNumeroCuenta
            // 
            txtNumeroCuenta.Location = new Point(546, 183);
            txtNumeroCuenta.Name = "txtNumeroCuenta";
            txtNumeroCuenta.Size = new Size(149, 23);
            txtNumeroCuenta.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(170, 260);
            button1.Name = "button1";
            button1.Size = new Size(125, 55);
            button1.TabIndex = 13;
            button1.Text = "Añadir Clientes";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(384, 260);
            button2.Name = "button2";
            button2.Size = new Size(123, 55);
            button2.TabIndex = 14;
            button2.Text = "Modificar Datos";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(610, 260);
            button3.Name = "button3";
            button3.Size = new Size(114, 55);
            button3.TabIndex = 15;
            button3.Text = "Eliminar Clientes";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 540);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNumeroCuenta);
            Controls.Add(txtTelefono);
            Controls.Add(txtEdad);
            Controls.Add(txtDireccion);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtDni);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtDni;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtDireccion;
        private TextBox txtEdad;
        private TextBox txtTelefono;
        private TextBox txtNumeroCuenta;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
