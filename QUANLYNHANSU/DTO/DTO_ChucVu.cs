using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChucVu
    {
        private string _MaChucVu;

        public string MaChucVu
        {
            get { return _MaChucVu; }
            set { _MaChucVu = value; }
        }
        private string _TenChucVu;

        public string TenChucVu
        {
            get { return _TenChucVu; }
            set { _TenChucVu = value; }
        }
    }
}
