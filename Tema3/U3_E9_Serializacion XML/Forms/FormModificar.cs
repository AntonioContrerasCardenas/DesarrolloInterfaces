using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U3_E9_Serializacion_XML.Clases;

namespace U3_E9_Serializacion_XML.Forms
{
    public partial class FormModificar : Form
    {
        public Banco Banco { get; set; }
        public string DniClienteModificar { get; set; }

        public FormModificar(Banco banco)
        {
            InitializeComponent();
            Banco = banco;
            RellenarCmbx();
        }

        private void RellenarCmbx()
        {
            cmbClientes.Items.Clear();
            foreach (Cliente c in Banco.Clientes)
            {
                this.cmbClientes.Items.Add(c.DNI);
            }
            if (cmbClientes.Items.Count > 0)
            {
                cmbClientes.SelectedIndex = 0;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cmbClientes == null)
            {
                return;
            }

            DniClienteModificar = cmbClientes.SelectedItem.ToString();

            Close();
        }
    }
}
