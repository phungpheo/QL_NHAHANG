using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using  System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_NhaHang
{
    public class Connect
    {
        SqlConnection con=new SqlConnection();
        SqlDataAdapter sda;
        DataTable dtb;
        SqlCommand cmd;

        

        public SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source=PHUNGPHEO\MSSQLSERVER01;Initial Catalog=QL_NHAHANG;Integrated Security=True");
        }

        public void OpenConnect()
        {
            getConnection();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        // dong ket noi
        public void CloseConnect()
        {
            getConnection();
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        //check Query database

        public DataTable CheckSql(string sql)
        {
            OpenConnect();
            dtb = new DataTable();
            cmd = new SqlCommand(sql, con);
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dtb);
            CloseConnect();
            return dtb;
        }
        // lay dulieu tu table cho datagridview
        public DataTable Select_data(string query)
        {
            dtb = new DataTable();
            OpenConnect();
            cmd = new SqlCommand(query, con);
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dtb);
            CloseConnect();
            return dtb;

        }
        public bool excuteNonQuery(string sql)
        {
            SqlConnection connection = (SqlConnection)getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            return true;
        }
        public SqlDataReader ExcuteReader(string sql)
        {
            SqlConnection con = getConnection();
            con.Open();
            SqlCommand cmd =new SqlCommand(sql,con);
            SqlDataReader reader=cmd.ExecuteReader();
            return reader;
        }
        public int executeScalar(string sql)
        {

            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            int n = (int)cmd.ExecuteScalar();
            con.Close();
            cmd.Dispose();
            return n;
        }
        public SqlDataAdapter executeDataTable (string sql)
        {

            SqlConnection con = getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand = cmd;
            return sda;
        }


        // auto goi y 
        
        public void AutoComplete(TextBox tbx_textbox, string sql)
        {
            tbx_textbox.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbx_textbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            tbx_textbox.AutoCompleteCustomSource = DataCollection;
        }
        public SqlCommand USER_ADD (string Manv, string Pass, string TenNv, string PhanQuyen)       //them
        {
            OpenConnect();
            cmd = new SqlCommand("Them User moi", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MA", Manv));
            cmd.Parameters.Add(new SqlParameter("TEN", TenNv));
            cmd.Parameters.Add(new SqlParameter("Pass", Pass));
            cmd.Parameters.Add(new SqlParameter("PhanQuyen", PhanQuyen));
            CloseConnect();
            return cmd;
        }
        public SqlCommand USER_UPDATE(string Manv, string Pass, string TenNv, string PhanQuyen)     //Sua
        {
            OpenConnect();
            cmd = new SqlCommand(" User Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MA", Manv));
            cmd.Parameters.Add(new SqlParameter("TEN", TenNv));
            cmd.Parameters.Add(new SqlParameter("Pass", Pass));
            cmd.Parameters.Add(new SqlParameter("PhanQuyen", PhanQuyen));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            CloseConnect();
            return cmd;
        }
        public SqlCommand USER_DEL(string Manv)
        {
            OpenConnect();
            cmd = new SqlCommand("Xoa tai khoan", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MA", Manv));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            CloseConnect();
            return cmd;
        }
    }
}
