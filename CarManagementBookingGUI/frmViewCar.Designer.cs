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
            txtCarName.Location = new System.Drawing.Point(153, 67);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(257, 27);
            txtCarName.TabIndex = 0;
            txtCarName.TextChanged += txtCarName_TextChanged;
            // 
            // txtCarPrice
            // 
            txtCarPrice.Enabled = false;
            txtCarPrice.Location = new System.Drawing.Point(153, 169);
            txtCarPrice.Name = "txtCarPrice";
            txtCarPrice.Size = new System.Drawing.Size(257, 27);
            txtCarPrice.TabIndex = 1;
            // 
            // txtCarBrand
            // 
            txtCarBrand.Enabled = false;
            txtCarBrand.Location = new System.Drawing.Point(552, 114);
            txtCarBrand.Name = "txtCarBrand";
            txtCarBrand.Size = new System.Drawing.Size(257, 27);
            txtCarBrand.TabIndex = 2;
            // 
            // txtCarPlate
            // 
            txtCarPlate.Enabled = false;
            txtCarPlate.Location = new System.Drawing.Point(153, 118);
            txtCarPlate.Name = "txtCarPlate";
            txtCarPlate.Size = new System.Drawing.Size(257, 27);
            txtCarPlate.TabIndex = 3;
            // 
            // txtCarModel
            // 
            txtCarModel.Enabled = false;
            txtCarModel.Location = new System.Drawing.Point(552, 67);
            txtCarModel.Name = "txtCarModel";
            txtCarModel.Size = new System.Drawing.Size(257, 27);
            txtCarModel.TabIndex = 4;
            // 
            // dgvViewCar
            // 
            dgvViewCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewCar.Location = new System.Drawing.Point(34, 389);
            dgvViewCar.Name = "dgvViewCar";
            dgvViewCar.RowHeadersWidth = 51;
            dgvViewCar.RowTemplate.Height = 29;
            dgvViewCar.Size = new System.Drawing.Size(775, 199);
            dgvViewCar.TabIndex = 5;
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Location = new System.Drawing.Point(34, 172);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new System.Drawing.Size(96, 20);
            lbCategory.TabIndex = 67;
            lbCategory.Text = "PriceperHour";
            lbCategory.Click += lbCategory_Click;
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new System.Drawing.Point(34, 121);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new System.Drawing.Size(68, 20);
            lbMemberName.TabIndex = 66;
            lbMemberName.Text = "Car Plate";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new System.Drawing.Point(34, 70);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new System.Drawing.Size(75, 20);
            lbProductID.TabIndex = 65;
            lbProductID.Text = "Car Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(447, 70);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 20);
            label1.TabIndex = 68;
            label1.Text = "Car Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(447, 117);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 20);
            label2.TabIndex = 69;
            label2.Text = "Car Brand";
            // 
            // grSearch
            // 
            grSearch.Controls.Add(txtSearchValue);
            grSearch.Controls.Add(btnSearch);
            grSearch.Controls.Add(lbSearch);
            grSearch.Location = new System.Drawing.Point(34, 224);
            grSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grSearch.Name = "grSearch";
            grSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grSearch.Size = new System.Drawing.Size(376, 119);
            grSearch.TabIndex = 70;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new System.Drawing.Point(88, 25);
            txtSearchValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new System.Drawing.Size(249, 27);
            txtSearchValue.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(88, 71);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(120, 31);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new System.Drawing.Point(33, 31);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new System.Drawing.Size(53, 20);
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
            grFilter.Location = new System.Drawing.Point(425, 224);
            grFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grFilter.Name = "grFilter";
            grFilter.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grFilter.Size = new System.Drawing.Size(384, 119);
            grFilter.TabIndex = 71;
            grFilter.TabStop = false;
            grFilter.Text = "Filter";
            // 
            // txtTo
            // 
            txtTo.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            txtTo.Location = new System.Drawing.Point(239, 25);
            txtTo.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtTo.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            txtTo.Name = "txtTo";
            txtTo.Size = new System.Drawing.Size(137, 27);
            txtTo.TabIndex = 20;
            txtTo.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // txtFrom
            // 
            txtFrom.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            txtFrom.Location = new System.Drawing.Point(65, 26);
            txtFrom.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtFrom.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new System.Drawing.Size(137, 27);
            txtFrom.TabIndex = 19;
            txtFrom.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnFilter
            // 
            btnFilter.Location = new System.Drawing.Point(155, 71);
            btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new System.Drawing.Size(91, 31);
            btnFilter.TabIndex = 18;
            btnFilter.Text = "&Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Location = new System.Drawing.Point(208, 28);
            lbTo.Name = "lbTo";
            lbTo.Size = new System.Drawing.Size(25, 20);
            lbTo.TabIndex = 4;
            lbTo.Text = "To";
            lbTo.Click += lbTo_Click;
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.Location = new System.Drawing.Point(16, 31);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new System.Drawing.Size(43, 20);
            lbFrom.TabIndex = 2;
            lbFrom.Text = "From";
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(552, 185);
            btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(91, 31);
            btnLogin.TabIndex = 72;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new System.Drawing.Point(664, 185);
            btnSignUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new System.Drawing.Size(91, 31);
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
            Login.Size = new System.Drawing.Size(846, 40);
            Login.TabIndex = 74;
            Login.Text = "Login";
            Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(441, 185);
            btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(91, 31);
            btnLoad.TabIndex = 75;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAddCart
            // 
            btnAddCart.Location = new System.Drawing.Point(294, 351);
            btnAddCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAddCart.Name = "btnAddCart";
            btnAddCart.Size = new System.Drawing.Size(116, 31);
            btnAddCart.TabIndex = 76;
            btnAddCart.Text = "&ChooseTime";
            btnAddCart.UseVisualStyleBackColor = true;
            btnAddCart.Click += btnChooseTime_Click;
            // 
            // btnViewCart
            // 
            btnViewCart.Location = new System.Drawing.Point(425, 351);
            btnViewCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnViewCart.Name = "btnViewCart";
            btnViewCart.Size = new System.Drawing.Size(116, 31);
            btnViewCart.TabIndex = 77;
            btnViewCart.Text = "&ViewCart";
            btnViewCart.UseVisualStyleBackColor = true;
            btnViewCart.Click += btnViewCart_Click;
            // 
            // btnViewOrder
            // 
            btnViewOrder.Location = new System.Drawing.Point(552, 185);
            btnViewOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnViewOrder.Name = "btnViewOrder";
            btnViewOrder.Size = new System.Drawing.Size(91, 31);
            btnViewOrder.TabIndex = 78;
            btnViewOrder.Text = "&ViewOrder";
            btnViewOrder.UseVisualStyleBackColor = true;
            btnViewOrder.Click += btnViewOrder_Click;
            // 
            // frmViewCar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(846, 611);
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
            Name = "frmViewCar";
            Text = "Form1";
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
        private System.Windows.Forms.NumericUpDown txtTo;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Button btnViewCart;
        private System.Windows.Forms.Button btnViewOrder;
    }
}