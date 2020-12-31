using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuayThuoc.DTO
{
    public class Chitietdathang
    {
        public Chitietdathang(string tenhanghoa, int soluong, string tennhacungcap)
        {
            this.Tenhanghoa = tenhanghoa;
            this.Soluong = soluong;
            this.Tennhacungcap = tennhacungcap;
        }

        public Chitietdathang(DataRow row)
        {
            this.Tenhanghoa = row["tenhanghoa"].ToString();
            this.Soluong = Convert.ToInt32(row["soluong"].ToString());
            this.Tennhacungcap = row["ten"].ToString();
        }

        private string tenhanghoa;
        private int soluong;
        private string tennhacungcap;

        public string Tenhanghoa
        {
            get { return tenhanghoa; }
            set { tenhanghoa = value; }
        }
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public string Tennhacungcap
        {
            get { return tennhacungcap; }
            set { tennhacungcap = value; }
        }
    }
}