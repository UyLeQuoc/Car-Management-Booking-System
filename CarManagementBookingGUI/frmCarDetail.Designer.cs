namespace CarManagementBookingGUI
{
    partial class frmCarDetail
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
            txtIsDeleted = new System.Windows.Forms.TextBox();
            lb10 = new System.Windows.Forms.Label();
            txtCarPlate = new System.Windows.Forms.TextBox();
            lbUnitsInStock = new System.Windows.Forms.Label();
            lbUnitPrice = new System.Windows.Forms.Label();
            lbWeight = new System.Windows.Forms.Label();
            txtPricePerHour = new System.Windows.Forms.TextBox();
            lbCategory = new System.Windows.Forms.Label();
            txtCarName = new System.Windows.Forms.TextBox();
            lbMemberName = new System.Windows.Forms.Label();
            btnUpdate = new System.Windows.Forms.Button();
            btnCreate = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            txtBrand = new System.Windows.Forms.ComboBox();
            txtModel = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // txtIsDeleted
            // 
            txtIsDeleted.Enabled = false;
            txtIsDeleted.Location = new System.Drawing.Point(175, 310);
            txtIsDeleted.Margin = new System.Windows.Forms.Padding(4);
            txtIsDeleted.Name = "txtIsDeleted";
            txtIsDeleted.Size = new System.Drawing.Size(210, 27);
            txtIsDeleted.TabIndex = 118;
            // 
            // lb10
            // 
            lb10.AutoSize = true;
            lb10.Location = new System.Drawing.Point(55, 312);
            lb10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lb10.Name = "lb10";
            lb10.Size = new System.Drawing.Size(62, 20);
            lb10.TabIndex = 119;
            lb10.Text = "Deleted";
            // 
            // txtCarPlate
            // 
            txtCarPlate.Location = new System.Drawing.Point(175, 87);
            txtCarPlate.Margin = new System.Windows.Forms.Padding(4);
            txtCarPlate.Name = "txtCarPlate";
            txtCarPlate.Size = new System.Drawing.Size(210, 27);
            txtCarPlate.TabIndex = 108;
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new System.Drawing.Point(55, 259);
            lbUnitsInStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new System.Drawing.Size(52, 20);
            lbUnitsInStock.TabIndex = 117;
            lbUnitsInStock.Text = "Model";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new System.Drawing.Point(55, 204);
            lbUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new System.Drawing.Size(48, 20);
            lbUnitPrice.TabIndex = 116;
            lbUnitPrice.Text = "Brand";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new System.Drawing.Point(55, 150);
            lbWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new System.Drawing.Size(101, 20);
            lbWeight.TabIndex = 115;
            lbWeight.Text = "Price per hour";
            // 
            // txtPricePerHour
            // 
            txtPricePerHour.Location = new System.Drawing.Point(175, 147);
            txtPricePerHour.Margin = new System.Windows.Forms.Padding(4);
            txtPricePerHour.Name = "txtPricePerHour";
            txtPricePerHour.Size = new System.Drawing.Size(210, 27);
            txtPricePerHour.TabIndex = 109;
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Location = new System.Drawing.Point(55, 92);
            lbCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new System.Drawing.Size(68, 20);
            lbCategory.TabIndex = 114;
            lbCategory.Text = "Car Plate";
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(175, 33);
            txtCarName.Margin = new System.Windows.Forms.Padding(4);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(210, 27);
            txtCarName.TabIndex = 107;
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new System.Drawing.Point(55, 37);
            lbMemberName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new System.Drawing.Size(75, 20);
            lbMemberName.TabIndex = 113;
            lbMemberName.Text = "Car Name";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(175, 373);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 120;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Visible = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(175, 373);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(94, 29);
            btnCreate.TabIndex = 121;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(291, 373);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(94, 29);
            btnBack.TabIndex = 122;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtBrand
            // 
            txtBrand.FormattingEnabled = true;
            txtBrand.Location = new System.Drawing.Point(175, 201);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new System.Drawing.Size(210, 28);
            txtBrand.TabIndex = 123;
            // 
            // txtModel
            // 
            txtModel.FormattingEnabled = true;
            txtModel.Location = new System.Drawing.Point(175, 256);
            txtModel.Name = "txtModel";
            txtModel.Size = new System.Drawing.Size(210, 28);
            txtModel.TabIndex = 124;
            // 
            // frmCarDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(432, 432);
            Controls.Add(txtModel);
            Controls.Add(txtBrand);
            Controls.Add(btnBack);
            Controls.Add(btnCreate);
            Controls.Add(btnUpdate);
            Controls.Add(txtIsDeleted);
            Controls.Add(lb10);
            Controls.Add(txtCarPlate);
            Controls.Add(lbUnitsInStock);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbWeight);
            Controls.Add(txtPricePerHour);
            Controls.Add(lbCategory);
            Controls.Add(txtCarName);
            Controls.Add(lbMemberName);
            Name = "frmCarDetail";
            Text = "Car Detail";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtIsDeleted;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.TextBox txtCarPlate;
        private System.Windows.Forms.Label lbUnitsInStock;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.TextBox txtPricePerHour;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox txtBrand;
        private System.Windows.Forms.ComboBox txtModel;
    }
}