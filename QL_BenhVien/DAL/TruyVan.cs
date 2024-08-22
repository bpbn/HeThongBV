using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
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
            return qlbv.NHANVIENs.Select(nv => nv).ToList<NHANVIEN>();
        }

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
    }
}