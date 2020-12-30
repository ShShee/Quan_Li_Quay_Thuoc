using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuayThuoc.DTO;

namespace QuanLyQuayThuoc.DAL
{
    public class QLLuutruDAL
    {
        private static QLLuutruDAL instance;
        public static QLLuutruDAL Instance
        {
            get { if (instance == null) instance = new QLLuutruDAL(); return instance; }
            private set { instance = value; }
        }
        private QLLuutruDAL() { }
        public DataTable LoadThongtinluutruList()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM DBO.THONGTINLUUTRU");
        }
        public DataTable LoadTenthuocList(bool kedon)
        {
            string distinct = "", query = "SELECT tenthuoc FROM DBO.THONGTINLUUTRU where loai";
            if (kedon == true) distinct = "="; else distinct = "!=";
            query += distinct + " 'VN'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void ThemThongTinLuuTru(Thongtinluutru thongtinluutru)
        {
            string query = @"INSERT INTO [dbo].[THONGTINLUUTRU]([tenthuoc],[hansudung],[giathanh],[id_baoquan],[soluong],[huongdansudung])
     VALUES(N'" + thongtinluutru.Tenthuoc + "',N'"+ thongtinluutru.HanSuDungDT.ToString("yyyy-MM-dd hh:mm:ss") + "',"+ thongtinluutru.Giathanh + ","+ thongtinluutru.Id_baoquan + ",1,'"+ thongtinluutru.Huongdansudung + "')";
            DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
