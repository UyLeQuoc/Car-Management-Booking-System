﻿using BusinessObjects;
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
            frmUserManagement.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }



        private void btnBrandModel_Click(object sender, EventArgs e)
        {
            frmModelBrandManagement frmModelBrandManagement = new frmModelBrandManagement();
            frmModelBrandManagement.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCarManagement frmCarManagement = new frmCarManagement();
            frmCarManagement.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginUser = null;
            frmViewCar frmViewCar = new frmViewCar();
            frmViewCar.Closed += (s, args) => this.Close();
            this.Hide();
            frmViewCar.Show();
        }
    }
}
