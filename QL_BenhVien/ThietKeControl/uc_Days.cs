using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControl
{
    public partial class uc_Days : UserControl
    {
        private string phongLamViec;
        public uc_Days()
        {
            InitializeComponent();
        }

        public void days(int numday)
        {
            lbDays.Text = numday.ToString();
        }

        public void SetLichLamViec(LICHLAMVIEC lich)
        {
            if (lich != null)
            {
                lbPhong.Visible = true;
                // Đặt màu nền thành màu xanh
                this.BackColor = Color.LightGreen;

                phongLamViec = lich.PHONGLAMVIEC;

                if (lich.CALAM == "Sáng")
                {
                    lbPhong.Text = $"Sáng - {lich.PHONGLAMVIEC}";
                }
                else if (lich.CALAM == "Chiều")
                {
                    lbPhong.Text = $"Chiều - {lich.PHONGLAMVIEC}";
                }
            }
        }
    }
}
