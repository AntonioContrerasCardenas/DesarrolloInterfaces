namespace ReservaSalones
{
    partial class FrmReservaSalon
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
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            label4 = new Label();
            cmbTipoEvento = new ComboBox();
            label5 = new Label();
            txtNumeroPersonas = new TextBox();
            label6 = new Label();
            cmbTipoCocina = new ComboBox();
            nudNumeroJornadas = new NumericUpDown();
            label7 = new Label();
            chkRequiereHabitaciones = new CheckBox();
            rdbMesaRectangular = new RadioButton();
            rdbMesaRedonda = new RadioButton();
            labelComensales = new Label();
            nudComensalesPorMesa = new NumericUpDown();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudNumeroJornadas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudComensalesPorMesa).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 35);
            label1.Name = "label1";
            label1.Size = new Size(56, 16);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 73);
            label2.Name = "label2";
            label2.Size = new Size(63, 16);
            label2.TabIndex = 1;
            label2.Text = "Telefono";
            label2.Click += label2_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(121, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(131, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(121, 70);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(131, 23);
            txtTelefono.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 29);
            label3.Name = "label3";
            label3.Size = new Size(47, 16);
            label3.TabIndex = 4;
            label3.Text = "Fecha";
            label3.Click += label3_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(189, 22);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 65);
            label4.Name = "label4";
            label4.Size = new Size(40, 16);
            label4.TabIndex = 6;
            label4.Text = "Tipo ";
            label4.Click += label4_Click;
            // 
            // cmbTipoEvento
            // 
            cmbTipoEvento.FormattingEnabled = true;
            cmbTipoEvento.Items.AddRange(new object[] { "Banquete", "Jornada", "Congreso" });
            cmbTipoEvento.Location = new Point(189, 62);
            cmbTipoEvento.Name = "cmbTipoEvento";
            cmbTipoEvento.Size = new Size(121, 24);
            cmbTipoEvento.TabIndex = 7;
            cmbTipoEvento.SelectedIndexChanged += cmbTipoEvento_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 107);
            label5.Name = "label5";
            label5.Size = new Size(141, 16);
            label5.TabIndex = 8;
            label5.Text = "Número de personas";
            // 
            // txtNumeroPersonas
            // 
            txtNumeroPersonas.Location = new Point(189, 107);
            txtNumeroPersonas.Name = "txtNumeroPersonas";
            txtNumeroPersonas.Size = new Size(100, 23);
            txtNumeroPersonas.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 145);
            label6.Name = "label6";
            label6.Size = new Size(104, 16);
            label6.TabIndex = 10;
            label6.Text = "Tipo de cocina";
            label6.Click += label6_Click;
            // 
            // cmbTipoCocina
            // 
            cmbTipoCocina.FormattingEnabled = true;
            cmbTipoCocina.Items.AddRange(new object[] { "Buffet", "Carta", "Pedir cita con el chef", "No precisa" });
            cmbTipoCocina.Location = new Point(189, 145);
            cmbTipoCocina.Name = "cmbTipoCocina";
            cmbTipoCocina.Size = new Size(121, 24);
            cmbTipoCocina.TabIndex = 11;
            // 
            // nudNumeroJornadas
            // 
            nudNumeroJornadas.Enabled = false;
            nudNumeroJornadas.Location = new Point(189, 54);
            nudNumeroJornadas.Name = "nudNumeroJornadas";
            nudNumeroJornadas.Size = new Size(87, 23);
            nudNumeroJornadas.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 56);
            label7.Name = "label7";
            label7.Size = new Size(138, 16);
            label7.TabIndex = 13;
            label7.Text = "Número de jornadas";
            // 
            // chkRequiereHabitaciones
            // 
            chkRequiereHabitaciones.AutoSize = true;
            chkRequiereHabitaciones.Enabled = false;
            chkRequiereHabitaciones.Location = new Point(36, 92);
            chkRequiereHabitaciones.Name = "chkRequiereHabitaciones";
            chkRequiereHabitaciones.RightToLeft = RightToLeft.Yes;
            chkRequiereHabitaciones.Size = new Size(170, 20);
            chkRequiereHabitaciones.TabIndex = 14;
            chkRequiereHabitaciones.Text = "Requiere habitaciones";
            chkRequiereHabitaciones.UseVisualStyleBackColor = true;
            chkRequiereHabitaciones.CheckedChanged += chkRequiereHabitaciones_CheckedChanged;
            // 
            // rdbMesaRectangular
            // 
            rdbMesaRectangular.AutoSize = true;
            rdbMesaRectangular.CheckAlign = ContentAlignment.MiddleRight;
            rdbMesaRectangular.Enabled = false;
            rdbMesaRectangular.Location = new Point(36, 151);
            rdbMesaRectangular.Name = "rdbMesaRectangular";
            rdbMesaRectangular.Size = new Size(139, 20);
            rdbMesaRectangular.TabIndex = 15;
            rdbMesaRectangular.TabStop = true;
            rdbMesaRectangular.Text = "Mesa rectangular";
            rdbMesaRectangular.UseVisualStyleBackColor = true;
            // 
            // rdbMesaRedonda
            // 
            rdbMesaRedonda.AutoSize = true;
            rdbMesaRedonda.CheckAlign = ContentAlignment.MiddleRight;
            rdbMesaRedonda.Enabled = false;
            rdbMesaRedonda.Location = new Point(36, 177);
            rdbMesaRedonda.Name = "rdbMesaRedonda";
            rdbMesaRedonda.Size = new Size(117, 20);
            rdbMesaRedonda.TabIndex = 16;
            rdbMesaRedonda.TabStop = true;
            rdbMesaRedonda.Text = "Mesa redonda";
            rdbMesaRedonda.UseVisualStyleBackColor = true;
            // 
            // labelComensales
            // 
            labelComensales.AutoSize = true;
            labelComensales.Location = new Point(36, 205);
            labelComensales.Name = "labelComensales";
            labelComensales.Size = new Size(158, 16);
            labelComensales.TabIndex = 18;
            labelComensales.Text = "Número de comensales";
            // 
            // nudComensalesPorMesa
            // 
            nudComensalesPorMesa.Enabled = false;
            nudComensalesPorMesa.Location = new Point(204, 198);
            nudComensalesPorMesa.Name = "nudComensalesPorMesa";
            nudComensalesPorMesa.Size = new Size(87, 23);
            nudComensalesPorMesa.TabIndex = 17;
            nudComensalesPorMesa.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.BackgroundImageLayout = ImageLayout.Center;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Verdana", 9.75F);
            groupBox1.Location = new Point(73, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(405, 128);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del contacto";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dtpFecha);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cmbTipoEvento);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtNumeroPersonas);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cmbTipoCocina);
            groupBox2.Font = new Font("Verdana", 9.75F);
            groupBox2.Location = new Point(73, 146);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(405, 208);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalles del evento";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.GradientInactiveCaption;
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(labelComensales);
            groupBox3.Controls.Add(nudComensalesPorMesa);
            groupBox3.Controls.Add(nudNumeroJornadas);
            groupBox3.Controls.Add(chkRequiereHabitaciones);
            groupBox3.Controls.Add(rdbMesaRedonda);
            groupBox3.Controls.Add(rdbMesaRectangular);
            groupBox3.Font = new Font("Verdana", 9.75F);
            groupBox3.Location = new Point(73, 370);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(317, 263);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Opciones adicionales";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9.75F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 127);
            label9.Name = "label9";
            label9.Size = new Size(75, 16);
            label9.TabIndex = 15;
            label9.Text = "Banquete:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9.75F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.Location = new Point(14, 30);
            label8.Name = "label8";
            label8.Size = new Size(75, 16);
            label8.TabIndex = 14;
            label8.Text = "Congreso:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Lime;
            btnGuardar.Font = new Font("Verdana", 9.75F);
            btnGuardar.Location = new Point(93, 648);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(97, 39);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.Font = new Font("Verdana", 9.75F);
            btnCancelar.ForeColor = SystemColors.ControlText;
            btnCancelar.Location = new Point(262, 648);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 39);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmReservaSalon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 699);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmReservaSalon";
            Text = "FrmReservaSalon";
            Load += FrmReservaSalon_Load;
            ((System.ComponentModel.ISupportInitialize)nudNumeroJornadas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudComensalesPorMesa).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private Label label3;
        private DateTimePicker dtpFecha;
        private Label label4;
        private ComboBox cmbTipoEvento;
        private Label label5;
        private TextBox txtNumeroPersonas;
        private Label label6;
        private ComboBox cmbTipoCocina;
        private NumericUpDown nudNumeroJornadas;
        private Label label7;
        private CheckBox chkRequiereHabitaciones;
        private RadioButton rdbMesaRectangular;
        private RadioButton rdbMesaRedonda;
        private Label labelComensales;
        private NumericUpDown nudComensalesPorMesa;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label9;
        private Label label8;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}