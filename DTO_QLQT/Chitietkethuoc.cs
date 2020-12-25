using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuayThuoc.DTO
{
    public class Chitietkethuoc
    {
        public Chitietkethuoc(string id_thuoc, string tenthuoc, int lieuluong,int giathanh,int id_chitietkethuoc)
        {
            this.Id_thuoc= id_thuoc;
            this.Tenthuoc = tenthuoc;
            this.Lieuluong = lieuluong;
            this.Giathanh = giathanh;
            this.Id_chitietkethuoc = id_chitietkethuoc;
        }

        public Chitietkethuoc(DataRow row)
        {
            this.Id_thuoc = row["id_thuoc"].ToString();
            this.Tenthuoc = row["tenthuoc"].ToString();
            this.Lieuluong = (int)Convert.ToInt32(row["lieuluong"].ToString());
            this.Giathanh = (int)Convert.ToInt32(row["giathanh"].ToString());
            this.Id_chitietkethuoc = (int)Convert.ToInt32(row["id_chitietkethuoc"].ToString());
        }

        private string id_thuoc;
        private string tenthuoc;
        private int lieuluong;
        private int giathanh;
        private int id_chitietkethuoc;

        public string Id_thuoc
        {
            get { return id_thuoc; }
            set { id_thuoc = value; }
        }
        public string Tenthuoc
        {
            get { return tenthuoc; }
            set { tenthuoc= value; }
        }
        public int Lieuluong
        {
            get { return lieuluong; }
            set { lieuluong = value; }
        }
        public int Giathanh
        {
            get { return giathanh; }
            set { giathanh = value; }
        }
        public int Id_chitietkethuoc
        {
            get { return id_chitietkethuoc; }
            set { id_chitietkethuoc = value; }
        }
    }
}
