using System.Data;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using U3_E9_Serializacion_XML.Clases;
using U3_E9_Serializacion_XML.Forms;

namespace U3_E9_Serializacion_XML
{
    public partial class Form1 : Form
    {
        private string fichero = "banco.xml";
        private Banco banco { get; set; }
        public Boolean btnEliminarClicked { get; set; }
        public Boolean btnModificarClicked { get; set; }

        string patronDni = @"^\d{8}[A-Za-z]\z";
        string mensageDni = "El dni debe estar compuesto por 8 digitos y una letra";

        string patronNombre = @"^[a-zA-Z\s]+\z";
        string mensageNombre = "Solo se permiten letras y espacios"; 
        
        string patronEdad = @"^\d{1,3}\z";
        string mensageEdad = "La edad deben de ser digitos de maximo 3"; 

        string patronTelefono = @"^\d{9}\z";
        string mensageTelefono = "El telefono debe de ser de 3 digitos";

        string patronNumCuenta = @"^\d{20}\z";
        string mensageNumCuenta = "El numero de cuenta corriente deben de ser 20 digitos";

        string patronDireccion = @"^[\w\s]+$";
        string mensageDireccion = "Escribe 1 letra aunque sea";

        public Form1()
        {
            InitializeComponent();
            banco = new Banco();
            MuestraBanco();
            btnEliminarClicked = false;
            btnModificarClicked = false;
        }

        private void MuestraBanco()
        {
            banco = CargaBanco();

            btnEliminar.Enabled = banco.Clientes.Count >= 1;
            btnModificar.Enabled = banco.Clientes.Count >= 1;

            DataSet set = new DataSet();
            DataTable dt = new DataTable();

            dt.Columns.Add("DNI");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Direccion");
            dt.Columns.Add("Edad");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Numero Cuenta Corriente");

            foreach (Cliente c in banco.Clientes)
            {
                comboBox1.Items.Add(c.Nombre);
                dt.Rows.Add(c.DNI, c.Nombre, c.Direccion, c.Edad, c.Telefono, c.NumCuentaCorriente.ToString("F0"));
            }


            set.Tables.Add(dt);
            dgwBanco.DataSource = set.Tables[0];
        }

