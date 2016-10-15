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
    public class BUS_PhongBan
    {
        public static DataTable Hienthi_phongban_all()
        {
            return DAO_PhongBan.HIENTHI_PHONGBAN_ALL();
        }
        public static DataTable laymaphongban()
        {
            return DAO_PhongBan.laymaphongban();
        }
        public static DataTable laytenphongban()
        {
            return DAO_PhongBan.laytenphongban();
        }
        public static DataTable hienthiphongbantheoma(string ma)
        {
            return DAO_PhongBan.HIENTHI_PHONGBAN_THEOMA(ma);
        }
        public static DataTable hienthiphongbantheoten(string ma)
        {
            return DAO_PhongBan.HIENTHI_PHONGBAN_THEOTEN(ma);
        }
        public static void Them_phongban(DTO_PhongBan nv)
        {
            DAO_PhongBan.Them_phongban(nv);
        }
        public static void Sua_phongban(DTO_PhongBan nv)
        {
            DAO_PhongBan.Sua_phongban(nv);
        }
        public static void Xoa_phongban(string nv)
        {
            DAO_PhongBan.Xoa_phongban(nv);
        }
    }
}
