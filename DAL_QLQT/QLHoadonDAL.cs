using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuayThuoc.DAL
{
    public class QLHoadonDAL
    {
        private static QLHoadonDAL instance;
        public static QLHoadonDAL Instance
        {
            get { if (instance == null) instance = new QLHoadonDAL(); return instance; }
            private set { instance = value; }
        }
        private QLHoadonDAL() { }
        public DataTable LoadHoadonList()
        {
            string query = "SELECT * FROM DBO.HOADONBANTHUOC,DBO.THONGTINCOBAN WHERE TONGTIEN!=0 and HOADONBANTHUOC.id_thongtincoban=THONGTINCOBAN.id_thongtincoban";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable LoadChitiethoadonList(string id_hoadon)
        {
            string query = "SELECT * FROM DBO.CHITIETKETHUOC,DBO.THUOC,DBO.THONGTINLUUTRU where CHITIETKETHUOC.id_thuoc=THUOC.id_thuoc and THUOC.id_loaithuoc=THONGTINLUUTRU.id_loaithuoc and CHITIETKETHUOC.id_hoadon='" + id_hoadon + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public void ThemChitiethoadon(int lieuluong,string id_thuoc,string id_hoadon)
        {
            DataProvider.Instance.ExecuteQuery("USP_Themhoadon @id_lieuluong , @id_thuoc , @id_hoadon", new object[] { lieuluong, id_thuoc, id_hoadon });
        }
        public void Taolaihoadon(string id_hoadon)
        {
            DataProvider.Instance.ExecuteQuery("USP_Taolaihoadon @id_hoadon", new object[] { id_hoadon });
        }
        public void Suahoadon(int id_chitietkethuoc,string id_thuoc,int lieuluong)
        {
            DataProvider.Instance.ExecuteQuery("USP_Suahoadon @id_chitietkethuoc , @id_thuoc , @lieuluong", new object[] { id_chitietkethuoc,id_thuoc,lieuluong });
        }
        public void Xoahoadon(int id_chitietkethuoc,string id_thuoc,int lieuluong)
        {
            DataProvider.Instance.ExecuteQuery("USP_Xoahoadon @id_chitietkethuoc , @id_thuoc , @lieuluong", new object[] { id_chitietkethuoc,id_thuoc,lieuluong });
        }
        public void Capnhathoadon()
        {
            DataProvider.Instance.ExecuteQuery("UPDATE MAHIENTAI SET id_hoadon = id_hoadon + 1 WHERE id_mahientai = '1'");
        }
        public void Xuathoadon(string id_hoadon)
        {
            string query = "INSERT INTO HOADONBANTHUOC VALUES('" + id_hoadon + "','','','','','','1','1','none')";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public string Luuthongtin(string ten,string diachi,string sodienthoai)
        {
            int id = PermissionDAL.Instance.GetId_thongtincoban();
            string query = "INSERT INTO THONGTINCOBAN VALUES('" + id + "',N'" + ten + "',N'" + diachi + "','" + sodienthoai + "')";
            DataProvider.Instance.ExecuteQuery(query);
            return id.ToString();
        }
        public void Luuhoadon(string id_hoadon,string ngaylap,string tongtien,string bacsikedon,string chuandoanbenh,string sobaohiemyte,string id_nhanvien,string id_thongtincoban,string loaihinh)
        {
            string query = "SET DATEFORMAT DMY " +
                "UPDATE HOADONBANTHUOC " +
                "SET ngaylap='" + ngaylap + "', tongtien='" + tongtien + "', bacsikedon= N'" + bacsikedon
                + "', chuandoanbenh= N'" + chuandoanbenh + "', sobaohiemyte= '"+sobaohiemyte+"', id_nhanvien='"+id_nhanvien+"', id_thongtincoban= '"+id_thongtincoban+"', loaihinh='"+loaihinh
                +"' WHERE id_hoadon='"+id_hoadon+"'";
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
