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
            // TODO: This line of code loads data into the 'qLDSVDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet.SINHVIEN);
            if (Program.mGroup.Equals("PGV"))
            {
                // TODO: This line of code loads data into the 'qLDSVDataSet.KHOA' table. You can move, or remove it, as needed.
                this.kHOATableAdapter.Fill(this.qLDSVDataSet.KHOA);
                cbKhoa.SelectedIndex = 0;

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
                //đổ dữ liệu vào combo box theo lớp
                DataTable dtsv = new DataTable();
                //gọi 1 view và trả về dưới dạng datatable
                dtsv = Program.ExecSqlDataTable("SELECT * FROM V_DSSV_TaoTK SV WHERE SV.MALOP = '" + cbLop.SelectedValue.ToString() + "'");
                // cất dt vào biến toàn cục Bds_Dspm
                Program.bds.DataSource = dtsv;
                cbMaSinhVien.DataSource = dtsv;
                cbMaSinhVien.DisplayMember = "HOTEN";
                cbMaSinhVien.ValueMember = "MASV";
                //maSV.Text = cbMaSinhVien.SelectedValue.ToString();

            }
            else if (Program.mGroup.Equals("KHOA"))
            {
                // TODO: This line of code loads data into the 'qLDSVDataSet.V_GETDSLOP' table. You can move, or remove it, as needed.
                this.v_GETDSLOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.v_GETDSLOPTableAdapter.Fill(this.qLDSVDataSet.V_GETDSLOP);
                cbLop.SelectedIndex = 0;

                //cbMaSinhVien.SelectedIndex = 0;
                // TODO: This line of code loads data into the 'qLDSVDataSet.KHOA' table. You can move, or remove it, as needed.
                this.kHOATableAdapter.Fill(this.qLDSVDataSet.KHOA);
                //để combobox chạy đúng
                cbKhoa.SelectedIndex = 0;
                //khóa hiển thị combobox khoa
                cbKhoa.SelectedIndex = Program.mKhoa;
                cbKhoa.DropDownStyle = ComboBoxStyle.Simple;
                maLop.Text = cbLop.SelectedValue.ToString();
                
                //đổ dữ liệu vào combo box theo lớp
                DataTable dtsv = new DataTable();
                //gọi 1 view và trả về dưới dạng datatable
                dtsv = Program.ExecSqlDataTable("SELECT * FROM V_DSSV_TaoTK SV WHERE SV.MALOP = '" + cbLop.SelectedValue.ToString() + "'");
                // cất dt vào biến toàn cục Bds_Dspm
                Program.bds.DataSource = dtsv;
                cbMaSinhVien.DataSource = dtsv;
                cbMaSinhVien.DisplayMember = "HOTEN";
                cbMaSinhVien.ValueMember = "MASV";
            }
            if (cbLop.SelectedValue != null)
            {
                maLop.Text = cbLop.SelectedValue.ToString();
            }
            if (cbMaSinhVien.SelectedValue != null)
            {
                maSV.Text = cbMaSinhVien.SelectedValue.ToString();
            }
                
                
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLop.SelectedValue != null)
            {
                //đổ dữ liệu vào combo box theo lớp
                DataTable dtsv = new DataTable();
                //gọi 1 view và trả về dưới dạng datatable
                dtsv = Program.ExecSqlDataTable("SELECT * FROM LINK0.QLDSV.dbo.V_DSSV_TaoTK SV WHERE SV.MALOP = '" + cbLop.SelectedValue.ToString() + "'");
                // cất dt vào biến toàn cục Bds_Dspm
                Program.bds.DataSource = dtsv;
                cbMaSinhVien.DataSource = dtsv;
                cbMaSinhVien.DisplayMember = "HOTEN";
                cbMaSinhVien.ValueMember = "MASV";
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
            DataTable dtsv = new DataTable();
            //gọi 1 view và trả về dưới dạng datatable
            dtsv = Program.ExecSqlDataTable("SELECT * FROM LINK0.QLDSV.dbo.V_DSSV_TaoTK SV WHERE SV.MASV = '" + txMaSinhVien.Text + "'");
            // cất dt vào biến toàn cục Bds_Dspm
            Program.bds.DataSource = dtsv;
           
            PHIEUDIEM rpPhieuDiem = new PHIEUDIEM(txMaSinhVien.Text);
            rpPhieuDiem.xrLabel1.Text = "SINH VIÊN: " + ((DataRowView)Program.bds[0])["HOTEN"].ToString().ToUpper() + " - " + txMaSinhVien.Text.ToUpper();
            ReportPrintTool rp = new ReportPrintTool(rpPhieuDiem);
            rp.ShowPreviewDialog();
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbKhoa.SelectedValue!=null)
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

                cbLop.SelectedIndex = 0;
            }
        }

        private void inBtn_Click(object sender, EventArgs e)
        {
            PHIEUDIEM rpPhieuDiem = new PHIEUDIEM(maSV.Text);
            rpPhieuDiem.xrLabel1.Text = "SINH VIÊN: " + cbMaSinhVien.Text.ToUpper() + " - " + maSV.Text.ToUpper();
            ReportPrintTool rp = new ReportPrintTool(rpPhieuDiem);
            
            rp.ShowPreviewDialog();
        }

        private void txMaSinhVien_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView dataRow = txMaSinhVien.GetSelectedDataRow() as DataRowView;
            if (dataRow != null)
            {
                inBnt.Enabled = true;
                errorML.Clear();
            }
            else
            {
                errorML.SetError(txMaSinhVien, "Mã Sinh Viên không có!");
                inBnt.Enabled = false;
            }
        }


        private void txMaSinhVien_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            txMaSinhVien_EditValueChanged(sender, e);
        }
    }
}