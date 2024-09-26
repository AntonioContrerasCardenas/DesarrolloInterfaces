namespace ReservaSalones
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
            btnAbrirFormulario = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnAbrirFormulario
            // 
            btnAbrirFormulario.BackgroundImageLayout = ImageLayout.Zoom;
            btnAbrirFormulario.Cursor = Cursors.IBeam;
            btnAbrirFormulario.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAbrirFormulario.Location = new Point(314, 188);
            btnAbrirFormulario.Name = "btnAbrirFormulario";
            btnAbrirFormulario.Size = new Size(142, 49);
            btnAbrirFormulario.TabIndex = 0;
            btnAbrirFormulario.Text = "Empieza aquí";
            btnAbrirFormulario.UseVisualStyleBackColor = true;
            btnAbrirFormulario.Click += btnAbrirFormulario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 60);
            label1.Name = "label1";
            label1.Size = new Size(179, 42);
            label1.TabIndex = 1;
            label1.Text = "Salón Almunia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(263, 135);
            label2.Name = "label2";
            label2.Size = new Size(257, 30);
            label2.TabIndex = 2;
            label2.Text = "Vamos a crear un nuevo evento";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAbrirFormulario);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbrirFormulario;
        private Label label1;
        private Label label2;
    }
}
