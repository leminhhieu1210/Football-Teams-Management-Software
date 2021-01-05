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
    public class DoiBongDAO
    {
        static Constant sys = new Constant();
        static SqlConnection Conn = connectDtb.connectDb();

        public static DataTable getData()
        {
            return GenericDAO.getData("sp_GetAll_Doibong", Conn);
        }

        public static void saveDoiBong(DoiBongDTO db, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[10];
            sqlP[0] = new SqlParameter("@madoi", db.MaDoi);
            sqlP[1] = new SqlParameter("@tendoi", db.TenDoi);
            sqlP[2] = new SqlParameter("@masan", db.MaSan);
            sqlP[3] = new SqlParameter("@hlv", db.HLV1);
            sqlP[4] = new SqlParameter("@matinh", db.MaTinh);
            sqlP[5] = new SqlParameter("@logo", db.Logo);
            sqlP[6] = new SqlParameter("@diem", db.Diem);
            sqlP[7] = new SqlParameter("@sobanthang", db.SoBanThang);
            sqlP[8] = new SqlParameter("@sobanthua", db.SoBanThua);
            sqlP[9] = new SqlParameter("@socauthu", db.SoCauThu);

            if (method == sys.INSERT) GenericDAO.execNonQuery("sp_Insert_Doibong", sqlP, Conn);
            else if (method == sys.UPDATE) GenericDAO.execNonQuery("sp_Update_Doibong", sqlP, Conn);
        }
    }
}
