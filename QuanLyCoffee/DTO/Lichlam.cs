using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffee.DTO
{
    public class Lichlam
    {
        public Lichlam(string Thu2, string Thu3, string Thu4, string Thu5, string Thu6, string Thu7, string CN)
        {
            this.Thu2 = Thu2;
            this.Thu3 = Thu3;
            this.Thu4 = Thu4;
            this.Thu5 = Thu5;
            this.Thu6 = Thu6;
            this.Thu7 = Thu7;
            this.CN = CN;

        }

        public Lichlam(DataRow row)
        {
            this.Thu2 = row["Thu2"].ToString();
            this.Thu3 = row["Thu3"].ToString();
            this.Thu4 = row["Thu4"].ToString();
            this.Thu5 = row["Thu5"].ToString();
            this.Thu6 = row["Thu6"].ToString();
            this.Thu7 = row["Thu7"].ToString();
            this.CN = row["CN"].ToString();;
        }
        public string Thu2
        {
            get { return Thu2; }
            set { Thu2 = value; }
        }
        public string Thu3
        {
            get { return Thu3; }
            set { Thu3 = value; }
        }
        public string Thu4
        {
            get { return Thu4; }
            set { Thu4 = value; }
        }
        public string Thu5
        {
            get { return Thu5; }
            set { Thu5 = value; }
        }
        public string Thu6
        {
            get { return Thu6; }
            set { Thu6 = value; }
        }
        public string Thu7
        {
            get { return Thu7; }
            set { Thu7 = value; }
        }
        public string CN
        {
            get { return CN; }
            set { Thu2 = value; }
        }

    }
}
