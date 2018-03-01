namespace QL_NhaHang
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Huy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.qL_KHACHSANDataSet = new QL_NhaHang.QL_KHACHSANDataSet();
            this.qLKHACHSANDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLKHACHSANDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_KHACHSANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKHACHSANDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKHACHSANDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.qLKHACHSANDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 478);
            this.dataGridView1.TabIndex = 16;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.DataSource = this.qLKHACHSANDataSetBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(482, 121);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(302, 478);
            this.dataGridView2.TabIndex = 17;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(94, 63);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 48);
            this.button13.TabIndex = 18;
            this.button13.Text = "Đồ ăn";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(240, 63);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(104, 48);
            this.button14.TabIndex = 19;
            this.button14.Text = "Đồ uống";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(521, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Danh sách đã chọn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.bt_Save);
            this.groupBox1.Controls.Add(this.bt_Huy);
            this.groupBox1.Location = new System.Drawing.Point(800, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 549);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Chọn số lượng món ăn";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button12.Location = new System.Drawing.Point(11, 315);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(74, 67);
            this.button12.TabIndex = 29;
            this.button12.Text = "Xóa";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button11.Location = new System.Drawing.Point(182, 315);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(73, 67);
            this.button11.TabIndex = 28;
            this.button11.Text = "Lưu";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button8.Location = new System.Drawing.Point(182, 72);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(73, 67);
            this.button8.TabIndex = 27;
            this.button8.Text = "9";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button9.Location = new System.Drawing.Point(98, 72);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(73, 67);
            this.button9.TabIndex = 26;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button10.Location = new System.Drawing.Point(11, 72);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(74, 67);
            this.button10.TabIndex = 25;
            this.button10.Text = "7";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button5.Location = new System.Drawing.Point(182, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 67);
            this.button5.TabIndex = 24;
            this.button5.Text = "6";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button6.Location = new System.Drawing.Point(98, 153);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 67);
            this.button6.TabIndex = 23;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button7.Location = new System.Drawing.Point(11, 153);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 67);
            this.button7.TabIndex = 22;
            this.button7.Text = "4";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.Location = new System.Drawing.Point(182, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 67);
            this.button4.TabIndex = 21;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Location = new System.Drawing.Point(98, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 67);
            this.button3.TabIndex = 20;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Location = new System.Drawing.Point(11, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 67);
            this.button2.TabIndex = 19;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(98, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 67);
            this.button1.TabIndex = 18;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bt_Save
            // 
            this.bt_Save.BackColor = System.Drawing.SystemColors.Info;
            this.bt_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Save.BackgroundImage")));
            this.bt_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Save.Location = new System.Drawing.Point(12, 429);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(113, 109);
            this.bt_Save.TabIndex = 17;
            this.bt_Save.UseVisualStyleBackColor = false;
            // 
            // bt_Huy
            // 
            this.bt_Huy.BackColor = System.Drawing.SystemColors.Info;
            this.bt_Huy.BackgroundImage = global::QL_NhaHang.Properties.Resources.Fxemoji_u274C_svg;
            this.bt_Huy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Huy.Location = new System.Drawing.Point(143, 429);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(113, 109);
            this.bt_Huy.TabIndex = 16;
            this.bt_Huy.UseVisualStyleBackColor = false;
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(10, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 45);
            this.panel2.TabIndex = 22;
            // 
            // qL_KHACHSANDataSet
            // 
            this.qL_KHACHSANDataSet.DataSetName = "QL_KHACHSANDataSet";
            this.qL_KHACHSANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLKHACHSANDataSetBindingSource
            // 
            this.qLKHACHSANDataSetBindingSource.DataSource = this.qL_KHACHSANDataSet;
            this.qLKHACHSANDataSetBindingSource.Position = 0;
            // 
            // qLKHACHSANDataSetBindingSource1
            // 
            this.qLKHACHSANDataSetBindingSource1.DataSource = this.qL_KHACHSANDataSet;
            this.qLKHACHSANDataSetBindingSource1.Position = 0;
            // 
            // Order
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1070, 624);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Order";
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_KHACHSANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKHACHSANDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKHACHSANDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button bt_Huy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource qLKHACHSANDataSetBindingSource;
        private QL_KHACHSANDataSet qL_KHACHSANDataSet;
        private System.Windows.Forms.BindingSource qLKHACHSANDataSetBindingSource1;
    }
}