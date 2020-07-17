namespace QuanLyCoffee
{
    partial class FrmQLNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLNhanVien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbonhomquyen = new System.Windows.Forms.ComboBox();
            this.lblGoLai = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtGoLai = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optNu = new System.Windows.Forms.RadioButton();
            this.optNam = new System.Windows.Forms.RadioButton();
            this.lvNhanVien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnthem = new System.Windows.Forms.ToolStripButton();
            this.btnsua = new System.Windows.Forms.ToolStripButton();
            this.btnxoa = new System.Windows.Forms.ToolStripButton();
            this.btnluu = new System.Windows.Forms.ToolStripButton();
            this.btnhoan = new System.Windows.Forms.ToolStripButton();
            this.btnthoat = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbonhomquyen);
            this.groupBox1.Controls.Add(this.lblGoLai);
            this.groupBox1.Controls.Add(this.lblMatKhau);
            this.groupBox1.Controls.Add(this.txtGoLai);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(498, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 348);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // cbonhomquyen
            // 
            this.cbonhomquyen.FormattingEnabled = true;
            this.cbonhomquyen.Location = new System.Drawing.Point(159, 284);
            this.cbonhomquyen.Name = "cbonhomquyen";
            this.cbonhomquyen.Size = new System.Drawing.Size(151, 21);
            this.cbonhomquyen.TabIndex = 35;
            // 
            // lblGoLai
            // 
            this.lblGoLai.BackColor = System.Drawing.Color.Transparent;
            this.lblGoLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoLai.Location = new System.Drawing.Point(31, 109);
            this.lblGoLai.Name = "lblGoLai";
            this.lblGoLai.Size = new System.Drawing.Size(99, 16);
            this.lblGoLai.TabIndex = 34;
            this.lblGoLai.Text = "Gõ lại Mật mã";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(31, 65);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(80, 16);
            this.lblMatKhau.TabIndex = 33;
            this.lblMatKhau.Text = "Mật mã";
            // 
            // txtGoLai
            // 
            this.txtGoLai.Location = new System.Drawing.Point(159, 105);
            this.txtGoLai.Name = "txtGoLai";
            this.txtGoLai.PasswordChar = '*';
            this.txtGoLai.Size = new System.Drawing.Size(151, 20);
            this.txtGoLai.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(159, 61);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(151, 20);
            this.txtMatKhau.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên nhân viên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(159, 152);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(191, 20);
            this.txtTenNV.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã Nhân viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(159, 19);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(107, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Quyền đăng nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optNu);
            this.groupBox2.Controls.Add(this.optNam);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 69);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giới tính";
            // 
            // optNu
            // 
            this.optNu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.optNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNu.Location = new System.Drawing.Point(141, 24);
            this.optNu.Name = "optNu";
            this.optNu.Size = new System.Drawing.Size(64, 16);
            this.optNu.TabIndex = 1;
            this.optNu.Text = "Nữ";
            // 
            // optNam
            // 
            this.optNam.Checked = true;
            this.optNam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.optNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNam.Location = new System.Drawing.Point(22, 24);
            this.optNam.Name = "optNam";
            this.optNam.Size = new System.Drawing.Size(64, 16);
            this.optNam.TabIndex = 0;
            this.optNam.TabStop = true;
            this.optNam.Text = "Nam";
            // 
            // lvNhanVien
            // 
            this.lvNhanVien.BackColor = System.Drawing.Color.White;
            this.lvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvNhanVien.FullRowSelect = true;
            this.lvNhanVien.GridLines = true;
            this.lvNhanVien.HideSelection = false;
            this.lvNhanVien.Location = new System.Drawing.Point(31, 12);
            this.lvNhanVien.Name = "lvNhanVien";
            this.lvNhanVien.Size = new System.Drawing.Size(425, 522);
            this.lvNhanVien.TabIndex = 41;
            this.lvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lvNhanVien.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã NV";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Nhân viên";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giới tính";
            this.columnHeader4.Width = 65;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quyền truy cập";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mật mã";
            this.columnHeader6.Width = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.toolStrip1);
            this.groupBox5.Location = new System.Drawing.Point(457, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(429, 62);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthem,
            this.toolStripSeparator1,
            this.btnsua,
            this.toolStripSeparator2,
            this.btnxoa,
            this.toolStripSeparator3,
            this.btnluu,
            this.toolStripSeparator4,
            this.btnhoan,
            this.toolStripSeparator5,
            this.btnthoat,
            this.toolStripSeparator6});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(423, 43);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 43);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(62, 40);
            this.btnthem.Text = " &Thêm";
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(61, 40);
            this.btnsua.Text = "   &Sửa ";
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(61, 40);
            this.btnxoa.Text = "   &Xoá ";
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(60, 40);
            this.btnluu.Text = "   &Lưu ";
            // 
            // btnhoan
            // 
            this.btnhoan.Enabled = false;
            this.btnhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnhoan.Image")));
            this.btnhoan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnhoan.Name = "btnhoan";
            this.btnhoan.Size = new System.Drawing.Size(66, 40);
            this.btnhoan.Text = "  &Hoãn ";
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(64, 40);
            this.btnthoat.Text = " T&hoát ";
            // 
            // FrmQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 544);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvNhanVien);
            this.Controls.Add(this.groupBox5);
            this.Name = "FrmQLNhanVien";
            this.Text = "FrmQLNhanVien";
            this.Load += new System.EventHandler(this.FrmQLNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbonhomquyen;
        private System.Windows.Forms.Label lblGoLai;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtGoLai;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optNu;
        private System.Windows.Forms.RadioButton optNam;
        private System.Windows.Forms.ListView lvNhanVien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnthem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnsua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnxoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnluu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnhoan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnthoat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}