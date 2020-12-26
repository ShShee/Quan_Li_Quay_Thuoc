using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuayThuoc
{
    public partial class fQLQT : Form
    {
        private bool Accessibility=true;
        public fQLQT()
        {
            InitializeComponent();
            ucHome1.Visible = false;
            ucThietLap1.Visible = false;
            ucLuuTru1.Visible = false;
            ucThuoc1.Visible = false;
            ucBaoQuan1.Visible = false;
            ucTonKho1.Visible = false;
            ucDatHang1.Visible = false;
            ucHoaDon1.Visible = false;
        }
        public bool Permission_to_access
        {
            get { return Accessibility; }
            set { Accessibility = value; }
        }

        public void SetID(int id_nhanvien)
        {
            txbID.Text = id_nhanvien.ToString();
        }

        private void fQLQT_Load(object sender, EventArgs e)
        {
            ucHome1.GetId_nhanvien(txbID.Text);
            if (Accessibility == false)
            {
                button_thietlap.Visible = false;
                btn_PhieuDatHang.Visible = false;
            }
            ucHome1.Visible = true;
        }

        private void itLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void fQLQT_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void Button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void Button_thugon_Click(object sender, EventArgs e)
        {
            if (panel_left.Width == 350)
            {
                panel_left.Width = 55;
            }
            else
            {
                panel_left.Width = 350;
            }
        }

        private void Button_trangchu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            foreach (Control item in panel_Menu.Controls)
                item.BackColor = panel_Menu.BackColor;
            btn.BackColor = Color.DeepSkyBlue;

            ucThietLap1.Visible = false;
            ucLuuTru1.Visible = false;
            ucThuoc1.Visible = false;
            ucBaoQuan1.Visible = false;
            ucTonKho1.Visible = false;
            ucHome1.Visible = true;
            ucDatHang1.Visible = false;
            ucHoaDon1.Visible = false;
        }

        private void Button_thietlap_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            foreach (Control item in panel_Menu.Controls)
                item.BackColor = panel_Menu.BackColor;
            btn.BackColor = Color.DeepSkyBlue;

            ucThietLap1.Visible = true;
            ucLuuTru1.Visible = false;
            ucThuoc1.Visible = false;
            ucBaoQuan1.Visible = false;
            ucTonKho1.Visible = false;
            ucHome1.Visible = false;
            ucDatHang1.Visible = false;
            ucHoaDon1.Visible = false;
        }

        private void Button_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UcHome2_Load(object sender, EventArgs e)
        {

        }

        private void Panel_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_cuaso_Click(object sender, EventArgs e)
        {

        }

        private void Button_phieutonkho_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            foreach (Control item in panel_Menu.Controls)
                item.BackColor = panel_Menu.BackColor;
            btn.BackColor = Color.DeepSkyBlue;

            ucThietLap1.Visible = false;
            ucLuuTru1.Visible = false;
            ucThuoc1.Visible = false;
            ucBaoQuan1.Visible = false;
            ucTonKho1.Visible = true;
            ucHome1.Visible = false;
            ucDatHang1.Visible = false;
            ucHoaDon1.Visible = false;
        }

        private void Button_luutru_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            foreach (Control item in panel_Menu.Controls)
                item.BackColor = panel_Menu.BackColor;
            btn.BackColor = Color.DeepSkyBlue;

            ucThietLap1.Visible = false;
            ucLuuTru1.Visible = true;
            ucThuoc1.Visible = false;
            ucBaoQuan1.Visible = false;
            ucTonKho1.Visible = false;
            ucHome1.Visible = false;
            ucDatHang1.Visible = false;
            ucHoaDon1.Visible = false;
        }

        private void Button_thuoc_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            foreach (Control item in panel_Menu.Controls)
                item.BackColor = panel_Menu.BackColor;
            btn.BackColor = Color.DeepSkyBlue;

            ucThietLap1.Visible = false;
            ucLuuTru1.Visible = false;
            ucThuoc1.Visible = true;
            ucBaoQuan1.Visible = false;
            ucTonKho1.Visible = false;
            ucHome1.Visible = false;
            ucDatHang1.Visible = false;
            ucHoaDon1.Visible = false;
        }

        private void btn_PhieuDatHang_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            foreach (Control item in panel_Menu.Controls)
                item.BackColor = panel_Menu.BackColor;
            btn.BackColor = Color.DeepSkyBlue;

            ucThietLap1.Visible = false;
            ucLuuTru1.Visible = false;
            ucThuoc1.Visible = false;
            ucBaoQuan1.Visible = false;
            ucTonKho1.Visible = false;
            ucHome1.Visible = false;
            ucDatHang1.Visible = true;
            ucHoaDon1.Visible = false;
        }

        private void Button_BaoQuan_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            foreach (Control item in panel_Menu.Controls)
                item.BackColor = panel_Menu.BackColor;
            btn.BackColor = Color.DeepSkyBlue;

            ucThietLap1.Visible = false;
            ucLuuTru1.Visible = false;
            ucThuoc1.Visible = false;
            ucBaoQuan1.Visible = true;
            ucTonKho1.Visible = false;
            ucHome1.Visible = false;
            ucDatHang1.Visible = false;
            ucHoaDon1.Visible = false;
        }

        private void button_hoadon_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            foreach (Control item in panel_Menu.Controls)
                item.BackColor = panel_Menu.BackColor;
            btn.BackColor = Color.DeepSkyBlue;

            ucThietLap1.Visible = false;
            ucLuuTru1.Visible = false;
            ucThuoc1.Visible = false;
            ucBaoQuan1.Visible = false;
            ucTonKho1.Visible = false;
            ucHome1.Visible = false;
            ucDatHang1.Visible = false;
            ucHoaDon1.Visible = true;
        }
    }   
}
