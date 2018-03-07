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
            this.components = new System.ComponentModel.Container();
            this.bt_DoanhThu = new System.Windows.Forms.Button();
            this.bt_KH = new System.Windows.Forms.Button();
            this.bt_MonAn = new System.Windows.Forms.Button();
            this.bt_NV = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qL_NHAHANGDataSet = new QL_NhaHang.QL_NHAHANGDataSet();
            this.qLNHAHANGDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phanquyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nsdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfgsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHAHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHAHANGDataSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.ten,
            this.Pass,
            this.Phanquyen});
            this.dataGridView1.DataSource = this.qLNHAHANGDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(220, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 468);
            this.dataGridView1.TabIndex = 16;
            // 
            // qL_NHAHANGDataSet
            // 
            this.qL_NHAHANGDataSet.DataSetName = "QL_NHAHANGDataSet";
            this.qL_NHAHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLNHAHANGDataSetBindingSource
            // 
            this.qLNHAHANGDataSetBindingSource.DataSource = this.qL_NHAHANGDataSet;
            this.qLNHAHANGDataSetBindingSource.Position = 0;
            // 
            // Ma
            // 
            this.Ma.HeaderText = "Mã User";
            this.Ma.Name = "Ma";
            // 
            // ten
            // 
            this.ten.HeaderText = "Tên User";
            this.ten.Name = "ten";
            // 
            // Pass
            // 
            this.Pass.HeaderText = "Password";
            this.Pass.Name = "Pass";
            // 
            // Phanquyen
            // 
            this.Phanquyen.HeaderText = "Phân Quyền";
            this.Phanquyen.Name = "Phanquyen";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "open";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nsdfToolStripMenuItem,
            this.dfgsToolStripMenuItem,
            this.dfgToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "edit";
            // 
            // nsdfToolStripMenuItem
            // 
            this.nsdfToolStripMenuItem.Name = "nsdfToolStripMenuItem";
            this.nsdfToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nsdfToolStripMenuItem.Text = "nsdf";
            // 
            // dfgsToolStripMenuItem
            // 
            this.dfgsToolStripMenuItem.Name = "dfgsToolStripMenuItem";
            this.dfgsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dfgsToolStripMenuItem.Text = "dfgs";
            // 
            // dfgToolStripMenuItem
            // 
            this.dfgToolStripMenuItem.Name = "dfgToolStripMenuItem";
            this.dfgToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dfgToolStripMenuItem.Text = "dfg";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.helpToolStripMenuItem.Text = "help";
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QL";
            this.Text = "Quản Lý";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHAHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHAHANGDataSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_DoanhThu;
        private System.Windows.Forms.Button bt_KH;
        private System.Windows.Forms.Button bt_MonAn;
        private System.Windows.Forms.Button bt_NV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phanquyen;
        private System.Windows.Forms.BindingSource qLNHAHANGDataSetBindingSource;
        private QL_NHAHANGDataSet qL_NHAHANGDataSet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nsdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dfgsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dfgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}