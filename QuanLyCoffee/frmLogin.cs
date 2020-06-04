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
    public partial class frmLogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ECDLIHU;Initial Catalog=QL_NhanVien;Integrated Security=True");
        public static string ID_USER = "";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát hay không !!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }

        private string getID(string username, string pass)
        {
            string id = "";
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE Username ='" + username + "' and Password='" + pass + "'", con);
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
            ID_USER = getID(txtTaiKhoan.Text, txtMatKhau.Text);
            if (ID_USER == "Admin" )
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
                this.txtTaiKhoan.Clear();
                this.txtMatKhau.Clear();
                this.txtTaiKhoan.Focus();
            }
        }

        private void txtTaiKhoan_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Clear();
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.Clear();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }



    }

}
