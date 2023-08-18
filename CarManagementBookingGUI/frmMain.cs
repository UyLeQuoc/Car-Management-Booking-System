using BusinessObjects;
using Repositories;
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
        IUserRepository userRepository = new UserRepository();
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
            LoadProfile(loginUser.UserId.ToString());
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            TblUser tblUser = userRepository.GetAUser(loginUser.UserId);

            frmUserDetail frmUserDetail = new frmUserDetail
            {
                UserRepository = userRepository,
                InsertOrUpdate = false,
                tblUser = tblUser,
                Text = "View profile",
                loginUser = loginUser
            };
            if(frmUserDetail.ShowDialog() == DialogResult.OK)
            {
                LoadProfile(tblUser.UserId.ToString());
            }
        }

        private void LoadProfile(string id)
        {
            txtWelcomeName.Text = userRepository?.GetAUser(id)?.FullName?.ToString();
        }
    }
}
