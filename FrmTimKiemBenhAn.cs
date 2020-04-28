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
    public partial class FrmTimKiemBenhAn : Form
    {
        DataTable tblHoSoBenhAn;
        public FrmTimKiemBenhAn()
        {
            InitializeComponent();
            LoadDataTimKiem();
        }      
        private void FrmTimKiemBenhAn_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            Functions.FillCombo("SELECT MaBS, TenBS FROM BacSi", cboMaBS, "MaBS", "TenBS");
            cboMaBS.SelectedIndex = -1;
            Functions.FillCombo("SELECT  NgayKham FROM HoSoBenhAn", cboNgayKham, "NgayKham", "NgayKham");
            cboNgayKham.SelectedIndex = -1;
        }
        private void LoadDataTimKiem()
        {
            Functions.Connect();
            string SQL = "select MaBA, MaBN, BacSi.MaBS,NgayKham, LiDoKham,TienSuBenh,HuyetAp,CanNang,NhietDo, TienKham from BacSi join HoSoBenhAn on HoSoBenhAn.MaBS=BacSi.MaBS";
            tblHoSoBenhAn = Functions.GetDataToTable(SQL);
            DataGridView_TimKiemBenhAn.DataSource = tblHoSoBenhAn;
            DataGridView_TimKiemBenhAn.Columns[0].HeaderText = " Mã bệnh án";
            DataGridView_TimKiemBenhAn.Columns[1].HeaderText = " Mã bệnh nhân";
            DataGridView_TimKiemBenhAn.Columns[2].HeaderText = " Mã bác sĩ";
            DataGridView_TimKiemBenhAn.Columns[3].HeaderText = " Ngày khám";
            DataGridView_TimKiemBenhAn.Columns[4].HeaderText = " Lí do khám";
            DataGridView_TimKiemBenhAn.Columns[5].HeaderText = " Tiền sử bệnh";
            DataGridView_TimKiemBenhAn.Columns[6].HeaderText = " Huyết áp ";
            DataGridView_TimKiemBenhAn.Columns[7].HeaderText = " Cân nặng";
            DataGridView_TimKiemBenhAn.Columns[8].HeaderText = " Nhiệt độ";
            DataGridView_TimKiemBenhAn.Columns[9].HeaderText = " Tiền khám";
            DataGridView_TimKiemBenhAn.AllowUserToAddRows = false;
            DataGridView_TimKiemBenhAn.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void bttTimKiem_Click(object sender, EventArgs e)
        {
            Functions.Connect();
            if ((cboMaBS.Text == "") && (cboNgayKham.Text == "") && (txtNhietDo.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yeu cau ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "select MaBA, MaBN, BacSi.MaBS,NgayKham, LiDoKham,TienSuBenh,HuyetAp,CanNang,NhietDo, TienKham from BacSi join HoSoBenhAn on HoSoBenhAn.MaBS=BacSi.MaBS";

            if (cboMaBS.Text != "")
                sql = sql + " AND HoSoBenhAn.MaBS like N'" + cboMaBS.Text + "%'";
            if (cboNgayKham.Text != "")
                sql = sql + " AND NgayKham = N' " + cboNgayKham.Text + "'";
            if (txtNhietDo.Text != "")
                sql = sql + " AND NhietDo Like N'" + txtNhietDo.Text + "%'";
            tblHoSoBenhAn = Functions.GetDataToTable(sql);
            if (tblHoSoBenhAn.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblHoSoBenhAn.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridView_TimKiemBenhAn.DataSource = tblHoSoBenhAn;
        }
    }
}
