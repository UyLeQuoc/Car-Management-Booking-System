using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagementBookingGUI
{
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCarManagement frm = new frmCarManagement();
            frm.ShowDialog();
            this.Close();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookingManagement frm = new frmBookingManagement();
            frm.ShowDialog();
            this.Close();
        }
    }
}
