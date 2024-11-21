namespace U3_E9_Serializacion_XML.Forms
{
    partial class FormEliminar
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
            cmbClientes = new ComboBox();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 33);
            label1.Name = "label1";
            label1.Size = new Size(168, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccione el cliente a eliminar";
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(70, 68);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(163, 23);
            cmbClientes.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(230, 68);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 134);
            Controls.Add(btnEliminar);
            Controls.Add(cmbClientes);
            Controls.Add(label1);
            Name = "FormEliminar";
            Text = "FormEliminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbClientes;
        private Button btnEliminar;
    }
}