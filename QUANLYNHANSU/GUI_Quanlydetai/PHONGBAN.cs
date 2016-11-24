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
    public partial class PHONGBAN : Form
    {
        public DataTable dt;
        public int quyen;
        public string strcon = @"Data Source=ADMINISTRATOR\SQLEXPRESS;Initial Catalog=QUANLINHANSU;Integrated Security=True";
        public PHONGBAN()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            dt = BUS_PhongBan.Hienthi_phongban_all();
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
            txtMaTP.Text = gridView2.GetFocusedRowCellValue(colMaTP).ToString();
            txtDienThoaiPB.Text = gridView2.GetFocusedRowCellValue(colDienThoai).ToString();
            txtEmailPB.Text = gridView2.GetFocusedRowCellValue(colEmail).ToString();
            txtDiaDiemPB.Text = gridView2.GetFocusedRowCellValue(colDiaDiem).ToString();

        }

        private void PHONGBAN_Load(object sender, EventArgs e)
        {
            loaddata();
            bindings();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string sl = cboTimKiem.Text;
            try
            {
                //  sl = sl.Replace();

                if (sl == "Mã phòng ban")
                {


                    dt = BUS_PhongBan.hienthiphongbantheoma(cmbKey.Text);
                    loaddata1(dt);
                    bindings();
                }
                else if (sl == "Tên phòng ban")
                {
                    dt = BUS_PhongBan.hienthiphongbantheoten(cmbKey.Text);
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
                if (sl == "Mã phòng ban")
                {
                    cmbKey.DataSource = BUS_PhongBan.laymaphongban();
                    //cmbKey.DisplayMember = "TENTD";
                    cmbKey.ValueMember = "MaPB";
                }

                else if (sl == "Tên phòng ban")
                {
                    cmbKey.DataSource = BUS_PhongBan.laytenphongban();
                    //cmbKey.DisplayMember = "TENTD";
                    cmbKey.ValueMember = "TenPB";

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

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            bindings();
        }

        private void grdGiangVien_Click(object sender, EventArgs e)
        {

        }
        //THEM
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_PhongBan sv = new DTO_PhongBan(txtMaPB.Text, txtTenPB.Text, txtMaTP.Text, txtDiaDiemPB.Text, txtDienThoaiPB.Text, txtEmailPB.Text);

                BUS_PhongBan.Them_phongban(sv);
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
        //SUA
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_PhongBan sv = new DTO_PhongBan(txtMaPB.Text, txtTenPB.Text, txtMaTP.Text, txtDiaDiemPB.Text, txtDienThoaiPB.Text, txtEmailPB.Text);

                BUS_PhongBan.Sua_phongban(sv);
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
        //xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                BUS_PhongBan.Xoa_phongban(txtMaPB.Text);
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
