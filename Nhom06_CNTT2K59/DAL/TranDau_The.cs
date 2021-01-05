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
    public class TranDau_The
    {
        static Constant sys = new Constant();
        static SqlConnection Conn = connectDtb.connectDb();

        public static void saveTranDau_The(TranDau_TheDTO db, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[4];

            sqlP[0] = new SqlParameter("@matrandau", db.MaTranDau);
            sqlP[1] = new SqlParameter("@macauthu", db.MaCauThu);
            sqlP[2] = new SqlParameter("@thoigian", db.ThoiGian);
            sqlP[3] = new SqlParameter("@loaithe", db.LoaiThe);

            if (method == sys.INSERT) GenericDAO.execNonQuery("sp_Insert_TranDauThe", sqlP, Conn);
        }
    }
}
