using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class connectDtb
    {
        public static SqlConnection connectDb()
        {
            string query = "Data Source = LEESAI; Initial Catalog  = QuanLyDoiBong; UID = sa; PWD = 123";
            SqlConnection Conn = new SqlConnection(query);
            return Conn;
        }
    }
}
