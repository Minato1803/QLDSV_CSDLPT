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

namespace QLSV
{
    public partial class ReportBDMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public ReportBDMonHoc()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportBDMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLDSVDataSet.MONHOC);
            
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

                DataTable dtMon = new DataTable();
                if (Program.TKhoa[cbKhoa.SelectedIndex] != Program.TKhoa[Program.mKhoa])
                {
                    cmd = "SELECT * FROM LINK1.QLDSV.dbo.MONHOC";
                }
                else
                {
                    cmd = "SELECT * FROM MONHOC";
                }
                dtMon = Program.ExecSqlDataTable(cmd);
                // cất dt vào biến toàn cục Bds_Dspm
                Program.bds_mon.DataSource = dtMon;
                cbMon.DataSource = dtMon;
                cbMon.DisplayMember = "TENMH";
                cbMon.ValueMember = "MAMH";

                cbMon.SelectedIndex = 0;
            }
            else if (Program.mGroup.Equals("KHOA"))
            {
                // TODO: This line of code loads data into the 'qLDSVDataSet.V_GETDSLOP' table. You can move, or remove it, as needed.
                this.v_GETDSLOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.v_GETDSLOPTableAdapter.Fill(this.qLDSVDataSet.V_GETDSLOP);
                cbLop.SelectedIndex = 0;
                // TODO: This line of code loads data into the 'qLDSVDataSet.KHOA' table. You can move, or remove it, as needed.
                this.kHOATableAdapter.Fill(this.qLDSVDataSet.KHOA);
                //để combobox chạy đúng
                cbKhoa.SelectedIndex = 0;
                //khóa hiển thị combobox khoa
                cbKhoa.SelectedIndex = Program.mKhoa;
                cbKhoa.DropDownStyle = ComboBoxStyle.Simple;

                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.qLDSVDataSet.MONHOC);
                cbMon.SelectedIndex = 0;
            }
            maLop.Text = cbLop.SelectedValue.ToString();
            maMon.Text = cbMon.SelectedValue.ToString();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLop.SelectedValue != null)
            {
                maLop.Text = cbLop.SelectedValue.ToString();
            }
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbKhoa.SelectedValue != null)
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

                DataTable dtMon = new DataTable();
                if (Program.TKhoa[cbKhoa.SelectedIndex] != Program.TKhoa[Program.mKhoa])
                {
                    cmd = "SELECT * FROM LINK1.QLDSV.dbo.MONHOC";
                }
                else
                {
                    cmd = "SELECT * FROM MONHOC";
                }
                dtMon = Program.ExecSqlDataTable(cmd);
                // cất dt vào biến toàn cục Bds_Dspm
                Program.bds_mon.DataSource = dtMon;
                cbMon.DataSource = dtMon;
                cbMon.DisplayMember = "TENMH";
                cbMon.ValueMember = "MAMH";

                cbMon.SelectedIndex = 0;
            }
        }

        private void cbMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMon.SelectedValue != null)
            {
                maMon.Text = cbMon.SelectedValue.ToString();
            }
        }
    }
}