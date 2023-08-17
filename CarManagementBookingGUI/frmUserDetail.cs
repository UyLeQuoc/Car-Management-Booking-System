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
    public partial class frmUserDetail : Form
    {
        public bool InsertOrUpdate { get; set; }
        public IUserRepository UserRepository { get; set; }
        public TblUser tblUser { get; set; }
        public TblUser loginUser { get; set; }

        public frmUserDetail()
        {
            InitializeComponent();
        }

        private void frmUserDetail_Load(object sender, EventArgs e)
        {
            txtUserID.Enabled = false;
            if (InsertOrUpdate)
            {
                txtUserID.Enabled = true;
                btnAdd.Text = "Add";
                cbRole.SelectedIndex = 0;
            }
            else
            {
                btnAdd.Text = "Update";
                txtUserID.Enabled = false;

                txtUserID.Text = tblUser.UserId.ToString();
                txtFullname.Text = tblUser.FullName.ToString();
                txtAddress.Text = tblUser.Address.ToString();
                txtEmail.Text = tblUser.Email.ToString();
                txtPassword.Text = tblUser.Password.ToString();
                cbRole.Text = tblUser.RoleId.ToString();
            }
        }
    }
}
