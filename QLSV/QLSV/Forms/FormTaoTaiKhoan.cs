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
using System.Data.SqlClient;

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
            if (Program.mGroup.Equals("PGV") || Program.mGroup.Equals("PkeToan"))
            {
                // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DSPM' table. You can move, or remove it, as needed.
                this.v_DSPMTableAdapter.Fill(this.qLDSVDataSet.V_DSPM);
                cbKhoa.SelectedIndex = Program.mKhoa;
                // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DSGV' table. You can move, or remove it, as needed.
                //đổ dữ liệu vào combobox theo khoa
                DataTable dtgv = new DataTable();
                //gọi 1 view và trả về dưới dạng datatable
                dtgv = Program.ExecSqlDataTable("SELECT * FROM LINK0.QLDSV.dbo.V_DSGV GV WHERE GV.MAKH = '" + Program.TKhoa[cbKhoa.SelectedIndex] + "'");
                // cất dt vào biến toàn cục Bds_Dspm
                Program.bds_dsgv.DataSource = dtgv;
                cbMaGiaoVien.DataSource = dtgv;
                cbMaGiaoVien.DisplayMember = "HOTEN";
                cbMaGiaoVien.ValueMember = "MAGV";
                //cbMaSinhVien.SelectedIndex = 0;

                // TODO: This line of code loads data into the 'qLDSVDataSet.V_GETDSLOP' table. You can move, or remove it, as needed.
                this.v_GETDSLOPTableAdapter.Fill(this.qLDSVDataSet.V_GETDSLOP);
                cbLop.SelectedIndex = 0;
                
                
                //đổ dữ liệu vào combo box theo lớp
                DataTable dtsv = new DataTable();
                //gọi 1 view và trả về dưới dạng datatable
                dtsv = Program.ExecSqlDataTable("SELECT * FROM LINK0.QLDSV.dbo.V_DSSV_TaoTK SV WHERE SV.MALOP = '" + cbLop.GetItemText(cbLop.SelectedItem) + "'");
                // cất dt vào biến toàn cục Bds_Dspm
                Program.bds.DataSource = dtsv;
                cbMaSinhVien.DataSource = dtsv;
                cbMaSinhVien.DisplayMember = "HOTEN";
                cbMaSinhVien.ValueMember = "MASV";
                cbMaSinhVien.SelectedIndex = 0;

                if (Program.mGroup.Equals("PkeToan"))
                {
                    //chỉ hiển thị pKeToan
                    cbKhoa.SelectedIndex = Program.mKhoa;
                    cbKhoa.DropDownStyle = ComboBoxStyle.Simple;
                    cbRoles.SelectedIndex = 3;
                    cbRoles.DropDownStyle = ComboBoxStyle.Simple;
                    tabSV.PageVisible = false;
                }
            }
            else if (Program.mGroup.Equals("KHOA"))
            {
                // TODO: This line of code loads data into the 'qLDSVDataSet.V_GETDSLOP' table. You can move, or remove it, as needed.
                this.v_GETDSLOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.v_GETDSLOPTableAdapter.Fill(this.qLDSVDataSet.V_GETDSLOP);
                cbLop.SelectedIndex = 0;
                
                //đổ dữ liệu vào combo box theo lớp
                DataTable dt = new DataTable();
                //gọi 1 view và trả về dưới dạng datatable
                dt = Program.ExecSqlDataTable("SELECT * FROM V_DSSV_TaoTK SV WHERE SV.MALOP = '" + cbLop.GetItemText(cbLop.SelectedItem) + "'");
                // cất dt vào biến toàn cục Bds_Dspm
                Program.bds.DataSource = dt;
                cbMaSinhVien.DataSource = dt;
                cbMaSinhVien.DisplayMember = "HOTEN";
                cbMaSinhVien.ValueMember = "MASV";
                //cbMaSinhVien.SelectedIndex = 0;
                // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DSGV' table. You can move, or remove it, as needed.
                this.v_DSGVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.v_DSGVTableAdapter.Fill(this.qLDSVDataSet.V_DSGV);
                // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DSPM' table. You can move, or remove it, as needed.
                this.v_DSPMTableAdapter.Fill(this.qLDSVDataSet.V_DSPM);
                //để combobox chạy đúng
                cbKhoa.SelectedIndex = 0;
                //khóa hiển thị combobox khoa
                    cbKhoa.SelectedIndex = Program.mKhoa;
                    cbKhoa.DropDownStyle = ComboBoxStyle.Simple;
                // xóa 2 role PGV và PKeToan
                cbRoles.Items.Remove("PGV");
                cbRoles.Items.Remove("PKeToan");
                cbRoles.SelectedIndex = 0;
            }

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
            DialogResult dr = XtraMessageBox.Show("Bạn thật sự muốn hủy thao tác đăng ký tài khoản?",
                      "Xác thực", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
            {
                return;
            }
            else if (dr == DialogResult.Yes)
            {
                this.Close();

            }
        }
        //khi chọn lớp thì cũng thay đổi data sinh viên
        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLop.SelectedValue != null)
            {
                DataTable dt = new DataTable();
                dt = Program.ExecSqlDataTable("SELECT * FROM LINK0.QLDSV.dbo.V_DSSV_TaoTK SV WHERE SV.MALOP = '" + cbLop.GetItemText(cbLop.SelectedItem) + "'");
                Program.bds.DataSource = dt;
                cbMaSinhVien.DataSource = dt;
                cbMaSinhVien.DisplayMember = "HOTEN";
                cbMaSinhVien.ValueMember = "MASV";
                //cbMaSinhVien.SelectedIndex = 0;
            }

        }
        
        private void cbMaGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        //chọn khoa thì thay đổi data giáo viên
        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhoa.SelectedValue != null)
            {
                Console.WriteLine(Program.TKhoa[cbKhoa.SelectedIndex]);
                DataTable dtgv = new DataTable();
                //gọi 1 view và trả về dưới dạng datatable
                dtgv = Program.ExecSqlDataTable("SELECT * FROM LINK0.QLDSV.dbo.V_DSGV GV WHERE GV.MAKH = '" + Program.TKhoa[cbKhoa.SelectedIndex] + "'");
                // cất dt vào biến toàn cục Bds_Dspm
                Program.bds_dsgv.DataSource = dtgv;
                cbMaGiaoVien.DataSource = dtgv;
                cbMaGiaoVien.DisplayMember = "HOTEN";
                cbMaGiaoVien.ValueMember = "MAGV";
                //cbMaSinhVien.SelectedIndex = 0;
            }
        }

        private void dangkiGiaoVien_Click(object sender, EventArgs e)
        {
            String login = userName.Text;
            String pass = passWord.Text;
            String user = cbMaGiaoVien.SelectedValue.ToString();
            String role = cbRoles.SelectedValue.ToString();

            String subLenh = " EXEC    @return_value = [dbo].[SP_TaoTaiKhoan] " +

                            " @LGNAME = N'" + login + "', " +
                            " @PASS = N'" + pass + "', " +
                            " @USERNAME = N'" + user + "', " +
                            " @ROLE = N'" + role + "' ";


            // trường hợp tạo tài khoản cho site khác thì phải dùng LINK1 để link tới Site 3 tạo tài khoản cho pKeToan
            if (role == (Program.NhomQuyen[3]))
            {
                if (Program.servername != ((DataRowView)Program.bds_dspm[2])["TENSERVER"].ToString())
                {
                    // site 1 tới site 3---> sử dụng LINK2
                    subLenh = " EXEC    @return_value = LINK2.QLDSV.[dbo].[SP_TAOLOGIN] " +

                                " @LGNAME = N'" + login + "', " +
                                " @PASS = N'" + pass + "', " +
                                " @USERNAME = N'" + user + "', " +
                                " @ROLE = N'" + role + "' ";
                }
            }
            else if ((Program.mGroup == Program.NhomQuyen[0]))
            {
                if (cbKhoa.SelectedValue.ToString() != Program.GetServerName[2] && Program.servername != ((DataRowView)Program.bds_dspm[2])["TENSERVER"].ToString())
                {
                    //site1 || site 2 --> site 3
                    subLenh = " EXEC    @return_value = LINK2.QLDSV.[dbo].[SP_TAOLOGIN] " +

                                " @LGNAME = N'" + login + "', " +
                                " @PASS = N'" + pass + "', " +
                                " @USERNAME = N'" + user + "', " +
                                " @ROLE = N'" + role + "' ";
                }
                else if (cbKhoa.SelectedValue.ToString() == Program.GetServerName[0] && Program.servername == ((DataRowView)Program.bds_dspm[2])["TENSERVER"].ToString())
                {
                    //site3 --> site 1
                    subLenh = " EXEC    @return_value = LINK1.QLDSV.[dbo].[SP_TAOLOGIN] " +

                                " @LGNAME = N'" + login + "', " +
                                " @PASS = N'" + pass + "', " +
                                " @USERNAME = N'" + user + "', " +
                                " @ROLE = N'" + role + "' ";
                }
                else if (cbKhoa.SelectedValue.ToString() == Program.GetServerName[1] && Program.servername == ((DataRowView)Program.bds_dspm[2])["TENSERVER"].ToString())
                {
                    //site3 --> site 2
                    subLenh = " EXEC    @return_value = LINK2.QLDSV.[dbo].[SP_TAOLOGIN] " +

                                " @LGNAME = N'" + login + "', " +
                                " @PASS = N'" + pass + "', " +
                                " @USERNAME = N'" + user + "', " +
                                " @ROLE = N'" + role + "' ";
                }
                else if (cbKhoa.SelectedValue.ToString() != Program.GetServerName[2] && Program.servername != ((DataRowView)Program.bds_dspm[2])["TENSERVER"].ToString())
                {
                    //site1 --> site 2 || site2 --> site 1
                    subLenh = " EXEC    @return_value = LINK1.QLDSV.[dbo].[SP_TAOLOGIN] " +

                                " @LGNAME = N'" + login + "', " +
                                " @PASS = N'" + pass + "', " +
                                " @USERNAME = N'" + user + "', " +
                                " @ROLE = N'" + role + "' ";
                }
            }

            // trường hợp tạo tài khoản cho chỉ khoa

            String strLenh = " DECLARE @return_value int " + subLenh +
                         " SELECT  'Return Value' = @return_value ";

            // kiểm tra valid
            SqlDataReader dataReader = Program.ExecSqlDataReader(strLenh);

            // nếu null thì thoát luôn  ==> lỗi kết nối
            if (dataReader == null)
            {
                MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại !", "", MessageBoxButtons.OK);
                this.Close();
            }
            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();

            if (result == 1)
            {
                //login trùng
            }
            else if (result == 2)
            {
                //đã có tk

            }
            else if (result == 3)
            {
                //lỗi thực thi
            }
            else if (result == 0)
            {
                //success

            }
            return;
        }

        private void dangkiSinhVien_Click(object sender, EventArgs e)
        {
            String login = userName.Text;
            String pass = passWord.Text;
            String user = cbMaSinhVien.SelectedValue.ToString();

            String subLenh = " EXEC    @return_value = [dbo].[SP_TaoTaiKhoan] " +

                            " @LGNAME = N'" + login + "', " +
                            " @PASS = N'" + pass + "', " +
                            " @USERNAME = N'" + user + "', " +
                            " @ROLE = N'" + "USERS" + "' ";

            if ((Program.mGroup == Program.NhomQuyen[0]))
            {
                if(cbLop.SelectedValue.ToString() == "CNTT" && Program.servername == ((DataRowView)Program.bds_dspm[1])["TENSERVER"].ToString())
                {
                    subLenh = " EXEC    @return_value = LINK1.QLDSV.[dbo].[SP_TAOLOGIN] " +

                                " @LGNAME = N'" + login + "', " +
                                " @PASS = N'" + pass + "', " +
                                " @USERNAME = N'" + user + "', " +
                                " @ROLE = N'" + "USERS" + "' ";
                }
                else if(cbLop.SelectedValue.ToString() == "VT" && Program.servername == ((DataRowView)Program.bds_dspm[0])["TENSERVER"].ToString())
                {
                    subLenh = " EXEC    @return_value = LINK1.QLDSV.[dbo].[SP_TAOLOGIN] " +

                                " @LGNAME = N'" + login + "', " +
                                " @PASS = N'" + pass + "', " +
                                " @USERNAME = N'" + user + "', " +
                                " @ROLE = N'" + "USERS" + "' ";
                }
            }

            // trường hợp tạo tài khoản cho chỉ khoa

            String strLenh = " DECLARE @return_value int " + subLenh +
                         " SELECT  'Return Value' = @return_value ";

            // kiểm tra valid
            SqlDataReader dataReader = Program.ExecSqlDataReader(strLenh);

            // nếu null thì thoát luôn  ==> lỗi kết nối
            if (dataReader == null)
            {
                MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại !", "", MessageBoxButtons.OK);
                this.Close();
            }
            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();

            if (result == 1)
            {
                //login trùng
            }
            else if (result == 2)
            {
                //đã có tk

            }
            else if (result == 3)
            {
                //lỗi thực thi
            }
            else if (result == 0)
            {
                //success

            }
            return;
        }
    }
}