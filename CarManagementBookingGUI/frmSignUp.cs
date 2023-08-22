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

namespace CarManagementBookingGUI
{
    public partial class frmSignUp : Form
    {
        IUserRepository _userRepo = new UserRepository();
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

        private void btSignup_Click(object sender, EventArgs e)
        {
            IEnumerable<TblUser> listUser = _userRepo.GetAllUsers();
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
                    MessageBox.Show("Email is not valid!", "Sign up",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkValidation = false;
                }

                if (fullName.Length > 256)
                {
                    MessageBox.Show("Fullname is too long!", "Sign up",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkValidation = false;
                }

                if (address.Length > 256)
                {
                    MessageBox.Show("Address is too long!", "Sign up",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkValidation = false;
                }

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
                else
                {
                    foreach (var tmp in listUser)
                    {
                        if (tmp.Email.Equals(txtEmail.Text))
                        {
                            MessageBox.Show("Email is already exist!",
                                "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            checkValidation = false;
                            break;
                        }
                    }
                }

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
                        _userRepo.AddAUser(user);
                        MessageBox.Show("Sign up success!", "Sign up", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Hide();
                        frmLogin frmLogin = new frmLogin();
                        frmLogin.ShowDialog();
                        this.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sign up error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            frmViewCar frmViewCar = new frmViewCar() 
            {
                GetListOrderinCreate = GetListOrderinSignUp,
                GetCountinView = GetCountinSignUp,
                checkEmptyinView = checkEmptyinSignUp,
            };
            frmViewCar.Show();
            Close();
        }
    }
}
