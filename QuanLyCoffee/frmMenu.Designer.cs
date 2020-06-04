namespace QuanLyCoffee
{
    partial class frmMenu
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
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.grbCF = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.frmExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ltvMenu = new System.Windows.Forms.ListView();
            this.grbCF.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThanhToan.Location = new System.Drawing.Point(866, 625);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(189, 49);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // grbCF
            // 
            this.grbCF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbCF.BackColor = System.Drawing.Color.Transparent;
            this.grbCF.Controls.Add(this.label3);
            this.grbCF.Controls.Add(this.label2);
            this.grbCF.Controls.Add(this.label1);
            this.grbCF.Controls.Add(this.button4);
            this.grbCF.Controls.Add(this.button2);
            this.grbCF.Controls.Add(this.button1);
            this.grbCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCF.ForeColor = System.Drawing.Color.Black;
            this.grbCF.Location = new System.Drawing.Point(101, 83);
            this.grbCF.Name = "grbCF";
            this.grbCF.Size = new System.Drawing.Size(477, 142);
            this.grbCF.TabIndex = 2;
            this.grbCF.TabStop = false;
            this.grbCF.Text = "Coffee";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(323, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bạc Xỉu: 22.000";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(180, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cà Fê sữa: 20.000";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(47, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cà Fê: 18.000";
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackgroundImage = global::QuanLyCoffee.Properties.Resources.BacXiu;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(343, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 53);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackgroundImage = global::QuanLyCoffee.Properties.Resources.cafesua;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(203, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 53);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackgroundImage = global::QuanLyCoffee.Properties.Resources.cafeda;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(62, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 53);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmExit
            // 
            this.frmExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.frmExit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.frmExit.Location = new System.Drawing.Point(1062, 625);
            this.frmExit.Name = "frmExit";
            this.frmExit.Size = new System.Drawing.Size(189, 49);
            this.frmExit.TabIndex = 2;
            this.frmExit.Text = "Thoát";
            this.frmExit.UseVisualStyleBackColor = false;
            this.frmExit.Click += new System.EventHandler(this.frmExit_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(584, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 76);
            this.label4.TabIndex = 2;
            this.label4.Text = "Menu ";
            // 
            // ltvMenu
            // 
            this.ltvMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ltvMenu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ltvMenu.Location = new System.Drawing.Point(866, 112);
            this.ltvMenu.Name = "ltvMenu";
            this.ltvMenu.Size = new System.Drawing.Size(385, 507);
            this.ltvMenu.TabIndex = 3;
            this.ltvMenu.UseCompatibleStateImageBehavior = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1363, 700);
            this.Controls.Add(this.ltvMenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grbCF);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.frmExit);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMenu";
            this.Text = "Bảng Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.grbCF.ResumeLayout(false);
            this.grbCF.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.GroupBox grbCF;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button frmExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView ltvMenu;

    }
}