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
    public partial class FormDiem : DevExpress.XtraEditors.XtraForm
    {

        private BindingSource bdsDiemAdd = new BindingSource(); 
        private BindingSource bdsDiemAdjust = new BindingSource(); 

        private int pos = 0;
        private Boolean flag = false; // 0 add 1 adjust

        private String lop = "";
        private String monhoc = "";
        private short lanthi;

        public FormDiem()
        {
            InitializeComponent();
        }



        //==================================================== XỬ LÝ DỮ LIỆU ĐỔ VÀO====================================================//

        private void FormDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.qLDSVDataSet.MONHOC);
            // TODO: This line of code loads data into the 'qLDSVDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);
            //// TODO: This line of code loads data into the 'qLDSVDataSet.DIEM' table. You can move, or remove it, as needed.
            //this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.dIEMTableAdapter.Fill(this.qLDSVDataSet.DIEM);
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

            cbLan.SelectedIndex = 0;

            reloadBtn.Enabled
               = quitFormBtn.Enabled = true;

            saveBtn.Enabled
                = exitBtn.Enabled
                = groupEdit.Enabled
                = false;
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhoa.SelectedValue != null)
            {
                if (cbKhoa.SelectedIndex != Program.mKhoa)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                { // ở B về lại A dùng login ban đầu
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }
                Program.servername = cbKhoa.SelectedValue.ToString();

                if (Program.KetNoi() == 1)
                {
                    // TODO: This line of code loads data into the 'qLDSVDataSet.LOP' table. You can move, or remove it, as needed.
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);
                    // TODO: This line of code loads data into the 'qLDSVDataSet.DIEM' table. You can move, or remove it, as needed.
                    this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dIEMTableAdapter.Fill(this.qLDSVDataSet.DIEM);
                }
                else
                {
                    MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                }
            }
        }

        //==================================================== XỬ LÝ NÚT ====================================================//

        private void startBtn_Click(object sender, EventArgs e)
        {
            lop = cbLop.SelectedValue.ToString();
            monhoc = cbMon.SelectedValue.ToString();
            lanthi = short.Parse(cbLan.Text);
            Console.WriteLine(lop + " " + monhoc + " " + lanthi);

            Boolean check = checkInfoDiem();
            pos = 0;
            Console.WriteLine("checkInfoDiem: "+ check);

            if(check)
            {

                // đổ table Add vào gridControl
                string cmdAdd = "EXEC [dbo].[SP_DSSVNhapDiem] " +
                              "@malop = N'" + lop + "'";
                DataTable dtBdAdd = Program.ExecSqlDataTable(cmdAdd);
                this.bdsDiemAdd.DataSource = dtBdAdd;

                // đổ table Adjust vào gridControl
                string cmdAdjust = "EXEC [dbo].[SP_BangDiemSV] " +
                             "@malop = N'" + lop + "', " +
                             "@mamh = N'" + monhoc + "', " +
                             "@lan =" + lanthi;
                DataTable dtBdAdj = Program.ExecSqlDataTable(cmdAdjust);
                this.bdsDiemAdjust.DataSource = dtBdAdj;

                // sửa
                if (this.bdsDiemAdjust.Count > 0)
                {
                    if (lanthi == 1)
                    {
                        // check lần 2 có điểm chưa
                        string cmdCheck = "EXEC [dbo].[SP_BangDiemSV] " +
                            " @malop = N'" + lop + "'," +
                            " @mamh = N'" + monhoc + "'," +
                               "@lan = 2";
                        DataTable dtCheck = Program.ExecSqlDataTable(cmdCheck);
                        if (dtCheck.Rows.Count > 0)
                        {
                            MessageBox.Show("Lần thi 2 đã có điểm! \n Không được sửa điểm lần 1", "Thông báo", MessageBoxButtons.OK);
                            saveBtn.Enabled = false;
                        }

                    }

                    this.danhSachDiem.DataSource = this.bdsDiemAdjust;
                    this.viewDSDiem.RefreshData();
                    hoTen.Text = ((DataRowView)bdsDiemAdjust[0])["HOTEN"].ToString();
                    maSV.Text = ((DataRowView)bdsDiemAdjust[0])["MASV"].ToString();
                    diem.Text = ((DataRowView)bdsDiemAdjust[0])["DIEM"].ToString();
                    flag = true;
                }
                else //add
                {
                    // nếu lần 1 đã có điểm 
                    if (lanthi == 2)
                    {
                        // check lần 1 có điểm hay chưa
                        string cmdCheck = "EXEC [dbo].[SP_BangDiemSV] " +
                             " @malop = N'" + lop + "'," +
                             " @mamh = N'" + monhoc + "'," +
                                "@lan = 1";
                        DataTable dtCheck = Program.ExecSqlDataTable(cmdCheck);


                        if (dtCheck.Rows.Count > 0)
                        {
                            //xóa điểm trước đó để nhập điểm lần 2
                            for (int i = dtCheck.Rows.Count - 1; i >= 0; i--)
                            {
                                DataRow dr = dtCheck.Rows[i];
                                if(float.Parse(dr["DIEM"].ToString()) < 4)
                                {
                                    dr.Delete();
                                }
                                else
                                {
                                    dr["DIEM"] = "";
                                }
                            }
                        
                            dtCheck.AcceptChanges();

                            this.bdsDiemAdd.DataSource = dtCheck;
                            this.danhSachDiem.DataSource = this.bdsDiemAdd;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Điểm thi lần 1 chưa có", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }
                    }

                        //trường hợp nhập điểm lần 1
                    this.danhSachDiem.DataSource = this.bdsDiemAdd;
                        this.viewDSDiem.RefreshData();
                    if(viewDSDiem.DataRowCount > 0)
                    {
                        hoTen.Text = ((DataRowView)bdsDiemAdd[0])["HOTEN"].ToString();
                        maSV.Text = ((DataRowView)bdsDiemAdd[0])["MASV"].ToString();
                        flag = false;

                    }
                    else
                    {
                        MessageBox.Show("Lớp này chưa có sinh viên!", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                }
                saveBtn.Enabled
                = groupEdit.Enabled
                = exitBtn.Enabled
                = startBtn.Enabled
                = true;
                reloadBtn.Enabled
                    = cbLop.Enabled
                    = cbKhoa.Enabled
                    = cbMon.Enabled
                    = cbLan.Enabled
                    = false;
            }
            else
            {
                saveBtn.Enabled
                = groupEdit.Enabled
                = exitBtn.Enabled
                = false;
                reloadBtn.Enabled
                    = danhSachDiem.Enabled
                    = cbLop.Enabled
                    = cbKhoa.Enabled
                    = cbLan.Enabled
                    = true;
            }
            

        }
        private void btnTiep_Click(object sender, EventArgs e)
        {
            Boolean check = string.IsNullOrEmpty(diem.Text.Trim().ToString())?false:true;
            if(check)
            {
                viewDSDiem.GetDataRow(pos)["DIEM"] = float.Parse(diem.Text.Trim().ToString());
                pos++;
                if(pos > viewDSDiem.DataRowCount -1)
                {
                    btnTiep.Enabled = false;
                    return;
                }
                diem.Clear();
                hoTen.Text = viewDSDiem.GetDataRow(pos)["HOTEN"].ToString();
                maSV.Text = viewDSDiem.GetDataRow(pos)["MASV"].ToString();
                //if(flag)
                //{
                //    hoTen.Text = ((DataRowView)bdsDiemAdjust[pos])["HOTEN"].ToString();
                //    maSV.Text = ((DataRowView)bdsDiemAdjust[pos])["MASV"].ToString();
                //    ((DataRowView)bdsDiemAdjust[pos])["DIEM"] = int.Parse(diem.Text.Trim().ToString());

                //}
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (checkRows())
            {
                //get binding source từ gridcontrol
                BindingSource bdsTemp = (BindingSource)this.danhSachDiem.DataSource;

                // kết thúc việc cập nhật dữ liệu
                bdsTemp.EndEdit();

                // bắt đầu ghi dữ liệu
                SqlConnection conn = new SqlConnection(Program.connstr);
                // bắt đầu transaction
                SqlTransaction tran;

                conn.Open();
                tran = conn.BeginTransaction();

                try
                {


                    for (int i = 0; i < bdsTemp.Count; i++)
                    {

                        SqlCommand cmd = new SqlCommand("SP_NHAPDIEM", conn);
                        cmd.Connection = conn;
                        cmd.Transaction = tran;



                        cmd.CommandType = CommandType.StoredProcedure;
                        string masv = ((DataRowView)bdsTemp[i])["MASV"].ToString();
                        cmd.Parameters.Add(new SqlParameter("@MASV", masv));
                        cmd.Parameters.Add(new SqlParameter("@MAMH", monhoc));
                        cmd.Parameters.Add(new SqlParameter("@LAN", lanthi));

                        float diem = float.Parse(((DataRowView)bdsTemp[i])["DIEM"].ToString());
                        cmd.Parameters.Add(new SqlParameter("@DIEM", diem));
                        Console.WriteLine("Nhap diem: " + masv + " " + " " + monhoc + " " + lanthi + " " + diem);
                        cmd.ExecuteNonQuery();


                    }


                    tran.Commit();
                }
                catch (SqlException sqlex)
                {
                    try
                    {

                        tran.Rollback();
                        MessageBox.Show("Lỗi ghi toàn bộ điểm vào Database. Bạn hãy xem lại ! " + sqlex.Message, "", MessageBoxButtons.OK);

                    }
                    catch (Exception ex2)
                    {
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                    conn.Close();
                    return;
                }
                finally
                {
                    conn.Close();
                }




                MessageBox.Show("Thao tác thành công!", "", MessageBoxButtons.OK);
                FormDiem_Load(sender, e);
                return;
            }
            else
            {
                saveBtn.Enabled
               = groupEdit.Enabled
               = exitBtn.Enabled
               = btnTiep.Enabled
               = true;
                reloadBtn.Enabled
                    = danhSachDiem.Enabled
                    = cbLop.Enabled
                    = cbKhoa.Enabled
                    = cbLan.Enabled
                    = startBtn.Enabled
                    = false;
                hoTen.Text = viewDSDiem.GetDataRow(pos)["HOTEN"].ToString();
                maSV.Text = viewDSDiem.GetDataRow(pos)["MASV"].ToString();
                viewDSDiem.GetDataRow(pos)["DIEM"] = float.Parse(diem.Text.Trim().ToString());
                MessageBox.Show("Bạn chưa nhập hết bản điểm cho sinh viên !", "Thông báo",MessageBoxButtons.OK);
                return;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            BindingSource bdsTemp = (BindingSource)this.danhSachDiem.DataSource;
            if (bdsTemp != null)
            {
                bdsTemp.CancelEdit();
                bdsTemp.ResetBindings(true);
            }

            // gọi lại form load.
            FormDiem_Load(sender, e);
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            FormDiem_Load(sender, e);
            MessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }
        private void quitFormBtn_Click(object sender, EventArgs e)
        {
            if (groupEdit.Enabled)
            {
                DialogResult dr = MessageBox.Show(" Dữ liệu Sinh viên chưa lưu vào Database \n Bạn có chắc muốn thoát !", "Cảnh báo", MessageBoxButtons.YesNo);

                if (dr == DialogResult.No)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    this.Close();

                }
            }
            else
            {
                this.Close();
                return;
            }
        }
        //==================================================== XỬ LÝ RÀNG BUỘC ====================================================//
        private Boolean checkInfoDiem()
        {
            if (string.IsNullOrEmpty(monhoc) || string.IsNullOrEmpty(lop) || string.IsNullOrEmpty(lanthi.ToString()))
            {
                reloadBtn.Enabled
               = quitFormBtn.Enabled = true;

                saveBtn.Enabled
                    = exitBtn.Enabled
                    = groupEdit.Enabled
                    = false;

                errorProvider.SetError(startBtn, "Cần đầy đủ thông tin để truy cập!");
                return false;
            }
            return true;

        }

        private bool checkRows()
        {
            // get binding source từ gridcontrol
            BindingSource bdsTemp = (BindingSource)this.danhSachDiem.DataSource;
            for (int i = 0; i < bdsTemp.Count; i++)
            {
                if (string.IsNullOrEmpty(((DataRowView)bdsTemp[i])["DIEM"].ToString()))
                {
                    bdsTemp.Position = i;
                    pos = i;
                    return false;
                }

            }

            return true;
        }

        private void diem_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(diem.Text.Trim().ToString()))
            {
                errorProvider.SetError(diem, "Điểm không được trống!");
                diem.Focus();
            }
            else
            {
               float checkDiem = float.Parse(diem.Text.Trim().ToString());
                if (checkDiem < 0 || checkDiem > 10)
                {
                    errorProvider.SetError(diem, "điểm phải lớn hơn 0 và nhỏ hơn 10");
                    diem.Focus();
                }

            }
        }
    }
}