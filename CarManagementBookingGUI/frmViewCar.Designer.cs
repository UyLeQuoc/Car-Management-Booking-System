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
            SuspendLayout();
            // 
            // frmViewCar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1516, 1368);
            Name = "frmViewCar";
            Text = "Car Management";
            ResumeLayout(false);
        }

        #endregion

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
        private System.Windows.Forms.RadioButton radioStock;
        private System.Windows.Forms.RadioButton radioPrice;
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
        private System.Windows.Forms.Button btnBack;
    }
}