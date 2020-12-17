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
    public partial class ucTonKho : UserControl
    {
        private bool Accessibility=true;
        public ucTonKho()
        {
            InitializeComponent();         
        }

        //#region Xử lí phân quyền

        public bool Permission_to_access
        {
            get { return Accessibility; }
            set { Accessibility = value; }
        }
    }
}
