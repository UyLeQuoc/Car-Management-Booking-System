namespace CarManagementBookingGUI
{
    partial class frmViewCar
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
            txtCarName = new System.Windows.Forms.TextBox();
            txtCarPrice = new System.Windows.Forms.TextBox();
            txtCarBrand = new System.Windows.Forms.TextBox();
            txtCarPlate = new System.Windows.Forms.TextBox();
            txtCarModel = new System.Windows.Forms.TextBox();
            dgvViewCar = new System.Windows.Forms.DataGridView();
            lbCategory = new System.Windows.Forms.Label();
            lbMemberName = new System.Windows.Forms.Label();
            lbProductID = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            grSearch = new System.Windows.Forms.GroupBox();
            txtSearchValue = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            lbSearch = new System.Windows.Forms.Label();
            grFilter = new System.Windows.Forms.GroupBox();
            txtTo = new System.Windows.Forms.NumericUpDown();
            txtFrom = new System.Windows.Forms.NumericUpDown();
            btnFilter = new System.Windows.Forms.Button();
            lbTo = new System.Windows.Forms.Label();
            lbFrom = new System.Windows.Forms.Label();
            btnLogin = new System.Windows.Forms.Button();
            btnSignUp = new System.Windows.Forms.Button();
            Login = new System.Windows.Forms.Label();
            btnLoad = new System.Windows.Forms.Button();
            btnAddCart = new System.Windows.Forms.Button();
            btnViewCart = new System.Windows.Forms.Button();
            btnViewOrder = new System.Windows.Forms.Button();
            btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvViewCar).BeginInit();
            grSearch.SuspendLayout();
            grFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFrom).BeginInit();
            SuspendLayout();
            // 
            // txtCarName
            // 
            txtCarName.Enabled = false;
            txtCarName.Location = new System.Drawing.Point(134, 50);
            txtCarName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(225, 23);
            txtCarName.TabIndex = 0;
            txtCarName.TextChanged += txtCarName_TextChanged;
            // 
            // txtCarPrice
            // 
            txtCarPrice.Enabled = false;
            txtCarPrice.Location = new System.Drawing.Point(134, 127);
            txtCarPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtCarPrice.Name = "txtCarPrice";
            txtCarPrice.Size = new System.Drawing.Size(225, 23);
            txtCarPrice.TabIndex = 1;
            // 
            // txtCarBrand
            // 
            txtCarBrand.Enabled = false;
            txtCarBrand.Location = new System.Drawing.Point(483, 86);
            txtCarBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtCarBrand.Name = "txtCarBrand";
            txtCarBrand.Size = new System.Drawing.Size(225, 23);
            txtCarBrand.TabIndex = 2;
            // 
            // txtCarPlate
            // 
            txtCarPlate.Enabled = false;
            txtCarPlate.Location = new System.Drawing.Point(134, 88);
            txtCarPlate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtCarPlate.Name = "txtCarPlate";
            txtCarPlate.Size = new System.Drawing.Size(225, 23);
            txtCarPlate.TabIndex = 3;
            // 
            // txtCarModel
            // 
            txtCarModel.Enabled = false;
            txtCarModel.Location = new System.Drawing.Point(483, 50);
            txtCarModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtCarModel.Name = "txtCarModel";
            txtCarModel.Size = new System.Drawing.Size(225, 23);
            txtCarModel.TabIndex = 4;
            // 
            // dgvViewCar
            // 
            dgvViewCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewCar.Location = new System.Drawing.Point(30, 292);
            dgvViewCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvViewCar.Name = "dgvViewCar";
            dgvViewCar.RowHeadersWidth = 51;
            dgvViewCar.RowTemplate.Height = 29;
            dgvViewCar.Size = new System.Drawing.Size(678, 149);
            dgvViewCar.TabIndex = 5;
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Location = new System.Drawing.Point(30, 129);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new System.Drawing.Size(77, 15);
            lbCategory.TabIndex = 67;
            lbCategory.Text = "PriceperHour";
            lbCategory.Click += lbCategory_Click;
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new System.Drawing.Point(30, 91);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new System.Drawing.Size(54, 15);
            lbMemberName.TabIndex = 66;
            lbMemberName.Text = "Car Plate";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new System.Drawing.Point(30, 52);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new System.Drawing.Size(60, 15);
            lbProductID.TabIndex = 65;
            lbProductID.Text = "Car Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(391, 52);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 15);
            label1.TabIndex = 68;
            label1.Text = "Car Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(391, 88);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 15);
            label2.TabIndex = 69;
            label2.Text = "Car Brand";
            // 
            // grSearch
            // 
            grSearch.Controls.Add(txtSearchValue);
            grSearch.Controls.Add(btnSearch);
            grSearch.Controls.Add(lbSearch);
            grSearch.Location = new System.Drawing.Point(30, 168);
            grSearch.Name = "grSearch";
            grSearch.Size = new System.Drawing.Size(329, 89);
            grSearch.TabIndex = 70;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new System.Drawing.Point(77, 19);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new System.Drawing.Size(218, 23);
            txtSearchValue.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(77, 53);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(105, 23);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new System.Drawing.Point(29, 23);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new System.Drawing.Size(42, 15);
            lbSearch.TabIndex = 16;
            lbSearch.Text = "Search";
            // 
            // grFilter
            // 
            grFilter.Controls.Add(txtTo);
            grFilter.Controls.Add(txtFrom);
            grFilter.Controls.Add(btnFilter);
            grFilter.Controls.Add(lbTo);
            grFilter.Controls.Add(lbFrom);
            grFilter.Location = new System.Drawing.Point(372, 168);
            grFilter.Name = "grFilter";
            grFilter.Size = new System.Drawing.Size(336, 89);
            grFilter.TabIndex = 71;
            grFilter.TabStop = false;
            grFilter.Text = "Filter";
            // 
            // txtTo
            // 
            txtTo.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            txtTo.Location = new System.Drawing.Point(209, 20);
            txtTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtTo.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            txtTo.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            txtTo.Name = "txtTo";
            txtTo.Size = new System.Drawing.Size(120, 23);
            txtTo.TabIndex = 20;
            txtTo.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // txtFrom
            // 
            txtFrom.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            txtFrom.Location = new System.Drawing.Point(57, 20);
            txtFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtFrom.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtFrom.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new System.Drawing.Size(120, 23);
            txtFrom.TabIndex = 19;
            txtFrom.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnFilter
            // 
            btnFilter.Location = new System.Drawing.Point(136, 53);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new System.Drawing.Size(80, 23);
            btnFilter.TabIndex = 18;
            btnFilter.Text = "&Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Location = new System.Drawing.Point(182, 21);
            lbTo.Name = "lbTo";
            lbTo.Size = new System.Drawing.Size(19, 15);
            lbTo.TabIndex = 4;
            lbTo.Text = "To";
            lbTo.Click += lbTo_Click;
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.Location = new System.Drawing.Point(14, 23);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new System.Drawing.Size(35, 15);
            lbFrom.TabIndex = 2;
            lbFrom.Text = "From";
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(483, 139);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(80, 23);
            btnLogin.TabIndex = 72;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new System.Drawing.Point(581, 139);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new System.Drawing.Size(80, 23);
            btnSignUp.TabIndex = 73;
            btnSignUp.Text = "&SignUp";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // Login
            // 
            Login.Dock = System.Windows.Forms.DockStyle.Top;
            Login.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Login.Location = new System.Drawing.Point(0, 0);
            Login.Name = "Login";
            Login.Size = new System.Drawing.Size(740, 30);
            Login.TabIndex = 74;
            Login.Text = "Login";
            Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(386, 139);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(80, 23);
            btnLoad.TabIndex = 75;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAddCart
            // 
            btnAddCart.Location = new System.Drawing.Point(257, 263);
            btnAddCart.Name = "btnAddCart";
            btnAddCart.Size = new System.Drawing.Size(102, 23);
            btnAddCart.TabIndex = 76;
            btnAddCart.Text = "&ChooseTime";
            btnAddCart.UseVisualStyleBackColor = true;
            btnAddCart.Click += btnChooseTime_Click;
            // 
            // btnViewCart
            // 
            btnViewCart.Location = new System.Drawing.Point(372, 263);
            btnViewCart.Name = "btnViewCart";
            btnViewCart.Size = new System.Drawing.Size(102, 23);
            btnViewCart.TabIndex = 77;
            btnViewCart.Text = "&ViewCart";
            btnViewCart.UseVisualStyleBackColor = true;
            btnViewCart.Click += btnViewCart_Click;
            // 
            // btnViewOrder
            // 
            btnViewOrder.Location = new System.Drawing.Point(483, 139);
            btnViewOrder.Name = "btnViewOrder";
            btnViewOrder.Size = new System.Drawing.Size(80, 23);
            btnViewOrder.TabIndex = 78;
            btnViewOrder.Text = "&ViewOrder";
            btnViewOrder.UseVisualStyleBackColor = true;
            btnViewOrder.Click += btnViewOrder_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new System.Drawing.Point(581, 139);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new System.Drawing.Size(80, 23);
            btnLogOut.TabIndex = 79;
            btnLogOut.Text = "&LogOut";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // frmViewCar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(740, 458);
            Controls.Add(btnLogOut);
            Controls.Add(btnViewOrder);
            Controls.Add(btnViewCart);
            Controls.Add(btnAddCart);
            Controls.Add(btnLoad);
            Controls.Add(Login);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogin);
            Controls.Add(grFilter);
            Controls.Add(grSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbCategory);
            Controls.Add(lbMemberName);
            Controls.Add(lbProductID);
            Controls.Add(dgvViewCar);
            Controls.Add(txtCarModel);
            Controls.Add(txtCarPlate);
            Controls.Add(txtCarBrand);
            Controls.Add(txtCarPrice);
            Controls.Add(txtCarName);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmViewCar";
            Text = "Booking Car Page";
            Load += frmViewCar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViewCar).EndInit();
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            grFilter.ResumeLayout(false);
            grFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFrom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.TextBox txtCarPrice;
        private System.Windows.Forms.TextBox txtCarBrand;
        private System.Windows.Forms.TextBox txtCarPlate;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.DataGridView dgvViewCar;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.GroupBox grFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.NumericUpDown txtFrom;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Button btnViewCart;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.NumericUpDown txtTo;
    }
}