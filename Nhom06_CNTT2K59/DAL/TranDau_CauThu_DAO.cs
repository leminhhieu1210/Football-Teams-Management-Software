using DTO;
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
    public class TranDau_CauThu_DAO
    {
        static Constant sys = new Constant();
        static SqlConnection Conn = connectDtb.connectDb();

        public static DataTable getData()
        {
            return GenericDAO.getData("sp_GetAll_Trandau_Cauthu", Conn);
        }

        public static void saveTranDau_CauThu(TranDau_CauThuDTO tdct, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[3];
            sqlP[0] = new SqlParameter("@matrandau", tdct.MaTranDau);
            sqlP[1] = new SqlParameter("@madoi", tdct.MaDoi);
            sqlP[2] = new SqlParameter("@macauthu", tdct.MaCauThu);

            if (method == sys.INSERT) GenericDAO.execNonQuery("sp_Insert_TranDauCauThu", sqlP, Conn);
        }
    }
}
