using System;
using System.Windows.Forms;
using ThietKeControl;

namespace GUI
{
    public partial class FrmChanDoan : Form
    {
        private UC_ThongTinBenhNhan ucThongTinBenhNhan;
        private UC_ThongTinKham ucThongTinKham;
        private UC_ThongTinChanDoan ucThongTinChanDoan;

        public FrmChanDoan()
        {
            InitializeComponent();
            ucThongTinBenhNhan = new UC_ThongTinBenhNhan();
            ucThongTinKham = new UC_ThongTinKham();
            ucThongTinChanDoan = new UC_ThongTinChanDoan();

            ucThongTinKham.CapNhatThongTinBenhNhan += UcThongTinKham_CapNhatThongTinBenhNhan;

            ucThongTinBenhNhan.Left = ucThongTinKham.Left = ucThongTinChanDoan.Left = 10;

            ucThongTinKham.Top = ucThongTinBenhNhan.Height;
            ucThongTinChanDoan.Top = ucThongTinBenhNhan.Height + ucThongTinKham.Height;

            Controls.Add(ucThongTinKham);
            Controls.Add(ucThongTinBenhNhan);
            Controls.Add(ucThongTinChanDoan);
        }

        private void UcThongTinKham_CapNhatThongTinBenhNhan(object sender, UC_ThongTinKham.CapNhatThongTinBenhNhanEventArgs e)
        {
            ucThongTinBenhNhan.SetBenhNhan(e.benhNhan);

            Controls.Add(ucThongTinBenhNhan);
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            string maToaThuoc;
            // Tạo toa thuốc
            maToaThuoc = TaoToaThuoc();
            // Thêm chi tiết toa thuốc
            ThemChiTietToaThuoc(maToaThuoc);
            // Thêm chi tiết chẩn đoán
            ThemChiTietChanDoan(maToaThuoc);
        }

        private void ThemChiTietChanDoan(string maToaThuoc)
        {
            ucThongTinChanDoan.ThemChiTietChanDoan(maToaThuoc);
        }

        private void ThemChiTietToaThuoc(string maToaThuoc)
        {
            ucThongTinChanDoan.ThemChiTietDonThuoc(maToaThuoc);
        }

        private string TaoToaThuoc()
        {
            string maPK = ucThongTinKham.LayMaPhieuKham();
            string maNV = ucThongTinKham.LayMaBacSi();
            DateTime ngayLap = ucThongTinKham.LayNgayLap();
            int tongTien = ucThongTinChanDoan.TinhTongTien();
            string loiDan = ucThongTinChanDoan.LayLoiDan();

            return ucThongTinChanDoan.TaoToaThuoc(maPK, maNV, ngayLap, tongTien, loiDan);
        }
    }
}