namespace CarManagementBookingGUI
{
    partial class frmUserDetail
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
            btnCancel = new System.Windows.Forms.Button();
            cbRole = new System.Windows.Forms.ComboBox();
            lbRole = new System.Windows.Forms.Label();
            txtAddress = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtFullname = new System.Windows.Forms.TextBox();
            lbFullname = new System.Windows.Forms.Label();
            txtConfirm = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(184, 276);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 23);
            btnCancel.TabIndex = 45;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "Staff", "Member" });
            cbRole.Location = new System.Drawing.Point(94, 230);
            cbRole.Name = "cbRole";
            cbRole.Size = new System.Drawing.Size(184, 23);
            cbRole.TabIndex = 57;
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Location = new System.Drawing.Point(30, 230);
            lbRole.Name = "lbRole";
            lbRole.Size = new System.Drawing.Size(30, 15);
            lbRole.TabIndex = 56;
            lbRole.Text = "Role";
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(94, 186);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(184, 23);
            txtAddress.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(30, 189);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 15);
            label1.TabIndex = 54;
            label1.Text = "Address";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(94, 106);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(184, 23);
            txtPassword.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(30, 109);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 15);
            label2.TabIndex = 52;
            label2.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(94, 65);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(184, 23);
            txtEmail.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(28, 68);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(36, 15);
            label3.TabIndex = 50;
            label3.Text = "Email";
            // 
            // txtFullname
            // 
            txtFullname.Location = new System.Drawing.Point(94, 24);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new System.Drawing.Size(184, 23);
            txtFullname.TabIndex = 49;
            // 
            // lbFullname
            // 
            lbFullname.AutoSize = true;
            lbFullname.Location = new System.Drawing.Point(28, 27);
            lbFullname.Name = "lbFullname";
            lbFullname.Size = new System.Drawing.Size(56, 15);
            lbFullname.TabIndex = 48;
            lbFullname.Text = "Fullname";
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new System.Drawing.Point(94, 145);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new System.Drawing.Size(184, 23);
            txtConfirm.TabIndex = 59;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(30, 148);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(51, 15);
            label4.TabIndex = 58;
            label4.Text = "Confirm";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(30, 276);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(75, 23);
            btnAdd.TabIndex = 60;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmUserDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(317, 320);
            Controls.Add(btnAdd);
            Controls.Add(txtConfirm);
            Controls.Add(label4);
            Controls.Add(cbRole);
            Controls.Add(lbRole);
            Controls.Add(txtAddress);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtFullname);
            Controls.Add(lbFullname);
            Controls.Add(btnCancel);
            Name = "frmUserDetail";
            Text = "User Detail";
            Load += frmUserDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
    }
}