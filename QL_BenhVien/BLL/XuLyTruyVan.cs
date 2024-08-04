using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class XuLyTruyVan
    {
        public static DataTable GetTableData(string tableName)
        {
            return TruyVan.GetData(tableName);
        }

        private TruyVan dal = new TruyVan();

        public List<THUOC> dsThuoc()
        {
            return dal.loadThuoc();
        }

        public List<BENH> dsBenh()
        {
            return dal.loadBenh();
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

        public List<BENHNHAN> TimKiemBenhNhan(string benhNhan)
        {
            var danhSachBenhNhan = dal.loadDSBenhNhan();
            return danhSachBenhNhan
                .Where(bn => bn.TENBENHNHAN.Contains(benhNhan) ||
                             bn.SDT.Contains(benhNhan))
                .ToList();
        }
    }
}
