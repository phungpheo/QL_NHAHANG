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
        public static string QuyenHan = "";
        public static string TenUser = "";
        public static string MatKhau = "";
        public DataTable LayQuyen(string id)
        {
            Connect con = new Connect();
            SqlDataReader read1 = con.ExcuteReader("select PhanQuyen from [User] where Ma ='" + id + "' ");
            while (read1.Read())
            {
                QuyenHan = read1["PhanQuyen"].ToString();
            }
            return null;
        }

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
            SqlDataReader reader =cn.ExcuteReader("select Ma, Pass from NguoiDung where Ma = '"+ user + "' and Pass = '" + pass + "' ");

            LayQuyen(tb_MaDN.Text); //gọi hàm lấy quyền
     
            TrangChu.Quyenhan = QuyenHan;// truyền quyền hạn đến trang chủ
           // TrangChu.Tenuser = TenUser;
            TrangChu.Mauser = user;

           // Order.Tenuser = TenUser;
            Order.Quyenhan = QuyenHan;

            if (reader.Read() == true)
            {
                this.Hide();
                TrangChu Trangchu =new TrangChu();
                Trangchu.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Mã đăng nhập hoặc mật khẩu của bạn không đúng!");
                tb_MaDN.Clear();
                tb_MK.Clear();
            }

  
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
