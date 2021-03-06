﻿using System;
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
    public partial class frm_KhenThuong : Form
    {
        public DataTable dt;
        public int quyen;
        public string strcon = @"Data Source=ADMINISTRATOR\SQLEXPRESS;Initial Catalog=QUANLINHANSU;Integrated Security=True";
        public frm_KhenThuong()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            dt = BUS_KhenThuong.Hienthi_khenthuong_all();
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
            txtHSL.Text = gridView2.GetFocusedRowCellValue(colHSL).ToString();
            txtHST.Text = gridView2.GetFocusedRowCellValue(colHST).ToString();
            txtTienLuong.Text = gridView2.GetFocusedRowCellValue(colTienLuong).ToString();
            txtTienThuong.Text = gridView2.GetFocusedRowCellValue(colTienThuong).ToString();
            txtTongLuong.Text = gridView2.GetFocusedRowCellValue(colTONGLUONG).ToString();
            

        }

        private void frm_KhenThuong_Load(object sender, EventArgs e)
        {
            loaddata();
            bindings();
        }

        private void grdGiangVien_Click(object sender, EventArgs e)
        {
            bindings();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            bindings();
        }

        private void cmbKey_Click(object sender, EventArgs e)
        {
            string sl = cboTimKiem.Text;
            try
            {
                if (sl == "Mã nhân viên")
                {
                    cmbKey.DataSource = BUS_KhenThuong.layma();
                    //cmbKey.DisplayMember = "TENTD";
                    cmbKey.ValueMember = "MaNV";
                }

                else if (sl == "Tên nhân viên")
                {
                    cmbKey.DataSource = BUS_KhenThuong.layten();
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

        private void button14_Click(object sender, EventArgs e)
        {
            string sl = cboTimKiem.Text;
            try
            {
                if (sl == "Mã nhân viên")
                {


                    dt = BUS_KhenThuong.Hienthi_khenthuong_theoma(cmbKey.Text);
                    loaddata1(dt);
                    bindings();
                }
                else if (sl == "Tên nhân viên")
                {
                    dt = BUS_KhenThuong.Hienthi_khenthuong_theoten(cmbKey.Text);
                    loaddata1(dt);
                    bindings();

                }

            }
            catch (Exception ex)
            {
            }
        }
    }
}
