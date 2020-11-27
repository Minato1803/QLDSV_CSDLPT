namespace QLSV
{
    partial class FormTaoTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.userName = new System.Windows.Forms.TextBox();
            this.passWord = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.clearGiaoVien = new DevExpress.XtraEditors.SimpleButton();
            this.dangkiGiaoVien = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMaGiaoVien = new System.Windows.Forms.ComboBox();
            this.vDSGVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new QLSV.QLDSVDataSet();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.vDSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.dangkiSinhVien = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clearSinhVien = new DevExpress.XtraEditors.SimpleButton();
            this.cbMaSinhVien = new System.Windows.Forms.ComboBox();
            this.vDSSVTaoTKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.confirmPassWord = new DevExpress.XtraEditors.TextEdit();
            this.v_DSPMTableAdapter = new QLSV.QLDSVDataSetTableAdapters.V_DSPMTableAdapter();
            this.v_DSGVTableAdapter = new QLSV.QLDSVDataSetTableAdapters.V_DSGVTableAdapter();
            this.v_DSSV_TaoTKTableAdapter = new QLSV.QLDSVDataSetTableAdapters.V_DSSV_TaoTKTableAdapter();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSGVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSSVTaoTKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(166, 91);
            this.userName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(301, 32);
            this.userName.TabIndex = 0;
            // 
            // passWord
            // 
            this.passWord.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWord.Location = new System.Drawing.Point(166, 167);
            this.passWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passWord.Name = "passWord";
            this.passWord.PasswordChar = '●';
            this.passWord.Size = new System.Drawing.Size(301, 32);
            this.passWord.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // tabPane1
            // 
            this.tabPane1.Appearance.BackColor = System.Drawing.Color.White;
            this.tabPane1.Appearance.Options.UseBackColor = true;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.Location = new System.Drawing.Point(166, 303);
            this.tabPane1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.tabPane1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(302, 385);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(302, 385);
            this.tabPane1.TabIndex = 6;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Giáo Viên";
            this.tabNavigationPage1.Controls.Add(this.clearGiaoVien);
            this.tabNavigationPage1.Controls.Add(this.dangkiGiaoVien);
            this.tabNavigationPage1.Controls.Add(this.label8);
            this.tabNavigationPage1.Controls.Add(this.comboBox1);
            this.tabNavigationPage1.Controls.Add(this.label7);
            this.tabNavigationPage1.Controls.Add(this.label6);
            this.tabNavigationPage1.Controls.Add(this.cbMaGiaoVien);
            this.tabNavigationPage1.Controls.Add(this.cbKhoa);
            this.tabNavigationPage1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(302, 339);
            // 
            // clearGiaoVien
            // 
            this.clearGiaoVien.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearGiaoVien.Appearance.Options.UseFont = true;
            this.clearGiaoVien.Location = new System.Drawing.Point(0, 298);
            this.clearGiaoVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearGiaoVien.Name = "clearGiaoVien";
            this.clearGiaoVien.Size = new System.Drawing.Size(138, 42);
            this.clearGiaoVien.TabIndex = 6;
            this.clearGiaoVien.Text = "Xóa";
            // 
            // dangkiGiaoVien
            // 
            this.dangkiGiaoVien.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dangkiGiaoVien.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangkiGiaoVien.Appearance.Options.UseBackColor = true;
            this.dangkiGiaoVien.Appearance.Options.UseFont = true;
            this.dangkiGiaoVien.Location = new System.Drawing.Point(164, 298);
            this.dangkiGiaoVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dangkiGiaoVien.Name = "dangkiGiaoVien";
            this.dangkiGiaoVien.Size = new System.Drawing.Size(138, 42);
            this.dangkiGiaoVien.TabIndex = 7;
            this.dangkiGiaoVien.Text = "Đăng kí";
            this.dangkiGiaoVien.Click += new System.EventHandler(this.dangkiGiaoVien_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-3, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Vai trò";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 208);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(301, 32);
            this.comboBox1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-3, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Giáo viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-3, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Khoa";
            // 
            // cbMaGiaoVien
            // 
            this.cbMaGiaoVien.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbMaGiaoVien.DataSource = this.vDSGVBindingSource;
            this.cbMaGiaoVien.DisplayMember = "HOTEN";
            this.cbMaGiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaGiaoVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMaGiaoVien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaGiaoVien.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbMaGiaoVien.FormattingEnabled = true;
            this.cbMaGiaoVien.Location = new System.Drawing.Point(0, 126);
            this.cbMaGiaoVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMaGiaoVien.Name = "cbMaGiaoVien";
            this.cbMaGiaoVien.Size = new System.Drawing.Size(301, 32);
            this.cbMaGiaoVien.TabIndex = 1;
            this.cbMaGiaoVien.ValueMember = "MAGV";
            // 
            // vDSGVBindingSource
            // 
            this.vDSGVBindingSource.DataMember = "V_DSGV";
            this.vDSGVBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbKhoa
            // 
            this.cbKhoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbKhoa.DataSource = this.vDSPMBindingSource;
            this.cbKhoa.DisplayMember = "TENKHOA";
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKhoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(0, 48);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(301, 32);
            this.cbKhoa.TabIndex = 0;
            this.cbKhoa.ValueMember = "TENSERVER";
            // 
            // vDSPMBindingSource
            // 
            this.vDSPMBindingSource.DataMember = "V_DSPM";
            this.vDSPMBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Sinh Viên";
            this.tabNavigationPage2.Controls.Add(this.dangkiSinhVien);
            this.tabNavigationPage2.Controls.Add(this.label5);
            this.tabNavigationPage2.Controls.Add(this.label4);
            this.tabNavigationPage2.Controls.Add(this.clearSinhVien);
            this.tabNavigationPage2.Controls.Add(this.cbMaSinhVien);
            this.tabNavigationPage2.Controls.Add(this.cbLop);
            this.tabNavigationPage2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(302, 339);
            // 
            // dangkiSinhVien
            // 
            this.dangkiSinhVien.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dangkiSinhVien.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangkiSinhVien.Appearance.Options.UseBackColor = true;
            this.dangkiSinhVien.Appearance.Options.UseFont = true;
            this.dangkiSinhVien.Location = new System.Drawing.Point(164, 298);
            this.dangkiSinhVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dangkiSinhVien.Name = "dangkiSinhVien";
            this.dangkiSinhVien.Size = new System.Drawing.Size(138, 42);
            this.dangkiSinhVien.TabIndex = 13;
            this.dangkiSinhVien.Text = "Đăng kí";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-5, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-3, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lớp";
            // 
            // clearSinhVien
            // 
            this.clearSinhVien.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSinhVien.Appearance.Options.UseFont = true;
            this.clearSinhVien.Location = new System.Drawing.Point(0, 298);
            this.clearSinhVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearSinhVien.Name = "clearSinhVien";
            this.clearSinhVien.Size = new System.Drawing.Size(138, 42);
            this.clearSinhVien.TabIndex = 12;
            this.clearSinhVien.Text = "Xóa";
            // 
            // cbMaSinhVien
            // 
            this.cbMaSinhVien.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbMaSinhVien.DataSource = this.vDSSVTaoTKBindingSource;
            this.cbMaSinhVien.DisplayMember = "HOTEN";
            this.cbMaSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMaSinhVien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaSinhVien.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbMaSinhVien.FormattingEnabled = true;
            this.cbMaSinhVien.Location = new System.Drawing.Point(0, 126);
            this.cbMaSinhVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMaSinhVien.Name = "cbMaSinhVien";
            this.cbMaSinhVien.Size = new System.Drawing.Size(301, 32);
            this.cbMaSinhVien.TabIndex = 9;
            this.cbMaSinhVien.ValueMember = "MASV";
            // 
            // vDSSVTaoTKBindingSource
            // 
            this.vDSSVTaoTKBindingSource.DataMember = "V_DSSV_TaoTK";
            this.vDSSVTaoTKBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // cbLop
            // 
            this.cbLop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbLop.DataSource = this.vDSSVTaoTKBindingSource;
            this.cbLop.DisplayMember = "MALOP";
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(0, 48);
            this.cbLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(301, 32);
            this.cbLop.TabIndex = 8;
            this.cbLop.ValueMember = "MALOP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSV.Properties.Resources.man_desk;
            this.pictureBox1.Location = new System.Drawing.Point(638, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // confirmPassWord
            // 
            this.confirmPassWord.Location = new System.Drawing.Point(166, 249);
            this.confirmPassWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmPassWord.Name = "confirmPassWord";
            this.confirmPassWord.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassWord.Properties.Appearance.Options.UseFont = true;
            this.confirmPassWord.Properties.PasswordChar = '●';
            this.confirmPassWord.Size = new System.Drawing.Size(302, 30);
            this.confirmPassWord.TabIndex = 2;
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
            // 
            // v_DSGVTableAdapter
            // 
            this.v_DSGVTableAdapter.ClearBeforeFill = true;
            // 
            // v_DSSV_TaoTKTableAdapter
            // 
            this.v_DSSV_TaoTKTableAdapter.ClearBeforeFill = true;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // FormTaoTaiKhoan
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 950);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmPassWord);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.userName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTaoTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Tài Khoản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSGVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSSVTaoTKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.MaskedTextBox passWord;
        private DevExpress.XtraEditors.TextEdit confirmPassWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.ComboBox cbMaGiaoVien;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.ComboBox cbMaSinhVien;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton dangkiGiaoVien;
        private DevExpress.XtraEditors.SimpleButton clearGiaoVien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton dangkiSinhVien;
        private DevExpress.XtraEditors.SimpleButton clearSinhVien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource vDSPMBindingSource;
        private QLDSVDataSetTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private System.Windows.Forms.BindingSource vDSGVBindingSource;
        private QLDSVDataSetTableAdapters.V_DSGVTableAdapter v_DSGVTableAdapter;
        private System.Windows.Forms.BindingSource vDSSVTaoTKBindingSource;
        private QLDSVDataSetTableAdapters.V_DSSV_TaoTKTableAdapter v_DSSV_TaoTKTableAdapter;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}