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
   public class BUS_KhenThuong
    {
       public static DataTable Hienthi_khenthuong_all()
       {
           return DAO_KhenThuong.Hienthi_khenthuong_all();
       }
       public static DataTable Hienthi_khenthuong_theoma(string ma)
       {
           return DAO_KhenThuong.Hienthi_khenthuong_theoma(ma);
       }
       public static DataTable Hienthi_khenthuong_theoten(string ma)
       {
           return DAO_KhenThuong.Hienthi_khenthuong_theoten(ma);
       }
       public static DataTable layma()
       {
           return DAO_KhenThuong.layma();
       }
       public static DataTable layten()
       {
           return DAO_KhenThuong.layten();
       }
       public static void Sua_khenthuong(DTO_TongLuong nv)
       {
           DAO_KhenThuong.Sua_khenthuong(nv);
       }
    }
}
