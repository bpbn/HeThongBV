using System;
using System.Collections.Generic;
using System.Linq;
using DAL;

namespace BLL
{
    public class XepLichLamViec
    {
        private LayDanhSach _layDanhSach = new LayDanhSach();

        public void XepLichLamViecChoBacSi(DateTime startDate, DateTime endDate)
        {
            var danhSachBacSi = _layDanhSach.LayDanhSachBacSi();
            var danhSachPhong = _layDanhSach.LayDanhSachPhong();

            // Xóa lịch làm việc cũ trước khi xếp lịch mới
            _layDanhSach.XoaLichLamViec();

            var lichLamViecMoi = new List<LICHLAMVIEC>();
            var random = new Random();

            // Lấy danh sách các ngày trong tuần
            List<DateTime> danhSachNgay = new List<DateTime>();
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                // Bỏ qua thứ 7 và chủ nhật
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    continue;

                danhSachNgay.Add(date);
            }

            // Xếp lịch cho từng bác sĩ
            foreach (var ca in new[] { "Sáng", "Chiều" })
            {
                // Khởi tạo cấu trúc dữ liệu để theo dõi số phòng đã mở trong từng ngày
                var soPhongDaMoTrongNgay = new Dictionary<DateTime, int>();

                foreach (var ngay in danhSachNgay)
                {
                    // Khởi tạo số lượng phòng đã mở trong ngày
                    soPhongDaMoTrongNgay[ngay] = 0;

                    foreach (var bacSi in danhSachBacSi)
                    {
                        // Đảm bảo không phân công quá 3 ca cho bác sĩ
                        if (lichLamViecMoi.Count(llv => llv.MANHANVIEN == bacSi.MANHANVIEN) >= 3)
                            continue;

                        // Lấy danh sách phòng còn trống trong ngày hiện tại
                        var phongConTrong = danhSachPhong
                            .Where(p => !lichLamViecMoi
                                .Any(llv => llv.NGAYLAM == ngay && llv.CALAM == ca && llv.PHONGLAMVIEC == p.MAPHONG))
                            .ToList();

                        // Nếu không còn phòng trống hoặc đã mở đủ 10 phòng, bỏ qua ca này
                        if (!phongConTrong.Any() || soPhongDaMoTrongNgay[ngay] >= 10)
                            continue;

                        // Chọn phòng ngẫu nhiên từ danh sách phòng còn trống
                        var phong = phongConTrong[random.Next(phongConTrong.Count)];

                        // Tạo bản ghi lịch làm việc mới
                        lichLamViecMoi.Add(new LICHLAMVIEC
                        {
                            MALICH = Guid.NewGuid().ToString().Substring(0, 10),
                            MANHANVIEN = bacSi.MANHANVIEN,
                            NGAYLAM = ngay,
                            PHONGLAMVIEC = phong.MAPHONG,
                            CALAM = ca
                        });

                        // Cập nhật số phòng đã mở trong ngày
                        soPhongDaMoTrongNgay[ngay]++;
                    }
                }
            }

            // Lưu lịch làm việc vào cơ sở dữ liệu
            _layDanhSach.LuuLichLamViec(lichLamViecMoi);
        }

        public void XoaLichLamViec()
        {
            _layDanhSach.XoaLichLamViec();
        }
    }
}
