using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GenericDAO
    {

        public static DataTable getData(string sqlQuery, SqlConnection Conn)
        {
            Conn = connectDtb.connectDb();
            SqlCommand command = new SqlCommand(sqlQuery, Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static DataTable getData(string sqlQuery, SqlConnection Conn, string id)
        {
            Conn = connectDtb.connectDb();
            SqlCommand command = new SqlCommand(sqlQuery, Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@madb", id);

            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static string getKey(string sqlQuery)
        {
            SqlConnection Conn = connectDtb.connectDb();
            SqlCommand command = new SqlCommand(sqlQuery, Conn);

            Conn.Open();
            var res = command.ExecuteScalar();
            Conn.Close();

            return res.ToString();
        }

        public static void execNonQuery(string sqlQuery, SqlParameter[] sqlParameters, SqlConnection Conn)
        {
            Conn = connectDtb.connectDb();
            SqlCommand command = new SqlCommand(sqlQuery, Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(sqlParameters);
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static DataSet execRPQuery(string sqlQuery, SqlParameter[] sqlParameters, SqlConnection Conn)
        {
            SqlCommand command = new SqlCommand(sqlQuery, Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(sqlParameters);
            command.Connection = Conn;
            Conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(command);
            dap.Fill(ds);
            Conn.Close();
            return ds;
        }

        public static DataSet execRPQuery(string sqlQuery, SqlConnection Conn)
        {
            SqlCommand command = new SqlCommand(sqlQuery, Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = Conn;
            Conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(command);
            dap.Fill(ds);
            Conn.Close();
            return ds;
        }
    }
}
