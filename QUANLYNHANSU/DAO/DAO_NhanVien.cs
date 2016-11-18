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
    public class DAO_NhanVien
    {
        public static SqlConnection con;
        public static DataSet ds;
        public static DataTable dt;
        public static IDataAdapter da;

        public static DataTable HIENTHI_NHANVIEN_ALL()
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_HIENTHI_NV_ALL").Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable Hienthi_nhanvien_theoma(string ma)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_HIENTHI_DANHSACHNHANVIEN_THEOMA", ma).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable Hienthi_nhanvien_theoten(string ten)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_HIENTHI_DANHSACHNHANVIEN_THEOTEN", ten).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable Hienthi_nhanvien_theoPB(string pb)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_HIENTHI_DANHSACHNHANVIEN_THEOPHONGBAN", pb).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }


        public static void Them_nhanvien(DTO_NhanVien nv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_THEM_NHANVIEN", nv.MaNV, nv.TenNV, nv.GioiTinh, nv.DienThoai, nv.DiaChi, nv.Email, nv.NgaySinh, nv.SoCMND, nv.NoiCap, nv.NgayCap, nv.ChuyenMon, nv.MaCV);
            DAO_KetNoiDB.CloseConnect(con);
        }

        public static void Sua_nhanvien(DTO_NhanVien gv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_SUA_NHANVIEN", gv.MaNV, gv.TenNV, gv.GioiTinh, gv.DienThoai, gv.DiaChi, gv.Email, gv.NgaySinh, gv.SoCMND, gv.NoiCap, gv.NgayCap, gv.ChuyenMon, gv.MaCV);
            DAO_KetNoiDB.CloseConnect(con);
        }

        public static void Xoa_nhanvien(string gv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_XOA_NHANVIEN", gv);
            DAO_KetNoiDB.CloseConnect(con);
        }

        public static DataTable laymanhanvien()
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_laymanhanvien").Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable laytennhanvien()
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_laytennhanvien").Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }


    }
}
