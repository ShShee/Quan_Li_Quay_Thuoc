﻿using System;
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

        private void btnHieuChinh_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == false) panel3.Visible = true; else panel3.Visible = false;
        }
    }
}
