using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLSV.Reports
{
    public partial class DSDHP : DevExpress.XtraReports.UI.XtraReport
    {
        public DSDHP(String maLop, String NK, int HK)
        {
            Console.WriteLine(maLop + "------" + NK + "--------" + HK);
            InitializeComponent();
            ds1.EnforceConstraints = false;
            //this.sP_REPORT_DSDHPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_REPORT_DSDHPTableAdapter.Fill(ds1.SP_REPORT_DSDHP, maLop, NK,HK);
        }

    }
}
