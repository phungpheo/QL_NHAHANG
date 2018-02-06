using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaHang
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button26_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) this.Close();
            else return;
        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void bt_QuanLy_Click(object sender, EventArgs e)
        {
            QL ql = new QL();
            this.Hide();
            ql.Show();
           /* InitializeComponent();
            QL_NhaHang.View.uctQL uc = new View.uctQL();
            this.Controls.Add(uc);
            */
        }

        private void bt_DangXuat_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.Show();
        }

        private void A1_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            this.Hide();
            od.Show();
        }

        private void D4_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            this.Hide();
            od.Show();
        }

        private void D5_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            this.Hide();
            od.Show();
        }

        private void D2_Click(object sender, EventArgs e)
        {

        }

        private void D3_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            this.Hide();
            od.Show();

        }

        private void D1_Click(object sender, EventArgs e)
        {

        }

        private void C4_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            this.Hide();
            od.Show();
        }

        private void C5_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            this.Hide();
            od.Show();
        }

        private void C2_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            this.Hide();
            od.Show();

        }

        private void C3_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            this.Hide();
            od.Show();
        }

        private void C1_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            this.Hide();
            od.Show();
        }

        private void B4_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            this.Hide();
            od.Show();
        }

        private void B5_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            this.Hide();
            od.Show();
        }

        private void B2_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            this.Hide();
            od.Show();
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            this.Hide();
            od.Show();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            this.Hide();
            od.Show();
        }

        private void A4_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            this.Hide();
            od.Show();
        }

        private void A5_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            this.Hide();
            od.Show();
        }

        private void A2_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            this.Hide();
            od.Show();
        }

        private void A3_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            this.Hide();
            od.Show();
        }

        private void bt_TachBan_Click(object sender, EventArgs e)
        {
            frDatBan db = new frDatBan();
            db.Show();
        }
    }
}
