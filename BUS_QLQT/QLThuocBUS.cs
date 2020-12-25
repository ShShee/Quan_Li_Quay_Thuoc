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
    public class QLThuocBUS
    {
        private static QLThuocBUS instance;

        public static QLThuocBUS Instance
        {
            get { if (instance == null) instance = new QLThuocBUS(); return QLThuocBUS.instance; }
            private set { QLThuocBUS.instance = value; }
        }

        private QLThuocBUS() { }

        public List<Thuoc> LoadThuocList()
        {
            List<Thuoc> list = new List<Thuoc>();

            DataTable data = QLThuocDAL.Instance.LoadThuocList();

            foreach (DataRow item in data.Rows)
            {
                Thuoc info = new Thuoc(item);
                list.Add(info);
            }
            return list;
        }
        public List<string> LoadIdthuocList(string tenthuoc)
        {
            List<string> list = new List<string>();

            DataTable data = QLThuocDAL.Instance.LoadIdthuocList(tenthuoc);

            foreach (DataRow item in data.Rows)
            {
                list.Add(item.Field<string>(0));
            }
            return list;
        }
        public int GetSoluong(string id_thuoc)
        {
            return QLThuocDAL.Instance.GetSoluong(id_thuoc);
        }
    }
} 
