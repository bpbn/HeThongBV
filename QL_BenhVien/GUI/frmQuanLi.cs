﻿using System;
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
    public partial class frmQuanLi : Form
    {
        public frmQuanLi()
        {
            InitializeComponent();
        }

        private void btnXemDanhSach_Click(object sender, EventArgs e)
        {
            frmDanhSach frmDanhSach = new frmDanhSach();
            frmDanhSach.Show();
        }

        private void btnLichLamViec_Click(object sender, EventArgs e)
        {
            frmXepLichLamViec frmXepLichLamViec = new frmXepLichLamViec();
            frmXepLichLamViec.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            this.Close();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            frmChinhSua frm = new frmChinhSua();
            frm.Show();
        }
    }
}
