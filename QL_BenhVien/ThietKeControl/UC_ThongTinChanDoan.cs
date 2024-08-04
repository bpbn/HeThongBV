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

            cboBenh.SelectedIndexChanged -= cboBenh_SelectedIndexChanged;
            cboBenh.SelectedIndexChanged += cboBenh_SelectedIndexChanged;

            btnThemThuoc.Click -= BtnThemThuoc_Click;
            btnThemThuoc.Click += BtnThemThuoc_Click;
            btnXoaThuoc.Click -= BtnXoaThuoc_Click;
            btnXoaThuoc.Click += BtnXoaThuoc_Click;
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
