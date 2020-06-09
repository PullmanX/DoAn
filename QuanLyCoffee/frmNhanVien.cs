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
            frmLogin frm = new frmLogin();
            frm.Show();
            Close();
        }

        private void mntMenu_Click(object sender, EventArgs e)
        {

        }

        private void mntNKHD_Click(object sender, EventArgs e)
        {
            frmMenu frmmn = new frmMenu();
            frmmn.Show();
            this.Close();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmmn = new frmMenu();
            frmmn.Show();
        }
    }
}
