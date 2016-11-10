using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TongLuong
    {
        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        private string _HSL;

        public string HSL
        {
            get { return _HSL; }
            set { _HSL = value; }
        }
        private string _HST;

        public string HST
        {
            get { return _HST; }
            set { _HST = value; }
        }

       public DTO_TongLuong(string _MaNV, string _HSL, string _HST)
       {
            this.MaNV = _MaNV;
            this.HSL = _HSL;
            this.HST =_HST;

        }
    }
}
