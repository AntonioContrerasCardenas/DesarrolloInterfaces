using System.Data;
using System.Xml.Serialization;
using U3_E9_Serializacion_XML.Clases;

namespace U3_E9_Serializacion_XML
{
    public partial class Form1 : Form
    {
        private string fichero = "banco.xml";
        private Banco banco { get; set; }
        public Form1()
        {
            InitializeComponent();
            banco = new Banco();
            banco = CargaBanco();
            MuestraBanco();
        }

        private void MuestraBanco()
        {
            DataSet set = new DataSet();
            DataTable dt = new DataTable();

            dt.Columns.Add("DNI");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Direccion");
            dt.Columns.Add("Edad");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Numero Cuenta Corriente");

            foreach (Cliente cliente in banco.Clientes) {
                dt.Rows.Add(cliente);
            }

            set.Tables.Add(dt);
            dgwBanco.DataSource = set.Tables[0];
        }

        private Banco CargaBanco()
        {
            if (File.Exists(fichero))
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

            XmlSerializer serializer = new XmlSerializer(typeof(Cliente));

            using(FileStream fileStream = new FileStream(fichero, FileMode.Create))
            {
                serializer.Serialize(fileStream, c);
            }
        }
    }
}
