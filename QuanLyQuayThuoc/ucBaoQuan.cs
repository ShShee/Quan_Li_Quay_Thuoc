using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuayThuoc.BUS;
using QuanLyQuayThuoc.DTO;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;


namespace QuanLyQuayThuoc
{
    public partial class ucBaoQuan : UserControl
    {
        public ucBaoQuan()
        {
            InitializeComponent();
        }

        private void btnHieuChinh_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == false) panel3.Visible = true; else panel3.Visible = false;
        }

        private void ucBaoQuan_Load(object sender, EventArgs e)
        {
            dtgvThongtinbaoquan.DataSource = QLBaoquanBUS.Instance.LoadThongtinbaoquanList();
        }
    }
}
