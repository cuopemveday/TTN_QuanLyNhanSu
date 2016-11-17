using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using Microsoft.ApplicationBlocks.Data;

 namespace DAO
{
        
    public class DAO_PhongBan
    {
        public static SqlConnection con;
        public static DataSet ds;
        public static DataTable dt;
        public static IDataAdapter da;

        public static DataTable HIENTHI_PHONGBAN_ALL()
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_HIENTHI_PB_ALL").Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable laytenphongban()
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_laytenphongban").Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable laymaphongban()
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_laymaphongban").Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable HIENTHI_PHONGBAN_THEOTEN(string ma)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_HIENTHI_PB_TEN",ma).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable HIENTHI_PHONGBAN_THEOMA(string ma)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_HIENTHI_PB_MA",ma).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static void Them_phongban(DTO_PhongBan nv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_THEM_PHONGBAN", nv.MaPB, nv.TenPB, nv.MaTP, nv.DiaDiem, nv.DienThoai, nv.Email);
            DAO_KetNoiDB.CloseConnect(con);
        }
        public static void Sua_phongban(DTO_PhongBan nv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_SUA_PHONGBAN", nv.MaPB, nv.TenPB, nv.MaTP, nv.DiaDiem, nv.DienThoai, nv.Email);
            DAO_KetNoiDB.CloseConnect(con);
        }
        public static void Xoa_phongban(string nv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_XOA_PHONGBAN", nv);
            DAO_KetNoiDB.CloseConnect(con);
        }
    }
}
