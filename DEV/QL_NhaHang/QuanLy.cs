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
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();

            Connect a = new Connect();          //Kết nối tới DATABASE
            SqlConnection con = a.getConnection();
            if (con.State != ConnectionState.Open) con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select * from [User] ", con);    //Show bảng User
            DataSet ds = new DataSet();
            sda.Fill(ds, "User");
            DataView dv = new DataView(ds.Tables["User"]);
            dgv_QLUser.DataSource = dv;


            SqlDataAdapter sda2 = new SqlDataAdapter("select * from MonAn ", con);      //Show bảng món ăn
            DataSet ds2 = new DataSet();
            sda2.Fill(ds2, "MonAn");
            DataView dv2 = new DataView(ds2.Tables["MonAn"]);
            dgv_QLMon.DataSource = dv2;



            SqlDataAdapter sda3 = new SqlDataAdapter("select * from Ban", con);     //Show bảng bàn ăn
            DataSet ds3 = new DataSet();
            sda3.Fill(ds3, "Ban");
            DataView dv3 = new DataView(ds3.Tables["Ban"]);
            dgv_QLBan.DataSource = dv3;

            con.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        private void tabMon_Click(object sender, EventArgs e)
        {

        }

    }
}
