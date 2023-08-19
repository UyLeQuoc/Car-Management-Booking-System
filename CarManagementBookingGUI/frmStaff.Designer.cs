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
            label2 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnBookings
            // 
            btnBookings.Location = new System.Drawing.Point(447, 277);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new System.Drawing.Size(295, 116);
            btnBookings.TabIndex = 3;
            btnBookings.Text = "Bookings Management";
            btnBookings.UseVisualStyleBackColor = true;
            btnBookings.Click += btnBookings_Click;
            // 
            // btnCars
            // 
            btnCars.Location = new System.Drawing.Point(97, 277);
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
            label1.Location = new System.Drawing.Point(263, 85);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 32);
            label1.TabIndex = 4;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(447, 85);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(130, 32);
            label2.TabIndex = 5;
            label2.Text = "staff_name";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(226, 152);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(150, 41);
            button3.TabIndex = 6;
            button3.Text = "View Profile";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(447, 152);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(150, 41);
            button4.TabIndex = 7;
            button4.Text = "Log out";
            button4.UseVisualStyleBackColor = true;
            // 
            // frmStaff
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(855, 476);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBookings);
            Controls.Add(btnCars);
            Name = "frmStaff";
            Text = "frmStaff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnCars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}