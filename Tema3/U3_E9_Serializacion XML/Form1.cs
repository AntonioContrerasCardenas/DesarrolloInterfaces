using System.Data;
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
                dt.Rows.Add(c.DNI, c.Nombre, c.Direccion, c.Edad, c.Telefono, c.NumCuentaCorriente);
            }

            set.Tables.Add(dt);
            dgwBanco.DataSource = set.Tables[0];
        }

        private Banco CargaBanco()
        {
            if (!File.Exists(fichero))
            {
                banco = new Banco();
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

            string dni = txtDni.Text;
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            int edad = int.Parse(txtEdad.Text);
            int telefono = int.Parse(txtTelefono.Text);
            int numCuentaCorriente = int.Parse(txtNumeroCuenta.Text);


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

                List<Cliente> nuevoBanco = banco.Clientes.Where(c => !c.Equals(cEliminar)).ToList();

                banco.Clientes = nuevoBanco;

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
            btnEliminar.Enabled = enabled;
        }

        private void SetCampos(Cliente cEliminar)
        {
            txtDni.Text = cEliminar.DNI;
            txtDireccion.Text = cEliminar.Direccion;
            txtEdad.Text = cEliminar.Edad.ToString();
            txtNombre.Text = cEliminar.Nombre;
            txtNumeroCuenta.Text = cEliminar.NumCuentaCorriente.ToString();
            txtTelefono.Text = cEliminar.Telefono.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificarClicked)
            {
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
                cModificar.NumCuentaCorriente = int.Parse(txtNumeroCuenta.Text);

                //banco.Clientes = nuevoBanco;

                SetXmlBanco();

                btnModificarClicked = false;
                SetBtnEnabled(true);
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
                NumCuentaCorriente = int.Parse(txtNumeroCuenta.Text),
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
    }
}
