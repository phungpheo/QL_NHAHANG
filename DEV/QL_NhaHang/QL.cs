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
    public partial class QL : Form
    {
        public QL()
        {
            InitializeComponent();
        }

        private void bt_MonAn_Click(object sender, EventArgs e)
        {

        }
       
        private void bt_NV_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q2KRDSD\\SQLEXPRESS;Initial Catalog=QL_NHAHANG;Integrated Security=True");
            SqlDataAdapter apt = new SqlDataAdapter("Select * from NhanVien", con);
            DataTable tb = new DataTable();
           // comand.CommandText = "";
           // comand.Connection = con;
            con.Open();
            apt.Fill(tb);

            
            con.Close();
        }
    }
}
