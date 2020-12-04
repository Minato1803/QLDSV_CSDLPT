using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLSV.Reports
{
    public partial class BangDiemTongKet : DevExpress.XtraReports.UI.XtraReport
    {
        public BangDiemTongKet(String maLop)
        {
            InitializeComponent();
            qldsvDataSet1.EnforceConstraints = false;
            this.sP_getBangDiemTongKetTableAdapter.Fill(qldsvDataSet1.SP_getBangDiemTongKet, maLop);
        }

    }
}
