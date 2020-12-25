using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuayThuoc.DTO
{
    public class Baohiemyte
    {
        public Baohiemyte(string loaihinh, int tile)
        {
            this.Loaihinh= loaihinh;
            this.Tile = tile;
        }

        public Baohiemyte(DataRow row)
        {
            this.Loaihinh = row["loaihinh"].ToString();
            this.Tile = (int)Convert.ToInt32(row["tile"].ToString());
        }

        private string loaihinh;
        private int tile;

        public string Loaihinh
        {
            get { return loaihinh; }
            set { loaihinh = value; }
        }
        public int Tile
        {
            get { return tile; }
            set { tile = value; }
        }
    }
}

