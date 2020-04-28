namespace QuanLyBenhNhan
{
    partial class FrmDMBacSi
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
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewBacSi = new System.Windows.Forms.DataGridView();
            this.MaBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTĐ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SĐT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.mskNgSinhBS = new System.Windows.Forms.MaskedTextBox();
            this.cboTrinhDo = new System.Windows.Forms.ComboBox();
            this.cboChuyenMon = new System.Windows.Forms.ComboBox();
            this.cboQueQuan = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ckbGioiTinh = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenBacSi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaBacSi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBacSi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(10, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Dữ liệu danh sách bác sĩ";
            // 
            // dataGridViewBacSi
            // 
            this.dataGridViewBacSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBacSi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBS,
            this.TenBS,
            this.NS,
            this.GT,
            this.MaQ,
            this.MaCM,
            this.MaTĐ,
            this.SĐT});
            this.dataGridViewBacSi.Location = new System.Drawing.Point(28, 275);
            this.dataGridViewBacSi.Name = "dataGridViewBacSi";
            this.dataGridViewBacSi.RowHeadersWidth = 51;
            this.dataGridViewBacSi.RowTemplate.Height = 24;
            this.dataGridViewBacSi.Size = new System.Drawing.Size(760, 129);
            this.dataGridViewBacSi.TabIndex = 40;
            this.dataGridViewBacSi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBacSi_CellClick);
            // 
            // MaBS
            // 
            this.MaBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaBS.DataPropertyName = "MaBS";
            this.MaBS.HeaderText = "Mã bác sĩ";
            this.MaBS.MinimumWidth = 6;
            this.MaBS.Name = "MaBS";
            // 
            // TenBS
            // 
            this.TenBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenBS.DataPropertyName = "TenBS";
            this.TenBS.HeaderText = "Tên bác sĩ";
            this.TenBS.MinimumWidth = 6;
            this.TenBS.Name = "TenBS";
            // 
            // NS
            // 
            this.NS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NS.DataPropertyName = "NS";
            this.NS.HeaderText = "Ngày sinh";
            this.NS.MinimumWidth = 6;
            this.NS.Name = "NS";
            // 
            // GT
            // 
            this.GT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GT.DataPropertyName = "GT";
            this.GT.HeaderText = "Giới tính";
            this.GT.MinimumWidth = 6;
            this.GT.Name = "GT";
            // 
            // MaQ
            // 
            this.MaQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaQ.DataPropertyName = "MaQ";
            this.MaQ.HeaderText = "Mã quê";
            this.MaQ.MinimumWidth = 6;
            this.MaQ.Name = "MaQ";
            // 
            // MaCM
            // 
            this.MaCM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCM.DataPropertyName = "MaCM";
            this.MaCM.HeaderText = "Mã chuyên môn";
            this.MaCM.MinimumWidth = 6;
            this.MaCM.Name = "MaCM";
            // 
            // MaTĐ
            // 
            this.MaTĐ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaTĐ.DataPropertyName = "MaTĐ";
            this.MaTĐ.HeaderText = "Mã trình độ";
            this.MaTĐ.MinimumWidth = 6;
            this.MaTĐ.Name = "MaTĐ";
            // 
            // SĐT
            // 
            this.SĐT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SĐT.DataPropertyName = "SĐT";
            this.SĐT.HeaderText = "Số điện thoại";
            this.SĐT.MinimumWidth = 6;
            this.SĐT.Name = "SĐT";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.mskNgSinhBS);
            this.groupBox1.Controls.Add(this.cboTrinhDo);
            this.groupBox1.Controls.Add(this.cboChuyenMon);
            this.groupBox1.Controls.Add(this.cboQueQuan);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ckbGioiTinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenBacSi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaBacSi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(760, 185);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Cá Nhân";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(615, 155);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(121, 23);
            this.txtSDT.TabIndex = 17;
            // 
            // mskNgSinhBS
            // 
            this.mskNgSinhBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNgSinhBS.Location = new System.Drawing.Point(165, 114);
            this.mskNgSinhBS.Margin = new System.Windows.Forms.Padding(4);
            this.mskNgSinhBS.Mask = "00/00/0000";
            this.mskNgSinhBS.Name = "mskNgSinhBS";
            this.mskNgSinhBS.Size = new System.Drawing.Size(100, 23);
            this.mskNgSinhBS.TabIndex = 16;
            this.mskNgSinhBS.ValidatingType = typeof(System.DateTime);
            // 
            // cboTrinhDo
            // 
            this.cboTrinhDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrinhDo.FormattingEnabled = true;
            this.cboTrinhDo.Location = new System.Drawing.Point(615, 116);
            this.cboTrinhDo.Margin = new System.Windows.Forms.Padding(4);
            this.cboTrinhDo.Name = "cboTrinhDo";
            this.cboTrinhDo.Size = new System.Drawing.Size(121, 25);
            this.cboTrinhDo.TabIndex = 14;
            // 
            // cboChuyenMon
            // 
            this.cboChuyenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChuyenMon.FormattingEnabled = true;
            this.cboChuyenMon.Location = new System.Drawing.Point(615, 83);
            this.cboChuyenMon.Margin = new System.Windows.Forms.Padding(4);
            this.cboChuyenMon.Name = "cboChuyenMon";
            this.cboChuyenMon.Size = new System.Drawing.Size(121, 25);
            this.cboChuyenMon.TabIndex = 13;
            // 
            // cboQueQuan
            // 
            this.cboQueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQueQuan.FormattingEnabled = true;
            this.cboQueQuan.Location = new System.Drawing.Point(615, 39);
            this.cboQueQuan.Margin = new System.Windows.Forms.Padding(4);
            this.cboQueQuan.Name = "cboQueQuan";
            this.cboQueQuan.Size = new System.Drawing.Size(121, 25);
            this.cboQueQuan.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(431, 155);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(431, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Trình độ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(431, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Chuyên môn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(431, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quê quán";
            // 
            // ckbGioiTinh
            // 
            this.ckbGioiTinh.AutoSize = true;
            this.ckbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGioiTinh.Location = new System.Drawing.Point(165, 155);
            this.ckbGioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.ckbGioiTinh.Name = "ckbGioiTinh";
            this.ckbGioiTinh.Size = new System.Drawing.Size(56, 21);
            this.ckbGioiTinh.TabIndex = 7;
            this.ckbGioiTinh.Text = "Nam";
            this.ckbGioiTinh.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh";
            // 
            // txtTenBacSi
            // 
            this.txtTenBacSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBacSi.Location = new System.Drawing.Point(165, 83);
            this.txtTenBacSi.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenBacSi.Name = "txtTenBacSi";
            this.txtTenBacSi.Size = new System.Drawing.Size(100, 23);
            this.txtTenBacSi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên bác sĩ";
            // 
            // txtMaBacSi
            // 
            this.txtMaBacSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBacSi.Location = new System.Drawing.Point(165, 42);
            this.txtMaBacSi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaBacSi.Name = "txtMaBacSi";
            this.txtMaBacSi.Size = new System.Drawing.Size(100, 23);
            this.txtMaBacSi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã bác sĩ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 26);
            this.label1.TabIndex = 38;
            this.label1.Text = "Danh Sách Bác Sĩ";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThoat.Location = new System.Drawing.Point(708, 410);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(77, 31);
            this.btnThoat.TabIndex = 60;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBoQua.Location = new System.Drawing.Point(568, 410);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(77, 31);
            this.btnBoQua.TabIndex = 59;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(420, 410);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(77, 31);
            this.btnLuu.TabIndex = 58;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSua.Location = new System.Drawing.Point(272, 410);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 31);
            this.btnSua.TabIndex = 57;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(145, 410);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(77, 31);
            this.btnXoa.TabIndex = 56;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThem.Location = new System.Drawing.Point(14, 410);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 31);
            this.btnThem.TabIndex = 55;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmDMBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridViewBacSi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmDMBacSi";
            this.Text = "Danh mục bác sĩ";
            this.Load += new System.EventHandler(this.FrmDMBacSi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBacSi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewBacSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NS;
        private System.Windows.Forms.DataGridViewTextBoxColumn GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTĐ;
        private System.Windows.Forms.DataGridViewTextBoxColumn SĐT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.MaskedTextBox mskNgSinhBS;
        private System.Windows.Forms.ComboBox cboTrinhDo;
        private System.Windows.Forms.ComboBox cboChuyenMon;
        private System.Windows.Forms.ComboBox cboQueQuan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckbGioiTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenBacSi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaBacSi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}