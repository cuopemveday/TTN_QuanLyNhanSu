using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Thuong
    {
        private string _HST;

        public string HST
        {
            get { return _HST; }
            set { _HST = value; }
        }
        private string _Tien;

        public string Tien
        {
            get { return _Tien; }
            set { _Tien = value; }
        }
    }
}
