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

namespace QuanLyCoffee
{
    public partial class fLogin : Form
    {
        public static string ID_USER = "";
        public fLogin()
        {
            InitializeComponent();
        }

        private string getID(string username, string pass)
        {
            string id = "";
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JB1Q7II\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True");
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

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
