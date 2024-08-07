using BLL;
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
using ThietKeControl;

namespace GUI
{
    public partial class frmChinhSua : Form
    {
        private XuLyTruyVan truyVanBLL = new XuLyTruyVan();
        private TruyVan truyVanDAL = new TruyVan();

        private uc_NhanVien ucNhanVien;
        private uc_PhongKham ucPhongKham;
        private uc_TaiKhoan ucTaiKhoan;

        private string bangHienTai;

        public frmChinhSua()
        {
            InitializeComponent();
            var dsNhanVien = truyVanBLL.dsNhanVien();
            dgv.DataSource = dsNhanVien;

            if (dgv.Columns["THONGTINBACSI"] != null)
                dgv.Columns["THONGTINBACSI"].Visible = false;

            ucNhanVien = new uc_NhanVien();
            ucPhongKham = new uc_PhongKham();
            ucTaiKhoan = new uc_TaiKhoan();

            pnMain.Controls.Add(ucNhanVien);
            pnMain.Controls.Add(ucPhongKham);
            pnMain.Controls.Add(ucTaiKhoan);

            ucNhanVien.Visible = true;
            ucPhongKham.Visible = false;
            ucTaiKhoan.Visible = false;

            ShowPanel("NHANVIEN");
        }

        private void loadData(string tableName)
        {
            switch (tableName)
            {
                case "NHANVIEN":
                    var dsNhanVien = truyVanBLL.dsNhanVien();
                    dgv.DataSource = dsNhanVien;
                    if (dgv.Columns["THONGTINBACSI"] != null)
                        dgv.Columns["THONGTINBACSI"].Visible = false;
                    bangHienTai = "NHANVIEN";
                    break;
                case "PHONGKHAM":
                    var dsPhongKham = truyVanBLL.dsPhongKham();
                    dgv.DataSource = dsPhongKham;
                    bangHienTai = "PHONGKHAM";
                    break;
                case "TAIKHOAN":
                    var dsTaiKhoan = truyVanBLL.dsTaiKhoan();
                    dgv.DataSource = dsTaiKhoan;
                    if (dgv.Columns["NHANVIEN"] != null)
                        dgv.Columns["NHANVIEN"].Visible = false;
                    bangHienTai = "TAIKHOAN";
                    break;
            }
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            loadData("NHANVIEN");

            ShowPanel("NHANVIEN");
        }

        private void btnPhongKham_Click(object sender, EventArgs e)
        {
            loadData("PHONGKHAM");

            ShowPanel("PHONGKHAM");
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            loadData("TAIKHOAN");

            ShowPanel("TAIKHOAN");
        }

