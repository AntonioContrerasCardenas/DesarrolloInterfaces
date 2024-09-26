namespace ReservaSalones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrirFormulario_Click(object sender, EventArgs e)
        {
            FrmReservaSalon frmReservaSalon = new FrmReservaSalon();
            frmReservaSalon.ShowDialog();
        }
    }
}
