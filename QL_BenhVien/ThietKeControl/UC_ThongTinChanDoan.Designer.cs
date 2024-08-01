
namespace ThietKeControl
{
    partial class UC_ThongTinChanDoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbTTKham = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.cboBenh = new System.Windows.Forms.ComboBox();
            this.cboThuoc = new System.Windows.Forms.ComboBox();
            this.dgvCTTT = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.grbTTKham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTTT)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTTKham
            // 
            this.grbTTKham.Controls.Add(this.label4);
            this.grbTTKham.Controls.Add(this.dgvCTTT);
            this.grbTTKham.Controls.Add(this.cboThuoc);
            this.grbTTKham.Controls.Add(this.cboBenh);
            this.grbTTKham.Controls.Add(this.txtTrieuChung);
            this.grbTTKham.Controls.Add(this.label3);
            this.grbTTKham.Controls.Add(this.label2);
            this.grbTTKham.Controls.Add(this.label1);
            this.grbTTKham.Location = new System.Drawing.Point(4, 4);
            this.grbTTKham.Name = "grbTTKham";
            this.grbTTKham.Size = new System.Drawing.Size(943, 361);
            this.grbTTKham.TabIndex = 0;
            this.grbTTKham.TabStop = false;
            this.grbTTKham.Text = "Thông tin chẩn đoán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chẩn đoán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Triệu chứng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kê toa thuốc";
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Location = new System.Drawing.Point(161, 30);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(752, 26);
            this.txtTrieuChung.TabIndex = 3;
            // 
            // cboBenh
            // 
            this.cboBenh.FormattingEnabled = true;
            this.cboBenh.Location = new System.Drawing.Point(161, 71);
            this.cboBenh.Name = "cboBenh";
            this.cboBenh.Size = new System.Drawing.Size(752, 27);
            this.cboBenh.TabIndex = 4;
            // 
            // cboThuoc
            // 
            this.cboThuoc.FormattingEnabled = true;
            this.cboThuoc.Location = new System.Drawing.Point(161, 113);
            this.cboThuoc.Name = "cboThuoc";
            this.cboThuoc.Size = new System.Drawing.Size(752, 27);
            this.cboThuoc.TabIndex = 5;
            // 
            // dgvCTTT
            // 
            this.dgvCTTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTTT.Location = new System.Drawing.Point(57, 187);
            this.dgvCTTT.Name = "dgvCTTT";
            this.dgvCTTT.Size = new System.Drawing.Size(856, 159);
            this.dgvCTTT.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Toa thuốc";
            // 
            // UC_ThongTinChanDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbTTKham);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ThongTinChanDoan";
            this.Size = new System.Drawing.Size(950, 368);
            this.grbTTKham.ResumeLayout(false);
            this.grbTTKham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTTKham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCTTT;
        private System.Windows.Forms.ComboBox cboThuoc;
        private System.Windows.Forms.ComboBox cboBenh;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Label label3;
    }
}