        private Banco CargaBanco()
        {
            if (!File.Exists(fichero))
            {
                banco = new Banco();
                File.Create(fichero);
                return banco;
            }

            using (var stream = new FileStream(fichero, FileMode.Open))
            {
                var serializer = new XmlSerializer(typeof(Banco));
                return (Banco)serializer.Deserialize(stream);
            }
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {

            if (!ValidaCampos()) {
                MessageBox.Show("Los cambos son invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string dni = txtDni.Text;
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            int edad = int.Parse(txtEdad.Text);
            int telefono = int.Parse(txtTelefono.Text);
            var numCuentaCorriente = float.Parse(txtNumeroCuenta.Text);


            Cliente c = new Cliente(dni, nombre, direccion, edad, telefono, numCuentaCorriente);

            banco.Clientes.Add(c);

            SetXmlBanco();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (btnEliminarClicked)
            {
                string DniCliente = txtDni.Text;

                Cliente cEliminar = banco.Clientes.FirstOrDefault(c => c.DNI.Equals(DniCliente));
                if (cEliminar == null)
                {
                    MessageBox.Show("No se ha encontrado el cliente a eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                banco.Clientes.Remove(cEliminar);

                SetXmlBanco();

                btnEliminarClicked = false;
                SetBtnEnabled(true);
                ClearCampos();
                return;
            }

            using (FormEliminar f = new FormEliminar(banco))
            {
                f.ShowDialog();

                string DniCliente = f.DniClienteEliminar;

                Cliente cEliminar = banco.Clientes.FirstOrDefault(c => c.DNI.Equals(DniCliente));

                if (cEliminar == null)
                {
                    MessageBox.Show("No se ha encontrado el cliente a eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MostrarClienteEliminar(cEliminar);
                btnEliminarClicked = true;
            }
        }

        private void ClearCampos()
        {
            txtDni.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtEdad.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtNumeroCuenta.Text = String.Empty;
            txtTelefono.Text = String.Empty;
        }

        private void SetXmlBanco()
        {

            XmlSerializer serializer = new XmlSerializer(typeof(Banco));

            using (FileStream fileStream = new FileStream(fichero, FileMode.Create))
            {
                serializer.Serialize(fileStream, banco);
            }

            MuestraBanco();

        }

        private void MostrarClienteEliminar(Cliente cEliminar)
        {
            SetCampos(cEliminar);

            SetBtnEnabled(false);
        }

        private void SetBtnEnabled(Boolean enabled)
        {
            txtDni.Enabled = enabled;
            txtDireccion.Enabled = enabled;
            txtEdad.Enabled = enabled;
            txtNombre.Enabled = enabled;
            txtNumeroCuenta.Enabled = enabled;
            txtTelefono.Enabled = enabled;

            btnAddCliente.Enabled = enabled;
            btnModificar.Enabled = enabled;

        }

        private void SetCampos(Cliente cEliminar)
        {
            txtDni.Text = cEliminar.DNI;
            txtDireccion.Text = cEliminar.Direccion;
            txtEdad.Text = cEliminar.Edad.ToString();
            txtNombre.Text = cEliminar.Nombre;
            txtNumeroCuenta.Text = cEliminar.NumCuentaCorriente.ToString("F0");
            txtTelefono.Text = cEliminar.Telefono.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificarClicked)
            {
                if (!ValidaCampos())
                {
                    MessageBox.Show("Los cambos son invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string DniCliente = txtDni.Text;

                Cliente cModificar = banco.Clientes.FirstOrDefault(c => c.DNI.Equals(DniCliente));
                if (cModificar == null)
                {
                    MessageBox.Show("No se ha encontrado el cliente a modificar", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cModificar.Nombre = txtNombre.Text;
                cModificar.Direccion = txtDireccion.Text;
                cModificar.Edad = int.Parse(txtEdad.Text);
                cModificar.Telefono = int.Parse(txtTelefono.Text);
                cModificar.NumCuentaCorriente = float.Parse(txtNumeroCuenta.Text);

                //banco.Clientes = nuevoBanco;

                SetXmlBanco();

                btnModificarClicked = false;
                SetBtnEnabled(true);
                btnEliminar.Enabled = true;
                ClearCampos();
                return;
            }

            using (FormModificar f = new FormModificar(banco))
            {
                f.ShowDialog();

                string DniCliente = f.DniClienteModificar;

                Cliente cModificar = banco.Clientes.FirstOrDefault(c => c.DNI.Equals(DniCliente));

                if (cModificar == null)
                {
                    MessageBox.Show("No se ha encontrado el cliente a modificar", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MostrarClienteModificar(cModificar);
                btnModificarClicked = true;
            }
        }

        private Cliente SetCliente()
        {
            return new Cliente()
            {
                Direccion = txtDireccion.Text,
                DNI = txtDni.Text,
                Edad = int.Parse(txtEdad.Text),
                Nombre = txtNombre.Text,
                NumCuentaCorriente = float.Parse(txtNumeroCuenta.Text),
                Telefono = int.Parse(txtTelefono.Text),
            };
        }

        private void MostrarClienteModificar(Cliente cModificar)
        {
            SetCampos(cModificar);
            SetBtnEnabledModify();
        }

        private void SetBtnEnabledModify()
        {
            txtDni.Enabled = false;
            btnAddCliente.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void txtDni_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidaCampo(patronDni, mensageDni, txtDni);
        }

        private void txtNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidaCampo(patronNombre, mensageNombre, txtNombre);
        }

        private void txtDireccion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidaCampo(patronDireccion, mensageDireccion, txtDireccion);
        }

        private void txtEdad_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidaCampo(patronEdad, mensageEdad, txtEdad);
        }

        private void txtTelefono_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidaCampo(patronTelefono, mensageTelefono, txtTelefono);
        }

        private void txtNumeroCuenta_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidaCampo(patronNumCuenta, mensageNumCuenta, txtNumeroCuenta);
        }

        private bool ValidaCampo(string patron, string mensage, TextBox textBox)
        {
            if (!Regex.IsMatch(textBox.Text, patron))
            {
                errorProvider.SetError(textBox, mensage);
                return false;
            }
            else
            {
                errorProvider.SetError(textBox, "");
                return true;
            }
        }

        private bool ValidaCampos()
        {
            bool valid = true;
            valid &= ValidaCampo(patronDni, mensageDni, txtDni);
            valid &= ValidaCampo(patronEdad, mensageEdad, txtEdad);
            valid &= ValidaCampo(patronNombre, mensageNombre, txtNombre);
            valid &= ValidaCampo(patronTelefono, mensageTelefono, txtTelefono);
            valid &= ValidaCampo(patronNumCuenta, mensageNumCuenta, txtNumeroCuenta);
            valid &= ValidaCampo(patronDireccion, mensageDireccion, txtDireccion);

            return valid;
        }
    }
}
