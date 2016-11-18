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
    public partial class frm_NhanVienTC : Form
    {
        public DataTable dt;
        public int quyen;
        public string strcon = @"Data Source=ADMINISTRATOR\SQLEXPRESS;Initial Catalog=QUANLINHANSU;Integrated Security=True";
        public frm_NhanVienTC()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void loaddata()
        {
            dt = BUS_NhanVien.Hienthi_nhanvien_all();
            grdNhanVienTC.DataSource = dt;

        }
        private void loaddata1(DataTable dt)
        {

            grdNhanVienTC.DataSource = dt;
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
        /// <summary>
        ///
        /// </summary>
        /// <param name="them sinh vien"></param>
        /// <param name="them sinh vien"></param>
        /// 
       
        private void grdGiangVien_Click(object sender, EventArgs e)
        {
            bindings();
        }

        private void frm_NhanVienTC_Load(object sender, EventArgs e)
        {
            loaddata();
         bindings();
        }

        private void gridView2_Click(object sender, EventArgs e)
        {
           bindings();
        }

        private void grdNhanVienTC_Click(object sender, EventArgs e)
        {
            bindings();
        }

        private void gridView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            bindings();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // CHUAN DAY NHE OKEY ;
           bindings();
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void cmbKey_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void grdNhanVienTC_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {

        }
    }
}
