﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Runtime.Remoting.Contexts;

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
        public string LayTenPhongLamViec(string maNhanVien)
        {
            var phongLamViec = qlbv.LICHLAMVIECs
                .Where(llv => llv.MANHANVIEN == maNhanVien)
                .Select(llv => llv.PHONGLAMVIEC)
                .FirstOrDefault();

            return phongLamViec;
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