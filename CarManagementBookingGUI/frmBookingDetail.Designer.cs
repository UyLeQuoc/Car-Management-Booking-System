namespace CarManagementBookingGUI
{
    partial class frmBookingDetail
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
            lbUnitPrice = new System.Windows.Forms.Label();
            lbWeight = new System.Windows.Forms.Label();
            txtCarName = new System.Windows.Forms.TextBox();
            lbMemberName = new System.Windows.Forms.Label();
            txtBookingID = new System.Windows.Forms.TextBox();
            lbProductID = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtReturnStatus = new System.Windows.Forms.TextBox();
            txtBookingPrice = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            dgvBookingDetailsList = new System.Windows.Forms.DataGridView();
            txtBookingDate = new System.Windows.Forms.DateTimePicker();
            txtBookingExpired = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvBookingDetailsList).BeginInit();
            SuspendLayout();
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new System.Drawing.Point(684, 65);
            lbUnitPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new System.Drawing.Size(159, 32);
            lbUnitPrice.TabIndex = 151;
            lbUnitPrice.Text = "Booking Date";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new System.Drawing.Point(684, 155);
            lbWeight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new System.Drawing.Size(187, 32);
            lbWeight.TabIndex = 150;
            lbWeight.Text = "Booking Expired";
            // 
            // txtCarName
            // 
            txtCarName.Enabled = false;
            txtCarName.Location = new System.Drawing.Point(265, 150);
            txtCarName.Margin = new System.Windows.Forms.Padding(6);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(339, 39);
            txtCarName.TabIndex = 145;
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new System.Drawing.Point(79, 156);
            lbMemberName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new System.Drawing.Size(120, 32);
            lbMemberName.TabIndex = 149;
            lbMemberName.Text = "Car Name";
            // 
            // txtBookingID
            // 
            txtBookingID.Enabled = false;
            txtBookingID.Location = new System.Drawing.Point(265, 67);
            txtBookingID.Margin = new System.Windows.Forms.Padding(6);
            txtBookingID.Name = "txtBookingID";
            txtBookingID.Size = new System.Drawing.Size(339, 39);
            txtBookingID.TabIndex = 144;
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new System.Drawing.Point(79, 70);
            lbProductID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new System.Drawing.Size(132, 32);
            lbProductID.TabIndex = 148;
            lbProductID.Text = "Booking ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(684, 244);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(155, 32);
            label1.TabIndex = 155;
            label1.Text = "Return Status";
            // 
            // txtReturnStatus
            // 
            txtReturnStatus.Enabled = false;
            txtReturnStatus.Location = new System.Drawing.Point(900, 239);
            txtReturnStatus.Margin = new System.Windows.Forms.Padding(6);
            txtReturnStatus.Name = "txtReturnStatus";
            txtReturnStatus.Size = new System.Drawing.Size(339, 39);
            txtReturnStatus.TabIndex = 153;
            // 
            // txtBookingPrice
            // 
            txtBookingPrice.Enabled = false;
            txtBookingPrice.Location = new System.Drawing.Point(265, 239);
            txtBookingPrice.Margin = new System.Windows.Forms.Padding(6);
            txtBookingPrice.Name = "txtBookingPrice";
            txtBookingPrice.Size = new System.Drawing.Size(339, 39);
            txtBookingPrice.TabIndex = 152;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(79, 245);
            label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(160, 32);
            label2.TabIndex = 154;
            label2.Text = "Booking Price";
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(538, 919);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(202, 56);
            btnBack.TabIndex = 157;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvBookingDetailsList
            // 
            dgvBookingDetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookingDetailsList.Location = new System.Drawing.Point(79, 343);
            dgvBookingDetailsList.Margin = new System.Windows.Forms.Padding(6);
            dgvBookingDetailsList.Name = "dgvBookingDetailsList";
            dgvBookingDetailsList.ReadOnly = true;
            dgvBookingDetailsList.RowHeadersWidth = 82;
            dgvBookingDetailsList.RowTemplate.Height = 25;
            dgvBookingDetailsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvBookingDetailsList.Size = new System.Drawing.Size(1160, 547);
            dgvBookingDetailsList.TabIndex = 156;
            dgvBookingDetailsList.CellContentClick += dgvBookingDetailsList_CellContentClick;
            dgvBookingDetailsList.CellDoubleClick += dgvBookingDetailsList_CellDoubleClick;

            // 
            // txtBookingDate
            // 
            txtBookingDate.Enabled = false;
            txtBookingDate.Location = new System.Drawing.Point(900, 65);
            txtBookingDate.Name = "txtBookingDate";
            txtBookingDate.Size = new System.Drawing.Size(339, 39);
            txtBookingDate.TabIndex = 159;
            // 
            // txtBookingExpired
            // 
            txtBookingExpired.Enabled = false;
            txtBookingExpired.Location = new System.Drawing.Point(900, 148);
            txtBookingExpired.Name = "txtBookingExpired";
            txtBookingExpired.Size = new System.Drawing.Size(339, 39);
            txtBookingExpired.TabIndex = 160;
            // 
            // frmBookingDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1324, 1007);
            Controls.Add(txtBookingExpired);
            Controls.Add(txtBookingDate);
            Controls.Add(btnBack);
            Controls.Add(dgvBookingDetailsList);
            Controls.Add(label1);
            Controls.Add(txtReturnStatus);
            Controls.Add(txtBookingPrice);
            Controls.Add(label2);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbWeight);
            Controls.Add(txtCarName);
            Controls.Add(lbMemberName);
            Controls.Add(txtBookingID);
            Controls.Add(lbProductID);
            Name = "frmBookingDetail";
            Text = "frmOrderDetail";
            Load += frmBookingDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookingDetailsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

      

        #endregion
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReturnStatus;
        private System.Windows.Forms.TextBox txtBookingPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvBookingDetailsList;
        private System.Windows.Forms.DateTimePicker txtBookingDate;
        private System.Windows.Forms.DateTimePicker txtBookingExpired;
    }
}