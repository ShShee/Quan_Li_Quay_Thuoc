using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuayThuoc.DTO
{
    public class Phieudathang
    {
        public Phieudathang(string phieudathang,string ngaylap,int id_nhanvien)
        {
            this.Id_phieudathang = id_phieudathang;
            this.Ngaylap= ngaylap;
            this.Id_nhanvien = id_nhanvien;
        }

        public Phieudathang(DataRow row)
        {
            this.Id_phieudathang = row["id_phieudathang"].ToString();
            this.Ngaylap = Convert.ToDateTime(row["ngaylap"]).ToString("dd/MM/yyyy");
            this.Id_nhanvien = (int)Convert.ToInt32(row["id_nhanvien"].ToString());
        }

        private string id_phieudathang;
        private string ngaylap;
        private int id_nhanvien;

        public string Id_phieudathang
        {
            get { return id_phieudathang; }
            set { id_phieudathang = value; }
        }
        public string Ngaylap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }
        public int Id_nhanvien
        {
            get { return id_nhanvien; }
            set { id_nhanvien = value; }
        }
    }
}
