namespace GUI
{
    partial class frmMain
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
            this.btnLichLamViec = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXemDanhSach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLichLamViec
            // 
            this.btnLichLamViec.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichLamViec.Image = global::GUI.Properties.Resources.icons8_calendar_64;
            this.btnLichLamViec.Location = new System.Drawing.Point(787, 52);
            this.btnLichLamViec.Name = "btnLichLamViec";
            this.btnLichLamViec.Size = new System.Drawing.Size(175, 139);
            this.btnLichLamViec.TabIndex = 0;
            this.btnLichLamViec.Text = "Xếp lịch làm việc";
            this.btnLichLamViec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLichLamViec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLichLamViec.UseVisualStyleBackColor = true;
            this.btnLichLamViec.Click += new System.EventHandler(this.btnLichLamViec_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Image = global::GUI.Properties.Resources.icons8_statistic_64;
            this.btnThongKe.Location = new System.Drawing.Point(546, 52);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(175, 139);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Image = global::GUI.Properties.Resources.icons8_edit_64;
            this.btnChinhSua.Location = new System.Drawing.Point(305, 52);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(175, 139);
            this.btnChinhSua.TabIndex = 0;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChinhSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChinhSua.UseVisualStyleBackColor = true;
            // 
            // btnXemDanhSach
            // 
            this.btnXemDanhSach.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDanhSach.Image = global::GUI.Properties.Resources.icons8_list_64;
            this.btnXemDanhSach.Location = new System.Drawing.Point(64, 52);
            this.btnXemDanhSach.Name = "btnXemDanhSach";
            this.btnXemDanhSach.Size = new System.Drawing.Size(175, 139);
            this.btnXemDanhSach.TabIndex = 0;
            this.btnXemDanhSach.Text = "Xem danh sách";
            this.btnXemDanhSach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXemDanhSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXemDanhSach.UseVisualStyleBackColor = true;
            this.btnXemDanhSach.Click += new System.EventHandler(this.btnXemDanhSach_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 240);
            this.Controls.Add(this.btnLichLamViec);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnXemDanhSach);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXemDanhSach;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnLichLamViec;
    }
}