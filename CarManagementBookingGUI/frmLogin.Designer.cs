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
            btBack = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(135, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(282, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(135, 173);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(282, 27);
            txtPassword.TabIndex = 1;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbLogin.Location = new System.Drawing.Point(224, 32);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new System.Drawing.Size(96, 40);
            lbLogin.TabIndex = 2;
            lbLogin.Text = "Login";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(58, 103);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(58, 177);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Password";
            // 
            // btSignin
            // 
            btSignin.Location = new System.Drawing.Point(135, 246);
            btSignin.Name = "btSignin";
            btSignin.Size = new System.Drawing.Size(94, 29);
            btSignin.TabIndex = 5;
            btSignin.Text = "Sign in";
            btSignin.UseVisualStyleBackColor = true;
            btSignin.Click += btSignin_Click;
            // 
            // btSignup
            // 
            btSignup.Location = new System.Drawing.Point(323, 246);
            btSignup.Name = "btSignup";
            btSignup.Size = new System.Drawing.Size(94, 29);
            btSignup.TabIndex = 6;
            btSignup.Text = "Sign up";
            btSignup.UseVisualStyleBackColor = true;
            btSignup.Click += btSignup_Click;
            // 
            // btBack
            // 
            btBack.Location = new System.Drawing.Point(201, 303);
            btBack.Name = "btBack";
            btBack.Size = new System.Drawing.Size(136, 29);
            btBack.TabIndex = 7;
            btBack.Text = "Back to View Car";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(523, 361);
            Controls.Add(btBack);
            Controls.Add(btSignup);
            Controls.Add(btSignin);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            MinimumSize = new System.Drawing.Size(539, 398);
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
        private System.Windows.Forms.Button btBack;
    }
}
