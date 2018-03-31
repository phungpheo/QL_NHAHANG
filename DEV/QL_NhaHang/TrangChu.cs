using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_NhaHang    
{
    public partial class TrangChu : Form
    {
        public static string Quyenhan = "";
        public static string Tenuser = ""; 
        public static string Mauser = "";
      
        
        public TrangChu()
        {
            InitializeComponent();

            Connect con = new Connect();
            SqlDataReader read1 = con.ExcuteReader("select Ten from NguoiDung where Ma ='" + Mauser + "' ");
            while (read1.Read())
            {
                Tenuser = read1["Ten"].ToString();
            }

          //hiển thị tên ng dùng trên title
            lb_Quyen.Text = Quyenhan+": "+Tenuser+".  Chọn bàn để Order !";
            lb_Time.Text = DateTime.Now.ToLongTimeString();


            if (Quyenhan == "Nhân viên") 
            {
                bt_QuanLy.Enabled = false;
                bt_ThanhToan.Enabled = false;
            }
            if (Quyenhan == "Tổ trưởng")
            {
               
                bt_QuanLy.Enabled = false;
            }
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
            QuanLy ql = new QuanLy();
            this.Hide();
            ql.Show();

            /*if (quyen == "1" || quyen == "2")
                MessageBox.Show("Bạn không thực hiện được thao tác này */
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


        private void bt_DangXuat_Click_1(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Mầy chắc chưa?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(tb == DialogResult.OK)
            {
                this.Hide();
                DangNhap dn = new DangNhap();
                this.Hide();
                dn.ShowDialog();
            }
        }

     

        private void bt_ThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan tt = new ThanhToan();
            tt.Show();
        }

        private void bt_HuyDat_Click(object sender, EventArgs e)
        {

        }

        private void bt_DatBan_Click(object sender, EventArgs e)
        {       
            frDatBan db = new frDatBan();
            db.Show();
        
        }

        private void panelNameUser_Paint(object sender, PaintEventArgs e)
        {

        }

     
      
    }
}
