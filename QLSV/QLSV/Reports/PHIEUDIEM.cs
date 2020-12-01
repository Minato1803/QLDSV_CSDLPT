using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLSV
{
    public partial class PHIEUDIEM : DevExpress.XtraReports.UI.XtraReport
    {
        public PHIEUDIEM(string mssv)
        {
            InitializeComponent();
            qldsvDataSet2.EnforceConstraints = false;
            this.sP_getPhieuDiemTableAdapter.Fill(qldsvDataSet2.SP_getPhieuDiem, mssv);
        }

    }
}
