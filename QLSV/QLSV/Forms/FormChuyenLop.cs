using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class FormChuyenLop : Form
    {
        public FormChuyenLop()
        {
            InitializeComponent();
        }

        private void FormChuyenLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);
            // TODO: This line of code loads data into the 'qLDSVDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'qLDSVDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);
            

        }

        private void maSinhVien_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            DataRowView dataRow = maSinhVien.GetSelectedDataRow() as DataRowView;
            if(dataRow != null)
            {
                ten.Text = (string)dataRow["HO"] + " " + (string)dataRow["TEN"];
                if((bool)dataRow["PHAI"])
                {
                    phai.Text = "Nam";
                }
                else
                {
                    phai.Text = "Nữ";
                }
                namSinh.Text = dataRow["NGAYSINH"].ToString();
            }
        }

        private void maSinhVien_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView dataRow = maSinhVien.GetSelectedDataRow() as DataRowView;
            if (dataRow != null)
            {
                ten.Text = (string)dataRow["HO"] + " " + (string)dataRow["TEN"];
                if ((bool)dataRow["PHAI"])
                {
                    phai.Text = "Nam";
                }
                else
                {
                    phai.Text = "Nữ";
                }
                namSinh.Text = dataRow["NGAYSINH"].ToString();
            }
        }
    }
}
