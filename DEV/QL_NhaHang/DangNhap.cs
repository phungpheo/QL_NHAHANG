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
             SqlConnection con =new SqlConnection("Data Source=DESKTOP-Q2KRDSD\\SQLEXPRESS;Initial Catalog=QL_NHAHANG;Integrated Security=True");
             con.Open();
           SqlDataAdapter sda=new SqlDataAdapter("Select Row from User where Ma='"+tb_MaDN+"'and Pass='"+tb_MK+"'",con);
            DataTable dtUser=new DataTable();
            sda.Fill(dtUser);
            if (dtUser.Rows[0][0].ToString()=="1")
            {
                this.Hide();
                TrangChu TrangChu =new TrangChu();
                TrangChu.Show();
            }
            else {
                MessageBox.Show("Your username or password is not correct!");
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
