using QuanLyQuayThuoc.DTO;
using QuanLyQuayThuoc.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuayThuoc.BUS
{
    public class PermissionBUS
    {
        private static PermissionBUS instance;
        public static PermissionBUS Instance
        {
            get { if (instance == null) instance = new PermissionBUS(); return instance; }
            private set { instance = value; }
        }
        private PermissionBUS() { }
        public string Permission(string username)
        {
            return PermissionDAL.Instance.Permission(username);
        }
        public int GetId_nhanvien(string username)
        {
            return PermissionDAL.Instance.GetId_nhanvien(username);
        }
        public string GetTen_nhanvien(string id)
        {
            return PermissionDAL.Instance.GetTen_nhanvien(id);
        }
        public int GetId_hoadon()
        {
            return PermissionDAL.Instance.GetId_hoadon();
        }
    }
}
