using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyQuayThuoc.DAL;
using QuanLyQuayThuoc.DTO;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuayThuoc.BUS
{
    public class QLBaoquanBUS
    {
        private static QLBaoquanBUS instance;
        public static QLBaoquanBUS Instance
        {
            get { if (instance == null) instance = new QLBaoquanBUS(); return instance; }
            private set { instance = value; }
        }
        private QLBaoquanBUS() { }
        public List<Thongtinbaoquan> LoadThongtinbaoquanList()
        {
            List<Thongtinbaoquan> ttbqList = new List<Thongtinbaoquan>();
            DataTable data = QLBaoquanDAL.Instance.LoadThongtinbaoquanList();
            foreach (DataRow item in data.Rows)
            {
                Thongtinbaoquan ckin = new Thongtinbaoquan(item);
                ttbqList.Add(ckin);
            }
            return ttbqList;
        }
        public DataTable SearchCheckin(string condition)
        {
            return QLBaoquanDAL.Instance.SearchCheckin(condition);
        }
    }
}
