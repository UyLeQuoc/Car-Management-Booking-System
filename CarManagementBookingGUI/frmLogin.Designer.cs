namespace CarManagementBookingGUI
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEmail = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            lbLogin = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            btSignin = new System.Windows.Forms.Button();
            btSignup = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(118, 75);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(247, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(118, 130);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(247, 23);
            txtPassword.TabIndex = 1;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbLogin.Location = new System.Drawing.Point(196, 24);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new System.Drawing.Size(78, 32);
            lbLogin.TabIndex = 2;
            lbLogin.Text = "Login";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(51, 77);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(36, 15);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(51, 133);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(57, 15);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Password";
            // 
            // btSignin
            // 
            btSignin.Location = new System.Drawing.Point(118, 184);
            btSignin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btSignin.Name = "btSignin";
            btSignin.Size = new System.Drawing.Size(82, 22);
            btSignin.TabIndex = 5;
            btSignin.Text = "Sign in";
            btSignin.UseVisualStyleBackColor = true;
            btSignin.Click += btSignin_Click;
            // 
            // btSignup
            // 
            btSignup.Location = new System.Drawing.Point(274, 184);
            btSignup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btSignup.Name = "btSignup";
            btSignup.Size = new System.Drawing.Size(82, 22);
            btSignup.TabIndex = 6;
            btSignup.Text = "Sign up";
            btSignup.UseVisualStyleBackColor = true;
            btSignup.Click += btSignup_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(458, 271);
            Controls.Add(btSignup);
            Controls.Add(btSignin);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MinimumSize = new System.Drawing.Size(474, 310);
            Name = "frmLogin";
            Text = "Login";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btSignin;
        private System.Windows.Forms.Button btSignup;
    }
}
