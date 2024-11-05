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
        public frmEstudiante()
        {
            estudianteDDL = new EstudianteDDL();
            InitializeComponent();
            RellenaCmbx();
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
                //imagaenByte = memoryStream.ToArray();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //string nombreEstudiante, string primerApellido, string segundoApellido, int ciclo, string email
            int idCiclo = (int)cmbCiclo.SelectedValue;
            MessageBox.Show($"{idCiclo}");
            // Estudiante estudiante = new Estudiante(txtNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, cmbCiclo.);
        }
    }
}
