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
    public partial class frmAccount : Form
    {
        //Khai báo các biến toàn cục
        SqlConnection con;//Khai báo đối tượng thực hiện kết nối đến cơ sở dữ liệu
        SqlCommand cmd;//Khai báo đối tượng thực hiện các câu lệnh truy vấn
        SqlDataAdapter dap;//Khai báo đối tượng gắn kết DataSource với DataSet
        DataSet ds;//Đối tượng chứa dữ liệu tại local

        public frmAccount()
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
            txtTaikhoan.Enabled = hien;
            txtMatkhau.Enabled = hien;
            cboLoai.Enabled = hien;
            cboQuyen.Enabled = hien;
            txtTen.Enabled = hien;
        
            //Ẩn hiện 2 nút Lưu và Hủy
            btnLuu.Enabled = hien;
            btnHuy.Enabled = hien;
        }



        private void dtgView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnHuy.Enabled = true;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvKetQua.Rows[e.RowIndex];
            txtTaikhoan.Text = row.Cells["UserName"].Value.ToString();
            txtMatkhau.Text = row.Cells["PassWord"].Value.ToString();
            cboLoai.Text = row.Cells["Type"].Value.ToString();
            cboQuyen.Text = row.Cells["id_user"].Value.ToString();
            txtTen.Text = row.Cells["DisplayName"].Value.ToString();
           

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "THÊM TÀI KHOẢN NHÂN VIÊN";
            //Cam nut sua xoa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //Hiện GroupBox Chi tiết
            HienChiTiet(true);
            txtTaikhoan.Clear();
            txtMatkhau.Clear();
            txtTen.Clear();
            cboQuyen.ResetText();
            cboLoai.ResetText();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "SỮA THÔNG TIN ACCOUNT";
            txtTaikhoan.Enabled = true;
            txtMatkhau.Enabled = true;
            cboLoai.Enabled = true;
            cboQuyen.Enabled = true;
            txtTen.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "XÓA THÔNG TIN NHÂN VIÊN";
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = " ";
            //Kiếm tra nếu kết nối chưa mở thì thực hiện mở kết nối
            if (con.State != ConnectionState.Open)
                con.Open();
            //Chúng ta sử dụng control ErrorProvider để hiển thị lỗi
            //Kiểm tra tên sản phầm có bị để trống không
            if (txtMatkhau.Text.Trim() == "")
            {
                errChiTiet.SetError(txtMatkhau, "Bạn không để trống mật khẩu!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            //Insert vao CSDL
            sql = "INSERT INTO Account(UserName,DisplayName,PassWord, Type, id_user)VALUES (";
            sql += "N'" + txtTaikhoan.Text + "',N'" + txtTen.Text + "','" + txtMatkhau.Text + "','" + cboLoai.Text + "',N'" + cboQuyen.Text + "')";
            //Nếu nút Sửa enable thì thực hiện cập nhật dữ liệu
            if (btnSua.Enabled == true)
            {
                MessageBox.Show("Đang sửa", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                sql = "Update Account SET ";
                sql += "DisplayName = '" + txtTen.Text + "',";
                sql += "PassWord = '" + txtMatkhau.Text + "',";
                sql += "Type = N'" + cboLoai.Text + "', ";
                sql += "id_user = N'" + cboQuyen.Text + "' ";
                sql += "Where UserName = N'" + txtTaikhoan.Text + "'";

            }
            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btnXoa.Enabled == true)
            {
                MessageBox.Show("Đang xóa", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                sql = "Delete From Account Where UserName =N'" + txtTaikhoan.Text + "'";

            }
            //Thuc thi cau lenh sql
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            //Cap nhat lai DataGrid
            sql = "Select * from Account";
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

        private void frmAccount_Load(object sender, EventArgs e)
        {
            //Tạo đối tượng Connection
            con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 

            con.ConnectionString = (@"Data Source=DESKTOP-JB1Q7II\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True");
            LoadDuLieu("Select * from Account");
            //Khi Form mới Load lên thì ẩn các bút Sửa và Xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //An groupbox chi tiet
            HienChiTiet(false);
        }
    }
}
