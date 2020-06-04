using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoffee
{
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void mntThoat_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            Close();
        }

        private void mntLogin_Click(object sender, EventArgs e)
        {

        }

        private void mntMenu_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mntDangNhap_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void mntQuanLyNV_Click(object sender, EventArgs e)
        {
            frmThongTinNhanVien frm1 = new frmThongTinNhanVien();
            frm1.Show();
        }

 


    }
}
