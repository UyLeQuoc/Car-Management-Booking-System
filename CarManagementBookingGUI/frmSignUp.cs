using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CarManagementBookingGUI
{
    public partial class frmSignUp : Form
    {
        IUserRepository userRepo = new UserRepository();
        public frmSignUp()
        {
            InitializeComponent();
        }
        public Dictionary<TblBookingDetail, TblCar> GetListOrderinSignUp { get; set; }
        public int checkEmptyinSignUp { get; set; }
        public int GetCountinSignUp { get; set; }
        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            frmViewCar frmViewCar = new frmViewCar()
            {
                GetListOrderinCreate = GetListOrderinSignUp,
                GetCountinView = GetCountinSignUp,
                checkEmptyinView = checkEmptyinSignUp,
            };
            frmViewCar.ShowDialog();
            Close();
        }

        private void btSignup_Click(object sender, EventArgs e)
        {
            IEnumerable<TblUser> listUser = userRepo.GetAllUsers();
            bool checkValidation = true;
            var emailValidation = new EmailAddressAttribute();

            string email = txtEmail.Text;
            string fullName = txtFullname.Text;
            string address = txtAddress.Text;
            string password = txtPassword.Text;
            string confirm = txtConfirm.Text;
            // validation
            // email validation

            bool checkEmail = emailValidation.IsValid(email);
            //if (checkEmail == false)
            //{
            //    MessageBox.Show("Email is not valid!", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    checkValidation = false;
            //}
            //if (fullName.Length > 256)
            //{
            //    MessageBox.Show("Fullname is too long!", "Sign up",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    checkValidation = false;
            //}

            //if (address.Length > 256)
            //{
            //    MessageBox.Show("Address is too long!", "Sign up",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    checkValidation = false;
            //}

            if (password.Length < 1 || password.Length > 26)
            {
                MessageBox.Show("Password is between [1, 25]",
                    "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkValidation = false;
            }

            if (!confirm.Equals(password))
            {
                MessageBox.Show("Passwords do not match!",
                    "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkValidation = false;
            }
            //else
            //{
            //    foreach (var tmp in listUser)
            //    {
            //        checkValidation = false;

            //        if (tmp.Email.Equals(txtEmail.Text))
            //        {
            //            MessageBox.Show("Email is already exist!",
            //                "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            break;
            //        }
            //    }
            //}

            if (checkValidation)
            {
                TblUser user = new TblUser()
                {
                    FullName = fullName,
                    Email = email,
                    Password = password,
                    Address = address,
                    RoleId = "Member",
                    IsDeleted = 0
                };
                if (MessageBox.Show("Confirm to sign up?", "Sign up", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // sign up a user
                    userRepo.AddAUser(user);
                    MessageBox.Show("Sign up success!", "Sign up", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Hide();
                    frmLogin frmLogin = new frmLogin();
                    frmLogin.ShowDialog();
                    Close();

                }


            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtFullname.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirm.Text = string.Empty;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            IEnumerable<TblUser> listUser = userRepo.GetAllUsers();
            bool checkValidation = true;
            var emailValidation = new EmailAddressAttribute();

            bool checkEmail = emailValidation.IsValid(txtEmail.Text.Trim());
            if (txtEmail.Text.Trim().Length == 0 ||
            txtFullname.Text.Trim().Length == 0 ||
            txtAddress.Text.Trim().Length == 0 ||
            txtPassword.Text.Trim().Length == 0 ||
            txtConfirm.Text.Trim().Length == 0)
            {
                MessageBox.Show("Do not allow Empty", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkValidation = false;
            }
            else if (checkEmail == false)
            {
                MessageBox.Show("Email is not valid!", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkValidation = false;
            }else if (txtFullname.Text.Trim().Length > 256)
            {
                MessageBox.Show("Fullname is too long!", "Sign up",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkValidation = false;
            }
            else if (txtAddress.Text.Trim().Length > 256)
            {
                MessageBox.Show("Address is too long!", "Sign up",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkValidation = false;
            }
            else if (txtPassword.Text.Trim().Length < 1 || txtPassword.Text.Trim().Length > 26)
            {
                MessageBox.Show("Password is between [1, 25]",
                    "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkValidation = false;
            }
            else if(!txtConfirm.Text.Equals(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Passwords do not match!",
                    "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkValidation = false;
            }
            else
            {
                foreach (var tmp in listUser)
                {
                    
                    if (tmp.Email.Equals(txtEmail.Text.Trim()))
                    {
                        checkValidation = false;
                        MessageBox.Show("Email is already exist!",
                            "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }
            if (checkValidation)
            {
                TblUser user = new TblUser()
                {
                    FullName = txtFullname.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    RoleId = "Member",
                    IsDeleted = 0
                };
                if (MessageBox.Show("Confirm to sign up?", "Sign up", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // sign up a user
                    userRepo.AddAUser(user);
                    MessageBox.Show("Sign up success!", "Sign up", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Hide();
                    frmLogin frmLogin = new frmLogin();
                    frmLogin.ShowDialog();
                    Close();

                }


            }
        }
    }
}
