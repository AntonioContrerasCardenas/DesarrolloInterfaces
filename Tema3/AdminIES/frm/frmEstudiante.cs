using AdminIES.DDL;
using AdminIES.Model;
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
    public partial class frmEstudiante : Form
    {
        EstudianteDDL estudianteDDL;
        private byte[] imagaenByte;
        public frmEstudiante()
        {
            estudianteDDL = new EstudianteDDL();
            InitializeComponent();
            RellenaCmbx();
            recargaDataGrid();
            txtClave.Enabled = false;
        }

        private void RellenaCmbx()
        {
            cmbCiclo.DataSource = estudianteDDL.getCiclos().Tables[0];
            cmbCiclo.DisplayMember = "nombre";
            cmbCiclo.ValueMember = "id";
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccionar imagen";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromStream(selectorImagen.OpenFile());
                MemoryStream memoryStream = new MemoryStream();
                pictureBox1.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                imagaenByte = memoryStream.ToArray();
            }
        }

        public void recargaDataGrid()
        {
            DataTable dtEstudiantes = estudianteDDL.getEstudiantes().Tables[0];

            dataGridView1.Rows.Clear();

            foreach (DataRow row in dtEstudiantes.Rows)
            {
                Image image = row["foto"].ToString() == String.Empty ? null : Base64ToImage(row["foto"].ToString());

                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["id"].Value = row["id"].ToString();
                dataGridView1.Rows[rowIndex].Cells["nombre"].Value = row["nombre"].ToString();
                dataGridView1.Rows[rowIndex].Cells["primerApellido"].Value = row["primerapellido"].ToString();
                dataGridView1.Rows[rowIndex].Cells["segundoApellido"].Value = row["segundoapellido"].ToString();
                dataGridView1.Rows[rowIndex].Cells["email"].Value = row["email"].ToString();
                dataGridView1.Rows[rowIndex].Cells["foto"].Value = image;
            }
        }

        private Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idCiclo = (int)cmbCiclo.SelectedValue;

            string base64Image = Convert.ToBase64String(imagaenByte);

            Estudiante estudiante = new Estudiante(txtNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, idCiclo, txtCorreo.Text, base64Image);

            estudianteDDL = new EstudianteDDL();
            estudianteDDL.Agregar(estudiante);

            recargaDataGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtClave.Text))
            {
                MessageBox.Show("Seleccione un estudiante para modificar.");
                return;
            }

            string base64Image = pictureBox1.Image != null ? Convert.ToBase64String(imagaenByte) : null;

            Estudiante estudiante = new Estudiante(int.Parse(txtClave.Text), txtNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text,(int)cmbCiclo.SelectedValue, txtCorreo.Text, base64Image);

            if (!estudianteDDL.Modificar(estudiante))
            {
                MessageBox.Show("Error al modificar el estudiante.");
                return;
            }

            MessageBox.Show("Estudiante modificado exitosamente.");
            recargaDataGrid();

            btnCancelar_Click(null, null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txtClave.Text = id;

                Modificar(e);
            }
        }

        private void Modificar(DataGridViewCellEventArgs e)
        {
            txtClave.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            txtPrimerApellido.Text = dataGridView1.Rows[e.RowIndex].Cells["primerApellido"].Value.ToString();
            txtSegundoApellido.Text = dataGridView1.Rows[e.RowIndex].Cells["segundoApellido"].Value.ToString();
            txtCorreo.Text = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();

            if (dataGridView1.Rows[e.RowIndex].Cells["foto"].Value is Image image && image != null)
            {
                pictureBox1.Image = image;
                imagaenByte = ImageToByteArray(image);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private byte[] ImageToByteArray(Image i)
        {
            using (MemoryStream ms = new MemoryStream()) {
                i.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtClave.Text)) { return; }

            int idEstudiante = int.Parse(txtClave.Text);

            if (!estudianteDDL.Eliminar(idEstudiante))
            {
                MessageBox.Show($"No se ha podido eliminar el estudiante con id : {idEstudiante}");
            }

            MessageBox.Show($"Estudiante con id : {idEstudiante} eliminado con exito");
            recargaDataGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtClave.Text = String.Empty;
            txtCorreo.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtPrimerApellido.Text = String.Empty;
            txtSegundoApellido.Text = String.Empty;
            pictureBox1.Image = null;
            imagaenByte = [];
        }
    }
}
