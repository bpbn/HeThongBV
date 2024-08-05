using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
    public class LuuDuLieu
    {
        private QLBVDataContext dbContext = new QLBVDataContext();

        public void SavePhieuKham(string maPhieuKham, string maBenhNhan, int tongTien, string maPhong, string trangThaiHen, string maNhanVien)
        {
            // Tạo đối tượng phiếu khám
            var phieuKham = new PHIEUKHAM
            {
                MAPHIEUKHAM = maPhieuKham,
                MABENHNHAN = maBenhNhan,
                TONGTIEN = tongTien,
                MAPHONG = maPhong,
                TRANGTHAIHEN = trangThaiHen,
                MANHANVIEN = maNhanVien
            };

            // Thêm phiếu khám vào DbSet và lưu thay đổi
            dbContext.PHIEUKHAMs.InsertOnSubmit(phieuKham);

            // Lưu thay đổi vào cơ sở dữ liệu
            dbContext.SubmitChanges();
        }

        public void SaveBenhNhan(string maBenhNhan, string tenBenhNhan, DateTime ngaySinh, string gioiTinh, string sdt, string diaChi)
        {
            var benhNhan = new BENHNHAN
            {
                MABENHNHAN = maBenhNhan,
                TENBENHNHAN = tenBenhNhan,
                NGAYSINH = ngaySinh,
                GIOITINH = gioiTinh,
                SDT = sdt,
                DIACHI = diaChi
            };

            dbContext.BENHNHANs.InsertOnSubmit(benhNhan);
            dbContext.SubmitChanges();
        }
    }
}
