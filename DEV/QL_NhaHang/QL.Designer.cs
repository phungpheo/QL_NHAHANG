namespace QL_NhaHang
{
    partial class QL
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
            this.bt_DoanhThu = new System.Windows.Forms.Button();
            this.bt_KH = new System.Windows.Forms.Button();
            this.bt_MonAn = new System.Windows.Forms.Button();
            this.bt_NV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_DoanhThu
            // 
            this.bt_DoanhThu.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_DoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DoanhThu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_DoanhThu.Location = new System.Drawing.Point(56, 363);
            this.bt_DoanhThu.Name = "bt_DoanhThu";
            this.bt_DoanhThu.Size = new System.Drawing.Size(111, 67);
            this.bt_DoanhThu.TabIndex = 15;
            this.bt_DoanhThu.Text = "Doanh thu";
            this.bt_DoanhThu.UseVisualStyleBackColor = false;
            // 
            // bt_KH
            // 
            this.bt_KH.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_KH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_KH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_KH.Location = new System.Drawing.Point(56, 253);
            this.bt_KH.Name = "bt_KH";
            this.bt_KH.Size = new System.Drawing.Size(111, 67);
            this.bt_KH.TabIndex = 14;
            this.bt_KH.Text = "Khách Hàng";
            this.bt_KH.UseVisualStyleBackColor = false;
            // 
            // bt_MonAn
            // 
            this.bt_MonAn.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_MonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_MonAn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_MonAn.Location = new System.Drawing.Point(56, 146);
            this.bt_MonAn.Name = "bt_MonAn";
            this.bt_MonAn.Size = new System.Drawing.Size(111, 67);
            this.bt_MonAn.TabIndex = 13;
            this.bt_MonAn.Text = "Món ăn";
            this.bt_MonAn.UseVisualStyleBackColor = false;
            // 
            // bt_NV
            // 
            this.bt_NV.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_NV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_NV.Location = new System.Drawing.Point(56, 41);
            this.bt_NV.Name = "bt_NV";
            this.bt_NV.Size = new System.Drawing.Size(111, 67);
            this.bt_NV.TabIndex = 12;
            this.bt_NV.Text = "Nhân viên";
            this.bt_NV.UseVisualStyleBackColor = false;
            // 
            // QL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 536);
            this.Controls.Add(this.bt_DoanhThu);
            this.Controls.Add(this.bt_KH);
            this.Controls.Add(this.bt_MonAn);
            this.Controls.Add(this.bt_NV);
            this.Name = "QL";
            this.Text = "QL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_DoanhThu;
        private System.Windows.Forms.Button bt_KH;
        private System.Windows.Forms.Button bt_MonAn;
        private System.Windows.Forms.Button bt_NV;
    }
}