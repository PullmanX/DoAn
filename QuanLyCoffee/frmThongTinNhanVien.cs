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
    public partial class frmThongTinNhanVien : Form
    {
        //Khai báo các biến toàn cục
        SqlConnection con;//Khai báo đối tượng thực hiện kết nối đến cơ sở dữ liệu
        SqlCommand cmd;//Khai báo đối tượng thực hiện các câu lệnh truy vấn
        SqlDataAdapter dap;//Khai báo đối tượng gắn kết DataSource với DataSet
        DataSet ds;//Đối tượng chứa dữ liệu tại local

        public frmThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void LoadDuLieu(String sql)
        {
            //tạo đối tượng DataSet
            ds = new DataSet();
            //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
            dap = new SqlDataAdapter(sql, con);
            //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
            dap.Fill(ds);
            //Gắn dữ liệu từ DataSet lên DataGridView
            dgvKetQua.DataSource = ds.Tables[0];
        }

        //Phương thức ẩn hiện các control ở groupbox chi tiết
        private void HienChiTiet(Boolean hien)
        {
            txtMaNV.Enabled = hien;
            txtTenNV.Enabled = hien;
            dtpNgSinh.Enabled = hien;
            cboGioiTinh.Enabled = hien;
            txtDiaChi.Enabled = hien;
            txtSDT.Enabled = hien;
            cboTinhTrang.Enabled = hien;
            cboUser.Enabled = hien;
            cboLuong.Enabled = hien;
            //Ẩn hiện 2 nút Lưu và Hủy
            btnLuu.Enabled = hien;
            btnHuy.Enabled = hien;
        }

        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            //Tạo đối tượng Connection
            con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 

            con.ConnectionString = (@"Data Source=DESKTOP-JB1Q7II\SQLEXPRESS;Initial Catalog=QL_NhanVien;Integrated Security=True");
            LoadDuLieu("Select * from NHANVIEN");
            //Khi Form mới Load lên thì ẩn các bút Sửa và Xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //An groupbox chi tiet
            HienChiTiet(false);
        }


        private void dtgView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
                DataGridViewRow row = new DataGridViewRow();
                row = dgvKetQua.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtTenNV.Text = row.Cells["TenNV"].Value.ToString();
                dtpNgSinh.Value = Convert.ToDateTime(row.Cells["NgSinh"].Value.ToString());
                cboGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                cboTinhTrang.Text = row.Cells["TinhTrang"].Value.ToString();
                cboUser.Text = row.Cells["id_user"].Value.ToString();
                cboLuong.Text = row.Cells["Luong"].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "THÊM NHÂN VIÊN";
            //Cam nut sua xoa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //Hiện GroupBox Chi tiết
            HienChiTiet(true);
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            dtpNgSinh.ResetText();
            cboGioiTinh.ResetText();
            txtDiaChi.Clear();
            cboTinhTrang.ResetText();
            cboUser.ResetText();
            cboLuong.ResetText();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {                       

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = " ";
            //Kiếm tra nếu kết nối chưa mở thì thực hiện mở kết nối
            if (con.State != ConnectionState.Open)
                con.Open();
            //Chúng ta sử dụng control ErrorProvider để hiển thị lỗi
            //Kiểm tra tên sản phầm có bị để trống không
            if (txtTenNV.Text.Trim() == "")
            {
                errChiTiet.SetError(txtTenNV, "Bạn không để trống tên sản phẩm!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
                //Insert vao CSDL
            sql = "INSERT INTO NHANVIEN(MaNV,TenNV,NgSinh, GioiTinh, DiaChi, SDT, TinhTrang, ID_User, Luong )VALUES (";
            sql += "N'" + txtMaNV.Text + "',N'" + txtTenNV.Text + "','" + dtpNgSinh.Value + "','" + cboGioiTinh.Text + "',N'" + txtDiaChi.Text + "',N'" + txtSDT.Text + "','" + cboTinhTrang.Text + "','" + cboUser.Text + "','" + cboLuong.Text + "'  )";
            //Nếu nút Sửa enable thì thực hiện cập nhật dữ liệu
            if (btnSua.Enabled == true)
            {
                sql = "Update NHANVIEN SET ";
                sql += "TenSP = N'" + txtTenNV.Text + "',";
                sql += "NgaySinh = '" + dtpNgSinh.Value + "',";
                sql += "GioiTinh = '" + cboGioiTinh.Text + "',";
                sql += "DiaChi = N'" + txtDiaChi.Text + "' ";
                sql += "SDT = N'" + txtSDT.Text + "' ";
                sql += "Where MaSP = N'" + txtMaNV.Text + "'";
                sql += "TinhTrang = '" + cboTinhTrang.Text + "'";
                sql += "id_user = '" + cboUser.Text + "'";
                sql += "Luong = '" + cboLuong.Text + "'";

            }
            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btnXoa.Enabled == true)
            {
                sql = "Delete From NHANVIEN Where MaNV =N'" + txtMaNV.Text + "'";
            }
            //Thuc thi cau lenh sql
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            //Cap nhat lai DataGrid
            sql = "Select * from NHANVIEN";
            LoadDuLieu(sql);
            //dong ket noi
            con.Close();
            //Ẩn hiện các nút phù hợp chức năng
            HienChiTiet(false);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Thiết lập lại các nút như ban đầu
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
           //Cam nhap
            HienChiTiet(false);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
