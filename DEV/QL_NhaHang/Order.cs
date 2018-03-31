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
    public partial class Order : Form
    {
        public static string Quyenhan = "";
        public static string Tenuser = ""; 
        public Order()
        {
            InitializeComponent();
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            this.Hide();
            tc.Show();
        }

        private void bt_Huy_Click_1(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            this.Hide();
            tc.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Connect a= new Connect();
            SqlConnection con = a.getConnection();
            if (con.State != ConnectionState.Open) con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from MonAn where LoaiMonAn like N'Đồ uống'", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "MonAn");
            DataView dv = new DataView(ds.Tables["MonAn"]);
            dgv_MonAn.DataSource = dv;


        }

        private void bt_Save_Click(object sender, EventArgs e)
        {

        }

        private void khaiVịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connect a = new Connect();
            SqlConnection con = a.getConnection();
            if (con.State != ConnectionState.Open) con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from MonAn where LoaiMonAn like N'Khai vị'", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "MonAn");
            DataView dv = new DataView(ds.Tables["MonAn"]);
            dgv_MonAn.DataSource = dv;
        }

        private void mónChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connect a = new Connect();
            SqlConnection con = a.getConnection();
            if (con.State != ConnectionState.Open) con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from MonAn where LoaiMonAn like N'Món chính'", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "MonAn");
            DataView dv = new DataView(ds.Tables["MonAn"]);
            dgv_MonAn.DataSource = dv;
        }

        private void trángMiệngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connect a = new Connect();
            SqlConnection con = a.getConnection();
            if (con.State != ConnectionState.Open) con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from MonAn where LoaiMonAn like N'Tráng miệng'", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "MonAn");
            DataView dv = new DataView(ds.Tables["MonAn"]);
            dgv_MonAn.DataSource = dv;
        }

        private void dgv_MonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {

        }
    }
}
