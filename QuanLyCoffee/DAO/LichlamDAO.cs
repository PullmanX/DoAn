using QuanLyCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffee.DAO
{
    public class LichlamDAO
    {
        private static LichlamDAO instance;

        public static LichlamDAO Instance
        {
            get { if (instance == null) instance = new LichlamDAO(); return LichlamDAO.instance; }
            private set { LichlamDAO.instance = value; }
        }

        private LichlamDAO() { }

        public List<Lichlam> GetListLichlam()
        {
            List<Lichlam> list = new List<Lichlam>();

            string query = "select * from Lichlam";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Lichlam lichlam = new Lichlam(item);
                list.Add(lichlam);
            }

            return list;
        }

        public bool InsertLichlam(string Thu2, string Thu3, string Thu4, string Thu5, string Thu6, string Thu7, string CN)
        {
            string query = string.Format("INSERT dbo.Lichlam ( Thu2, Thu3, Thu4,  Thu5, Thu6, Thu7, CN )VALUES  ( N'{0}', {1}, {2},{3},{4},{5},{6})", Thu2, Thu3, Thu4, Thu5, Thu6, Thu7, CN);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateLichlam(string Thu2, string Thu3, string Thu4, string Thu5, string Thu6, string Thu7, string CN)
        {
            string query = string.Format("UPDATE dbo.Lichlam SET Thu2 = N'{0}', Thu3 = {1}, Thu4 = {2}, Thu5 = {3}, Thu6 = {4}, Thu7 = {5}, CN = {6}", Thu2, Thu3, Thu4, Thu5, Thu6, Thu7, CN);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        /*public bool DeleteLichlam(string Thu2)
        {
            LichlamInfoDAO.Instance.DeleteBillInfoByThu2(Thu2);

            string query = string.Format("Delete Food where Thu2 = {0}", Thu2);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }*/
    }
}
