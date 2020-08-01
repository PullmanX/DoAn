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
    public partial class frmKhuVuc : Form
    {
        SqlConnection con;//Khai báo đối tượng thực hiện kết nối đến cơ sở dữ liệu
        SqlCommand cmd;//Khai báo đối tượng thực hiện các câu lệnh truy vấn
        SqlDataAdapter dap;//Khai báo đối tượng gắn kết DataSource với DataSet
        DataSet ds;//Đối tượng chứa dữ liệu tại local

        public frmKhuVuc()
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

        private void frmKhuVuc_Load(object sender, EventArgs e)
        {
            //Tạo đối tượng Connection
            con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 

            con.ConnectionString = (@"Data Source=DESKTOP-ECDLIHU;Initial Catalog=QuanLyQuanCafe;Integrated Security=True");
            LoadDuLieu("Select * from TableFood");
            //Khi Form mới Load lên thì ẩn các bút Sửa và Xóa
            btnXoa.Enabled = false;
            //An groupbox chi tiet
            HienChiTiet(false);
        }

        

        //Phương thức ẩn hiện các control ở groupbox chi tiết
        private void HienChiTiet(Boolean hien)
        {
            txtTenBan.Enabled = hien;
            cboKhuVuc.Enabled = hien;
            //Ẩn hiện 2 nút Lưu và Hủy
            btnLuu.Enabled = hien;
            btnHuy.Enabled = hien;
        }



        private void dtgView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnHuy.Enabled = true;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvKetQua.Rows[e.RowIndex];
            txtID.Text = row.Cells["id"].Value.ToString();
            txtTenBan.Text = row.Cells["name"].Value.ToString();
            cboKhuVuc.Text = row.Cells["status"].Value.ToString();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lblTieude.Text = "Thêm Bàn";
            //Cam nut sua xoa
            btnXoa.Enabled = false;
            //Hiện GroupBox Chi tiết
            HienChiTiet(true);
            txtTenBan.Clear();
            cboKhuVuc.ResetText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lblTieude.Text = "Xóa Bàn";
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
            if (txtTenBan.Text.Trim() == "")
            {
                errChiTiet.SetError(txtTenBan, "Bạn không để trống mật khẩu!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            //Insert vao CSDL
            sql = "INSERT INTO TableFood(name,status)VALUES (";
            sql += "N'" + txtTenBan.Text + "',N'" + cboKhuVuc.Text + "')";
            //Nếu nút Sửa enable thì thực hiện cập nhật dữ liệu
            
            if (btnXoa.Enabled == true)
            {
                MessageBox.Show("Đang xóa", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                sql = "Delete From TableFood Where id =N'" + txtID.Text + "'";
            }
            //Thuc thi cau lenh sql
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            //Cap nhat lai DataGrid
            sql = "Select * from TableFood";
            LoadDuLieu(sql);
            //dong ket noi
            con.Close();
            //Ẩn hiện các nút phù hợp chức năng
            HienChiTiet(false);
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Thiết lập lại các nút như ban đầu
            btnXoa.Enabled = false;
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
