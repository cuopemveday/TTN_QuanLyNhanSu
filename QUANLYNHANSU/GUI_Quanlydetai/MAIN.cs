﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;

namespace GUI_Quanlydetai
{
    //public static class QUYEN
    //{
    //    public static int quyen;
    //}
    public partial class MAIN : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        Add clsAddTab = new Add();

        int quyen;
        public MAIN()
        {
            InitializeComponent();
        }

        public MAIN(int quyen)
        {
            InitializeComponent();
            this.quyen = quyen;
        }


        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Kiểm tra khi bấm nút Sinh Viên: Nếu đã có TAb này rồi thì không Add vào nữa
            // mà nó sẽ chuyển focus tới TAb Sinh Viên này
  
           
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
            //frm_DangNhap frm = new frm_DangNhap();
            //frm.Show();
            //Application.Exit();
 
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            xtraTabControl1.TabPages.RemoveAt(xtraTabControl1.SelectedTabPageIndex);
        }

        private void xtraTabControl1_ControlAdded(object sender, ControlEventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (quyen == 1)
            {
                int t = 0;
                foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
                {
                    if (tab.Text == "Quản lý tài khoản")
                    {
                        xtraTabControl1.SelectedTabPage = tab;
                        t = 1;
                    }
                }
                if (t == 1)
                {

                }
                else
                {// Nếu chưa có TAb này thì gọi hàm Addtab xây dựng ở trên để Add Tab con vào
                    //clsAddTab.AddTab(xtraTabControl1, "", "Quản Lý Hội Đồng", new frm_NhanVienTC(quyen));
                    clsAddTab.AddTab(xtraTabControl1, "", "Quản lý tài khoản", new TaiKhoan());
                }
            }
            else MessageBox.Show("Ban khong co quyen nay !!!");
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Kiểm tra khi bấm nút Sinh Viên: Nếu đã có TAb này rồi thì không Add vào nữa
            // mà nó sẽ chuyển focus tới TAb Sinh Viên này
  
        }

        private void MAIN_Load(object sender, EventArgs e)
        {
           // clsAddTab.AddTab(xtraTabControl1, "", "Trang Chủ", new MainTC(quyen));
            DevExpress.UserSkins.BonusSkins.Register();
            SkinHelper.InitSkinPopupMenu(skins);
            //
            //
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(huyanh, true);

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void MAIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_DangNhap frm = new frm_DangNhap();
            frm.Show();
            //Application.Exit();
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)

        {
            // Kiểm tra khi bấm nút Sinh Viên: Nếu đã có TAb này rồi thì không Add vào nữa
            // mà nó sẽ chuyển focus tới TAb Sinh Viên này
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản lý nhân viên")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {// Nếu chưa có TAb này thì gọi hàm Addtab xây dựng ở trên để Add Tab con vào
                //clsAddTab.AddTab(xtraTabControl1, "", "Quản Lý Hội Đồng", new frm_NhanVienTC(quyen));
                clsAddTab.AddTab(xtraTabControl1, "", "Quản lý nhân viên", new frm_NhanVienTC());
            }
        }

        private void barButtonItem41_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản lý phòng ban")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {// Nếu chưa có TAb này thì gọi hàm Addtab xây dựng ở trên để Add Tab con vào
                //clsAddTab.AddTab(xtraTabControl1, "", "Quản Lý Hội Đồng", new frm_NhanVienTC(quyen));
                clsAddTab.AddTab(xtraTabControl1, "", "Quản lý phòng ban", new frm_PhongBan());
            }
        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản lý khen thưởng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản lý khen thưởng", new frm_KhenThuong());
            }
        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ((quyen == 1) || (quyen == 2))
            {
                int t = 0;
                foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
                {
                    if (tab.Text == "Quản Lý Phòng Ban")
                    {
                        xtraTabControl1.SelectedTabPage = tab;
                        t = 1;
                    }
                }
                if (t == 1)
                {

                }
                else
                {
                    clsAddTab.AddTab(xtraTabControl1, "", "Quản Lý Phòng Ban", new PHONGBAN());
                }
            }
            else MessageBox.Show("Ban khong co quyen nay !!!");
        }

        private void barButtonItem33_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ((quyen == 1) || (quyen == 2))
            {
                int t = 0;
                foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
                {
                    if (tab.Text == "Quản Lý Nhân Viên")
                    {
                        xtraTabControl1.SelectedTabPage = tab;
                        t = 1;
                    }
                }
                if (t == 1)
                {

                }
                else
                {
                    clsAddTab.AddTab(xtraTabControl1, "", "Quản Lý Nhân Viên", new NHANVIEN());
                }
            }
            else MessageBox.Show("Ban khong co quyen nay !!!");
        }

        private void barButtonItem34_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ((quyen == 1) || (quyen == 2))
            {
                int t = 0;
                foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
                {
                    if (tab.Text == "Quản Lý Khen Thưởng")
                    {
                        xtraTabControl1.SelectedTabPage = tab;
                        t = 1;
                    }
                }
                if (t == 1)
                {

                }
                else
                {
                    clsAddTab.AddTab(xtraTabControl1, "", "Quản Lý Khen Thưởng", new KHENTHUONG());
                }
            }
            else MessageBox.Show("Ban khong co quyen nay!!!");
        }

        private void frmMain_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem42_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Trang Chu")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Trang Chu", new TrangChu());
            }
        }

        private void barButtonItem44_ItemClick(object sender, ItemClickEventArgs e)
        {
            Help.ShowHelp(this, "HelpNhanSu.chm");
        }
    }
}