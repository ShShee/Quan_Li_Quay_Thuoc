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
    public partial class ucThietLap : UserControl
    {
        private bool Accessibility=true;
        public ucThietLap()
        {
            InitializeComponent();
        }

        public bool Permission_to_access
        {
            get { return Accessibility; }
            set { Accessibility = value; }
        }

        private void btnHieuChinh_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == false) panel3.Visible = true; else panel3.Visible = false;
        }

        private void ucThietLap_Load(object sender, EventArgs e)
        {
            dtgvNhacungcap.DataSource = QLNhacungcapBUS.Instance.LoadNhacungcapList();
            dtgvBaohiemyte.DataSource = QLBaohiemBUS.Instance.LoadBaohiemyteList();
        }
    }
}
