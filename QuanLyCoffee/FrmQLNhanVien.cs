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
    public partial class FrmQLNhanVien : Form
    {
        public FrmQLNhanVien()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (txtmaso.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã số nhân viên cần cập nhật!");
            }
            else if (txthoten.Text == "" || txtdiachi.Text == "" || cbbquyen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên cần cập nhập!");
            }
            else
            {
                kn.mo();
                string sql = "update nhan_vien set hoten_nv=N'" + txthoten.Text + "',dia_chi=N'" + txtdiachi.Text + "',sdt='" + txtsdt.Text + "',quyen='" + cbbquyen.Text + "',mat_khau='" + txtmatkhau.Text + "' where ma_nv='" + txtmaso.Text + "'";
                kn.xuly(sql);
                kn.hienraluoi("select * from nhan_vien", datagridnhanvien);
                kn.dong();
                txtdiachi.Clear();
                txthoten.Clear();
                txtmaso.Clear();
                txtmatkhau.Clear();
                txtsdt.Clear();
            }

        }

        private void nhanvien_Load(object sender, EventArgs e)
        {
            kn.mo();
            kn.hienraluoi("select * from nhan_vien", datagridnhanvien);
            kn.dong();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmaso.Text == "" || txthoten.Text == "" || txtdiachi.Text == "" || cbbquyen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin của nhân viên!");
            }
            else
            {
                kn.mo();
                string sql = "insert into nhan_vien values('" + txtmaso.Text + "',N'" + txthoten.Text + "',N'" + txtdiachi.Text + "','" + txtsdt.Text + "','" + txtmatkhau.Text + "','" + cbbquyen.Text + "')";
                kn.xuly(sql);
                kn.hienraluoi("select * from nhan_vien", datagridnhanvien);
                kn.dong();
                txtdiachi.Clear();
                txthoten.Clear();
                txtmaso.Clear();
                txtmatkhau.Clear();
                txtsdt.Clear();
            }
        }

        private void datagridnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaso.Text = datagridnhanvien.CurrentRow.Cells["ma_nv"].Value.ToString();
            txthoten.Text = datagridnhanvien.CurrentRow.Cells["hoten_nv"].Value.ToString();
            txtdiachi.Text = datagridnhanvien.CurrentRow.Cells["dia_chi"].Value.ToString();
            txtmatkhau.Text = datagridnhanvien.CurrentRow.Cells["mat_khau"].Value.ToString();
            txtsdt.Text = datagridnhanvien.CurrentRow.Cells["sdt"].Value.ToString();
            cbbquyen.Text = datagridnhanvien.CurrentRow.Cells["quyen"].Value.ToString();
        }
    }
}
