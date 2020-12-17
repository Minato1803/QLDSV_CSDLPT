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
            // TODO: This line of code loads data into the 'qLDSVDataSet.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Fill(this.qLDSVDataSet.DIEM);

        }
    }
}