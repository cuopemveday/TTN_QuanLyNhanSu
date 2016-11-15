using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using Microsoft.ApplicationBlocks.Data;

namespace DAO
{
    public class DAO_KhenThuong
    {
        public static SqlConnection con;
        public static DataSet ds;
        public static DataTable dt;
        public static IDataAdapter da;

        public static DataTable Hienthi_khenthuong_all()
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_HIENTHI_KHENTHUONG_ALL").Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable Hienthi_khenthuong_theoma(string ma)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_HIENTHI_KHENTHUONG_theoma",ma).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable Hienthi_khenthuong_theoten(string ma)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_HIENTHI_KHENTHUONG_theoten", ma).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable layma()
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_HIENTHI_KHENTHUONG_ma").Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable layten()
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_HIENTHI_KHENTHUONG_ten").Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static void Sua_khenthuong(DTO_TongLuong nv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_SUA_KHENTHUONG", nv.MaNV, nv.HST, nv.HSL);
            DAO_KetNoiDB.CloseConnect(con);
        }
    }
}
