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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect cn = new Connect();
            string user = tb_MaDN.Text.Trim();
            string pass = tb_MK.Text.Trim();
            SqlDataReader reader =cn.ExcuteReader("select Ma, Pass from [User] where Ma = '"+ user + "' and Pass = '" + pass + "' ");

            if (reader.Read() == true)
            {
                this.Hide();
                TrangChu TrangChu =new TrangChu();
                TrangChu.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Your username or password is not correct!");
                tb_MaDN.Clear();
                tb_MK.Clear();
            }

            /*if ((tb_MaDN.Text == "1234") && (tb_MaDN.Text == "1234"))
            {
                TrangChu TrangChu =new TrangChu();
                this.Hide();
                TrangChu.Show();

            }*/
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) this.Close();
            else return;
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
