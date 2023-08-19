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
            btnBack.Location = new System.Drawing.Point(552, 1261);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(202, 56);
            btnBack.TabIndex = 106;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtIsDeleted
            // 
            txtIsDeleted.Enabled = false;
            txtIsDeleted.Location = new System.Drawing.Point(925, 285);
            txtIsDeleted.Margin = new Padding(6);
            txtIsDeleted.Name = "txtIsDeleted";
            txtIsDeleted.Size = new System.Drawing.Size(339, 39);
            txtIsDeleted.TabIndex = 104;
            // 
            // lb10
            // 
            lb10.AutoSize = true;
            lb10.Location = new System.Drawing.Point(751, 291);
            lb10.Margin = new Padding(6, 0, 6, 0);
            lb10.Name = "lb10";
            lb10.Size = new System.Drawing.Size(98, 32);
            lb10.TabIndex = 105;
            lb10.Text = "Deleted";
            // 
            // txtModel
            // 
            txtModel.Enabled = false;
            txtModel.Location = new System.Drawing.Point(925, 198);
            txtModel.Margin = new Padding(6);
            txtModel.Name = "txtModel";
            txtModel.Size = new System.Drawing.Size(339, 39);
            txtModel.TabIndex = 91;
            // 
            // txtBrand
            // 
            txtBrand.Enabled = false;
            txtBrand.Location = new System.Drawing.Point(925, 112);
            txtBrand.Margin = new Padding(6);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new System.Drawing.Size(339, 39);
            txtBrand.TabIndex = 90;
            // 
            // txtCarPlate
            // 
            txtCarPlate.Enabled = false;
            txtCarPlate.Location = new System.Drawing.Point(288, 198);
            txtCarPlate.Margin = new Padding(6);
            txtCarPlate.Name = "txtCarPlate";
            txtCarPlate.Size = new System.Drawing.Size(339, 39);
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
            grFilter.Location = new System.Drawing.Point(642, 470);
            grFilter.Margin = new Padding(6);
            grFilter.Name = "grFilter";
            grFilter.Padding = new Padding(6);
            grFilter.Size = new System.Drawing.Size(624, 190);
            grFilter.TabIndex = 103;
            grFilter.TabStop = false;
            grFilter.Text = "Filter";
            // 
            // btnFilter
            // 
            btnFilter.Location = new System.Drawing.Point(442, 118);
            btnFilter.Margin = new Padding(6);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new System.Drawing.Size(150, 50);
            btnFilter.TabIndex = 18;
            btnFilter.Text = "&Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // txtTo
            // 
            txtTo.Location = new System.Drawing.Point(119, 122);
            txtTo.Margin = new Padding(6);
            txtTo.Name = "txtTo";
            txtTo.Size = new System.Drawing.Size(280, 39);
            txtTo.TabIndex = 15;
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Location = new System.Drawing.Point(36, 126);
            lbTo.Margin = new Padding(6, 0, 6, 0);
            lbTo.Name = "lbTo";
            lbTo.Size = new System.Drawing.Size(39, 32);
            lbTo.TabIndex = 4;
            lbTo.Text = "To";
            // 
            // txtFrom
            // 
            txtFrom.Location = new System.Drawing.Point(119, 42);
            txtFrom.Margin = new Padding(6);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new System.Drawing.Size(280, 39);
            txtFrom.TabIndex = 14;
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.Location = new System.Drawing.Point(36, 56);
            lbFrom.Margin = new Padding(6, 0, 6, 0);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new System.Drawing.Size(69, 32);
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
            grSearch.Location = new System.Drawing.Point(94, 470);
            grSearch.Margin = new Padding(6);
            grSearch.Name = "grSearch";
            grSearch.Padding = new Padding(6);
            grSearch.Size = new System.Drawing.Size(536, 190);
            grSearch.TabIndex = 102;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            // 
            // radioByName
            // 
            radioByName.AutoSize = true;
            radioByName.Checked = true;
            radioByName.Location = new System.Drawing.Point(392, 122);
            radioByName.Margin = new Padding(6);
            radioByName.Name = "radioByName";
            radioByName.Size = new System.Drawing.Size(142, 36);
            radioByName.TabIndex = 12;
            radioByName.TabStop = true;
            radioByName.Text = "By Name";
            radioByName.UseVisualStyleBackColor = true;
            // 
            // radioByID
            // 
            radioByID.AutoSize = true;
            radioByID.Location = new System.Drawing.Point(392, 58);
            radioByID.Margin = new Padding(6);
            radioByID.Name = "radioByID";
            radioByID.Size = new System.Drawing.Size(101, 36);
            radioByID.TabIndex = 11;
            radioByID.TabStop = true;
            radioByID.Text = "By ID";
            radioByID.UseVisualStyleBackColor = true;
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new System.Drawing.Point(127, 42);
            txtSearchValue.Margin = new Padding(6);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new System.Drawing.Size(215, 39);
            txtSearchValue.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(127, 114);
            btnSearch.Margin = new Padding(6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(140, 50);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new System.Drawing.Point(47, 56);
            lbSearch.Margin = new Padding(6, 0, 6, 0);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new System.Drawing.Size(85, 32);
            lbSearch.TabIndex = 16;
            lbSearch.Text = "Search";
            // 
            // dgvCarsList
            // 
            dgvCarsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarsList.Location = new System.Drawing.Point(93, 693);
            dgvCarsList.Margin = new Padding(6);
            dgvCarsList.Name = "dgvCarsList";
            dgvCarsList.ReadOnly = true;
            dgvCarsList.RowHeadersWidth = 82;
            dgvCarsList.RowTemplate.Height = 25;
            dgvCarsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarsList.Size = new System.Drawing.Size(1173, 547);
            dgvCarsList.TabIndex = 101;
            dgvCarsList.CellContentClick += dgvCarsList_CellContentClick;
            dgvCarsList.CellDoubleClick += dgvCarsList_CellDoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new System.Drawing.Point(900, 384);
            btnDelete.Margin = new Padding(6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(202, 50);
            btnDelete.TabIndex = 94;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Enabled = false;
            btnNew.Location = new System.Drawing.Point(552, 384);
            btnNew.Margin = new Padding(6);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(202, 50);
            btnNew.TabIndex = 93;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(187, 384);
            btnLoad.Margin = new Padding(6);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(202, 50);
            btnLoad.TabIndex = 92;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new System.Drawing.Point(751, 206);
            lbUnitsInStock.Margin = new Padding(6, 0, 6, 0);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new System.Drawing.Size(83, 32);
            lbUnitsInStock.TabIndex = 100;
            lbUnitsInStock.Text = "Model";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new System.Drawing.Point(751, 118);
            lbUnitPrice.Margin = new Padding(6, 0, 6, 0);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new System.Drawing.Size(76, 32);
            lbUnitPrice.TabIndex = 99;
            lbUnitPrice.Text = "Brand";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new System.Drawing.Point(751, 32);
            lbWeight.Margin = new Padding(6, 0, 6, 0);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new System.Drawing.Size(164, 32);
            lbWeight.TabIndex = 98;
            lbWeight.Text = "Price per hour";
            // 
            // txtPricePerHour
            // 
            txtPricePerHour.Enabled = false;
            txtPricePerHour.Location = new System.Drawing.Point(925, 24);
            txtPricePerHour.Margin = new Padding(6);
            txtPricePerHour.Name = "txtPricePerHour";
            txtPricePerHour.Size = new System.Drawing.Size(339, 39);
            txtPricePerHour.TabIndex = 89;
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Location = new System.Drawing.Point(93, 206);
            lbCategory.Margin = new Padding(6, 0, 6, 0);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new System.Drawing.Size(108, 32);
            lbCategory.TabIndex = 97;
            lbCategory.Text = "Car Plate";
            // 
            // txtCarName
            // 
            txtCarName.Enabled = false;
            txtCarName.Location = new System.Drawing.Point(288, 112);
            txtCarName.Margin = new Padding(6);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(339, 39);
            txtCarName.TabIndex = 87;
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new System.Drawing.Point(93, 118);
            lbMemberName.Margin = new Padding(6, 0, 6, 0);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new System.Drawing.Size(120, 32);
            lbMemberName.TabIndex = 96;
            lbMemberName.Text = "Car Name";
            // 
            // txtCarID
            // 
            txtCarID.Enabled = false;
            txtCarID.Location = new System.Drawing.Point(288, 24);
            txtCarID.Margin = new Padding(6);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(339, 39);
            txtCarID.TabIndex = 86;
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new System.Drawing.Point(93, 32);
            lbProductID.Margin = new Padding(6, 0, 6, 0);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new System.Drawing.Size(79, 32);
            lbProductID.TabIndex = 95;
            lbProductID.Text = "Car ID";
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1370, 1344);
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