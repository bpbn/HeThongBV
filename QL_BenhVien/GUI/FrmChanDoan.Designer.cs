
namespace GUI
{
    partial class FrmChanDoan
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
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.uC_ThongTinChanDoan1 = new ThietKeControl.UC_ThongTinChanDoan();
            this.uC_ThongTinKham1 = new ThietKeControl.UC_ThongTinKham();
            this.uC_ThongTinBenhNhan1 = new ThietKeControl.UC_ThongTinBenhNhan();
            this.SuspendLayout();
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThuc.Location = new System.Drawing.Point(1093, 930);
            this.btnKetThuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(155, 50);
            this.btnKetThuc.TabIndex = 3;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            // 
            // uC_ThongTinChanDoan1
            // 
            this.uC_ThongTinChanDoan1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_ThongTinChanDoan1.Location = new System.Drawing.Point(21, 465);
            this.uC_ThongTinChanDoan1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uC_ThongTinChanDoan1.Name = "uC_ThongTinChanDoan1";
            this.uC_ThongTinChanDoan1.Size = new System.Drawing.Size(1267, 492);
            this.uC_ThongTinChanDoan1.TabIndex = 2;
            // 
            // uC_ThongTinKham1
            // 
            this.uC_ThongTinKham1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_ThongTinKham1.Location = new System.Drawing.Point(21, 209);
            this.uC_ThongTinKham1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uC_ThongTinKham1.Name = "uC_ThongTinKham1";
            this.uC_ThongTinKham1.Size = new System.Drawing.Size(1267, 271);
            this.uC_ThongTinKham1.TabIndex = 1;
            // 
            // uC_ThongTinBenhNhan1
            // 
            this.uC_ThongTinBenhNhan1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_ThongTinBenhNhan1.Location = new System.Drawing.Point(21, 16);
            this.uC_ThongTinBenhNhan1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uC_ThongTinBenhNhan1.Name = "uC_ThongTinBenhNhan1";
            this.uC_ThongTinBenhNhan1.Size = new System.Drawing.Size(1267, 197);
            this.uC_ThongTinBenhNhan1.TabIndex = 0;
            // 
            // FrmChanDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 998);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.uC_ThongTinChanDoan1);
            this.Controls.Add(this.uC_ThongTinKham1);
            this.Controls.Add(this.uC_ThongTinBenhNhan1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmChanDoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChanDoan";
            this.ResumeLayout(false);

        }

        #endregion

        private ThietKeControl.UC_ThongTinBenhNhan uC_ThongTinBenhNhan1;
        private ThietKeControl.UC_ThongTinKham uC_ThongTinKham1;
        private ThietKeControl.UC_ThongTinChanDoan uC_ThongTinChanDoan1;
        private System.Windows.Forms.Button btnKetThuc;
    }
}