        private void ShowPanel(string panelName)
        {
            ucNhanVien.Visible = panelName == "NHANVIEN";
            ucPhongKham.Visible = panelName == "PHONGKHAM";
            ucTaiKhoan.Visible = panelName == "TAIKHOAN";
            pnMain.Visible = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ucNhanVien.Visible)
            {
                var nhanVien = ucNhanVien.layTTNV();
                truyVanDAL.ThemNhanVien(nhanVien);

                loadData("NHANVIEN");
                ShowPanel("NHANVIEN");
            }
            else if (ucPhongKham.Visible)
            {
                var phongKham = ucPhongKham.layTTPK();
                truyVanDAL.ThemPhongKham(phongKham);

                loadData("PHONGKHAM");
                ShowPanel("PHONGKHAM");
            }
            else if (ucTaiKhoan.Visible)
            {
                var taiKhoan = ucTaiKhoan.layTTTK();
                truyVanDAL.ThemTaiKhoan(taiKhoan);

                loadData("TAIKHOAN");
                ShowPanel("TAIKHOAN");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ucNhanVien.Visible)
            {
                var nhanVien = ucNhanVien.layTTNV();
                truyVanDAL.SuaNhanVien(nhanVien);

                loadData("NHANVIEN");
                ShowPanel("NHANVIEN");
            }
            else if (ucPhongKham.Visible)
            {
                var phongKham = ucPhongKham.layTTPK();
                truyVanDAL.SuaPhongKham(phongKham);

                loadData("PHONGKHAM");
                ShowPanel("PHONGKHAM");
            }
            else if (ucTaiKhoan.Visible)
            {
                var taiKhoan = ucTaiKhoan.layTTTK();
                truyVanDAL.SuaTaiKhoan(taiKhoan);

                loadData("TAIKHOAN");
                ShowPanel("TAIKHOAN");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ucNhanVien.Visible)
            {
                var maNhanVien = ucNhanVien.layMaNhanVien();
                truyVanDAL.XoaNhanVien(maNhanVien);

                loadData("NHANVIEN");
                ShowPanel("NHANVIEN");
            }
            else if (ucPhongKham.Visible)
            {
                var maPhongKham = ucPhongKham.layMaPhongKham();
                truyVanDAL.XoaPhongKham(maPhongKham);

                loadData("PHONGKHAM");
                ShowPanel("PHONGKHAM");
            }
            else if (ucTaiKhoan.Visible)
            {
                var maTaiKhoan = ucTaiKhoan.layMaTaiKhoan();
                truyVanDAL.XoaTaiKhoan(maTaiKhoan);

                loadData("TAIKHOAN");
                ShowPanel("TAIKHOAN");
            }
            
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgv.Rows[e.RowIndex];
                switch (bangHienTai)
                {
                    case "NHANVIEN":
                        string maNhanVien = selectedRow.Cells["MANHANVIEN"].Value.ToString();
                        string tenNhanVien = selectedRow.Cells["TENNHANVIEN"].Value.ToString();
                        string chucVu = selectedRow.Cells["CHUCVU"].Value.ToString();
                        string gioiTinh = selectedRow.Cells["GIOITINH"].Value.ToString();
                        ucNhanVien.UpdateControls(maNhanVien, tenNhanVien, chucVu, gioiTinh);
                        break;

                    case "PHONGKHAM":
                        string maPhongKham = selectedRow.Cells["MAPHONG"].Value.ToString();
                        string tenPhongKham = selectedRow.Cells["TENPHONG"].Value.ToString();
                        string viTri = selectedRow.Cells["VITRI"].Value.ToString();
                        ucPhongKham.UpdateControls(maPhongKham, tenPhongKham, viTri);
                        break;

                    case "TAIKHOAN":
                        string maTaiKhoan = selectedRow.Cells["MATAIKHOAN"].Value.ToString();
                        string tenTaiKhoan = selectedRow.Cells["TENTAIKHOAN"].Value.ToString();
                        string matKhau = selectedRow.Cells["MATKHAU"].Value.ToString();
                        string loaiTaiKhoan = selectedRow.Cells["LOAITAIKHOAN"].Value.ToString();
                        string maNV = selectedRow.Cells["MANHANVIEN"].Value.ToString();
                        ucTaiKhoan.UpdateControls(maTaiKhoan, tenTaiKhoan, matKhau, loaiTaiKhoan, maNV);
                        break;
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            var dsNhanVien = truyVanBLL.dsNhanVien();
            dgv.DataSource = dsNhanVien;

            if (dgv.Columns["THONGTINBACSI"] != null)
                dgv.Columns["THONGTINBACSI"].Visible = false;

            ucNhanVien = new uc_NhanVien();
            ucPhongKham = new uc_PhongKham();
            ucTaiKhoan = new uc_TaiKhoan();

            pnMain.Controls.Add(ucNhanVien);
            pnMain.Controls.Add(ucPhongKham);
            pnMain.Controls.Add(ucTaiKhoan);

            ucNhanVien.Visible = true;
            ucPhongKham.Visible = false;
            ucTaiKhoan.Visible = false;

            ShowPanel("NHANVIEN");
        }
    }
}
