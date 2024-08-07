namespace GUI
{
    partial class frmQuanLi
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXemDanhSach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLichLamViec
            // 
            this.btnLichLamViec.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichLamViec.Image = global::GUI.Properties.Resources.icons8_calendar_64;
            this.btnLichLamViec.Location = new System.Drawing.Point(657, 49);
            this.btnLichLamViec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLichLamViec.Name = "btnLichLamViec";
            this.btnLichLamViec.Size = new System.Drawing.Size(175, 139);
            this.btnLichLamViec.TabIndex = 0;
            this.btnLichLamViec.Text = "Xếp lịch làm việc";
            this.btnLichLamViec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLichLamViec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLichLamViec.UseVisualStyleBackColor = true;
            this.btnLichLamViec.Click += new System.EventHandler(this.btnLichLamViec_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = global::GUI.Properties.Resources.icons8_back_40;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 69);
            this.btnBack.TabIndex = 0;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Image = global::GUI.Properties.Resources.icons8_edit_64;
            this.btnChinhSua.Location = new System.Drawing.Point(165, 49);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(175, 139);
            this.btnChinhSua.TabIndex = 0;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChinhSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnXemDanhSach
            // 
            this.btnXemDanhSach.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDanhSach.Image = global::GUI.Properties.Resources.icons8_list_64;
            this.btnXemDanhSach.Location = new System.Drawing.Point(411, 49);
            this.btnXemDanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemDanhSach.Name = "btnXemDanhSach";
            this.btnXemDanhSach.Size = new System.Drawing.Size(175, 139);
            this.btnXemDanhSach.TabIndex = 0;
            this.btnXemDanhSach.Text = "Xem danh sách";
            this.btnXemDanhSach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXemDanhSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXemDanhSach.UseVisualStyleBackColor = true;
            this.btnXemDanhSach.Click += new System.EventHandler(this.btnXemDanhSach_Click);
            // 
            // frmQuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 240);
            this.Controls.Add(this.btnLichLamViec);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnXemDanhSach);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục quản lý";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXemDanhSach;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLichLamViec;
    }
}