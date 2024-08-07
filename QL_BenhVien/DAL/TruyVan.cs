using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Runtime.Remoting.Contexts;
using System.Text.RegularExpressions;

namespace DAL
{
    public class TruyVan
    {
        QLBVDataContext qlbv = new QLBVDataContext();
        private static string GetConnectionString()
        {
            return Properties.Settings.Default.QL_BENHVIENConnectionString;
        }
        public static DataTable GetData(string tableName)
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT * FROM {tableName}";

            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public List<TOATHUOC> loadToaThuoc()
        {
            return qlbv.TOATHUOCs.Select(tt => tt).ToList<TOATHUOC>();
        }

        public List<THUOC> loadThuoc()
        {
            return qlbv.THUOCs.Select(t => t).ToList<THUOC>();
        }

        public List<BENH> loadBenh()
        {
            return qlbv.BENHs.Select(b => b).ToList<BENH>();
        }

        public List<PHONGKHAM> loadPhongKham()
        {
            return qlbv.PHONGKHAMs.Select(pk => pk).ToList<PHONGKHAM>();
        }

        public PHIEUKHAM LoadPhieuKham(string maPhieuKham)
        {
            return qlbv.PHIEUKHAMs.FirstOrDefault(pk => pk.MAPHIEUKHAM == maPhieuKham);
        }

        public BENHNHAN LoadBenhNhan(string maBenhNhan)
        {
            return qlbv.BENHNHANs.FirstOrDefault(bn => bn.MABENHNHAN == maBenhNhan);
        }

        public List<BENHNHAN> loadDSBenhNhan()
        {
            return qlbv.BENHNHANs.Select(bn => bn).ToList<BENHNHAN>();
        }
        public List<NHANVIEN> loadNhanVien()
        {
            return qlbv.NHANVIENs.Select(nv => nv).ToList();
        }

        public List<string> loadChucVu()
        {
            return qlbv.NHANVIENs.Select(nv => nv.CHUCVU).Distinct().ToList();
        }

        //public List<string> loadLoaiTaiKhoan()
        //{
        //    return qlbv.TAIKHOANs.Select(tk=>tk.LOAITAIKHOAN).Distinct().ToList();
        //}

        public List<NHANVIEN> loadBacSi()
        {
            var danhSachBacSi = loadNhanVien()
                .Where(nv => nv.CHUCVU.Equals("Bác sĩ", StringComparison.OrdinalIgnoreCase))
                .ToList();

            return danhSachBacSi;
        }

        public List<LICHLAMVIEC> loadLichLamViec()
        {
            return qlbv.LICHLAMVIECs.Select(llv => llv).ToList<LICHLAMVIEC>();
        }
        public List<LICHLAMVIEC> layLichLamViecCuaBacSi(string maNhanVien)
        {
            return qlbv.LICHLAMVIECs.Where(llv => llv.MANHANVIEN == maNhanVien).ToList();
        }

