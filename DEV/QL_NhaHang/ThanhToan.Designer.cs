namespace QL_NhaHang
{
    partial class ThanhToan
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
            this.panelNameUser = new System.Windows.Forms.Panel();
            this.lb_Time = new System.Windows.Forms.Label();
            this.lb_Quyen = new System.Windows.Forms.Label();
            this.lb_TenUser = new System.Windows.Forms.Label();
            this.panelNameUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNameUser
            // 
            this.panelNameUser.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelNameUser.Controls.Add(this.lb_Time);
            this.panelNameUser.Controls.Add(this.lb_Quyen);
            this.panelNameUser.Controls.Add(this.lb_TenUser);
            this.panelNameUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNameUser.Location = new System.Drawing.Point(0, 0);
            this.panelNameUser.Name = "panelNameUser";
            this.panelNameUser.Size = new System.Drawing.Size(815, 45);
            this.panelNameUser.TabIndex = 14;
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Time.Location = new System.Drawing.Point(954, 9);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(0, 24);
            this.lb_Time.TabIndex = 2;
            // 
            // lb_Quyen
            // 
            this.lb_Quyen.AutoSize = true;
            this.lb_Quyen.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Quyen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Quyen.Location = new System.Drawing.Point(171, 9);
            this.lb_Quyen.Name = "lb_Quyen";
            this.lb_Quyen.Size = new System.Drawing.Size(0, 24);
            this.lb_Quyen.TabIndex = 1;
            // 
            // lb_TenUser
            // 
            this.lb_TenUser.AutoSize = true;
            this.lb_TenUser.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_TenUser.Location = new System.Drawing.Point(292, 9);
            this.lb_TenUser.Name = "lb_TenUser";
            this.lb_TenUser.Size = new System.Drawing.Size(0, 24);
            this.lb_TenUser.TabIndex = 0;
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 524);
            this.Controls.Add(this.panelNameUser);
            this.Name = "ThanhToan";
            this.Text = "ThanhToan";
            this.panelNameUser.ResumeLayout(false);
            this.panelNameUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNameUser;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Label lb_Quyen;
        private System.Windows.Forms.Label lb_TenUser;
    }
}