namespace QuanLyBenhNhan
{
    partial class FrmBaoCaoThongTinThuoc
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
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.cboMaThuoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCongDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCongDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Controls.Add(this.btnHienThi);
            this.panel1.Controls.Add(this.cboMaThuoc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 155);
            this.panel1.TabIndex = 0;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Location = new System.Drawing.Point(615, 94);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(118, 23);
            this.btnExportExcel.TabIndex = 8;
            this.btnExportExcel.Text = "&Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Location = new System.Drawing.Point(496, 94);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 23);
            this.btnHienThi.TabIndex = 7;
            this.btnHienThi.Text = "&Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // cboMaThuoc
            // 
            this.cboMaThuoc.FormattingEnabled = true;
            this.cboMaThuoc.Location = new System.Drawing.Point(309, 96);
            this.cboMaThuoc.Name = "cboMaThuoc";
            this.cboMaThuoc.Size = new System.Drawing.Size(147, 21);
            this.cboMaThuoc.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(188, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "BÁO CÁO THÔNG TIN THUỐC";
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.TenCongDung,
            this.DonViTinh,
            this.TenThuoc,
            this.MaCongDung,
            this.ThanhPhan,
            this.MaDonVi,
            this.DonGia});
            this.DataGridView.Location = new System.Drawing.Point(0, 152);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(800, 253);
            this.DataGridView.TabIndex = 3;
            // 
            // MaThuoc
            // 
            this.MaThuoc.DataPropertyName = "MaT";
            this.MaThuoc.HeaderText = "Mã Thuốc";
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.Width = 90;
            // 
            // TenCongDung
            // 
            this.TenCongDung.DataPropertyName = "TenCD";
            this.TenCongDung.HeaderText = "Tên Công Dụng";
            this.TenCongDung.Name = "TenCongDung";
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "TenĐV";
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.Name = "DonViTinh";
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
            this.MaCongDung.Width = 90;
            // 
            // ThanhPhan
            // 
            this.ThanhPhan.DataPropertyName = "ThanhPhan";
            this.ThanhPhan.HeaderText = "Thành Phần";
            this.ThanhPhan.Name = "ThanhPhan";
            // 
            // MaDonVi
            // 
            this.MaDonVi.DataPropertyName = "MaĐV";
            this.MaDonVi.HeaderText = "Mã Đơn Vị Tính";
            this.MaDonVi.Name = "MaDonVi";
            this.MaDonVi.Width = 90;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "ĐonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            // 
            // FrmBaoCaoThongTinThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBaoCaoThongTinThuoc";
            this.Text = "Báo cáo thông tin thuốc";
            this.Load += new System.EventHandler(this.FrmBaoCaoThongTinThuoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.ComboBox cboMaThuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCongDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCongDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}