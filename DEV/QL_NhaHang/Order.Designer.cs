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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Save
            // 
            this.bt_Save.BackColor = System.Drawing.SystemColors.Info;
            this.bt_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Save.BackgroundImage")));
            this.bt_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Save.Location = new System.Drawing.Point(801, 497);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(120, 115);
            this.bt_Save.TabIndex = 2;
            this.bt_Save.UseVisualStyleBackColor = false;
            // 
            // bt_Huy
            // 
            this.bt_Huy.BackColor = System.Drawing.SystemColors.Info;
            this.bt_Huy.BackgroundImage = global::QL_NhaHang.Properties.Resources.Fxemoji_u274C_svg;
            this.bt_Huy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Huy.Location = new System.Drawing.Point(932, 497);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(120, 115);
            this.bt_Huy.TabIndex = 1;
            this.bt_Huy.UseVisualStyleBackColor = false;
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1064, 624);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.bt_Huy);
            this.Name = "Order";
            this.Text = "Order";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Huy;
        private System.Windows.Forms.Button bt_Save;
    }
}