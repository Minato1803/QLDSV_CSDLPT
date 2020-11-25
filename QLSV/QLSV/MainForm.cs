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
        
        public MainForm()
        {
            InitializeComponent();
            ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
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
    }
}