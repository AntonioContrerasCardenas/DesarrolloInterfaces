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
        CicloDDL cicloddl;
        public frmCiclo()
        {
            cicloddl = new CicloDDL();
            InitializeComponent();
            recargaDataGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombreCiclo.Text))
            {
                MessageBox.Show("Debes rellena el nombre del ciclo");
                return;
            }

            CicloDDL cicloDDL = new CicloDDL();
            cicloDDL.Agregar(txtNombreCiclo.Text);
            recargaDataGrid();
        }


        public void recargaDataGrid()
        {
            dataGridView1.DataSource = cicloddl.MostrarCiclos().Tables[0];
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtNombreCiclo.Text = string.Empty;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Debes introducir el id a eliminar");
                return;
            }
            CicloDDL cicloDdl = new CicloDDL();

            if (!cicloddl.Eliminar(txtId.Text))
            {
                MessageBox.Show("Ha habido un error en el borrado");
                return;
            }

            recargaDataGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtId.Text) || String.IsNullOrEmpty(txtNombreCiclo.Text))
            {
                MessageBox.Show("Debes introducir el id y nombre del campo a modificar");
                return;
            }

            CicloDDL cicloDDL = new CicloDDL();

            if (!cicloddl.Actualizar(txtId.Text, txtNombreCiclo.Text))
            {
                MessageBox.Show("Ha habido un error en la actualizacion");
                return;
            }

            recargaDataGrid();
        }
    }
}
