using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        XuLyDangNhap login = new XuLyDangNhap();
        XuLyTruyVan truyVanBLL = new XuLyTruyVan();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + label1.Text.ToLower());
                this.txtTenDangNhap.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtMatKhau.Text))
            {
                MessageBox.Show("Không được bỏ trống" + label2.Text.ToLower());
                this.txtMatKhau.Focus();
                return;
            }

            var kq = login.Check_User(txtTenDangNhap.Text.Trim(), txtMatKhau.Text.Trim());
            if (kq == LoginResult.Invalid)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng, xin vui lòng kiểm tra lại!", "Thông báo");
            }
            else if (kq == LoginResult.Disabled)
            {
                MessageBox.Show("Tài khoản đã bị vô hiệu hóa", "Thông báo");
            }
            else
            {
                string role = truyVanBLL.LayLoaiTaiKhoan(txtTenDangNhap.Text);
                string maNhanVien = truyVanBLL.LayMaNhanVien(txtTenDangNhap.Text);

                Form form;
                switch(role)
                {
                    case "Quản lý":
                        form = new frmQuanLi();
                        break;
                    case "Thu ngân":
                        form = new frmPhieuKham(maNhanVien);
                        break;
                    case "Bác sĩ":
                        form = new frmBacSi(maNhanVien);
                        break;
                    default:
                        MessageBox.Show("Không xác định được quyền của người dùng!", "Thông báo");
                        return;
                }    
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                this.Hide();
                form.Show();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
