using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhongBan
    {
        private string _MaPB;

        public string MaPB
        {
            get { return _MaPB; }
            set { _MaPB = value; }
        }
        private string _TenPB;

        public string TenPB
        {
            get { return _TenPB; }
            set { _TenPB = value; }
        }
        private string _MaTP;

        public string MaTP
        {
            get { return _MaTP; }
            set { _MaTP = value; }
        }
        private string _DiaDiem;

        public string DiaDiem
        {
            get { return _DiaDiem; }
            set { _DiaDiem = value; }
        }
        private string _DienThoai;

        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
         public DTO_PhongBan(string _MaPB, string _TenPB, string _MaTP, string  _DiaDiem, string _DienThoai,string _Email )
        {
            this.MaPB = _MaPB;
            this.TenPB = _TenPB;
            this.MaTP =_MaTP;
            this.DiaDiem = _DiaDiem;
            this.DienThoai = _DienThoai;
            this.Email = _Email;
         

        }
    }
}
