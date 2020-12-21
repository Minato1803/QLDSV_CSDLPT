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
    public partial class ReportBDTongKet : DevExpress.XtraEditors.XtraForm
    {
        public ReportBDTongKet()
        {
            InitializeComponent();
            txMaLop.Select();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ReportBDTongKet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);
            // TODO: This line of code loads data into the 'qLDSVDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet.SINHVIEN);

            if (Program.mGroup.Equals("PGV"))
            {
                // TODO: This line of code loads data into the 'qLDSVDataSet.KHOA' table. You can move, or remove it, as needed.
                this.kHOATableAdapter.Fill(this.qLDSVDataSet.KHOA);
                cbKhoa.SelectedIndex = Program.mKhoa;
            
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
            else if (Program.mGroup.Equals("KHOA"))
            {
                // TODO: This line of code loads data into the 'qLDSVDataSet.V_GETDSLOP' table. You can move, or remove it, as needed.
                this.v_GETDSLOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.v_GETDSLOPTableAdapter.Fill(this.qLDSVDataSet.V_GETDSLOP);
                cbLop.SelectedIndex = 0;

                //cbMaSinhVien.SelectedIndex = 0;
                // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DSGV' table. You can move, or remove it, as needed.
                // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DSPM' table. You can move, or remove it, as needed.
                this.v_DSPMTableAdapter.Fill(this.qLDSVDataSet.V_DSPM);
                //để combobox chạy đúng
                cbKhoa.SelectedIndex = 0;
                //khóa hiển thị combobox khoa
                cbKhoa.SelectedIndex = Program.mKhoa;
                cbKhoa.DropDownStyle = ComboBoxStyle.Simple;
            }
            if (cbLop.SelectedValue != null)
            {
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

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbKhoa.SelectedValue !=null)
            {
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
        }

        private void inBtn_Click(object sender, EventArgs e)
        {
            BDTK report = new BDTK(cbLop.SelectedValue.ToString());
            report.xrLabel1.Text = cbLop.Text.ToUpper();
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void inBtnNhap_Click(object sender, EventArgs e)
        {
            // lấy tên lớp từ mã lớp
            DataTable dtLop = new DataTable();
            //gọi 1 view và trả về dưới dạng datatable
            String cmd = "SELECT * FROM LINK0.QLDSV.dbo.V_GETDSLOP L WHERE L.MALOP = '" +  txMaLop.Text +"'";
            dtLop = Program.ExecSqlDataTable(cmd);
            Program.bds_lop.DataSource = dtLop;
            //Console.WriteLine(((DataRowView)Program.bds_lop[0])["TENLOP"].ToString());

            BDTK report = new BDTK(txMaLop.Text);
            report.xrLabel1.Text = ((DataRowView)Program.bds_lop[0])["TENLOP"].ToString().ToUpper();
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }
    }
}