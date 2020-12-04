using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLSV.Reports
{
    public partial class BDMH : DevExpress.XtraReports.UI.XtraReport
    {
        public BDMH(string maLop, string maMH, string lan)
        {
            InitializeComponent();
            this.sP_getBangDiemMonHocTableAdapter.Fill(qldsvDataSet1.SP_getBangDiemMonHoc, maLop, maMH, int.Parse(lan));
        }

    }
}
