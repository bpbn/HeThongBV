namespace GUI
{
    partial class frmDanhSach
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
            this.btnPhieuHen = new System.Windows.Forms.Button();
            this.btnBenhNhan = new System.Windows.Forms.Button();
            this.btnToaThuoc = new System.Windows.Forms.Button();
            this.dgvDanhSach = new ThietKeControl.UC_DanhSach();
            this.SuspendLayout();
            // 
            // btnPhieuHen
            // 
            this.btnPhieuHen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuHen.Image = global::GUI.Properties.Resources.icons8_appointments_50;
            this.btnPhieuHen.Location = new System.Drawing.Point(386, 12);
            this.btnPhieuHen.Name = "btnPhieuHen";
            this.btnPhieuHen.Size = new System.Drawing.Size(146, 127);
            this.btnPhieuHen.TabIndex = 1;
            this.btnPhieuHen.Text = "Phiếu hẹn";
            this.btnPhieuHen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPhieuHen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPhieuHen.UseVisualStyleBackColor = true;
            this.btnPhieuHen.Click += new System.EventHandler(this.btnPhieuHen_Click);
            // 
            // btnBenhNhan
            // 
            this.btnBenhNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBenhNhan.Image = global::GUI.Properties.Resources.icons8_patient_50;
            this.btnBenhNhan.Location = new System.Drawing.Point(199, 12);
            this.btnBenhNhan.Name = "btnBenhNhan";
            this.btnBenhNhan.Size = new System.Drawing.Size(146, 127);
            this.btnBenhNhan.TabIndex = 1;
            this.btnBenhNhan.Text = "Bệnh nhân";
            this.btnBenhNhan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBenhNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBenhNhan.UseVisualStyleBackColor = true;
            this.btnBenhNhan.Click += new System.EventHandler(this.btnBenhNhan_Click);
            // 
            // btnToaThuoc
            // 
            this.btnToaThuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToaThuoc.Image = global::GUI.Properties.Resources.icons8_prescription_50;
            this.btnToaThuoc.Location = new System.Drawing.Point(12, 12);
            this.btnToaThuoc.Name = "btnToaThuoc";
            this.btnToaThuoc.Size = new System.Drawing.Size(146, 127);
            this.btnToaThuoc.TabIndex = 1;
            this.btnToaThuoc.Text = "Toa thuốc";
            this.btnToaThuoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnToaThuoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnToaThuoc.UseVisualStyleBackColor = true;
            this.btnToaThuoc.Click += new System.EventHandler(this.btnToaThuoc_Click);
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSach.Location = new System.Drawing.Point(12, 162);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.Size = new System.Drawing.Size(1213, 546);
            this.dgvDanhSach.TabIndex = 0;
            // 
            // frmDanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 720);
            this.Controls.Add(this.btnPhieuHen);
            this.Controls.Add(this.btnBenhNhan);
            this.Controls.Add(this.btnToaThuoc);
            this.Controls.Add(this.dgvDanhSach);
            this.Name = "frmDanhSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDanhSach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDanhSach_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ThietKeControl.UC_DanhSach dgvDanhSach;
        private System.Windows.Forms.Button btnToaThuoc;
        private System.Windows.Forms.Button btnBenhNhan;
        private System.Windows.Forms.Button btnPhieuHen;
    }
}