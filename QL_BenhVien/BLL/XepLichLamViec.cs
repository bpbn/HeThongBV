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
            //_layDanhSach.XoaLichLamViec();

            var lichLamViecMoi = new List<LICHLAMVIEC>();
            var random = new Random();

            // Lấy danh sách các ngày trong tuần
            List<DateTime> danhSachNgay = new List<DateTime>();
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    continue;

                danhSachNgay.Add(date);
            }

            foreach (var ca in new[] { "Sáng", "Chiều" })
            {
                var soPhongDaMoTrongNgay = new Dictionary<DateTime, int>();

                foreach (var ngay in danhSachNgay)
                {
                    soPhongDaMoTrongNgay[ngay] = 0;

                    foreach (var phong in danhSachPhong)
                    {
                        var bacSiCoThePhanCong = danhSachBacSi
                            .Where(b => lichLamViecMoi.Count(llv => llv.MANHANVIEN == b.MANHANVIEN) < 3)
                            .ToList();

                        if (!bacSiCoThePhanCong.Any() || soPhongDaMoTrongNgay[ngay] >= 10)
                            continue;

                        var bacSi = bacSiCoThePhanCong[random.Next(bacSiCoThePhanCong.Count)];

                        lichLamViecMoi.Add(new LICHLAMVIEC
                        {
                            MALICH = Guid.NewGuid().ToString().Substring(0, 10),
                            MANHANVIEN = bacSi.MANHANVIEN,
                            NGAYLAM = ngay,
                            PHONGLAMVIEC = phong.MAPHONG,
                            CALAM = ca
                        });

                        soPhongDaMoTrongNgay[ngay]++;
                    }
                }
            }

            _layDanhSach.LuuLichLamViec(lichLamViecMoi);
        }

        public void XoaLichLamViec()
        {
            _layDanhSach.XoaLichLamViec();
        }

    }
}
