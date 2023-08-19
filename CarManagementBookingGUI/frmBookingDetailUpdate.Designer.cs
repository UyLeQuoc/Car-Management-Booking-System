namespace CarManagementBookingGUI
{
    partial class frmBookingDetailUpdate
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
            txtBookingExpired = new System.Windows.Forms.DateTimePicker();
            txtBookingDate = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            lbUnitPrice = new System.Windows.Forms.Label();
            lbWeight = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            txtReturnStatus = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtReturnStatus).BeginInit();
            SuspendLayout();
            // 
            // txtBookingExpired
            // 
            txtBookingExpired.Location = new System.Drawing.Point(295, 159);
            txtBookingExpired.Name = "txtBookingExpired";
            txtBookingExpired.Size = new System.Drawing.Size(394, 39);
            txtBookingExpired.TabIndex = 184;
            // 
            // txtBookingDate
            // 
            txtBookingDate.Enabled = false;
            txtBookingDate.Location = new System.Drawing.Point(295, 71);
            txtBookingDate.Name = "txtBookingDate";
            txtBookingDate.Size = new System.Drawing.Size(394, 39);
            txtBookingDate.TabIndex = 183;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(79, 255);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(155, 32);
            label1.TabIndex = 182;
            label1.Text = "Return Status";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new System.Drawing.Point(79, 71);
            lbUnitPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new System.Drawing.Size(159, 32);
            lbUnitPrice.TabIndex = 178;
            lbUnitPrice.Text = "Booking Date";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new System.Drawing.Point(79, 166);
            lbWeight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new System.Drawing.Size(187, 32);
            lbWeight.TabIndex = 177;
            lbWeight.Text = "Booking Expired";
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(539, 342);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(150, 46);
            btnBack.TabIndex = 185;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(365, 342);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(150, 46);
            btnUpdate.TabIndex = 186;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtReturnStatus
            // 
            txtReturnStatus.Location = new System.Drawing.Point(295, 253);
            txtReturnStatus.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            txtReturnStatus.Name = "txtReturnStatus";
            txtReturnStatus.Size = new System.Drawing.Size(394, 39);
            txtReturnStatus.TabIndex = 187;
            txtReturnStatus.ValueChanged += txtReturnStatus_ValueChanged;
            // 
            // frmBookingDetailUpdate
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(773, 448);
            Controls.Add(txtReturnStatus);
            Controls.Add(btnUpdate);
            Controls.Add(btnBack);
            Controls.Add(txtBookingExpired);
            Controls.Add(txtBookingDate);
            Controls.Add(label1);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbWeight);
            Name = "frmBookingDetailUpdate";
            Text = "frmBookingDetailUpdate";
            Load += frmBookingDetailUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)txtReturnStatus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtBookingExpired;
        private System.Windows.Forms.DateTimePicker txtBookingDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown txtReturnStatus;
    }
}