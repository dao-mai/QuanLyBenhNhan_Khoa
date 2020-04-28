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
   
    public partial class FrmThongTinCacBenhAn : Form
    {
        public FrmThongTinCacBenhAn()
        {
            InitializeComponent();
        }

        private void FrmThongTinBenhAn_Load(object sender, EventArgs e)
        {
            
            Functions.FillCombo("SELECT MaBA FROM HoSoBenhAn", cboMaBenhAn, "MaBA", "MaBA");
            cboMaBenhAn.SelectedIndex = -1;           
        }

        
        private void LoadDataGridView_T()
        {
            DataTable BenhAn;
            string sql1;
            sql1 = "SELECT b.MaBA, a.MaT,c.TenT, a.SoLuong, a.SoNgayDung,a.LieuDung,a.CachDung, a.Thanhtien, c.MaCD,c.MaĐV,c.ThanhPhan,c.ĐonGia" +
                " FROM BenhAnThuoc AS a, HoSoBenhAn AS b, Thuoc c WHERE a.MaBA = N'" +
                cboMaBenhAn.SelectedValue + "' AND a.MaBA=b.MaBA AND a.MaT= c.MaT";

            BenhAn = Functions.GetDataToTable(sql1);
            DataGridView_BAT.DataSource = BenhAn;
        }

        private void LoadDataGridView_XN()
        {
            DataTable BenhAnXetNghiem;
            string sql1;
            sql1 = "SELECT b.MaBA, a.MaXN, a.NgayXN, a.KetQua, a.MaKL, a.BacSiXN, a.TienXN,c.TenKL " +
                "FROM BenhAnXetNghiem AS a, HoSoBenhAn AS b, KetLuan AS c WHERE b.MaBA = N'"
                + cboMaBenhAn.SelectedValue + "' AND a.MaBA=b.MaBA AND a.MaKL=c.MaKL";
            BenhAnXetNghiem = Functions.GetDataToTable(sql1);
            DataGridView_BAXN.DataSource = BenhAnXetNghiem;
        }
        
       private void LoadDataGridView_KL()
        {
            DataTable BenhAnKetLuan;
            string sql2;
            sql2 = "SELECT *"
                +"FROM BenhAnKetLuan as a, Benh as b, PhuongAn as c  WHERE MaBA = N'"
                + cboMaBenhAn.SelectedValue + "'AND b.MaB=a.MaB AND c.MaPA=a.MaPA ";
            BenhAnKetLuan = Functions.GetDataToTable(sql2);
            DataGridView_BAKL.DataSource = BenhAnKetLuan;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboMaBenhAn.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mã bệnh án", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadDataGridView_T();
            LoadDataGridView_XN();
            LoadDataGridView_KL();
        }
        
    }
}
