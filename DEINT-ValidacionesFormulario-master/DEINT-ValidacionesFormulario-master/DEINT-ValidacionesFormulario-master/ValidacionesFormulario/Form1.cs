using System.ComponentModel;
using System.Text.RegularExpressions;

namespace ValidacionesFormulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        // Permite hacer las validaciones en tiempo real mientras el usuario está ingresando datos en un control,
        // como un cuadro de texto.

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                //Va a permitir introducir un número o la tecla de borrar.
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    MessageBox.Show("El carácter introducido no es una cifra");
                    e.Handled = true; //Cancela la entrada del carácter no válido.
                }
            }

        }

        private void textBox2_Validating_1(object sender, CancelEventArgs e)
        {

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex reg = new Regex(pattern);
            if (!reg.IsMatch(this.textBox2.Text))
            {
                MessageBox.Show("El formato del email es incorrecto.");
                e.Cancel = true;  //Cancela el cambio de foco 
            }

        }


        //Añadimos el control ErrorProvider para mostrar el error 

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBox3.Text, @"^\d{8}[A-Z]$") || String.IsNullOrEmpty(textBox3.Text))
            {
                ePDNI.SetError(textBox3, "El formato del NIF es incorrecto.");
                e.Cancel = true;
            }
            else
            {
                ePDNI.SetError(textBox3, "");
                e.Cancel = false; //Permite el cambio de foco, si no hay error  (por defecto es así, no hace falta ponerlo) 
            }
        }



        //Que lo envie si todos los validating son correctos
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                MessageBox.Show("Se ha añadido correctamente");
            }
            else
            {
                MessageBox.Show("Algún campo es incorrecto");
            }
        }

        
    }
}


