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
    public partial class FormHocPhi : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource bds_SV = new BindingSource();
        private BindingSource bds_HPSV = new BindingSource();
        private int pos;
        private Boolean flag = false; //add 0 update 1
        private String currNienKhoa = ""; //niên khóa hiện tại
        private String maSV = "";
        private int currHK = 1; // kì học hiện tại
        private int currHP;
        private int currMEarned;
        private Boolean enoughMoney = false; // kiểm tra xem đóng tiền đủ chưa, nếu đủ r thì mới cho sang khóa mới - kì mới;
        public FormHocPhi()
        {
            InitializeComponent();
        }


        //==================================================== XỬ LÝ DỮ LIỆU ĐỔ VÀO====================================================//
        private void FormHocPhi_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'qLDSVDataSet.V_DSHPSV' table. You can move, or remove it, as needed.
            //this.v_DSHPSVTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.v_DSHPSVTableAdapter.Fill(this.qLDSVDataSet.V_DSHPSV);
            // TODO: This line of code loads data into the 'qLDSVDataSet.CT_DONGHOCPHI' table. You can move, or remove it, as needed.
            this.cT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_DONGHOCPHITableAdapter.Fill(this.qLDSVDataSet.CT_DONGHOCPHI);
            // TODO: This line of code loads data into the 'qLDSVDataSet.HOCPHI' table. You can move, or remove it, as needed.
            this.hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.hOCPHITableAdapter.Fill(this.qLDSVDataSet.HOCPHI);
            // TODO: This line of code loads data into the 'qLDSVDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
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

        private void cbMaSV_EditValueChanged(object sender, EventArgs e)
        {
            maSV = leMaSV.Properties.GetDisplayText(leMaSV.EditValue);
            DataTable dtsv = new DataTable();
            //gọi 1 view và trả về dưới dạng datatable
            dtsv = Program.ExecSqlDataTable("SELECT * FROM LINK0.QLDSV.dbo.V_DSSV_TaoTK SV WHERE SV.MASV = '" + maSV + "'");
            hoTen.Text = dtsv.Rows[0].Field<String>("HOTEN");
            maLop.Text = dtsv.Rows[0].Field<String>("MALOP");

            // đổ table Add vào gridControl
            string cmdload = "EXEC [dbo].[SP_DSHPSinhVien] " +
                          "@masv = N'" + maSV + "'";
            DataTable dtHPSV = Program.ExecSqlDataTable(cmdload);

            if (dtHPSV.Rows.Count > 0)
            {
                //tính tổng số tiền đã đóng cho mỗi cell
                int sum = 0;
                String tmpNienKhoa = dtHPSV.Rows[0].Field<String>("NIENKHOA");
                int tmpHK = dtHPSV.Rows[0].Field<Int32>("HOCKY");
                for (int i = 0; i < dtHPSV.Rows.Count; ++i)
                {
                    if (tmpNienKhoa != dtHPSV.Rows[i].Field<String>("NIENKHOA") || tmpHK != dtHPSV.Rows[0].Field<Int32>("HOCKY"))
                    {
                        sum = 0;
                    }
                    sum += Convert.ToInt32(dtHPSV.Rows[i].Field<Int32>("SOTIENDONG"));
                    //DataRow dr = dthpSV.Rows[i];
                    dtHPSV.Rows[i]["SOTIENDADONG"] = sum;
                    Console.WriteLine(sum);
                }
                //daDong.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Sinh viên chưa có dữ liệu học phí", "Thông báo", MessageBoxButtons.OK);
            }
            dtHPSV.AcceptChanges();
            this.bds_HPSV.DataSource = dtHPSV;
            this.danhSachHPSV.DataSource = this.bds_HPSV;
            this.viewHPSV.RefreshData();
            pos = bds_HPSV.Position;
            // kiểm tra tiền học phí
            if(bds_HPSV.Count>0)
            {
                currNienKhoa = ((DataRowView)bds_HPSV[pos])["NIENKHOA"].ToString();
                currHK = (int) ((DataRowView)bds_HPSV[pos])["HOCKY"];
                currHP = (int) ((DataRowView)bds_HPSV[pos])["HOCPHI"];
                Console.WriteLine("sotiendadong: " + ((DataRowView)bds_HPSV[pos])["SOTIENDADONG"]);
                currMEarned = int.Parse(((DataRowView)bds_HPSV[pos])["SOTIENDADONG"].ToString());
                //currMEarned = 0;
                if (currHP != currMEarned) // HP != STDONG
                {
                    enoughMoney = false;
                }
                else
                    enoughMoney = true;

            }
            else
            {
                enoughMoney = true;
            }
            Console.WriteLine("checkcurrHP: " + currNienKhoa + " " + currHK + " " + enoughMoney);

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
                = leMaSV.Enabled
                = false;
            pos = bds_HPSV.Position;
            nienKhoa.Focus();

            // TODO : Thao tác chuẩn bị thêm
            bds_HPSV.AddNew();
            if(!enoughMoney) // nếu không đóng đủ thì không cho nhập NK HK
            {
                ((DataRowView) bds_HPSV[pos])["NIENKHOA"] 
                    = nienKhoa.Text
                    = currNienKhoa;
                ((DataRowView) bds_HPSV[pos])["HOCKY"] = currHK;
                hocKi.Text = currHK.ToString();
                ((DataRowView) bds_HPSV[pos])["HOCPHI"] = currHP;
                hocPhi.Text = currHP.ToString();
                this.viewHPSV.RefreshData();
                Console.WriteLine("add: " + currNienKhoa + " " + currHK + " " + enoughMoney);
                nienKhoa.Enabled
                    = hocKi.Enabled
                    = hocPhi.Enabled
                    = false;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    cTDONGHOCPHIBindingSource.RemoveCurrent();
                    this.cT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cT_DONGHOCPHITableAdapter.Update(this.qLDSVDataSet.CT_DONGHOCPHI);
                    bds_HPSV.RemoveCurrent();
                    this.bds_HPSV.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                    this.danhSachHPSV.DataSource = bds_HPSV;
                    this.viewHPSV.RefreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa học phí\nBạn hãy xem lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                }


            }


            if (pos > 0)
            {
                bds_HPSV.Position = pos;
                currNienKhoa = (String) ((DataRowView)this.bds_HPSV[pos])["NIENKHOA"];
                currHK =(int) ((DataRowView)this.bds_HPSV[pos])["HOCKY"];
                currHP = (int) ((DataRowView)this.bds_HPSV[pos])["HOCPHI"];
                currMEarned = int.Parse(((DataRowView)bds_HPSV[pos])["SOTIENDADONG"].ToString());
                if (currHP != currMEarned) // HP != STDONG
                {
                    enoughMoney = false;
                }
                else
                    enoughMoney = true;
            }
        }

        private void adjustBtn_Click(object sender, EventArgs e)
        {
            flag = false;//  Update 

            saveBtn.Enabled
                = exitBtn.Enabled
                = groupEdit.Enabled = true;

            addBtn.Enabled
                = deleteBtn.Enabled
                = adjustBtn.Enabled
                = undoBtn.Enabled
                = reloadBtn.Enabled
                = leMaSV.Enabled
                = danhSachHPSV.Enabled = false;
            daDong.Text = (int.Parse(daDong.Text) - int.Parse(Dong.Text)).ToString();
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            // check giá trị trước khi add
            bool check = checkInfoHP();
            if (check)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    ((DataRowView)bds_HPSV[pos])["NIENKHOA"] = nienKhoa.Text;
                    ((DataRowView)bds_HPSV[pos])["HOCKY"] = hocKi.Text;
                    ((DataRowView)bds_HPSV[pos])["HOCPHI"] = hocPhi.Text;
                    ((DataRowView)bds_HPSV[pos])["SOTIENDONG"] = Dong.Text;


                    try
                    {
                        bds_HPSV.EndEdit();
                        SqlConnection conn = new SqlConnection(Program.connstr);
                        // bắt đầu transaction
                        SqlTransaction tran;

                        conn.Open();
                        tran = conn.BeginTransaction();
                        try
                        {
                            SqlCommand cmd = new SqlCommand("SP_NHAPHOCPHI", conn);
                            cmd.Connection = conn;
                            cmd.Transaction = tran;

                            cmd.CommandType = CommandType.StoredProcedure;
                            int soTienDong = (int)((DataRowView)bds_HPSV[pos])["SOTIENDONG"];
                            cmd.Parameters.Add(new SqlParameter("@MASV", maSV));
                            cmd.Parameters.Add(new SqlParameter("@NIENKHOA", ((DataRowView)bds_HPSV[pos])["NIENKHOA"]));
                            cmd.Parameters.Add(new SqlParameter("@HOCKY", ((DataRowView)bds_HPSV[pos])["HOCKY"]));
                            cmd.Parameters.Add(new SqlParameter("@HOCPHI", ((DataRowView)bds_HPSV[pos])["HOCPHI"]));
                            cmd.ExecuteNonQuery();

                            cmd = new SqlCommand("SP_NHAPCTHOCPHI", conn);
                            cmd.Connection = conn;
                            cmd.Transaction = tran;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@MASV", maSV));
                            cmd.Parameters.Add(new SqlParameter("@NIENKHOA", ((DataRowView)bds_HPSV[pos])["NIENKHOA"]));
                            cmd.Parameters.Add(new SqlParameter("@HOCKY", ((DataRowView)bds_HPSV[pos])["HOCKY"]));
                            DateTime myDateTime = DateTime.Now;
                            string sqlFormattedDate = myDateTime.Date.ToString("yyyy-MM-dd");

                            cmd.Parameters.Add(new SqlParameter("@NGAYDONG", sqlFormattedDate));
                            cmd.Parameters.Add(new SqlParameter("@SOTIENDONG", ((DataRowView)bds_HPSV[pos])["SOTIENDONG"]));
                            cmd.ExecuteNonQuery();
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
                         tran.Commit();
                        // ct_hocphi
                        conn = new SqlConnection(Program.connstr);
                        // bắt đầu transaction

                        conn.Open();
                        tran = conn.BeginTransaction();
                        try
                        {
                            SqlCommand cmd = new SqlCommand("SP_NHAPCTHOCPHI", conn);
                            cmd.Connection = conn;
                            cmd.Transaction = tran;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@MASV", maSV));
                            cmd.Parameters.Add(new SqlParameter("@NIENKHOA", ((DataRowView)bds_HPSV[pos])["NIENKHOA"]));
                            cmd.Parameters.Add(new SqlParameter("@HOCKY", ((DataRowView)bds_HPSV[pos])["HOCKY"]));
                            DateTime myDateTime = DateTime.Now;
                            string sqlFormattedDate = myDateTime.Date.ToString("yyyy-MM-dd");

                            cmd.Parameters.Add(new SqlParameter("@NGAYDONG", sqlFormattedDate));
                            cmd.Parameters.Add(new SqlParameter("@SOTIENDONG", ((DataRowView)bds_HPSV[pos])["SOTIENDONG"]));
                            cmd.ExecuteNonQuery();
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
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        bds_HPSV.RemoveCurrent();
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.bds_HPSV.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                    addBtn.Enabled
                    = deleteBtn.Enabled
                    = adjustBtn.Enabled
                    = undoBtn.Enabled
                    = reloadBtn.Enabled = true;

                    danhSachHPSV.Enabled = true;
                    groupEdit.Enabled = false;
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
            bds_HPSV.CancelEdit();

            FormHocPhi_Load(sender, e);
            if (pos > 0)
            {
                bds_HPSV.Position = pos;
            }

            danhSachHPSV.Enabled = true;
            groupEdit.Enabled = false;
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            FormHocPhi_Load(sender, e);
            MessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        private void quitFormBtn_Click(object sender, EventArgs e)
        {
            if (groupEdit.Enabled)
            {
                DialogResult dr = MessageBox.Show(" Dữ liệu học phí chưa lưu vào Database \n Bạn có chắc muốn thoát !", "Cảnh báo", MessageBoxButtons.YesNo);

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

        private Boolean checkInfoHP()
        {
            //Check khoảng trống ở textField
            if (nienKhoa.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(nienKhoa, "Niên khóa không được để trống!");
                nienKhoa.Focus();
                return false;
            }
            else if (hocKi.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(hocKi, "Học kì không được để trống");
                hocKi.Focus();
                return false;
            }
            else if (hocPhi.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(hocPhi, "Học phí không được để trống");
                hocPhi.Focus();
                return false;
            }
            else if (Dong.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(Dong, "Số tiền đóng không được để trống");
                Dong.Focus();
                return false;
            }
            else
            {
                errorProvider.Clear();
            }
            if(flag)
            {
                if(enoughMoney == true && currHK.ToString() == hocKi.Text.Trim())
                {
                    MessageBox.Show("Học kì này đã đóng đủ!", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                int tienDaDong = int.Parse(Dong.Text.Trim().ToString()) + int.Parse(((DataRowView)bds_HPSV[pos])["SOTIENDADONG"].ToString());
                int tienHocPhi = int.Parse(hocPhi.Text);
                if (tienDaDong > tienHocPhi)
                {
                    MessageBox.Show("Số tiền đóng không được lớn hơn học phí !", "", MessageBoxButtons.OK);
                    return false;
                }

            }
            if(flag == false)
            {
                int tienDaDong = int.Parse(daDong.Text);
                int tienHocPhi = int.Parse(hocPhi.Text);
                if (tienDaDong > tienHocPhi)
                {
                    MessageBox.Show("Số tiền đóng không được lớn hơn học phí !", "", MessageBoxButtons.OK);
                    return false;
                }
            }

            return true;
        }

    }
}