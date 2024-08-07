using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControl
{
    public partial class uc_PhongKham : UserControl
    {
        public uc_PhongKham()
        {
            InitializeComponent();
        }

        public PHONGKHAM layTTPK()
        {
            return new PHONGKHAM
            {
                MAPHONG = txtMaPhong.Text,
                TENPHONG = txtTenPhong.Text,
                VITRI = txtViTriPhong.Text
            };

        }

        public void UpdateControls(string ma, string ten, string viTri)
        {
            txtMaPhong.Text = ma;
            txtTenPhong.Text = ten;
            txtViTriPhong.Text = viTri;
        }

        public string layMaPhongKham()
        {
            return txtMaPhong.Text;
        }
    }
}
