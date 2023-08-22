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
            btnBrandModel = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnLogout = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnUserMangement
            // 
            btnUserMangement.Location = new System.Drawing.Point(20, 86);
            btnUserMangement.Name = "btnUserMangement";
            btnUserMangement.Size = new System.Drawing.Size(182, 73);
            btnUserMangement.TabIndex = 0;
            btnUserMangement.Text = "User Management";
            btnUserMangement.UseVisualStyleBackColor = true;
            btnUserMangement.Click += btnUserMangement_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(223, 86);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(182, 73);
            button1.TabIndex = 1;
            button1.Text = "Car Management";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnBrandModel
            // 
            btnBrandModel.Location = new System.Drawing.Point(425, 86);
            btnBrandModel.Name = "btnBrandModel";
            btnBrandModel.Size = new System.Drawing.Size(182, 73);
            btnBrandModel.TabIndex = 2;
            btnBrandModel.Text = "Brand and Model Management";
            btnBrandModel.UseVisualStyleBackColor = true;
            btnBrandModel.Click += btnBrandModel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(224, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(157, 25);
            label1.TabIndex = 3;
            label1.Text = "Welcome Admin";
            // 
            // btnLogout
            // 
            btnLogout.Location = new System.Drawing.Point(400, 32);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(82, 25);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(629, 177);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Controls.Add(btnBrandModel);
            Controls.Add(button1);
            Controls.Add(btnUserMangement);
            Name = "frmMain";
            Text = "Admin Dashboard";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnUserMangement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBrandModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnLogout;
    }
}