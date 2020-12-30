using System;
using System.Data;
using QuanLyQuayThuoc.DAL;
using QuanLyQuayThuoc.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuayThuoc.BUS
{
    public class QLLuutruBUS
    {
        private static QLLuutruBUS instance;
        public static QLLuutruBUS Instance
        {
            get { if (instance == null) instance = new QLLuutruBUS(); return instance; }
            private set { instance = value; }
        }
        private QLLuutruBUS() { }
        public List<Thongtinluutru> LoadThongtinluutruList()
        {
            List<Thongtinluutru> ttltList = new List<Thongtinluutru>();
            DataTable data = QLLuutruDAL.Instance.LoadThongtinluutruList();
            foreach (DataRow item in data.Rows)
            {
                Thongtinluutru ib = new Thongtinluutru(item);
                ttltList.Add(ib);
            }
            return ttltList;
        }
        public List<string> LoadTenthuocList(bool kedon)
        {
            List<string> list = new List<string>();

            DataTable data = QLLuutruDAL.Instance.LoadTenthuocList(kedon);

            foreach (DataRow item in data.Rows)
            {
                list.Add(item.Field<string>(0));
            }
            return list;
        }

        public void ThemThongTinLuuTru(Thongtinluutru thongtinluutru)
        {
            QLLuutruDAL.Instance.ThemThongTinLuuTru(thongtinluutru);
        }
    }
}
