﻿using System;
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
            if (Program.mGroup.Equals("PGV") || Program.mGroup.Equals("PkeToan"))
            {
                // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DSPM' table. You can move, or remove it, as needed.
                this.v_DSPMTableAdapter.Fill(this.qLDSVDataSet.V_DSPM);
                cbKhoa.SelectedIndex = Program.mKhoa;
                // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DSGV' table. You can move, or remove it, as needed.

                // TODO: This line of code loads data into the 'qLDSVDataSet.V_GETDSLOP' table. You can move, or remove it, as needed.
                this.v_GETDSLOPTableAdapter.Fill(this.qLDSVDataSet.V_GETDSLOP);
                cbLop.SelectedIndex = 0;

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
                // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DSGV' table. You can move, or remove it, as needed.
                // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DSPM' table. You can move, or remove it, as needed.
                this.v_DSPMTableAdapter.Fill(this.qLDSVDataSet.V_DSPM);
                //để combobox chạy đúng
                cbKhoa.SelectedIndex = 0;
                //khóa hiển thị combobox khoa
                cbKhoa.SelectedIndex = Program.mKhoa;
                cbKhoa.DropDownStyle = ComboBoxStyle.Simple;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLop.SelectedValue != null)
            {
                maLop.Text = cbLop.SelectedValue.ToString();
            }
        }
    }
}