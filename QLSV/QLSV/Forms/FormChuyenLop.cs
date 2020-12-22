using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class FormChuyenLop : Form
    {
        private bool flagChuyenLop;
        private bool flagMaSV;
        private bool flagMaLop;
        public FormChuyenLop()
        {
            flagChuyenLop = false;
            InitializeComponent();
        }

        private void FormChuyenLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);
            // TODO: This line of code loads data into the 'qLDSVDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'qLDSVDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);
            

        }

        private void maSinhVien_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            maSinhVien_EditValueChanged(sender, e);
        }

        private void maSinhVien_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView dataRow = maSinhVien.GetSelectedDataRow() as DataRowView;
            if (dataRow != null)
            {
                errorMSV.Clear();
                flagMaSV = true;
                if (flagMaLop)
                {
                    btnOk.Enabled = true;
                }
                ten.Text = (string)dataRow["HO"] + " " + (string)dataRow["TEN"];
                if ((bool)dataRow["PHAI"])
                {
                    phai.Text = "Nam";
                }
                else
                {
                    phai.Text = "Nữ";
                }
                namSinh.Text = dataRow["NGAYSINH"].ToString();
            }
            else
            {
                flagMaSV = false;
                errorMSV.SetError(maSinhVien, "Mã Sinh Viên không có!");
                btnOk.Enabled = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!flagChuyenLop)
            {
                //Kiểm tra khoa có chung hay không
                string qr = " DECLARE @return_value INT " +
                                " EXEC @return_value = [dbo].[SP_chuyenChungKhoa] " +
                                " @MASINHVIEN = N'" + maSinhVien.Text + "',  " +
                                " @MALOPMOI =N'" + maLop.Text + "'  " +
                                " SELECT  'Return Value' = @return_value ";
                int result = -1;
                SqlDataReader dataReader = Program.ExecSqlDataReader(qr);

                // nếu null thì thoát luôn  ==> lỗi kết nối
                if (dataReader == null)
                {
                    MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                }
                dataReader.Read();
                result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();

                if (result == 0)
                {
                    MessageBox.Show("Lớp vừa nhập trùng lớp cũ !", "Thông Báo", MessageBoxButtons.OK);
                }
                else if (result == 1)
                {
                    MessageBox.Show("Chuyển thành công vào lớp, khoa giữ nguyên !", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    flagChuyenLop = true;
                }
            }
            
            if(flagChuyenLop)
            {
                maSinhVienMoi.Visible = true;
                if (maSinhVienMoi.Text.Equals(""))
                {
                    MessageBox.Show("Mời nhập mã sinh viên mới ở khoa mới !", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    //Check mã sinh viên có tồn tại chưa
                    string qr = " DECLARE @return_value INT " +

                                    " EXEC @return_value = [dbo].[SP_CHECKCODE] " +

                                    " @Code = N'" + maSinhVienMoi.Text + "',  " +

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

                    if (result == 0)
                    {
                        MessageBox.Show("Mã Sinh Viên đã tồn tại. Mời bạn chon mã khác !", "Cảnh báo", MessageBoxButtons.OK);
                    }
                    else 
                    {
                        qr = " DECLARE @return_value INT " +
                            " EXEC @return_value = [dbo].[SP_chuyenKhacKhoa] " +
                            " @MASV = N'" + maSinhVien.Text + "',  " +
                            " @MASVMOI = N'" + maSinhVienMoi.Text + "',  " +
                            " @MALOPMOI =N'" + maLop.Text + "'  " +
                            " SELECT  'Return Value' = @return_value ";
                        result = -1;
                        dataReader = Program.ExecSqlDataReader(qr);

                        // nếu null thì thoát luôn  ==> lỗi kết nối
                        if (dataReader == null)
                        {
                            MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                        }
                        dataReader.Read();
                        result = int.Parse(dataReader.GetValue(0).ToString());
                        dataReader.Close();

                        if (result == 0)
                        {
                            MessageBox.Show("Chuyển lớp thành công !", "Thông Báo", MessageBoxButtons.OK);
                            maSinhVienMoi.Visible = false;
                            maSinhVienMoi.Text = "";
                            flagChuyenLop = false;
                        }
                        else
                        {
                            MessageBox.Show("Chuyển thất bại, mời bạn thử lại !", "Thông Báo", MessageBoxButtons.OK);
                        }
                    }
                    
                }
            }
        }

        private void maLop_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView dataRow = maLop.GetSelectedDataRow() as DataRowView;
            if (dataRow != null)
            {
                flagMaLop = true;
                if (flagMaSV)
                {
                    btnOk.Enabled = true;
                }
                errorMSV.Clear();
            }
            else
            {
                errorMSV.SetError(maSinhVien, "Mã Lớp không có!");
                flagMaLop = false;
                btnOk.Enabled = false;
            }
        }
    }
}
