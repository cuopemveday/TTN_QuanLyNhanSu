﻿namespace GUI_Quanlydetai
{
    partial class frm_PhongBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdPhongBan = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenPB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaDiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.cmbKey = new System.Windows.Forms.ComboBox();
            this.button14 = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.txtDiaDiemPB = new System.Windows.Forms.TextBox();
            this.txtMaTP = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDienThoaiPB = new System.Windows.Forms.TextBox();
            this.txtEmailPB = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.navBarControl1.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdPhongBan);
            this.groupBox1.Controls.Add(this.navBarControl1);
            this.groupBox1.Location = new System.Drawing.Point(-4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 510);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // grdPhongBan
            // 
            this.grdPhongBan.DataMember = "CustomSqlQuery";
            this.grdPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPhongBan.Location = new System.Drawing.Point(3, 16);
            this.grdPhongBan.MainView = this.gridView2;
            this.grdPhongBan.Name = "grdPhongBan";
            this.grdPhongBan.Size = new System.Drawing.Size(507, 491);
            this.grdPhongBan.TabIndex = 36;
            this.grdPhongBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView1});
            this.grdPhongBan.Click += new System.EventHandler(this.grdGiangVien_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPB,
            this.colTenPB,
            this.colMaTP,
            this.colDiaDiem,
            this.colDienThoai,
            this.colEmail});
            this.gridView2.GridControl = this.grdPhongBan;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsFind.FindDelay = 100;
            this.gridView2.OptionsFind.ShowFindButton = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // colMaPB
            // 
            this.colMaPB.Caption = "Mã PB";
            this.colMaPB.FieldName = "MaPB";
            this.colMaPB.Name = "colMaPB";
            this.colMaPB.Visible = true;
            this.colMaPB.VisibleIndex = 0;
            // 
            // colTenPB
            // 
            this.colTenPB.Caption = "Tên PB";
            this.colTenPB.FieldName = "TenPB";
            this.colTenPB.Name = "colTenPB";
            this.colTenPB.OptionsFilter.AllowFilter = false;
            this.colTenPB.Visible = true;
            this.colTenPB.VisibleIndex = 1;
            // 
            // colMaTP
            // 
            this.colMaTP.Caption = "Mã TP";
            this.colMaTP.FieldName = "MaTP";
            this.colMaTP.Name = "colMaTP";
            this.colMaTP.Visible = true;
            this.colMaTP.VisibleIndex = 2;
            // 
            // colDiaDiem
            // 
            this.colDiaDiem.Caption = "Địa Điểm";
            this.colDiaDiem.FieldName = "DiaDiem";
            this.colDiaDiem.Name = "colDiaDiem";
            this.colDiaDiem.Visible = true;
            this.colDiaDiem.VisibleIndex = 3;
            // 
            // colDienThoai
            // 
            this.colDienThoai.Caption = "Điện Thoại";
            this.colDienThoai.FieldName = "DienThoai";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.Visible = true;
            this.colDienThoai.VisibleIndex = 4;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdPhongBan;
            this.gridView1.Name = "gridView1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Location = new System.Drawing.Point(510, 16);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 470;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(470, 491);
            this.navBarControl1.TabIndex = 35;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Thông tin";
            this.navBarGroup1.ControlContainer = this.navBarGroupControlContainer1;
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupClientHeight = 371;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer1.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer1.Controls.Add(this.groupBox2);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(470, 388);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox13);
            this.groupBox2.Controls.Add(this.txtDiaDiemPB);
            this.groupBox2.Controls.Add(this.txtMaTP);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtDienThoaiPB);
            this.groupBox2.Controls.Add(this.txtEmailPB);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtTenPB);
            this.groupBox2.Controls.Add(this.txtMaPB);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 368);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.cmbKey);
            this.groupBox13.Controls.Add(this.button14);
            this.groupBox13.Controls.Add(this.label34);
            this.groupBox13.Controls.Add(this.cboTimKiem);
            this.groupBox13.Location = new System.Drawing.Point(12, 29);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(446, 67);
            this.groupBox13.TabIndex = 66;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = " ";
            // 
            // cmbKey
            // 
            this.cmbKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbKey.FormattingEnabled = true;
            this.cmbKey.Location = new System.Drawing.Point(62, 23);
            this.cmbKey.Name = "cmbKey";
            this.cmbKey.Size = new System.Drawing.Size(197, 21);
            this.cmbKey.TabIndex = 12;
            this.cmbKey.Click += new System.EventHandler(this.cmbKey_Click);
            // 
            // button14
            // 
            this.button14.BackgroundImage = global::GUI_Quanlydetai.Properties.Resources.search_1_;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.Location = new System.Drawing.Point(285, 21);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(30, 28);
            this.button14.TabIndex = 9;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 29);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(50, 13);
            this.label34.TabIndex = 7;
            this.label34.Text = "Từ khóa:";
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Items.AddRange(new object[] {
            "Mã phòng ban",
            "Tên phòng ban"});
            this.cboTimKiem.Location = new System.Drawing.Point(326, 23);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(108, 21);
            this.cboTimKiem.TabIndex = 10;
            this.cboTimKiem.Text = "Nâng cao";
            // 
            // txtDiaDiemPB
            // 
            this.txtDiaDiemPB.Location = new System.Drawing.Point(332, 232);
            this.txtDiaDiemPB.Name = "txtDiaDiemPB";
            this.txtDiaDiemPB.Size = new System.Drawing.Size(126, 20);
            this.txtDiaDiemPB.TabIndex = 56;
            // 
            // txtMaTP
            // 
            this.txtMaTP.Location = new System.Drawing.Point(104, 232);
            this.txtMaTP.Name = "txtMaTP";
            this.txtMaTP.Size = new System.Drawing.Size(126, 20);
            this.txtMaTP.TabIndex = 55;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(261, 235);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 45;
            this.label19.Text = "Địa Điểm :";
            // 
            // txtDienThoaiPB
            // 
            this.txtDienThoaiPB.Location = new System.Drawing.Point(332, 192);
            this.txtDienThoaiPB.Name = "txtDienThoaiPB";
            this.txtDienThoaiPB.Size = new System.Drawing.Size(126, 20);
            this.txtDienThoaiPB.TabIndex = 43;
            // 
            // txtEmailPB
            // 
            this.txtEmailPB.Location = new System.Drawing.Point(332, 164);
            this.txtEmailPB.Name = "txtEmailPB";
            this.txtEmailPB.Size = new System.Drawing.Size(126, 20);
            this.txtEmailPB.TabIndex = 42;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(263, 199);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "Điện thoại:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(263, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Email:";
            // 
            // txtTenPB
            // 
            this.txtTenPB.Location = new System.Drawing.Point(104, 198);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(126, 20);
            this.txtTenPB.TabIndex = 33;
            // 
            // txtMaPB
            // 
            this.txtMaPB.Location = new System.Drawing.Point(104, 167);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(126, 20);
            this.txtMaPB.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Mã TP :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Tên Phòng Ban :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Mã Phòng Ban :";
            // 
            // frm_PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 524);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_PhongBan";
            this.Text = "frm_PhongBan";
            this.Load += new System.EventHandler(this.frm_PhongBan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.navBarControl1.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl grdPhongBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDienThoaiPB;
        private System.Windows.Forms.TextBox txtEmailPB;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPB;
        private DevExpress.XtraGrid.Columns.GridColumn colTenPB;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTP;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaDiem;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private System.Windows.Forms.TextBox txtDiaDiemPB;
        private System.Windows.Forms.TextBox txtMaTP;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.ComboBox cmbKey;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox cboTimKiem;

    }
}