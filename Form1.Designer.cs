namespace QuanLyBenhNhan
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMBacSi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSHSBA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongTinBA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTKBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTKBenhAn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCThongTinBenhAn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCDanhSachBenhAn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCThongTinThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMuc,
            this.mnuTraCuu,
            this.mnuTimKiem,
            this.mnuBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(576, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDMBenhNhan,
            this.mnuDMBacSi,
            this.mnuDMThuoc});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuDMBenhNhan
            // 
            this.mnuDMBenhNhan.Name = "mnuDMBenhNhan";
            this.mnuDMBenhNhan.Size = new System.Drawing.Size(180, 22);
            this.mnuDMBenhNhan.Text = "Bệnh nhân";
            this.mnuDMBenhNhan.Click += new System.EventHandler(this.mnuDMBenhNhan_Click);
            // 
            // mnuDMBacSi
            // 
            this.mnuDMBacSi.Name = "mnuDMBacSi";
            this.mnuDMBacSi.Size = new System.Drawing.Size(180, 22);
            this.mnuDMBacSi.Text = "Bác sĩ";
            this.mnuDMBacSi.Click += new System.EventHandler(this.mnuDMBacSi_Click);
            // 
            // mnuDMThuoc
            // 
            this.mnuDMThuoc.Name = "mnuDMThuoc";
            this.mnuDMThuoc.Size = new System.Drawing.Size(180, 22);
            this.mnuDMThuoc.Text = "Thuốc";
            this.mnuDMThuoc.Click += new System.EventHandler(this.mnuDMThuoc_Click);
            // 
            // mnuTraCuu
            // 
            this.mnuTraCuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDSHSBA,
            this.mnuThongTinBA});
            this.mnuTraCuu.Name = "mnuTraCuu";
            this.mnuTraCuu.Size = new System.Drawing.Size(59, 20);
            this.mnuTraCuu.Text = "Tra Cứu";
            // 
            // mnuDSHSBA
            // 
            this.mnuDSHSBA.Name = "mnuDSHSBA";
            this.mnuDSHSBA.Size = new System.Drawing.Size(207, 22);
            this.mnuDSHSBA.Text = "Danh sách hồ sơ bệnh án";
            this.mnuDSHSBA.Click += new System.EventHandler(this.mnuDSHSBA_Click);
            // 
            // mnuThongTinBA
            // 
            this.mnuThongTinBA.Name = "mnuThongTinBA";
            this.mnuThongTinBA.Size = new System.Drawing.Size(207, 22);
            this.mnuThongTinBA.Text = "Thông tin các bệnh án";
            this.mnuThongTinBA.Click += new System.EventHandler(this.mnuThongTinBA_Click);
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTKBenhNhan,
            this.mnuTKBenhAn});
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(68, 20);
            this.mnuTimKiem.Text = "Tìm kiếm";
            // 
            // mnuTKBenhNhan
            // 
            this.mnuTKBenhNhan.Name = "mnuTKBenhNhan";
            this.mnuTKBenhNhan.Size = new System.Drawing.Size(131, 22);
            this.mnuTKBenhNhan.Text = "Bệnh nhân";
            this.mnuTKBenhNhan.Click += new System.EventHandler(this.mnuTKBenhNhan_Click);
            // 
            // mnuTKBenhAn
            // 
            this.mnuTKBenhAn.Name = "mnuTKBenhAn";
            this.mnuTKBenhAn.Size = new System.Drawing.Size(131, 22);
            this.mnuTKBenhAn.Text = "Bệnh án";
            this.mnuTKBenhAn.Click += new System.EventHandler(this.mnuTKBenhAn_Click);
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBCThongTinBenhAn,
            this.mnuBCDanhSachBenhAn,
            this.mnuBCThongTinThuoc});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(61, 20);
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuBCThongTinBenhAn
            // 
            this.mnuBCThongTinBenhAn.Name = "mnuBCThongTinBenhAn";
            this.mnuBCThongTinBenhAn.Size = new System.Drawing.Size(175, 22);
            this.mnuBCThongTinBenhAn.Text = "Thông tin bệnh án";
            this.mnuBCThongTinBenhAn.Click += new System.EventHandler(this.mnuBCThongTinBenhAn_Click);
            // 
            // mnuBCDanhSachBenhAn
            // 
            this.mnuBCDanhSachBenhAn.Name = "mnuBCDanhSachBenhAn";
            this.mnuBCDanhSachBenhAn.Size = new System.Drawing.Size(175, 22);
            this.mnuBCDanhSachBenhAn.Text = "Danh sách bệnh án";
            this.mnuBCDanhSachBenhAn.Click += new System.EventHandler(this.mnuBCDanhSachBenhAn_Click);
            // 
            // mnuBCThongTinThuoc
            // 
            this.mnuBCThongTinThuoc.Name = "mnuBCThongTinThuoc";
            this.mnuBCThongTinThuoc.Size = new System.Drawing.Size(175, 22);
            this.mnuBCThongTinThuoc.Text = "Thông tin thuốc";
            this.mnuBCThongTinThuoc.Click += new System.EventHandler(this.mnuBCThongTinThuoc_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBenhNhan.Properties.Resources.bacsi;
            this.ClientSize = new System.Drawing.Size(576, 445);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Quản lý bệnh nhân";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuDMBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem mnuDMBacSi;
        private System.Windows.Forms.ToolStripMenuItem mnuDMThuoc;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuTKBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem mnuTKBenhAn;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuBCThongTinBenhAn;
        private System.Windows.Forms.ToolStripMenuItem mnuBCDanhSachBenhAn;
        private System.Windows.Forms.ToolStripMenuItem mnuBCThongTinThuoc;
        private System.Windows.Forms.ToolStripMenuItem mnuTraCuu;
        private System.Windows.Forms.ToolStripMenuItem mnuDSHSBA;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTinBA;
    }
}

