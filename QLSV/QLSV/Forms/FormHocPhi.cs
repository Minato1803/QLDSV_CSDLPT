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
    public partial class FormHocPhi : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource bds_SV = new BindingSource();
        private BindingSource bds_HPSV = new BindingSource();
        private int pos;
        private Boolean flag = false; //add 0 update 1
        private String currNienKhoa = ""; //niên khóa hiện tại
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
            String maSV = leMaSV.Properties.GetDisplayText(leMaSV.EditValue);
            DataTable dtsv = new DataTable();
            //gọi 1 view và trả về dưới dạng datatable
            dtsv = Program.ExecSqlDataTable("SELECT * FROM LINK0.QLDSV.dbo.V_DSSV_TaoTK SV WHERE SV.MASV = '" + maSV + "'");
            hoTen.Text = dtsv.Rows[0].Field<String>("HOTEN");
            maLop.Text = dtsv.Rows[0].Field<String>("MALOP");

            DataTable dthpSV = new DataTable();
            //gọi 1 view và trả về dưới dạng datatable
            dthpSV = Program.ExecSqlDataTable("SELECT * FROM LINK0.QLDSV.dbo.V_DSHPSV SV WHERE SV.MASV = '" + maSV + "'");

            if (dthpSV.Rows.Count > 0)
            {
                //tính tổng số tiền đã đóng cho mỗi cell
                int sum = 0;
                String tmpNienKhoa = dthpSV.Rows[0].Field<String>("NIENKHOA");
                int tmpHK = dthpSV.Rows[0].Field<Int32>("HOCKY");
                for (int i = 0; i < dthpSV.Rows.Count; ++i)
                {
                    if (tmpNienKhoa != dthpSV.Rows[i].Field<String>("NIENKHOA") || tmpHK != dthpSV.Rows[0].Field<Int32>("HOCKY"))
                    {
                        sum = 0;
                    }
                    sum += Convert.ToInt32(dthpSV.Rows[i].Field<Int32>("SOTIENDONG"));
                    //DataRow dr = dthpSV.Rows[i];
                    dthpSV.Rows[i]["SOTIENDADONG"] = sum;
                    Console.WriteLine(sum);
                }
                //daDong.Text = sum.ToString();
            }
            dthpSV.AcceptChanges();
            this.vDSHPSVBindingSource.DataSource = dthpSV;
            this.v_DSHPSVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DSHPSVTableAdapter.Fill(this.qLDSVDataSet.V_DSHPSV);

            // kiểm tra tiền học phí
            currNienKhoa = dthpSV.Rows[dthpSV.Rows.Count - 1].Field<String>("NIENKHOA");
            currHK = dthpSV.Rows[dthpSV.Rows.Count - 1].Field<Int32>("HOCKY");
            currHP = dthpSV.Rows[dthpSV.Rows.Count - 1].Field<Int32>("HOCPHI");
            currMEarned = dthpSV.Rows[dthpSV.Rows.Count - 1].Field<Int32>("SOTIENDADONG");
            if (currHP != currMEarned) // HP != STDONG
            {
                enoughMoney = false;
            }
            else
                enoughMoney = true;
            Console.WriteLine("checkcurrHP: " + currNienKhoa + " " + currHK);

        }

        private void Dong_TextChanged(object sender, EventArgs e)
        {
            if(daDong.Text != null)
            {
                //daDong.Text = (int.Parse(daDong.Text) + int.Parse(Dong.Text)).ToString();

            }
            else
            {
                daDong.Text = Dong.Text;
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
                = danhSachHPSV.Enabled
                = leMaSV.Enabled
                = false;
            pos = vDSHPSVBindingSource.Position;
            nienKhoa.Focus();

            // TODO : Thao tác chuẩn bị thêm
            if(!enoughMoney) // nếu không đóng đủ thì không cho nhập NK HK
            {
                nienKhoa.Text = currNienKhoa;
                hocKi.Text = currHK.ToString();
                hocPhi.Text = currHP.ToString();
                nienKhoa.Enabled
                    = hocKi.Enabled
                    = hocPhi.Enabled
                    = false;

            }
            daDong.Text = (currMEarned + int.Parse(daDong.Text.Trim().Equals("")?"0":daDong.Text.Trim())).ToString();
            this.hOCPHIBindingSource.AddNew();
            this.cTDONGHOCPHIBindingSource.AddNew();
            this.vDSHPSVBindingSource.AddNew();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    cTDONGHOCPHIBindingSource.RemoveCurrent();
                    hOCPHIBindingSource.RemoveCurrent();
                    this.cT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cT_DONGHOCPHITableAdapter.Update(this.qLDSVDataSet.CT_DONGHOCPHI);
                    this.hOCPHITableAdapter.Update(this.qLDSVDataSet.HOCPHI);
                    this.vDSHPSVBindingSource.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa học phí\nBạn hãy xem lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                }


            }


            if (pos > 0)
            {
                vDSHPSVBindingSource.Position = pos;
                currNienKhoa = (String) ((DataRowView)this.vDSHPSVBindingSource[pos])["NIENKHOA"];
                currHK =(int) ((DataRowView)this.vDSHPSVBindingSource[pos])["HOCKY"];
                currHP = (int) ((DataRowView)this.sINHVIENBindingSource[pos])["HOCPHI"];
                currMEarned = (int)((DataRowView)this.sINHVIENBindingSource[pos])["SOTIENDADONG"];
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
                    try
                    {
                        // cập nhật học phí
                        ((DataRowView)this.hOCPHIBindingSource[this.sINHVIENBindingSource.Position])["MASV"] = leMaSV.Properties.GetDisplayText(leMaSV.EditValue);
                        ((DataRowView)this.hOCPHIBindingSource[this.hOCPHIBindingSource.Position])["NIENKHOA"] = nienKhoa.Text;
                        ((DataRowView)this.hOCPHIBindingSource[this.hOCPHIBindingSource.Position])["HOCKY"] = hocKi.Text;
                        ((DataRowView)this.hOCPHIBindingSource[this.hOCPHIBindingSource.Position])["HOCPHI"] = hocPhi.Text;
                        this.hOCPHIBindingSource.EndEdit();
                        this.hOCPHITableAdapter.Update(this.qLDSVDataSet);
                        // câp nhật ct_HP
                        ((DataRowView)this.cTDONGHOCPHIBindingSource[this.cTDONGHOCPHIBindingSource.Position])["MASV"] = leMaSV.Properties.GetDisplayText(leMaSV.EditValue);
                        ((DataRowView)this.cTDONGHOCPHIBindingSource[this.cTDONGHOCPHIBindingSource.Position])["NIENKHOA"] = nienKhoa.Text;
                        ((DataRowView)this.cTDONGHOCPHIBindingSource[this.cTDONGHOCPHIBindingSource.Position])["HOCKY"] = hocKi.Text;
                        DateTime myDateTime = DateTime.Now;
                        string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
                        ((DataRowView)this.cTDONGHOCPHIBindingSource[this.cTDONGHOCPHIBindingSource.Position])["NGAYDONG"] = sqlFormattedDate.ToString();
                        ((DataRowView)this.cTDONGHOCPHIBindingSource[this.cTDONGHOCPHIBindingSource.Position])["SOTIENDONG"] = Dong.Text;
                        this.cTDONGHOCPHIBindingSource.EndEdit();
                        this.cT_DONGHOCPHITableAdapter.Update(this.qLDSVDataSet);

                        //
                        this.vDSHPSVBindingSource.CancelEdit();
                        this.vDSHPSVBindingSource.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                        addBtn.Enabled
                        = deleteBtn.Enabled
                        = adjustBtn.Enabled
                        = undoBtn.Enabled
                        = reloadBtn.Enabled = true;

                        danhSachHPSV.Enabled = true;
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
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //xóa trạng thái
            hOCPHIBindingSource.CancelEdit();
            cTDONGHOCPHIBindingSource.CancelEdit();

            FormHocPhi_Load(sender, e);
            if (pos > 0)
            {
                vDSHPSVBindingSource.Position = pos;
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
                int tienDaDong = int.Parse(daDong.Text);
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