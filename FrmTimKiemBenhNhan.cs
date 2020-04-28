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
   
    public partial class FrmTimKiemBenhNhan : Form
    {
        DataTable tblBenhNhan;
        public FrmTimKiemBenhNhan()
        {
            InitializeComponent();
        }

        private void FrmTimKiemBenhNhan_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            LoadDataTK();
        }
        private void LoadDataTK()
        {
            Functions.Connect();
            string SQL = "select MaB, HoSoBenhAn.MaBA,HoSoBenhAn.MaBN,TenBN,LiDoKham,GT,NS From BenhNhan join HoSoBenhAn on HoSoBenhAn.MaBN=BenhNhan.MaBN join BenhAnKetLuan on BenhAnKetLuan.MaBA=HoSoBenhAn.MaBA ";
            tblBenhNhan = Functions.GetDataToTable(SQL);
            DataGridView_BN.DataSource = tblBenhNhan;
            DataGridView_BN.Columns[0].HeaderText = " Mã bệnh";
            DataGridView_BN.Columns[1].HeaderText = " Mã bệnh án ";
            DataGridView_BN.Columns[2].HeaderText = " Mã bệnh nhân ";
            DataGridView_BN.Columns[3].HeaderText = " Tên bệnh nhân";
            DataGridView_BN.Columns[4].HeaderText = " Lí do khám";
            DataGridView_BN.Columns[5].HeaderText = " Giới tính";
            DataGridView_BN.Columns[6].HeaderText = " Ngày sinh";
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Functions.Connect();
            if ((txtTenBN.Text == "") && (txtMaB.Text == "") && (txtLiDoKham.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yeu cau ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "select BenhNhan.MaBN,MaB,HoSoBenhAn.MaBA, TenBN,LiDoKham, GT,NS From BenhNhan join HoSoBenhAn on HoSoBenhAn.MaBN=BenhNhan.MaBN join BenhAnKetLuan on BenhAnKetLuan.MaBA=HoSoBenhAn.MaBA ";
            if (txtTenBN.Text != "")
                sql = sql + " AND BenhNhan.TenBN like N'" + txtTenBN.Text + "%'";
            if (txtMaB.Text != "")
                sql = sql + " AND BenhAnKetLuan.MaB like N'" + txtMaB.Text + "%'";
            if (txtLiDoKham.Text != "")
                sql = sql + " AND HoSoBenhAn.LiDoKham like N'" + txtLiDoKham.Text + "%'";

            tblBenhNhan = Functions.GetDataToTable(sql);
            if (tblBenhNhan.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblBenhNhan.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridView_BN.DataSource = tblBenhNhan;
        }       
    }
}
