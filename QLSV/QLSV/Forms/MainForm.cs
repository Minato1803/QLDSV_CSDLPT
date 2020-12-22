using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLSV
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public MainForm(String rule, String name)
        {
            InitializeComponent();
            initForm(rule, name);
            this.FormClosing += MainForm_FormClosing;
            ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
        }

        // khởi tạo các thành phần
        private void initForm(String rule, String name)
        {
            bottomRule.Caption = rule;
            bottomName.Caption = name;
            if(Program.mGroup == "PGV" || Program.mGroup == "KHOA")
            {
                qlHocPhi.Enabled = false;
                dsDongHocPhi.Enabled = false;
            }
        }

        private void thongTin_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void taoTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FormTaoTaiKhoan));
        }

        private void dangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Program.logged = false;
            Program.frmLogin.logOut();
            this.Close();
            Program.frmLogin.Show();
        }

        private void qlLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FormLop));
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.logged)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Program.frmLogin.Close();
                        this.Dispose();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }

        }

        private void qlMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FormMonHoc));
        }

        private void ShowMdiChildren(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    f.WindowState = FormWindowState.Maximized;
                    f.Activate();
                    return;
                }
            }
            Form form = (Form)Activator.CreateInstance(fType);
            form.MdiParent = this;
            form.Show();
        }

        private void qlSinhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FormSinhVien));
        }

        private void qlDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FormDiem));
        }

        private void qlHocPhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FormHocPhi));
        }

        private void dsSinhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(ReportDSSinhVien));
        }

        private void dsDongHocPhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(ReportDSDongHocPhi));
        }

        private void bangDiemThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(ReportBangDiemThi));
        }

        private void bangDiemMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(ReportBDMonHoc));
        }

        private void bangDiemTongKet_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(ReportBDTongKet));
        }

        private void phieuDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(ReportPhieuDiem));
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FormChuyenLop));
        }
    }

    
}