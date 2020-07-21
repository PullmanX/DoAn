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
    public partial class frmPhieuNhapCT : Form
    {

        public frmPhieuNhapCT()
        {
            InitializeComponent();
        }

        ketnoi kn = new ketnoi();
        private void btncapnhat_Click(object sender, EventArgs e)
        {
            

        }

        private void nhanvien_Load(object sender, EventArgs e)
        {
            kn.mo();
            kn.hienraluoi("select * from nhan_vien", datagridnhanvien);
            kn.dong();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "" || cboTenHang.Text == "" || txtSoLuong.Text == "" || txtGiaNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin của nhân viên!");
            }
            else
            {
                kn.mo();
                string sql = "insert into nhan_vien values('" + txtMaHang.Text + "',N'" + cboTenHang.Text + "',N'" + txtSoLuong.Text + "','" + txtGiaNhap.Text + "')";
                kn.xuly(sql);
                kn.hienraluoi("select * from nhan_vien", dgvPhieuNhapCtiet);
                kn.dong();
                txtSoPhieuNhap.Clear();
                cboMaNV.ResetText();
                txtGhiChu.Clear();
                txtMaHang.Clear();
                cboTenHang.ResetText();
                txtSoLuong.Clear();
                txtGiaNhap.Clear();
            }
        }

        private void dgvPhieuNhapCtiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHang.Text = dgvPhieuNhapCtiet.CurrentRow.Cells["Username"].Value.ToString();
            cboTenHang.Text = dgvPhieuNhapCtiet.CurrentRow.Cells["hoten_nv"].Value.ToString();
            txtSoLuong.Text = dgvPhieuNhapCtiet.CurrentRow.Cells["dia_chi"].Value.ToString();
            txtGiaNhap.Text = dgvPhieuNhapCtiet.CurrentRow.Cells["Password"].Value.ToString();
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            if (txtSoPhieuNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã số phiếu nhậpt!");
            }
            else if (txtMaHang.Text == "" || cboTenHang.Text == "" || txtSoLuong.Text == "" || txtGiaNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên cần cập nhập!");
            }
            else
            {
                kn.mo();
                string sql = "update nhan_vien set hoten_nv=N'" + txtMaHang.Text + "',N'" + cboTenHang.Text + "',N'" + txtSoLuong.Text + "','" + txtGiaNhap.Text + "'";
                kn.xuly(sql);
                kn.hienraluoi("select * from nhan_vien", dgvPhieuNhapCtiet);
                kn.dong();
                txtSoPhieuNhap.Clear();
                cboMaNV.ResetText();
                txtGhiChu.Clear();
                txtMaHang.Clear();
                cboTenHang.ResetText();
                txtSoLuong.Clear();
                txtGiaNhap.Clear();
            }
        }
    }
}
