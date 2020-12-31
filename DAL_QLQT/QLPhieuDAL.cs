using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuayThuoc.DAL
{
    public class QLPhieuDAL
    {
        private static QLPhieuDAL instance;

        public static QLPhieuDAL Instance
        {
            get { if (instance == null) instance = new QLPhieuDAL(); return QLPhieuDAL.instance; }
            private set { QLPhieuDAL.instance = value; }
        }

        private QLPhieuDAL() { }

        public DataTable LoadPhieudathangList()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.PHIEUDATHANG");
        }
        public DataTable LoadChitietdathangList(string id_phieudathang)
        {
            string query = "SELECT * FROM DBO.CHITIETDATHANG,DBO.NHACUNGCAP,DBO.THONGTINCOBAN" +
                " where CHITIETDATHANG.id_nhacungcap=NHACUNGCAP.id_nhacungcap and NHACUNGCAP.id_thongtincoban=THONGTINCOBAN.id_thongtincoban" +
                " and id_phieudathang = '" + id_phieudathang + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
