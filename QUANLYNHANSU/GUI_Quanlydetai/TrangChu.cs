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
    public partial class TrangChu : Form
    {
        public DataTable dt;
        public int quyen;
        public string strcon = @"Data Source=ADMINISTRATOR\SQLEXPRESS;Initial Catalog=QUANLINHANSU;Integrated Security=True";
        public TrangChu()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            dt = BUS_LamViec.Hienthi_all();
            grdGiangVien.DataSource = dt;

        }
        private void loaddata1(DataTable dt)
        {

            grdGiangVien.DataSource = dt;
        }
        private void bindings()
        {


            txtMaPB.Text = gridView2.GetFocusedRowCellValue(colMaPB).ToString();
            txtTenPB.Text = gridView2.GetFocusedRowCellValue(colTenPB).ToString();
            txtMaNV.Text = gridView2.GetFocusedRowCellValue(colMaNV).ToString();
            txtTenNV.Text = gridView2.GetFocusedRowCellValue(colTenNV).ToString();
 
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            loaddata();
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
                if (sl == "Mã phòng ban")
                {
                    cmbKey.DataSource = BUS_LamViec.laymaphongbantrangchu();
                    //cmbKey.DisplayMember = "TENTD";
                    cmbKey.ValueMember = "MaPB";
                }

                else if (sl == "Tên phòng ban")
                {
                    cmbKey.DataSource = BUS_LamViec.laytenphongbantrangchu();
                    //cmbKey.DisplayMember = "TENTD";
                    cmbKey.ValueMember = "TenPB";

                }
                else
                {
                    cmbKey.Text = "";
                }

                if (sl == "Mã nhân viên")
                {
                    cmbKey.DataSource = BUS_LamViec.laymanhanvientrangchu();
                    //cmbKey.DisplayMember = "TENTD";
                    cmbKey.ValueMember = "MaNV";
                }

                else if (sl == "Tên nhân viên")
                {
                    cmbKey.DataSource = BUS_LamViec.laytennhanvientrangchu();
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
            // NGUYEN HUU HUY

            string sl = cboTimKiem.Text;
            try
            {
                //  sl = sl.Replace();

                if (sl == "Mã phòng ban")
                {


                    dt = BUS_LamViec.hienthitrangchutheomaphongban(cmbKey.Text);
                    loaddata1(dt);
                    bindings();
                }
                else if (sl == "Tên phòng ban")
                {
                    dt = BUS_LamViec.hienthitrangchutheotenphongban(cmbKey.Text);
                    loaddata1(dt);
                    bindings();
                }
                if (sl == "Mã nhân viên")
                {
                    dt = BUS_LamViec.hienthitrangchutheomanhanvien(cmbKey.Text);
                    loaddata1(dt);
                    bindings();
                }
                if (sl == "Tên nhân viên")
                {
                    dt = BUS_LamViec.hienthitrangchutheotennhanvien(cmbKey.Text);
                    loaddata1(dt);
                    bindings();
                }
           }
            catch (Exception ex)
            {
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            try
            {
                DTO_LamViec sv = new DTO_LamViec(txtMaPB.Text, txtMaNV.Text);
                BUS_LamViec.Sua_lamviec(sv);
                DialogResult dr = MessageBox.Show("Sua thanh Cong", "Thông Báo", MessageBoxButtons.OK);
                loaddata();
                if (dr == DialogResult.OK)
                {
                    loaddata();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Sua không thành công!\n" + ex.Message);
            }
        }
    }
}
