using AdminIES.DDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminIES.frm
{
    public partial class frmCiclo : Form
    {
        public frmCiclo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CicloDDL cicloDDL = new CicloDDL();
            cicloDDL.Agregar(txtNombreCiclo.Text);
        }
    }
}
