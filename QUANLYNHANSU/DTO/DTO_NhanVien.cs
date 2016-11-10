using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        private string _TenNV;

        public string TenNV
        {
            get { return _TenNV; }
            set { _TenNV = value; }
        }
        private string _GioiTinh;

        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }
        private string  _DienThoai;

        public string  DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }
        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _NgaySinh;

        public string NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        private string _SoCMND;

        public string  SoCMND
        {
            get { return _SoCMND; }
            set { _SoCMND = value; }
        }
        private string _NgayCap;

        public string NgayCap
        {
            get { return _NgayCap; }
            set { _NgayCap = value; }
        }
        private string _NoiCap;

        public string NoiCap
        {
            get { return _NoiCap; }
            set { _NoiCap = value; }
        }
        private string _ChuyenMon;

        public string ChuyenMon
        {
            get { return _ChuyenMon; }
            set { _ChuyenMon = value; }
        }
        private string  _MaCV;

        public string  MaCV
        {
            get { return _MaCV; }
            set { _MaCV = value; }
        }
        public DTO_NhanVien(string _MaNV, string _TenNV, string _GioiTinh, string  _DienThoai, string _DiaChi,string _Email , string _NgaySinh , string  _SoCMND , string _NgayCap , string _NoiCap , string _ChuyenMon , string  _MaChucVu)
        {
            this.MaNV = _MaNV;
            this.TenNV = _TenNV;
            this.GioiTinh =_GioiTinh;
            this.DienThoai = _DienThoai;
            this.DiaChi = _DiaChi;
            this.Email = _Email;
            this.NgaySinh = _NgaySinh;
            this.SoCMND = _SoCMND;
            this.NgayCap = _NgayCap;
            this.NoiCap = _NoiCap;

            this.ChuyenMon = _ChuyenMon;
            this.MaCV = _MaCV;
            

        }

    }
}
