namespace U3_E9_Serializacion_XML.Forms
{
    partial class FormModificar
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
            btnModificar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 34);
            label1.Name = "label1";
            label1.Size = new Size(176, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccione el cliente a modificar";
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(91, 70);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(145, 23);
            cmbClientes.TabIndex = 1;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(233, 70);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // FormModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 124);
            Controls.Add(btnModificar);
            Controls.Add(cmbClientes);
            Controls.Add(label1);
            Name = "FormModificar";
            Text = "FormModificar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbClientes;
        private Button btnModificar;
    }
}