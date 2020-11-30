using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLSV.Reports
{
    public partial class DSSV : DevExpress.XtraReports.UI.XtraReport
    {
        public DSSV(String maLop)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_REPORT_DSSVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_REPORT_DSSVTableAdapter.Fill(ds1.SP_REPORT_DSSV, maLop);
        }

    }
}
