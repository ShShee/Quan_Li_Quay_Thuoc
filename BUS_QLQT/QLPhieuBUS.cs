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
    public class QLPhieuBUS
    {
        private static QLPhieuBUS instance;

        public static QLPhieuBUS Instance
        {
            get { if (instance == null) instance = new QLPhieuBUS(); return QLPhieuBUS.instance; }
            private set { QLPhieuBUS.instance = value; }
        }

        private QLPhieuBUS() { }

        public List<Phieudathang> LoadPhieudathangList()
        {
            List<Phieudathang> list = new List<Phieudathang>();

            DataTable data = QLPhieuDAL.Instance.LoadPhieudathangList();

            foreach (DataRow item in data.Rows)
            {
                Phieudathang info = new Phieudathang(item);
                list.Add(info);
            }
            return list;
        }
        public List<Chitietdathang> LoadChitietdathangList(string id_phieudathang)
        {
            List<Chitietdathang> list = new List<Chitietdathang>();

            DataTable data = QLPhieuDAL.Instance.LoadChitietdathangList(id_phieudathang);

            foreach (DataRow item in data.Rows)
            {
                Chitietdathang info = new Chitietdathang(item);
                list.Add(info);
            }
            return list;
        }
    }
}
