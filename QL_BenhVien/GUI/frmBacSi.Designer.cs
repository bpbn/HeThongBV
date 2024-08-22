namespace GUI
{
    partial class frmBacSi
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLichLamViec = new System.Windows.Forms.Button();
            this.btnChanDoan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = global::GUI.Properties.Resources.icons8_back_40;
            this.btnBack.Location = new System.Drawing.Point(7, 5);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 56);
            this.btnBack.TabIndex = 1;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLichLamViec
            // 
            this.btnLichLamViec.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichLamViec.Image = global::GUI.Properties.Resources.icons8_calendar_641;
            this.btnLichLamViec.Location = new System.Drawing.Point(122, 35);
            this.btnLichLamViec.Margin = new System.Windows.Forms.Padding(2);
            this.btnLichLamViec.Name = "btnLichLamViec";
            this.btnLichLamViec.Size = new System.Drawing.Size(131, 113);
            this.btnLichLamViec.TabIndex = 2;
            this.btnLichLamViec.Text = "Lịch làm việc";
            this.btnLichLamViec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLichLamViec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLichLamViec.UseVisualStyleBackColor = true;
            this.btnLichLamViec.Click += new System.EventHandler(this.btnLichLamViec_Click);
            // 
            // btnChanDoan
            // 
            this.btnChanDoan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChanDoan.Image = global::GUI.Properties.Resources.icons8_prescription_64;
            this.btnChanDoan.Location = new System.Drawing.Point(306, 35);
            this.btnChanDoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnChanDoan.Name = "btnChanDoan";
            this.btnChanDoan.Size = new System.Drawing.Size(131, 113);
            this.btnChanDoan.TabIndex = 3;
            this.btnChanDoan.Text = "Chẩn đoán";
            this.btnChanDoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChanDoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChanDoan.UseVisualStyleBackColor = true;
            this.btnChanDoan.Click += new System.EventHandler(this.btnChanDoan_Click);
            // 
            // frmBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 196);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLichLamViec);
            this.Controls.Add(this.btnChanDoan);
            this.Name = "frmBacSi";
            this.Text = "frmBacSi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLichLamViec;
        private System.Windows.Forms.Button btnChanDoan;
    }
}