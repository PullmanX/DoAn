using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyCoffee
{
    class ketnoi
    {
        String chuoiketnoi = "Data Source=DESKTOP-JB1Q7II\\SQLEXPRESS;Initial Catalog=Linhkien;Integrated Security=True";
        public SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        public void mo()
        {
            try
            {
                conn = new SqlConnection(chuoiketnoi);
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến cơ sơ dữ liệu!");
            }
        }

        public void dong()
        {
            conn.Close();
        }

        public DataTable laydulieu(string sql)
        {
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public void hienraluoi(string sql, DataGridView luoi)
        {
            DataTable dt = new DataTable();
            dt = laydulieu(sql);
            luoi.DataSource = dt;
        }
        public void xuly(string sql)
        {
            try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra dữ liệu nhập vào hoặc dữ liệu đã tồn tại");
            }
        }

        public int xoadulieu(string sql)
        {
            int i;
            cmd = new SqlCommand(sql, conn);
            i = (int)cmd.ExecuteNonQuery();
            return i;
        }

        public int executescalar(string sql)
        {
            int i;
            cmd = new SqlCommand(sql, conn);
            i = (int)cmd.ExecuteScalar();
            return i;
        }



        public void combobox(string sql, ComboBox cbb)
        {
            DataTable bang = new DataTable();
            bang = laydulieu(sql);
            cbb.DataSource = bang;
            cbb.DisplayMember = bang.Columns[0].ToString();
        }

    }
}
