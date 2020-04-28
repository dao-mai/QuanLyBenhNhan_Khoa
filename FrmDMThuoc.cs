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
    public partial class FrmDMThuoc : Form
    {
        DataTable Thuoc;
        public FrmDMThuoc()
        {
            InitializeComponent();
        }

        private void FrmDMThuoc_Load(object sender, EventArgs e)
        {
            txtMaThuoc.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            Functions.FillCombo("SELECT MaCD, TenCD FROM CongDung", cboCongDung, "MaCD", "TenCD");
            cboCongDung.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaĐV, TenĐV FROM ĐonViTinh", cboDonVi, "MaĐV", "TenĐV");
            cboDonVi.SelectedIndex = -1;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            
            string sql;
            sql = "select a.MaT, b.TenCD, c.TenĐV, a.TenT,a.ThanhPhan, a.ĐonGia" +
                " from Thuoc AS a, CongDung AS b, ĐonViTinh AS c WHERE  b.MaCD = a.MaCD AND c.MaĐV=a.MaĐV";
            Thuoc = Functions.GetDataToTable(sql);
            DataGridView.DataSource = Thuoc;
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaThuoc.Text = DataGridView.CurrentRow.Cells["MaThuoc"].Value.ToString();
            txtTenThuoc.Text = DataGridView.CurrentRow.Cells["TenThuoc"].Value.ToString();
            txtThanhPhan.Text = DataGridView.CurrentRow.Cells["ThanhPhan"].Value.ToString();
            txtDonGia.Text = DataGridView.CurrentRow.Cells["DonGia"].Value.ToString();
            cboCongDung.Text = DataGridView.CurrentRow.Cells["CongDung"].Value.ToString();
            cboDonVi.Text = DataGridView.CurrentRow.Cells["DonVi"].Value.ToString();
            txtMaThuoc.Enabled = false;
        }

        private void ResetValues()
        {
            txtMaThuoc.Text = " ";
            txtThanhPhan.Text = "";
            txtTenThuoc.Text = "";
            cboDonVi.Text = "";
            cboCongDung.Text = "";
            txtDonGia.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            ResetValues();
            txtMaThuoc.Enabled = true;
            txtMaThuoc.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaThuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã thuốc", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaThuoc.Focus();
                return;
            }
            if (txtTenThuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thuốc", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenThuoc.Focus();
                return;
            }
            sql = "SELECT MaT FROM Thuoc WHERE MaT=N'" +
txtMaThuoc.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã thuốc này đã có, bạn phải nhập mã khác", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaThuoc.Focus();
                txtMaThuoc.Text = "";
                return;
            }
            
            sql = " INSERT INTO Thuoc(MaT,TenT,MaCD,MaĐV,ThanhPhan,ĐonGia)" +
                " VALUES(N'" + txtMaThuoc.Text + "',N'" + txtTenThuoc.Text + "',N'" + cboCongDung.SelectedValue + "',N'" + cboDonVi.SelectedValue + "',N'"
                 + txtThanhPhan.Text + "'," + txtDonGia.Text + ")";
                Functions.RunSql(sql);
            LoadDataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaThuoc.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (Thuoc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMaThuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenThuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thuốc", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenThuoc.Focus();
                return;
            }
            if (txtThanhPhan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thành phần thuốc", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThanhPhan.Focus();
                return;
            }
            if (txtDonGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá thuốc", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }
            if (cboCongDung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn công dụng của thuốc", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCongDung.Focus();
                return;
            }
            if (cboDonVi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn đơn vị của thuốc", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDonVi.Focus();
                return;
            }


            sql = "UPDATE Thuoc SET TenT=N'" + txtTenThuoc.Text + "', ThanhPhan=N'" +txtThanhPhan.Text
                + "',ĐonGia ='" +txtDonGia.Text +"',MaCD=N'" +cboCongDung.SelectedValue + "',MaĐV=N'" +cboDonVi.SelectedValue+
"' WHERE MaT=N'" + txtMaThuoc.Text + "'";
            Class.Functions.RunSql(sql);
            LoadDataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (Thuoc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMaThuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE Thuoc WHERE MaT=N'" + txtMaThuoc.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaThuoc.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
