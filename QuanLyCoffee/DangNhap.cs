using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCoffee
{
    public partial class DangNhap : Form
    {
        public static string ID_USER = "QUYEN";
        public DangNhap()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        DataTable nhanvien;
        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {

            if (txtmaso.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã số đăng nhập!");
                txtmaso.Focus();
            }
            else if (txtmatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu đăng nhập!");
                txtmatkhau.Focus();
            }
            else
            {
                kn.mo();
                nhanvien = new DataTable();
                string sql = "Select * from nhan_vien where ma_nv ='" + txtmaso.Text + "'";
                nhanvien = kn.laydulieu(sql);

                if (nhanvien.Rows.Count != 0)
                {
                    string matkhau = nhanvien.Rows[0]["mat_khau"].ToString();
                    if (matkhau.CompareTo(txtmatkhau.Text) == 1)
                    {
                        MessageBox.Show("Chúc mừng bạn đã đăng nhập thành công");
                        this.Hide();
                        frmThemTaiKhoan f = new frmThemTaiKhoan();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại tên và mật khẩu đăng nhập!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại tên và mật khẩu đăng nhập!");
                }
                kn.dong();
            }

        }
        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
