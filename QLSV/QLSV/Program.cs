using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;

namespace QLSV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        // tạo đối tượng kết nối Conn , kêt nối Database bằng mã lệnh
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataAdapter da = null;
        public static BindingSource bds = new BindingSource();
        public static BindingSource bds_dsgv = new BindingSource();
        public static BindingSource bds_lop = new BindingSource();
        public static BindingSource bds_mon = new BindingSource();
        public static BindingSource bds_khoa = new BindingSource();
        public static SqlDataReader myReader =null;
        //public static String servername = "MINATO";
        //public static String[] GetServerName = new string[3] { "MINATO\\MSSQLSERVER1", "MINATO\\MSSQLSERVER2", "MINATO\\MSSQLSERVER3" };
        public static String servername = "TNCNHAN\\TNCN";

        public static String[] GetServerName = new string[3]{ "TNCNHAN\\TNCN\\MSSQLSERVER1", "TNCNHAN\\TNCN\\MSSQLSERVER2", "TNCNHAN\\TNCN\\MSSQLSERVER3" };
        public static String username = "";
        // lưu các login và password từ các form khi chương trình chạy
        public static String mlogin = "";
        public static String password = "";
        //MLoginDN là mã login đăng nhập và mật khẩu của nó
        public static String mloginDN = "";
        public static String passwordDN = "";

        public static String database = "QLDSV";
        // RemoteLogin này là remote dùng để hỗ trợ kết nối ra ngoài ví dụ trong quá trình đăng nhập nó sẽ rẽ qua server 2
        // để đăng nhập truy vấn dữ liệu thì nó dùng login này để kết nối(hay là tạo link server)
        // vì nó giống nhau trên các phân mảnh là HTKN nối nó sẽ gán cứng vào.
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123456";
       
        // 3 Mgroup , MHoten, MKhoa dùng để hiển thi thông tin login vào
        // MGroup là mã nhóm quyền khi của login đó đăng nhập vào.
        public static String mGroup = ""; // PGV KHOA USERS PKeToan
        public static String mHoten = "";
        public static int mKhoa = 0; //->0 CNTT 1 VT 2 KT
        public static string[] TKhoa = new string[3] { "CNTT", "VT", "KT"};
        // trạng thái đăng nhập
        public static Boolean logged = false;
        // lưu danh sách các nhóm quyền
        public static string[] NhomQuyen = new string[4] { "PGV", "KHOA", "USERS", "PKeToan" };
        //biến dùng để chứa danh sách các phân mãnh từ viewDSPM (bằng code, ko kéo thả)
        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập
        public static LoginForm frmLogin;

        // hàm thực hiện kết nối tới Database
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                logged = true;
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu" + e.Message, "", MessageBoxButtons.OK);
                Program.conn.Close();
                return 0;
            }
        }

        // ExecSqlDataReader tôc độ tải về nhanh hơn ExecSqlDataTable vì đối tượng nó chỉ quam tân chỉ select
        // chỉ duyệt 1 chiều từ trên xuống
        // vì vậy trong nghiệp vụ form báo cáo thì dùng datareader
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        // tải về cho phép xem xóa sửa
        // duyệt 2 chiều dưới lên
        // form nhập liệu thì dùng datatable.
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        //thực thi các câu truy vấn như INSERT, DELETE, UPDATE. 
        //Kiểm tra số dòng trong table của database bị thay đổi bởi 3 lệnh trên. 
        //
        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }
        public static void SetEnableOfButton(Form frm, Boolean Active)
        {

            foreach (Control ctl in frm.Controls)
                if ((ctl) is Button)
                    ctl.Enabled = Active;
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new LoginForm();
            Application.Run(frmLogin);
        }
    }
}
