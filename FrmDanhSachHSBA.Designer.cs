namespace QuanLyBenhNhan
{
    partial class FrmDanhSachHSBA
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaBenhNhan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bntTimKIem = new System.Windows.Forms.Button();
            this.dataGridViewTraCuu = new System.Windows.Forms.DataGridView();
            this.MaBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(152, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Danh sách bệnh án của bệnh nhân";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.cboMaBenhNhan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bntTimKIem);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(155, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 78);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu";
            // 
            // cboMaBenhNhan
            // 
            this.cboMaBenhNhan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaBenhNhan.FormattingEnabled = true;
            this.cboMaBenhNhan.Location = new System.Drawing.Point(136, 29);
            this.cboMaBenhNhan.Name = "cboMaBenhNhan";
            this.cboMaBenhNhan.Size = new System.Drawing.Size(121, 24);
            this.cboMaBenhNhan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã bệnh nhân";
            // 
            // bntTimKIem
            // 
            this.bntTimKIem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTimKIem.Location = new System.Drawing.Point(282, 25);
            this.bntTimKIem.Name = "bntTimKIem";
            this.bntTimKIem.Size = new System.Drawing.Size(99, 28);
            this.bntTimKIem.TabIndex = 3;
            this.bntTimKIem.Text = "Tìm Kiếm";
            this.bntTimKIem.UseVisualStyleBackColor = true;
            this.bntTimKIem.Click += new System.EventHandler(this.bntTimKIem_Click);
            // 
            // dataGridViewTraCuu
            // 
            this.dataGridViewTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTraCuu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBA,
            this.MaBN,
            this.TenBN});
            this.dataGridViewTraCuu.Location = new System.Drawing.Point(155, 243);
            this.dataGridViewTraCuu.Name = "dataGridViewTraCuu";
            this.dataGridViewTraCuu.RowHeadersWidth = 51;
            this.dataGridViewTraCuu.RowTemplate.Height = 24;
            this.dataGridViewTraCuu.Size = new System.Drawing.Size(500, 128);
            this.dataGridViewTraCuu.TabIndex = 39;
            // 
            // MaBA
            // 
            this.MaBA.DataPropertyName = "MaBA";
            this.MaBA.HeaderText = "Mã Bệnh Án";
            this.MaBA.MinimumWidth = 6;
            this.MaBA.Name = "MaBA";
            // 
            // MaBN
            // 
            this.MaBN.DataPropertyName = "MaBN";
            this.MaBN.HeaderText = "Mã Bệnh Nhân";
            this.MaBN.MinimumWidth = 6;
            this.MaBN.Name = "MaBN";
            // 
            // TenBN
            // 
            this.TenBN.DataPropertyName = "TenBN";
            this.TenBN.HeaderText = "Tên Bệnh Nhân";
            this.TenBN.MinimumWidth = 6;
            this.TenBN.Name = "TenBN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(178, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 36);
            this.label1.TabIndex = 37;
            this.label1.Text = "DANH SÁCH HỒ SƠ BỆNH ÁN";
            // 
            // FrmDanhSachHSBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewTraCuu);
            this.Controls.Add(this.label1);
            this.Name = "FrmDanhSachHSBA";
            this.Text = "Danh sách hồ sơ bệnh án theo bệnh nhân";
            this.Load += new System.EventHandler(this.FrmDanhSachHSBA_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraCuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMaBenhNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntTimKIem;
        private System.Windows.Forms.DataGridView dataGridViewTraCuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBN;
    }
}