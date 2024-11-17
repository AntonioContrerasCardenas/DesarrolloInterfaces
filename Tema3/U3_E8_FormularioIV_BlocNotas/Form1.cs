namespace U3_E8_FormularioIV_BlocNotas
{
    public partial class Form1 : Form
    {

        private string NombreFichero;

        public Form1()
        {
            InitializeComponent();
            NombreFichero = String.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text.Trim().Length <= 0) return;

            DialogResult result = MessageBox.Show("¿Quieres guardar el contenido?", "Nuevo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result != DialogResult.OK)
            {
                richTextBox.Clear();
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Guardar archivo";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    //richTextBox.Clear();
                    return;
                }

                NombreFichero = saveFileDialog.FileName;
                File.WriteAllText(NombreFichero, richTextBox.Text);
                MessageBox.Show("Archivo guardado con exito.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox.Clear();

            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Archivos RTF (*.rtf)|*.rtf";
                openFileDialog.Title = "Abrir archivo";

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                NombreFichero = openFileDialog.FileName;
                richTextBox.Text = File.ReadAllText(NombreFichero);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NombreFichero))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    saveFileDialog.Title = "Guardar archivo";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        //richTextBox.Clear();
                        return;
                    }

                    NombreFichero = saveFileDialog.FileName;
                    File.WriteAllText(NombreFichero, richTextBox.Text);
                    MessageBox.Show("Archivo guardado con exito.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            File.WriteAllText(NombreFichero, richTextBox.Text);
            MessageBox.Show("Archivo guardado con exito.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            ActualizaStatus();
        }

        private void richTextBox_SelectionChanged(object sender, EventArgs e)
        {
            ActualizaStatus();
        }

        private void ActualizaStatus()
        {
            int cursor = richTextBox.SelectionStart;

            int linea = richTextBox.GetLineFromCharIndex(cursor) + 1;
            int columna = cursor - richTextBox.GetFirstCharIndexOfCurrentLine() + 1;

            lblLineaColumna.Text = $"Ln {linea}, Col {columna}";
        }

        private void btnCortar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox.SelectedText)) richTextBox.Cut();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox.SelectedText)) richTextBox.Copy();
            else Clipboard.SetText(richTextBox.Text);
        }

        private void btnPegar_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }
    }
}
