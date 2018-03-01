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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_DoanhThu
            // 
            this.bt_DoanhThu.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_DoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DoanhThu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_DoanhThu.Location = new System.Drawing.Point(56, 408);
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
            this.bt_KH.Location = new System.Drawing.Point(56, 312);
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
            this.bt_MonAn.Location = new System.Drawing.Point(56, 208);
            this.bt_MonAn.Name = "bt_MonAn";
            this.bt_MonAn.Size = new System.Drawing.Size(111, 67);
            this.bt_MonAn.TabIndex = 13;
            this.bt_MonAn.Text = "Món ăn";
            this.bt_MonAn.UseVisualStyleBackColor = false;
            this.bt_MonAn.Click += new System.EventHandler(this.bt_MonAn_Click);
            // 
            // bt_NV
            // 
            this.bt_NV.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_NV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_NV.Location = new System.Drawing.Point(56, 94);
            this.bt_NV.Name = "bt_NV";
            this.bt_NV.Size = new System.Drawing.Size(111, 67);
            this.bt_NV.TabIndex = 12;
            this.bt_NV.Text = "Người dùng";
            this.bt_NV.UseVisualStyleBackColor = false;
            this.bt_NV.Click += new System.EventHandler(this.bt_NV_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(236, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(670, 465);
            this.dataGridView1.TabIndex = 16;
            // 
            // QL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(935, 536);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_DoanhThu);
            this.Controls.Add(this.bt_KH);
            this.Controls.Add(this.bt_MonAn);
            this.Controls.Add(this.bt_NV);
            this.Name = "QL";
            this.Text = "Quản Lý";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_DoanhThu;
        private System.Windows.Forms.Button bt_KH;
        private System.Windows.Forms.Button bt_MonAn;
        private System.Windows.Forms.Button bt_NV;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}