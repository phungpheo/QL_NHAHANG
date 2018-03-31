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
            Connect con = new Connect();
        public QuanLy()
        {
            InitializeComponent();

        }

        private void tabMon_Click(object sender, EventArgs e)
        {

        }

        private void bt_ThemUser_Click(object sender, EventArgs e)
        {
         //   con.USER_ADD(tbx_iduser.Text, tbx_password.Text, tbx_username.Text, cb_Quyen.Selected);x
        }

        private void bt_ThemBan_Click(object sender, EventArgs e)
        {

        }

        private void dgv_QLUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_QLUser.SelectedRows == null || e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                MessageBox.Show("Hãy Chọn 1 thông tin người dùng trước", "Thông báo");

            }
            else
            {
                tbx_iduser.Text = dgv_QLUser.Rows[e.RowIndex].Cells["ID"].Value.ToString().Trim();
                tbx_password.Text = dgv_QLUser.Rows[e.RowIndex].Cells["PASS"].Value.ToString();
                tbx_username.Text = dgv_QLUser.Rows[e.RowIndex].Cells["NAME"].Value.ToString().Trim();
                cb_Quyen.Text = dgv_QLUser.Rows[e.RowIndex].Cells["ROLE"].Value.ToString().Trim();
                dgv_QLUser.ClearSelection();
            }
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Ban' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dataSet1.MonAn' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dataSet1.User' table. You can move, or remove it, as needed.

            Connect a = new Connect();          //Kết nối tới DATABASE
            SqlConnection con = a.getConnection();
            if (con.State != ConnectionState.Open) con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from NguoiDung ", con);    //Show bảng User
            // DataSet ds = new DataSet();
            //sda.Fill(ds, "NguoiDung");
            //DataView dv = new DataView(ds.Tables["NguoiDung"]);
            // dgv_QLUser.DataSource = dv;
            DataTable dtnd = new DataTable();
            sda.Fill(dtnd);
            dgv_QLUser.DataSource = dtnd;


            SqlDataAdapter sda2 = new SqlDataAdapter("select * from MonAn ", con);      //Show bảng món ăn
            DataSet ds2 = new DataSet();
            sda2.Fill(ds2, "MonAn");
            DataView dv2 = new DataView(ds2.Tables["MonAn"]);
            dgv_QLMon.DataSource = dv2;



            /* SqlDataAdapter sda3 = new SqlDataAdapter("select * from Ban", con);     //Show bảng bàn ăn
             DataSet ds3 = new DataSet();
             sda3.Fill(ds3, "Ban");
             DataView dv3 = new DataView(ds3.Tables["Ban"]);
             dgv_QLBan.DataSource = dv3;*/
            SqlDataAdapter sda3 = new SqlDataAdapter("select * from Ban", con);
            DataTable dtban = new DataTable();
            sda3.Fill(dtban);
            dgv_QLBan.DataSource = dtban;

            con.Close();
        }

        private void dgv_QLMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv_QLMon.SelectedRows == null || e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                MessageBox.Show("Hãy Chọn 1 thông tin người dùng trước", "Thông báo");

            }
            else
            {
                tbx_Ma.Text = dgv_QLMon.Rows[e.RowIndex].Cells["MAMON"].Value.ToString().Trim();
                tbx_Ten.Text = dgv_QLMon.Rows[e.RowIndex].Cells["TENMON"].Value.ToString();
                tbx_GiaMon.Text = dgv_QLMon.Rows[e.RowIndex].Cells["GIA"].Value.ToString().Trim();
                cbx_LoaiMon.Text = dgv_QLMon.Rows[e.RowIndex].Cells["LOAIMONAN"].Value.ToString().Trim();
                dgv_QLMon.ClearSelection();
            }

        }

        private void tbx_MAMON(object sender, EventArgs e)
        {

        }

        private void tbx_TENMON(object sender, EventArgs e)
        {

        }

        private void tbx_GIA(object sender, EventArgs e)
        {

        }

        private void tbx_iduser_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_MaBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_QLBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_QLBan.SelectedRows == null || e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                MessageBox.Show("Hãy Chọn 1 thông tin người dùng trước", "Thông báo");
            }
            else
            {
                tbx_MaBan.Text = dgv_QLBan.Rows[e.RowIndex].Cells["MABAN"].Value.ToString().Trim();
                cbx_LoaiBan.Text = dgv_QLBan.Rows[e.RowIndex].Cells["LOAIBAN"].Value.ToString().Trim();
                cbx_TinhTrangBan.Text = dgv_QLBan.Rows[e.RowIndex].Cells["TINHTRANG"].Value.ToString().Trim();
                dgv_QLBan.ClearSelection();
            }
        }

        private void bt_trolai1_Click(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            this.Hide();
            tc.Show();
        }

        private void bt_trolai2_Click(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            this.Hide();
            tc.Show();
        }

        private void bt_trolai3_Click(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            this.Hide();
            tc.Show();
        }

        private void bt_Trolai_Click(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            this.Hide();
            tc.Show();
        }
    }
}