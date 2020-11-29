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
    public partial class FormTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet1.GIANGVIEN' table. You can move, or remove it, as needed.
            //this.gIANGVIENTableAdapter.Fill(this.qLDSVDataSet1.GIANGVIEN);
            // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DSSV_TaoTK' table. You can move, or remove it, as needed.
            this.v_DSSV_TaoTKTableAdapter1.Fill(this.qLDSVDataSet1.V_DSSV_TaoTK);
            // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DSGV' table. You can move, or remove it, as needed.
            this.v_DSGVTableAdapter1.Fill(this.qLDSVDataSet1.V_DSGV);
            // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter1.Fill(this.qLDSVDataSet1.V_DSPM);


            tabNavigationPage2.PageVisible = false;
        }

        private void dangkiGiaoVien_Click(object sender, EventArgs e)
        {

        }

        private bool CheckInfo()
        {
            bool check = false;


            if(string.IsNullOrEmpty(this.userName.Text))
                    {
                MessageBox.Show("Tên tài khoản không được rỗng", "Lỗi", MessageBoxButtons.OK);
                userName.Focus();
            }
            else if (userName.Text.Contains(" "))
            {
                MessageBox.Show("không được chứa khoảng trắng trong tên", "Lỗi", MessageBoxButtons.OK);
                userName.Focus();
            }
            else if (string.IsNullOrEmpty(this.passWord.Text))
            {
                MessageBox.Show("Mật khẩu không được rỗng", "Lỗi", MessageBoxButtons.OK);
                passWord.Focus();
            }
            else if (string.IsNullOrEmpty(this.confirmPassWord.Text))
            {
                MessageBox.Show("Mật khẩu không được rỗng", "Lỗi", MessageBoxButtons.OK);
                confirmPassWord.Focus();
            }
            else if (confirmPassWord.Text != passWord.Text)
            {
                MessageBox.Show("Mật khẩu không khớp", "Lỗi", MessageBoxButtons.OK);
                confirmPassWord.Focus();
            }
            else
            {
                check = true;
            }

            return check;
        }

        private void clearGiaoVien_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}