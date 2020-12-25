namespace QuanLyQuayThuoc
{
    partial class fQLQT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQLQT));
            this.button_exit = new System.Windows.Forms.Button();
            this.panel_congcu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_left = new System.Windows.Forms.Panel();
            this.button_thugon = new System.Windows.Forms.Button();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.button_hoadon = new System.Windows.Forms.Button();
            this.btn_PhieuDatHang = new System.Windows.Forms.Button();
            this.button_phieutonkho = new System.Windows.Forms.Button();
            this.button_trangchu = new System.Windows.Forms.Button();
            this.button_luutru = new System.Windows.Forms.Button();
            this.button_thuoc = new System.Windows.Forms.Button();
            this.button_BaoQuan = new System.Windows.Forms.Button();
            this.button_thietlap = new System.Windows.Forms.Button();
            this.button_thoat = new System.Windows.Forms.Button();
            this.ucThietLap1 = new QuanLyQuayThuoc.ucThietLap();
            this.ucBaoQuan1 = new QuanLyQuayThuoc.ucBaoQuan();
            this.ucThuoc1 = new QuanLyQuayThuoc.ucThuoc();
            this.ucLuuTru1 = new QuanLyQuayThuoc.ucLuuTru();
            this.ucTonKho1 = new QuanLyQuayThuoc.ucTonKho();
            this.ucHome1 = new QuanLyQuayThuoc.ucHome();
            this.ucDatHang1 = new QuanLyQuayThuoc.ucDatHang();
            this.ucHoaDon1 = new QuanLyQuayThuoc.ucHoaDon();
            this.txbID = new System.Windows.Forms.TextBox();
            this.panel_congcu.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Image = ((System.Drawing.Image)(resources.GetObject("button_exit.Image")));
            this.button_exit.Location = new System.Drawing.Point(1380, 0);
            this.button_exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(50, 42);
            this.button_exit.TabIndex = 14;
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // panel_congcu
            // 
            this.panel_congcu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_congcu.Controls.Add(this.txbID);
            this.panel_congcu.Controls.Add(this.label1);
            this.panel_congcu.Controls.Add(this.button1);
            this.panel_congcu.Controls.Add(this.button_exit);
            this.panel_congcu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_congcu.Location = new System.Drawing.Point(0, 0);
            this.panel_congcu.Margin = new System.Windows.Forms.Padding(2);
            this.panel_congcu.Name = "panel_congcu";
            this.panel_congcu.Size = new System.Drawing.Size(1430, 42);
            this.panel_congcu.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(639, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "QUẢN LÝ QUẦY THUỐC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1326, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 42);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.MintCream;
            this.panel_left.Controls.Add(this.button_thugon);
            this.panel_left.Controls.Add(this.panel_Menu);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 42);
            this.panel_left.Margin = new System.Windows.Forms.Padding(2);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(350, 766);
            this.panel_left.TabIndex = 16;
            // 
            // button_thugon
            // 
            this.button_thugon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_thugon.BackColor = System.Drawing.Color.MintCream;
            this.button_thugon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_thugon.FlatAppearance.BorderSize = 0;
            this.button_thugon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_thugon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_thugon.Image = ((System.Drawing.Image)(resources.GetObject("button_thugon.Image")));
            this.button_thugon.Location = new System.Drawing.Point(288, 4);
            this.button_thugon.Margin = new System.Windows.Forms.Padding(2);
            this.button_thugon.Name = "button_thugon";
            this.button_thugon.Size = new System.Drawing.Size(62, 42);
            this.button_thugon.TabIndex = 30;
            this.button_thugon.UseVisualStyleBackColor = false;
            this.button_thugon.Click += new System.EventHandler(this.Button_thugon_Click);
            // 
            // panel_Menu
            // 
            this.panel_Menu.Controls.Add(this.button_hoadon);
            this.panel_Menu.Controls.Add(this.btn_PhieuDatHang);
            this.panel_Menu.Controls.Add(this.button_phieutonkho);
            this.panel_Menu.Controls.Add(this.button_trangchu);
            this.panel_Menu.Controls.Add(this.button_luutru);
            this.panel_Menu.Controls.Add(this.button_thuoc);
            this.panel_Menu.Controls.Add(this.button_BaoQuan);
            this.panel_Menu.Controls.Add(this.button_thietlap);
            this.panel_Menu.Controls.Add(this.button_thoat);
            this.panel_Menu.Location = new System.Drawing.Point(0, 50);
            this.panel_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(350, 716);
            this.panel_Menu.TabIndex = 29;
            // 
            // button_hoadon
            // 
            this.button_hoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_hoadon.FlatAppearance.BorderSize = 0;
            this.button_hoadon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.button_hoadon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.button_hoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hoadon.ForeColor = System.Drawing.Color.Black;
            this.button_hoadon.Image = ((System.Drawing.Image)(resources.GetObject("button_hoadon.Image")));
            this.button_hoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hoadon.Location = new System.Drawing.Point(0, 272);
            this.button_hoadon.Margin = new System.Windows.Forms.Padding(2);
            this.button_hoadon.Name = "button_hoadon";
            this.button_hoadon.Size = new System.Drawing.Size(350, 63);
            this.button_hoadon.TabIndex = 29;
            this.button_hoadon.Text = "     Thông tin hóa đơn";
            this.button_hoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_hoadon.UseVisualStyleBackColor = true;
            this.button_hoadon.Click += new System.EventHandler(this.button_hoadon_Click);
            // 
            // btn_PhieuDatHang
            // 
            this.btn_PhieuDatHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PhieuDatHang.FlatAppearance.BorderSize = 0;
            this.btn_PhieuDatHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btn_PhieuDatHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btn_PhieuDatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PhieuDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PhieuDatHang.ForeColor = System.Drawing.Color.Black;
            this.btn_PhieuDatHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_PhieuDatHang.Image")));
            this.btn_PhieuDatHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PhieuDatHang.Location = new System.Drawing.Point(0, 408);
            this.btn_PhieuDatHang.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PhieuDatHang.Name = "btn_PhieuDatHang";
            this.btn_PhieuDatHang.Size = new System.Drawing.Size(350, 63);
            this.btn_PhieuDatHang.TabIndex = 28;
            this.btn_PhieuDatHang.Text = "     Quản lí phiếu";
            this.btn_PhieuDatHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PhieuDatHang.UseVisualStyleBackColor = true;
            this.btn_PhieuDatHang.Click += new System.EventHandler(this.btn_PhieuDatHang_Click);
            // 
            // button_phieutonkho
            // 
            this.button_phieutonkho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_phieutonkho.FlatAppearance.BorderSize = 0;
            this.button_phieutonkho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.button_phieutonkho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.button_phieutonkho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_phieutonkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_phieutonkho.ForeColor = System.Drawing.Color.Black;
            this.button_phieutonkho.Image = ((System.Drawing.Image)(resources.GetObject("button_phieutonkho.Image")));
            this.button_phieutonkho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_phieutonkho.Location = new System.Drawing.Point(0, 341);
            this.button_phieutonkho.Margin = new System.Windows.Forms.Padding(2);
            this.button_phieutonkho.Name = "button_phieutonkho";
            this.button_phieutonkho.Size = new System.Drawing.Size(350, 63);
            this.button_phieutonkho.TabIndex = 23;
            this.button_phieutonkho.Text = "     Lập phiếu tồn kho";
            this.button_phieutonkho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_phieutonkho.UseVisualStyleBackColor = true;
            this.button_phieutonkho.Click += new System.EventHandler(this.Button_phieutonkho_Click);
            // 
            // button_trangchu
            // 
            this.button_trangchu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_trangchu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_trangchu.FlatAppearance.BorderSize = 0;
            this.button_trangchu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.button_trangchu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.button_trangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_trangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_trangchu.ForeColor = System.Drawing.Color.Black;
            this.button_trangchu.Image = ((System.Drawing.Image)(resources.GetObject("button_trangchu.Image")));
            this.button_trangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_trangchu.Location = new System.Drawing.Point(0, 2);
            this.button_trangchu.Margin = new System.Windows.Forms.Padding(2);
            this.button_trangchu.Name = "button_trangchu";
            this.button_trangchu.Size = new System.Drawing.Size(350, 63);
            this.button_trangchu.TabIndex = 21;
            this.button_trangchu.Text = "      Trang chủ";
            this.button_trangchu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_trangchu.UseVisualStyleBackColor = false;
            this.button_trangchu.Click += new System.EventHandler(this.Button_trangchu_Click);
            // 
            // button_luutru
            // 
            this.button_luutru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_luutru.FlatAppearance.BorderSize = 0;
            this.button_luutru.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.button_luutru.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.button_luutru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_luutru.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_luutru.ForeColor = System.Drawing.Color.Black;
            this.button_luutru.Image = ((System.Drawing.Image)(resources.GetObject("button_luutru.Image")));
            this.button_luutru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_luutru.Location = new System.Drawing.Point(0, 138);
            this.button_luutru.Margin = new System.Windows.Forms.Padding(2);
            this.button_luutru.Name = "button_luutru";
            this.button_luutru.Size = new System.Drawing.Size(350, 63);
            this.button_luutru.TabIndex = 24;
            this.button_luutru.Text = "     Thông tin lưu trữ";
            this.button_luutru.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_luutru.UseVisualStyleBackColor = true;
            this.button_luutru.Click += new System.EventHandler(this.Button_luutru_Click);
            // 
            // button_thuoc
            // 
            this.button_thuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_thuoc.FlatAppearance.BorderSize = 0;
            this.button_thuoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.button_thuoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.button_thuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_thuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thuoc.ForeColor = System.Drawing.Color.Black;
            this.button_thuoc.Image = ((System.Drawing.Image)(resources.GetObject("button_thuoc.Image")));
            this.button_thuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_thuoc.Location = new System.Drawing.Point(0, 71);
            this.button_thuoc.Margin = new System.Windows.Forms.Padding(2);
            this.button_thuoc.Name = "button_thuoc";
            this.button_thuoc.Size = new System.Drawing.Size(350, 63);
            this.button_thuoc.TabIndex = 25;
            this.button_thuoc.Text = "     Thông tin thuốc";
            this.button_thuoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_thuoc.UseVisualStyleBackColor = true;
            this.button_thuoc.Click += new System.EventHandler(this.Button_thuoc_Click);
            // 
            // button_BaoQuan
            // 
            this.button_BaoQuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_BaoQuan.FlatAppearance.BorderSize = 0;
            this.button_BaoQuan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.button_BaoQuan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.button_BaoQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BaoQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BaoQuan.ForeColor = System.Drawing.Color.Black;
            this.button_BaoQuan.Image = ((System.Drawing.Image)(resources.GetObject("button_BaoQuan.Image")));
            this.button_BaoQuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_BaoQuan.Location = new System.Drawing.Point(0, 205);
            this.button_BaoQuan.Margin = new System.Windows.Forms.Padding(2);
            this.button_BaoQuan.Name = "button_BaoQuan";
            this.button_BaoQuan.Size = new System.Drawing.Size(350, 63);
            this.button_BaoQuan.TabIndex = 26;
            this.button_BaoQuan.Text = "     Thông tin bảo quản";
            this.button_BaoQuan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_BaoQuan.UseVisualStyleBackColor = true;
            this.button_BaoQuan.Click += new System.EventHandler(this.Button_BaoQuan_Click);
            // 
            // button_thietlap
            // 
            this.button_thietlap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_thietlap.FlatAppearance.BorderSize = 0;
            this.button_thietlap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.button_thietlap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.button_thietlap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_thietlap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thietlap.ForeColor = System.Drawing.Color.Black;
            this.button_thietlap.Image = ((System.Drawing.Image)(resources.GetObject("button_thietlap.Image")));
            this.button_thietlap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_thietlap.Location = new System.Drawing.Point(1, 475);
            this.button_thietlap.Margin = new System.Windows.Forms.Padding(2);
            this.button_thietlap.Name = "button_thietlap";
            this.button_thietlap.Size = new System.Drawing.Size(350, 63);
            this.button_thietlap.TabIndex = 27;
            this.button_thietlap.Text = "     Thiết lập";
            this.button_thietlap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_thietlap.UseVisualStyleBackColor = true;
            this.button_thietlap.Click += new System.EventHandler(this.Button_thietlap_Click);
            // 
            // button_thoat
            // 
            this.button_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_thoat.FlatAppearance.BorderSize = 0;
            this.button_thoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.button_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thoat.ForeColor = System.Drawing.Color.Black;
            this.button_thoat.Image = ((System.Drawing.Image)(resources.GetObject("button_thoat.Image")));
            this.button_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_thoat.Location = new System.Drawing.Point(0, 640);
            this.button_thoat.Margin = new System.Windows.Forms.Padding(2);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(351, 55);
            this.button_thoat.TabIndex = 28;
            this.button_thoat.Text = "     Thoát";
            this.button_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.Button_thoat_Click);
            // 
            // ucThietLap1
            // 
            this.ucThietLap1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ucThietLap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucThietLap1.Location = new System.Drawing.Point(350, 42);
            this.ucThietLap1.Margin = new System.Windows.Forms.Padding(2);
            this.ucThietLap1.Name = "ucThietLap1";
            this.ucThietLap1.Permission_to_access = true;
            this.ucThietLap1.Size = new System.Drawing.Size(1080, 766);
            this.ucThietLap1.TabIndex = 23;
            // 
            // ucBaoQuan1
            // 
            this.ucBaoQuan1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ucBaoQuan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBaoQuan1.Location = new System.Drawing.Point(350, 42);
            this.ucBaoQuan1.Margin = new System.Windows.Forms.Padding(2);
            this.ucBaoQuan1.Name = "ucBaoQuan1";
            this.ucBaoQuan1.Size = new System.Drawing.Size(1080, 766);
            this.ucBaoQuan1.TabIndex = 22;
            // 
            // ucThuoc1
            // 
            this.ucThuoc1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ucThuoc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucThuoc1.Location = new System.Drawing.Point(350, 42);
            this.ucThuoc1.Margin = new System.Windows.Forms.Padding(2);
            this.ucThuoc1.Name = "ucThuoc1";
            this.ucThuoc1.Size = new System.Drawing.Size(1080, 766);
            this.ucThuoc1.TabIndex = 21;
            // 
            // ucLuuTru1
            // 
            this.ucLuuTru1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ucLuuTru1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLuuTru1.Location = new System.Drawing.Point(350, 42);
            this.ucLuuTru1.Margin = new System.Windows.Forms.Padding(2);
            this.ucLuuTru1.Name = "ucLuuTru1";
            this.ucLuuTru1.Size = new System.Drawing.Size(1080, 766);
            this.ucLuuTru1.TabIndex = 20;
            // 
            // ucTonKho1
            // 
            this.ucTonKho1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ucTonKho1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTonKho1.Location = new System.Drawing.Point(350, 42);
            this.ucTonKho1.Margin = new System.Windows.Forms.Padding(2);
            this.ucTonKho1.Name = "ucTonKho1";
            this.ucTonKho1.Permission_to_access = true;
            this.ucTonKho1.Size = new System.Drawing.Size(1080, 766);
            this.ucTonKho1.TabIndex = 19;
            // 
            // ucHome1
            // 
            this.ucHome1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ucHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHome1.Location = new System.Drawing.Point(350, 42);
            this.ucHome1.Margin = new System.Windows.Forms.Padding(2);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(1080, 766);
            this.ucHome1.TabIndex = 18;
            // 
            // ucDatHang1
            // 
            this.ucDatHang1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ucDatHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDatHang1.Location = new System.Drawing.Point(350, 42);
            this.ucDatHang1.Margin = new System.Windows.Forms.Padding(2);
            this.ucDatHang1.Name = "ucDatHang1";
            this.ucDatHang1.Size = new System.Drawing.Size(1080, 766);
            this.ucDatHang1.TabIndex = 24;
            // 
            // ucHoaDon1
            // 
            this.ucHoaDon1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ucHoaDon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHoaDon1.Location = new System.Drawing.Point(350, 42);
            this.ucHoaDon1.Margin = new System.Windows.Forms.Padding(2);
            this.ucHoaDon1.Name = "ucHoaDon1";
            this.ucHoaDon1.Size = new System.Drawing.Size(1080, 766);
            this.ucHoaDon1.TabIndex = 25;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(1244, 11);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(77, 20);
            this.txbID.TabIndex = 18;
            this.txbID.Visible = false;
            // 
            // fQLQT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1430, 808);
            this.ControlBox = false;
            this.Controls.Add(this.ucThietLap1);
            this.Controls.Add(this.ucBaoQuan1);
            this.Controls.Add(this.ucThuoc1);
            this.Controls.Add(this.ucLuuTru1);
            this.Controls.Add(this.ucTonKho1);
            this.Controls.Add(this.ucHome1);
            this.Controls.Add(this.ucDatHang1);
            this.Controls.Add(this.ucHoaDon1);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel_congcu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fQLQT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fQLQT_FormClosed);
            this.Load += new System.EventHandler(this.fQLQT_Load);
            this.panel_congcu.ResumeLayout(false);
            this.panel_congcu.PerformLayout();
            this.panel_left.ResumeLayout(false);
            this.panel_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Panel panel_congcu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button button_trangchu;
        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.Button button_thietlap;
        private System.Windows.Forms.Button button_BaoQuan;
        private System.Windows.Forms.Button button_thuoc;
        private System.Windows.Forms.Button button_luutru;
        private System.Windows.Forms.Button button_phieutonkho;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button button_thugon;
        private ucHome ucHome1;
        private ucTonKho ucTonKho1;
        private ucLuuTru ucLuuTru1;
        private ucThuoc ucThuoc1;
        private ucBaoQuan ucBaoQuan1;
        private ucThietLap ucThietLap1;
        private ucDatHang ucDatHang1;
        private ucHoaDon ucHoaDon1;
        private System.Windows.Forms.Button btn_PhieuDatHang;
        private System.Windows.Forms.Button button_hoadon;
        private System.Windows.Forms.TextBox txbID;
    }
}