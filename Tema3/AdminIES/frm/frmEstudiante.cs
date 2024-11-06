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

            if (!dataGridView1.Columns.Contains("Foto"))
            {
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.Name = "Foto";
                imgColumn.HeaderText = "Foto";
                dataGridView1.Columns.Add(imgColumn);
            }

            dataGridView1.Rows.Clear();

            foreach (DataRow row in dtEstudiantes.Rows)
            {
                Image image = Base64ToImage(row["foto"].ToString());

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

            //string nombreEstudiante, string primerApellido, string segundoApellido, int ciclo, string email, byte[] fotoEstudiante
            Estudiante estudiante = new Estudiante(txtNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, idCiclo, txtCorreo.Text, base64Image);

            estudianteDDL = new EstudianteDDL();
            estudianteDDL.Agregar(estudiante);

            recargaDataGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtClave.Text)) return;

        }
    }
}
