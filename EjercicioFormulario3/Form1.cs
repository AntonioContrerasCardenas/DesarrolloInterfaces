namespace EjercicioFormulario3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtnAscendente_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbtnAscendente.Checked)
            {
                return;
            }

            int valor = (int)nUpDown.Value;
            tBoxResultado.Text = "";
            for (int i = 0; i <= 10; i++)
            {
                tBoxResultado.Text += $"{valor} * {i} = {valor * i} \r\n";
            }
        }

        private void rbtnDescendente_CheckedChanged(object sender, EventArgs e)
        {

            if (!rbtnDescendente.Checked)
            {
                return;
            }

            int valor = (int)nUpDown.Value;
            tBoxResultado.Text = "";
            for (int i = 10; i >= 0; i--)
            {
                tBoxResultado.Text += $"{valor} * {i} = {valor * i} \r\n";
            }
        }
    }
}
