using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyBenhNhan.Class;

namespace QuanLyBenhNhan
{
    public partial class FrmBaoCaoThongTinThuoc : Form
    {
        public FrmBaoCaoThongTinThuoc()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoThongTinThuoc_Load(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT MaT, TenT FROM Thuoc", cboMaThuoc, "MaT", "TenT");
            cboMaThuoc.SelectedIndex = -1;
        }

        private void LoadDataGridView()
        {
            DataTable Thuoc;
            string sql;
            sql = "select a.MaT, b.TenCD, c.TenĐV, a.TenT,b.MaCD,a.ThanhPhan, c.MaĐV, a.ĐonGia" +
                " from Thuoc AS a, CongDung AS b, ĐonViTinh AS c WHERE MaT = N'"
                + cboMaThuoc.SelectedValue + "'AND b.MaCD = a.MaCD AND c.MaĐV=a.MaĐV";
            Functions.Connect();
            Thuoc = Functions.GetDataToTable(sql);
            DataGridView.DataSource = Thuoc;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            if (cboMaThuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadDataGridView();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel_T excel = new ExportToExcel_T();            
            DataTable dt = (DataTable) DataGridView.DataSource;
            excel.Export(dt, "Báo cáo thông tin thuốc", "BÁO CÁO THÔNG TIN THUỐC");
        }      
    }
}
