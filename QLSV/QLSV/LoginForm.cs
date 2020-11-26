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
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qLDSVDataSet.V_DSPM);
            Program.servername = comboBoxKhoa.SelectedValue.ToString();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.servername = comboBoxKhoa.SelectedValue.ToString();

        }

        //private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (userName.Text.Trim().Equals("") && passWord.Text.Trim().Equals(""))
        //    {
        //        Environment.Exit(0);
        //    }
        //    if (e.CloseReason == CloseReason.UserClosing)
        //    {
        //        DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thoát Đăng Nhập", MessageBoxButtons.YesNo);
        //        if (result == DialogResult.Yes)
        //        {
        //            Environment.Exit(0);
        //        }
        //        else
        //        {
        //            e.Cancel = true;
        //        }
        //    }
        //    else
        //    {
        //        e.Cancel = true;
        //    }
        //}

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(userName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên tài khoản không được rỗng","Lỗi",MessageBoxButtons.OK);
                userName.Focus();
                return;

            }
            else if (passWord.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mật khẩu không được rỗng", "Lỗi", MessageBoxButtons.OK);
                passWord.Focus();
                return;
            }
            else
            {
                Program.mlogin = userName.Text;
                Program.password = passWord.Text;
                if (Program.KetNoi() == 1)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    //MessageBox.Show("Tài khoản không tồn tại", "Lỗi", MessageBoxButtons.OK);
                    userName.Clear();
                    passWord.Clear();
                    userName.Focus();
                    return;
                }
                
            }
        }
    }
}