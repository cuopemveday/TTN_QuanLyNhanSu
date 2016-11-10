using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Luong
    {
        private string _HSL;

        public string HSL
        {
            get { return _HSL; }
            set { _HSL = value; }
        }
        private string _Tien;

        public string Tien
        {
            get { return _Tien; }
            set { _Tien = value; }
        }
    }
}
