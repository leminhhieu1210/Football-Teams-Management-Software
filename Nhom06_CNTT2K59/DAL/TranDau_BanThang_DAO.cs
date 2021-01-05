using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemConstant;

namespace DAL
{
    public class TranDau_BanThang_DAO
    {
        static Constant sys = new Constant();
        static SqlConnection Conn = connectDtb.connectDb();

        public static void saveTranDau_BanThang(TranDau_BanThangDTO db, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[3];
            sqlP[0] = new SqlParameter("@matrandau", db.MaTranDau);
            sqlP[1] = new SqlParameter("@macauthu", db.MaCauThu);
            sqlP[2] = new SqlParameter("@thoigian", db.Thoigian);

            if (method == sys.INSERT) GenericDAO.execNonQuery("sp_Insert_TranDauBanThang", sqlP, Conn);
        }
    }
}
