namespace CarManagementBookingGUI
{
    partial class frmModelBrandManagement
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
            groupBox2 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            txtBrandId = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtBrand = new System.Windows.Forms.TextBox();
            btnLoadBrand = new System.Windows.Forms.Button();
            btnNewBrand = new System.Windows.Forms.Button();
            btnUpdateBrand = new System.Windows.Forms.Button();
            btnDeleteBrand = new System.Windows.Forms.Button();
            dgvBrand = new System.Windows.Forms.DataGridView();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            txtModelId = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtModelName = new System.Windows.Forms.TextBox();
            btnLoadModel = new System.Windows.Forms.Button();
            btnNewModel = new System.Windows.Forms.Button();
            btnUpdateModel = new System.Windows.Forms.Button();
            btnDeleteModel = new System.Windows.Forms.Button();
            dgvModel = new System.Windows.Forms.DataGridView();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBrand).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvModel).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtBrandId);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtBrand);
            groupBox2.Controls.Add(btnLoadBrand);
            groupBox2.Controls.Add(btnNewBrand);
            groupBox2.Controls.Add(btnUpdateBrand);
            groupBox2.Controls.Add(btnDeleteBrand);
            groupBox2.Controls.Add(dgvBrand);
            groupBox2.Location = new System.Drawing.Point(12, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(370, 412);
            groupBox2.TabIndex = 107;
            groupBox2.TabStop = false;
            groupBox2.Text = "Brand Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 28);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 15);
            label2.TabIndex = 100;
            label2.Text = "Brand Id";
            // 
            // txtBrandId
            // 
            txtBrandId.Location = new System.Drawing.Point(73, 25);
            txtBrandId.Name = "txtBrandId";
            txtBrandId.Size = new System.Drawing.Size(55, 23);
            txtBrandId.TabIndex = 99;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(134, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 15);
            label1.TabIndex = 27;
            label1.Text = "Brand Name";
            // 
            // txtBrand
            // 
            txtBrand.Location = new System.Drawing.Point(213, 25);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new System.Drawing.Size(139, 23);
            txtBrand.TabIndex = 28;
            // 
            // btnLoadBrand
            // 
            btnLoadBrand.Location = new System.Drawing.Point(16, 63);
            btnLoadBrand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLoadBrand.Name = "btnLoadBrand";
            btnLoadBrand.Size = new System.Drawing.Size(166, 23);
            btnLoadBrand.TabIndex = 95;
            btnLoadBrand.Text = "&Load";
            btnLoadBrand.UseVisualStyleBackColor = true;
            btnLoadBrand.Click += btnLoadBrand_Click;
            // 
            // btnNewBrand
            // 
            btnNewBrand.Enabled = false;
            btnNewBrand.Location = new System.Drawing.Point(186, 63);
            btnNewBrand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNewBrand.Name = "btnNewBrand";
            btnNewBrand.Size = new System.Drawing.Size(166, 23);
            btnNewBrand.TabIndex = 96;
            btnNewBrand.Text = "&New";
            btnNewBrand.UseVisualStyleBackColor = true;
            btnNewBrand.Click += btnNewBrand_Click;
            // 
            // btnUpdateBrand
            // 
            btnUpdateBrand.Enabled = false;
            btnUpdateBrand.Location = new System.Drawing.Point(16, 92);
            btnUpdateBrand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnUpdateBrand.Name = "btnUpdateBrand";
            btnUpdateBrand.Size = new System.Drawing.Size(166, 23);
            btnUpdateBrand.TabIndex = 98;
            btnUpdateBrand.Text = "&Update";
            btnUpdateBrand.UseVisualStyleBackColor = true;
            btnUpdateBrand.Click += btnUpdateBrand_Click;
            // 
            // btnDeleteBrand
            // 
            btnDeleteBrand.Enabled = false;
            btnDeleteBrand.Location = new System.Drawing.Point(186, 92);
            btnDeleteBrand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeleteBrand.Name = "btnDeleteBrand";
            btnDeleteBrand.Size = new System.Drawing.Size(166, 23);
            btnDeleteBrand.TabIndex = 97;
            btnDeleteBrand.Text = "&Delete";
            btnDeleteBrand.UseVisualStyleBackColor = true;
            btnDeleteBrand.Click += btnDeleteBrand_Click;
            // 
            // dgvBrand
            // 
            dgvBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBrand.Location = new System.Drawing.Point(16, 121);
            dgvBrand.Name = "dgvBrand";
            dgvBrand.ReadOnly = true;
            dgvBrand.RowTemplate.Height = 25;
            dgvBrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvBrand.Size = new System.Drawing.Size(336, 277);
            dgvBrand.TabIndex = 42;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtModelId);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtModelName);
            groupBox1.Controls.Add(btnLoadModel);
            groupBox1.Controls.Add(btnNewModel);
            groupBox1.Controls.Add(btnUpdateModel);
            groupBox1.Controls.Add(btnDeleteModel);
            groupBox1.Controls.Add(dgvModel);
            groupBox1.Location = new System.Drawing.Point(405, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(370, 412);
            groupBox1.TabIndex = 108;
            groupBox1.TabStop = false;
            groupBox1.Text = "Model Management";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(16, 28);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 15);
            label3.TabIndex = 100;
            label3.Text = "Model Id";
            // 
            // txtModelId
            // 
            txtModelId.Location = new System.Drawing.Point(73, 25);
            txtModelId.Name = "txtModelId";
            txtModelId.Size = new System.Drawing.Size(55, 23);
            txtModelId.TabIndex = 99;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(134, 28);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(76, 15);
            label4.TabIndex = 27;
            label4.Text = "Model Name";
            // 
            // txtModelName
            // 
            txtModelName.Location = new System.Drawing.Point(213, 25);
            txtModelName.Name = "txtModelName";
            txtModelName.Size = new System.Drawing.Size(139, 23);
            txtModelName.TabIndex = 28;
            // 
            // btnLoadModel
            // 
            btnLoadModel.Location = new System.Drawing.Point(16, 63);
            btnLoadModel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLoadModel.Name = "btnLoadModel";
            btnLoadModel.Size = new System.Drawing.Size(166, 23);
            btnLoadModel.TabIndex = 95;
            btnLoadModel.Text = "&Load";
            btnLoadModel.UseVisualStyleBackColor = true;
            btnLoadModel.Click += btnLoadModel_Click;
            // 
            // btnNewModel
            // 
            btnNewModel.Enabled = false;
            btnNewModel.Location = new System.Drawing.Point(186, 63);
            btnNewModel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNewModel.Name = "btnNewModel";
            btnNewModel.Size = new System.Drawing.Size(166, 23);
            btnNewModel.TabIndex = 96;
            btnNewModel.Text = "&New";
            btnNewModel.UseVisualStyleBackColor = true;
            btnNewModel.Click += btnNewModel_Click;
            // 
            // btnUpdateModel
            // 
            btnUpdateModel.Enabled = false;
            btnUpdateModel.Location = new System.Drawing.Point(16, 92);
            btnUpdateModel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnUpdateModel.Name = "btnUpdateModel";
            btnUpdateModel.Size = new System.Drawing.Size(166, 23);
            btnUpdateModel.TabIndex = 98;
            btnUpdateModel.Text = "&Update";
            btnUpdateModel.UseVisualStyleBackColor = true;
            btnUpdateModel.Click += btnUpdateModel_Click;
            // 
            // btnDeleteModel
            // 
            btnDeleteModel.Enabled = false;
            btnDeleteModel.Location = new System.Drawing.Point(186, 92);
            btnDeleteModel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeleteModel.Name = "btnDeleteModel";
            btnDeleteModel.Size = new System.Drawing.Size(166, 23);
            btnDeleteModel.TabIndex = 97;
            btnDeleteModel.Text = "&Delete";
            btnDeleteModel.UseVisualStyleBackColor = true;
            btnDeleteModel.Click += btnDeleteModel_Click;
            // 
            // dgvModel
            // 
            dgvModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvModel.Location = new System.Drawing.Point(16, 121);
            dgvModel.Name = "dgvModel";
            dgvModel.ReadOnly = true;
            dgvModel.RowTemplate.Height = 25;
            dgvModel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvModel.Size = new System.Drawing.Size(336, 277);
            dgvModel.TabIndex = 42;
            // 
            // frmModelBrandManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(797, 450);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmModelBrandManagement";
            Text = "frmModelBrandManagement";
            Load += frmModelBrandManagement_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBrand).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvModel).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Button btnLoadBrand;
        private System.Windows.Forms.Button btnNewBrand;
        private System.Windows.Forms.Button btnUpdateBrand;
        private System.Windows.Forms.Button btnDeleteBrand;
        private System.Windows.Forms.DataGridView dgvBrand;
        private System.Windows.Forms.TextBox txtBrandId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtModelId;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.Button btnLoadModel;
        private System.Windows.Forms.Button btnNewModel;
        private System.Windows.Forms.Button btnUpdateModel;
        private System.Windows.Forms.Button btnDeleteModel;
        private System.Windows.Forms.DataGridView dgvModel;
    }
}