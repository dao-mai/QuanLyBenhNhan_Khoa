namespace QuanLyBenhNhan
{
    partial class FrmTimKiemBenhAn
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
            this.label5 = new System.Windows.Forms.Label();
            this.cboNgayKham = new System.Windows.Forms.ComboBox();
            this.cboMaBS = new System.Windows.Forms.ComboBox();
            this.DataGridView_TimKiemBenhAn = new System.Windows.Forms.DataGridView();
            this.MaBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiDoKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienSuBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HuyetAp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhietDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttTimKiem = new System.Windows.Forms.Button();
            this.txtNhietDo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_TimKiemBenhAn)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(261, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 31);
            this.label5.TabIndex = 43;
            this.label5.Text = "TÌM KIẾM BỆNH ÁN";
            // 
            // cboNgayKham
            // 
            this.cboNgayKham.FormattingEnabled = true;
            this.cboNgayKham.Location = new System.Drawing.Point(301, 130);
            this.cboNgayKham.Name = "cboNgayKham";
            this.cboNgayKham.Size = new System.Drawing.Size(100, 21);
            this.cboNgayKham.TabIndex = 42;
            // 
            // cboMaBS
            // 
            this.cboMaBS.FormattingEnabled = true;
            this.cboMaBS.Location = new System.Drawing.Point(301, 90);
            this.cboMaBS.Name = "cboMaBS";
            this.cboMaBS.Size = new System.Drawing.Size(100, 21);
            this.cboMaBS.TabIndex = 41;
            // 
            // DataGridView_TimKiemBenhAn
            // 
            this.DataGridView_TimKiemBenhAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_TimKiemBenhAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBA,
            this.MaBN,
            this.MaBS,
            this.NgayKham,
            this.LiDoKham,
            this.TienSuBenh,
            this.HuyetAp,
            this.CanNang,
            this.NhietDo,
            this.TienKham});
            this.DataGridView_TimKiemBenhAn.Location = new System.Drawing.Point(12, 212);
            this.DataGridView_TimKiemBenhAn.Name = "DataGridView_TimKiemBenhAn";
            this.DataGridView_TimKiemBenhAn.Size = new System.Drawing.Size(764, 121);
            this.DataGridView_TimKiemBenhAn.TabIndex = 40;
            // 
            // MaBA
            // 
            this.MaBA.DataPropertyName = "MaBA";
            this.MaBA.HeaderText = "Mã bệnh án";
            this.MaBA.Name = "MaBA";
            // 
            // MaBN
            // 
            this.MaBN.DataPropertyName = "MaBN";
            this.MaBN.HeaderText = "Mã bệnh nhân";
            this.MaBN.Name = "MaBN";
            // 
            // MaBS
            // 
            this.MaBS.DataPropertyName = "MaBS";
            this.MaBS.HeaderText = "Mã bác sĩ";
            this.MaBS.Name = "MaBS";
            // 
            // NgayKham
            // 
            this.NgayKham.DataPropertyName = "NgayKham";
            this.NgayKham.HeaderText = "Ngày khám";
            this.NgayKham.Name = "NgayKham";
            // 
            // LiDoKham
            // 
            this.LiDoKham.DataPropertyName = "LiDoKham";
            this.LiDoKham.HeaderText = "Lí do khám";
            this.LiDoKham.Name = "LiDoKham";
            // 
            // TienSuBenh
            // 
            this.TienSuBenh.DataPropertyName = "TienSuBenh";
            this.TienSuBenh.HeaderText = "Tiền sử bệnh";
            this.TienSuBenh.Name = "TienSuBenh";
            // 
            // HuyetAp
            // 
            this.HuyetAp.DataPropertyName = "HuyetAp";
            this.HuyetAp.HeaderText = "Huyết áp";
            this.HuyetAp.Name = "HuyetAp";
            // 
            // CanNang
            // 
            this.CanNang.DataPropertyName = "CanNang";
            this.CanNang.HeaderText = "Cân nặng";
            this.CanNang.Name = "CanNang";
            // 
            // NhietDo
            // 
            this.NhietDo.DataPropertyName = "NhietDo";
            this.NhietDo.HeaderText = "Nhiệt độ";
            this.NhietDo.Name = "NhietDo";
            // 
            // TienKham
            // 
            this.TienKham.DataPropertyName = "TienKham";
            this.TienKham.HeaderText = "Tiền khám";
            this.TienKham.Name = "TienKham";
            // 
            // bttTimKiem
            // 
            this.bttTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttTimKiem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bttTimKiem.Location = new System.Drawing.Point(439, 113);
            this.bttTimKiem.Name = "bttTimKiem";
            this.bttTimKiem.Size = new System.Drawing.Size(122, 23);
            this.bttTimKiem.TabIndex = 39;
            this.bttTimKiem.Text = "Tìm kiếm";
            this.bttTimKiem.UseVisualStyleBackColor = true;
            this.bttTimKiem.Click += new System.EventHandler(this.bttTimKiem_Click);
            // 
            // txtNhietDo
            // 
            this.txtNhietDo.Location = new System.Drawing.Point(301, 165);
            this.txtNhietDo.Name = "txtNhietDo";
            this.txtNhietDo.Size = new System.Drawing.Size(100, 20);
            this.txtNhietDo.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nhiệt độ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Ngày khám";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Mã bác sĩ";
            // 
            // FrmTimKiemBenhAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboNgayKham);
            this.Controls.Add(this.cboMaBS);
            this.Controls.Add(this.DataGridView_TimKiemBenhAn);
            this.Controls.Add(this.bttTimKiem);
            this.Controls.Add(this.txtNhietDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "FrmTimKiemBenhAn";
            this.Text = "Tìm kiếm bệnh án";
            this.Load += new System.EventHandler(this.FrmTimKiemBenhAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_TimKiemBenhAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboNgayKham;
        private System.Windows.Forms.ComboBox cboMaBS;
        private System.Windows.Forms.DataGridView DataGridView_TimKiemBenhAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiDoKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienSuBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HuyetAp;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhietDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienKham;
        private System.Windows.Forms.Button bttTimKiem;
        private System.Windows.Forms.TextBox txtNhietDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}