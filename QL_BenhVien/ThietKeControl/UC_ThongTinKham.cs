using System;
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

        public UC_ThongTinKham()
        {
            InitializeComponent();
            txtMaPK.TextChanged += txtMaPK_TextChanged;
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
    }
}
