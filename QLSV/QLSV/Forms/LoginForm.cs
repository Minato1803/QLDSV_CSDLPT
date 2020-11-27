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
        private bool showPass = false;
        public LoginForm()
        {
            InitializeComponent();
            this.FormClosing += LoginForm_FormClosing;
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qLDSVDataSet.V_DSPM);
            Program.servername = comboBoxKhoa.SelectedValue.ToString();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxKhoa.SelectedValue != null)
                {
                    Program.servername = comboBoxKhoa.SelectedValue.ToString();
                }
                
            }
            catch (NullReferenceException ex)
            {

            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Program.logged)
            {
                if (userName.Text.Trim().Equals("") && passWord.Text.Trim().Equals(""))
                {
                    Environment.Exit(0);
                }
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thoát Đăng Nhập", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

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
                    MainForm main = new MainForm("Phòng giáo vụ","Tên");
                    main.Show();
                    this.Visible = false;
                    return;
                }
                else
                {
                    //MessageBox.Show("Tài khoản không tồn tại", "Lỗi", MessageBoxButtons.OK);
                    //userName.Clear();
                    passWord.Clear();
                    userName.Focus();
                    this.DialogResult = DialogResult.None;
                    return;
                }
                
            }
        }

        private void svgImageBox1_Click(object sender, EventArgs e)
        {
            if (showPass)
            {
                showPass = false;
                passWord.PasswordChar = '●';
                svgImageBox1.SvgImage = Properties.Resources.blind;
            }
            else
            {
                showPass = true;
                passWord.PasswordChar = '\0';
                svgImageBox1.SvgImage = Properties.Resources.eye;
            }
        }

        public void logOut()
        {
            passWord.Clear();
            userName.Clear();
            userName.Select();
        }

        private void userName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userName.Text))
            {
                epUsername.Icon = Properties.Resources.exclamation;
                epUsername.SetError(userName, "Tài khoản không được trống!");
            }
            else
            {
                epUsername.Clear();
            }
        }

        private void passWord_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passWord.Text))
            {
                epPassword.Icon = Properties.Resources.exclamation;
                epPassword.SetError(passWord, "Mật khẩu không được trống!");
            }
            else
            {
                epPassword.Clear();
            }
        }

        // giới hạn vị trí con trỏ khi nhập
        //private void passWord_TextChanged(object sender, EventArgs e)
        //{
        //    if (passWord.Text.Length>14)
        //    {
        //        passWord.Focus();
        //        passWord.Select(15,0);
        //    }

        //}

    }
}