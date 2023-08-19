namespace CarManagementBookingGUI
{
    partial class frmUpdateCart
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
            btnUpdate = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtExpried = new System.Windows.Forms.DateTimePicker();
            txtDate = new System.Windows.Forms.DateTimePicker();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(292, 136);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(103, 29);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(412, 136);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(99, 29);
            button2.TabIndex = 14;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(464, 68);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(114, 20);
            label3.TabIndex = 12;
            label3.Text = "BookingExpired";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(99, 68);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 20);
            label2.TabIndex = 11;
            label2.Text = "BookingDate";
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(800, 49);
            label1.TabIndex = 10;
            label1.Text = "UpdateBooking";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtExpried
            // 
            txtExpried.Location = new System.Drawing.Point(464, 91);
            txtExpried.Name = "txtExpried";
            txtExpried.Size = new System.Drawing.Size(250, 27);
            txtExpried.TabIndex = 9;
            // 
            // txtDate
            // 
            txtDate.Location = new System.Drawing.Point(99, 91);
            txtDate.Name = "txtDate";
            txtDate.Size = new System.Drawing.Size(250, 27);
            txtDate.TabIndex = 8;
            // 
            // frmUpdateCart
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 177);
            Controls.Add(btnUpdate);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtExpried);
            Controls.Add(txtDate);
            Name = "frmUpdateCart";
            Text = "frmUpdateCart";
            Load += frmUpdateCart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtExpried;
        private System.Windows.Forms.DateTimePicker txtDate;
    }
}