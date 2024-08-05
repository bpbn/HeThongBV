using BLL;
using DAL;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;
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
using iText.IO.Font;
using iText.Kernel.Font;

namespace GUI
{
    public partial class frmPhieuKham : Form
    {
        private XuLyTruyVan xlTruyVanBLL = new XuLyTruyVan();

        public frmPhieuKham(string maNhanVien)
        {
            InitializeComponent();
            this.txtMaNhanVien.Text = maNhanVien;
            
        }

        private void frmPhieuKham_Load(object sender, EventArgs e)
        {
            loadCboBacSi();
            loadBenhNhan();
            string maPKTiepTheo = xlTruyVanBLL.TaoMaPhieuKham();
            txtMaPhieuKham.Text = maPKTiepTheo;
            grbTTBN.Enabled = false;
        }


        private void loadCboBacSi()
        {
            var tenBS = xlTruyVanBLL.dsBacSiLamViec();
            cboBacSi.DataSource = tenBS;
        }

        private void loadBenhNhan()
        {
            DataTable data = XuLyTruyVan.GetTableData("BENHNHAN");
            dgvBenhNhan.DataSource = data;
        }

        private void cboBacSi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBacSi = cboBacSi.SelectedItem.ToString();
            var manv = xlTruyVanBLL.dsBacSi().FirstOrDefault(nv => nv.TENNHANVIEN == selectedBacSi)?.MANHANVIEN;

            if (manv != null)
            {
                var tenPhongLamViec = xlTruyVanBLL.LayTenPhongLamViec(manv);
                txtMaPhong.Text = tenPhongLamViec;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string benhNhan = txtTimKiem.Text;
            var kq = xlTruyVanBLL.TimKiemBenhNhan(benhNhan);
            dgvBenhNhan.DataSource = kq;

        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            grbTTBN.Enabled = true;

            string maBenhNhan = xlTruyVanBLL.TaoMaBenhNhan();
            txtMaBN.Text = maBenhNhan;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            DateTime ngaySinh = dtpNgaySinh.Value;
            string gioiTinh = "";
            if (rdoNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }
            string sdt = txtSDT.Text;
            string diaChi = txtDiaChi.Text;

            string maPhieuKham = txtMaPhieuKham.Text;
            string maBenhNhan = txtMaBN.Text;
            string tenBenhNhan = txtTenBN.Text;
            int tongTien = Convert.ToInt32(txtTongTien.Text); // Đảm bảo định dạng số chính xác
            string maPhong = txtMaPhong.Text;
            string maNhanVien = txtMaNhanVien.Text;
            string trangThaiHen;
            if (rdoCoHen.Checked)
            {
                trangThaiHen = "Có hẹn";
            }
            else
            {
                trangThaiHen = "Không có hẹn";
            }

            // Đường dẫn lưu file PDF
            string filePath = "D:\\PhieuKham.pdf";

            // Gọi hàm xuất dữ liệu ra PDF
            ExportPhieuKhamToPdf(maPhieuKham, tenBenhNhan, tongTien, maPhong, maNhanVien, filePath);

            if (grbTTBN.Enabled == true)
            {
                xlTruyVanBLL.SaveBenhNhan(maBenhNhan, tenBenhNhan, ngaySinh, gioiTinh, sdt, diaChi);
            }

            xlTruyVanBLL.SavePhieuKham(maPhieuKham, maBenhNhan, tongTien, maPhong, trangThaiHen, maNhanVien);

            MessageBox.Show("Thành công!");

            frmPhieuKham_Load(sender, e);

        }

        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvBenhNhan.Rows[e.RowIndex];
                txtMaBN.Text = selectedRow.Cells["MABENHNHAN"].Value.ToString();
                txtTenBN.Text = selectedRow.Cells["TENBENHNHAN"].Value.ToString();
                txtSDT.Text = selectedRow.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells["DIACHI"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(selectedRow.Cells["NGAYSINH"].Value);

                var gioiTinh = selectedRow.Cells["GIOITINH"].Value.ToString();
                rdoNam.Checked = gioiTinh.Equals("Nam", StringComparison.OrdinalIgnoreCase);
                rdoNu.Checked = gioiTinh.Equals("Nữ", StringComparison.OrdinalIgnoreCase);
            }


            string maBacSi;
            if (xlTruyVanBLL.KiemTraPhieuHen(txtTenBN.Text, DateTime.Now, out maBacSi))
            {
                // Nếu có phiếu hẹn, chọn radio button có hẹn
                rdoCoHen.Checked = true;

                // Lấy thông tin bác sĩ
                var bacSi = xlTruyVanBLL.LayThongTinBacSi(maBacSi);
                if (bacSi != null)
                {
                    cboBacSi.DataSource = new List<string> { bacSi.TENNHANVIEN };
                    cboBacSi.SelectedIndex = 0;

                    var tenPhongLamViec = xlTruyVanBLL.LayTenPhongLamViec(maBacSi);
                    txtMaPhong.Text = tenPhongLamViec;
                }
                else
                {
                    // Nếu không có phiếu hẹn, bỏ chọn radio button có hẹn và xóa tên bác sĩ
                    rdoKhongCoHen.Checked = true;
                    loadCboBacSi();
                    txtMaPhong.Text = string.Empty;
                }
            }
            else
            {
                // Nếu không có phiếu hẹn, bỏ chọn radio button có hẹn và xóa tên bác sĩ
                rdoKhongCoHen.Checked = true;
                loadCboBacSi();
                txtMaPhong.Text = string.Empty;
            }
        }

        public void ExportPhieuKhamToPdf(string maPhieuKham, string tenBenhNhan, decimal tongTien, string maPhong, string maNhanVien, string filePath)
        {
            using (var writer = new PdfWriter(filePath))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var document = new Document(pdf);

                    string fontPath = "C:\\WINDOWS\\FONTS\\TIMES.TTF";
                    PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);

                    // Thêm tiêu đề
                    document.Add(new Paragraph("Phiếu Khám")
                        .SetFontSize(18)
                        .SetBold()
                        .SetFont(font)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetMarginBottom(20));

                    // Thêm thông tin phiếu khám
                    document.Add(new Paragraph($"Mã Phiếu Khám: {maPhieuKham}")
                        .SetFont(font)
                        .SetFontSize(14)
                        .SetMarginBottom(10));

                    document.Add(new Paragraph($"Tên Bệnh Nhân: {tenBenhNhan}")
                        .SetFont(font)
                        .SetFontSize(14)
                        .SetMarginBottom(10));

                    document.Add(new Paragraph($"Tổng Tiền: {tongTien:C}") // Định dạng số tiền theo kiểu tiền tệ
                        .SetFont(font)
                        .SetFontSize(14)
                        .SetMarginBottom(10));

                    document.Add(new Paragraph($"Mã Phòng: {maPhong}")
                        .SetFont(font)
                        .SetFontSize(14)
                        .SetMarginBottom(10));

                    document.Add(new Paragraph($"Mã Nhân Viên: {maNhanVien}")
                        .SetFont(font)
                        .SetFontSize(14)
                        .SetMarginBottom(10));

                    // Thêm chân trang nếu cần
                    document.Add(new Paragraph("Đây là phiếu khám chính thức.")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFont(font)
                        .SetFontSize(10)
                        .SetMarginTop(20));

                    // Đóng tài liệu PDF
                    document.Close();
                }
            }
        }

        
    }
}
