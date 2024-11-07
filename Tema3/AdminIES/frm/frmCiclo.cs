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
            DataTable dtCiclos = cicloddl.MostrarCiclos().Tables[0];

            dataGridView1.Rows.Clear();

            foreach (DataRow row in dtCiclos.Rows)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["id"].Value = row["id"].ToString();
                dataGridView1.Rows[rowIndex].Cells["nombre"].Value = row["nombre"].ToString();
            }
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
            if (String.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Debes selecionar una celda");
                return;
            }

            CicloDDL cicloDDL = new CicloDDL();

            if (!cicloddl.Actualizar(txtId.Text, txtNombreCiclo.Text))
            {
                MessageBox.Show("Ha habido un error en la actualizacion");
                return;
            }

            recargaDataGrid();
            btnCancelar_Click(null, null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txtId.Text = id;

                Modificar(e);
            }
        }

        private void Modificar(DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtNombreCiclo.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
        }
    }
}
