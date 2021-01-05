using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReportDAO
    {
        static SqlConnection Conn = connectDtb.connectDb();

        public static DataSet getDataRP1()
        {
            return GenericDAO.execRPQuery("report_1", Conn);
        }
        public static DataSet getDataRP2(string maTran)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@matd", maTran);
            return GenericDAO.execRPQuery("report2", sqlP,Conn);
        }
        public static DataSet getDataRP3()
        {
            return GenericDAO.execRPQuery("report3", Conn);
        }
    }
}
