using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaSalones
{
    public partial class FrmReservaSalon : Form
    {
        public FrmReservaSalon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void chkRequiereHabitaciones_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTipoEvento.SelectedItem.ToString())
            {
                case "Congreso":
                    nudNumeroJornadas.Enabled = true;
                    chkRequiereHabitaciones.Enabled = true;

                    rdbMesaRectangular.Enabled = false;
                    rdbMesaRedonda.Enabled = false;
                    nudComensalesPorMesa.Enabled = false;
                    break;

                case "Banquete":
                    nudNumeroJornadas.Enabled = false;
                    chkRequiereHabitaciones.Enabled = false;

                    rdbMesaRectangular.Enabled = true;
                    rdbMesaRedonda.Enabled = true;
                    nudComensalesPorMesa.Enabled = true;
                    break;

                case "Jornada":
                    nudNumeroJornadas.Enabled = false;
                    chkRequiereHabitaciones.Enabled = false;

                    rdbMesaRectangular.Enabled = false;
                    rdbMesaRedonda.Enabled = false;
                    nudComensalesPorMesa.Enabled = false;
                    break;
            }
        }

        private void FrmReservaSalon_Load(object sender, EventArgs e)
        {

        }
    }
}
