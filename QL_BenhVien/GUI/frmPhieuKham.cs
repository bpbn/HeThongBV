using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThietKeControl;

namespace GUI
{
    public partial class frmPhieuKham : Form
    {
        private XuLyTruyVan xlTruyVanBLL = new XuLyTruyVan();

        public frmPhieuKham()
        {
            InitializeComponent();
        }

        private void frmPhieuKham_Load(object sender, EventArgs e)
        {
            loadCboBacSi();
            loadBenhNhan();
            dgvBenhNhan.RowSelected += dgvBenhNhan_RowSelected;
        }


        private void loadCboBacSi()
        {
            var tenBS = xlTruyVanBLL.dsBacSiLamViec();
            cboBacSi.DataSource = tenBS;
        }

        private void loadBenhNhan()
        {
            DataTable data = XuLyTruyVan.GetTableData("BENHNHAN");
            dgvBenhNhan.SetDataSource(data);
        }

        private void cboBacSi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBacSi = cboBacSi.SelectedItem.ToString();
            var manv = xlTruyVanBLL.dsBacSi().FirstOrDefault(nv => nv.TENNHANVIEN == selectedBacSi)?.MANHANVIEN;

            if(manv != null )
            {
                var tenPhongLamViec = xlTruyVanBLL.LayTenPhongLamViec(manv);
                txtPhong.Text = tenPhongLamViec;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string benhNhan = txtTimKiem.Text;
            var kq = xlTruyVanBLL.TimKiemBenhNhan(benhNhan);
            var dataTable = ConvertToDataTable(kq);
            dgvBenhNhan.SetDataSource(dataTable);

        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            grbTTBN.Enabled = true;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            grbTTBN.Enabled = false;
        }

        private DataTable ConvertToDataTable(List<BENHNHAN> danhSachBenhNhan)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("MABENHNHAN", typeof(string));
            dataTable.Columns.Add("TENBENHNHAN", typeof(string));
            dataTable.Columns.Add("NGAYSINH", typeof(DateTime));
            dataTable.Columns.Add("GIOITINH", typeof(string));
            dataTable.Columns.Add("SDT", typeof(string));
            dataTable.Columns.Add("DIACHI", typeof(string));

            foreach (var bn in danhSachBenhNhan)
            {
                dataTable.Rows.Add(bn.MABENHNHAN, bn.TENBENHNHAN, bn.NGAYSINH, bn.GIOITINH, bn.SDT, bn.DIACHI);
            }

            return dataTable;
        }

        private void dgvBenhNhan_RowSelected(object sender, DataRow e)
        {
            if (e != null)
            {
                txtMaBN.Text = e["MABENHNHAN"].ToString();
                txtTenBN.Text = e["TENBENHNHAN"].ToString();
                txtSDT.Text = e["SDT"].ToString();
                txtDiaChi.Text = e["DIACHI"].ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(e["NGAYSINH"]);

                var gioiTinh = e["GIOITINH"].ToString();
                rdoNam.Checked = gioiTinh.Equals("Nam", StringComparison.OrdinalIgnoreCase);
                rdoNu.Checked = gioiTinh.Equals("Nữ", StringComparison.OrdinalIgnoreCase);
            }
        }
    }
}
