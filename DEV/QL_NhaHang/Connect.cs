using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using  System.Data.SqlClient;

namespace QL_NhaHang
{
    public class Connect
    {
        public SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source=PHUNGPHEO\SQLEXPRESS;Initial Catalog=QL_NHAHANG;Integrated Security=True");
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
    }
}
