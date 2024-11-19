namespace U3_E8_FormularioIV_BlocNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuSuperior = new MenuStrip();
            btnArchivo = new ToolStripMenuItem();
            btnNuevo = new ToolStripMenuItem();
            btnAbrir = new ToolStripMenuItem();
            btnGuardar = new ToolStripMenuItem();
            btnSalir = new ToolStripMenuItem();
            btnEdicion = new ToolStripMenuItem();
            btnCortar = new ToolStripMenuItem();
            btnCopiar = new ToolStripMenuItem();
            btnPegar = new ToolStripMenuItem();
            btnBuscar = new ToolStripMenuItem();
            btnFuente = new ToolStripMenuItem();
            btnColor = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            pngNuevo = new ToolStripButton();
            pngAbrir = new ToolStripButton();
            pngGuardar = new ToolStripButton();
            pngCortar = new ToolStripButton();
            pngCopiar = new ToolStripButton();
            pngPegar = new ToolStripButton();
            pngBuscar = new ToolStripButton();
            pngFuente = new ToolStripButton();
            pngColor = new ToolStripButton();
            richTextBox = new RichTextBox();
            statusStrip = new StatusStrip();
            lblLineaColumna = new ToolStripStatusLabel();
            menuSuperior.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuSuperior
            // 
            menuSuperior.Items.AddRange(new ToolStripItem[] { btnArchivo, btnEdicion });
            menuSuperior.Location = new Point(0, 0);
            menuSuperior.Name = "menuSuperior";
            menuSuperior.Size = new Size(1042, 24);
            menuSuperior.TabIndex = 0;
            menuSuperior.Text = "menuStrip1";
            // 
            // btnArchivo
            // 
            btnArchivo.DropDownItems.AddRange(new ToolStripItem[] { btnNuevo, btnAbrir, btnGuardar, btnSalir });
            btnArchivo.Name = "btnArchivo";
            btnArchivo.Size = new Size(60, 20);
            btnArchivo.Text = "Archivo";
            // 
            // btnNuevo
            // 
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(116, 22);
            btnNuevo.Text = "Nuevo";
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnAbrir
            // 
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(116, 22);
            btnAbrir.Text = "Abrir";
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(116, 22);
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(116, 22);
            btnSalir.Text = "Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEdicion
            // 
            btnEdicion.DropDownItems.AddRange(new ToolStripItem[] { btnCortar, btnCopiar, btnPegar, btnBuscar, btnFuente, btnColor });
            btnEdicion.Name = "btnEdicion";
            btnEdicion.Size = new Size(58, 20);
            btnEdicion.Text = "Edición";
            // 
            // btnCortar
            // 
            btnCortar.Name = "btnCortar";
            btnCortar.Size = new Size(110, 22);
            btnCortar.Text = "Cortar";
            btnCortar.Click += btnCortar_Click;
            // 
            // btnCopiar
            // 
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(110, 22);
            btnCopiar.Text = "Copiar";
            btnCopiar.Click += btnCopiar_Click;
            // 
            // btnPegar
            // 
            btnPegar.Name = "btnPegar";
            btnPegar.Size = new Size(110, 22);
            btnPegar.Text = "Pegar";
            btnPegar.Click += btnPegar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 22);
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnFuente
            // 
            btnFuente.Name = "btnFuente";
            btnFuente.Size = new Size(110, 22);
            btnFuente.Text = "Fuente";
            btnFuente.Click += btnFuente_Click;
            // 
            // btnColor
            // 
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(110, 22);
            btnColor.Text = "Color";
            btnColor.Click += btnColor_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { pngNuevo, pngAbrir, pngGuardar, pngCortar, pngCopiar, pngPegar, pngBuscar, pngFuente, pngColor });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1042, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // pngNuevo
            // 
            pngNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pngNuevo.Image = (Image)resources.GetObject("pngNuevo.Image");
            pngNuevo.ImageTransparentColor = Color.Magenta;
            pngNuevo.Name = "pngNuevo";
            pngNuevo.Size = new Size(23, 22);
            pngNuevo.Text = "Nuevo";
            pngNuevo.Click += btnNuevo_Click;
            // 
            // pngAbrir
            // 
            pngAbrir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pngAbrir.Image = Properties.Resources.abrir;
            pngAbrir.ImageTransparentColor = Color.Magenta;
            pngAbrir.Name = "pngAbrir";
            pngAbrir.Size = new Size(23, 22);
            pngAbrir.Text = "Abrir";
            pngAbrir.Click += btnAbrir_Click;
            // 
            // pngGuardar
            // 
            pngGuardar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pngGuardar.Image = Properties.Resources.guardar;
            pngGuardar.ImageTransparentColor = Color.Magenta;
            pngGuardar.Name = "pngGuardar";
            pngGuardar.Size = new Size(23, 22);
            pngGuardar.Text = "Guardar";
            pngGuardar.Click += btnGuardar_Click;
            // 
            // pngCortar
            // 
            pngCortar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pngCortar.Image = Properties.Resources.cortar;
            pngCortar.ImageTransparentColor = Color.Magenta;
            pngCortar.Name = "pngCortar";
            pngCortar.Size = new Size(23, 22);
            pngCortar.Text = "Cortar";
            pngCortar.Click += btnCortar_Click;
            // 
            // pngCopiar
            // 
            pngCopiar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pngCopiar.Image = Properties.Resources.copiar;
            pngCopiar.ImageTransparentColor = Color.Magenta;
            pngCopiar.Name = "pngCopiar";
            pngCopiar.Size = new Size(23, 22);
            pngCopiar.Text = "Copiar";
            pngCopiar.Click += btnCopiar_Click;
            // 
            // pngPegar
            // 
            pngPegar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pngPegar.Image = Properties.Resources.pegar;
            pngPegar.ImageTransparentColor = Color.Magenta;
            pngPegar.Name = "pngPegar";
            pngPegar.Size = new Size(23, 22);
            pngPegar.Text = "Pegar";
            pngPegar.Click += btnPegar_Click;
            // 
            // pngBuscar
            // 
            pngBuscar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pngBuscar.Image = Properties.Resources.buscar;
            pngBuscar.ImageTransparentColor = Color.Magenta;
            pngBuscar.Name = "pngBuscar";
            pngBuscar.Size = new Size(23, 22);
            pngBuscar.Text = "Buscar";
            pngBuscar.Click += btnBuscar_Click;
            // 
            // pngFuente
            // 
            pngFuente.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pngFuente.Image = Properties.Resources.fuente;
            pngFuente.ImageTransparentColor = Color.Magenta;
            pngFuente.Name = "pngFuente";
            pngFuente.Size = new Size(23, 22);
            pngFuente.Text = "Fuente";
            pngFuente.Click += btnFuente_Click;
            // 
            // pngColor
            // 
            pngColor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pngColor.Image = Properties.Resources.color;
            pngColor.ImageTransparentColor = Color.Magenta;
            pngColor.Name = "pngColor";
            pngColor.Size = new Size(23, 22);
            pngColor.Text = "Color";
            pngColor.Click += btnColor_Click;
            // 
            // richTextBox
            // 
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.Location = new Point(0, 49);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(1042, 521);
            richTextBox.TabIndex = 2;
            richTextBox.Text = "";
            richTextBox.SelectionChanged += richTextBox_SelectionChanged;
            richTextBox.TextChanged += richTextBox_TextChanged;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { lblLineaColumna });
            statusStrip.Location = new Point(0, 548);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1042, 22);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip1";
            // 
            // lblLineaColumna
            // 
            lblLineaColumna.Name = "lblLineaColumna";
            lblLineaColumna.Size = new Size(0, 17);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 570);
            Controls.Add(statusStrip);
            Controls.Add(richTextBox);
            Controls.Add(toolStrip1);
            Controls.Add(menuSuperior);
            MainMenuStrip = menuSuperior;
            Name = "Form1";
            Text = "Form1";
            menuSuperior.ResumeLayout(false);
            menuSuperior.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuSuperior;
        private ToolStrip toolStrip1;
        private RichTextBox richTextBox;
        private ToolStripMenuItem btnArchivo;
        private ToolStripMenuItem btnEdicion;
        private ToolStripMenuItem btnNuevo;
        private ToolStripMenuItem btnAbrir;
        private ToolStripMenuItem btnGuardar;
        private ToolStripMenuItem btnSalir;
        private ToolStripMenuItem btnCortar;
        private ToolStripMenuItem btnCopiar;
        private ToolStripMenuItem btnPegar;
        private ToolStripMenuItem btnBuscar;
        private ToolStripMenuItem btnFuente;
        private ToolStripMenuItem btnColor;
        private ToolStripButton pngNuevo;
        private ToolStripButton pngAbrir;
        private ToolStripButton pngGuardar;
        private ToolStripButton pngCortar;
        private ToolStripButton pngCopiar;
        private ToolStripButton pngPegar;
        private ToolStripButton pngBuscar;
        private ToolStripButton pngFuente;
        private ToolStripButton pngColor;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblLineaColumna;
    }
}
