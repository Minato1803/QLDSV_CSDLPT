using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLSV.Reports
{
    public partial class BDTHI : DevExpress.XtraReports.UI.XtraReport
    {
        public BDTHI(String Malop, String MaMH, int lan)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_REPORT_BDTHITableAdapter.Fill(ds1.SP_REPORT_BDTHI, Malop, MaMH, lan);
        }

    }
}
