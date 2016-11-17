using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using DTO;
using DAO;

namespace BUS
{
    public class BUS_NhanVien
    {
        public static DataTable Hienthi_nhanvien_all()
        {
            return DAO_NhanVien.HIENTHI_NHANVIEN_ALL();
        }
        public static DataTable Hienthi_nhanvien_theoma(string ma)
        {
            return DAO_NhanVien.Hienthi_nhanvien_theoma(ma);
        }
        public static DataTable Hienthi_nhanvien_theoten(string ten)
        {
            return DAO_NhanVien.Hienthi_nhanvien_theoten(ten);
        }
        public static DataTable Hienthi_nhanvien_theoPB(string khoa)
        {
            return DAO_NhanVien.Hienthi_nhanvien_theoPB(khoa);
        }


        public static void Them_nhanvien(DTO_NhanVien nv)
        {
            DAO_NhanVien.Them_nhanvien(nv);
        }
        public static void Sua_nhanvien(DTO_NhanVien gv)
        {
            DAO_NhanVien.Sua_nhanvien(gv);
        }

        public static void Xoa_nhanvien(string gv)
        {
            DAO_NhanVien.Xoa_nhanvien(gv);
        }

        public static DataTable laymanhanvien()
        {
            return DAO_NhanVien.laymanhanvien();
        }
        public static DataTable laytennhanvien()
        {
            return DAO_NhanVien.laytennhanvien();
        }


    }
}