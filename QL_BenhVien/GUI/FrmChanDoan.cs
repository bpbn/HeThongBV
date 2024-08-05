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

    }
}