using System;
using System.Windows.Forms;

namespace CarManagementBookingGUI
{
    partial class frmBookingManagement
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
            txtCreateDate = new TextBox();
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
            dgvBookingsList = new DataGridView();
            lbUnitPrice = new Label();
            lbWeight = new Label();
            txtTotalPrice = new TextBox();
            txtBookingUser = new TextBox();
            lbMemberName = new Label();
            txtBookingID = new TextBox();
            lbProductID = new Label();
            btnLoad = new Button();
            grFilter.SuspendLayout();
            grSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookingsList).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(545, 1088);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(202, 56);
            btnBack.TabIndex = 139;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtCreateDate
            // 
            txtCreateDate.Enabled = false;
            txtCreateDate.Location = new System.Drawing.Point(920, 37);
            txtCreateDate.Margin = new Padding(6);
            txtCreateDate.Name = "txtCreateDate";
            txtCreateDate.Size = new System.Drawing.Size(339, 39);
            txtCreateDate.TabIndex = 131;
            // 
            // grFilter
            // 
            grFilter.Controls.Add(btnFilter);
            grFilter.Controls.Add(txtTo);
            grFilter.Controls.Add(lbTo);
            grFilter.Controls.Add(txtFrom);
            grFilter.Controls.Add(lbFrom);
            grFilter.Enabled = false;
            grFilter.Location = new System.Drawing.Point(635, 297);
            grFilter.Margin = new Padding(6);
            grFilter.Name = "grFilter";
            grFilter.Padding = new Padding(6);
            grFilter.Size = new System.Drawing.Size(624, 190);
            grFilter.TabIndex = 138;
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
            lbTo.Location = new System.Drawing.Point(42, 132);
            lbTo.Margin = new Padding(6, 0, 6, 0);
            lbTo.Name = "lbTo";
            lbTo.Size = new System.Drawing.Size(39, 32);
            lbTo.TabIndex = 4;
            lbTo.Text = "To";
            // 
            // txtFrom
            // 
            txtFrom.Location = new System.Drawing.Point(119, 52);
            txtFrom.Margin = new Padding(6);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new System.Drawing.Size(280, 39);
            txtFrom.TabIndex = 14;
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.Location = new System.Drawing.Point(42, 62);
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
            grSearch.Location = new System.Drawing.Point(87, 297);
            grSearch.Margin = new Padding(6);
            grSearch.Name = "grSearch";
            grSearch.Padding = new Padding(6);
            grSearch.Size = new System.Drawing.Size(536, 190);
            grSearch.TabIndex = 137;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            // 
            // radioByName
            // 
            radioByName.AutoSize = true;
            radioByName.Checked = true;
            radioByName.Location = new System.Drawing.Point(346, 118);
            radioByName.Margin = new Padding(6);
            radioByName.Name = "radioByName";
            radioByName.Size = new System.Drawing.Size(189, 36);
            radioByName.TabIndex = 12;
            radioByName.TabStop = true;
            radioByName.Text = "By UserName";
            radioByName.UseVisualStyleBackColor = true;
            // 
            // radioByID
            // 
            radioByID.AutoSize = true;
            radioByID.Location = new System.Drawing.Point(346, 54);
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
            txtSearchValue.Location = new System.Drawing.Point(109, 52);
            txtSearchValue.Margin = new Padding(6);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new System.Drawing.Size(215, 39);
            txtSearchValue.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(109, 116);
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
            lbSearch.Location = new System.Drawing.Point(15, 62);
            lbSearch.Margin = new Padding(6, 0, 6, 0);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new System.Drawing.Size(85, 32);
            lbSearch.TabIndex = 16;
            lbSearch.Text = "Search";
            // 
            // dgvBookingsList
            // 
            dgvBookingsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookingsList.Location = new System.Drawing.Point(86, 520);
            dgvBookingsList.Margin = new Padding(6);
            dgvBookingsList.Name = "dgvBookingsList";
            dgvBookingsList.ReadOnly = true;
            dgvBookingsList.RowHeadersWidth = 82;
            dgvBookingsList.RowTemplate.Height = 25;
            dgvBookingsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookingsList.Size = new System.Drawing.Size(1173, 547);
            dgvBookingsList.TabIndex = 136;
            dgvBookingsList.CellContentClick += dgvBookingsList_CellContentClick;
            dgvBookingsList.CellDoubleClick += dgvBookingsList_CellDoubleClick;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new System.Drawing.Point(746, 43);
            lbUnitPrice.Margin = new Padding(6, 0, 6, 0);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new System.Drawing.Size(140, 32);
            lbUnitPrice.TabIndex = 135;
            lbUnitPrice.Text = "Create Date";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new System.Drawing.Point(746, 133);
            lbWeight.Margin = new Padding(6, 0, 6, 0);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new System.Drawing.Size(123, 32);
            lbWeight.TabIndex = 134;
            lbWeight.Text = "Total Price";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Enabled = false;
            txtTotalPrice.Location = new System.Drawing.Point(920, 125);
            txtTotalPrice.Margin = new Padding(6);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new System.Drawing.Size(339, 39);
            txtTotalPrice.TabIndex = 130;
            // 
            // txtBookingUser
            // 
            txtBookingUser.Enabled = false;
            txtBookingUser.Location = new System.Drawing.Point(283, 125);
            txtBookingUser.Margin = new Padding(6);
            txtBookingUser.Name = "txtBookingUser";
            txtBookingUser.Size = new System.Drawing.Size(339, 39);
            txtBookingUser.TabIndex = 129;
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new System.Drawing.Point(88, 131);
            lbMemberName.Margin = new Padding(6, 0, 6, 0);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new System.Drawing.Size(156, 32);
            lbMemberName.TabIndex = 133;
            lbMemberName.Text = "Booking User";
            // 
            // txtBookingID
            // 
            txtBookingID.Enabled = false;
            txtBookingID.Location = new System.Drawing.Point(283, 37);
            txtBookingID.Margin = new Padding(6);
            txtBookingID.Name = "txtBookingID";
            txtBookingID.Size = new System.Drawing.Size(339, 39);
            txtBookingID.TabIndex = 128;
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new System.Drawing.Point(88, 45);
            lbProductID.Margin = new Padding(6, 0, 6, 0);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new System.Drawing.Size(132, 32);
            lbProductID.TabIndex = 132;
            lbProductID.Text = "Booking ID";
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(545, 214);
            btnLoad.Margin = new Padding(6);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(202, 50);
            btnLoad.TabIndex = 140;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // frmBookingManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1344, 1188);
            Controls.Add(btnLoad);
            Controls.Add(btnBack);
            Controls.Add(txtCreateDate);
            Controls.Add(grFilter);
            Controls.Add(grSearch);
            Controls.Add(dgvBookingsList);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbWeight);
            Controls.Add(txtTotalPrice);
            Controls.Add(txtBookingUser);
            Controls.Add(lbMemberName);
            Controls.Add(txtBookingID);
            Controls.Add(lbProductID);
            Name = "frmBookingManagement";
            Text = "frmBookingManagement";
            Load += frmBookingManagement_Load;
            grFilter.ResumeLayout(false);
            grFilter.PerformLayout();
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookingsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btnBack;
        private TextBox txtCreateDate;
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
        private DataGridView dgvBookingsList;
        private Label lbUnitPrice;
        private Label lbWeight;
        private TextBox txtTotalPrice;
        private TextBox txtBookingUser;
        private Label lbMemberName;
        private TextBox txtBookingID;
        private Label lbProductID;
        private TextBox txtIsDeleted;
        private Label lb10;
        private TextBox txtModel;
        private TextBox txtCarPlate;
        private Label lbUnitsInStock;
        private Label lbCategory;
        private Button btnLoad;
    }
}