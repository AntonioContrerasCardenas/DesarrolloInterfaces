namespace U3_E8_FormularioIV_BlocNotas
{
    partial class FormBuscar
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
            txtBuscar = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(33, 35);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(229, 23);
            txtBuscar.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(318, 35);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(115, 23);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FormBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 98);
            Controls.Add(btnAceptar);
            Controls.Add(txtBuscar);
            Name = "FormBuscar";
            Text = "Buscar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private Button btnAceptar;
    }
}