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
        LayDanhSach layDanhSach = new LayDanhSach();

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

            List<DateTime> dsNgayTrongTuanToi = dsNgayCuaTuanTiepTheo(today);
            bool lichTonTai = false;
            foreach(var day in dsNgayTrongTuanToi)
            {
                if (layDanhSach.ktraTonTaiNgayTrongLLV(day))
                {
                    lichTonTai = true;
                    break;
                }
            }

            List<DateTime> daysInLastWeek = dsNgayCuaTuanCuoiCung(today.Year, today.Month);
            if (!lichTonTai)
            {
                if (daysInLastWeek.Contains(today.Date))
                {
                    DialogResult rs = MessageBox.Show("Nếu bây giờ xếp lịch cho tháng mới, lịch của tháng cũ sẽ bị xóa! Bạn có muốn tiếp tục không?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        layDanhSach.XoaLichLamViec();
                        xepLichLamViecBLL.XepLichLamViecChoBacSi(startDate, endDate);
                    }
                }
                else
                {
                    xepLichLamViecBLL.XepLichLamViecChoBacSi(startDate, endDate);
                }
                LoadLichLamViec();
                MessageBox.Show("Đã xếp lịch làm việc cho bác sĩ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lịch đã được xếp!");
            }    
        }

        public void LoadLichLamViec()
        {
            DataTable data = XuLyTruyVan.GetTableData("LICHLAMVIEC");
            dgvLichLamViec.SetDataSource(data);
        }

        private void btnXoaLich_Click(object sender, EventArgs e)
        {
            layDanhSach.XoaLichLamViec();
            LoadLichLamViec();
        }

        public static List<DateTime> dsNgayCuaTuanCuoiCung(int year, int month)
        {
            List<DateTime> days = new List<DateTime>();
            DateTime ngayCuoiThang = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            int ngayDauCuaTuanCuoiCung = DayOfWeek.Monday - ngayCuoiThang.DayOfWeek;
            DateTime ngayThuHaiCuoiCung = ngayCuoiThang.AddDays(ngayDauCuaTuanCuoiCung);

            if (ngayThuHaiCuoiCung.Month != month)
            {
                ngayThuHaiCuoiCung = ngayThuHaiCuoiCung.AddDays(7);
            }

            for (int i = 0; i < 5; i++)
            {
                days.Add(ngayThuHaiCuoiCung.AddDays(i));
            }
            return days;
        }

        public List<DateTime> dsNgayCuaTuanTiepTheo(DateTime currentDate)
        {
            List<DateTime > days = new List<DateTime>();
            DateTime ngayDauTuanTiepTheo = currentDate.AddDays(7 -(int)currentDate.DayOfWeek + (int)DayOfWeek.Monday);
            for(int  i = 0; i < 7;i++)
            {
                days.Add(ngayDauTuanTiepTheo.AddDays(i));
            }
            return days;
        }
        
    }
}
