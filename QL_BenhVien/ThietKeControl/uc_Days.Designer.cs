namespace ThietKeControl
{
    partial class uc_Days
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
            this.lbDays = new System.Windows.Forms.Label();
            this.lbPhong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDays
            // 
            this.lbDays.AutoSize = true;
            this.lbDays.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDays.Location = new System.Drawing.Point(2, 7);
            this.lbDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(27, 20);
            this.lbDays.TabIndex = 0;
            this.lbDays.Text = "00";
            // 
            // lbPhong
            // 
            this.lbPhong.AutoSize = true;
            this.lbPhong.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhong.Location = new System.Drawing.Point(2, 50);
            this.lbPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(27, 20);
            this.lbPhong.TabIndex = 0;
            this.lbPhong.Text = "00";
            this.lbPhong.Visible = false;
            // 
            // uc_Days
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lbPhong);
            this.Controls.Add(this.lbDays);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "uc_Days";
            this.Size = new System.Drawing.Size(100, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.Label lbPhong;
    }
}
