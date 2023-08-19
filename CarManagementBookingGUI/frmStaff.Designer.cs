namespace CarManagementBookingGUI
{
    partial class frmStaff
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
            btnBookings = new System.Windows.Forms.Button();
            btnCars = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            txtUserName = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnBookings
            // 
            btnBookings.Location = new System.Drawing.Point(447, 238);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new System.Drawing.Size(295, 116);
            btnBookings.TabIndex = 3;
            btnBookings.Text = "Bookings Management";
            btnBookings.UseVisualStyleBackColor = true;
            btnBookings.Click += btnBookings_Click;
            // 
            // btnCars
            // 
            btnCars.Location = new System.Drawing.Point(97, 238);
            btnCars.Name = "btnCars";
            btnCars.Size = new System.Drawing.Size(279, 116);
            btnCars.TabIndex = 2;
            btnCars.Text = "Cars Management";
            btnCars.UseVisualStyleBackColor = true;
            btnCars.Click += btnCars_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(263, 76);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 32);
            label1.TabIndex = 4;
            label1.Text = "Welcome";
            // 
            // txtUserName
            // 
            txtUserName.AutoSize = true;
            txtUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtUserName.Location = new System.Drawing.Point(447, 76);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(138, 32);
            txtUserName.TabIndex = 5;
            txtUserName.Text = "staff_name";
            txtUserName.Click += label2_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(592, 150);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(150, 41);
            button4.TabIndex = 7;
            button4.Text = "Log out";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // frmStaff
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(855, 438);
            Controls.Add(button4);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Controls.Add(btnBookings);
            Controls.Add(btnCars);
            Name = "frmStaff";
            Text = "frmStaff";
            Load += frmStaff_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnCars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.Button button4;
    }
}