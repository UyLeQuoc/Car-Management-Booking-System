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
    public partial class frmUserManagement : Form
    {
        public TblUser loginUser { get; set; }

        IUserRepository userRepository = new UserRepository();
        BindingSource source;


        public frmUserManagement()
        {
            InitializeComponent();
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            var list = userRepository.GetAllUsers();
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtUserID.DataBindings.Clear();
                txtFullname.DataBindings.Clear();
                txtAddress.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                cbRole.DataBindings.Clear();

                txtUserID.DataBindings.Add("Text", source, "UserId");
                txtFullname.DataBindings.Add("Text", source, "Fullname");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtAddress.DataBindings.Add("Text", source, "Address");
                cbRole.DataBindings.Add("Text", source, "RoleId");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmUserDetail frmUserDetail = new frmUserDetail
            {
                UserRepository = this.userRepository,
                InsertOrUpdate = true,
                Text = "Add new member",
                loginUser = this.loginUser,
            };

            if (frmUserDetail.ShowDialog() == DialogResult.OK)
            {
                LoadList();
                source.Position = source.Count - 1;
            }
        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TblUser tblUser = GetInfo();

            frmUserDetail frmUserDetail = new frmUserDetail
            {
                UserRepository = this.userRepository,
                InsertOrUpdate = false,
                tblUser = tblUser,
                Text = "Update user info"
            };

            if (frmUserDetail.ShowDialog() == DialogResult.OK)
            {
                LoadList();
                source.Position = source.Count - 1;
            }
        }

        private TblUser GetInfo()
        {
            TblUser user = null;
            try
            {
                user = new TblUser
                {
                    UserId = int.Parse(txtUserID.Text),
                    FullName = txtFullname.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    Password = txtPassword.Text,
                    RoleId = cbRole.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get User Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return user;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                TblUser tblUser = GetInfo();
                if (tblUser.UserId == loginUser.UserId)
                {
                    MessageBox.Show("You can't delete yourself!!", "Delete member", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show($"Do you really want to delete the user: \n" +
                    $"User ID: {tblUser.UserId}\n" +
                    $"FullName: {tblUser.FullName}\n" +
                    $"Email: {tblUser.Email}\n" +
                    $"City: {tblUser.Address}\n" +
                    $"Country: {tblUser.RoleId}", "Delete user", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        userRepository.DeleteAUser(tblUser);

                    LoadList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
