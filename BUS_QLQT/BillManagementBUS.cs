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
    public class BillManagementBUS
    {
        private static BillManagementBUS instance;
        public static BillManagementBUS Instance
        {
            get { if (instance == null) instance = new BillManagementBUS(); return instance; }
            private set { instance = value; }
        }
        private BillManagementBUS() { }
        public List<Bill> LoadBillList()
        {
            List<Bill> BillList = new List<Bill>();
            DataTable data = BillManagementDAL.Instance.LoadBillList();
            foreach (DataRow item in data.Rows)
            {
                Bill ib = new Bill(item);
                BillList.Add(ib);
            }
            return BillList;
        }
        public DataTable SearchBill(string condition)
        {
            return BillManagementDAL.Instance.SearchBill(condition);
        }
    }
}
