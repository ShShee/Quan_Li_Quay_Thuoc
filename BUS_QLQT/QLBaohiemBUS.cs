using QuanLyQuayThuoc.DTO;
using QuanLyQuayThuoc.DAL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuayThuoc.BUS
{
    public class QLBaohiemBUS
    {
            private static QLBaohiemBUS instance;
            public static QLBaohiemBUS Instance
            {
                get { if (instance == null) instance = new QLBaohiemBUS(); return instance; }
                private set { instance = value; }
            }
            private QLBaohiemBUS() { }
        public List<Baohiemyte> LoadBaohiemyteList()
        {
            List<Baohiemyte> bhytList = new List<Baohiemyte>();
            DataTable data = QLBaohiemDAL.Instance.LoadBaohiemyteList();
            foreach (DataRow item in data.Rows)
            {
                Baohiemyte bhyt = new Baohiemyte(item);
                bhytList.Add(bhyt);
            }
            return bhytList;
        }
        public int GetTileBaoHiem(string loai)
        {
            return QLBaohiemDAL.Instance.GetTilebaohiem(loai);
        }
    }

}
