using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBenhNhan
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void mnuDMThuoc_Click(object sender, EventArgs e)
        {
            FrmDMThuoc frm = new FrmDMThuoc();
            frm.ShowDialog();
        }

        private void mnuBCThongTinThuoc_Click(object sender, EventArgs e)
        {
            FrmBaoCaoThongTinThuoc Frm = new FrmBaoCaoThongTinThuoc();
            Frm.ShowDialog();
        }

        private void mnuThongTinBA_Click(object sender, EventArgs e)
        {
            FrmThongTinCacBenhAn frm = new FrmThongTinCacBenhAn();
            frm.ShowDialog();
        }

        private void mnuTKBenhNhan_Click(object sender, EventArgs e)
        {
            FrmTimKiemBenhNhan frm = new FrmTimKiemBenhNhan();
            frm.ShowDialog();
        }

        private void mnuDMBacSi_Click(object sender, EventArgs e)
        {
            FrmDMBacSi frm = new FrmDMBacSi();
            frm.ShowDialog();
        }

        private void mnuDSHSBA_Click(object sender, EventArgs e)
        {
            FrmDanhSachHSBA frm = new FrmDanhSachHSBA();
            frm.ShowDialog();
        }

        private void mnuTKBenhAn_Click(object sender, EventArgs e)
        {
            FrmTimKiemBenhAn frm = new FrmTimKiemBenhAn();
            frm.ShowDialog();
        }

        private void mnuBCThongTinBenhAn_Click(object sender, EventArgs e)
        {
            FrmBaoCaoTTBenhAn frm = new FrmBaoCaoTTBenhAn();
            frm.ShowDialog();
        }

        private void mnuBCDanhSachBenhAn_Click(object sender, EventArgs e)
        {          
            FrmBaoCaoDSBenhAn frm = new FrmBaoCaoDSBenhAn();
            frm.ShowDialog();
        }

        private void mnuDMBenhNhan_Click(object sender, EventArgs e)
        {
            FrmDMBenhNhan frm = new FrmDMBenhNhan();
            frm.ShowDialog();
        }
    }
    }
