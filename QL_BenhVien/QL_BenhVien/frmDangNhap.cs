using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BenhVien
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            XuLyDangNhap CauHinh = new XuLyDangNhap();
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

            var kq = CauHinh.Check_User(txtTenDangNhap.Text.Trim(), txtMatKhau.Text.Trim());
            if(kq == LoginResult.Invalid)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng, xin vui lòng kiểm tra lại!", "Thông báo");
            }
            else if(kq == LoginResult.Disabled)
            {
                MessageBox.Show("Tài khoản đã bị vô hiệu hóa", "Thông báo");
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                frmMain frm = new frmMain();
                this.Hide();
                frm.Show();
            }
        }

    }
}
