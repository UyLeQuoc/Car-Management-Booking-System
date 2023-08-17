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
    public partial class frmMain : Form
    {
        public TblUser loginUser = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnUserMangement_Click(object sender, EventArgs e)
        {
            frmUserManagement frmUserManagement = null;
            frmUserManagement = new frmUserManagement
            {
                loginUser = loginUser
            };
            frmUserManagement.Closed += (s, args) => this.Close();
            this.Hide();
            frmUserManagement.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtWelcomeName.Text = loginUser?.FullName?.ToString();
        }
    }
}
