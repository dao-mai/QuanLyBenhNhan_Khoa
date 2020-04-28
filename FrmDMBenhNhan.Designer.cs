namespace QuanLyBenhNhan
{
    partial class FrmDMBenhNhan
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
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntBoQua = new System.Windows.Forms.Button();
            this.bntLuu = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.dataGridViewDanhSachBenhNhan = new System.Windows.Forms.DataGridView();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaĐT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThongTinCoBan = new System.Windows.Forms.GroupBox();
            this.cboDoiTuong = new System.Windows.Forms.ComboBox();
            this.cboDanToc = new System.Windows.Forms.ComboBox();
            this.cboQueQuan = new System.Windows.Forms.ComboBox();
            this.cboNgheNghiep = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ckbNam = new System.Windows.Forms.CheckBox();
            this.mskNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachBenhNhan)).BeginInit();
            this.gbThongTinCoBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(12, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 17);
            this.label10.TabIndex = 48;
            this.label10.Text = "Dữ liệu danh sách bệnh nhân";
            // 
            // bntThoat
            // 
            this.bntThoat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntThoat.Location = new System.Drawing.Point(769, 611);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(77, 42);
            this.bntThoat.TabIndex = 47;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = false;
            // 
            // bntBoQua
            // 
            this.bntBoQua.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntBoQua.Location = new System.Drawing.Point(619, 611);
            this.bntBoQua.Name = "bntBoQua";
            this.bntBoQua.Size = new System.Drawing.Size(77, 42);
            this.bntBoQua.TabIndex = 46;
            this.bntBoQua.Text = "Bỏ Qua";
            this.bntBoQua.UseVisualStyleBackColor = false;
            // 
            // bntLuu
            // 
            this.bntLuu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntLuu.Location = new System.Drawing.Point(457, 611);
            this.bntLuu.Name = "bntLuu";
            this.bntLuu.Size = new System.Drawing.Size(77, 42);
            this.bntLuu.TabIndex = 45;
            this.bntLuu.Text = "Lưu";
            this.bntLuu.UseVisualStyleBackColor = false;
            // 
            // bntSua
            // 
            this.bntSua.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntSua.Location = new System.Drawing.Point(311, 611);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(77, 42);
            this.bntSua.TabIndex = 44;
            this.bntSua.Text = "Sửa";
            this.bntSua.UseVisualStyleBackColor = false;
            // 
            // bntXoa
            // 
            this.bntXoa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntXoa.Location = new System.Drawing.Point(159, 611);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(77, 42);
            this.bntXoa.TabIndex = 43;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = false;
            // 
            // bntThem
            // 
            this.bntThem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntThem.Location = new System.Drawing.Point(12, 611);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(77, 42);
            this.bntThem.TabIndex = 42;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = false;
            // 
            // dataGridViewDanhSachBenhNhan
            // 
            this.dataGridViewDanhSachBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachBenhNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBN,
            this.TenBN,
            this.GT,
            this.NS,
            this.MaQ,
            this.MaDT,
            this.MaĐT,
            this.MaNN});
            this.dataGridViewDanhSachBenhNhan.Location = new System.Drawing.Point(12, 284);
            this.dataGridViewDanhSachBenhNhan.Name = "dataGridViewDanhSachBenhNhan";
            this.dataGridViewDanhSachBenhNhan.RowHeadersWidth = 51;
            this.dataGridViewDanhSachBenhNhan.RowTemplate.Height = 24;
            this.dataGridViewDanhSachBenhNhan.Size = new System.Drawing.Size(776, 164);
            this.dataGridViewDanhSachBenhNhan.TabIndex = 41;
            this.dataGridViewDanhSachBenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachBenhNhan_CellClick);
            // 
            // MaBN
            // 
            this.MaBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaBN.DataPropertyName = "MaBN";
            this.MaBN.HeaderText = "Mã bệnh nhân";
            this.MaBN.MinimumWidth = 6;
            this.MaBN.Name = "MaBN";
            // 
            // TenBN
            // 
            this.TenBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenBN.DataPropertyName = "TenBN";
            this.TenBN.HeaderText = "Tên bệnh nhân";
            this.TenBN.MinimumWidth = 6;
            this.TenBN.Name = "TenBN";
            // 
            // GT
            // 
            this.GT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GT.DataPropertyName = "GT";
            this.GT.HeaderText = "Giới tính";
            this.GT.MinimumWidth = 6;
            this.GT.Name = "GT";
            // 
            // NS
            // 
            this.NS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NS.DataPropertyName = "NS";
            this.NS.HeaderText = "Năm sinh";
            this.NS.MinimumWidth = 6;
            this.NS.Name = "NS";
            // 
            // MaQ
            // 
            this.MaQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaQ.DataPropertyName = "MaQ";
            this.MaQ.HeaderText = "Quê Quán";
            this.MaQ.MinimumWidth = 6;
            this.MaQ.Name = "MaQ";
            // 
            // MaDT
            // 
            this.MaDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaDT.DataPropertyName = "MaDT";
            this.MaDT.HeaderText = "Dân Tộc";
            this.MaDT.MinimumWidth = 6;
            this.MaDT.Name = "MaDT";
            // 
            // MaĐT
            // 
            this.MaĐT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaĐT.DataPropertyName = "MaĐT";
            this.MaĐT.HeaderText = "Đối Tượng";
            this.MaĐT.MinimumWidth = 6;
            this.MaĐT.Name = "MaĐT";
            // 
            // MaNN
            // 
            this.MaNN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNN.DataPropertyName = "MaNN";
            this.MaNN.HeaderText = "Nghề nghiệp";
            this.MaNN.MinimumWidth = 6;
            this.MaNN.Name = "MaNN";
            // 
            // gbThongTinCoBan
            // 
            this.gbThongTinCoBan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbThongTinCoBan.Controls.Add(this.cboDoiTuong);
            this.gbThongTinCoBan.Controls.Add(this.cboDanToc);
            this.gbThongTinCoBan.Controls.Add(this.cboQueQuan);
            this.gbThongTinCoBan.Controls.Add(this.cboNgheNghiep);
            this.gbThongTinCoBan.Controls.Add(this.label11);
            this.gbThongTinCoBan.Controls.Add(this.label12);
            this.gbThongTinCoBan.Controls.Add(this.label13);
            this.gbThongTinCoBan.Controls.Add(this.label14);
            this.gbThongTinCoBan.Controls.Add(this.ckbNam);
            this.gbThongTinCoBan.Controls.Add(this.mskNgaySinh);
            this.gbThongTinCoBan.Controls.Add(this.label5);
            this.gbThongTinCoBan.Controls.Add(this.label4);
            this.gbThongTinCoBan.Controls.Add(this.txtTenBenhNhan);
            this.gbThongTinCoBan.Controls.Add(this.label3);
            this.gbThongTinCoBan.Controls.Add(this.txtMaBenhNhan);
            this.gbThongTinCoBan.Controls.Add(this.label2);
            this.gbThongTinCoBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinCoBan.Location = new System.Drawing.Point(12, 68);
            this.gbThongTinCoBan.Name = "gbThongTinCoBan";
            this.gbThongTinCoBan.Size = new System.Drawing.Size(776, 178);
            this.gbThongTinCoBan.TabIndex = 40;
            this.gbThongTinCoBan.TabStop = false;
            this.gbThongTinCoBan.Text = "Thông tin cá nhân";
            // 
            // cboDoiTuong
            // 
            this.cboDoiTuong.FormattingEnabled = true;
            this.cboDoiTuong.Location = new System.Drawing.Point(568, 151);
            this.cboDoiTuong.Name = "cboDoiTuong";
            this.cboDoiTuong.Size = new System.Drawing.Size(121, 27);
            this.cboDoiTuong.TabIndex = 20;
            // 
            // cboDanToc
            // 
            this.cboDanToc.FormattingEnabled = true;
            this.cboDanToc.Location = new System.Drawing.Point(568, 113);
            this.cboDanToc.Name = "cboDanToc";
            this.cboDanToc.Size = new System.Drawing.Size(121, 27);
            this.cboDanToc.TabIndex = 19;
            // 
            // cboQueQuan
            // 
            this.cboQueQuan.FormattingEnabled = true;
            this.cboQueQuan.Location = new System.Drawing.Point(568, 75);
            this.cboQueQuan.Name = "cboQueQuan";
            this.cboQueQuan.Size = new System.Drawing.Size(121, 27);
            this.cboQueQuan.TabIndex = 18;
            // 
            // cboNgheNghiep
            // 
            this.cboNgheNghiep.FormattingEnabled = true;
            this.cboNgheNghiep.Location = new System.Drawing.Point(568, 36);
            this.cboNgheNghiep.Name = "cboNgheNghiep";
            this.cboNgheNghiep.Size = new System.Drawing.Size(121, 27);
            this.cboNgheNghiep.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(424, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Đối tượng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(424, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Dân Tộc";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(424, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Quê Quán";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(424, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Nghề Nghiệp";
            // 
            // ckbNam
            // 
            this.ckbNam.AutoSize = true;
            this.ckbNam.Location = new System.Drawing.Point(147, 155);
            this.ckbNam.Name = "ckbNam";
            this.ckbNam.Size = new System.Drawing.Size(58, 23);
            this.ckbNam.TabIndex = 12;
            this.ckbNam.Text = "Nam";
            this.ckbNam.UseVisualStyleBackColor = true;
            // 
            // mskNgaySinh
            // 
            this.mskNgaySinh.Location = new System.Drawing.Point(147, 113);
            this.mskNgaySinh.Mask = "00/00/0000";
            this.mskNgaySinh.Name = "mskNgaySinh";
            this.mskNgaySinh.Size = new System.Drawing.Size(100, 26);
            this.mskNgaySinh.TabIndex = 11;
            this.mskNgaySinh.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày sinh";
            // 
            // txtTenBenhNhan
            // 
            this.txtTenBenhNhan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBenhNhan.Location = new System.Drawing.Point(147, 75);
            this.txtTenBenhNhan.Name = "txtTenBenhNhan";
            this.txtTenBenhNhan.Size = new System.Drawing.Size(100, 23);
            this.txtTenBenhNhan.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên bệnh nhân";
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBenhNhan.Location = new System.Drawing.Point(147, 38);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.Size = new System.Drawing.Size(100, 23);
            this.txtMaBenhNhan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã bệnh nhân";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "Danh Sách Bệnh Nhân";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThoat.Location = new System.Drawing.Point(706, 463);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(77, 31);
            this.btnThoat.TabIndex = 54;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBoQua.Location = new System.Drawing.Point(566, 463);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(77, 31);
            this.btnBoQua.TabIndex = 53;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(418, 463);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(77, 31);
            this.btnLuu.TabIndex = 52;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSua.Location = new System.Drawing.Point(270, 463);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 31);
            this.btnSua.TabIndex = 51;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(143, 463);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(77, 31);
            this.btnXoa.TabIndex = 50;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThem.Location = new System.Drawing.Point(12, 463);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 31);
            this.btnThem.TabIndex = 49;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmDMBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.bntBoQua);
            this.Controls.Add(this.bntLuu);
            this.Controls.Add(this.bntSua);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.dataGridViewDanhSachBenhNhan);
            this.Controls.Add(this.gbThongTinCoBan);
            this.Controls.Add(this.label1);
            this.Name = "FrmDMBenhNhan";
            this.Text = "Danh mục bệnh nhân";
            this.Load += new System.EventHandler(this.FrmDMBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachBenhNhan)).EndInit();
            this.gbThongTinCoBan.ResumeLayout(false);
            this.gbThongTinCoBan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button bntBoQua;
        private System.Windows.Forms.Button bntLuu;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.DataGridView dataGridViewDanhSachBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaĐT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNN;
        private System.Windows.Forms.GroupBox gbThongTinCoBan;
        private System.Windows.Forms.ComboBox cboDoiTuong;
        private System.Windows.Forms.ComboBox cboDanToc;
        private System.Windows.Forms.ComboBox cboQueQuan;
        private System.Windows.Forms.ComboBox cboNgheNghiep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox ckbNam;
        private System.Windows.Forms.MaskedTextBox mskNgaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenBenhNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaBenhNhan;
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