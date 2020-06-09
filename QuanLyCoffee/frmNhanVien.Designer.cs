namespace QuanLyCoffee
{
    partial class frmNhanVien
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
            this.mntNKHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mntKhuVuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mntThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntNKHD,
            this.mntKhuVuc,
            this.mntThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mntNKHD
            // 
            this.mntNKHD.Name = "mntNKHD";
            this.mntNKHD.Size = new System.Drawing.Size(66, 20);
            this.mntNKHD.Text = "Hóa Đơn";
            this.mntNKHD.Click += new System.EventHandler(this.mntNKHD_Click);
            // 
            // mntKhuVuc
            // 
            this.mntKhuVuc.Name = "mntKhuVuc";
            this.mntKhuVuc.Size = new System.Drawing.Size(63, 20);
            this.mntKhuVuc.Text = "Khu Vực";
            // 
            // mntThoat
            // 
            this.mntThoat.Name = "mntThoat";
            this.mntThoat.Size = new System.Drawing.Size(74, 20);
            this.mntThoat.Text = "Đăng Xuất";
            this.mntThoat.Click += new System.EventHandler(this.mntThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMenu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn Mới";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(59, 41);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(33, 27);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "+";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNhanVien";
            this.Text = "Phần Mềm Ocha";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mntNKHD;
        private System.Windows.Forms.ToolStripMenuItem mntKhuVuc;
        private System.Windows.Forms.ToolStripMenuItem mntThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMenu;
    }
}