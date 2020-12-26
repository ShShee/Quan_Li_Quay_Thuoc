using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string distinct="",query = "SELECT tenthuoc FROM DBO.THONGTINLUUTRU where loai";
            if (kedon == true) distinct = "="; else distinct = "!=";
            query += distinct + " 'VN'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
