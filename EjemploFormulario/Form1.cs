namespace EjemploFormulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            string cadena = textBoxCadena.Text;
            string vocal = cmbxCaracterVocales.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(cadena))
            {
                MessageBox.Show("No se puede introducir una cadena vacia", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            

            if (string.IsNullOrEmpty(vocal))
            {
                MessageBox.Show("Seleccione una vocal", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            int vocalRepetida = cadena.Count(c => c.Equals(char.Parse(vocal)));

            string resultado = $"Las veces que se repite la vocal {vocal} en la cadena {cadena} es: {vocalRepetida}";

            textBoxResultado.Text = resultado;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string cadena = textBoxCadena.Text;
            string vocal = cmbxCaracterVocales.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(cadena))
            {
                MessageBox.Show("No se puede introducir una cadena vacia", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(vocal))
            {
                MessageBox.Show("Seleccione una vocal", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }


            string cadenaClean = cadena.Replace(vocal, "");

            string resultado = $"La cadena {cadena} sin la vocal {vocal} se quedaria: {cadenaClean}";

            textBoxResultado.Text = resultado;

        }
    }
}
