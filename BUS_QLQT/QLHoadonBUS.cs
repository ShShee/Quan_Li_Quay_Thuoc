using System;
using System.Collections.Generic;
using QuanLyQuayThuoc.DAL;
using QuanLyQuayThuoc.DTO;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Windows.Forms;

namespace QuanLyQuayThuoc.BUS
{
    public class QLHoadonBUS
    {
        private static QLHoadonBUS instance;
        public static QLHoadonBUS Instance
        {
            get { if (instance == null) instance = new QLHoadonBUS(); return instance; }
            private set { instance = value; }
        }
        private QLHoadonBUS() { }
        public List<Chitietkethuoc> LoadChitiethoadonList(string id_hoadon)
        {
            List<Chitietkethuoc> ctktList = new List<Chitietkethuoc>();
            DataTable data = QLHoadonDAL.Instance.LoadChitiethoadonList(id_hoadon);
            foreach (DataRow item in data.Rows)
            {
                Chitietkethuoc ib = new Chitietkethuoc(item);
                ctktList.Add(ib);
            }
            return ctktList;
        }
        public void Themchitiethoadon(int lieuluong,string id_thuoc,string id_hoadon)
        {
            QLHoadonDAL.Instance.ThemChitiethoadon(lieuluong,id_thuoc,id_hoadon);
        }
        public void Taolaihoadon(string id_hoadon)
        {
            QLHoadonDAL.Instance.Taolaihoadon(id_hoadon);
        }
        public void Suahoadon(int id_chitietkethuoc,string id_thuoc,int lieuluong)
        {
            QLHoadonDAL.Instance.Suahoadon(id_chitietkethuoc, id_thuoc, lieuluong);
        }
        public void Xoahoadon(int id_chitietkethuoc,string id_thuoc,int lieuluong)
        {
            QLHoadonDAL.Instance.Xoahoadon(id_chitietkethuoc,id_thuoc,lieuluong);
        }
        public void Capnhathoadon()
        {
            QLHoadonDAL.Instance.Capnhathoadon();
        }
        public void Xuathoadon(string id_hoadon)
        {
            QLHoadonDAL.Instance.Xuathoadon(id_hoadon);
        }

        public void ExportDataTableToPdf(DataGridView dtblTable, String strPdfPath, string strHeader, 
            string id_hoadon, string ngaylap, string tongtien, string bacsikedon, string chuandoanbenh, string sobaohiemyte, 
            string id_nhanvien,string ten_nhanvien, string ten_khachhang, string diachi, string sodienthoai, string loaihinh)
        {
            QLHoadonDAL.Instance.Luuhoadon(id_hoadon, ngaylap, tongtien, bacsikedon, chuandoanbenh, sobaohiemyte, id_nhanvien, QLHoadonDAL.Instance.Luuthongtin(ten_khachhang, diachi, sodienthoai), loaihinh);
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.Read);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();
            string working = Environment.CurrentDirectory;
            string ARIALUNI_TFF = Path.Combine(System.IO.Directory.GetParent(working).Parent.FullName, "ARIALUNI.TTF");

            BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            Font fontNormal = new Font(bf, 12, Font.NORMAL);

            //Report Header
            Font fntHead = new Font(bf, 20, Font.NORMAL);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAuthor = new Font(bf, 16, Font.NORMAL);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("\n\n Quầy thuốc Bệnh Viện", fntAuthor));
            prgAuthor.Add(new Chunk("\n Số hóa đơn : " + id_hoadon, fntAuthor));
            prgAuthor.Add(new Chunk("\n Ngày bán : " + ngaylap, fntAuthor));
            document.Add(prgAuthor);
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 50.0F, BaseColor.GRAY, Element.ALIGN_LEFT, 1)));
            document.Add(p);
            prgAuthor = new Paragraph();
            prgAuthor.Alignment = Element.ALIGN_LEFT;
            prgAuthor.Add(new Chunk("\n Người mua : " + ten_khachhang, fntAuthor));
            prgAuthor.Add(new Chunk("\n Địa chỉ : " + diachi, fntAuthor));
            prgAuthor.Add(new Chunk("\n Số điện thoại: " + sodienthoai, fntAuthor));
            prgAuthor.Add(new Chunk("\n Số bảo hiểm y tế : " + sobaohiemyte, fntAuthor));
            prgAuthor.Add(new Chunk("\n Bệnh nhân : " + loaihinh, fntAuthor));
            prgAuthor.Add(new Chunk("\n Bác sĩ kê đơn : " + bacsikedon, fntAuthor));
            prgAuthor.Add(new Chunk("\n Chuẩn đoán bệnh : " + chuandoanbenh, fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            document.Add(new Chunk("\n\n", fntHead));

            //Write the table
            PdfPTable pdfTable = new PdfPTable(dtblTable.Columns.Count-1);
            //Table header
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            Font fntCell = new Font(bf, 12, Font.NORMAL);

            for(int i=0;i<dtblTable.Columns.Count-1;i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(dtblTable.Columns[i].HeaderText, fntCell));
                pdfTable.AddCell(cell);
            }
            for(int i=0;i<dtblTable.Rows.Count;i++)
            {
                for(int j=0;j<dtblTable.Rows[i].Cells.Count-1;j++)
                {
                    pdfTable.AddCell(dtblTable.Rows[i].Cells[j].Value.ToString());
                }
            }
            document.Add(pdfTable);

            prgAuthor = new Paragraph();
            prgAuthor.Alignment = Element.ALIGN_LEFT;
            prgAuthor.Add(new Chunk("\n\n Tổng tiền (Đã bao gồm thuế gtgt và bảo hiểm y tế) : " + tongtien +" VNĐ", fntAuthor));
            document.Add(prgAuthor);
            prgAuthor = new Paragraph();
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("\n\n\n Người bán ", fntAuthor));
            prgAuthor.Add(new Chunk("\n\n\n"+ten_nhanvien, fntAuthor));
            document.Add(prgAuthor);

            document.Close();
            writer.Close();
            fs.Close();
        }
    }
}
