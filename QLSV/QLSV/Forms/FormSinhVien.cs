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
    public partial class FormSinhVien : DevExpress.XtraEditors.XtraForm
    {
        public FormSinhVien()
        {
            InitializeComponent();
        }

        private void quitFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}