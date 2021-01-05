using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemConstant;

namespace DAL
{
    public class ViTriDAO
    {
        static Constant sys = new Constant();
        static SqlConnection Conn = connectDtb.connectDb();

        public static DataTable getData()
        {
            return GenericDAO.getData("sp_GetAll_Vitri", Conn);
        }
    }
}
