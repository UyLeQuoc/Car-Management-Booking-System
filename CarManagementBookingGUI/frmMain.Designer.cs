namespace CarManagementBookingGUI
{
    partial class frmMain
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
            btnUserMangement = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnViewProfile = new System.Windows.Forms.Button();

            txtWelcomeName = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnUserMangement
            // 
            btnUserMangement.Location = new System.Drawing.Point(21, 143);
            btnUserMangement.Name = "btnUserMangement";
            btnUserMangement.Size = new System.Drawing.Size(182, 73);
            btnUserMangement.TabIndex = 0;
            btnUserMangement.Text = "User Management";
            btnUserMangement.UseVisualStyleBackColor = true;
            btnUserMangement.Click += btnUserMangement_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(224, 143);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(182, 73);
            button1.TabIndex = 1;
            button1.Text = "Car Management";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(426, 143);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(182, 73);
            button2.TabIndex = 2;
            button2.Text = "Booking Management";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(224, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "Welcome: ";
            // 

            btnViewProfile.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnViewProfile.Location = new System.Drawing.Point(189, 78);
            btnViewProfile.Name = "btnViewProfile";
            btnViewProfile.Size = new System.Drawing.Size(98, 23);
            btnViewProfile.TabIndex = 5;
            btnViewProfile.Text = "View Profile";
            btnViewProfile.UseVisualStyleBackColor = true;
            btnViewProfile.Click += btnViewProfile_Click;

            // 
            // txtWelcomeName
            // 
            txtWelcomeName.AutoSize = true;
            txtWelcomeName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtWelcomeName.Location = new System.Drawing.Point(314, 45);
            txtWelcomeName.Name = "txtWelcomeName";
            txtWelcomeName.Size = new System.Drawing.Size(59, 15);
            txtWelcomeName.TabIndex = 6;
            txtWelcomeName.Text = "&full name";
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(314, 78);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(629, 270);
            Controls.Add(button4);
            Controls.Add(txtWelcomeName);
            Controls.Add(btnViewProfile);

            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnUserMangement);
            Name = "frmMain";
            Text = "frmAdmin";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnUserMangement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewProfile;

        private System.Windows.Forms.Label txtWelcomeName;
        private System.Windows.Forms.Button button4;
    }
}