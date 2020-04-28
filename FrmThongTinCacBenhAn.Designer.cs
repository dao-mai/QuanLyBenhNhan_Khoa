namespace QuanLyBenhNhan
{
    partial class FrmThongTinCacBenhAn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboMaBenhAn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataGridView_BAT = new System.Windows.Forms.DataGridView();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCongDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LieuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGridView_BAXN = new System.Windows.Forms.DataGridView();
            this.MaXetNghiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKetLuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXetNghiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKetLuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BacSiXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView_BAKL = new System.Windows.Forms.DataGridView();
            this.MaBenhAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhuongAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhuongAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoiDanBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BAT)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BAXN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BAKL)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.cboMaBenhAn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 118);
            this.panel1.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(492, 71);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "&Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboMaBenhAn
            // 
            this.cboMaBenhAn.FormattingEnabled = true;
            this.cboMaBenhAn.Location = new System.Drawing.Point(305, 73);
            this.cboMaBenhAn.Name = "cboMaBenhAn";
            this.cboMaBenhAn.Size = new System.Drawing.Size(147, 21);
            this.cboMaBenhAn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã bệnh án";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(237, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN BỆNH ÁN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.DataGridView_BAT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(76, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bệnh án thuốc";
            // 
            // DataGridView_BAT
            // 
            this.DataGridView_BAT.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGridView_BAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_BAT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.TenThuoc,
            this.MaCongDung,
            this.MaDonVi,
            this.ThanhPhan,
            this.DonGia,
            this.SoLuong,
            this.SoNgayDung,
            this.LieuDung,
            this.CachDung,
            this.ThanhTien});
            this.DataGridView_BAT.Location = new System.Drawing.Point(-6, 21);
            this.DataGridView_BAT.Name = "DataGridView_BAT";
            this.DataGridView_BAT.Size = new System.Drawing.Size(643, 89);
            this.DataGridView_BAT.TabIndex = 0;
            // 
            // MaThuoc
            // 
            this.MaThuoc.DataPropertyName = "MaT";
            this.MaThuoc.HeaderText = "Mã Thuốc";
            this.MaThuoc.Name = "MaThuoc";
            // 
            // TenThuoc
            // 
            this.TenThuoc.DataPropertyName = "TenT";
            this.TenThuoc.HeaderText = "Tên Thuốc";
            this.TenThuoc.Name = "TenThuoc";
            // 
            // MaCongDung
            // 
            this.MaCongDung.DataPropertyName = "MaCD";
            this.MaCongDung.HeaderText = "Mã Công Dụng";
            this.MaCongDung.Name = "MaCongDung";
            // 
            // MaDonVi
            // 
            this.MaDonVi.DataPropertyName = "MaĐV";
            this.MaDonVi.HeaderText = "Mã Đơn Vị Tính";
            this.MaDonVi.Name = "MaDonVi";
            // 
            // ThanhPhan
            // 
            this.ThanhPhan.DataPropertyName = "ThanhPhan";
            this.ThanhPhan.HeaderText = "Thành Phần";
            this.ThanhPhan.Name = "ThanhPhan";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "ĐonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // SoNgayDung
            // 
            this.SoNgayDung.DataPropertyName = "SoNgayDung";
            this.SoNgayDung.HeaderText = "Số Ngày Dùng";
            this.SoNgayDung.Name = "SoNgayDung";
            // 
            // LieuDung
            // 
            this.LieuDung.DataPropertyName = "LieuDung";
            this.LieuDung.HeaderText = "Liều Dùng";
            this.LieuDung.Name = "LieuDung";
            // 
            // CachDung
            // 
            this.CachDung.DataPropertyName = "CachDung";
            this.CachDung.HeaderText = "Cách Dùng";
            this.CachDung.Name = "CachDung";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.DataGridView_BAXN);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(76, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bệnh án xét nghiệm";
            // 
            // DataGridView_BAXN
            // 
            this.DataGridView_BAXN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_BAXN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaXetNghiem,
            this.TenKetLuan,
            this.NgayXetNghiem,
            this.KetQua,
            this.MaKetLuan,
            this.BacSiXN,
            this.TienXN});
            this.DataGridView_BAXN.Location = new System.Drawing.Point(0, 19);
            this.DataGridView_BAXN.Name = "DataGridView_BAXN";
            this.DataGridView_BAXN.Size = new System.Drawing.Size(643, 86);
            this.DataGridView_BAXN.TabIndex = 1;
            // 
            // MaXetNghiem
            // 
            this.MaXetNghiem.DataPropertyName = "MaXN";
            this.MaXetNghiem.HeaderText = "Mã Xét Nghiệm";
            this.MaXetNghiem.Name = "MaXetNghiem";
            // 
            // TenKetLuan
            // 
            this.TenKetLuan.DataPropertyName = "TenKL";
            this.TenKetLuan.HeaderText = "Tên Kết Luận";
            this.TenKetLuan.Name = "TenKetLuan";
            // 
            // NgayXetNghiem
            // 
            this.NgayXetNghiem.DataPropertyName = "NgayXN";
            this.NgayXetNghiem.HeaderText = "Ngày Xét Nghiệm";
            this.NgayXetNghiem.Name = "NgayXetNghiem";
            // 
            // KetQua
            // 
            this.KetQua.DataPropertyName = "KetQua";
            this.KetQua.HeaderText = "Kết Quả";
            this.KetQua.Name = "KetQua";
            // 
            // MaKetLuan
            // 
            this.MaKetLuan.DataPropertyName = "MaKL";
            this.MaKetLuan.HeaderText = "Mã Kết Luận";
            this.MaKetLuan.Name = "MaKetLuan";
            // 
            // BacSiXN
            // 
            this.BacSiXN.DataPropertyName = "BacSiXN";
            this.BacSiXN.HeaderText = "Bác Sĩ XN";
            this.BacSiXN.Name = "BacSiXN";
            // 
            // TienXN
            // 
            this.TienXN.DataPropertyName = "TienXN";
            this.TienXN.HeaderText = "Tiền Xét Ngiệm";
            this.TienXN.Name = "TienXN";
            // 
            // DataGridView_BAKL
            // 
            this.DataGridView_BAKL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_BAKL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBenhAn,
            this.TenBenh,
            this.TenPhuongAn,
            this.MaBenh,
            this.MaPhuongAn,
            this.LoiDanBS});
            this.DataGridView_BAKL.Location = new System.Drawing.Point(0, 21);
            this.DataGridView_BAKL.Name = "DataGridView_BAKL";
            this.DataGridView_BAKL.Size = new System.Drawing.Size(642, 82);
            this.DataGridView_BAKL.TabIndex = 2;
            // 
            // MaBenhAn
            // 
            this.MaBenhAn.DataPropertyName = "MaBA";
            this.MaBenhAn.HeaderText = "Mã Bệnh Án";
            this.MaBenhAn.Name = "MaBenhAn";
            // 
            // TenBenh
            // 
            this.TenBenh.DataPropertyName = "TenB";
            this.TenBenh.HeaderText = "Tên Bệnh";
            this.TenBenh.Name = "TenBenh";
            // 
            // TenPhuongAn
            // 
            this.TenPhuongAn.DataPropertyName = "TenPA";
            this.TenPhuongAn.HeaderText = "Tên Phương Án";
            this.TenPhuongAn.Name = "TenPhuongAn";
            // 
            // MaBenh
            // 
            this.MaBenh.DataPropertyName = "MaB";
            this.MaBenh.HeaderText = "Mã Bệnh";
            this.MaBenh.Name = "MaBenh";
            // 
            // MaPhuongAn
            // 
            this.MaPhuongAn.DataPropertyName = "MaPA";
            this.MaPhuongAn.HeaderText = "Mã Phương Án";
            this.MaPhuongAn.Name = "MaPhuongAn";
            // 
            // LoiDanBS
            // 
            this.LoiDanBS.DataPropertyName = "LoiDanBS";
            this.LoiDanBS.HeaderText = "Lời Dặn Bác Sĩ";
            this.LoiDanBS.Name = "LoiDanBS";
            this.LoiDanBS.Width = 150;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.DataGridView_BAKL);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(76, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(643, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bệnh án kết luận";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 332);
            this.panel2.TabIndex = 1;
            // 
            // FrmThongTinCacBenhAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmThongTinCacBenhAn";
            this.Text = "Thông Tin Các Bệnh Án";
            this.Load += new System.EventHandler(this.FrmThongTinBenhAn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BAT)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BAXN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BAKL)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboMaBenhAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGridView_BAT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataGridView_BAKL;
        private System.Windows.Forms.DataGridView DataGridView_BAXN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCongDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn LieuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn CachDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenhAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhuongAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhuongAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoiDanBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXetNghiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKetLuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXetNghiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn KetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKetLuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BacSiXN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienXN;
    }
}