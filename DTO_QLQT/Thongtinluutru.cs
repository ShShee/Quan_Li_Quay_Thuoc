using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuayThuoc.DTO
{
    public class Thongtinluutru
    {
        public Thongtinluutru(int id_loaithuoc,int soluong,string donvi,int donluong, string sogiayphep,string solo,string nhasanxuat,string tenthuoc,
            string hansudung,int giathanh, string huongdansudung,string loai,int id_baoquan,int id_nhacungcap,string id_phieunhanhang)
        {
            this.Id_loaithuoc = id_loaithuoc;
            this.Soluong = soluong;
            this.Donvi = donvi;
            this.Donluong = donluong;
            this.Sogiayphep = sogiayphep;
            this.Solo = solo;
            this.Nhasanxuat = nhasanxuat;
            this.Tenthuoc = tenthuoc;
            this.Hansudung = hansudung;
            this.Giathanh = giathanh;
            this.Huongdansudung = huongdansudung;
            this.Loai = loai;
            this.Id_baoquan = id_baoquan;
            this.Id_nhacungcap = id_nhacungcap;
            this.Id_phieunhanhang = id_phieunhanhang;
        }

        public Thongtinluutru(DataRow row)
        {
            this.Id_loaithuoc = (int)Convert.ToInt32(row["id_loaithuoc"].ToString());
            this.Soluong = (int)Convert.ToInt32(row["soluong"].ToString());
            this.Donvi = row["donvi"].ToString();
            this.Donluong = (int)Convert.ToInt32(row["donluong"].ToString());
            this.Sogiayphep = row["sogiayphep"].ToString();
            this.Solo = row["solo"].ToString();
            this.Nhasanxuat = row["nhasanxuat"].ToString();
            this.Tenthuoc = row["tenthuoc"].ToString();
            this.Hansudung = Convert.ToDateTime(row["hansudung"]).ToString("dd/MM/yyyy");
            this.Giathanh = (int)Convert.ToInt32(row["giathanh"].ToString());
            this.Huongdansudung = row["huongdansudung"].ToString();
            this.Loai = row["loai"].ToString();
            this.Id_baoquan = (int)Convert.ToInt32(row["id_baoquan"].ToString());
            this.Id_nhacungcap = (int)Convert.ToInt32(row["id_nhacungcap"].ToString());
            this.Id_phieunhanhang = row["id_phieunhanhang"].ToString();
        }

        private int id_loaithuoc;
        private int soluong;
        private string donvi;
        private int donluong;
        private string sogiayphep;
        private string solo;
        private string nhasanxuat;
        private string tenthuoc;
        private string hansudung;
        private int giathanh;
        private string huongdansudung;
        private string loai;
        private int id_baoquan;
        private int id_nhacungcap;
        private string id_phieunhanhang;

        public int Id_loaithuoc
        {
            get { return id_loaithuoc; }
            set { id_loaithuoc = value; }
        }
        public string Donvi
        {
            get { return donvi; }
            set { donvi = value; }
        }
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public int Donluong
        {
            get { return donluong; }
            set { donluong = value; }
        }
        public string Sogiayphep
        {
            get { return sogiayphep; }
            set { sogiayphep = value; }
        }
        public string Solo
        {
            get { return solo; }
            set { solo = value; }
        }
        public string Nhasanxuat
        {
            get { return nhasanxuat; }
            set { nhasanxuat = value; }
        }
        public string Tenthuoc
        {
            get { return tenthuoc; }
            set { tenthuoc= value; }
        }
        public string Hansudung
        {
            get { return hansudung; }
            set { hansudung = value; }
        }
        public int Giathanh
        {
            get { return giathanh; }
            set { giathanh = value; }
        }
        public string Huongdansudung
        {
            get { return huongdansudung; }
            set { huongdansudung = value; }
        }
        public string Loai
        {
            get { return loai; }
            set { loai = value; }
        }
        public int Id_baoquan
        {
            get { return id_baoquan; }
            set { id_baoquan = value; }
        }
        public int Id_nhacungcap
        {
            get { return id_nhacungcap; }
            set { id_nhacungcap = value; }
        }
        public string Id_phieunhanhang
        {
            get { return id_phieunhanhang; }
            set { id_phieunhanhang = value; }
        }
    }
}
