using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BLL
{
    public class XuLyTruyVan
    {
        public static DataTable GetTableData(string tableName)
        {
            return TruyVan.GetData(tableName);
        }

        private TruyVan dal = new TruyVan();
        private LuuDuLieu luuDataBLL = new LuuDuLieu();

        public List<THUOC> dsThuoc()
        {
            return dal.loadThuoc();
        }

        public List<BENH> dsBenh()
        {
            return dal.loadBenh();
        }

        public List<NHANVIEN> dsNhanVien()
        {
            return dal.loadNhanVien();
        }

        public List<PHONGKHAM> dsPhongKham()
        {
            return dal.loadPhongKham();
        }

        public List<TAIKHOAN> dsTaiKhoan()
        {
            return dal.loadTaiKhoan();
        }

        public List<string> dsChucVu()
        {
            return dal.loadChucVu();
        }

        public List<string> dsLoaiTaiKhoan()
        {
            return dal.loadTaiKhoan().Select(tk => tk.LOAITAIKHOAN).Distinct().ToList();
        }

        public PHIEUKHAM LayThongTinPhieuKham(string maPhieuKham)
        {
            return dal.LoadPhieuKham(maPhieuKham);
        }

        public BENHNHAN LayThongTinBenhNhan(string maBenhNhan)
        {
            return dal.LoadBenhNhan(maBenhNhan);
        }

        public List<string> dsBacSiLamViec()
        {
            var tenBS = dal.loadLichLamViec()
                .Select(llv => llv.MANHANVIEN)
                .Distinct()
                .Join(dal.loadNhanVien(), manv => manv, nv => nv.MANHANVIEN, (manv, nv) => nv.TENNHANVIEN).ToList();
            return tenBS;
        }


        public string LayTenPhongLamViec(string maNhanVien)
        {
            return dal.LayTenPhongLamViec(maNhanVien);
        }
        public List<NHANVIEN> dsBacSi()
        {
            return dal.loadBacSi();
        }
        public List<BENHNHAN> TimKiemBenhNhan(string keyword)
        {
            return dal.TimKiemBenhNhan(keyword);
        }
        public string TaoToaThuoc(TOATHUOC toaThuoc)
        {
            return dal.ThemToaThuoc(toaThuoc);
        }

        public void ThemChiTietToaThuoc(CHITIETTOATHUOC chiTietToaThuoc)
        {
            dal.ThemChiTietToaThuoc(chiTietToaThuoc);
        }

        public void ThemChiTietChanDoan(CHITIETCHUANDOAN chiTietChanDoan)
        {
            dal.ThemChiTietChanDoan(chiTietChanDoan);
        }
        public bool KiemTraPhieuHen(string tenBenhNhan, DateTime ngayHienTai, out string maBacSi)
        {
            var phieuHen = dal.loadDSPhieuHen()
                .FirstOrDefault(ph => ph.TENBENHNHAN.Equals(tenBenhNhan, StringComparison.OrdinalIgnoreCase)
                                    && ph.NGAYKHAM.HasValue && ph.NGAYKHAM.Value.Date == ngayHienTai.Date);

            if (phieuHen != null)
            {
                maBacSi = phieuHen.MANHANVIEN;
                return true;
            }

            maBacSi = null;
            return false;
        }
        public NHANVIEN LayThongTinBacSi(string maBacSi)
        {
            var danhSachBacSi = dal.loadBacSi();
            return danhSachBacSi.FirstOrDefault(nv => nv.MANHANVIEN.Equals(maBacSi, StringComparison.OrdinalIgnoreCase));
        }
        public void SavePhieuKham(string maPhieuKham, string maBenhNhan, int tongTien, string maPhong, string trangThaiHen, string maNhanVien)
        {
            luuDataBLL.SavePhieuKham(maPhieuKham, maBenhNhan, tongTien, maPhong, trangThaiHen, maNhanVien);
        }

        public string LayLoaiTaiKhoan(string username)
        {
            return dal.layLoaiTaiKhoan(username);
        }
        public string LayMaNhanVien(string username)
        {
            return dal.layMaNhanVien(username);
        }
        public string TaoMaPhieuKham()
        {
            int count = dal.laySoLuongPhieuKham();
            count++;
            string maMoi = "PK0" + count.ToString("D3");
            return maMoi;
        }

        public string TaoMaBenhNhan()
        {
            int count = dal.laySoLuongBenhNhan();
            count++;
            string maMoi = "BN0" + count.ToString("D3");
            return maMoi;
        }
        public void SaveBenhNhan(string maBenhNhan, string tenBenhNhan, DateTime ngaySinh, string gioiTinh, string sdt, string diaChi)
        {
            luuDataBLL.SaveBenhNhan(maBenhNhan, tenBenhNhan, ngaySinh, gioiTinh, sdt, diaChi);
        }

        public string TaoMaNhanVien()
        {
            int count = dal.loadNhanVien().Count();
            count++;
            string maMoi = "NV0" + count.ToString("D3");
            return maMoi;
        }

        public string TaoMaTaiKhoan()
        {
            int count = dal.loadPhongKham().Count();
            count++;
            string maMoi = "TK0" + count.ToString("D3");
            return maMoi;
        }
    }
}