using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuayThuoc.DTO
{
    public class Thuoc
    {
        public Thuoc(/*string id_thuoc,*/int soluong, string chatluong, int id_loaithuoc)
        {
            //this.Id_thuoc= id_thuoc;
            this.Soluong = soluong;
            this.Chatluong = chatluong;
            this.Id_loaithuoc = id_loaithuoc;
        }

        public Thuoc(DataRow row)
        {
            this.Id_thuoc = row["id_thuoc"].ToString();
            this.Soluong = (int)Convert.ToInt32(row["soluong"].ToString());
            this.Chatluong = row["chatluong"].ToString();
            this.Id_loaithuoc = (int)Convert.ToInt32(row["id_loaithuoc"].ToString());
        }

        private string id_thuoc;
        private int soluong;
        private string chatluong;
        private int id_loaithuoc;

        public string Id_thuoc
        {
            get { return id_thuoc; }
            set { id_thuoc = value; }
        }
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public string Chatluong
        {
            get { return chatluong; }
            set { chatluong = value; }
        }
        public int Id_loaithuoc
        {
            get { return id_loaithuoc; }
            set { id_loaithuoc = value; }
        }
    }
}
