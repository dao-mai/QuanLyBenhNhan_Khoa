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
    public partial class FrmDanhSachHSBA : Form
    {
        DataTable tblHSBA;
        public FrmDanhSachHSBA()
        {
            InitializeComponent();
        }

        private void FrmDanhSachHSBA_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            Functions.FillCombo("select  distinct MaBN from HoSoBenhAn", cboMaBenhNhan, "MaBN","MaBN");
            cboMaBenhNhan.SelectedIndex = -1;
        }

        private void loadDataTraCuu()
        {
            Functions.Connect();
            String SQL = "select MaBA, HoSoBenhAn.MaBN, TenBN, MaBS, NgayKham, LiDoKham, MaTT, TienSuBenh, HuyetAp, CanNang, NhietDo, MaPA, TienKham From BenhNhan join HoSoBenhAn on HoSoBenhAn.MaBN= BenhNhan.MaBN ";
            tblHSBA = Functions.GetDataToTable(SQL);
            dataGridViewTraCuu.DataSource = tblHSBA;
            dataGridViewTraCuu.Columns[0].HeaderText = " Mã bệnh án";
            dataGridViewTraCuu.Columns[1].HeaderText = " Mã bệnh nhân";
            dataGridViewTraCuu.Columns[2].HeaderText = " Tên bệnh nhân";
            dataGridViewTraCuu.AllowUserToAddRows = false;
            dataGridViewTraCuu.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void bntTimKIem_Click(object sender, EventArgs e)
        {
            Functions.Connect();

            if (cboMaBenhNhan.Text == "")
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaBenhNhan.Focus();
                return;
            }
            string SQL = "select MaBA, HoSoBenhAn.MaBN, TenBN From BenhNhan join HoSoBenhAn on HoSoBenhAn.MaBN= BenhNhan.MaBN Where 1=1";
            if (cboMaBenhNhan.Text != "")
                SQL = SQL + " AND HoSoBenhAn.MaBN Like N'%" + cboMaBenhNhan.Text + "%'";
            tblHSBA = Functions.GetDataToTable(SQL);
            if (tblHSBA.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
                MessageBox.Show("Có " + tblHSBA.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dataGridViewTraCuu.DataSource = tblHSBA;
        }             
    }
}
