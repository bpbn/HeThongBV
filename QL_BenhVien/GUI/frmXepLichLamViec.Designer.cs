namespace GUI
{
    partial class frmXepLichLamViec
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
            this.btnXepLich = new System.Windows.Forms.Button();
            this.dgvLichLamViec = new ThietKeControl.UC_DanhSach();
            this.btnXoaLich = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXepLich
            // 
            this.btnXepLich.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXepLich.Location = new System.Drawing.Point(11, 11);
            this.btnXepLich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXepLich.Name = "btnXepLich";
            this.btnXepLich.Size = new System.Drawing.Size(70, 39);
            this.btnXepLich.TabIndex = 0;
            this.btnXepLich.Text = "Xếp";
            this.btnXepLich.UseVisualStyleBackColor = true;
            this.btnXepLich.Click += new System.EventHandler(this.btnXepLich_Click);
            // 
            // dgvLichLamViec
            // 
            this.dgvLichLamViec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvLichLamViec.Location = new System.Drawing.Point(11, 54);
            this.dgvLichLamViec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLichLamViec.Name = "dgvLichLamViec";
            this.dgvLichLamViec.Size = new System.Drawing.Size(608, 545);
            this.dgvLichLamViec.TabIndex = 3;
            // 
            // btnXoaLich
            // 
            this.btnXoaLich.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLich.Location = new System.Drawing.Point(85, 11);
            this.btnXoaLich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaLich.Name = "btnXoaLich";
            this.btnXoaLich.Size = new System.Drawing.Size(70, 39);
            this.btnXoaLich.TabIndex = 0;
            this.btnXoaLich.Text = "Xóa";
            this.btnXoaLich.UseVisualStyleBackColor = true;
            this.btnXoaLich.Click += new System.EventHandler(this.btnXoaLich_Click);
            // 
            // frmXepLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 610);
            this.Controls.Add(this.dgvLichLamViec);
            this.Controls.Add(this.btnXoaLich);
            this.Controls.Add(this.btnXepLich);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmXepLichLamViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXepLichLamViec";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXepLich;
        private ThietKeControl.UC_DanhSach dgvLichLamViec;
        private System.Windows.Forms.Button btnXoaLich;
    }
}