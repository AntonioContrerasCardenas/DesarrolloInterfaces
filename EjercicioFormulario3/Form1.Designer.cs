namespace EjercicioFormulario3
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
            nUpDown = new NumericUpDown();
            tBoxResultado = new TextBox();
            rbtnAscendente = new RadioButton();
            rbtnDescendente = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)nUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 37);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 154);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "Tabla de multiplicar";
            // 
            // nUpDown
            // 
            nUpDown.Location = new Point(134, 35);
            nUpDown.Name = "nUpDown";
            nUpDown.Size = new Size(120, 23);
            nUpDown.TabIndex = 2;
            // 
            // tBoxResultado
            // 
            tBoxResultado.Location = new Point(121, 192);
            tBoxResultado.Multiline = true;
            tBoxResultado.Name = "tBoxResultado";
            tBoxResultado.Size = new Size(190, 207);
            tBoxResultado.TabIndex = 3;
            // 
            // rbtnAscendente
            // 
            rbtnAscendente.AutoSize = true;
            rbtnAscendente.Location = new Point(80, 98);
            rbtnAscendente.Name = "rbtnAscendente";
            rbtnAscendente.Size = new Size(87, 19);
            rbtnAscendente.TabIndex = 4;
            rbtnAscendente.TabStop = true;
            rbtnAscendente.Text = "Ascendente";
            rbtnAscendente.UseVisualStyleBackColor = true;
            rbtnAscendente.CheckedChanged += rbtnAscendente_CheckedChanged;
            // 
            // rbtnDescendente
            // 
            rbtnDescendente.AutoSize = true;
            rbtnDescendente.Location = new Point(222, 100);
            rbtnDescendente.Name = "rbtnDescendente";
            rbtnDescendente.Size = new Size(93, 19);
            rbtnDescendente.TabIndex = 5;
            rbtnDescendente.TabStop = true;
            rbtnDescendente.Text = "Descendente";
            rbtnDescendente.UseVisualStyleBackColor = true;
            rbtnDescendente.CheckedChanged += rbtnDescendente_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbtnDescendente);
            Controls.Add(rbtnAscendente);
            Controls.Add(tBoxResultado);
            Controls.Add(nUpDown);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown nUpDown;
        private TextBox tBoxResultado;
        private RadioButton rbtnAscendente;
        private RadioButton rbtnDescendente;
    }
}
