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
using QuanLyQuayThuoc.DTO;

namespace QuanLyQuayThuoc
{
    public partial class ucLuuTru : UserControl
    {
        public ucLuuTru()
        {
            InitializeComponent();
            
        }

        List<Thongtinbaoquan> baoquans;

        private void btnHieuChinh_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == false) panel3.Visible = true; else panel3.Visible = false;
        }

        private void ucLuuTru_Load(object sender, EventArgs e)
        {
            dtgvThongtinluutru.DataSource = QLLuutruBUS.Instance.LoadThongtinluutruList();
            baoquans = QLBaoquanBUS.Instance.LoadThongtinbaoquanList();
            comboBox1.DataSource = baoquans;
            comboBox1.ValueMember = "Id_baoquan";
            comboBox1.DisplayMember = "Khuvuc";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int giaThanh = 0;
            try
            {
                giaThanh = int.Parse(textBox5.Text);
            }
            catch
            {

            }
            Thongtinluutru thongtinluutru = new Thongtinluutru()
            {
                Tenthuoc = textBox4.Text,
                HanSuDungDT = dateTimePicker1.Value,
                Giathanh = giaThanh,
                Id_baoquan = ((Thongtinbaoquan)comboBox1.SelectedItem).Id_baoquan,
                Huongdansudung = richTextBox1.Text
            };

            QLLuutruBUS.Instance.ThemThongTinLuuTru(thongtinluutru);
            dtgvThongtinluutru.DataSource = QLLuutruBUS.Instance.LoadThongtinluutruList();

        }
    }
}
