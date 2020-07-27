using QuanLyCoffee.DAO;
using QuanLyCoffee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace QuanLyCoffee
{
    public partial class frmLogin : Form
    {
        public static string ID_USER = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private string getID(string username, string pass)
        {
            string id = "";
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ECDLIHU;Initial Catalog=QuanLyQuanCafe;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("SELECT * FROM Account WHERE UserName ='" + username + "' and PassWord='" + pass + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["id_user"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }

            return id;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ID_USER = getID(txbUserName.Text, txbPassWord.Text);
            if (ID_USER == "Admin")
            {
                frmQuanLy fmain = new frmQuanLy();
                fmain.Show();
                this.Hide();
            }

            else if (ID_USER == "Member")
            {
                frmNhanVien frm1 = new frmNhanVien();
                frm1.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không đúng !", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                this.txbUserName.Clear();
                this.txbPassWord.Clear();
                this.txbUserName.Focus();
            }

        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ptbExit_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát hay không !!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }

        private void ptbSleep_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txbPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txbPassWord_TextChanged(object sender, EventArgs e)
        {
            txbPassWord.PasswordChar = '*';
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txbUserName_Click(object sender, EventArgs e)
        {
            txbUserName.Clear();
        }

        private void txbPassWord_Click(object sender, EventArgs e)
        {
            txbPassWord.Clear();
        }
    }
}
