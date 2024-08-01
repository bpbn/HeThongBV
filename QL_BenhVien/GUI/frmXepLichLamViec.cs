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

namespace GUI
{
    public partial class frmXepLichLamViec : Form
    {
        public frmXepLichLamViec()
        {
            InitializeComponent();
            LoadLichLamViec();
        }

        private XepLichLamViec xepLichLamViecBLL = new XepLichLamViec();

        private void btnXepLich_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            // Ngày thứ Hai của tuần hiện tại
            DateTime startDateCurrentWeek = today.AddDays(-(int)today.DayOfWeek + (int)DayOfWeek.Monday);

            // Ngày thứ Hai của tuần sau
            DateTime startDate = startDateCurrentWeek.AddDays(7);

            // Ngày cuối cùng của tuần sau
            DateTime endDate = startDate.AddDays(6);

            // Gọi phương thức để xếp lịch
            xepLichLamViecBLL.XepLichLamViecChoBacSi(startDate, endDate);

            // Tải lịch làm việc và thông báo
            LoadLichLamViec();
            MessageBox.Show("Đã xếp lịch làm việc cho bác sĩ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LoadLichLamViec()
        {
            DataTable data = XuLyTruyVan.GetTableData("LICHLAMVIEC");
            dgvLichLamViec.SetDataSource(data);
        }

        private void btnXoaLich_Click(object sender, EventArgs e)
        {
            LayDanhSach layDanhSach = new LayDanhSach();
            layDanhSach.XoaLichLamViec();
            LoadLichLamViec();
        }
    }
}
