using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QuanLyCoffee
{
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void sbtnThongTinNhanVien_Click(object sender, EventArgs e)
        {
            frmThongTinNV nv = new frmThongTinNV() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pLoad.Controls.Add(nv);
            nv.Show();
        }

        private void sbtnExit_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn đăng xuất hay không !!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
            {
                frmLogin frm = new frmLogin();
                frm.Show();
                Close();
            }
                
        }



        private void frmQuanLy_Load(object sender, EventArgs e)
        {
           
        }


        

        private void ptbSleep_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát hay không !!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Close();
        }

        

        private void pLoad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sbtnNKHD_Click(object sender, EventArgs e)
        {
            frmAdmin nv = new frmAdmin() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pLoad.Controls.Add(nv);
            nv.Show();
        }

        private void sbtnLichLam_Click(object sender, EventArgs e)
        {
            frmLichLam ll = new frmLichLam() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pLoad.Controls.Add(ll);
            ll.Show();
        }


        private void pLoad_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void sbtnTKNV_Click(object sender, EventArgs e)
        {
            frmAccount ac = new frmAccount() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pLoad.Controls.Add(ac);
            ac.Show();
        }

        private void snbtPhieuNhap_Click(object sender, EventArgs e)
        {
            frmPhieuNhap pn = new frmPhieuNhap() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pLoad.Controls.Add(pn);
            pn.Show();
        }
    }
}
