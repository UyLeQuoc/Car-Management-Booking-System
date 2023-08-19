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
            btnBack = new System.Windows.Forms.Button();
            dgvOrderList = new System.Windows.Forms.DataGridView();
            txtPrice = new System.Windows.Forms.TextBox();
            lbMember = new System.Windows.Forms.Label();
            txtCarName = new System.Windows.Forms.TextBox();
            lbCarName = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtDate = new System.Windows.Forms.DateTimePicker();
            txtExpired = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(276, 529);
            btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(139, 48);
            btnBack.TabIndex = 47;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new System.Drawing.Point(76, 152);
            dgvOrderList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.ReadOnly = true;
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.RowTemplate.Height = 25;
            dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvOrderList.Size = new System.Drawing.Size(488, 359);
            dgvOrderList.TabIndex = 46;
            // 
            // txtPrice
            // 
            txtPrice.Enabled = false;
            txtPrice.Location = new System.Drawing.Point(117, 74);
            txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(154, 27);
            txtPrice.TabIndex = 44;
            // 
            // lbMember
            // 
            lbMember.AutoSize = true;
            lbMember.Location = new System.Drawing.Point(32, 77);
            lbMember.Name = "lbMember";
            lbMember.Size = new System.Drawing.Size(41, 20);
            lbMember.TabIndex = 42;
            lbMember.Text = "Price";
            // 
            // txtCarName
            // 
            txtCarName.Enabled = false;
            txtCarName.Location = new System.Drawing.Point(117, 39);
            txtCarName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(154, 27);
            txtCarName.TabIndex = 41;
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new System.Drawing.Point(32, 42);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new System.Drawing.Size(71, 20);
            lbCarName.TabIndex = 40;
            lbCarName.Text = "CarName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(310, 74);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(114, 20);
            label3.TabIndex = 51;
            label3.Text = "BookingExpired";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(310, 39);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 20);
            label2.TabIndex = 50;
            label2.Text = "BookingDate";
            // 
            // txtDate
            // 
            txtDate.Enabled = false;
            txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            txtDate.Location = new System.Drawing.Point(439, 36);
            txtDate.Name = "txtDate";
            txtDate.Size = new System.Drawing.Size(166, 27);
            txtDate.TabIndex = 49;
            // 
            // txtExpired
            // 
            txtExpired.Enabled = false;
            txtExpired.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            txtExpired.Location = new System.Drawing.Point(439, 74);
            txtExpired.Name = "txtExpired";
            txtExpired.Size = new System.Drawing.Size(166, 27);
            txtExpired.TabIndex = 48;
            // 
            // frmBookingDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(636, 590);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDate);
            Controls.Add(txtExpired);
            Controls.Add(btnBack);
            Controls.Add(dgvOrderList);
            Controls.Add(txtPrice);
            Controls.Add(lbMember);
            Controls.Add(txtCarName);
            Controls.Add(lbCarName);
            Name = "frmBookingDetail";
            Text = "frmOrderDetail";
            Load += frmBookingDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbMember;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.DateTimePicker txtExpired;
    }
}