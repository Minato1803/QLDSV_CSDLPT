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
            ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
        }

        // khởi tạo các thành phần
        private void initForm(String rule, String name)
        {
            bottomRule.Caption = rule;
            bottomName.Caption = name;
        }

        private void thongTin_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void taoTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void dangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void qlLop_ItemClick(object sender, ItemClickEventArgs e)
        {

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
                        Environment.Exit(0);
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

    }

    
}