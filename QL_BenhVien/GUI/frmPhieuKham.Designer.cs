﻿namespace GUI
{
    partial class frmPhieuKham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.grbTTBN = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnXuat = new System.Windows.Forms.Button();
            this.cboBacSi = new System.Windows.Forms.ComboBox();
            this.rdoKhongCoHen = new System.Windows.Forms.RadioButton();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.txtPhieuKham = new System.Windows.Forms.TextBox();
            this.rdoCoHen = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBenhNhan = new ThietKeControl.UC_DanhSach();
            this.grbTTBN.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(148, 10);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(122, 28);
            this.txtMaNhanVien.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(118, 41);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(239, 28);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnTaoMoi.BackgroundImage = global::GUI.Properties.Resources.icons8_add_64;
            this.btnTaoMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTaoMoi.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoi.Location = new System.Drawing.Point(378, 36);
            this.btnTaoMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(38, 41);
            this.btnTaoMoi.TabIndex = 5;
            this.btnTaoMoi.UseVisualStyleBackColor = false;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // grbTTBN
            // 
            this.grbTTBN.Controls.Add(this.dtpNgaySinh);
            this.grbTTBN.Controls.Add(this.txtDiaChi);
            this.grbTTBN.Controls.Add(this.label6);
            this.grbTTBN.Controls.Add(this.label7);
            this.grbTTBN.Controls.Add(this.rdoNu);
            this.grbTTBN.Controls.Add(this.txtSDT);
            this.grbTTBN.Controls.Add(this.rdoNam);
            this.grbTTBN.Controls.Add(this.label8);
            this.grbTTBN.Controls.Add(this.label9);
            this.grbTTBN.Controls.Add(this.txtTenBN);
            this.grbTTBN.Controls.Add(this.label10);
            this.grbTTBN.Controls.Add(this.txtMaBN);
            this.grbTTBN.Controls.Add(this.label11);
            this.grbTTBN.Enabled = false;
            this.grbTTBN.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTTBN.Location = new System.Drawing.Point(436, 12);
            this.grbTTBN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbTTBN.Name = "grbTTBN";
            this.grbTTBN.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbTTBN.Size = new System.Drawing.Size(759, 125);
            this.grbTTBN.TabIndex = 17;
            this.grbTTBN.TabStop = false;
            this.grbTTBN.Text = "Thông tin bệnh nhân";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(148, 62);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(121, 28);
            this.dtpNgaySinh.TabIndex = 24;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(121, 95);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(564, 28);
            this.txtDiaChi.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "SDT";
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNu.Location = new System.Drawing.Point(707, 63);
            this.rdoNu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(50, 24);
            this.rdoNu.TabIndex = 3;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(361, 62);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(177, 28);
            this.txtSDT.TabIndex = 19;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNam.Location = new System.Drawing.Point(639, 63);
            this.rdoNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(62, 24);
            this.rdoNam.TabIndex = 3;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(564, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Giới tính";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ngày sinh";
            // 
            // txtTenBN
            // 
            this.txtTenBN.Location = new System.Drawing.Point(441, 28);
            this.txtTenBN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(243, 28);
            this.txtTenBN.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Tên bệnh nhân";
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(148, 28);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(121, 28);
            this.txtMaBN.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Mã bệnh nhân";
            // 
            // btnXuat
            // 
            this.btnXuat.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Location = new System.Drawing.Point(1020, 159);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(92, 44);
            this.btnXuat.TabIndex = 16;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // cboBacSi
            // 
            this.cboBacSi.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBacSi.FormattingEnabled = true;
            this.cboBacSi.Location = new System.Drawing.Point(542, 180);
            this.cboBacSi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboBacSi.Name = "cboBacSi";
            this.cboBacSi.Size = new System.Drawing.Size(174, 28);
            this.cboBacSi.TabIndex = 15;
            // 
            // rdoKhongCoHen
            // 
            this.rdoKhongCoHen.AutoSize = true;
            this.rdoKhongCoHen.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoKhongCoHen.Location = new System.Drawing.Point(870, 143);
            this.rdoKhongCoHen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoKhongCoHen.Name = "rdoKhongCoHen";
            this.rdoKhongCoHen.Size = new System.Drawing.Size(128, 24);
            this.rdoKhongCoHen.TabIndex = 13;
            this.rdoKhongCoHen.TabStop = true;
            this.rdoKhongCoHen.Text = "Không có hẹn";
            this.rdoKhongCoHen.UseVisualStyleBackColor = true;
            // 
            // txtPhong
            // 
            this.txtPhong.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhong.Location = new System.Drawing.Point(827, 180);
            this.txtPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(90, 28);
            this.txtPhong.TabIndex = 11;
            // 
            // txtPhieuKham
            // 
            this.txtPhieuKham.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhieuKham.Location = new System.Drawing.Point(566, 142);
            this.txtPhieuKham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhieuKham.Name = "txtPhieuKham";
            this.txtPhieuKham.Size = new System.Drawing.Size(122, 28);
            this.txtPhieuKham.TabIndex = 12;
            // 
            // rdoCoHen
            // 
            this.rdoCoHen.AutoSize = true;
            this.rdoCoHen.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCoHen.Location = new System.Drawing.Point(780, 143);
            this.rdoCoHen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoCoHen.Name = "rdoCoHen";
            this.rdoCoHen.Size = new System.Drawing.Size(79, 24);
            this.rdoCoHen.TabIndex = 14;
            this.rdoCoHen.TabStop = true;
            this.rdoCoHen.Text = "Có hẹn";
            this.rdoCoHen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bác sĩ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(764, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã phiếu khám";
            // 
            // dgvBenhNhan
            // 
            this.dgvBenhNhan.Location = new System.Drawing.Point(31, 81);
            this.dgvBenhNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            this.dgvBenhNhan.Size = new System.Drawing.Size(401, 288);
            this.dgvBenhNhan.TabIndex = 7;
            this.dgvBenhNhan.RowSelected += new System.EventHandler<System.Data.DataRow>(this.dgvBenhNhan_RowSelected);
            // 
            // frmPhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 381);
            this.Controls.Add(this.grbTTBN);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.cboBacSi);
            this.Controls.Add(this.rdoKhongCoHen);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.txtPhieuKham);
            this.Controls.Add(this.rdoCoHen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBenhNhan);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPhieuKham";
            this.Text = "frmPhieuKham";
            this.Load += new System.EventHandler(this.frmPhieuKham_Load);
            this.grbTTBN.ResumeLayout(false);
            this.grbTTBN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTaoMoi;
        private ThietKeControl.UC_DanhSach dgvBenhNhan;
        private System.Windows.Forms.GroupBox grbTTBN;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.ComboBox cboBacSi;
        private System.Windows.Forms.RadioButton rdoKhongCoHen;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.TextBox txtPhieuKham;
        private System.Windows.Forms.RadioButton rdoCoHen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}