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
using System.IO;

namespace QuanLyQuayThuoc
{
    public partial class ucHome : UserControl
    {
        private string id_nhanvien="";
        public ucHome()
        {
            InitializeComponent();
        }
         private void LoadData()
        {
            dtgvChitiethoadon.DataSource = QLHoadonBUS.Instance.LoadChitiethoadonList(txbId_hoadon.Text);
        }
        private void ucHome_Load(object sender, EventArgs e)
        {
            cbbLoaihinh.Text = "none";
            txbId_hoadon.Text = "HD-" + PermissionBUS.Instance.GetId_hoadon().ToString();
            LoadData();
            TinhTong();
            if (dtgvChitiethoadon.SelectedCells.Count!=0)
            {
                btnClearAll.PerformClick();
            }
        }
        private void Xoahet()
        {
            panel1.Visible = false;
            btnLayThuoc.Visible = false;
            panel2.Enabled = true;
            txbNguoimua.Text = "";
            txbDiachi.Text = "";
            txbSodienthoai.Text = "";
            txbChuandoan.Text = "";
            txbBacsi.Text = "";
            txbSobaohiem.Text = "";
            cbbTenthuoc.Text = "";
            cbbId_thuoc.Text = "";
            txbSoluong.Text = "";
            txbLieuluong.Text = "";
            cbbLoaihinh.Text = "none";
        }
        private void TinhTong()
        {
            int tien = dtgvChitiethoadon.Rows.Count;
            int thanhtien = 0;
            for(int i=0;i<tien;i++)
            {
                thanhtien += Convert.ToInt32(dtgvChitiethoadon.Rows[i].Cells["thanhtien"].Value);
            }
            thanhtien = thanhtien + (QLBaohiemBUS.Instance.GetTileBaoHiem(cbbLoaihinh.Text) * thanhtien) / 100;
            txbTongtien.Text = thanhtien.ToString();
        }
        private void Thuchienthanhtoan()
        {
            if (dtgvChitiethoadon.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                     QLHoadonBUS.Instance.ExportDataTableToPdf(dtgvChitiethoadon, sfd.FileName, " HÓA ĐƠN THANH TOÁN ", 
                         txbId_hoadon.Text, dateTimePicker1.Value.ToString("dd/MM/yyyy"), txbTongtien.Text, txbBacsi.Text, txbChuandoan.Text, txbSobaohiem.Text, 
                         id_nhanvien,txbTen_nhanvien.Text, txbNguoimua.Text, txbDiachi.Text, txbSodienthoai.Text, cbbLoaihinh.Text);
                }
            }
            QLHoadonBUS.Instance.Capnhathoadon();
            txbId_hoadon.Text = "HD-" + PermissionBUS.Instance.GetId_hoadon().ToString();
            QLHoadonBUS.Instance.Xuathoadon(txbId_hoadon.Text);
        }
        private bool Kiemtrarangbuoc()
        {
            return (cbbId_thuoc.Text == "" || cbbTenthuoc.Text == "" || txbLieuluong.Text == "") ?false: true;
        }
        public void GetId_nhanvien(string id)
        {
            id_nhanvien = id;
            txbTen_nhanvien.Text = PermissionBUS.Instance.GetTen_nhanvien(id_nhanvien);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(txbNguoimua.Text=="")
            {
                MessageBox.Show("Vui lòng nhập tên người mua !!!");
            }
            else if(txbSodienthoai.Text==""||txbSodienthoai.Text.Length!=10)
            {
                MessageBox.Show("Số điện thoại nhập vào không hợp lệ !!!");
            }
            else if (panel3.Visible == true && txbBacsi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên bác sĩ đã kê đơn !!!");
            }
            else if (panel3.Visible == true && cbbLoaihinh.Text != "none" && txbSobaohiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập vào số bảo hiểm y tế !!!");             
            }
            else if (panel3.Visible == true && cbbLoaihinh.Text == "none" && txbSobaohiem.Text != "")
            {
                MessageBox.Show("Vui lòng chọn đúng loại !!!");
            }
            else
            {
                panel2.Enabled = false;
                panel1.Visible = true;
                btnLayThuoc.Visible = true;
                cbbTenthuoc.Items.Clear();
                List<string> result = QLLuutruBUS.Instance.LoadTenthuocList(panel3.Visible == true ? true : false);
                foreach (string part in result)
                    cbbTenthuoc.Items.Add(part);
            }
        }

