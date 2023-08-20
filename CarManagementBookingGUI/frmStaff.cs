using BusinessObjects;
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
        public TblUser curUser;

        public frmStaff()
        {
            InitializeComponent();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            frmCarManagement frm = new frmCarManagement();
            frm.ShowDialog();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            frmBookingManagement frm = new frmBookingManagement();
            frm.ShowDialog();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Text = curUser.FullName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewCar frm = new frmViewCar();
            frm.ShowDialog();
            this.Close();
        }
    }
}
