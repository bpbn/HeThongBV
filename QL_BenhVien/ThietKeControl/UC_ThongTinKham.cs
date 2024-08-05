using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL;

namespace ThietKeControl
{
    public partial class UC_ThongTinKham : UserControl
    {
        public class CapNhatThongTinBenhNhanEventArgs : EventArgs
        {
            public DAL.BENHNHAN benhNhan;
        }

        public event EventHandler<CapNhatThongTinBenhNhanEventArgs> CapNhatThongTinBenhNhan;

        private XuLyTruyVan bll = new XuLyTruyVan();
        private List<DAL.NHANVIEN> danhSachBacSi;

        public UC_ThongTinKham()
        {
            InitializeComponent();
            txtMaPK.TextChanged += txtMaPK_TextChanged;
            cboMaBS.TextUpdate += cboMaBS_TextUpdate;
            LoadBacSiToComboBox();
        }

        private void txtMaPK_TextChanged(object sender, EventArgs e)
        {
            string maPhieuKham = txtMaPK.Text;

            if (!string.IsNullOrEmpty(maPhieuKham))
            {
                var phieuKham = bll.LayThongTinPhieuKham(maPhieuKham);
                if (phieuKham != null)
                {
                    txtMaPhong.Text = phieuKham.MAPHONG;
                    txtNgayLap.Text = DateTime.Now.ToString("yyyy-MM-dd");

                    var benhNhan = bll.LayThongTinBenhNhan(phieuKham.MABENHNHAN);
                    if (benhNhan != null)
                    {
                        CapNhatThongTinBenhNhan.Invoke(this,
                            new CapNhatThongTinBenhNhanEventArgs() { benhNhan = benhNhan });
                    }
                }
            }
        }

        private void LoadBacSiToComboBox()
        {
            danhSachBacSi = bll.dsBacSi();
            cboMaBS.DataSource = danhSachBacSi;
            cboMaBS.DisplayMember = "MANHANVIEN";
            cboMaBS.ValueMember = "MANHANVIEN";
        }

        private void cboMaBS_TextUpdate(object sender, EventArgs e)
        {
            string searchText = cboMaBS.Text.ToLower();

            var filteredList = danhSachBacSi
                .Where(bs => bs.MANHANVIEN.ToLower().Contains(searchText))
                .ToList();

            if (filteredList.Any())
            {
                cboMaBS.DataSource = filteredList;
                cboMaBS.DroppedDown = true;
                cboMaBS.DisplayMember = "MANHANVIEN";
                cboMaBS.ValueMember = "MANHANVIEN";

                cboMaBS.Text = searchText;

                cboMaBS.SelectionStart = searchText.Length;
                cboMaBS.SelectionLength = 0;
            }
            else
            {
                cboMaBS.DroppedDown = false;
            }
        }
    }
}