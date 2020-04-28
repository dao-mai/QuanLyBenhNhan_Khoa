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
    public partial class FrmBaoCaoDSBenhAn : Form
    {
        DataTable tblBenhAnTheoBS;
        public FrmBaoCaoDSBenhAn()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoThongTinBenhAn_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            Functions.FillCombo("SELECT distinct MaBS FROM HoSoBenhAn", cboMaBacSi, "MaBS", "MaBS");
            cboMaBacSi.SelectedIndex = -1;
        }

        private void loadDataTimKiemBA()
        {
            Functions.Connect();
            String SQL = "select MaBA, MaBN,  HoSoBenhAn.MaBS,TenBS From BacSi join HoSoBenhAn on HoSoBenhAn.MaBS= BacSi.MaBS ";
            tblBenhAnTheoBS = Functions.GetDataToTable(SQL);
            dataGridViewBenhAnTheoBS.DataSource = tblBenhAnTheoBS;
            dataGridViewBenhAnTheoBS.Columns[0].HeaderText = " Mã bệnh án";
            dataGridViewBenhAnTheoBS.Columns[1].HeaderText = " Mã bệnh nhân";
            dataGridViewBenhAnTheoBS.Columns[2].HeaderText = " Mã bác sĩ";
            dataGridViewBenhAnTheoBS.Columns[3].HeaderText = " Tên bác sĩ";          
            dataGridViewBenhAnTheoBS.AllowUserToAddRows = false;
            dataGridViewBenhAnTheoBS.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void bntTimKiem_Click(object sender, EventArgs e)
        {
            Functions.Connect();

            if (cboMaBacSi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bác sĩ", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaBacSi.Focus();
                return;
            }
            string SQL = "select MaBA, BacSi.TenBS, MaBN, HoSoBenhAn.MaBS From BacSi join  HoSoBenhAn on HoSoBenhAn.MaBS= BacSi.MaBS  Where 1=1";
            if (cboMaBacSi.Text != "")
                SQL = SQL + " AND HoSoBenhAn.MaBS Like N'%" + cboMaBacSi.Text + "%'";
            tblBenhAnTheoBS = Functions.GetDataToTable(SQL);
            dataGridViewBenhAnTheoBS.DataSource = tblBenhAnTheoBS;
        }

        private void bntInBaoCao_Click(object sender, EventArgs e)
        {
            ExportToExcel_DSBA excel = new ExportToExcel_DSBA();
            DataTable dt = (DataTable)dataGridViewBenhAnTheoBS.DataSource;
            excel.Export(dt, "Báo cáo danh sách bệnh án", "BÁO CÁO DS BỆNH ÁN THEO MÃ BÁC SĨ");
        }
    }
}
