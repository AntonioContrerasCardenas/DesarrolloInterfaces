using System.Windows.Forms;

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
            if (string.IsNullOrEmpty(richTextBox.Text))
            {
                richTextBox.Clear();
                NombreFichero = String.Empty;
                return;
            }

            DialogResult result = MessageBox.Show("¿Quieres guardar el contenido?", "Nuevo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result != DialogResult.OK)
            {
                //richTextBox.Clear();
                //NombreFichero = String.Empty;
                return;
            }

            GuardarArchivo();
            NombreFichero = String.Empty;
            richTextBox.Clear() ;

            /*using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Guardar archivo";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    //richTextBox.Clear();
                    return;
                }

                
                NombreFichero = saveFileDialog.FileName;

                GuardarFichero(NombreFichero);

               
                MessageBox.Show("Archivo guardado con exito.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox.Clear();
                NombreFichero = String.Empty;
            }*/
        }

        private void GuardarFichero(string nombreFichero)
        {
            string extension = Path.GetExtension(nombreFichero).ToLower();
            if (extension == ".rtf")
                richTextBox.SaveFile(nombreFichero, RichTextBoxStreamType.RichText);
            else
                File.WriteAllText(nombreFichero, richTextBox.Text);

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Documentos de texto (*.txt)|*.txt|Archivos RTF (*.rtf)|*.rtf";
                openFileDialog.Title = "Abrir";

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                NombreFichero = openFileDialog.FileName;

                string extension = Path.GetExtension(NombreFichero).ToLower();

                if(extension.Equals(".rtf"))
                    richTextBox.LoadFile(NombreFichero, RichTextBoxStreamType.RichText);
                else
                    richTextBox.Text = File.ReadAllText(NombreFichero);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            GuardarArchivo();

            /*if (String.IsNullOrEmpty(NombreFichero))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Documentos de texto (*.txt)|*.txt|All Files (*.*)|*.*";
                    saveFileDialog.Title = "Guardar como";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        //richTextBox.Clear();
                        return;
                    }

                    NombreFichero = saveFileDialog.FileName;
                    GuardarFichero(NombreFichero);
                    MessageBox.Show("Archivo guardado con exito.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            GuardarFichero(NombreFichero);
            MessageBox.Show("Archivo guardado con exito.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }

        private void GuardarArchivo()
        {
            if (string.IsNullOrEmpty(NombreFichero))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Archivos RTF (*.rtf)|*.rtf";
                    saveFileDialog.Title = "Guardar como";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                        return;

                    NombreFichero = saveFileDialog.FileName;
                }
            }

            GuardarFichero(NombreFichero);
            MessageBox.Show("Archivo guardado con éxito.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                if(richTextBox.SelectedText.Length > 0)
                    Clipboard.SetText(richTextBox.Text);
            }
        }

        private void btnPegar_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using(FormBuscar form1 = new FormBuscar())
            {
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    string palabraBuscar = form1.palabraABuscar;
                    int posicion = richTextBox.Find(palabraBuscar, RichTextBoxFinds.None);

                    if (posicion != -1)
                    {
                        richTextBox.Select(posicion, palabraBuscar.Length);
                        richTextBox.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Palabra no encontrada.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private void btnFuente_Click(object sender, EventArgs e)
        {
            using (FontDialog font = new FontDialog())
            {
                font.Font = richTextBox.SelectionFont ?? richTextBox.Font;
                if (font.ShowDialog() == DialogResult.OK) 
                { 
                    richTextBox.SelectionFont = font.Font;
                }
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog color = new ColorDialog())
            {
                color.Color = richTextBox.SelectionColor ;
                if (color.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SelectionColor = color.Color;
                }
            }
        }
    }
}
