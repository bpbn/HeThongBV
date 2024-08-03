using BLL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ThietKeControl
{
    public partial class UC_ThongTinChanDoan : UserControl
    {
        private XuLyTruyVan bll = new XuLyTruyVan();

        public UC_ThongTinChanDoan()
        {
            InitializeComponent();

            cboBenh.TextChanged += cboBenh_TextChanged;

            cboBenh.Items.AddRange(bll.TimKiemBenh("").Select(b => b.TENBENH).ToArray());

        }

        private void cboBenh_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = cboBenh.Text;

            var danhSachKetQua = bll.TimKiemBenh(tuKhoa);

            cboBenh.Items.Clear();
            cboBenh.Items.AddRange(danhSachKetQua.Select(b => b.TENBENH).ToArray());

            cboBenh.SelectionStart = cboBenh.Text.Length;
            cboBenh.SelectionLength = 0;

            cboBenh.DroppedDown = true;
        }
    }
}
