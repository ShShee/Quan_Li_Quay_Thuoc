using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuayThuoc.DTO;
using QuanLyQuayThuoc.BUS;

namespace QuanLyQuayThuoc
{
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
            LoadHome(); 
        }

        void LoadHome()
        {
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            panel1.Visible = true;
            btnLayThuoc.Visible = true;
        }

        private void rbtnBanTheoDon_CheckedChanged(object sender, EventArgs e)
        {
            if (panel3.Visible == false) panel3.Visible = true;
            else
            {
                panel3.Visible = false;
                tbDTBS.Text = "";
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Enabled = true;
            btnLayThuoc.Visible = false;
        }
    }
}
