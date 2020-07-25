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
            fLogin frm = new fLogin();
            frm.Show();
            this.Close();
        }

        private void mntMenu_Click(object sender, EventArgs e)
        {

        }

        private void mntNKHD_Click(object sender, EventArgs e)
        {
            fTableManager frmmn = new fTableManager();
            frmmn.Show();
        
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            fTableManager frmmn = new fTableManager();
            frmmn.Show();
        }

        private void mntXemLL_Click(object sender, EventArgs e)
        {
            XLichLam xll = new XLichLam();
            xll.Show();
        }
    }
}
