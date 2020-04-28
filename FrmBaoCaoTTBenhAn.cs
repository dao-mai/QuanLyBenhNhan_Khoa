using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBenhNhan.Class;


namespace QuanLyBenhNhan
{
    public partial class FrmBaoCaoTTBenhAn : Form
    {
        DataTable tblHoSoBenhAn;
        public FrmBaoCaoTTBenhAn()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoDanhSachBenhAn_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            Functions.FillCombo("SELECT distinct MaBA FROM HoSoBenhAn", cboMaBenhAn, "MaBA", "MaBA");
            cboMaBenhAn.SelectedIndex = -1;
        }

        private void loadDataTimKiem()
        {
            Functions.Connect();
            String SQL = "select MaBA, MaBN,  MaBS, NgayKham, LiDoKham, MaTT, TienSuBenh, HuyetAp, CanNang, NhietDo, MaPA, TienKham From  HoSoBenhAn  ";
            tblHoSoBenhAn = Functions.GetDataToTable(SQL);
            dataGridViewTimKiem.DataSource = tblHoSoBenhAn;
            dataGridViewTimKiem.Columns[0].HeaderText = " Mã bệnh án";
            dataGridViewTimKiem.Columns[1].HeaderText = " Mã bệnh nhân";
            dataGridViewTimKiem.Columns[2].HeaderText = " Mã bác sĩ";
            dataGridViewTimKiem.Columns[3].HeaderText = " Ngày khám";
            dataGridViewTimKiem.Columns[4].HeaderText = " Lí do khám";
            dataGridViewTimKiem.Columns[5].HeaderText = " Mã tình trạng";
            dataGridViewTimKiem.Columns[6].HeaderText = " Tiền sử bệnh";
            dataGridViewTimKiem.Columns[7].HeaderText = " Huyết áp";
            dataGridViewTimKiem.Columns[8].HeaderText = " Cân nặng";
            dataGridViewTimKiem.Columns[9].HeaderText = " nhiệt độ";
            dataGridViewTimKiem.Columns[10].HeaderText = " Mã phương án";
            dataGridViewTimKiem.Columns[11].HeaderText = " Tiền khám";
            dataGridViewTimKiem.AllowUserToAddRows = false;
            dataGridViewTimKiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void bntTimKiem_Click(object sender, EventArgs e)
        {
            Functions.Connect();

            if (cboMaBenhAn.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mã bệnh án", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaBenhAn.Focus();
                return;
            }
            string SQL = "select MaBA, HoSoBenhAn.MaBN, MaBS, NgayKham, LiDoKham, MaTT, TienSuBenh, HuyetAp, CanNang, NhietDo, MaPA, TienKham From HoSoBenhAn Where 1=1";
            if (cboMaBenhAn.Text != "")
                SQL = SQL + " AND HoSoBenhAn.MaBA Like N'%" + cboMaBenhAn.Text + "%'";
            tblHoSoBenhAn = Functions.GetDataToTable(SQL);
            dataGridViewTimKiem.DataSource = tblHoSoBenhAn;
        }

        private void bntInBaoCao_Click(object sender, EventArgs e)
        {
            ExportToExcel_TTBA excel = new ExportToExcel_TTBA();
            DataTable dt = (DataTable)dataGridViewTimKiem.DataSource;
            excel.Export(dt, "Báo cáo thông tin bệnh án", "BÁO CÁO THÔNG TIN BỆNH ÁN THEO MÃ BỆNH ÁN");
        }
    }
}
