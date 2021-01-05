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
    public class TranDauDAO
    {
        static Constant sys = new Constant();
        static SqlConnection Conn = connectDtb.connectDb();
        public static DataTable getData()
        {
            return GenericDAO.getData("sp_GetAll_Trandau", Conn);
        }
        public static DataTable getDataForSearch()
        {
            return GenericDAO.getData("sp_GetAll_TranDau_ForSearch", Conn);
        }
        public static void saveTranDau(TranDauDTO db, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[5];
            sqlP[0] = new SqlParameter("@matrandau", db.Matrandau);
            sqlP[1] = new SqlParameter("@luotdau", db.Luotdau);
            sqlP[2] = new SqlParameter("@vongdau", db.Vongdau);
            sqlP[3] = new SqlParameter("@madoinha", db.Madoinha);
            sqlP[4] = new SqlParameter("@madoikhach", db.Madoikhach);

            if (method == sys.INSERT) GenericDAO.execNonQuery("sp_Insert_TranDau", sqlP, Conn);
        }
        /* tinh diem sau tran*/
        public static void tinhDiemDoiBong(string db, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaTranDau", db);
            if (method == sys.INSERT) GenericDAO.execNonQuery("TinhDiem", sqlP, Conn);
        }
        public static void TinhSBT_SauTranDau(string db, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaTranDau", db);
            if (method == sys.INSERT) GenericDAO.execNonQuery("TinhSBT_SauTranDau", sqlP, Conn);
        }
    }
}
