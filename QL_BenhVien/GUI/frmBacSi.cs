using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmBacSi : Form
    {
        private string maBacSi;
        public frmBacSi(string maBacSi)
        {
            InitializeComponent();
            this.maBacSi = maBacSi;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            this.Close();
        }

        private void btnLichLamViec_Click(object sender, EventArgs e)
        {
            frmLichLamViec frmLichLamViec = new frmLichLamViec(maBacSi);
            frmLichLamViec.Show();
        }

        private void btnChanDoan_Click(object sender, EventArgs e)
        {
            FrmChanDoan frmChanDoan = new FrmChanDoan();
            frmChanDoan.Show();
        }
    }
}