        private void rbtnBanTheoDon_CheckedChanged(object sender, EventArgs e)
        {

            if (panel3.Visible == false)
            {
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
                txbBacsi.Text = "";
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            Xoahet();
            QLHoadonBUS.Instance.Taolaihoadon(txbId_hoadon.Text);
            LoadData();
            TinhTong();
        }

        private void txbSodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbTenthuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbId_thuoc.Text = "";
            txbSoluong.Text = "";
            cbbId_thuoc.Items.Clear();
            List<string> result = QLThuocBUS.Instance.LoadIdthuocList(cbbTenthuoc.Text);
            foreach (string part in result)
                cbbId_thuoc.Items.Add(part);
        }

        private void cbbId_thuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbSoluong.Text = "";
            txbSoluong.Text = QLThuocBUS.Instance.GetSoluong(cbbId_thuoc.Text).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Kiemtrarangbuoc() == false) MessageBox.Show("Thông tin chưa điền xin hãy nhập vào !!!");
            else if ((Convert.ToInt32(txbSoluong.Text) < Convert.ToInt32(txbLieuluong.Text)) && (Convert.ToInt32(txbLieuluong.Text) > 0)) MessageBox.Show("Số lượng lấy không được nhiều hơn tồn kho và phải lớn hơn không !!!");
            else
            {
                QLHoadonBUS.Instance.Themchitiethoadon(Convert.ToInt32(txbLieuluong.Text), cbbId_thuoc.Text, txbId_hoadon.Text);
                LoadData();
                TinhTong();
            }
        }

        private void dtgvChitiethoadon_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvChitiethoadon.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvChitiethoadon.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvChitiethoadon.Rows[selectedrowindex];
                cbbTenthuoc.Text = Convert.ToString(selectedRow.Cells["tenthuoc"].Value);
                cbbId_thuoc.Text = Convert.ToString(selectedRow.Cells["id_thuoc"].Value);
                txbLieuluong.Text = Convert.ToString(selectedRow.Cells["lieuluong"].Value);
                txbId_chitiet.Text = Convert.ToString(selectedRow.Cells["id_chitietkethuoc"].Value);
                txbSoluong.Text = QLThuocBUS.Instance.GetSoluong(cbbId_thuoc.Text).ToString();
            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (dtgvChitiethoadon.SelectedCells.Count > 0 && Kiemtrarangbuoc()==true)
            {
                if (Convert.ToInt32(txbSoluong.Text) < Convert.ToInt32(txbLieuluong.Text)) MessageBox.Show("Số lượng lấy không được nhiều hơn tồn kho !!!");
                else
                {
                    QLHoadonBUS.Instance.Suahoadon(Convert.ToInt32(txbId_chitiet.Text), cbbId_thuoc.Text, Convert.ToInt32(txbLieuluong.Text));
                    LoadData();
                    TinhTong();
                }
            }
            else
            {
                MessageBox.Show("Vi phạm ràng buộc. Hãy kiểm tra lại !!!");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dtgvChitiethoadon.SelectedCells.Count > 0 && Kiemtrarangbuoc() == true)
            {
                QLHoadonBUS.Instance.Xoahoadon(Convert.ToInt32(txbId_chitiet.Text), cbbId_thuoc.Text, Convert.ToInt32(txbLieuluong.Text));
                LoadData();
                TinhTong();
            }
            else
            {
                MessageBox.Show("Vi phạm ràng buộc. Hãy kiểm tra lại !!!");
            }
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            Xoahet();
            Thuchienthanhtoan();
            LoadData();
            TinhTong();
            
        }
    }
}
