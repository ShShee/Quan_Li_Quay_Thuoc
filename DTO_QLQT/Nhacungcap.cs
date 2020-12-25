using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuayThuoc.DTO
{
    public class Nhacungcap
    {
        public Nhacungcap(int id_nhacungcap, string ten,string diachi,string sodienthoai, string giayphep)
        {
            this.Id_nhacungcap= id_nhacungcap;
            this.Ten = ten;
            this.Diachi = diachi;
            this.Sodienthoai = sodienthoai;
            this.Giayphep = giayphep;
        }

        public Nhacungcap(DataRow row)
        {
            this.Id_nhacungcap = (int)Convert.ToInt32(row["id_nhacungcap"].ToString()); ;
            this.Ten = row["ten"].ToString();
            this.Diachi = row["diachi"].ToString();
            this.Sodienthoai = row["sodienthoai"].ToString();
            this.Giayphep = row["giayphep"].ToString();
        }

        private int id_nhacungcap;
        private string ten;
        private string diachi;
        private string sodienthoai;
        private string giayphep;

        public int Id_nhacungcap
        {
            get { return id_nhacungcap; }
            set { id_nhacungcap = value; }
        }
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string Sodienthoai
        {
            get { return sodienthoai; }
            set { sodienthoai = value; }
        }
        public string Giayphep
        {
            get { return giayphep; }
            set { giayphep = value; }
        }
    }
}
