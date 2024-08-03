using System;
using System.Windows.Forms;
using DAL; 

namespace ThietKeControl
{
    public partial class UC_ThongTinBenhNhan : UserControl
    {
        public UC_ThongTinBenhNhan()
        {
            InitializeComponent();
        }

        public void SetBenhNhan(DAL.BENHNHAN benhNhan)
        {
            if (benhNhan != null)
            {
                txtMaBN.Text = benhNhan.MABENHNHAN;
                txtTenBN.Text = benhNhan.TENBENHNHAN;

                if (benhNhan.NGAYSINH != null)
                {
                    DateTime ngaySinh = (DateTime)benhNhan.NGAYSINH;
                    txtNgaySinh.Text = ngaySinh.ToString("yyyy-MM-dd");
                }
                else
                {
                    txtNgaySinh.Text = string.Empty;
                }

                txtGioiTinh.Text = benhNhan.GIOITINH;
                txtSDT.Text = benhNhan.SDT;
                txtDiaChi.Text = benhNhan.DIACHI;
            }
        }

    }
}
