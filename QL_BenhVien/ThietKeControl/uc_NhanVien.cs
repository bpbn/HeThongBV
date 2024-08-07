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

namespace ThietKeControl
{
    public partial class uc_NhanVien : UserControl
    {
        private XuLyTruyVan truyVanBLL = new XuLyTruyVan();
        public uc_NhanVien()
        {
            InitializeComponent();
            loadCboChucVu();
            string maNVTiepTheo = truyVanBLL.TaoMaNhanVien();
            txtMaNhanVien.Text = maNVTiepTheo;
        }

        private void loadCboChucVu()
        {
            var dsChucVu = truyVanBLL.dsChucVu();
            cbChucVu.DataSource = dsChucVu;
        }

        public NHANVIEN layTTNV()
        {
            string gioiTinh = "";

            if (rdoNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }

            return new NHANVIEN
            {
                MANHANVIEN = txtMaNhanVien.Text,
                TENNHANVIEN = txtTenNhanVien.Text,
                CHUCVU = cbChucVu.SelectedItem.ToString(),
                GIOITINH = gioiTinh
            };

        }
        public void UpdateControls(string ma, string ten, string chucVu, string gioiTinh)
        {
            txtMaNhanVien.Text = ma;
            txtTenNhanVien.Text = ten;
            cbChucVu.SelectedItem = chucVu;
            if (gioiTinh == "Nam")
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }
        }
        public string layMaNhanVien()
        {
            return txtMaNhanVien.Text;
        }
    }
}
