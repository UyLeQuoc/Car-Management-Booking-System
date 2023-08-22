using System;
using System.Windows.Forms;

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
            btnBack = new Button();
            txtIsDeleted = new TextBox();
            lb10 = new Label();
            txtModel = new TextBox();
            txtBrand = new TextBox();
            txtCarPlate = new TextBox();
            grFilter = new GroupBox();
            btnFilter = new Button();
            txtTo = new TextBox();
            lbTo = new Label();
            txtFrom = new TextBox();
            lbFrom = new Label();
            grSearch = new GroupBox();
            radioByName = new RadioButton();
            radioByID = new RadioButton();
            txtSearchValue = new TextBox();
            btnSearch = new Button();
            lbSearch = new Label();
            dgvCarsList = new DataGridView();
            btnDelete = new Button();
            btnNew = new Button();
            btnLoad = new Button();
            lbUnitsInStock = new Label();
            lbUnitPrice = new Label();
            lbWeight = new Label();
            txtPricePerHour = new TextBox();
            lbCategory = new Label();
            txtCarName = new TextBox();
            lbMemberName = new Label();
            txtCarID = new TextBox();
            lbProductID = new Label();
            grFilter.SuspendLayout();
            grSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarsList).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(340, 788);
            btnBack.Margin = new Padding(2, 2, 2, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(124, 35);
            btnBack.TabIndex = 106;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtIsDeleted
            // 
            txtIsDeleted.Enabled = false;
            txtIsDeleted.Location = new System.Drawing.Point(569, 178);
            txtIsDeleted.Margin = new Padding(4, 4, 4, 4);
            txtIsDeleted.Name = "txtIsDeleted";
            txtIsDeleted.Size = new System.Drawing.Size(210, 27);
            txtIsDeleted.TabIndex = 104;
            // 
            // lb10
            // 
            lb10.AutoSize = true;
            lb10.Location = new System.Drawing.Point(462, 182);
            lb10.Margin = new Padding(4, 0, 4, 0);
            lb10.Name = "lb10";
            lb10.Size = new System.Drawing.Size(62, 20);
            lb10.TabIndex = 105;
            lb10.Text = "Deleted";
            // 
            // txtModel
            // 
            txtModel.Enabled = false;
            txtModel.Location = new System.Drawing.Point(569, 124);
            txtModel.Margin = new Padding(4, 4, 4, 4);
            txtModel.Name = "txtModel";
            txtModel.Size = new System.Drawing.Size(210, 27);
            txtModel.TabIndex = 91;
            // 
            // txtBrand
            // 
            txtBrand.Enabled = false;
            txtBrand.Location = new System.Drawing.Point(569, 70);
            txtBrand.Margin = new Padding(4, 4, 4, 4);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new System.Drawing.Size(210, 27);
            txtBrand.TabIndex = 90;
            // 
            // txtCarPlate
            // 
            txtCarPlate.Enabled = false;
            txtCarPlate.Location = new System.Drawing.Point(177, 124);
            txtCarPlate.Margin = new Padding(4, 4, 4, 4);
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
            grFilter.Margin = new Padding(4, 4, 4, 4);
            grFilter.Name = "grFilter";
            grFilter.Padding = new Padding(4, 4, 4, 4);
            grFilter.Size = new System.Drawing.Size(384, 119);
            grFilter.TabIndex = 103;
            grFilter.TabStop = false;
            grFilter.Text = "Filter";
            // 
            // btnFilter
            // 
            btnFilter.Location = new System.Drawing.Point(272, 74);
            btnFilter.Margin = new Padding(4, 4, 4, 4);
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
            txtTo.Margin = new Padding(4, 4, 4, 4);
            txtTo.Name = "txtTo";
            txtTo.Size = new System.Drawing.Size(174, 27);
            txtTo.TabIndex = 15;
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Location = new System.Drawing.Point(22, 79);
            lbTo.Margin = new Padding(4, 0, 4, 0);
            lbTo.Name = "lbTo";
            lbTo.Size = new System.Drawing.Size(25, 20);
            lbTo.TabIndex = 4;
            lbTo.Text = "To";
            // 
            // txtFrom
            // 
            txtFrom.Location = new System.Drawing.Point(73, 26);
            txtFrom.Margin = new Padding(4, 4, 4, 4);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new System.Drawing.Size(174, 27);
            txtFrom.TabIndex = 14;
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.Location = new System.Drawing.Point(22, 35);
            lbFrom.Margin = new Padding(4, 0, 4, 0);
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
            grSearch.Margin = new Padding(4, 4, 4, 4);
            grSearch.Name = "grSearch";
            grSearch.Padding = new Padding(4, 4, 4, 4);
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
            radioByName.Margin = new Padding(4, 4, 4, 4);
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
            radioByID.Margin = new Padding(4, 4, 4, 4);
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
            txtSearchValue.Margin = new Padding(4, 4, 4, 4);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new System.Drawing.Size(134, 27);
            txtSearchValue.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(78, 71);
            btnSearch.Margin = new Padding(4, 4, 4, 4);
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
            lbSearch.Margin = new Padding(4, 0, 4, 0);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new System.Drawing.Size(53, 20);
            lbSearch.TabIndex = 16;
            lbSearch.Text = "Search";
            // 
            // dgvCarsList
            // 
            dgvCarsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarsList.Location = new System.Drawing.Point(57, 433);
            dgvCarsList.Margin = new Padding(4, 4, 4, 4);
            dgvCarsList.Name = "dgvCarsList";
            dgvCarsList.ReadOnly = true;
            dgvCarsList.RowHeadersWidth = 82;
            dgvCarsList.RowTemplate.Height = 25;
            dgvCarsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarsList.Size = new System.Drawing.Size(722, 265);
            dgvCarsList.TabIndex = 101;
            dgvCarsList.CellContentClick += dgvCarsList_CellContentClick;
            dgvCarsList.CellDoubleClick += dgvCarsList_CellDoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new System.Drawing.Point(554, 240);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
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
            btnNew.Margin = new Padding(4, 4, 4, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(124, 31);
            btnNew.TabIndex = 93;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(115, 240);
            btnLoad.Margin = new Padding(4, 4, 4, 4);
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
            lbUnitsInStock.Margin = new Padding(4, 0, 4, 0);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new System.Drawing.Size(52, 20);
            lbUnitsInStock.TabIndex = 100;
            lbUnitsInStock.Text = "Model";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new System.Drawing.Point(462, 74);
            lbUnitPrice.Margin = new Padding(4, 0, 4, 0);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new System.Drawing.Size(48, 20);
            lbUnitPrice.TabIndex = 99;
            lbUnitPrice.Text = "Brand";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new System.Drawing.Point(462, 20);
            lbWeight.Margin = new Padding(4, 0, 4, 0);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new System.Drawing.Size(101, 20);
            lbWeight.TabIndex = 98;
            lbWeight.Text = "Price per hour";
            // 
            // txtPricePerHour
            // 
            txtPricePerHour.Enabled = false;
            txtPricePerHour.Location = new System.Drawing.Point(569, 15);
            txtPricePerHour.Margin = new Padding(4, 4, 4, 4);
            txtPricePerHour.Name = "txtPricePerHour";
            txtPricePerHour.Size = new System.Drawing.Size(210, 27);
            txtPricePerHour.TabIndex = 89;
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Location = new System.Drawing.Point(57, 129);
            lbCategory.Margin = new Padding(4, 0, 4, 0);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new System.Drawing.Size(68, 20);
            lbCategory.TabIndex = 97;
            lbCategory.Text = "Car Plate";
            // 
            // txtCarName
            // 
            txtCarName.Enabled = false;
            txtCarName.Location = new System.Drawing.Point(177, 70);
            txtCarName.Margin = new Padding(4, 4, 4, 4);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(210, 27);
            txtCarName.TabIndex = 87;
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new System.Drawing.Point(57, 74);
            lbMemberName.Margin = new Padding(4, 0, 4, 0);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new System.Drawing.Size(75, 20);
            lbMemberName.TabIndex = 96;
            lbMemberName.Text = "Car Name";
            // 
            // txtCarID
            // 
            txtCarID.Enabled = false;
            txtCarID.Location = new System.Drawing.Point(177, 15);
            txtCarID.Margin = new Padding(4, 4, 4, 4);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(210, 27);
            txtCarID.TabIndex = 86;
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new System.Drawing.Point(57, 20);
            lbProductID.Margin = new Padding(4, 0, 4, 0);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new System.Drawing.Size(50, 20);
            lbProductID.TabIndex = 95;
            lbProductID.Text = "Car ID";
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(843, 720);
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
            Margin = new Padding(2, 2, 2, 2);
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

        private Button btnBack;
        private TextBox txtIsDeleted;
        private Label lb10;
        private TextBox txtModel;
        private TextBox txtBrand;
        private TextBox txtCarPlate;
        private GroupBox grFilter;
        private Button btnFilter;
        private TextBox txtTo;
        private Label lbTo;
        private TextBox txtFrom;
        private Label lbFrom;
        private GroupBox grSearch;
        private RadioButton radioByName;
        private RadioButton radioByID;
        private TextBox txtSearchValue;
        private Button btnSearch;
        private Label lbSearch;
        private DataGridView dgvCarsList;
        private Button btnDelete;
        private Button btnNew;
        private Button btnLoad;
        private Label lbUnitsInStock;
        private Label lbUnitPrice;
        private Label lbWeight;
        private TextBox txtPricePerHour;
        private Label lbCategory;
        private TextBox txtCarName;
        private Label lbMemberName;
        private TextBox txtCarID;
        private Label lbProductID;
    }
}