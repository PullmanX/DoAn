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
    public partial class frmXemLichLam : Form
    {
        SqlConnection con;//Khai báo đối tượng thực hiện kết nối đến cơ sở dữ liệu
        SqlCommand cmd;//Khai báo đối tượng thực hiện các câu lệnh truy vấn
        SqlDataAdapter dap;//Khai báo đối tượng gắn kết DataSource với DataSet
        DataSet ds;//Đối tượng chứa dữ liệu tại local
        public frmXemLichLam()
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
        private void XLichLam_Load(object sender, EventArgs e)
        {
 
                //Tạo đối tượng Connection
                con = new SqlConnection();
                //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
                //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 

                con.ConnectionString = (@"Data Source=DESKTOP-ECDLIHU;Initial Catalog=QuanLyQuanCafe;Integrated Security=True");
                LoadDuLieu("Select * from LICHLAM");
                //An groupbox chi tiet
        }
    }
}
