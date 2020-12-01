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
using DevExpress.XtraReports.UI;

namespace QLSV
{
    public partial class ReportPhieuDiem : DevExpress.XtraEditors.XtraForm
    {
        public ReportPhieuDiem()
        {
            InitializeComponent();
            txMaSinhVien.Select();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ReportPhieuDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DSSV_TaoTK' table. You can move, or remove it, as needed.
            this.v_DSSV_TaoTKTableAdapter.Fill(this.qLDSVDataSet.V_DSSV_TaoTK);
            this.v_GETDSLOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_GETDSLOPTableAdapter.Fill(this.qLDSVDataSet.V_GETDSLOP);
            cbLop.SelectedIndex = 0;

            //đổ dữ liệu vào combo box theo lớp
            DataTable dt = new DataTable();
            //gọi 1 view và trả về dưới dạng datatable
            dt = Program.ExecSqlDataTable("SELECT * FROM V_DSSV_TaoTK SV WHERE SV.MALOP = '" + cbLop.SelectedValue.ToString() + "'");
            // cất dt vào biến toàn cục Bds_Dspm
            Program.bds.DataSource = dt;
            cbMaSinhVien.DataSource = dt;
            cbMaSinhVien.DisplayMember = "HOTEN";
            cbMaSinhVien.ValueMember = "MASV";
            maLop.Text = cbLop.SelectedValue.ToString();
            maSV.Text = cbMaSinhVien.SelectedValue.ToString();

            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qLDSVDataSet.V_DSPM);

        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLop.SelectedValue != null)
            {
                DataTable dt = new DataTable();
                dt = Program.ExecSqlDataTable("SELECT * FROM LINK0.QLDSV.dbo.V_DSSV_TaoTK SV WHERE SV.MALOP = '" + cbLop.SelectedValue.ToString() + "'");
                Program.bds.DataSource = dt;
                cbMaSinhVien.DataSource = dt;
                cbMaSinhVien.DisplayMember = "HOTEN";
                cbMaSinhVien.ValueMember = "MASV";
                //cbMaSinhVien.SelectedIndex = 0;
                maLop.Text = cbLop.SelectedValue.ToString();
            }
            
        }

        private void cbMaSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbMaSinhVien.SelectedValue != null)
            {
                maSV.Text = cbMaSinhVien.SelectedValue.ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PHIEUDIEM rpPhieuDiem = new PHIEUDIEM(txMaSinhVien.Text);
            ReportPrintTool rp = new ReportPrintTool(rpPhieuDiem);
            rp.ShowPreviewDialog();
        }
    }
}