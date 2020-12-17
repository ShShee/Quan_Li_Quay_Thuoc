﻿using System;
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
    public partial class fHotelManager : Form
    {
        private bool Accessibility=true;
        public fHotelManager()
        {
            InitializeComponent();
            ucHome1.Visible = false;
            ucThietLap1.Visible = false;
            ucLuuTru1.Visible = false;
            ucThuoc1.Visible = false;
            ucBaoQuan1.Visible = false;
            ucTonKho1.Visible = false;
            ucDatHang1.Visible = false;
        }
        public bool Permission_to_access
        {
            get { return Accessibility; }
            set { Accessibility = value; }
        }

        private void fHotelManager_Load(object sender, EventArgs e)
        {
            ucTonKho1.Permission_to_access = Accessibility;
            ucThietLap1.Permission_to_access = Accessibility;
            if (Accessibility == false)
            {
                panel1.Visible = false;
                button_BaoQuan.Visible = false;
            }
            ucHome1.Visible = true;
        }

        private void itLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void fHotelManager_FormClosed(object sender, FormClosedEventArgs e)
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
                panel_left.Width = 70;
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
        }
    }   
}