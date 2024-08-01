using BLL;
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
    public partial class frmDanhSach : Form
    {
        public frmDanhSach()
        {
            InitializeComponent();
        }

        private void loadData(string tableName)
        {
            DataTable data = XuLyTruyVan.GetTableData(tableName);
            dgvDanhSach.SetDataSource(data);
        }

        private void frmDanhSach_Load(object sender, EventArgs e)
        {
            loadData("TOATHUOC");
        }

        private void btnToaThuoc_Click(object sender, EventArgs e)
        {
            loadData("TOATHUOC");
        }

        private void btnBenhNhan_Click(object sender, EventArgs e)
        {
            loadData("BENHNHAN");
        }

        private void btnPhieuHen_Click(object sender, EventArgs e)
        {
            loadData("PHIEUHEN");
        }

        private void btnLichLamViec_Click(object sender, EventArgs e)
        {

        }
    }
}