        public string LayTenPhongLamViec(string maNhanVien)
        {
            var phongLamViec = qlbv.LICHLAMVIECs
                .Where(llv => llv.MANHANVIEN == maNhanVien)
                .Select(llv => llv.PHONGLAMVIEC)
                .FirstOrDefault();

            return phongLamViec;
        }
        public string ThemToaThuoc(TOATHUOC toaThuoc)
        {
            try
            {
                toaThuoc.MATOATHUOC = TaoMaTuDong(qlbv.TOATHUOCs.Max(t=>t.MATOATHUOC));
                qlbv.TOATHUOCs.InsertOnSubmit(toaThuoc);
                qlbv.SubmitChanges();

                return toaThuoc.MATOATHUOC;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void ThemChiTietToaThuoc(CHITIETTOATHUOC chiTietToaThuoc)
        {
            try
            {
                qlbv.CHITIETTOATHUOCs.InsertOnSubmit(chiTietToaThuoc);
                qlbv.SubmitChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void ThemChiTietChanDoan(CHITIETCHUANDOAN chiTietChanDoan)
        {
            try
            {
                qlbv.CHITIETCHUANDOANs.InsertOnSubmit(chiTietChanDoan);
                qlbv.SubmitChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private string TaoMaTuDong(string maCu)
        {
            // Sử dụng regex để tách phần chữ và phần số
            Regex regex = new Regex(@"([A-Za-z]+)(\d+)");
            Match match = regex.Match(maCu);

            if (match.Success)
            {
                string prefix = match.Groups[1].Value;
                int number = int.Parse(match.Groups[2].Value);

                // Tăng số lên 1
                number++;

                // Định dạng số với 4 chữ số (0 đệm phía trước nếu cần)
                string newNumber = number.ToString("D4");

                // Ghép prefix và newNumber
                return prefix + newNumber;
            }

            // Nếu mã không hợp lệ, trả về chuỗi gốc
            return maCu;
        }
        public List<PHIEUHEN> loadDSPhieuHen()
        {
            return qlbv.PHIEUHENs.Select(ph => ph).ToList<PHIEUHEN>();
        }
        public List<BENHNHAN> TimKiemBenhNhan(string keyword)
        {
            return qlbv.BENHNHANs
                .Where(bn => bn.TENBENHNHAN.Contains(keyword) || bn.SDT.Contains(keyword))
                .ToList();
        }

        public List<TAIKHOAN> loadTaiKhoan()
        {
            return qlbv.TAIKHOANs.Select(tk => tk).ToList<TAIKHOAN>();
        }

        public string layLoaiTaiKhoan(string username)
        {
            return qlbv.TAIKHOANs.Where(tk => tk.TENTAIKHOAN == username)
                .Select(tk => tk.LOAITAIKHOAN)
                .FirstOrDefault();

        }
        public string layMaNhanVien(string username)
        {
            return qlbv.TAIKHOANs.Where(tk=>tk.TENTAIKHOAN == username)
                .Select(tk=>tk.MANHANVIEN)
                .FirstOrDefault();
        }
        public int laySoLuongPhieuKham()
        {
            return qlbv.PHIEUKHAMs.Count();
        }

        public int laySoLuongBenhNhan()
        {
            return qlbv.BENHNHANs.Count();
        }

        //Thêm xóa sửa Nhân viên, Phòng khám, tài khoản

        //THÊM
        public void ThemNhanVien(NHANVIEN nv)
        {
            using (var qlbv = new QLBVDataContext())
            {
                qlbv.NHANVIENs.InsertOnSubmit(nv);
                qlbv.SubmitChanges();
            }
        }

        public void ThemPhongKham(PHONGKHAM pk)
        {
            using (var qlbv = new QLBVDataContext())
            {
                qlbv.PHONGKHAMs.InsertOnSubmit(pk);
                qlbv.SubmitChanges();
            }
        }
        public void ThemTaiKhoan(TAIKHOAN tk)
        {
            using (var qlbv = new QLBVDataContext())
            {
                qlbv.TAIKHOANs.InsertOnSubmit(tk);
                qlbv.SubmitChanges();
            }
        }

        //SỬA
        public void SuaNhanVien(NHANVIEN nhanVien)
        {
            using (var context = new QLBVDataContext())
            {
                var existingNhanVien = context.NHANVIENs.FirstOrDefault(nv => nv.MANHANVIEN == nhanVien.MANHANVIEN);
                if (existingNhanVien != null)
                {
                    // Update properties
                    existingNhanVien.TENNHANVIEN = nhanVien.TENNHANVIEN;
                    existingNhanVien.CHUCVU = nhanVien.CHUCVU;
                    existingNhanVien.GIOITINH = nhanVien.GIOITINH;
                    // Submit changes
                    context.SubmitChanges();
                }
            }
        }

        public void SuaPhongKham(PHONGKHAM phongKham)
        {
            using (var context = new QLBVDataContext())
            {
                var existingPhongKham = context.PHONGKHAMs.FirstOrDefault(pk => pk.MAPHONG == phongKham.MAPHONG);
                if (existingPhongKham != null)
                {
                    // Update properties
                    existingPhongKham.TENPHONG = phongKham.TENPHONG;
                    existingPhongKham.VITRI = phongKham.VITRI;
                    // Submit changes
                    context.SubmitChanges();
                }
            }
        }

        public void SuaTaiKhoan(TAIKHOAN taiKhoan)
        {
            using (var context = new QLBVDataContext())
            {
                var existingTaiKhoan = context.TAIKHOANs.FirstOrDefault(tk => tk.MATAIKHOAN == taiKhoan.MATAIKHOAN);
                if (existingTaiKhoan != null)
                {
                    // Update properties
                    existingTaiKhoan.TENTAIKHOAN = taiKhoan.TENTAIKHOAN;
                    existingTaiKhoan.MATKHAU = taiKhoan.MATKHAU;
                    existingTaiKhoan.LOAITAIKHOAN = taiKhoan.LOAITAIKHOAN;
                    existingTaiKhoan.MANHANVIEN = taiKhoan.MANHANVIEN;
                    // Submit changes
                    context.SubmitChanges();
                }
            }
        }

        //XÓA
        public void XoaNhanVien(string maNhanVien)
        {
            using (var context = new QLBVDataContext())
            {
                var nhanVien = context.NHANVIENs.FirstOrDefault(nv => nv.MANHANVIEN == maNhanVien);
                if (nhanVien != null)
                {
                    context.NHANVIENs.DeleteOnSubmit(nhanVien); 
                    context.SubmitChanges();
                }
            }
        }

        public void XoaPhongKham(string maPhongKham)
        {
            using (var context = new QLBVDataContext())
            {
                var phongKham = context.PHONGKHAMs.FirstOrDefault(nv => nv.MAPHONG == maPhongKham);
                if (phongKham != null)
                {
                    context.PHONGKHAMs.DeleteOnSubmit(phongKham);
                    context.SubmitChanges();
                }
            }
        }

        public void XoaTaiKhoan(string maTaiKhoan)
        {
            using (var context = new QLBVDataContext())
            {
                var taiKhoan = context.TAIKHOANs.FirstOrDefault(nv => nv.MATAIKHOAN == maTaiKhoan);
                if (taiKhoan != null)
                {
                    context.TAIKHOANs.DeleteOnSubmit(taiKhoan);
                    context.SubmitChanges();
                }
            }
        }

    }
}