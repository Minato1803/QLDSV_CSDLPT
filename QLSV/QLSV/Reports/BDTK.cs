using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLSV.Reports
{
    public partial class BDTK : DevExpress.XtraReports.UI.XtraReport
    {
        public BDTK(string maLop)
        {
            InitializeComponent();
            qldsvDataSet2.EnforceConstraints = false;
            this.sP_getBangDiemTongKetTableAdapter.Fill(qldsvDataSet2.SP_getBangDiemTongKet, maLop);
        }

    }
}
