
namespace ThietKeControl
{
    partial class UC_ThongTinKham
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
            this.grbTTK = new System.Windows.Forms.GroupBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtMaPK = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaBS = new System.Windows.Forms.ComboBox();
            this.grbTTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTTK
            // 
            this.grbTTK.Controls.Add(this.cboMaBS);
            this.grbTTK.Controls.Add(this.txtMaPhong);
            this.grbTTK.Controls.Add(this.txtMaPK);
            this.grbTTK.Controls.Add(this.txtNgayLap);
            this.grbTTK.Controls.Add(this.label3);
            this.grbTTK.Controls.Add(this.label4);
            this.grbTTK.Controls.Add(this.label2);
            this.grbTTK.Controls.Add(this.label1);
            this.grbTTK.Location = new System.Drawing.Point(3, 3);
            this.grbTTK.Name = "grbTTK";
            this.grbTTK.Size = new System.Drawing.Size(944, 119);
            this.grbTTK.TabIndex = 0;
            this.grbTTK.TabStop = false;
            this.grbTTK.Text = "Thông tin khám";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Enabled = false;
            this.txtMaPhong.Location = new System.Drawing.Point(661, 27);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(256, 30);
            this.txtMaPhong.TabIndex = 41;
            // 
            // txtMaPK
            // 
            this.txtMaPK.Location = new System.Drawing.Point(177, 27);
            this.txtMaPK.Name = "txtMaPK";
            this.txtMaPK.Size = new System.Drawing.Size(256, 30);
            this.txtMaPK.TabIndex = 40;
            this.txtMaPK.TextChanged += new System.EventHandler(this.txtMaPK_TextChanged);
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Enabled = false;
            this.txtNgayLap.Location = new System.Drawing.Point(661, 75);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(256, 30);
            this.txtNgayLap.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 37;
            this.label3.Text = "Ngày khám";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 36;
            this.label4.Text = "Phòng khám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mã bác sĩ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mã phiếu khám";
            // 
            // cboMaBS
            // 
            this.cboMaBS.FormattingEnabled = true;
            this.cboMaBS.Location = new System.Drawing.Point(177, 75);
            this.cboMaBS.Name = "cboMaBS";
            this.cboMaBS.Size = new System.Drawing.Size(256, 30);
            this.cboMaBS.TabIndex = 42;
            // 
            // UC_ThongTinKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbTTK);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ThongTinKham";
            this.Size = new System.Drawing.Size(950, 124);
            this.grbTTK.ResumeLayout(false);
            this.grbTTK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTTK;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtMaPK;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaBS;
    }
}
