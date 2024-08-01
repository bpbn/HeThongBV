using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LayDanhSach
    {
        QLBVDataContext qlbv = new QLBVDataContext();

        public List<NHANVIEN> LayDanhSachBacSi()
        {
            return (from nv in qlbv.NHANVIENs where nv.CHUCVU == "Bác sĩ" select nv).ToList();
        }

        public List<PHONGKHAM> LayDanhSachPhong()
        {
            return qlbv.PHONGKHAMs.ToList();
        }

        public void LuuLichLamViec(List<LICHLAMVIEC> llvList)
        {
            qlbv.LICHLAMVIECs.InsertAllOnSubmit(llvList);
            qlbv.SubmitChanges();
        }
    }
}
