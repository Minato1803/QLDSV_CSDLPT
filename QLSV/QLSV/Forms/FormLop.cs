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
    public partial class FormLop : DevExpress.XtraEditors.XtraForm
    {
        public FormLop()
        {
            InitializeComponent();
        }

        private void quitFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}