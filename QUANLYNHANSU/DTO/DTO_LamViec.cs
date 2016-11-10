using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LamViec
    {
        private string _MaPB;

        public string MaPB
        {
            get { return _MaPB; }
            set { _MaPB = value; }
        }
        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
         public DTO_LamViec(string _MaPB, string _MaNV)
        {
            this.MaPB = _MaPB;
            this.MaNV = _MaNV;        
        }
    }
}
