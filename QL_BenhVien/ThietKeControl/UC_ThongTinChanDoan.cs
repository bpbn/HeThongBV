using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ThietKeControl
{
    public partial class UC_ThongTinChanDoan : UserControl
    {
        private XuLyTruyVan bll = new XuLyTruyVan();
        private List<DAL.BENH> danhSachBenh;
        private List<DAL.THUOC> danhSachThuoc;

        public UC_ThongTinChanDoan()
        {
            InitializeComponent();

            LoadBenhToComboBox();
            LoadThuocToComboBox();

            cboBenh.TextUpdate -= cboBenh_TextUpdate;
            cboBenh.TextUpdate += cboBenh_TextUpdate;

            cboThuoc.TextUpdate -= cboThuoc_TextUpdate;
            cboThuoc.TextUpdate += cboThuoc_TextUpdate;

            cboBenh.SelectedIndexChanged += cboBenh_SelectedIndexChanged;

            btnThemThuoc.Click -= BtnThemThuoc_Click;
            btnThemThuoc.Click += BtnThemThuoc_Click;

            btnXoaThuoc.Click -= BtnXoaThuoc_Click;
            btnXoaThuoc.Click += BtnXoaThuoc_Click;
            dgvCTTT.Rows.Clear();
        }

        private void BtnXoaThuoc_Click(object sender, EventArgs e)
        {
            if (dgvCTTT.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCTTT.SelectedRows)
                {
                    dgvCTTT.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnThemThuoc_Click(object sender, EventArgs e)
        {
            if (cboThuoc.SelectedValue != null)
            {
                string tenThuoc = cboThuoc.Text;
                int soLuong = 1;
                string ghiChu = "";

                dgvCTTT.Rows.Add(tenThuoc, soLuong, ghiChu);
            }
        }

        public void ThemChiTietChanDoan(string maToaThuoc)
        {
            string maBenh = ((DAL.BENH) cboBenh.SelectedItem).MABENH;

            DAL.CHITIETCHUANDOAN chiTietChanDoan = new DAL.CHITIETCHUANDOAN();
            chiTietChanDoan.MABENH = maBenh;
            chiTietChanDoan.MATOATHUOC = maToaThuoc;

            bll.ThemChiTietChanDoan(chiTietChanDoan);
        }

        public void ThemChiTietDonThuoc(string maToaThuoc)
        {

            foreach (DataGridViewRow row in dgvCTTT.Rows)
            {
                if (row.Cells[0].Value == null)
                    continue;

                string tenThuoc = row.Cells[0].Value.ToString();
                int soLuong = int.Parse(row.Cells[1].Value.ToString());
                string ghiChu = row.Cells[2].Value.ToString();

                DAL.THUOC thuoc = danhSachThuoc.Find(t => t.TENTHUOC == tenThuoc);
                string ma = thuoc.MATHUOC;
                int? gia = thuoc.GIA;

                DAL.CHITIETTOATHUOC chiTietToaThuoc = new DAL.CHITIETTOATHUOC();
                chiTietToaThuoc.MATOATHUOC = maToaThuoc; // Mã toa thuốc
                chiTietToaThuoc.DONGIA = gia; // Đơn giá thuốc
                chiTietToaThuoc.MATHUOC = ma; // Mã thuốc
                chiTietToaThuoc.SOLUONG = soLuong; // Số lượng
                chiTietToaThuoc.GHICHU = ghiChu; // Ghi chú

                bll.ThemChiTietToaThuoc(chiTietToaThuoc);
            }
        }

        public string TaoToaThuoc(string maPK, string maNV, DateTime ngayLap, int tongTien, string loiDan)
        {
            DAL.TOATHUOC toaThuoc = new DAL.TOATHUOC();
            toaThuoc.MAPHIEUKHAM = maPK;
            toaThuoc.MANHANVIEN = maNV;
            toaThuoc.NGAYLAP = ngayLap;
            toaThuoc.TONGTIEN = tongTien;
            toaThuoc.LOIDAN = loiDan;

            return bll.TaoToaThuoc(toaThuoc);
        }

        public int TinhTongTien()
        {
            int tongTien = 0;
            foreach (DataGridViewRow row in dgvCTTT.Rows)
            {
                if (row.Cells[0].Value == null)
                    continue;

                string tenThuoc = row.Cells[0].Value.ToString();
                int soLuong = int.Parse(row.Cells[1].Value.ToString());

                int? gia = danhSachThuoc.Find(t => t.TENTHUOC == tenThuoc).GIA;
                tongTien += soLuong * (gia ?? 0);
            }
            return tongTien;
        }

        public string LayLoiDan()
        {
            return txtLoiDan.Text;
        }

        private void LoadBenhToComboBox()
        {
            danhSachBenh = bll.dsBenh();
            cboBenh.DataSource = danhSachBenh;
            cboBenh.DisplayMember = "TENBENH";
            cboBenh.ValueMember = "MABENH";
        }

        private void LoadThuocToComboBox()
        {
            danhSachThuoc = bll.dsThuoc();
            cboThuoc.DataSource = danhSachThuoc;
            cboThuoc.DisplayMember = "TENTHUOC";
            cboThuoc.ValueMember = "MATHUOC";
        }

        private void cboBenh_TextUpdate(object sender, EventArgs e)
        {
            string searchText = cboBenh.Text.ToLower();

            var filteredList = danhSachBenh
                .Where(b => b.MABENH.ToLower().Contains(searchText) || b.TENBENH.ToLower().Contains(searchText))
                .ToList();

            if (filteredList.Any())
            {
                cboBenh.DataSource = filteredList;
                cboBenh.DroppedDown = true;
                cboBenh.DisplayMember = "TENBENH";
                cboBenh.ValueMember = "MABENH";

                cboBenh.Text = searchText;
                cboBenh.SelectionStart = searchText.Length;
                cboBenh.SelectionLength = 0;
            }
            else
            {
                cboBenh.DroppedDown = false;
            }
        }

        private void cboThuoc_TextUpdate(object sender, EventArgs e)
        {
            string searchText = cboThuoc.Text.ToLower();

            var filteredList = danhSachThuoc
                .Where(t => t.MATHUOC.ToLower().Contains(searchText) || t.TENTHUOC.ToLower().Contains(searchText))
                .ToList();

            if (filteredList.Any())
            {
                cboThuoc.DataSource = filteredList;
                cboThuoc.DroppedDown = true;
                cboThuoc.DisplayMember = "TENTHUOC";
                cboThuoc.ValueMember = "MATHUOC";

                cboThuoc.Text = searchText;
                cboThuoc.SelectionStart = searchText.Length;
                cboThuoc.SelectionLength = 0;
            }
            else
            {
                cboThuoc.DroppedDown = false;
            }
        }

        private void cboBenh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBenh.SelectedValue != null)
            {
                if (cboBenh.SelectedValue.ToString() == "B0048")
                {
                    txtBenh.Visible = true;
                }
                else
                {
                    txtBenh.Visible = false;
                }
            }
        }




    }
}