﻿namespace QuanLyCoffee
{
    partial class frmAdmin
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
            this.components = new System.ComponentModel.Container();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbSearchFoodName = new System.Windows.Forms.TextBox();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbFoodID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbPageBill = new System.Windows.Forms.TextBox();
            this.btnNextBillPage = new System.Windows.Forms.Button();
            this.btnPrevioursBillPage = new System.Windows.Forms.Button();
            this.btnLastBillPage = new System.Windows.Forms.Button();
            this.btnFristBillPage = new System.Windows.Forms.Button();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.USP_GetListBillByDateForReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpFood.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.tpBill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.tcAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateForReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.panel6);
            this.tpFood.Controls.Add(this.panel5);
            this.tpFood.Controls.Add(this.panel4);
            this.tpFood.Controls.Add(this.panel3);
            this.tpFood.Location = new System.Drawing.Point(4, 22);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpFood.Size = new System.Drawing.Size(821, 418);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Nước uống";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbSearchFoodName);
            this.panel6.Controls.Add(this.btnSearchFood);
            this.panel6.Location = new System.Drawing.Point(361, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(283, 52);
            this.panel6.TabIndex = 3;
            // 
            // txbSearchFoodName
            // 
            this.txbSearchFoodName.Location = new System.Drawing.Point(3, 17);
            this.txbSearchFoodName.Name = "txbSearchFoodName";
            this.txbSearchFoodName.Size = new System.Drawing.Size(199, 20);
            this.txbSearchFoodName.TabIndex = 5;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.Location = new System.Drawing.Point(208, 3);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(75, 46);
            this.btnSearchFood.TabIndex = 4;
            this.btnSearchFood.Text = "Tìm";
            this.btnSearchFood.UseVisualStyleBackColor = true;
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(361, 61);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(285, 346);
            this.panel5.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.nmFoodPrice);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(3, 153);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(279, 44);
            this.panel10.TabIndex = 4;
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Location = new System.Drawing.Point(91, 8);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(185, 20);
            this.nmFoodPrice.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbFoodCategory);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(3, 103);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(279, 44);
            this.panel9.TabIndex = 3;
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(91, 9);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(185, 21);
            this.cbFoodCategory.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbFoodName);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(3, 53);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(279, 44);
            this.panel8.TabIndex = 2;
            // 
            // txbFoodName
            // 
            this.txbFoodName.Location = new System.Drawing.Point(91, 8);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(185, 20);
            this.txbFoodName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên món:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbFoodID);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(279, 44);
            this.panel7.TabIndex = 1;
            // 
            // txbFoodID
            // 
            this.txbFoodID.Location = new System.Drawing.Point(91, 8);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.ReadOnly = true;
            this.txbFoodID.Size = new System.Drawing.Size(185, 20);
            this.txbFoodID.TabIndex = 1;
            this.txbFoodID.TextChanged += new System.EventHandler(this.txbFoodID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnShowFood);
            this.panel4.Controls.Add(this.btnEditFood);
            this.panel4.Controls.Add(this.btnDeleteFood);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Location = new System.Drawing.Point(6, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(349, 52);
            this.panel4.TabIndex = 1;
            // 
            // btnShowFood
            // 
            this.btnShowFood.Location = new System.Drawing.Point(246, 3);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(75, 46);
            this.btnShowFood.TabIndex = 3;
            this.btnShowFood.Text = "Xem";
            this.btnShowFood.UseVisualStyleBackColor = true;
            this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.Location = new System.Drawing.Point(165, 3);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(75, 46);
            this.btnEditFood.TabIndex = 2;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(84, 3);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(75, 46);
            this.btnDeleteFood.TabIndex = 1;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(3, 3);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 46);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvFood);
            this.panel3.Location = new System.Drawing.Point(6, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 346);
            this.panel3.TabIndex = 0;
            // 
            // dtgvFood
            // 
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(3, 3);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.Size = new System.Drawing.Size(343, 340);
            this.dtgvFood.TabIndex = 0;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.panel2);
            this.tpBill.Controls.Add(this.panel1);
            this.tpBill.Location = new System.Drawing.Point(4, 22);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(821, 418);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnViewBill);
            this.panel2.Controls.Add(this.dtpkToDate);
            this.panel2.Controls.Add(this.dtpkFromDate);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 26);
            this.panel2.TabIndex = 1;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Location = new System.Drawing.Point(282, 0);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(75, 23);
            this.btnViewBill.TabIndex = 2;
            this.btnViewBill.Text = "Thống kê";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Location = new System.Drawing.Point(435, 3);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(200, 20);
            this.dtpkToDate.TabIndex = 1;
            this.dtpkToDate.ValueChanged += new System.EventHandler(this.dtpkToDate_ValueChanged);
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Location = new System.Drawing.Point(3, 3);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(200, 20);
            this.dtpkFromDate.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbPageBill);
            this.panel1.Controls.Add(this.btnNextBillPage);
            this.panel1.Controls.Add(this.btnPrevioursBillPage);
            this.panel1.Controls.Add(this.btnLastBillPage);
            this.panel1.Controls.Add(this.btnFristBillPage);
            this.panel1.Controls.Add(this.dtgvBill);
            this.panel1.Location = new System.Drawing.Point(6, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 369);
            this.panel1.TabIndex = 0;
            // 
            // txbPageBill
            // 
            this.txbPageBill.Location = new System.Drawing.Point(282, 343);
            this.txbPageBill.Name = "txbPageBill";
            this.txbPageBill.ReadOnly = true;
            this.txbPageBill.Size = new System.Drawing.Size(75, 20);
            this.txbPageBill.TabIndex = 5;
            this.txbPageBill.Text = "1";
            this.txbPageBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbPageBill.TextChanged += new System.EventHandler(this.txbPageBill_TextChanged);
            // 
            // btnNextBillPage
            // 
            this.btnNextBillPage.Location = new System.Drawing.Point(479, 343);
            this.btnNextBillPage.Name = "btnNextBillPage";
            this.btnNextBillPage.Size = new System.Drawing.Size(75, 23);
            this.btnNextBillPage.TabIndex = 4;
            this.btnNextBillPage.Text = "Next";
            this.btnNextBillPage.UseVisualStyleBackColor = true;
            this.btnNextBillPage.Click += new System.EventHandler(this.btnNextBillPage_Click);
            // 
            // btnPrevioursBillPage
            // 
            this.btnPrevioursBillPage.Location = new System.Drawing.Point(84, 343);
            this.btnPrevioursBillPage.Name = "btnPrevioursBillPage";
            this.btnPrevioursBillPage.Size = new System.Drawing.Size(75, 23);
            this.btnPrevioursBillPage.TabIndex = 3;
            this.btnPrevioursBillPage.Text = "Previours";
            this.btnPrevioursBillPage.UseVisualStyleBackColor = true;
            this.btnPrevioursBillPage.Click += new System.EventHandler(this.btnPrevioursBillPage_Click);
            // 
            // btnLastBillPage
            // 
            this.btnLastBillPage.Location = new System.Drawing.Point(560, 344);
            this.btnLastBillPage.Name = "btnLastBillPage";
            this.btnLastBillPage.Size = new System.Drawing.Size(75, 23);
            this.btnLastBillPage.TabIndex = 2;
            this.btnLastBillPage.Text = "Last";
            this.btnLastBillPage.UseVisualStyleBackColor = true;
            this.btnLastBillPage.Click += new System.EventHandler(this.btnLastBillPage_Click);
            // 
            // btnFristBillPage
            // 
            this.btnFristBillPage.Location = new System.Drawing.Point(3, 343);
            this.btnFristBillPage.Name = "btnFristBillPage";
            this.btnFristBillPage.Size = new System.Drawing.Size(75, 23);
            this.btnFristBillPage.TabIndex = 1;
            this.btnFristBillPage.Text = "First";
            this.btnFristBillPage.UseVisualStyleBackColor = true;
            this.btnFristBillPage.Click += new System.EventHandler(this.btnFristBillPage_Click);
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(3, 3);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.Size = new System.Drawing.Size(632, 335);
            this.dtgvBill.TabIndex = 0;
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Controls.Add(this.tpFood);
            this.tcAdmin.Location = new System.Drawing.Point(12, 12);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(829, 444);
            this.tcAdmin.TabIndex = 0;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 476);
            this.Controls.Add(this.tcAdmin);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            this.tpFood.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.tpBill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.tcAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateForReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbSearchFoodName;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown nmFoodPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txbFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbFoodID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnShowFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbPageBill;
        private System.Windows.Forms.Button btnNextBillPage;
        private System.Windows.Forms.Button btnPrevioursBillPage;
        private System.Windows.Forms.Button btnLastBillPage;
        private System.Windows.Forms.Button btnFristBillPage;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.TabControl tcAdmin;
        //private Microsoft.Reporting.WinForms.ReportViewer rpViewer;
        // private System.Windows.Forms.BindingSource USP_GetTableListBindingSource;
        private System.Windows.Forms.BindingSource USP_GetListBillByDateForReportBindingSource;
    }
}