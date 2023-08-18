namespace CarManagementBookingGUI
{
    partial class frmUserManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grFilter = new System.Windows.Forms.GroupBox();
            cboSearchRole = new System.Windows.Forms.ComboBox();
            lbSearchCountry = new System.Windows.Forms.Label();
            grSearch = new System.Windows.Forms.GroupBox();
            radioByName = new System.Windows.Forms.RadioButton();
            radioByID = new System.Windows.Forms.RadioButton();
            txtSearchValue = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            lbSearch = new System.Windows.Forms.Label();
            dgvMemberList = new System.Windows.Forms.DataGridView();
            btnDelete = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            lbRole = new System.Windows.Forms.Label();
            txtAddress = new System.Windows.Forms.TextBox();
            lbCity = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            lbPassword = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lbEmail = new System.Windows.Forms.Label();
            txtFullname = new System.Windows.Forms.TextBox();
            lbFullname = new System.Windows.Forms.Label();
            txtUserID = new System.Windows.Forms.TextBox();
            lbID = new System.Windows.Forms.Label();
            cbRole = new System.Windows.Forms.ComboBox();
            grFilter.SuspendLayout();
            grSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // grFilter
            // 
            grFilter.Controls.Add(cboSearchRole);
            grFilter.Controls.Add(lbSearchCountry);
            grFilter.Location = new System.Drawing.Point(376, 203);
            grFilter.Name = "grFilter";
            grFilter.Size = new System.Drawing.Size(260, 55);
            grFilter.TabIndex = 43;
            grFilter.TabStop = false;
            grFilter.Text = "Filter";
            // 
            // cboSearchRole
            // 
            cboSearchRole.Location = new System.Drawing.Point(77, 18);
            cboSearchRole.Name = "cboSearchRole";
            cboSearchRole.Size = new System.Drawing.Size(165, 23);
            cboSearchRole.TabIndex = 0;
            cboSearchRole.SelectedIndexChanged += cboSearchRole_SelectedIndexChanged;
            // 
            // lbSearchCountry
            // 
            lbSearchCountry.AutoSize = true;
            lbSearchCountry.Location = new System.Drawing.Point(27, 21);
            lbSearchCountry.Name = "lbSearchCountry";
            lbSearchCountry.Size = new System.Drawing.Size(35, 15);
            lbSearchCountry.TabIndex = 18;
            lbSearchCountry.Text = "Roles";
            // 
            // grSearch
            // 
            grSearch.Controls.Add(radioByName);
            grSearch.Controls.Add(radioByID);
            grSearch.Controls.Add(txtSearchValue);
            grSearch.Controls.Add(btnSearch);
            grSearch.Controls.Add(lbSearch);
            grSearch.Location = new System.Drawing.Point(31, 169);
            grSearch.Name = "grSearch";
            grSearch.Size = new System.Drawing.Size(289, 89);
            grSearch.TabIndex = 42;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            // 
            // radioByName
            // 
            radioByName.AutoSize = true;
            radioByName.Checked = true;
            radioByName.Location = new System.Drawing.Point(202, 55);
            radioByName.Name = "radioByName";
            radioByName.Size = new System.Drawing.Size(73, 19);
            radioByName.TabIndex = 23;
            radioByName.TabStop = true;
            radioByName.Text = "By Name";
            radioByName.UseVisualStyleBackColor = true;
            // 
            // radioByID
            // 
            radioByID.AutoSize = true;
            radioByID.Location = new System.Drawing.Point(202, 25);
            radioByID.Name = "radioByID";
            radioByID.Size = new System.Drawing.Size(52, 19);
            radioByID.TabIndex = 22;
            radioByID.TabStop = true;
            radioByID.Text = "By ID";
            radioByID.UseVisualStyleBackColor = true;
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new System.Drawing.Point(64, 21);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new System.Drawing.Size(118, 23);
            txtSearchValue.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(64, 55);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(75, 23);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new System.Drawing.Point(16, 24);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new System.Drawing.Size(42, 15);
            lbSearch.TabIndex = 16;
            lbSearch.Text = "Search";
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new System.Drawing.Point(12, 280);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowTemplate.Height = 25;
            dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new System.Drawing.Size(650, 268);
            dgvMemberList.TabIndex = 41;
            dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(526, 169);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(109, 23);
            btnDelete.TabIndex = 40;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(376, 169);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(109, 23);
            btnNew.TabIndex = 39;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Location = new System.Drawing.Point(385, 109);
            lbRole.Name = "lbRole";
            lbRole.Size = new System.Drawing.Size(30, 15);
            lbRole.TabIndex = 36;
            lbRole.Text = "Role";
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(451, 65);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(184, 23);
            txtAddress.TabIndex = 35;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new System.Drawing.Point(385, 68);
            lbCity.Name = "lbCity";
            lbCity.Size = new System.Drawing.Size(49, 15);
            lbCity.TabIndex = 34;
            lbCity.Text = "Address";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(451, 24);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(184, 23);
            txtPassword.TabIndex = 33;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(385, 27);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(57, 15);
            lbPassword.TabIndex = 32;
            lbPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(135, 106);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(184, 23);
            txtEmail.TabIndex = 30;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(31, 109);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(36, 15);
            lbEmail.TabIndex = 29;
            lbEmail.Text = "Email";
            // 
            // txtFullname
            // 
            txtFullname.Location = new System.Drawing.Point(135, 65);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new System.Drawing.Size(184, 23);
            txtFullname.TabIndex = 28;
            // 
            // lbFullname
            // 
            lbFullname.AutoSize = true;
            lbFullname.Location = new System.Drawing.Point(31, 68);
            lbFullname.Name = "lbFullname";
            lbFullname.Size = new System.Drawing.Size(56, 15);
            lbFullname.TabIndex = 27;
            lbFullname.Text = "Fullname";
            // 
            // txtUserID
            // 
            txtUserID.Location = new System.Drawing.Point(135, 24);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new System.Drawing.Size(184, 23);
            txtUserID.TabIndex = 26;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new System.Drawing.Point(31, 27);
            lbID.Name = "lbID";
            lbID.Size = new System.Drawing.Size(44, 15);
            lbID.TabIndex = 25;
            lbID.Text = "User ID";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "Staff", "Member" });
            cbRole.Location = new System.Drawing.Point(451, 109);
            cbRole.Name = "cbRole";
            cbRole.Size = new System.Drawing.Size(184, 23);
            cbRole.TabIndex = 44;
            // 
            // frmUserManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(677, 560);
            Controls.Add(cbRole);
            Controls.Add(grFilter);
            Controls.Add(grSearch);
            Controls.Add(dgvMemberList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(lbRole);
            Controls.Add(txtAddress);
            Controls.Add(lbCity);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtFullname);
            Controls.Add(lbFullname);
            Controls.Add(txtUserID);
            Controls.Add(lbID);
            Name = "frmUserManagement";
            Text = "frmUserManagement";
            Load += frmUserManagement_Load;
            grFilter.ResumeLayout(false);
            grFilter.PerformLayout();
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.GroupBox grFilter;
        private System.Windows.Forms.ComboBox cboSearchRole;
        private System.Windows.Forms.Label lbSearchCountry;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.RadioButton radioByName;
        private System.Windows.Forms.RadioButton radioByID;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.ComboBox cbRole;
    }
}