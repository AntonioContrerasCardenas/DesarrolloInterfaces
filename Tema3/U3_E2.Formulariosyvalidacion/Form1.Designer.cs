﻿namespace U3_E2.Formulariosyvalidacion
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtBEmail = new TextBox();
            label8 = new Label();
            txtBApellido = new TextBox();
            label9 = new Label();
            txtBNombre = new TextBox();
            label7 = new Label();
            txtBNif = new TextBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            errorProviderNif = new ErrorProvider(components);
            errorProviderNombre = new ErrorProvider(components);
            errorProviderApellido = new ErrorProvider(components);
            errorProviderEmail = new ErrorProvider(components);
            errorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderNif).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderApellido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtBEmail);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtBApellido);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtBNombre);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtBNif);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(8, 182);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 515);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonShadow;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(257, 444);
            button3.Name = "button3";
            button3.Size = new Size(90, 51);
            button3.TabIndex = 14;
            button3.Text = "CrucetaEliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(150, 444);
            button2.Name = "button2";
            button2.Size = new Size(90, 51);
            button2.TabIndex = 13;
            button2.Text = "Papelera";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(36, 444);
            button1.Name = "button1";
            button1.Size = new Size(90, 51);
            button1.TabIndex = 12;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtBEmail
            // 
            txtBEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBEmail.Location = new Point(206, 350);
            txtBEmail.Name = "txtBEmail";
            txtBEmail.Size = new Size(151, 29);
            txtBEmail.TabIndex = 11;
            txtBEmail.TextChanged += txtBEmail_TextChanged;
            txtBEmail.Validating += txtBEmail_Validating;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(206, 326);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(48, 21);
            label8.TabIndex = 10;
            label8.Text = "Email";
            // 
            // txtBApellido
            // 
            txtBApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBApellido.Location = new Point(13, 350);
            txtBApellido.Name = "txtBApellido";
            txtBApellido.Size = new Size(150, 29);
            txtBApellido.TabIndex = 9;
            txtBApellido.TextChanged += txtBApellido_TextChanged;
            txtBApellido.Validating += txtBApellido_Validating;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(13, 326);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(67, 21);
            label9.TabIndex = 8;
            label9.Text = "Apellido";
            // 
            // txtBNombre
            // 
            txtBNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBNombre.Location = new Point(206, 294);
            txtBNombre.Name = "txtBNombre";
            txtBNombre.Size = new Size(151, 29);
            txtBNombre.TabIndex = 7;
            txtBNombre.TextChanged += txtBNombre_TextChanged;
            txtBNombre.Validating += txtBNombre_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(206, 270);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(68, 21);
            label7.TabIndex = 6;
            label7.Text = "Nombre";
            // 
            // txtBNif
            // 
            txtBNif.BackColor = SystemColors.Window;
            txtBNif.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBNif.ForeColor = SystemColors.WindowText;
            txtBNif.Location = new Point(13, 294);
            txtBNif.Name = "txtBNif";
            txtBNif.Size = new Size(150, 29);
            txtBNif.TabIndex = 5;
            txtBNif.TextChanged += txtBNif_TextChanged;
            txtBNif.Validating += txtBNif_Validating;
            txtBNif.Validated += txtBNif_Validated;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(13, 270);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(34, 21);
            label6.TabIndex = 4;
            label6.Text = "NIF";
            label6.Click += label6_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(139, 75);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(135, 95);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(113, 27);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(195, 21);
            label5.TabIndex = 2;
            label5.Text = "Información del estudiante";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(7, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1102, 68);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(416, 15);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(275, 32);
            label1.TabIndex = 0;
            label1.Text = "Sistema de estudiantes";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(8, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(1101, 61);
            panel3.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(623, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 29);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(509, 15);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(90, 32);
            label3.TabIndex = 2;
            label3.Text = "Buscar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(95, 15);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(145, 32);
            label2.TabIndex = 1;
            label2.Text = "Estudiantes";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(label4);
            panel4.Location = new Point(444, 182);
            panel4.Name = "panel4";
            panel4.Size = new Size(665, 515);
            panel4.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(231, 27);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(139, 21);
            label4.TabIndex = 3;
            label4.Text = "Lista de estudiante";
            // 
            // errorProviderNif
            // 
            errorProviderNif.ContainerControl = this;
            // 
            // errorProviderNombre
            // 
            errorProviderNombre.ContainerControl = this;
            // 
            // errorProviderApellido
            // 
            errorProviderApellido.ContainerControl = this;
            // 
            // errorProviderEmail
            // 
            errorProviderEmail.ContainerControl = this;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 709);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Sistema de estudiantes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderNif).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNombre).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderApellido).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Panel panel4;
        private Label label6;
        private PictureBox pictureBox2;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtBEmail;
        private Label label8;
        private TextBox txtBApellido;
        private Label label9;
        private TextBox txtBNombre;
        private Label label7;
        private TextBox txtBNif;
        private ErrorProvider errorProviderNif;
        private ErrorProvider errorProviderNombre;
        private ErrorProvider errorProviderApellido;
        private ErrorProvider errorProviderEmail;
        private ErrorProvider errorProvider;
    }
}