namespace QuanLyCoffee
{
    partial class frmPhieuNhapCT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCurrentIndex = new System.Windows.Forms.TextBox();
            this.txtMaHang_old = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvPhieuNhapCtiet = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sophieunhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.txtGiaNhap = new System.Windows.Forms.MaskedTextBox();
            this.txtSoLuong = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoPhieuNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTenHang = new System.Windows.Forms.ComboBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhapCtiet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCurrentIndex
            // 
            this.txtCurrentIndex.Location = new System.Drawing.Point(15, 471);
            this.txtCurrentIndex.Name = "txtCurrentIndex";
            this.txtCurrentIndex.Size = new System.Drawing.Size(78, 20);
            this.txtCurrentIndex.TabIndex = 36;
            this.txtCurrentIndex.Text = "0";
            this.txtCurrentIndex.Visible = false;
            // 
            // txtMaHang_old
            // 
            this.txtMaHang_old.Location = new System.Drawing.Point(23, 165);
            this.txtMaHang_old.Name = "txtMaHang_old";
            this.txtMaHang_old.Size = new System.Drawing.Size(100, 20);
            this.txtMaHang_old.TabIndex = 35;
            this.txtMaHang_old.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(645, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "vnđ";
            // 
            // dgvPhieuNhapCtiet
            // 
            this.dgvPhieuNhapCtiet.AllowUserToAddRows = false;
            this.dgvPhieuNhapCtiet.AllowUserToDeleteRows = false;
            this.dgvPhieuNhapCtiet.AllowUserToResizeColumns = false;
            this.dgvPhieuNhapCtiet.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPhieuNhapCtiet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhieuNhapCtiet.ColumnHeadersHeight = 25;
            this.dgvPhieuNhapCtiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPhieuNhapCtiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenHang,
            this.SoLuong,
            this.GiaNhap,
            this.Sophieunhap});
            this.dgvPhieuNhapCtiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPhieuNhapCtiet.Location = new System.Drawing.Point(15, 194);
            this.dgvPhieuNhapCtiet.MultiSelect = false;
            this.dgvPhieuNhapCtiet.Name = "dgvPhieuNhapCtiet";
            this.dgvPhieuNhapCtiet.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPhieuNhapCtiet.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPhieuNhapCtiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhapCtiet.Size = new System.Drawing.Size(656, 271);
            this.dgvPhieuNhapCtiet.TabIndex = 33;
            this.dgvPhieuNhapCtiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhapCtiet_CellClick);
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã hàng";
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
            this.MaHang.Width = 120;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "Tên hàng";
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            this.TenHang.Width = 250;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            this.GiaNhap.Width = 120;
            // 
            // Sophieunhap
            // 
            this.Sophieunhap.DataPropertyName = "Sophieunhap";
            this.Sophieunhap.HeaderText = "so phieu nhap";
            this.Sophieunhap.Name = "Sophieunhap";
            this.Sophieunhap.ReadOnly = true;
            this.Sophieunhap.Visible = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(596, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(503, 165);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 30;
            this.btnCapNhat.Text = "&Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click_1);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(422, 165);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 31;
            this.btnThemMoi.Text = "&Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Visible = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(545, 132);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(100, 20);
            this.txtGiaNhap.TabIndex = 25;
            this.txtGiaNhap.Text = "0";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(372, 132);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(77, 20);
            this.txtSoLuong.TabIndex = 24;
            this.txtSoLuong.Text = "1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboNgayNhap);
            this.panel1.Controls.Add(this.txtGhiChu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboMaNV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSoPhieuNhap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 70);
            this.panel1.TabIndex = 20;
            // 
            // cboNgayNhap
            // 
            this.cboNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.cboNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cboNgayNhap.Location = new System.Drawing.Point(267, 9);
            this.cboNgayNhap.Name = "cboNgayNhap";
            this.cboNgayNhap.Size = new System.Drawing.Size(94, 20);
            this.cboNgayNhap.TabIndex = 8;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(82, 39);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(577, 20);
            this.txtGhiChu.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ghi chú";
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(463, 8);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(196, 21);
            this.cboMaNV.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Người nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày nhập";
            // 
            // txtSoPhieuNhap
            // 
            this.txtSoPhieuNhap.Location = new System.Drawing.Point(82, 9);
            this.txtSoPhieuNhap.Name = "txtSoPhieuNhap";
            this.txtSoPhieuNhap.ReadOnly = true;
            this.txtSoPhieuNhap.Size = new System.Drawing.Size(89, 20);
            this.txtSoPhieuNhap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số phiếu nhập";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Tên hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Mã hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Giá nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Số lượng";
            // 
            // cboTenHang
            // 
            this.cboTenHang.FormattingEnabled = true;
            this.cboTenHang.Location = new System.Drawing.Point(121, 131);
            this.cboTenHang.Name = "cboTenHang";
            this.cboTenHang.Size = new System.Drawing.Size(178, 21);
            this.cboTenHang.TabIndex = 23;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(15, 132);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(100, 20);
            this.txtMaHang.TabIndex = 22;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(583, 471);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Chi tiết hàng nhập:";
            // 
            // frmPhieuNhapCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(694, 503);
            this.Controls.Add(this.txtCurrentIndex);
            this.Controls.Add(this.txtMaHang_old);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvPhieuNhapCtiet);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboTenHang);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhieuNhapCT";
            this.Text = "frmPhieuNhapCT";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhapCtiet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCurrentIndex;
        private System.Windows.Forms.TextBox txtMaHang_old;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvPhieuNhapCtiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sophieunhap;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.MaskedTextBox txtGiaNhap;
        private System.Windows.Forms.MaskedTextBox txtSoLuong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker cboNgayNhap;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoPhieuNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTenHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label5;

    }
}