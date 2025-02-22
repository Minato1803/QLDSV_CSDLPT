﻿namespace QLSV
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.dangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.thongTin = new DevExpress.XtraBars.BarButtonItem();
            this.taoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.qlLop = new DevExpress.XtraBars.BarButtonItem();
            this.qlMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.qlSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.qlDiem = new DevExpress.XtraBars.BarButtonItem();
            this.qlHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.bottomName = new DevExpress.XtraBars.BarStaticItem();
            this.bottomRule = new DevExpress.XtraBars.BarStaticItem();
            this.dsSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.dsDongHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.bangDiemThi = new DevExpress.XtraBars.BarButtonItem();
            this.bangDiemMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.bangDiemTongKet = new DevExpress.XtraBars.BarButtonItem();
            this.phieuDiem = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.qlChuyenLop = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.dangXuat,
            this.thongTin,
            this.taoTaiKhoan,
            this.qlLop,
            this.qlMonHoc,
            this.qlSinhVien,
            this.qlDiem,
            this.qlHocPhi,
            this.bottomName,
            this.bottomRule,
            this.dsSinhVien,
            this.dsDongHocPhi,
            this.bangDiemThi,
            this.bangDiemMonHoc,
            this.bangDiemTongKet,
            this.phieuDiem,
            this.barStaticItem1,
            this.barStaticItem2,
            this.qlChuyenLop});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbon.MaxItemId = 25;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 385;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.Size = new System.Drawing.Size(1491, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // dangXuat
            // 
            this.dangXuat.Caption = "Đăng Xuất";
            this.dangXuat.Id = 3;
            this.dangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("dangXuat.ImageOptions.SvgImage")));
            this.dangXuat.Name = "dangXuat";
            this.dangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.dangXuat_ItemClick);
            // 
            // thongTin
            // 
            this.thongTin.Caption = "Thông Tin";
            this.thongTin.Id = 4;
            this.thongTin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("thongTin.ImageOptions.SvgImage")));
            this.thongTin.LargeWidth = 70;
            this.thongTin.Name = "thongTin";
            this.thongTin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.thongTin_ItemClick);
            // 
            // taoTaiKhoan
            // 
            this.taoTaiKhoan.Caption = "Tạo Tài Khoản";
            this.taoTaiKhoan.Id = 5;
            this.taoTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("taoTaiKhoan.ImageOptions.SvgImage")));
            this.taoTaiKhoan.LargeWidth = 100;
            this.taoTaiKhoan.Name = "taoTaiKhoan";
            this.taoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.taoTaiKhoan_ItemClick);
            // 
            // qlLop
            // 
            this.qlLop.Caption = "LỚP";
            this.qlLop.Id = 6;
            this.qlLop.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("qlLop.ImageOptions.SvgImage")));
            this.qlLop.LargeWidth = 75;
            this.qlLop.Name = "qlLop";
            this.qlLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.qlLop_ItemClick);
            // 
            // qlMonHoc
            // 
            this.qlMonHoc.Caption = "MÔN HỌC";
            this.qlMonHoc.Id = 7;
            this.qlMonHoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("qlMonHoc.ImageOptions.SvgImage")));
            this.qlMonHoc.LargeWidth = 75;
            this.qlMonHoc.Name = "qlMonHoc";
            this.qlMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.qlMonHoc_ItemClick);
            // 
            // qlSinhVien
            // 
            this.qlSinhVien.Caption = "SINH VIÊN";
            this.qlSinhVien.Id = 8;
            this.qlSinhVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("qlSinhVien.ImageOptions.SvgImage")));
            this.qlSinhVien.LargeWidth = 75;
            this.qlSinhVien.Name = "qlSinhVien";
            this.qlSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.qlSinhVien_ItemClick);
            // 
            // qlDiem
            // 
            this.qlDiem.Caption = "ĐIỂM";
            this.qlDiem.Id = 9;
            this.qlDiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("qlDiem.ImageOptions.SvgImage")));
            this.qlDiem.LargeWidth = 75;
            this.qlDiem.Name = "qlDiem";
            this.qlDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.qlDiem_ItemClick);
            // 
            // qlHocPhi
            // 
            this.qlHocPhi.Caption = "HỌC PHÍ";
            this.qlHocPhi.Id = 11;
            this.qlHocPhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("qlHocPhi.ImageOptions.SvgImage")));
            this.qlHocPhi.Name = "qlHocPhi";
            this.qlHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.qlHocPhi_ItemClick);
            // 
            // bottomName
            // 
            this.bottomName.Caption = "barStaticItem1";
            this.bottomName.Id = 13;
            this.bottomName.Name = "bottomName";
            // 
            // bottomRule
            // 
            this.bottomRule.Caption = "barStaticItem1";
            this.bottomRule.Id = 15;
            this.bottomRule.Name = "bottomRule";
            // 
            // dsSinhVien
            // 
            this.dsSinhVien.Caption = "Danh Sách Sinh Viên";
            this.dsSinhVien.Id = 16;
            this.dsSinhVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("dsSinhVien.ImageOptions.SvgImage")));
            this.dsSinhVien.LargeWidth = 100;
            this.dsSinhVien.Name = "dsSinhVien";
            this.dsSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.dsSinhVien_ItemClick);
            // 
            // dsDongHocPhi
            // 
            this.dsDongHocPhi.Caption = "Danh Sách Đóng Học Phí";
            this.dsDongHocPhi.Id = 17;
            this.dsDongHocPhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("dsDongHocPhi.ImageOptions.SvgImage")));
            this.dsDongHocPhi.LargeWidth = 100;
            this.dsDongHocPhi.Name = "dsDongHocPhi";
            this.dsDongHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.dsDongHocPhi_ItemClick);
            // 
            // bangDiemThi
            // 
            this.bangDiemThi.Caption = "Bảng Điểm Thi";
            this.bangDiemThi.Id = 18;
            this.bangDiemThi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bangDiemThi.ImageOptions.SvgImage")));
            this.bangDiemThi.LargeWidth = 100;
            this.bangDiemThi.Name = "bangDiemThi";
            this.bangDiemThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bangDiemThi_ItemClick);
            // 
            // bangDiemMonHoc
            // 
            this.bangDiemMonHoc.Caption = "Bảng Điểm Môn Học";
            this.bangDiemMonHoc.Id = 19;
            this.bangDiemMonHoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bangDiemMonHoc.ImageOptions.SvgImage")));
            this.bangDiemMonHoc.LargeWidth = 100;
            this.bangDiemMonHoc.Name = "bangDiemMonHoc";
            this.bangDiemMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bangDiemMonHoc_ItemClick);
            // 
            // bangDiemTongKet
            // 
            this.bangDiemTongKet.Caption = "Bảng Điểm Tổng Kết";
            this.bangDiemTongKet.Id = 20;
            this.bangDiemTongKet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bangDiemTongKet.ImageOptions.SvgImage")));
            this.bangDiemTongKet.LargeWidth = 100;
            this.bangDiemTongKet.Name = "bangDiemTongKet";
            this.bangDiemTongKet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bangDiemTongKet_ItemClick);
            // 
            // phieuDiem
            // 
            this.phieuDiem.Caption = "Phiếu Điểm";
            this.phieuDiem.Id = 21;
            this.phieuDiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("phieuDiem.ImageOptions.SvgImage")));
            this.phieuDiem.LargeWidth = 100;
            this.phieuDiem.Name = "phieuDiem";
            this.phieuDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.phieuDiem_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.AllowRightClickInMenu = false;
            this.barStaticItem1.Caption = "|";
            this.barStaticItem1.Id = 22;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.False;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.AllowRightClickInMenu = false;
            this.barStaticItem2.Caption = "|";
            this.barStaticItem2.Id = 23;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.False;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản Lý";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.qlMonHoc);
            this.ribbonPageGroup1.ItemLinks.Add(this.qlLop);
            this.ribbonPageGroup1.ItemLinks.Add(this.qlSinhVien);
            this.ribbonPageGroup1.ItemLinks.Add(this.qlDiem);
            this.ribbonPageGroup1.ItemLinks.Add(this.qlChuyenLop);
            this.ribbonPageGroup1.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Lớp Học";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.qlHocPhi);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Tài Chính";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup6});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Báo Cáo";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.dsSinhVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.dsDongHocPhi);
            this.ribbonPageGroup2.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Danh Sách";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.bangDiemThi);
            this.ribbonPageGroup6.ItemLinks.Add(this.bangDiemMonHoc);
            this.ribbonPageGroup6.ItemLinks.Add(this.bangDiemTongKet);
            this.ribbonPageGroup6.ItemLinks.Add(this.phieuDiem);
            this.ribbonPageGroup6.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Bảng Điểm";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Quản Trị";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.taoTaiKhoan);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Cơ Sở Dữ Liệu";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.thongTin);
            this.ribbonPageGroup4.ItemLinks.Add(this.dangXuat);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            this.ribbonPageGroup4.Text = "Hệ Thống";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bottomRule);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.bottomName);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 863);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1491, 22);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // qlChuyenLop
            // 
            this.qlChuyenLop.Caption = "CHUYỂN LỚP";
            this.qlChuyenLop.Id = 24;
            this.qlChuyenLop.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.qlChuyenLop.LargeWidth = 75;
            this.qlChuyenLop.Name = "qlChuyenLop";
            this.qlChuyenLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // MainForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 885);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.LargeImage")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản Lý Sinh Viên";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem dangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem thongTin;
        private DevExpress.XtraBars.BarButtonItem taoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem qlLop;
        private DevExpress.XtraBars.BarButtonItem qlMonHoc;
        private DevExpress.XtraBars.BarButtonItem qlSinhVien;
        private DevExpress.XtraBars.BarButtonItem qlDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem qlHocPhi;
        private DevExpress.XtraBars.BarStaticItem bottomName;
        private DevExpress.XtraBars.BarStaticItem bottomRule;
        private DevExpress.XtraBars.BarButtonItem dsSinhVien;
        private DevExpress.XtraBars.BarButtonItem dsDongHocPhi;
        private DevExpress.XtraBars.BarButtonItem bangDiemThi;
        private DevExpress.XtraBars.BarButtonItem bangDiemMonHoc;
        private DevExpress.XtraBars.BarButtonItem bangDiemTongKet;
        private DevExpress.XtraBars.BarButtonItem phieuDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarButtonItem qlChuyenLop;
    }
}