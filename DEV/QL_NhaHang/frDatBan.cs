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
    public partial class frDatBan : Form
    {
        public frDatBan()
        {
            InitializeComponent();

            Connect a = new Connect();          //Kết nối tới DATABASE
            SqlConnection con = a.getConnection();
            if (con.State != ConnectionState.Open) con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select * from BanDat ", con);    //Show bảng User
            DataSet ds = new DataSet();
            sda.Fill(ds, "BanDat");
            DataView dv = new DataView(ds.Tables["BanDat"]);
            dgv_BanDat.DataSource = dv;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.Hide();
          
        }
    }
}
