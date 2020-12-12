using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLSV.Reports;
using DevExpress.XtraReports.UI;

namespace QLSV
{
    public partial class ReportDSDongHocPhi : DevExpress.XtraEditors.XtraForm
    {
        public ReportDSDongHocPhi()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportDSDongHocPhi_Load(object sender, EventArgs e)
        {

                // TODO: This line of code loads data into the 'qLDSVDataSet.KHOA' table. You can move, or remove it, as needed.
                this.kHOATableAdapter.Fill(this.qLDSVDataSet.KHOA);
                cbKhoa.SelectedIndex = 0;

                // TODO: This line of code loads data into the 'qLDSVDataSet.V_GETDSLOP' table. You can move, or remove it, as needed.
                DataTable dtLop = new DataTable();
                //gọi 1 view và trả về dưới dạng datatable
                string cmd = "SELECT * FROM LINK0.QLDSV.dbo.V_GETDSLOP L WHERE L.MAKH = '" + Program.TKhoa[cbKhoa.SelectedIndex] + "'";
                dtLop = Program.ExecSqlDataTable(cmd);
                // cất dt vào biến toàn cục Bds_Dspm
                Program.bds_lop.DataSource = dtLop;
                cbLop.DataSource = dtLop;
                cbLop.DisplayMember = "TENLOP";
                cbLop.ValueMember = "MALOP";
                cbLop.SelectedIndex = 0;

        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLop.SelectedValue != null)
            {
                maLop.Text = cbLop.SelectedValue.ToString();
            }
        }

        private void inBtn_Click(object sender, EventArgs e)
        {
            DSDHP report = new DSDHP(maLop.Text, nienKhoa.Value.ToString(), (int)kiHoc.Value);
            report.lblLop.Text = cbLop.Text;
            report.lblNguoiIn.Text = "Người In Ấn : " + Program.mHoten;
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }


        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbKhoa.SelectedValue !=null)
            {
                DataTable dtLop = new DataTable();
                //gọi 1 view và trả về dưới dạng datatable
                string cmd = "SELECT * FROM LINK0.QLDSV.dbo.V_GETDSLOP L WHERE L.MAKH = '" + Program.TKhoa[cbKhoa.SelectedIndex] + "'";
                dtLop = Program.ExecSqlDataTable(cmd);
                // cất dt vào biến toàn cục Bds_Dspm
                Program.bds_lop.DataSource = dtLop;
                cbLop.DataSource = dtLop;
                cbLop.DisplayMember = "TENLOP";
                cbLop.ValueMember = "MALOP";
            }
        }
    }
}