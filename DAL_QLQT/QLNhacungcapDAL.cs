using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuayThuoc.DAL
{
    public class QLNhacungcapDAL
    {
        private static QLNhacungcapDAL instance;
        public static QLNhacungcapDAL Instance
        {
            get { if (instance == null) instance = new QLNhacungcapDAL(); return instance; }
            private set { instance = value; }
        }
        private QLNhacungcapDAL() { }
        public DataTable LoadNhacungcapList()
        {
            return DataProvider.Instance.ExecuteQuery("select * from DBO.NHACUNGCAP,DBO.THONGTINCOBAN where NHACUNGCAP.id_thongtincoban=THONGTINCOBAN.id_thongtincoban");
        }
        public DataTable SearchBill(string condition)
        {
            string query = "select * from dbo.BILL where " + condition;
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
