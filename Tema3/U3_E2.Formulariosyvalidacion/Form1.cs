using System.Text.RegularExpressions;

namespace U3_E2.Formulariosyvalidacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtBNif_Validated(object sender, EventArgs e)
        {

        }

        private void txtBNif_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string dni = txtBNif.Text.Trim();

            var pattern = @"^\d{8}[A-Z]$";
            if (!Regex.IsMatch(dni, pattern))
            {
                MessageBox.Show("El formato del NIF no es válido. Debe tener 8 números seguidos de una letra.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(txtBNif, "El formato del NIF no es válido");
                e.Cancel = true;
                //txtBNif.Focus();
                return;
            }
            errorProvider.SetError(txtBNif, "");
            e.Cancel = false;
        }

        private void txtBNif_TextChanged(object sender, EventArgs e)
        {
            CambiarColor(txtBNif);
        }

        private void txtBNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string nombre = txtBNombre.Text.Trim();

            var pattern = @"^[A-Za-z]{3,18}$";
            if (!Regex.IsMatch(nombre, pattern))
            {
                MessageBox.Show("El formato del nombre no es válido. Debe tener mínimo 3 letras y maximo 18.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(txtBNombre, "El formato del nombre no es válido");
                e.Cancel = true;
                //txtBNombre.Focus();
                return;
            }
            errorProvider.SetError(txtBNombre, "");
            e.Cancel = false;
            return;
        }

        private void txtBApellido_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string apellido = txtBApellido.Text.Trim();

            var pattern = @"^[A-Za-z]{3,18}$";
            if (!Regex.IsMatch(apellido, pattern))
            {
                MessageBox.Show("El formato del apellido no es válido. Debe tener mínimo 3 letras y maximo 18.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(txtBApellido, "El formato del apellido no es válido");
                e.Cancel = true;
                //txtBApellido.Focus();
                return;
            }
            errorProvider.SetError(txtBApellido, "");
            e.Cancel = false;
            return;
        }

        private void txtBEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            string email = txtBEmail.Text.Trim();

            var pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(email, pattern))
            {
                MessageBox.Show("El formato del email no es válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(txtBEmail, "El formato del email no es válido");
                e.Cancel = true;
                //txtBEmail.Focus();
                return;
            }
            e.Cancel = false;
            errorProvider.SetError(txtBEmail, "");
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                MessageBox.Show("Todos los campos son validos.", "Validacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBNombre_TextChanged(object sender, EventArgs e)
        {
            CambiarColor(txtBNombre);
        }

        private void txtBApellido_TextChanged(object sender, EventArgs e)
        {
            CambiarColor(txtBApellido);
        }

        private void txtBEmail_TextChanged(object sender, EventArgs e)
        {
            CambiarColor(txtBEmail);
        }

        private void CambiarColor(TextBox tb)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.BackColor = SystemColors.Window;
            }
            else
            {
                tb.BackColor = Color.AliceBlue;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBApellido.Text = string.Empty;
            txtBNif.Text = string.Empty;
            txtBNombre.Text = string.Empty;
            txtBEmail.Text = string.Empty;
        }
    }
}
