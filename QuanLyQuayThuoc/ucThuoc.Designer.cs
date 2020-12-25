namespace QuanLyQuayThuoc
{
    partial class ucThuoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHieuChinh = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvQLThuoc = new System.Windows.Forms.DataGridView();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.id_thuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chatluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_loaithuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnHieuChinh);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtgvQLThuoc);
            this.panel1.Location = new System.Drawing.Point(16, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 501);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nhập mã:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "id_thuoc",
            "id_loaithuoc",
            "id_baoquan"});
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "id_thuoc",
            "id_loaithuoc"});
            this.comboBox1.Location = new System.Drawing.Point(234, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(732, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 79);
            this.panel3.TabIndex = 27;
            this.panel3.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(178, 8);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 59);
            this.button4.TabIndex = 28;
            this.button4.Text = "Lưu thay đổi";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(75, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(89, 26);
            this.textBox2.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mã loại:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(102, 41);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(62, 26);
            this.textBox4.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Chất lượng:";
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.btnHieuChinh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHieuChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHieuChinh.ForeColor = System.Drawing.Color.White;
            this.btnHieuChinh.Location = new System.Drawing.Point(835, 14);
            this.btnHieuChinh.Margin = new System.Windows.Forms.Padding(2);
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.Size = new System.Drawing.Size(131, 26);
            this.btnHieuChinh.TabIndex = 36;
            this.btnHieuChinh.Text = "Đánh giá chất lượng";
            this.btnHieuChinh.UseVisualStyleBackColor = false;
            this.btnHieuChinh.Click += new System.EventHandler(this.btnHieuChinh_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(757, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 26);
            this.button2.TabIndex = 34;
            this.button2.Text = "Tạo lại";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(591, 13);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(73, 26);
            this.btnTimKiem.TabIndex = 33;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(453, 13);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(103, 26);
            this.textBox3.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Chọn phương thức tìm kiếm:";
            // 
            // dtgvQLThuoc
            // 
            this.dtgvQLThuoc.AllowUserToAddRows = false;
            this.dtgvQLThuoc.AllowUserToDeleteRows = false;
            this.dtgvQLThuoc.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dtgvQLThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQLThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_thuoc,
            this.soluong,
            this.chatluong,
            this.id_loaithuoc});
            this.dtgvQLThuoc.Location = new System.Drawing.Point(26, 48);
            this.dtgvQLThuoc.Name = "dtgvQLThuoc";
            this.dtgvQLThuoc.Size = new System.Drawing.Size(940, 433);
            this.dtgvQLThuoc.TabIndex = 0;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddRoom.Enabled = false;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(16, 18);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(192, 45);
            this.btnAddRoom.TabIndex = 5;
            this.btnAddRoom.Text = "Thông Tin Thuốc";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            // 
            // id_thuoc
            // 
            this.id_thuoc.DataPropertyName = "id_thuoc";
            this.id_thuoc.HeaderText = "Mã thuốc";
            this.id_thuoc.Name = "id_thuoc";
            this.id_thuoc.Width = 160;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.Width = 160;
            // 
            // chatluong
            // 
            this.chatluong.DataPropertyName = "chatluong";
            this.chatluong.HeaderText = "Chất lượng";
            this.chatluong.Name = "chatluong";
            this.chatluong.Width = 160;
            // 
            // id_loaithuoc
            // 
            this.id_loaithuoc.DataPropertyName = "id_loaithuoc";
            this.id_loaithuoc.HeaderText = "Mã loại thuốc";
            this.id_loaithuoc.Name = "id_loaithuoc";
            this.id_loaithuoc.Width = 160;
            // 
            // ucThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddRoom);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucThuoc";
            this.Size = new System.Drawing.Size(1055, 782);
            this.Load += new System.EventHandler(this.ucThuoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLThuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHieuChinh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvQLThuoc;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_thuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn chatluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_loaithuoc;
    }
}
