namespace QuanLyBenhNhan
{
    partial class FrmBaoCaoDSBenhAn
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
            this.bntInBaoCao = new System.Windows.Forms.Button();
            this.dataGridViewBenhAnTheoBS = new System.Windows.Forms.DataGridView();
            this.MaBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntTimKiem = new System.Windows.Forms.Button();
            this.cboMaBacSi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBenhAnTheoBS)).BeginInit();
            this.SuspendLayout();
            // 
            // bntInBaoCao
            // 
            this.bntInBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntInBaoCao.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bntInBaoCao.Location = new System.Drawing.Point(466, 184);
            this.bntInBaoCao.Name = "bntInBaoCao";
            this.bntInBaoCao.Size = new System.Drawing.Size(111, 24);
            this.bntInBaoCao.TabIndex = 18;
            this.bntInBaoCao.Text = "In báo cáo";
            this.bntInBaoCao.UseVisualStyleBackColor = true;
            this.bntInBaoCao.Click += new System.EventHandler(this.bntInBaoCao_Click);
            // 
            // dataGridViewBenhAnTheoBS
            // 
            this.dataGridViewBenhAnTheoBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBenhAnTheoBS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBA,
            this.MaBN,
            this.MaBS,
            this.TenBS});
            this.dataGridViewBenhAnTheoBS.Location = new System.Drawing.Point(174, 262);
            this.dataGridViewBenhAnTheoBS.Name = "dataGridViewBenhAnTheoBS";
            this.dataGridViewBenhAnTheoBS.RowHeadersWidth = 51;
            this.dataGridViewBenhAnTheoBS.RowTemplate.Height = 24;
            this.dataGridViewBenhAnTheoBS.Size = new System.Drawing.Size(450, 146);
            this.dataGridViewBenhAnTheoBS.TabIndex = 17;
            // 
            // MaBA
            // 
            this.MaBA.DataPropertyName = "MaBA";
            this.MaBA.HeaderText = "Mã Bệnh Án";
            this.MaBA.Name = "MaBA";
            // 
            // MaBN
            // 
            this.MaBN.DataPropertyName = "MaBN";
            this.MaBN.HeaderText = "Mã Bệnh Nhân";
            this.MaBN.Name = "MaBN";
            // 
            // MaBS
            // 
            this.MaBS.DataPropertyName = "MaBS";
            this.MaBS.HeaderText = "Mã Bác Sĩ";
            this.MaBS.Name = "MaBS";
            // 
            // TenBS
            // 
            this.TenBS.DataPropertyName = "TenBS";
            this.TenBS.HeaderText = "Tên bác sĩ";
            this.TenBS.Name = "TenBS";
            // 
            // bntTimKiem
            // 
            this.bntTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTimKiem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bntTimKiem.Location = new System.Drawing.Point(466, 140);
            this.bntTimKiem.Name = "bntTimKiem";
            this.bntTimKiem.Size = new System.Drawing.Size(111, 24);
            this.bntTimKiem.TabIndex = 16;
            this.bntTimKiem.Text = "Tìm kiếm";
            this.bntTimKiem.UseVisualStyleBackColor = true;
            this.bntTimKiem.Click += new System.EventHandler(this.bntTimKiem_Click);
            // 
            // cboMaBacSi
            // 
            this.cboMaBacSi.FormattingEnabled = true;
            this.cboMaBacSi.Location = new System.Drawing.Point(300, 143);
            this.cboMaBacSi.Name = "cboMaBacSi";
            this.cboMaBacSi.Size = new System.Drawing.Size(111, 21);
            this.cboMaBacSi.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã bác sĩ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(137, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "BÁO CÁO DANH SÁCH BỆNH ÁN";
            // 
            // FrmBaoCaoDSBenhAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntInBaoCao);
            this.Controls.Add(this.dataGridViewBenhAnTheoBS);
            this.Controls.Add(this.bntTimKiem);
            this.Controls.Add(this.cboMaBacSi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmBaoCaoDSBenhAn";
            this.Text = "Báo cáo danh sách bệnh án theo bác sĩ";
            this.Load += new System.EventHandler(this.FrmBaoCaoThongTinBenhAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBenhAnTheoBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bntInBaoCao;
        private System.Windows.Forms.DataGridView dataGridViewBenhAnTheoBS;
        private System.Windows.Forms.Button bntTimKiem;
        private System.Windows.Forms.ComboBox cboMaBacSi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBS;
    }
}