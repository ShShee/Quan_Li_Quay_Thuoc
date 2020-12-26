
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuayThuoc.DAL
{
    public class QLThuocDAL
    {
        private static QLThuocDAL instance;

        public static QLThuocDAL Instance
        {
            get { if (instance == null) instance = new QLThuocDAL(); return QLThuocDAL.instance; }
            private set { QLThuocDAL.instance = value; }
        }

        private QLThuocDAL() { }

        public DataTable LoadThuocList()
        {
           return DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.THUOC");
        }
        public DataTable LoadIdthuocList(string tenthuoc)
        {
            string query = "SELECT id_thuoc FROM DBO.THUOC,DBO.THONGTINLUUTRU where THUOC.soluong>0 and THUOC.id_loaithuoc=THONGTINLUUTRU.id_loaithuoc and THONGTINLUUTRU.tenthuoc='"+tenthuoc+"'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int GetSoluong(string id_thuoc)
        {
            string query = "SELECT soluong FROM DBO.THUOC where id_thuoc='" + id_thuoc + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            int id = result.Rows[0].Field<int>(0);
            return id;
        }
    }
} 
