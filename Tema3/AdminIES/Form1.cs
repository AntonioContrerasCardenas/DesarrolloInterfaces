using AdminIES.frm;

namespace AdminIES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCiclos_Click(object sender, EventArgs e)
        {
            frmCiclo frmCiclo = new();
            frmCiclo.ShowDialog();
        }
    }
}
