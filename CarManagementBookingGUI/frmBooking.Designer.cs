namespace CarManagementBookingGUI
{
    partial class frmBooking
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
            txtTime = new System.Windows.Forms.TextBox();
            lbMember = new System.Windows.Forms.Label();
            txtOrderTotal = new System.Windows.Forms.TextBox();
            lbOrderTotal = new System.Windows.Forms.Label();
            txtBookingID = new System.Windows.Forms.TextBox();
            lbOrderID = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            dgvOrderList = new System.Windows.Forms.DataGridView();
            btnOrderDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // txtTime
            // 
            txtTime.Enabled = false;
            txtTime.Location = new System.Drawing.Point(133, 62);
            txtTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTime.Name = "txtTime";
            txtTime.Size = new System.Drawing.Size(154, 27);
            txtTime.TabIndex = 35;
            // 
            // lbMember
            // 
            lbMember.AutoSize = true;
            lbMember.Location = new System.Drawing.Point(40, 65);
            lbMember.Name = "lbMember";
            lbMember.Size = new System.Drawing.Size(42, 20);
            lbMember.TabIndex = 33;
            lbMember.Text = "Time";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Enabled = false;
            txtOrderTotal.Location = new System.Drawing.Point(133, 97);
            txtOrderTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.Size = new System.Drawing.Size(154, 27);
            txtOrderTotal.TabIndex = 36;
            // 
            // lbOrderTotal
            // 
            lbOrderTotal.AutoSize = true;
            lbOrderTotal.Location = new System.Drawing.Point(40, 100);
            lbOrderTotal.Name = "lbOrderTotal";
            lbOrderTotal.Size = new System.Drawing.Size(42, 20);
            lbOrderTotal.TabIndex = 34;
            lbOrderTotal.Text = "Total";
            // 
            // txtBookingID
            // 
            txtBookingID.Enabled = false;
            txtBookingID.Location = new System.Drawing.Point(133, 27);
            txtBookingID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtBookingID.Name = "txtBookingID";
            txtBookingID.Size = new System.Drawing.Size(154, 27);
            txtBookingID.TabIndex = 31;
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new System.Drawing.Point(40, 27);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new System.Drawing.Size(83, 20);
            lbOrderID.TabIndex = 30;
            lbOrderID.Text = "Booking ID";
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(161, 512);
            btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(139, 48);
            btnBack.TabIndex = 38;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new System.Drawing.Point(20, 145);
            dgvOrderList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.ReadOnly = true;
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.RowTemplate.Height = 25;
            dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvOrderList.Size = new System.Drawing.Size(428, 359);
            dgvOrderList.TabIndex = 37;
            // 
            // btnOrderDetail
            // 
            btnOrderDetail.Location = new System.Drawing.Point(321, 61);
            btnOrderDetail.Name = "btnOrderDetail";
            btnOrderDetail.Size = new System.Drawing.Size(94, 28);
            btnOrderDetail.TabIndex = 39;
            btnOrderDetail.Text = "ViewDetail";
            btnOrderDetail.UseVisualStyleBackColor = true;
            btnOrderDetail.Click += btnOrderDetail_Click;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(472, 576);
            Controls.Add(btnOrderDetail);
            Controls.Add(btnBack);
            Controls.Add(dgvOrderList);
            Controls.Add(txtTime);
            Controls.Add(lbMember);
            Controls.Add(txtOrderTotal);
            Controls.Add(lbOrderTotal);
            Controls.Add(txtBookingID);
            Controls.Add(lbOrderID);
            Name = "frmOrder";
            Text = "frmOrder";
            Load += frmOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lbMember;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label lbOrderTotal;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Button btnOrderDetail;
    }
}