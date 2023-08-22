namespace CarManagementBookingGUI
{
    partial class frmCart
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
            Cus = new System.Windows.Forms.Label();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            txtPrice = new System.Windows.Forms.TextBox();
            Price = new System.Windows.Forms.Label();
            txtModel = new System.Windows.Forms.TextBox();
            Quantity = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            Name = new System.Windows.Forms.Label();
            dgvOrderList = new System.Windows.Forms.DataGridView();
            btnCheckOut = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            txtPlate = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtSub = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtBrand = new System.Windows.Forms.TextBox();
            txtTotal = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtExpried = new System.Windows.Forms.DateTimePicker();
            txtDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // Cus
            // 
            Cus.AutoSize = true;
            Cus.Location = new System.Drawing.Point(341, 151);
            Cus.Name = "Cus";
            Cus.Size = new System.Drawing.Size(70, 20);
            Cus.TabIndex = 139;
            Cus.Text = "CarBrand";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(132, 279);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 137;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(244, 279);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 136;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPrice
            // 
            txtPrice.Enabled = false;
            txtPrice.Location = new System.Drawing.Point(457, 104);
            txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(154, 27);
            txtPrice.TabIndex = 135;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new System.Drawing.Point(337, 107);
            Price.Name = "Price";
            Price.Size = new System.Drawing.Size(96, 20);
            Price.TabIndex = 134;
            Price.Text = "PriceperHour";
            // 
            // txtModel
            // 
            txtModel.Enabled = false;
            txtModel.Location = new System.Drawing.Point(173, 145);
            txtModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtModel.Name = "txtModel";
            txtModel.Size = new System.Drawing.Size(143, 27);
            txtModel.TabIndex = 133;
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Location = new System.Drawing.Point(73, 151);
            Quantity.Name = "Quantity";
            Quantity.Size = new System.Drawing.Size(74, 20);
            Quantity.TabIndex = 132;
            Quantity.Text = "CarModel";
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new System.Drawing.Point(173, 103);
            txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(143, 27);
            txtName.TabIndex = 131;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new System.Drawing.Point(73, 107);
            Name.Name = "Name";
            Name.Size = new System.Drawing.Size(71, 20);
            Name.TabIndex = 130;
            Name.Text = "CarName";
            // 
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new System.Drawing.Point(73, 324);
            dgvOrderList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.ReadOnly = true;
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.RowTemplate.Height = 25;
            dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvOrderList.Size = new System.Drawing.Size(522, 339);
            dgvOrderList.TabIndex = 129;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new System.Drawing.Point(234, 670);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new System.Drawing.Size(94, 29);
            btnCheckOut.TabIndex = 128;
            btnCheckOut.Text = "CheckOut";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(271, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(119, 62);
            label1.TabIndex = 127;
            label1.Text = "Cart";
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(346, 670);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(94, 29);
            btnBack.TabIndex = 126;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtPlate
            // 
            txtPlate.Enabled = false;
            txtPlate.Location = new System.Drawing.Point(173, 189);
            txtPlate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new System.Drawing.Size(143, 27);
            txtPlate.TabIndex = 141;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(73, 195);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 20);
            label2.TabIndex = 140;
            label2.Text = "CarPlate";
            // 
            // txtSub
            // 
            txtSub.Enabled = false;
            txtSub.Location = new System.Drawing.Point(457, 189);
            txtSub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSub.Name = "txtSub";
            txtSub.Size = new System.Drawing.Size(154, 27);
            txtSub.TabIndex = 143;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(339, 195);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 20);
            label3.TabIndex = 142;
            label3.Text = "SubTotal";
            // 
            // txtBrand
            // 
            txtBrand.Enabled = false;
            txtBrand.Location = new System.Drawing.Point(457, 145);
            txtBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new System.Drawing.Size(154, 27);
            txtBrand.TabIndex = 144;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new System.Drawing.Point(401, 280);
            txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(154, 27);
            txtTotal.TabIndex = 146;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(351, 283);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 20);
            label4.TabIndex = 145;
            label4.Text = "Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(337, 237);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(114, 20);
            label5.TabIndex = 150;
            label5.Text = "BookingExpired";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(73, 237);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(96, 20);
            label6.TabIndex = 149;
            label6.Text = "BookingDate";
            // 
            // txtExpried
            // 
            txtExpried.Enabled = false;
            txtExpried.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            txtExpried.Location = new System.Drawing.Point(457, 232);
            txtExpried.Name = "txtExpried";
            txtExpried.Size = new System.Drawing.Size(154, 27);
            txtExpried.TabIndex = 148;
            // 
            // txtDate
            // 
            txtDate.Enabled = false;
            txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            txtDate.Location = new System.Drawing.Point(173, 232);
            txtDate.Name = "txtDate";
            txtDate.Size = new System.Drawing.Size(142, 27);
            txtDate.TabIndex = 147;
            // 
            // frmCart
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(671, 711);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtExpried);
            Controls.Add(txtDate);
            Controls.Add(txtTotal);
            Controls.Add(label4);
            Controls.Add(txtBrand);
            Controls.Add(txtSub);
            Controls.Add(label3);
            Controls.Add(txtPlate);
            Controls.Add(label2);
            Controls.Add(Cus);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtPrice);
            Controls.Add(Price);
            Controls.Add(txtModel);
            Controls.Add(Quantity);
            Controls.Add(txtName);
            Controls.Add(Name);
            Controls.Add(dgvOrderList);
            Controls.Add(btnCheckOut);
            Controls.Add(label1);
            Controls.Add(btnBack);
            //Name = "frmCart";
            Text = "Cart";
            Load += frmCart_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Cus;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtExpried;
        private System.Windows.Forms.DateTimePicker txtDate;
    }
}