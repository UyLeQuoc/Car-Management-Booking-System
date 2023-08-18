using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

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
            if(loginUser.RoleId.Equals("Member"))
            {
                cbRole.Visible = false;
            }
            if (InsertOrUpdate)
            {
                btnAdd.Text = "Add";
                cbRole.SelectedIndex = 0;
            }
            else
            {
                btnAdd.Text = "Update";
                txtFullname.Text = tblUser.FullName.ToString();
                txtAddress.Text = tblUser.Address.ToString();
                txtEmail.Text = tblUser.Email.ToString();
                txtPassword.Text = tblUser.Password.ToString();
                txtConfirm.Text = tblUser.Password.ToString();
                cbRole.Text = tblUser.RoleId.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool checkValidation = true;
            var emailValidation = new EmailAddressAttribute();

            string email = txtEmail.Text;
            string fullName = txtFullname.Text;
            string address = txtAddress.Text;
            string password = txtPassword.Text;
            string confirm = txtConfirm.Text;


            // validation
            // email validation
            try
            {
                bool checkEmail = emailValidation.IsValid(email);
                if (checkEmail == false)
                {
                    MessageBox.Show("Email is not valid!", "Create User",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkValidation = false;
                }

                if (fullName.Length > 256)
                {
                    MessageBox.Show("Fullname is too long!", "Create User",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkValidation = false;
                }

                if (address.Length > 256)
                {
                    MessageBox.Show("Address is too long!", "Create User",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkValidation = false;
                }

                if (password.Length < 1 || password.Length > 26)
                {
                    MessageBox.Show("Password is between [1, 25]",
                        "Create User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkValidation = false;
                }

                if (!confirm.Equals(password))
                {
                    MessageBox.Show("Passwords do not match!",
                        "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkValidation = false;
                }

                if (InsertOrUpdate)
                {
                    if (checkValidation)
                    {
                        TblUser user = new TblUser()
                        {
                            FullName = fullName,
                            Email = email,
                            Password = password,
                            Address = address,
                            RoleId = cbRole.Text,
                            IsDeleted = 0
                        };
                        if (MessageBox.Show("Confirm to create a user?", "Create user", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            // sign up a user
                            UserRepository.AddAUser(user);
                            MessageBox.Show("Create user success!", "Create user", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            Close();
                        }
                    }
                }
                else
                {
                    if (checkValidation)
                    {
                        TblUser user = new TblUser()
                        {
                            UserId = tblUser.UserId,
                            FullName = fullName,
                            Email = email,
                            Password = password,
                            Address = address,
                            RoleId = cbRole.Text,
                            IsDeleted = 0
                        };
                        if (MessageBox.Show("Confirm to update a user?", "Update user", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            // sign up a user
                            UserRepository.UpdateAUser(user);
                            MessageBox.Show("Update user success!", "Update user", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                string msg = InsertOrUpdate ? "Insert User Error" : "Update User Error";
                MessageBox.Show(ex.Message, msg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

    }
}
