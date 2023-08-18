namespace CarManagementBookingGUI
{
    partial class frmCarManagement
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
            txtIsDeleted = new System.Windows.Forms.TextBox();
            lb10 = new System.Windows.Forms.Label();
            txtModel = new System.Windows.Forms.TextBox();
            txtBrand = new System.Windows.Forms.TextBox();
            txtCarPlate = new System.Windows.Forms.TextBox();
            grFilter = new System.Windows.Forms.GroupBox();
            btnFilter = new System.Windows.Forms.Button();
            txtTo = new System.Windows.Forms.TextBox();
            lbTo = new System.Windows.Forms.Label();
            txtFrom = new System.Windows.Forms.TextBox();
            lbFrom = new System.Windows.Forms.Label();
            grSearch = new System.Windows.Forms.GroupBox();
            radioByName = new System.Windows.Forms.RadioButton();
            radioByID = new System.Windows.Forms.RadioButton();
            txtSearchValue = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            lbSearch = new System.Windows.Forms.Label();
            dgvCarsList = new System.Windows.Forms.DataGridView();
            btnDelete = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            lbUnitsInStock = new System.Windows.Forms.Label();
            lbUnitPrice = new System.Windows.Forms.Label();
            lbWeight = new System.Windows.Forms.Label();
            txtPricePerHour = new System.Windows.Forms.TextBox();
            lbCategory = new System.Windows.Forms.Label();
            txtCarName = new System.Windows.Forms.TextBox();
            lbMemberName = new System.Windows.Forms.Label();
            txtCarID = new System.Windows.Forms.TextBox();
            lbProductID = new System.Windows.Forms.Label();
            grFilter.SuspendLayout();
            grSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarsList).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(340, 788);
            btnBack.Margin = new System.Windows.Forms.Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(124, 35);
            btnBack.TabIndex = 106;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // txtIsDeleted
            // 
            txtIsDeleted.Enabled = false;
            txtIsDeleted.Location = new System.Drawing.Point(569, 178);
            txtIsDeleted.Margin = new System.Windows.Forms.Padding(4);
            txtIsDeleted.Name = "txtIsDeleted";
            txtIsDeleted.Size = new System.Drawing.Size(210, 27);
            txtIsDeleted.TabIndex = 104;
            // 
            // lb10
            // 
            lb10.AutoSize = true;
            lb10.Location = new System.Drawing.Point(462, 182);
            lb10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lb10.Name = "lb10";
            lb10.Size = new System.Drawing.Size(62, 20);
            lb10.TabIndex = 105;
            lb10.Text = "Deleted";
            // 
            // txtModel
            // 
            txtModel.Enabled = false;
            txtModel.Location = new System.Drawing.Point(569, 124);
            txtModel.Margin = new System.Windows.Forms.Padding(4);
            txtModel.Name = "txtModel";
            txtModel.Size = new System.Drawing.Size(210, 27);
            txtModel.TabIndex = 91;
            // 
            // txtBrand
            // 
            txtBrand.Enabled = false;
            txtBrand.Location = new System.Drawing.Point(569, 70);
            txtBrand.Margin = new System.Windows.Forms.Padding(4);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new System.Drawing.Size(210, 27);
            txtBrand.TabIndex = 90;
            // 
            // txtCarPlate
            // 
            txtCarPlate.Enabled = false;
            txtCarPlate.Location = new System.Drawing.Point(177, 124);
            txtCarPlate.Margin = new System.Windows.Forms.Padding(4);
            txtCarPlate.Name = "txtCarPlate";
            txtCarPlate.Size = new System.Drawing.Size(210, 27);
            txtCarPlate.TabIndex = 88;
            // 
            // grFilter
            // 
            grFilter.Controls.Add(btnFilter);
            grFilter.Controls.Add(txtTo);
            grFilter.Controls.Add(lbTo);
            grFilter.Controls.Add(txtFrom);
            grFilter.Controls.Add(lbFrom);
            grFilter.Enabled = false;
            grFilter.Location = new System.Drawing.Point(395, 294);
            grFilter.Margin = new System.Windows.Forms.Padding(4);
            grFilter.Name = "grFilter";
            grFilter.Padding = new System.Windows.Forms.Padding(4);
            grFilter.Size = new System.Drawing.Size(384, 119);
            grFilter.TabIndex = 103;
            grFilter.TabStop = false;
            grFilter.Text = "Filter";
            // 
            // btnFilter
            // 
            btnFilter.Location = new System.Drawing.Point(272, 74);
            btnFilter.Margin = new System.Windows.Forms.Padding(4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new System.Drawing.Size(92, 31);
            btnFilter.TabIndex = 18;
            btnFilter.Text = "&Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // txtTo
            // 
            txtTo.Location = new System.Drawing.Point(73, 76);
            txtTo.Margin = new System.Windows.Forms.Padding(4);
            txtTo.Name = "txtTo";
            txtTo.Size = new System.Drawing.Size(174, 27);
            txtTo.TabIndex = 15;
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Location = new System.Drawing.Point(22, 79);
            lbTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbTo.Name = "lbTo";
            lbTo.Size = new System.Drawing.Size(25, 20);
            lbTo.TabIndex = 4;
            lbTo.Text = "To";
            // 
            // txtFrom
            // 
            txtFrom.Location = new System.Drawing.Point(73, 26);
            txtFrom.Margin = new System.Windows.Forms.Padding(4);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new System.Drawing.Size(174, 27);
            txtFrom.TabIndex = 14;
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.Location = new System.Drawing.Point(22, 35);
            lbFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new System.Drawing.Size(43, 20);
            lbFrom.TabIndex = 2;
            lbFrom.Text = "From";
            // 
            // grSearch
            // 
            grSearch.Controls.Add(radioByName);
            grSearch.Controls.Add(radioByID);
            grSearch.Controls.Add(txtSearchValue);
            grSearch.Controls.Add(btnSearch);
            grSearch.Controls.Add(lbSearch);
            grSearch.Enabled = false;
            grSearch.Location = new System.Drawing.Point(58, 294);
            grSearch.Margin = new System.Windows.Forms.Padding(4);
            grSearch.Name = "grSearch";
            grSearch.Padding = new System.Windows.Forms.Padding(4);
            grSearch.Size = new System.Drawing.Size(330, 119);
            grSearch.TabIndex = 102;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            // 
            // radioByName
            // 
            radioByName.AutoSize = true;
            radioByName.Checked = true;
            radioByName.Location = new System.Drawing.Point(241, 76);
            radioByName.Margin = new System.Windows.Forms.Padding(4);
            radioByName.Name = "radioByName";
            radioByName.Size = new System.Drawing.Size(90, 24);
            radioByName.TabIndex = 12;
            radioByName.TabStop = true;
            radioByName.Text = "By Name";
            radioByName.UseVisualStyleBackColor = true;
            // 
            // radioByID
            // 
            radioByID.AutoSize = true;
            radioByID.Location = new System.Drawing.Point(241, 36);
            radioByID.Margin = new System.Windows.Forms.Padding(4);
            radioByID.Name = "radioByID";
            radioByID.Size = new System.Drawing.Size(65, 24);
            radioByID.TabIndex = 11;
            radioByID.TabStop = true;
            radioByID.Text = "By ID";
            radioByID.UseVisualStyleBackColor = true;
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new System.Drawing.Point(78, 26);
            txtSearchValue.Margin = new System.Windows.Forms.Padding(4);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new System.Drawing.Size(134, 27);
            txtSearchValue.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(78, 71);
            btnSearch.Margin = new System.Windows.Forms.Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(86, 31);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new System.Drawing.Point(29, 35);
            lbSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new System.Drawing.Size(53, 20);
            lbSearch.TabIndex = 16;
            lbSearch.Text = "Search";
            // 
            // dgvCarsList
            // 
            dgvCarsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarsList.Location = new System.Drawing.Point(57, 433);
            dgvCarsList.Margin = new System.Windows.Forms.Padding(4);
            dgvCarsList.Name = "dgvCarsList";
            dgvCarsList.ReadOnly = true;
            dgvCarsList.RowHeadersWidth = 82;
            dgvCarsList.RowTemplate.Height = 25;
            dgvCarsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCarsList.Size = new System.Drawing.Size(722, 342);
            dgvCarsList.TabIndex = 101;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new System.Drawing.Point(554, 240);
            btnDelete.Margin = new System.Windows.Forms.Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(124, 31);
            btnDelete.TabIndex = 94;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Enabled = false;
            btnNew.Location = new System.Drawing.Point(340, 240);
            btnNew.Margin = new System.Windows.Forms.Padding(4);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(124, 31);
            btnNew.TabIndex = 93;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(115, 240);
            btnLoad.Margin = new System.Windows.Forms.Padding(4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(124, 31);
            btnLoad.TabIndex = 92;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new System.Drawing.Point(462, 129);
            lbUnitsInStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new System.Drawing.Size(52, 20);
            lbUnitsInStock.TabIndex = 100;
            lbUnitsInStock.Text = "Model";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new System.Drawing.Point(462, 74);
            lbUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new System.Drawing.Size(48, 20);
            lbUnitPrice.TabIndex = 99;
            lbUnitPrice.Text = "Brand";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new System.Drawing.Point(462, 20);
            lbWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new System.Drawing.Size(101, 20);
            lbWeight.TabIndex = 98;
            lbWeight.Text = "Price per hour";
            // 
            // txtPricePerHour
            // 
            txtPricePerHour.Enabled = false;
            txtPricePerHour.Location = new System.Drawing.Point(569, 15);
            txtPricePerHour.Margin = new System.Windows.Forms.Padding(4);
            txtPricePerHour.Name = "txtPricePerHour";
            txtPricePerHour.Size = new System.Drawing.Size(210, 27);
            txtPricePerHour.TabIndex = 89;
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Location = new System.Drawing.Point(57, 129);
            lbCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new System.Drawing.Size(68, 20);
            lbCategory.TabIndex = 97;
            lbCategory.Text = "Car Plate";
            // 
            // txtCarName
            // 
            txtCarName.Enabled = false;
            txtCarName.Location = new System.Drawing.Point(177, 70);
            txtCarName.Margin = new System.Windows.Forms.Padding(4);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(210, 27);
            txtCarName.TabIndex = 87;
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new System.Drawing.Point(57, 74);
            lbMemberName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new System.Drawing.Size(75, 20);
            lbMemberName.TabIndex = 96;
            lbMemberName.Text = "Car Name";
            // 
            // txtCarID
            // 
            txtCarID.Enabled = false;
            txtCarID.Location = new System.Drawing.Point(177, 15);
            txtCarID.Margin = new System.Windows.Forms.Padding(4);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(210, 27);
            txtCarID.TabIndex = 86;
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new System.Drawing.Point(57, 20);
            lbProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new System.Drawing.Size(50, 20);
            lbProductID.TabIndex = 95;
            lbProductID.Text = "Car ID";
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(842, 659);
            Controls.Add(btnBack);
            Controls.Add(txtIsDeleted);
            Controls.Add(lb10);
            Controls.Add(txtModel);
            Controls.Add(txtBrand);
            Controls.Add(txtCarPlate);
            Controls.Add(grFilter);
            Controls.Add(grSearch);
            Controls.Add(dgvCarsList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(lbUnitsInStock);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbWeight);
            Controls.Add(txtPricePerHour);
            Controls.Add(lbCategory);
            Controls.Add(txtCarName);
            Controls.Add(lbMemberName);
            Controls.Add(txtCarID);
            Controls.Add(lbProductID);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "frmCarManagement";
            Text = "frmCarManagement";
            Load += frmCarManagement_Load;
            grFilter.ResumeLayout(false);
            grFilter.PerformLayout();
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtIsDeleted;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtCarPlate;
        private System.Windows.Forms.GroupBox grFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.RadioButton radioByName;
        private System.Windows.Forms.RadioButton radioByID;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.DataGridView dgvCarsList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lbUnitsInStock;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.TextBox txtPricePerHour;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.Label lbProductID;
    }
}