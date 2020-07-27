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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void mntThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn đăng xuất hay không !!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
            {
                frmLogin frm = new frmLogin();
                frm.Show();
                this.Close();
            }
        }

        private void mntMenu_Click(object sender, EventArgs e)
        {

        }

        private void mntNKHD_Click(object sender, EventArgs e)
        {
            frmTableManager frmmn = new frmTableManager();
            frmmn.Show();
        
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmTableManager frmmn = new frmTableManager();
            frmmn.Show();
        }

        private void mntXemLL_Click(object sender, EventArgs e)
        {
            frmXemLichLam xll = new frmXemLichLam();
            xll.Show();
        }
    }
}
