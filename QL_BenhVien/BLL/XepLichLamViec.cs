using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class XepLichLamViec
    {
        private LayDanhSach dsDAL = new LayDanhSach();

        public void XepLichLamViecChoBacSi(DateTime startDate, DateTime endDate)
        {
            List<NHANVIEN> danhSachBacSi = dsDAL.LayDanhSachBacSi();
            List<PHONGKHAM> danhSachPhong = dsDAL.LayDanhSachPhong();
            List<string> danhSachCaLam = new List<string> { "Sáng", "Chiều" };

            List<DateTime> danhSachNgayLam = new List<DateTime>();
            for(DateTime date = startDate; date <= endDate;  date = date.AddDays(1))
            {
                danhSachNgayLam.Add(date);
            }

            Dictionary<DateTime, Dictionary<string, Dictionary<string, string>>> lichLamViec = new Dictionary<DateTime, Dictionary<string, Dictionary<string, string>>>();

            foreach (var ngay in danhSachNgayLam)
            {
                lichLamViec[ngay] = new Dictionary<string, Dictionary<string, string>>();
                foreach (var ca in danhSachCaLam)
                {
                    lichLamViec[ngay][ca] = new Dictionary<string, string>();
                    foreach (var phong in danhSachPhong)
                    {
                        lichLamViec[ngay][ca][phong.MAPHONG] = null; // Khởi tạo tất cả các vị trí với giá trị null (chưa có bác sĩ nào được gán)
                    }
                }
            }

            foreach (var ngay in danhSachNgayLam)
            {
                foreach (var ca in danhSachCaLam)
                {
                    foreach (var phong in danhSachPhong)
                    {
                        HashSet<string> bacSiDaDuocGan = new HashSet<string>();
                        foreach (var bacSi in danhSachBacSi)
                        {
                            if (!bacSiDaDuocGan.Contains(bacSi.MANHANVIEN) && lichLamViec[ngay][ca][phong.MAPHONG] == null)
                            {
                                lichLamViec[ngay][ca][phong.MAPHONG] = bacSi.MANHANVIEN; // Gán bác sĩ vào ca và phòng này
                                bacSiDaDuocGan.Add(bacSi.MANHANVIEN);
                            }
                        }
                    }
                }
            }

            List<LICHLAMVIEC> lichLamViecList = new List<LICHLAMVIEC>();
            int maLichCounter = 1;

            foreach (var ngay in lichLamViec.Keys)
            {
                foreach (var ca in lichLamViec[ngay].Keys)
                {
                    foreach (var phong in lichLamViec[ngay][ca].Keys)
                    {
                        string maNhanVien = lichLamViec[ngay][ca][phong];
                        if (maNhanVien != null) // Chỉ lưu các lịch làm việc đã được gán bác sĩ
                        {
                            lichLamViecList.Add(new LICHLAMVIEC
                            {
                                MALICH = maLichCounter++.ToString(),
                                MANHANVIEN = maNhanVien,
                                NGAYLAM = ngay,
                                CALAM = ca,
                                PHONGLAMVIEC = phong
                            });
                        }
                    }
                }
            }

            dsDAL.LuuLichLamViec(lichLamViecList);
        }
    }
}
