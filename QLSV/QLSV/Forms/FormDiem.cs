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
    public partial class FormDiem : DevExpress.XtraEditors.XtraForm
    {
        public FormDiem()
        {
            InitializeComponent();
        }

        private void quitFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void FormDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qLDSVDataSet.V_DSPM);
            if (Program.mGroup == "PGV")
            {
                DataTable dt = new DataTable();
                dt = this.qLDSVDataSet.V_DSPM;
                dt.Rows[2].Delete();
                Program.bds_khoa.DataSource = dt;
                cbKhoa.DataSource = dt;
                cbKhoa.DisplayMember = "TENKHOA";
                cbKhoa.ValueMember = "TENSERVER";
                cbKhoa.SelectedIndex = Program.mKhoa;
            }
            else if (Program.mGroup == "KHOA")
            {
                cbKhoa.SelectedIndex = Program.mKhoa;
                cbKhoa.DropDownStyle = ComboBoxStyle.Simple;
            }
            // TODO: This line of code loads data into the 'qLDSVDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);

            // TODO: This line of code loads data into the 'qLDSVDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.qLDSVDataSet.MONHOC);


            // TODO: This line of code loads data into the 'qLDSVDataSet.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Fill(this.qLDSVDataSet.DIEM);

        }
    }
}