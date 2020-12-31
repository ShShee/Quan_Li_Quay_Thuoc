using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuayThuoc.BUS;
using System.Windows.Forms;

namespace QuanLyQuayThuoc
{
    public partial class ucDatHang : UserControl
    {
        public ucDatHang()
        {
            InitializeComponent();
        }

        private void ucDatHang_Load(object sender, EventArgs e)
        {
            dtgvPhieudathang.DataSource = QLPhieuBUS.Instance.LoadPhieudathangList();
        }

        private void dtgvPhieudathang_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvPhieudathang.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvPhieudathang.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvPhieudathang.Rows[selectedrowindex];
                txbId_phieudathang.Text = Convert.ToString(selectedRow.Cells["Id_phieudathang"].Value);
                dtgvChitietdathang.DataSource = QLPhieuBUS.Instance.LoadChitietdathangList(txbId_phieudathang.Text);
            }
        }
    }
}
