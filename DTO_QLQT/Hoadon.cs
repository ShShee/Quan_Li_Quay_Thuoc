using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuayThuoc.DTO
{
    public class Hoadon
    {
        public Hoadon(string id_hoadon, string ngaylap, string nguoimua, string diachi, string sodienthoai,string bacsikedon,string chuandoanbenh,
            string sobaohiemyte,string loaihinh,int id_nhanvien, string tongtien)
        {
            this.Id_hoadon=id_hoadon;
            this.Ngaylap = ngaylap;
            this.Nguoimua = nguoimua;
            this.Diachi = diachi;
            this.Sodienthoai = sodienthoai;
            this.Bacsikedon = bacsikedon;
            this.Chuandoanbenh = chuandoanbenh;
            this.Sobaohiemyte = sobaohiemyte;
            this.Loaihinh = loaihinh;
            this.Id_nhanvien = id_nhanvien;
            this.Tongtien = tongtien;
        }

        public Hoadon(DataRow row)
        {
            this.Id_hoadon = row["id_hoadon"].ToString();
            this.Ngaylap = Convert.ToDateTime(row["ngaylap"]).ToString("dd/MM/yyyy");
            this.Nguoimua = row["ten"].ToString();
            this.Diachi = row["diachi"].ToString();
            this.Sodienthoai = row["sodienthoai"].ToString();
            this.Bacsikedon = row["bacsikedon"].ToString();
            this.Chuandoanbenh = row["chuandoanbenh"].ToString();
            this.Sobaohiemyte = row["sobaohiemyte"].ToString();
            this.Loaihinh = row["loaihinh"].ToString();
            this.Id_nhanvien = Convert.ToInt32(row["id_nhanvien"].ToString());
            this.Tongtien = row["tongtien"].ToString();
        }

        private string id_hoadon;
        private string ngaylap;
        private string nguoimua;
        private string diachi;
        private string sodienthoai;
        private string bacsikedon;
        private string chuandoanbenh;
        private string sobaohiemyte;
        private string loaihinh;
        private int id_nhanvien;
        private string tongtien;

        public string Id_hoadon
        {
            get { return id_hoadon; }
            set { id_hoadon = value; }
        }
        public string Ngaylap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }
        public string Nguoimua
        {
            get { return nguoimua; }
            set { nguoimua = value; }
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
        public string Bacsikedon
        {
            get { return bacsikedon; }
            set { bacsikedon = value; }
        }
        public string Chuandoanbenh
        {
            get { return chuandoanbenh; }
            set { chuandoanbenh = value; }
        }
        public string Sobaohiemyte
        {
            get { return sobaohiemyte; }
            set { sobaohiemyte = value; }
        }
        public string Loaihinh
        {
            get { return loaihinh; }
            set { loaihinh = value; }
        }
        public int Id_nhanvien
        {
            get { return id_nhanvien; }
            set { id_nhanvien = value; }
        }
        public string Tongtien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
    }
}
