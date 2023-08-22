namespace CarManagementBookingGUI
{
    partial class frmSignUp
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
            lbEmail = new System.Windows.Forms.Label();
            lbFullname = new System.Windows.Forms.Label();
            lbAddress = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            lbConfirm = new System.Windows.Forms.Label();
            btSignup = new System.Windows.Forms.Button();
            btReset = new System.Windows.Forms.Button();
            txtEmail = new System.Windows.Forms.TextBox();
            txtFullname = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtConfirm = new System.Windows.Forms.TextBox();
            lbSignup = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(69, 99);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Email";
            // 
            // lbFullname
            // 
            lbFullname.AutoSize = true;
            lbFullname.Location = new System.Drawing.Point(69, 146);
            lbFullname.Name = "lbFullname";
            lbFullname.Size = new System.Drawing.Size(69, 20);
            lbFullname.TabIndex = 1;
            lbFullname.Text = "Fullname";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new System.Drawing.Point(69, 193);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new System.Drawing.Size(62, 20);
            lbAddress.TabIndex = 2;
            lbAddress.Text = "Address";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(69, 248);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password";
            // 
            // lbConfirm
            // 
            lbConfirm.AutoSize = true;
            lbConfirm.Location = new System.Drawing.Point(69, 300);
            lbConfirm.Name = "lbConfirm";
            lbConfirm.Size = new System.Drawing.Size(62, 20);
            lbConfirm.TabIndex = 4;
            lbConfirm.Text = "Confirm";
            // 
            // btSignup
            // 
            btSignup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btSignup.DialogResult = System.Windows.Forms.DialogResult.Yes;
            btSignup.Location = new System.Drawing.Point(175, 357);
            btSignup.Name = "btSignup";
            btSignup.Size = new System.Drawing.Size(94, 29);
            btSignup.TabIndex = 5;
            btSignup.Text = "Sign up";
            btSignup.UseVisualStyleBackColor = false;
            btSignup.Click += btSignup_Click;
            // 
            // btReset
            // 
            btReset.Location = new System.Drawing.Point(373, 357);
            btReset.Name = "btReset";
            btReset.Size = new System.Drawing.Size(94, 29);
            btReset.TabIndex = 6;
            btReset.Text = "Reset";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(175, 96);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(292, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtFullname
            // 
            txtFullname.Location = new System.Drawing.Point(175, 143);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new System.Drawing.Size(292, 27);
            txtFullname.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(175, 190);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(292, 27);
            txtAddress.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(175, 241);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(292, 27);
            txtPassword.TabIndex = 10;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new System.Drawing.Point(175, 297);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size = new System.Drawing.Size(292, 27);
            txtConfirm.TabIndex = 11;
            // 
            // lbSignup
            // 
            lbSignup.AutoSize = true;
            lbSignup.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbSignup.Location = new System.Drawing.Point(248, 43);
            lbSignup.Name = "lbSignup";
            lbSignup.Size = new System.Drawing.Size(125, 40);
            lbSignup.TabIndex = 12;
            lbSignup.Text = "Sign up";
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(94, 29);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmSignUp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(616, 449);
            Controls.Add(btnBack);
            Controls.Add(lbSignup);
            Controls.Add(txtConfirm);
            Controls.Add(txtPassword);
            Controls.Add(txtAddress);
            Controls.Add(txtFullname);
            Controls.Add(txtEmail);
            Controls.Add(btReset);
            Controls.Add(btSignup);
            Controls.Add(lbConfirm);
            Controls.Add(lbPassword);
            Controls.Add(lbAddress);
            Controls.Add(lbFullname);
            Controls.Add(lbEmail);
            MinimumSize = new System.Drawing.Size(634, 449);
            Name = "frmSignUp";
            Text = "Sign up";
            Load += frmSignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbConfirm;
        private System.Windows.Forms.Button btSignup;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lbSignup;
        private System.Windows.Forms.Button btnBack;
    }
}