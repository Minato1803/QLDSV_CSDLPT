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
using System.Collections;
using System.Data.SqlClient;

namespace QLSV
{
    public partial class FormLop : DevExpress.XtraEditors.XtraForm
    {
        private int pos = 0;
        private Boolean flag = false; // true = add ; false = update
        private string oldMaLop = "";
        private string oldTenLop = "";
        UndoStack undoStk;

        public FormLop()
        {
            InitializeComponent();
            undoStk = new UndoStack("MALOP", this.lOPBindingSource);
        }

        private void quitFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qldsvDataSet1.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qldsvDataSet1.V_DSPM);
            if (Program.mGroup == "PGV")
            {
                DataTable dt = new DataTable();
                dt = this.qldsvDataSet1.V_DSPM;
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
            addBtn.Enabled
                = deleteBtn.Enabled
                = adjustBtn.Enabled
                = reloadBtn.Enabled
                = quitFormBtn.Enabled = true;
            saveBtn.Enabled
                = exitBtn.Enabled
                = undoBtn.Enabled = false;

            // TODO: This line of code loads data into the 'qldsvDataSet1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;

            this.lOPTableAdapter.Fill(this.qldsvDataSet1.LOP);
            // TODO: This line of code loads data into the 'qldsvDataSet1.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qldsvDataSet1.SINHVIEN);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            flag = true;  // Add

            saveBtn.Enabled = exitBtn.Enabled = true;
            addBtn.Enabled
                = deleteBtn.Enabled
                = adjustBtn.Enabled
                = undoBtn.Enabled
                = reloadBtn.Enabled = false;

            tuyChinh.Enabled
                = groupEdit.Enabled = true;
            danhsachLop.Enabled = false;
            maLop.Focus();
            // TODO : Thao tác chuẩn bị thêm
            //undoBds.Push(mONHOCBindingSource);
            this.lOPBindingSource.AddNew();
            ((DataRowView)this.lOPBindingSource[this.lOPBindingSource.Position])["MAKH"] = Program.TKhoa[Program.mKhoa];
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (fKSINHVIENLOPBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa lóp này vì đang chứa sinh viên", "cảnh báo", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa Môn này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    //undoBds.Push(lOPBindingSource);
                    lOPBindingSource.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.qldsvDataSet1.LOP);
                    this.lOPBindingSource.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp\nBạn hãy xem lại\n" + ex.Message, "", MessageBoxButtons.OK);
                }


            }
            if (pos > 0)
            {

                lOPBindingSource.Position = pos;
            }
        }

        private void adjustBtn_Click(object sender, EventArgs e)
        {
            flag = false;//  Update 
            oldMaLop = this.maLop.Text.Trim().ToString();
            oldTenLop = this.tenLop.Text.Trim().ToString();

            saveBtn.Enabled = exitBtn.Enabled = true;

            addBtn.Enabled
                = deleteBtn.Enabled
                = adjustBtn.Enabled
                = undoBtn.Enabled
                = reloadBtn.Enabled
                = cbKhoa.Enabled
                = false;

            danhsachLop.Enabled = false;
            tuyChinh.Enabled
                = groupEdit.Enabled = true;
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            //QLDSVDataSet.LOPDataTable dttb = (QLDSVDataSet.LOPDataTable)undoBds.Pop();
            //((QLDSVDataSet)this.lOPBindingSource.DataSource).LOP.Load(dttb.CreateDataReader());
            //this.qldsvDataSet1.LOP.Load(dttb.CreateDataReader());
            //this.lOPBindingSource.EndEdit();
            //this.lOPBindingSource.ResetCurrentItem();


            //this.lOPTableAdapter.Update(this.qldsvDataSet1.LOP);
            //this.qldsvDataSet1.AcceptChanges();
            ////this.lOPTableAdapter.Fill(this.qldsvDataSet1.LOP);


            //if (undoBds.Count == 0)
            //{
            //    undoBtn.Enabled = false;
            //}
            undoStk.Undo();
            this.lOPBindingSource.EndEdit();
            this.lOPBindingSource.ResetCurrentItem();
            this.lOPTableAdapter.Update(this.qldsvDataSet1);

            if (undoStk.Empty())
            {
                undoBtn.Enabled = false;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool check = checkInfoLop();
            if (check)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        //this.qLDSVDataSet.MONHOC.Rows.Add(maMon.Text, tenMon.Text);
                        undoStk.PushUndo("ADJUST", ((DataRowView)this.lOPBindingSource[this.lOPBindingSource.Position]));
                        this.lOPBindingSource.EndEdit();
                        this.lOPBindingSource.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                        this.lOPTableAdapter.Update(this.qldsvDataSet1);
                        addBtn.Enabled
                        = deleteBtn.Enabled
                        = adjustBtn.Enabled
                        = undoBtn.Enabled
                        = reloadBtn.Enabled = true;
                        oldMaLop = oldTenLop = "";
                        danhsachLop.Enabled = true;
                        groupEdit.Enabled = false;
                        
                        
                    }
                    catch (Exception ex)
                    {
                        lOPBindingSource.RemoveCurrent();
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                return;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //xóa trạng thái
            lOPBindingSource.CancelEdit();

            FormLop_Load(sender, e);
            if (pos > 0)
            {
                lOPBindingSource.Position = pos;
            }

            danhsachLop.Enabled = true;
            groupEdit.Enabled = false;
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            FormLop_Load(sender, e);
            MessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }


        private bool checkInfoLop()
        {

            // TODO : Check khoảng trống ở textField
            if (maLop.Text.Trim().Equals(""))
            {
                this.errorMaLop.SetError(maLop, "Mã môn học không được để trống!");
                return false;
            }
            if (tenLop.Text.Trim().Equals(""))
            {
                this.errorTenLop.SetError(tenLop, "Tên môn học không được để trống");
                return false;
            }
            else
            {
                errorMaLop.Clear();
                errorTenLop.Clear();
            }


            if (flag) // add
            {
                //TODO: Check mã lớp có tồn tại chưa
                string queryMa = "DECLARE  @return_value int \n"
                            + "EXEC @return_value = SP_CHECKID \n"
                            + "@Code = N'" + maLop.Text.Trim() + "',@Type = N'MALOP' \n"
                            + "SELECT 'Return Value' = @return_value";

                int result = -1;
                SqlDataReader dataReader = Program.ExecSqlDataReader(queryMa);

                // nếu null thì thoát luôn  ==> lỗi kết nối
                if (dataReader == null)
                {
                    MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                    this.Close();
                }
                dataReader.Read();
                result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();

                if (result == 1)
                {
                    this.errorMaLop.SetError(maLop, "Mã môn học đã tồn tại!");
                    return false;
                }

                // TODO : Check tên lớp có tồn tại chưa
                string queryTen = "DECLARE  @return_value int \n"
                            + "EXEC @return_value = SP_CHECKNAME \n"
                            + "@Name = N'" + tenLop.Text.Trim() + "',@Type = N'TENLOP' \n"
                            + "SELECT 'Return Value' = @return_value";

                result = -1;
                dataReader = Program.ExecSqlDataReader(queryTen);

                // nếu null thì thoát luôn  ==> lỗi kết nối
                if (dataReader == null)
                {
                    MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                    this.Close();
                }
                dataReader.Read();
                result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();

                if (result == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (result == 1)
                {
                    this.errorTenLop.SetError(tenLop, "Tên lớp đã tồn tại!");
                    return false;
                }
            }

            if (flag == false)
            {
                if (!this.maLop.Text.Trim().ToString().Equals(oldMaLop))// Mã lớp thay đổi so với ban đầu
                {
                    //TODO: Check mã lớp có tồn tại chưa
                    string queryMa = "DECLARE  @return_value int \n"
                                + "EXEC @return_value = SP_CHECKID \n"
                                + "@Code = N'" + maLop.Text.Trim() + "',@Type = N'MALOP' \n"
                                + "SELECT 'Return Value' = @return_value";

                    int result = -1;
                    SqlDataReader dataReader = Program.ExecSqlDataReader(queryMa);

                    // nếu null thì thoát luôn  ==> lỗi kết nối
                    if (dataReader == null)
                    {
                        MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    dataReader.Read();
                    result = int.Parse(dataReader.GetValue(0).ToString());
                    dataReader.Close();

                    if (result == 1)
                    {
                        this.errorMaLop.SetError(maLop, "Mã lớp đã tồn tại!");
                        return false;
                    }
                }
                if (!this.tenLop.Text.Trim().ToString().Equals(oldTenLop))// Tên lớp thay đổi so với ban đầu
                {
                    // TODO : Check tên lớp có tồn tại chưa
                    string queryTen = "DECLARE  @return_value int \n"
                                + "EXEC @return_value = SP_CHECKNAME \n"
                                + "@Name = N'" + tenLop.Text.Trim() + "',@Type = N'TENLOP' \n"
                                + "SELECT 'Return Value' = @return_value";

                    int result = -1;
                    SqlDataReader dataReader = Program.ExecSqlDataReader(queryTen);

                    // nếu null thì thoát luôn  ==> lỗi kết nối
                    if (dataReader == null)
                    {
                        MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    dataReader.Read();
                    result = int.Parse(dataReader.GetValue(0).ToString());
                    dataReader.Close();

                    if (result == -1)
                    {
                        MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    if (result == 1)
                    {
                        this.errorTenLop.SetError(tenLop, "Tên lớp đã tồn tại!");
                        return false;
                    }
                }
            }

            return true;
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbKhoa.SelectedValue != null)
            {
                if (cbKhoa.SelectedIndex != Program.mKhoa)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                { // ở B về lại A dùng login ban đầu
                    Program.mlogin = Program.mloginDN ;
                    Program.password = Program.passwordDN;
                }
                Program.servername = cbKhoa.SelectedValue.ToString();

                if (Program.KetNoi() == 1)
                {
                    // TODO: This line of code loads data into the 'qldsvDataSet1.LOP' table. You can move, or remove it, as needed.
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.qldsvDataSet1.LOP);
                    // TODO: This line of code loads data into the 'qldsvDataSet1.SINHVIEN' table. You can move, or remove it, as needed.
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Fill(this.qldsvDataSet1.SINHVIEN);
                }
                else
                {
                    MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                }
            }

        }

        private void push_undo()
        {
            undoBtn.Enabled = true;
            DataTable dttb;
            dttb = ((QLDSVDataSet)lOPBindingSource.DataSource).LOP.Copy();
            //undoBds.Push(dttb);
        }
    }
}