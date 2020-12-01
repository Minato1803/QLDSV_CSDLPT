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
    public partial class ReportDSSinhVien : DevExpress.XtraEditors.XtraForm
    {
        public ReportDSSinhVien()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportDSSinhVien_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'qLDSVDataSet.V_DSSV_TaoTK' table. You can move, or remove it, as needed.

            //this.v_GETDSLOPTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.v_GETDSLOPTableAdapter.Fill(this.qLDSVDataSet.V_GETDSLOP);
            //cbLop.SelectedIndex = 0;
            //maLop.Text = cbLop.SelectedValue.ToString();

            //// TODO: This line of code loads data into the 'qLDSVDataSet.V_DSPM' table. You can move, or remove it, as needed.
            //this.v_DSPMTableAdapter.Fill(this.qLDSVDataSet.V_DSPM);


            if (Program.mGroup.Equals("PGV") || Program.mGroup.Equals("PkeToan"))
            {
                // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DSPM' table. You can move, or remove it, as needed.
                this.v_DSPMTableAdapter.Fill(this.qLDSVDataSet.V_DSPM);
                cbKhoa.SelectedIndex = Program.mKhoa;
                // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DSGV' table. You can move, or remove it, as needed.

                // TODO: This line of code loads data into the 'qLDSVDataSet.V_GETDSLOP' table. You can move, or remove it, as needed.
                this.v_GETDSLOPTableAdapter.Fill(this.qLDSVDataSet.V_GETDSLOP);
                cbLop.SelectedIndex = 0;
                maLop.Text = cbLop.SelectedValue.ToString();
                if (Program.mGroup.Equals("PkeToan"))
                {
                    //chỉ hiển thị pKeToan
                    cbKhoa.SelectedIndex = Program.mKhoa;
                    cbKhoa.DropDownStyle = ComboBoxStyle.Simple;
                }
            }
            else if (Program.mGroup.Equals("KHOA"))
            {
                // TODO: This line of code loads data into the 'qLDSVDataSet.V_GETDSLOP' table. You can move, or remove it, as needed.
                this.v_GETDSLOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.v_GETDSLOPTableAdapter.Fill(this.qLDSVDataSet.V_GETDSLOP);
                cbLop.SelectedIndex = 0;

                //cbMaSinhVien.SelectedIndex = 0;
                // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DSPM' table. You can move, or remove it, as needed.
                this.v_DSPMTableAdapter.Fill(this.qLDSVDataSet.V_DSPM);
                //để combobox chạy đúng
                cbKhoa.SelectedIndex = 0;
                //khóa hiển thị combobox khoa
                cbKhoa.SelectedIndex = Program.mKhoa;
                cbKhoa.DropDownStyle = ComboBoxStyle.Simple;
                maLop.Text = cbLop.SelectedValue.ToString();
            }

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
            DSSV report = new DSSV(this.cbLop.SelectedValue.ToString());
            report.lblLop.Text = cbLop.Text;
            report.lblGiangVien.Text = "Người In Ấn : " + Program.mHoten;
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }
    }
}