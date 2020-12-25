
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuayThuoc.DAL
{
    public class PermissionDAL
    {
        private static PermissionDAL instance;
        public static PermissionDAL Instance
        {
            get { if (instance == null) instance = new PermissionDAL(); return instance; }
            private set { instance = value; }
        }
        private PermissionDAL() { }
        public string Permission(string username)
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("USP_GetPermission @username ", new object[] { username } );
            string permission_position = result.Rows[0].Field<string>(0);
            return permission_position;
        }
        public int GetId_nhanvien(string username)
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("USP_GetId_nhanvien @username ", new object[] { username });
            int id = result.Rows[0].Field<int>(0);
            return id;
        }
        public string GetTen_nhanvien(string id)
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("USP_GetTen_nhanvien @id ", new object[] { id });
            string name = result.Rows[0].Field<string>(0);
            return name;
        }
        public int GetId_hoadon()
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("USP_GetId_hoadon ");
            int id = result.Rows[0].Field<int>(0);
            return id+1;
        }
    }
}
