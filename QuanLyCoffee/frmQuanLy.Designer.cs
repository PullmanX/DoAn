namespace QuanLyCoffee
{
    partial class frmQuanLy
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mntSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mntHoatDong = new System.Windows.Forms.ToolStripMenuItem();
            this.mntHangTon = new System.Windows.Forms.ToolStripMenuItem();
            this.mntQuanLyNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mntLichLam = new System.Windows.Forms.ToolStripMenuItem();
            this.mntThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntSanPham,
            this.mntQuanLyNV,
            this.mntLichLam,
            this.mntThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1363, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mntSanPham
            // 
            this.mntSanPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntHoatDong,
            this.mntHangTon});
            this.mntSanPham.Name = "mntSanPham";
            this.mntSanPham.Size = new System.Drawing.Size(105, 20);
            this.mntSanPham.Text = "Hàng Trong Kho";
            // 
            // mntHoatDong
            // 
            this.mntHoatDong.Name = "mntHoatDong";
            this.mntHoatDong.Size = new System.Drawing.Size(132, 22);
            this.mntHoatDong.Text = "Hoạt Động";
            // 
            // mntHangTon
            // 
            this.mntHangTon.Name = "mntHangTon";
            this.mntHangTon.Size = new System.Drawing.Size(132, 22);
            this.mntHangTon.Text = "Hàng Tồn";
            // 
            // mntQuanLyNV
            // 
            this.mntQuanLyNV.Name = "mntQuanLyNV";
            this.mntQuanLyNV.Size = new System.Drawing.Size(120, 20);
            this.mntQuanLyNV.Text = "Quản Lý Nhân Viên";
            this.mntQuanLyNV.Click += new System.EventHandler(this.mntQuanLyNV_Click);
            // 
            // mntLichLam
            // 
            this.mntLichLam.Name = "mntLichLam";
            this.mntLichLam.Size = new System.Drawing.Size(112, 20);
            this.mntLichLam.Text = "Sắp Xếp Lịch Làm";
            // 
            // mntThoat
            // 
            this.mntThoat.Name = "mntThoat";
            this.mntThoat.Size = new System.Drawing.Size(74, 20);
            this.mntThoat.Text = "Đăng Xuất";
            this.mntThoat.Click += new System.EventHandler(this.mntThoat_Click);
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1363, 749);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQuanLy";
            this.Text = "Phần Mềm Ocha";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mntThoat;
        private System.Windows.Forms.ToolStripMenuItem mntSanPham;
        private System.Windows.Forms.ToolStripMenuItem mntHoatDong;
        private System.Windows.Forms.ToolStripMenuItem mntHangTon;
        private System.Windows.Forms.ToolStripMenuItem mntQuanLyNV;
        private System.Windows.Forms.ToolStripMenuItem mntLichLam;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

