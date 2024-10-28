namespace EjemploFormulario
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
            label1 = new Label();
            label2 = new Label();
            btnContar = new Button();
            btnEliminar = new Button();
            label3 = new Label();
            textBoxCadena = new TextBox();
            textBoxResultado = new TextBox();
            cmbxCaracterVocales = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 42);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 0;
            label1.Text = "Cadena";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 86);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 1;
            label2.Text = "Caracter";
            // 
            // btnContar
            // 
            btnContar.Location = new Point(153, 144);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(75, 23);
            btnContar.TabIndex = 2;
            btnContar.Text = "Contar";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += btnContar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(299, 147);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 198);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "Resultado";
            // 
            // textBoxCadena
            // 
            textBoxCadena.Location = new Point(173, 41);
            textBoxCadena.Name = "textBoxCadena";
            textBoxCadena.Size = new Size(100, 23);
            textBoxCadena.TabIndex = 5;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(173, 198);
            textBoxResultado.Multiline = true;
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(167, 134);
            textBoxResultado.TabIndex = 6;
            textBoxResultado.TextChanged += textBox2_TextChanged;
            // 
            // cmbxCaracterVocales
            // 
            cmbxCaracterVocales.FormattingEnabled = true;
            cmbxCaracterVocales.Items.AddRange(new object[] { "A", "a", "E", "e", "I", "i", "O", "o", "U", "u" });
            cmbxCaracterVocales.Location = new Point(173, 85);
            cmbxCaracterVocales.Name = "cmbxCaracterVocales";
            cmbxCaracterVocales.Size = new Size(121, 23);
            cmbxCaracterVocales.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbxCaracterVocales);
            Controls.Add(textBoxResultado);
            Controls.Add(textBoxCadena);
            Controls.Add(label3);
            Controls.Add(btnEliminar);
            Controls.Add(btnContar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnContar;
        private Button btnEliminar;
        private Label label3;
        private TextBox textBoxCadena;
        private TextBox textBoxResultado;
        private ComboBox cmbxCaracterVocales;
    }
}
