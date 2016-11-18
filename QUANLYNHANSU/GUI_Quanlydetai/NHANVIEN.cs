using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Microsoft.ApplicationBlocks.Data;

namespace GUI_Quanlydetai
{
    public partial class NHANVIEN : Form
    {
        public DataTable dt;
        public int quyen;
        public string strcon = @"Data Source=ADMINISTRATOR\SQLEXPRESS;Initial Catalog=QUANLINHANSU;Integrated Security=True";
        public NHANVIEN()
        {
            InitializeComponent();
        }

        private void grdGiangVien_Click(object sender, EventArgs e)
        {

        }
        private void loaddata()
        {
            dt = BUS_NhanVien.Hienthi_nhanvien_all();
            grdGiangVien.DataSource = dt;

        }
        private void loaddata1(DataTable dt)
        {

            grdGiangVien.DataSource = dt;
        }
        private void bindings()
        {


            txtMaNV.Text = gridView2.GetFocusedRowCellValue(colMaNV).ToString();
            txtTenNV.Text = gridView2.GetFocusedRowCellValue(colTenNV).ToString();
            txtGioiTinh.Text = gridView2.GetFocusedRowCellValue(colGioiTinh).ToString();
            txtDienThoaiNV.Text = gridView2.GetFocusedRowCellValue(colDienThoai).ToString();
            txtEmailNV.Text = gridView2.GetFocusedRowCellValue(colEmail).ToString();
            txtDiaChiNV.Text = gridView2.GetFocusedRowCellValue(colDiaChi).ToString();
            txtNgaySinh.Text = gridView2.GetFocusedRowCellValue(colNgaySinh).ToString();
            txtSoCMND.Text = gridView2.GetFocusedRowCellValue(colSoCMND).ToString();
            txtNgayCap.Text = gridView2.GetFocusedRowCellValue(colNgayCap).ToString();
            txtNoiCap.Text = gridView2.GetFocusedRowCellValue(colNoiCap).ToString();
            txtChuyenMon.Text = gridView2.GetFocusedRowCellValue(colChuyenMon).ToString();
            txtMaCV.Text = gridView2.GetFocusedRowCellValue(colMaCV).ToString();
            txtTongLuong.Text = gridView2.GetFocusedRowCellValue(colTongLuong).ToString();

        }

        private void NHANVIEN_Load(object sender, EventArgs e)
        {
            loaddata();
            bindings();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {// chuan day
            bindings();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string sl = cboTimKiem.Text;
            try
            {
                //  sl = sl.Replace();

                if (sl == "Mã nhân viên")
                {


                    dt = BUS_NhanVien.Hienthi_nhanvien_theoma(cmbKey.Text);
                    loaddata1(dt);
                    bindings();
                }
                else if (sl == "Tên nhân viên")
                {
                    dt = BUS_NhanVien.Hienthi_nhanvien_theoten(cmbKey.Text);
                    loaddata1(dt);
                    bindings();

                }

            }
            catch (Exception ex)
            {
            }
        }

        private void cmbKey_Click(object sender, EventArgs e)
        {
            string sl = cboTimKiem.Text;
            try
            {
                if (sl == "Mã nhân viên")
                {
                    cmbKey.DataSource = BUS_NhanVien.laymanhanvien();
                    //cmbKey.DisplayMember = "TENTD";
                    cmbKey.ValueMember = "MaNV";
                }

                else if (sl == "Tên nhân viên")
                {
                    cmbKey.DataSource = BUS_NhanVien.laytennhanvien();
                    //cmbKey.DisplayMember = "TENTD";
                    cmbKey.ValueMember = "TenNV";

                }
                else
                {
                    cmbKey.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        { 
            try
            {
                DTO_NhanVien sv = new DTO_NhanVien(txtMaNV.Text, txtTenNV.Text, txtGioiTinh.Text, txtDienThoaiNV.Text, txtDiaChiNV.Text, txtEmailNV.Text, txtNgaySinh.Text, txtSoCMND.Text, txtNgayCap.Text, txtNoiCap.Text, txtChuyenMon.Text, txtMaCV.Text);

                BUS_NhanVien.Them_nhanvien(sv);
                DialogResult dr = MessageBox.Show("Them thanh Cong", "Thông Báo", MessageBoxButtons.OK);
                loaddata();
                if (dr == DialogResult.OK)
                {
                    loaddata();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công!\n" + ex.Message);
            }
        }
        // sua
        private void btnSua_Click(object sender, EventArgs e)
        {

            try
            {

                DTO_NhanVien sv = new DTO_NhanVien(txtMaNV.Text, txtTenNV.Text, txtGioiTinh.Text, txtDienThoaiNV.Text, txtDiaChiNV.Text, txtEmailNV.Text, txtNgaySinh.Text, txtSoCMND.Text, txtNgayCap.Text, txtNoiCap.Text, txtChuyenMon.Text, txtMaCV.Text);
                BUS_NhanVien.Sua_nhanvien(sv);
                DialogResult dr = MessageBox.Show(" Sửa thành công", "Thông Báo", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    loaddata();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất Bại!!");
            }
        }
        //XOA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {


                BUS_NhanVien.Xoa_nhanvien(txtMaNV.Text);
                DialogResult dr = MessageBox.Show("Đã Xóa", "Thông Báo", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    loaddata();
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi");
            }
        }
    }
}
