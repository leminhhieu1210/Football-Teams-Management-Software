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
    public class CauThuDAO
    {
        static Constant sys = new Constant();
        static SqlConnection Conn = connectDtb.connectDb();

        public static DataTable getData()
        {
            return GenericDAO.getData("sp_GetAll_Cauthu", Conn);
        }

        public static DataTable getDataForSearch()
        {
            return GenericDAO.getData("sp_GetAll_CauThu_ForSearch", Conn);
        }

        //thêm, sửa, xoá xuống csdl
        public static void saveCauThu(CauThuDTO ct, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[12];
            sqlP[0] = new SqlParameter("@MaCauThu", ct.MaCauThu);
            sqlP[1] = new SqlParameter("@MaDoi", ct.MaDoi);
            sqlP[2] = new SqlParameter("@TenCauThu", ct.TenCauThu);
            sqlP[3] = new SqlParameter("@MaViTri", ct.MaViTri);
            sqlP[4] = new SqlParameter("@NgaySinh", ct.NgaySinh);
            sqlP[5] = new SqlParameter("@SoAo", ct.SoAo);
            sqlP[6] = new SqlParameter("@SoBanThang", ct.SoBanThang);
            sqlP[7] = new SqlParameter("@SoTheVang", ct.SoTheVang);
            sqlP[8] = new SqlParameter("@SoTheDo", ct.SoTheDo);
            sqlP[9] = new SqlParameter("@MaQuocTich", ct.MaQuocTich);
            sqlP[10] = new SqlParameter("@SoLanRaSan", ct.SoLanRaSan);
            sqlP[11] = new SqlParameter("@Anh", ct.Anh);

            if (method == sys.INSERT) GenericDAO.execNonQuery("sp_InsertCauThu", sqlP, Conn);
            else if (method == sys.UPDATE) GenericDAO.execNonQuery("sp_UpdateCauThu", sqlP, Conn);
        }
        #region Cau 2
        public static void saveCauThu_SoLanRaSan(CauThuDTO ct, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[3];
            sqlP[0] = new SqlParameter("@MaCauThu", ct.MaCauThu);
            sqlP[1] = new SqlParameter("@SoLanRaSan", ct.SoLanRaSan);
            sqlP[2] = new SqlParameter("@SoBanThang", ct.SoBanThang);

            if (method == sys.UPDATE) GenericDAO.execNonQuery("sp_UpdateCauThu_SoLanRaSanVaSBT", sqlP, Conn);
        }
        #endregion
        public static void DeleteCT(string hs)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@Mact", hs);
            GenericDAO.execNonQuery("sp_Delete_CauThu", sqlP, Conn);
        }

        public static DataTable getDatabyID(string id)
        {
            return GenericDAO.getData("sp_GetAll_Cauthu_byID", Conn, id);
        }
    }
}
