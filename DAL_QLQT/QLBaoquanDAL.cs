using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuayThuoc.DAL
{
    public class QLBaoquanDAL
    {
        private static QLBaoquanDAL instance;
        public static QLBaoquanDAL Instance
        {
            get { if (instance == null) instance = new QLBaoquanDAL(); return instance; }
            private set { instance = value; }
        }
        private QLBaoquanDAL() { }
        public DataTable LoadThongtinbaoquanList()
        {
           return DataProvider.Instance.ExecuteQuery("SELECT * FROM DBO.THONGTINBAOQUAN");
        }
        public DataTable SearchCheckin(string condition)
        {
            string query = "select * from dbo.CHECKIN where " + condition;
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
