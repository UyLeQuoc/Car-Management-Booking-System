using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObjects;
using Microsoft.Extensions.Configuration;
using Repositories;

namespace CarManagementBookingGUI
{
    public partial class frmLogin : Form
    {
        IUserRepository _userRepo = new UserRepository();
        private static readonly string ADMIN_ROLE = "Admin";
        private static readonly string STAFF_ROLE = "Staff";
        private static readonly string MEMBER_ROLE = "Member";

        public frmLogin()
        {
            InitializeComponent();
        }
        public Dictionary<TblBookingDetail, TblCar> GetListOrderinLogin { get; set; }
        public int checkEmptyinLogin { get; set; }
        public int GetCountinLogin { get; set; }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btSignin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            try
            {
                TblUser loginUser = _userRepo.checkLogin(email, password);
                if (loginUser != null)
                {
                    // phan quyen cho tung role
                    if (ADMIN_ROLE.Equals(loginUser.RoleId))
                    {
                        frmMain frmMain = new frmMain
                        {
                            loginUser = loginUser
                        };
                        frmMain.Show();
                        this.Hide();
                        frmMain.FormClosed += (s, args) => this.Close();
                    }
                    else if (STAFF_ROLE.Equals(loginUser.RoleId))
                    {
                        frmStaff frm = new frmStaff
                        {
                            curUser = loginUser
                        };
                        frm.Show();
                        this.Hide();
                        frm.FormClosed += (s, args) => this.Close();
                    }
                    else if (MEMBER_ROLE.Equals(loginUser.RoleId))
                    {
                        Hide();
                        frmViewCar frmViewCar = new frmViewCar()
                        {
                            GetInfoUser = loginUser,
                            GetCountinView = GetCountinLogin,
                            GetListOrderinCreate = GetListOrderinLogin,
                            checkEmptyinView = checkEmptyinLogin,
                        };
                        frmViewCar.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Your role is not supported!", "Login failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect email or password!", "Login failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sign in error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSignup_Click(object sender, EventArgs e)
        {
            frmSignUp frmSignUp = new frmSignUp()
            {
                GetListOrderinSignUp = GetListOrderinLogin,
                GetCountinSignUp = GetCountinLogin,
                checkEmptyinSignUp = checkEmptyinLogin,
            };
            frmSignUp.ShowDialog();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Hide();
            frmViewCar frmViewCar = new frmViewCar() 
            {
                GetListOrderinCreate = GetListOrderinLogin,
                GetCountinView = GetCountinLogin,
                checkEmptyinView= checkEmptyinLogin,
            };
            frmViewCar.ShowDialog();
            Close();
        }
    }
}
