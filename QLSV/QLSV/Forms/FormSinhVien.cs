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
    public partial class FormSinhVien : DevExpress.XtraEditors.XtraForm
    {
        private int pos = 0;
        private Boolean flag = false; // true = add ; false = update
        private string oldMaLop = "";
        private string oldMaSV = "";
        UndoStack undoStk;

        public FormSinhVien()
        {
            InitializeComponent();
            undoStk = new UndoStack("MASV", this.sINHVIENBindingSource);
        }


        //==================================================== XỬ LÝ DỮ LIỆU ĐỔ VÀO====================================================//

        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.HOCPHI' table. You can move, or remove it, as needed.
            this.hOCPHITableAdapter.Fill(this.qLDSVDataSet.HOCPHI);
            // TODO: This line of code loads data into the 'qLDSVDataSet.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Fill(this.qLDSVDataSet.DIEM);
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
            // TODO: This line of code loads data into the 'qLDSVDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);
            // TODO: This line of code loads data into the 'qLDSVDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet.SINHVIEN);
            DataTable dtsv = new DataTable();
            //gọi 1 view và trả về dưới dạng datatable
            dtsv = Program.ExecSqlDataTable("SELECT * FROM LINK0.QLDSV.dbo.SINHVIEN SV WHERE SV.MALOP = '" + cbLop.GetItemText(cbLop.SelectedItem) + "'");

            sINHVIENBindingSource.DataSource = dtsv;
            this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet.SINHVIEN);

            addBtn.Enabled
                = deleteBtn.Enabled
                = adjustBtn.Enabled
                = undoBtn.Enabled
                = reloadBtn.Enabled
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
                    // TODO: This line of code loads data into the 'qldsvDataSet1.LOP' table. You can move, or remove it, as needed.
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);
                    // TODO: This line of code loads data into the 'qldsvDataSet1.SINHVIEN' table. You can move, or remove it, as needed.
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    //this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet.SINHVIEN);
                    DataTable dtsv = new DataTable();
                    //gọi 1 view và trả về dưới dạng datatable
                    dtsv = Program.ExecSqlDataTable("SELECT * FROM LINK0.QLDSV.dbo.SINHVIEN SV WHERE SV.MALOP = '" + cbLop.GetItemText(cbLop.SelectedItem) + "'");

                    sINHVIENBindingSource.DataSource = dtsv;
                    this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet.SINHVIEN);
                }
                else
                {
                    MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                }

                if (viewDSSV.SelectedRowsCount <= 0)
                {
                    maLop.Clear();
                    MessageBox.Show("Lớp này chưa có sinh viên", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    maLop.Text = cbLop.SelectedValue.ToString();
                }
            }

        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbLop.SelectedValue!=null)
            {
                DataTable dtsv = new DataTable();
                //gọi 1 view và trả về dưới dạng datatable
                dtsv = Program.ExecSqlDataTable("SELECT * FROM LINK0.QLDSV.dbo.SINHVIEN SV WHERE SV.MALOP = '" + cbLop.GetItemText(cbLop.SelectedItem) + "'");

                sINHVIENBindingSource.DataSource = dtsv;
                this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet.SINHVIEN);

                if (viewDSSV.SelectedRowsCount <= 0)
                {
                    MessageBox.Show("Lớp này chưa có sinh viên", "Thông báo", MessageBoxButtons.OK);
                    maLop.Clear();
                }
                else
                {
                    maLop.Text = cbLop.SelectedValue.ToString();
                }
            }
        }

        private void viewDSSV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (viewDSSV.SelectedRowsCount > 0)
            {
                //Console.WriteLine(((DataRowView)this.sINHVIENBindingSource[this.sINHVIENBindingSource.Position])["PHAI"]);
                //Console.WriteLine(viewDSSV.GetFocusedDataRow()["PHAI"].ToString());
                if (viewDSSV.GetFocusedDataRow()["PHAI"].ToString() == "True")
                {
                    btnNam.Checked = true;
                    btnNu.Checked = false;
                }
                else
                {
                    btnNam.Checked = false;
                    btnNu.Checked = true;
                }
                if(viewDSSV.GetFocusedDataRow()["NGHIHOC"].ToString() == "True")
                {
                    nGHIHOCCheckEdit.Checked = true;
                }
                pos = sINHVIENBindingSource.Position;
                maLop.Text = cbLop.SelectedValue.ToString();
            }
            else
            {
                btnNam.Checked = false;
                btnNu.Checked = false;
                nGHIHOCCheckEdit.Checked = false;
            }
        }

        //==================================================== XỬ LÝ NÚT ====================================================//

        private void addBtn_Click(object sender, EventArgs e)
        {
            flag = true;  // Add

            saveBtn.Enabled
                = groupEdit.Enabled
                = exitBtn.Enabled 
                = true;
            addBtn.Enabled
                = deleteBtn.Enabled
                = adjustBtn.Enabled
                = undoBtn.Enabled
                = reloadBtn.Enabled 
                = danhSachSV.Enabled
                = cbLop.Enabled
                = cbKhoa.Enabled
                = false;

            maSinhVien.Focus();
            btnNam.Enabled = true;
            nGHIHOCCheckEdit.Enabled = true;
            // TODO : Thao tác chuẩn bị thêm
            //undoBds.Push(mONHOCBindingSource);
            this.sINHVIENBindingSource.AddNew();

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            String CurrMaSV = ((DataRowView) sINHVIENBindingSource[this.viewDSSV.FocusedRowHandle])["MASV"].ToString();
            Console.WriteLine("mã sinh viên xóa: " + CurrMaSV);

            // kiểm tra HP
            if (CheckHP(CurrMaSV))
            {
                MessageBox.Show("Sinh viên này có dữ liệu, Không được xóa !", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thực sự muốn xóa Sinh Viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    undoStk.PushUndo("REMOVE", ((DataRowView)this.sINHVIENBindingSource[this.sINHVIENBindingSource.Position]));
                    sINHVIENBindingSource.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.qLDSVDataSet.SINHVIEN);
                    this.sINHVIENBindingSource.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Sinh Viên\nBạn hãy xem lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                }


            }


            if (pos > 0)
            {

                sINHVIENBindingSource.Position = pos;
            }
        }

        private void adjustBtn_Click(object sender, EventArgs e)
        {
            flag = false;//  Update 
            oldMaLop = this.maLop.Text.Trim().ToString();
            //oldTenLop = this.cbLop.Text.Trim().ToString();
            oldMaSV = this.maSinhVien.Text.Trim().ToString();

            saveBtn.Enabled 
                = exitBtn.Enabled 
                = maLop.Enabled
                = groupEdit.Enabled = true;

            addBtn.Enabled
                = deleteBtn.Enabled
                = adjustBtn.Enabled
                = undoBtn.Enabled
                = reloadBtn.Enabled
                = cbKhoa.Enabled
                = danhSachSV.Enabled = false;
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            undoStk.Undo();
            this.sINHVIENBindingSource.EndEdit();
            this.sINHVIENBindingSource.ResetCurrentItem();
            this.sINHVIENTableAdapter.Update(this.qLDSVDataSet);

            if (undoStk.Empty())
            {
                undoBtn.Enabled = false;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            ((DataRowView)this.sINHVIENBindingSource[this.sINHVIENBindingSource.Position])["PHAI"] = btnNam.Enabled?true:false;
            ((DataRowView)this.sINHVIENBindingSource[this.sINHVIENBindingSource.Position])["NGHIHOC"] = nGHIHOCCheckEdit.Enabled?true:false;
            ((DataRowView)this.sINHVIENBindingSource[this.sINHVIENBindingSource.Position])["MALOP"] = cbLop.SelectedValue.ToString();

            bool check = CheckInfoSinhVien();
            if (check)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        //this.qLDSVDataSet.MONHOC.Rows.Add(maMon.Text, tenMon.Text);

                        this.sINHVIENBindingSource.EndEdit();
                        this.sINHVIENBindingSource.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                        this.sINHVIENTableAdapter.Update(this.qLDSVDataSet);
                        addBtn.Enabled
                        = deleteBtn.Enabled
                        = adjustBtn.Enabled
                        = undoBtn.Enabled
                        = reloadBtn.Enabled = true;

                        danhSachSV.Enabled = true;
                        groupEdit.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        sINHVIENBindingSource.RemoveCurrent();
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                return;

            }

            if (pos > 0)
            {
               sINHVIENBindingSource.Position = pos;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //xóa trạng thái
            sINHVIENBindingSource.CancelEdit();

            FormSinhVien_Load(sender, e);
            if (pos > 0)
            {
                lOPBindingSource.Position = pos;
            }

            danhSachSV.Enabled = true;
            groupEdit.Enabled = false; 
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            FormSinhVien_Load(sender, e);
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

        private bool CheckHP(string maSV)
        {



            string qr = " DECLARE @return_value int " +

                            " EXEC    @return_value = [dbo].[SP_CHECKCODEHOCPHI] " +

                            " @masv = N'" + maSV + "'" +

                            " SELECT  'Return Value' = @return_value ";
            int result = -1;
            SqlDataReader dataReader = Program.ExecSqlDataReader(qr);

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
                return true;
            }
            else
            {
                return false;
            }
        }

      
        private bool CheckInfoSinhVien()
        {

            //Check khoảng trống ở textField
            if (maSinhVien.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(maSinhVien, "Mã Sinh viên không được để trống!");
                maSinhVien.Focus();
                return false;
            }
            else if (ho.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(ho, "Họ không được để trống");
                ho.Focus();
                return false;
            }
            else if (ten.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(ten, "Tên không được để trống");
                ten.Focus();
                return false;
            }
            else if (noiSinh.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(noiSinh, "Nơi sinh không được để trống");
                noiSinh.Focus();
                return false;
            }
            else if (diaChi.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(ten, "Địa chỉ không được để trống");
                diaChi.Focus();
                return false;
            }
            else
            {
                errorProvider.Clear();
            }
            if(flag)
            {

                //Check mã sinh viên có tồn tại chưa
                string qr = " DECLARE @return_value INT " +

                                " EXEC @return_value = [dbo].[SP_CHECKCODE] " +

                                " @Code = N'" + maSinhVien.Text + "',  " +

                                " @Type = N'MASV' " +

                                " SELECT  'Return Value' = @return_value ";

                int result = -1;
                SqlDataReader dataReader = Program.ExecSqlDataReader(qr);

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
                    MessageBox.Show("Mã Sinh Viên đã tồn tại. Mời bạn chon mã khác !", "Cảnh báo", MessageBoxButtons.OK);
                    return false;
                }
                if (result == 2)
                {
                    MessageBox.Show("Mã Sinh Viên đã tồn tại ở Khoa khác. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK);
                    return false;
                }
                undoStk.PushUndo("ADD", ((DataRowView)this.sINHVIENBindingSource[this.sINHVIENBindingSource.Position]));
            }

            if (flag == false)
            {
                int result = -1;
                SqlDataReader dataReader = null;
                if (!this.maLop.Text.Trim().ToString().Equals(oldMaLop))// Mã lớp thay đổi so với ban đầu
                {
                    //TODO: Check mã lớp có tồn tại chưa
                    string queryMa = "DECLARE  @return_value int \n"
                                + "EXEC @return_value = SP_CHECKCODE \n"
                                + "@Code = N'" + maLop.Text.Trim() + "',@Type = N'MALOP' \n"
                                + "SELECT 'Return Value' = @return_value";

                    dataReader = Program.ExecSqlDataReader(queryMa);

                    // nếu null thì thoát luôn  ==> lỗi kết nối
                    if (dataReader == null)
                    {
                        MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    dataReader.Read();
                    result = int.Parse(dataReader.GetValue(0).ToString());
                    dataReader.Close();

                    if (result != 1)
                    {
                        this.errorProvider.SetError(maLop, "Mã lớp không tồn tại!");
                        return false;
                    }
                }
                //Check mã sinh viên có tồn tại chưa
                string qr = " DECLARE @return_value INT " +

                                " EXEC @return_value = [dbo].[SP_CHECKCODE] " +

                                " @Code = N'" + maSinhVien.Text + "',  " +

                                " @Type = N'MASV' " +

                                " SELECT  'Return Value' = @return_value ";

                result = -1;
                dataReader = Program.ExecSqlDataReader(qr);

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
                    MessageBox.Show("Mã Sinh Viên đã tồn tại. Mời bạn chon mã khác !", "Cảnh báo", MessageBoxButtons.OK);
                    return false;
                }
                if (result == 2)
                {
                    MessageBox.Show("Mã Sinh Viên đã tồn tại ở Khoa khác. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK);
                    return false;
                }
                undoStk.PushUndo("ADJUST", ((DataRowView)this.sINHVIENBindingSource[this.sINHVIENBindingSource.Position]));
            }
            return true;
        }

        private void btnNu_CheckedChanged(object sender, EventArgs e)
        {
            if(btnNu.Checked)
            {
                btnNam.Checked = false;
            }
            else
            {
                btnNam.Checked = true;
            }
        }
    
    }
}