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
    public class BUS_LamViec
    {
        public static DataTable Hienthi_all()
        {
            return DAO_LamViec.HIENTHI_ALL();
        }
        public static DataTable laymaphongbantrangchu()
        {
            return DAO_LamViec.laymaphongban();
        }
        public static DataTable laytenphongbantrangchu()
        {
            return DAO_LamViec.laytenphongban();
        }
        public static DataTable laymanhanvientrangchu()
        {
            return DAO_LamViec.laymanhanvien();
        }
        public static DataTable hienthitrangchutheomaphongban(string ma)
        {
            return DAO_LamViec.hienthitrangchutheomaphongban(ma);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static DataTable laytennhanvientrangchu()
        {
            return DAO_LamViec.laytennhanvien();
        }
        public static DataTable hienthitrangchutheotenphongban(string ma)
        {
            return DAO_LamViec.hienthitrangchutheotenphongban(ma);
        }
        public static DataTable hienthitrangchutheomanhanvien(string ma)
        {
            return DAO_LamViec.hienthitrangchutheomanhanvien(ma);
        }
        public static DataTable hienthitrangchutheotennhanvien(string ma)
        {
            return DAO_LamViec.hienthitrangchutheotennhanvien(ma);
        }
        //
        //
        //
        public static void Sua_lamviec(DTO_LamViec nv)
        {
            DAO_LamViec.Sua_lamviec(nv);
        }
    }
}
