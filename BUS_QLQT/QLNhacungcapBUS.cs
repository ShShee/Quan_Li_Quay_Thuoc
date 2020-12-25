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
    public class QLNhacungcapBUS
    {
        private static QLNhacungcapBUS instance;

        public static QLNhacungcapBUS Instance
        {
            get { if (instance == null) instance = new QLNhacungcapBUS(); return QLNhacungcapBUS.instance; }
            private set { QLNhacungcapBUS.instance = value; }
        }

        private QLNhacungcapBUS() { }

        public List<Nhacungcap> LoadNhacungcapList()
        {
            List<Nhacungcap> nccList = new List<Nhacungcap>();
            DataTable data = QLNhacungcapDAL.Instance.LoadNhacungcapList();
            foreach (DataRow item in data.Rows)
            {
                Nhacungcap ib = new Nhacungcap(item);
                nccList.Add(ib);
            }
            return nccList;
        }

        //public int GetMaxIDCheckin() // lấy id phòng đang tương tác
        //{
        //    return infoCheckinDAL.Instance.GetMaxIDCheckin();
        //}

        //public int GetAmountCustomer(int id) //lấy số lượng khách 
        //{
        //    return infoCheckinDAL.Instance.GetAmountCustomer(id);
        //}

        //public float GetMaxRatio(int id) //lấy tỉ lệ phụ thu loại khách lớn nhất
        //{
        //    return infoCheckinDAL.Instance.GetMaxRatio(id);
        //}

        //public bool insertCheckin(DateTime date,string id)
        //{
        //    return infoCheckinDAL.Instance.insertCheckin(date, id);
        //}

        //public bool updateCheckin(float ratio, int count, int id_checkin)
        //{
        //    return infoCheckinDAL.Instance.updateCheckin(ratio, count, id_checkin);
        //}


        //public bool insertCheckinInfo(string name, string type, string cmnd, string address, int id)
        //{
        //    return infoCheckinDAL.Instance.insertCheckinInfo(name, type, cmnd, address, id);
        //}
    }
}
