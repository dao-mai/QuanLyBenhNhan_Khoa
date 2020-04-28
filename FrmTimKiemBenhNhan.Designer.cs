namespace QuanLyBenhNhan
{
    partial class FrmTimKiemBenhNhan
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaB = new System.Windows.Forms.TextBox();
            this.txtLiDoKham = new System.Windows.Forms.TextBox();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.DataGridView_BN = new System.Windows.Forms.DataGridView();
            this.MaB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiDoKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BN)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(231, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 31);
            this.label4.TabIndex = 35;
            this.label4.Text = "TÌM KIẾM BỆNH NHÂN";
            // 
            // txtMaB
            // 
            this.txtMaB.Location = new System.Drawing.Point(311, 157);
            this.txtMaB.Name = "txtMaB";
            this.txtMaB.Size = new System.Drawing.Size(100, 20);
            this.txtMaB.TabIndex = 33;
            // 
            // txtLiDoKham
            // 
            this.txtLiDoKham.Location = new System.Drawing.Point(311, 127);
            this.txtLiDoKham.Name = "txtLiDoKham";
            this.txtLiDoKham.Size = new System.Drawing.Size(100, 20);
            this.txtLiDoKham.TabIndex = 32;
            // 
            // txtTenBN
            // 
            this.txtTenBN.Location = new System.Drawing.Point(311, 97);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(100, 20);
            this.txtTenBN.TabIndex = 31;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTimKiem.Location = new System.Drawing.Point(456, 109);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(103, 23);
            this.btnTimKiem.TabIndex = 30;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // DataGridView_BN
            // 
            this.DataGridView_BN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_BN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaB,
            this.MaBA,
            this.MaBN,
            this.TenBN,
            this.LiDoKham,
            this.GT,
            this.NS});
            this.DataGridView_BN.Location = new System.Drawing.Point(28, 207);
            this.DataGridView_BN.Name = "DataGridView_BN";
            this.DataGridView_BN.Size = new System.Drawing.Size(743, 137);
            this.DataGridView_BN.TabIndex = 29;
            // 
            // MaB
            // 
            this.MaB.DataPropertyName = "MaB";
            this.MaB.HeaderText = "Mã bệnh";
            this.MaB.Name = "MaB";
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
            // TenBN
            // 
            this.TenBN.DataPropertyName = "TenBN";
            this.TenBN.HeaderText = "Tên bệnh nhân";
            this.TenBN.Name = "TenBN";
            // 
            // LiDoKham
            // 
            this.LiDoKham.DataPropertyName = "LiDoKham";
            this.LiDoKham.HeaderText = "Lí do khám";
            this.LiDoKham.Name = "LiDoKham";
            // 
            // GT
            // 
            this.GT.DataPropertyName = "GT";
            this.GT.HeaderText = "Giới tính";
            this.GT.Name = "GT";
            // 
            // NS
            // 
            this.NS.DataPropertyName = "NS";
            this.NS.HeaderText = "Ngày sinh";
            this.NS.Name = "NS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mã bệnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Lý do khám";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tên bệnh nhân";
            // 
            // FrmTimKiemBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaB);
            this.Controls.Add(this.txtLiDoKham);
            this.Controls.Add(this.txtTenBN);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.DataGridView_BN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTimKiemBenhNhan";
            this.Text = "Tìm kiếm bệnh nhân";
            this.Load += new System.EventHandler(this.FrmTimKiemBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaB;
        private System.Windows.Forms.TextBox txtLiDoKham;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView DataGridView_BN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiDoKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}