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
            btnBack = new System.Windows.Forms.Button();
            lbSignup = new System.Windows.Forms.Label();
            txtConfirm = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            txtFullname = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            btReset = new System.Windows.Forms.Button();
            lbConfirm = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            lbAddress = new System.Windows.Forms.Label();
            lbFullname = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            btnSignUp = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(20, 21);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(94, 29);
            btnBack.TabIndex = 27;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbSignup
            // 
            lbSignup.AutoSize = true;
            lbSignup.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbSignup.Location = new System.Drawing.Point(214, 57);
            lbSignup.Name = "lbSignup";
            lbSignup.Size = new System.Drawing.Size(125, 40);
            lbSignup.TabIndex = 26;
            lbSignup.Text = "Sign up";
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new System.Drawing.Point(141, 311);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size = new System.Drawing.Size(292, 27);
            txtConfirm.TabIndex = 25;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(141, 255);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(292, 27);
            txtPassword.TabIndex = 24;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(141, 204);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(292, 27);
            txtAddress.TabIndex = 23;
            // 
            // txtFullname
            // 
            txtFullname.Location = new System.Drawing.Point(141, 157);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new System.Drawing.Size(292, 27);
            txtFullname.TabIndex = 22;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(141, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(292, 27);
            txtEmail.TabIndex = 21;
            // 
            // btReset
            // 
            btReset.Location = new System.Drawing.Point(291, 371);
            btReset.Name = "btReset";
            btReset.Size = new System.Drawing.Size(94, 29);
            btReset.TabIndex = 20;
            btReset.Text = "Reset";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // lbConfirm
            // 
            lbConfirm.AutoSize = true;
            lbConfirm.Location = new System.Drawing.Point(35, 314);
            lbConfirm.Name = "lbConfirm";
            lbConfirm.Size = new System.Drawing.Size(62, 20);
            lbConfirm.TabIndex = 18;
            lbConfirm.Text = "Confirm";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(35, 262);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 17;
            lbPassword.Text = "Password";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new System.Drawing.Point(35, 207);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new System.Drawing.Size(62, 20);
            lbAddress.TabIndex = 16;
            lbAddress.Text = "Address";
            // 
            // lbFullname
            // 
            lbFullname.AutoSize = true;
            lbFullname.Location = new System.Drawing.Point(35, 160);
            lbFullname.Name = "lbFullname";
            lbFullname.Size = new System.Drawing.Size(69, 20);
            lbFullname.TabIndex = 15;
            lbFullname.Text = "Fullname";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(35, 113);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 14;
            lbEmail.Text = "Email";
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new System.Drawing.Point(175, 371);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new System.Drawing.Size(94, 29);
            btnSignUp.TabIndex = 28;
            btnSignUp.Text = "SignUp";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // frmSignUp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(487, 450);
            Controls.Add(btnSignUp);
            Controls.Add(btnBack);
            Controls.Add(lbSignup);
            Controls.Add(txtConfirm);
            Controls.Add(txtPassword);
            Controls.Add(txtAddress);
            Controls.Add(txtFullname);
            Controls.Add(txtEmail);
            Controls.Add(btReset);
            Controls.Add(lbConfirm);
            Controls.Add(lbPassword);
            Controls.Add(lbAddress);
            Controls.Add(lbFullname);
            Controls.Add(lbEmail);
            Name = "frmSignUp";
            Text = "frmSignUp";
            Load += frmSignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbSignup;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label lbConfirm;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btnSignUp;
    }
}