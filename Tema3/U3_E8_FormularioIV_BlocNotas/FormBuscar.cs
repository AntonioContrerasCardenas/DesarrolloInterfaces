using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3_E8_FormularioIV_BlocNotas
{
    public partial class FormBuscar : Form
    {
        public string palabraABuscar { get; set; }

        public FormBuscar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            palabraABuscar = this.txtBuscar.Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
