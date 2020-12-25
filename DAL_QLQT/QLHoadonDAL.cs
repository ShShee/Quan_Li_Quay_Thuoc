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
    }
}
