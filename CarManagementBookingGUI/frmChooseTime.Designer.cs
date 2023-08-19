namespace CarManagementBookingGUI
{
    partial class frmChooseTime
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
            txtDate = new System.Windows.Forms.DateTimePicker();
            txtExpried = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtDate
            // 
            txtDate.Location = new System.Drawing.Point(89, 88);
            txtDate.Name = "txtDate";
            txtDate.Size = new System.Drawing.Size(250, 27);
            txtDate.TabIndex = 0;
            // 
            // txtExpried
            // 
            txtExpried.Location = new System.Drawing.Point(454, 88);
            txtExpried.Name = "txtExpried";
            txtExpried.Size = new System.Drawing.Size(250, 27);
            txtExpried.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(776, 49);
            label1.TabIndex = 2;
            label1.Text = "DetailBooking";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(89, 65);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 20);
            label2.TabIndex = 3;
            label2.Text = "BookingDate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(454, 65);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(114, 20);
            label3.TabIndex = 4;
            label3.Text = "BookingExpired";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(274, 124);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(103, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add To Cart";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += AddToCart_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(393, 124);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(99, 29);
            button2.TabIndex = 6;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmCarDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(776, 165);
            Controls.Add(button2);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtExpried);
            Controls.Add(txtDate);
            Name = "frmCarDetail";
            Text = "CarDetailBooking";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.DateTimePicker txtExpried;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
    }
}