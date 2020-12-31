using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuayThuoc.BUS;

namespace QuanLyQuayThuoc
{
    public partial class ucHoaDon : UserControl
    {
        public ucHoaDon()
        {
            InitializeComponent();
        }

        private void ucHoaDon_Load(object sender, EventArgs e)
        {
            dtgvHoadon.DataSource = QLHoadonBUS.Instance.LoadHoadonList();
        }
    }
}
