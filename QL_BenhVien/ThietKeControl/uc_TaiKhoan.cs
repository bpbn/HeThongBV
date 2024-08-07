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
    public partial class uc_TaiKhoan : UserControl
    {
        XuLyTruyVan truyVanBLL = new XuLyTruyVan();
        public uc_TaiKhoan()
        {
            InitializeComponent();
            loadCboNhanVien();
            loadCboLoaiTaiKhoan();

            string maMoi = truyVanBLL.TaoMaTaiKhoan();
            txtMaTaiKhoan.Text = maMoi;
        }

        private void loadCboLoaiTaiKhoan()
        {
            var dsLoaiTaiKhoan = truyVanBLL.dsLoaiTaiKhoan();
            cbLoaiTaiKhoan.DataSource = dsLoaiTaiKhoan;
        }

        public void loadCboNhanVien()
        {
            var dsNhanVien = truyVanBLL.dsNhanVien();
            cbNhanVien.DataSource = dsNhanVien;
            cbNhanVien.DisplayMember = "TENNHANVIEN";
            cbNhanVien.ValueMember = "MANHANVIEN";
        }

        public TAIKHOAN layTTTK()
        {
            return new TAIKHOAN
            {
                MATAIKHOAN = txtMaTaiKhoan.Text,
                TENTAIKHOAN = txtTenTaiKhoan.Text,
                MATKHAU = txtMatKhau.Text,
                LOAITAIKHOAN = cbLoaiTaiKhoan.SelectedItem.ToString(),
                MANHANVIEN = cbNhanVien.SelectedItem.ToString()
            };
        }

        public void UpdateControls(string maTK, string ten, string matKhau, string loaiTaiKhoan, string maNV)
        {
            txtMaTaiKhoan.Text = maTK;
            txtTenTaiKhoan.Text = ten;
            txtMatKhau.Text = matKhau;
            cbLoaiTaiKhoan.SelectedItem = loaiTaiKhoan;
            cbNhanVien.SelectedValue = maNV;
        }

        public string layMaTaiKhoan()
        {
            return txtMaTaiKhoan.Text;
        }
    }
}
