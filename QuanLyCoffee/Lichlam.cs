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
    public partial class Lichlam : Form
    {
        //Khai báo các biến toàn cục
        SqlConnection con;//Khai báo đối tượng thực hiện kết nối đến cơ sở dữ liệu
        SqlCommand cmd;//Khai báo đối tượng thực hiện các câu lệnh truy vấn
        SqlDataAdapter dap;//Khai báo đối tượng gắn kết DataSource với DataSet
        DataSet ds;//Đối tượng chứa dữ liệu tại local

        public Lichlam()
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
            txtCalam.Enabled = hien;
            txtThu2.Enabled = hien;
            txtThu3.Enabled = hien;
            txtThu4.Enabled = hien;
            txtThu5.Enabled = hien;
            txtThu6.Enabled = hien;
            txtThu7.Enabled = hien;
            txtCN.Enabled = hien;
            //Ẩn hiện 2 nút Lưu và Hủy
            btnLuu.Enabled = hien;
            btnHuy.Enabled = hien;
        }

        /*private void Phieunhap_Load(object sender, EventArgs e)
        {
            //Tạo đối tượng Connection
            con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 

            con.ConnectionString = (@"Data Source=DESKTOP-JB1Q7II\SQLEXPRESS;Initial Catalog=QL_NHANVIEN;Integrated Security=True");
            LoadDuLieu("Select * from PHIEUNHAP");
            //Khi Form mới Load lên thì ẩn các bút Sửa và Xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //An groupbox chi tiet
            HienChiTiet(false);
        }*/


        private void dtgView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnHuy.Enabled = true;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvKetQua.Rows[e.RowIndex];
            txtCalam.Text = row.Cells["Calam"].Value.ToString();
            txtThu2.Text = row.Cells["Thu2"].Value.ToString();
            txtThu3.Text = row.Cells["Thu3"].Value.ToString();
            txtThu4.Text = row.Cells["Thu4"].Value.ToString();
            txtThu5.Text = row.Cells["Thu5"].Value.ToString();
            txtThu6.Text = row.Cells["Thu6"].Value.ToString();
            txtThu7.Text = row.Cells["Thu7"].Value.ToString();
            txtCN.Text = row.Cells["CN"].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "LỊCH LÀM HẰNG TUẦN";
            //Cam nut sua xoa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //Hiện GroupBox Chi tiết
            HienChiTiet(true);
            txtThu2.Clear();
            txtThu3.Clear();
            txtThu4.Clear();
            txtThu5.Clear();
            txtThu6.Clear();
            txtThu7.Clear();
            txtCN.Clear();
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
            /*  if (txtTenHang.Text.Trim() == "")
              {
                  errChiTiet.SetError(txtTenHang, "Bạn không để trống tên sản phẩm!");
                  return;
              }
              else
              {
                  errChiTiet.Clear();
              }*/
            //Insert vao CSDL
            sql = "INSERT INTO LICHLAM(Calam, Thu2,Thu3,Thu4,Thu5,Thu6,Thu7,CN)VALUES (";
            sql += "N'" + txtCalam.Text + "',N'" + txtThu2.Text + "',N'" + txtThu3.Text + "',N'" + txtThu4.Text + "',N'" + txtThu5.Text + "',N'" + txtThu6.Text + "',N'" + txtThu7.Text + "',N'" + txtCN.Text + "')";
            //Nếu nút Sửa enable thì thực hiện cập nhật dữ liệu
            if (btnSua.Enabled == true)
            {
                sql = "Update LICHLAM SET ";
                sql += "Thu2 = N'" + txtThu2.Text + "',";
                sql += "Thu3 = N'" + txtThu3.Text + "' ";
                sql += "Thu4 = N'" + txtThu4.Text + "',";
                sql += "Thu5 = N'" + txtThu5.Text + "' ";
                sql += "Thu6 = N'" + txtThu6.Text + "',";
                sql += "Thu7 = N'" + txtThu7.Text + "' ";
                sql += "CN = N'" + txtCN.Text + "' ";
                sql += "Where Calam = N'" + txtCalam.Text + "'";

            }
            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btnXoa.Enabled == true)
            {
                sql = "Delete From LICHLAM Where Calam =N'" + txtCalam.Text + "'";
            }
            //Thuc thi cau lenh sql
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            //Cap nhat lai DataGrid
            sql = "Select * from LICHLAM";
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


        private void Lichlam_Load(object sender, EventArgs e)
        {
            //Tạo đối tượng Connection
            con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 

            con.ConnectionString = (@"Data Source=DESKTOP-JB1Q7II\SQLEXPRESS;Initial Catalog=QL_NHANVIEN;Integrated Security=True");
            LoadDuLieu("Select * from LICHLAM");
            //Khi Form mới Load lên thì ẩn các bút Sửa và Xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //An groupbox chi tiet
            HienChiTiet(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void c(object sender, EventArgs e)
        {

        }
    }
}
