using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuayThuoc.DAL
{
    public class QLBaohiemDAL
    {
        private static QLBaohiemDAL instance;
        public static QLBaohiemDAL Instance
        {
            get { if (instance == null) instance = new QLBaohiemDAL(); return instance; }
            private set { instance = value; }
        }
        private QLBaohiemDAL() { }
        public DataTable LoadBaohiemyteList()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM DBO.BAOHIEMYTE");
        }
        public int GetTilebaohiem(string loai)
        {
            string query = "SELECT tile FROM BAOHIEMYTE WHERE loaihinh='" + loai + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            int id = result.Rows[0].Field<int>(0);
            return id;
        }
    }
}
