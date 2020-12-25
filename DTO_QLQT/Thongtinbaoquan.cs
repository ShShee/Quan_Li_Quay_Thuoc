using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuayThuoc.DTO
{
    public class Thongtinbaoquan
    {
        public Thongtinbaoquan(int id_baoquan, string khuvuc, int vitri,int soluong,int nhietdo, string cachthuc)
        {
            this.Id_baoquan= id_baoquan;
            this.Khuvuc = khuvuc;
            this.Vitri = vitri;
            this.Soluong = soluong;
            this.Nhietdo = nhietdo;
            this.Cachthuc = cachthuc;
        }

        public Thongtinbaoquan(DataRow row)
        {
            this.Id_baoquan = (int)Convert.ToInt32(row["id_baoquan"].ToString());
            this.Khuvuc = row["khuvuc"].ToString();
            this.Vitri = (int)Convert.ToInt32(row["vitri"].ToString());
            this.Soluong = (int)Convert.ToInt32(row["soluong"].ToString());
            this.Nhietdo = (int)Convert.ToInt32(row["nhietdo"].ToString());
            this.Cachthuc = row["cachthuc"].ToString();
        }

        private int id_baoquan;
        private string khuvuc;
        private int vitri;
        private int soluong;
        private int nhietdo;
        private string cachthuc;

        public int Id_baoquan
        {
            get { return id_baoquan; }
            set { id_baoquan = value; }
        }
        public string Khuvuc
        {
            get { return khuvuc; }
            set { khuvuc = value; }
        }
        public int Vitri
        {
            get { return vitri; }
            set { vitri = value; }
        }
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public int Nhietdo
        {
            get { return nhietdo; }
            set { nhietdo = value; }
        }
        public string Cachthuc
        {
            get { return cachthuc; }
            set { cachthuc = value; }
        }
    }
}

