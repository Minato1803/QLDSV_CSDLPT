﻿namespace QLSV
{
    partial class ReportBDTongKet
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inBtn2 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.txMaLop = new DevExpress.XtraEditors.LookUpEdit();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new QLSV.QLDSVDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.inBtnNhap = new DevExpress.XtraEditors.SimpleButton();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inBtn = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.vGETDSLOPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.maLop = new System.Windows.Forms.TextBox();
            this.vGETDSLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vDSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_GETDSLOPTableAdapter = new QLSV.QLDSVDataSetTableAdapters.V_GETDSLOPTableAdapter();
            this.v_DSPMTableAdapter = new QLSV.QLDSVDataSetTableAdapters.V_DSPMTableAdapter();
            this.kHOATableAdapter = new QLSV.QLDSVDataSetTableAdapters.KHOATableAdapter();
            this.sP_REPORT_DSSVTableAdapter = new QLSV.QLDSVDataSetTableAdapters.SP_REPORT_DSSVTableAdapter();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new QLSV.QLDSVDataSetTableAdapters.SINHVIENTableAdapter();
            this.lOPTableAdapter = new QLSV.QLDSVDataSetTableAdapters.LOPTableAdapter();
            this.errorML = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inBtn2)).BeginInit();
            this.inBtn2.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGETDSLOPBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGETDSLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorML)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSV.Properties.Resources.At_the_office_pana;
            this.pictureBox1.Location = new System.Drawing.Point(65, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(771, 802);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // inBtn2
            // 
            this.inBtn2.Controls.Add(this.tabNavigationPage1);
            this.inBtn2.Controls.Add(this.tabNavigationPage2);
            this.inBtn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inBtn2.Location = new System.Drawing.Point(909, 94);
            this.inBtn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inBtn2.Name = "inBtn2";
            this.inBtn2.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.inBtn2.RegularSize = new System.Drawing.Size(714, 359);
            this.inBtn2.SelectedPage = this.tabNavigationPage2;
            this.inBtn2.Size = new System.Drawing.Size(714, 359);
            this.inBtn2.TabIndex = 39;
            this.inBtn2.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Nhập Mã";
            this.tabNavigationPage1.Controls.Add(this.txMaLop);
            this.tabNavigationPage1.Controls.Add(this.label4);
            this.tabNavigationPage1.Controls.Add(this.simpleButton3);
            this.tabNavigationPage1.Controls.Add(this.inBtnNhap);
            this.tabNavigationPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.PageVisible = false;
            this.tabNavigationPage1.Size = new System.Drawing.Size(714, 312);
            // 
            // txMaLop
            // 
            this.txMaLop.EditValue = "";
            this.txMaLop.Location = new System.Drawing.Point(290, 122);
            this.txMaLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txMaLop.Name = "txMaLop";
            this.txMaLop.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMaLop.Properties.Appearance.Options.UseFont = true;
            this.txMaLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txMaLop.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MALOP", "MALOP", 48, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.txMaLop.Properties.DataSource = this.lOPBindingSource;
            this.txMaLop.Properties.DisplayMember = "MALOP";
            this.txMaLop.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txMaLop.Properties.ValueMember = "MALOP";
            this.txMaLop.Size = new System.Drawing.Size(330, 30);
            this.txMaLop.TabIndex = 44;
            this.txMaLop.EditValueChanged += new System.EventHandler(this.txMaLop_EditValueChanged);
            this.txMaLop.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txMaLop_EditValueChanging);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.Locale = new System.Globalization.CultureInfo("en-US");
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 28);
            this.label4.TabIndex = 43;
            this.label4.Text = "Mã Lớp";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(411, 254);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(210, 60);
            this.simpleButton3.TabIndex = 42;
            this.simpleButton3.Text = "Thoát";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // inBtnNhap
            // 
            this.inBtnNhap.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.inBtnNhap.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.inBtnNhap.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inBtnNhap.Appearance.Options.UseBackColor = true;
            this.inBtnNhap.Appearance.Options.UseBorderColor = true;
            this.inBtnNhap.Appearance.Options.UseFont = true;
            this.inBtnNhap.Enabled = false;
            this.inBtnNhap.Location = new System.Drawing.Point(168, 254);
            this.inBtnNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inBtnNhap.Name = "inBtnNhap";
            this.inBtnNhap.Size = new System.Drawing.Size(210, 60);
            this.inBtnNhap.TabIndex = 41;
            this.inBtnNhap.Text = "In Báo Cáo";
            this.inBtnNhap.Click += new System.EventHandler(this.inBtnNhap_Click);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Chọn Từ Danh Sách";
            this.tabNavigationPage2.Controls.Add(this.simpleButton2);
            this.tabNavigationPage2.Controls.Add(this.cbKhoa);
            this.tabNavigationPage2.Controls.Add(this.inBtn);
            this.tabNavigationPage2.Controls.Add(this.label1);
            this.tabNavigationPage2.Controls.Add(this.label2);
            this.tabNavigationPage2.Controls.Add(this.cbLop);
            this.tabNavigationPage2.Controls.Add(this.maLop);
            this.tabNavigationPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(714, 312);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(411, 254);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(210, 60);
            this.simpleButton2.TabIndex = 37;
            this.simpleButton2.Text = "Thoát";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // cbKhoa
            // 
            this.cbKhoa.DataSource = this.kHOABindingSource;
            this.cbKhoa.DisplayMember = "TENKH";
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(168, 49);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(452, 36);
            this.cbKhoa.TabIndex = 32;
            this.cbKhoa.ValueMember = "MAKH";
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.qLDSVDataSet;
            // 
            // inBtn
            // 
            this.inBtn.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.inBtn.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.inBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inBtn.Appearance.Options.UseBackColor = true;
            this.inBtn.Appearance.Options.UseBorderColor = true;
            this.inBtn.Appearance.Options.UseFont = true;
            this.inBtn.Location = new System.Drawing.Point(168, 254);
            this.inBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inBtn.Name = "inBtn";
            this.inBtn.Size = new System.Drawing.Size(210, 60);
            this.inBtn.TabIndex = 36;
            this.inBtn.Text = "In Báo Cáo";
            this.inBtn.Click += new System.EventHandler(this.inBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 28);
            this.label1.TabIndex = 30;
            this.label1.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tên Lớp";
            // 
            // cbLop
            // 
            this.cbLop.DataSource = this.vGETDSLOPBindingSource1;
            this.cbLop.DisplayMember = "TENLOP";
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(168, 126);
            this.cbLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(287, 36);
            this.cbLop.TabIndex = 33;
            this.cbLop.ValueMember = "MALOP";
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // vGETDSLOPBindingSource1
            // 
            this.vGETDSLOPBindingSource1.DataMember = "V_GETDSLOP";
            this.vGETDSLOPBindingSource1.DataSource = this.qLDSVDataSet;
            // 
            // maLop
            // 
            this.maLop.Enabled = false;
            this.maLop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maLop.Location = new System.Drawing.Point(481, 126);
            this.maLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maLop.Name = "maLop";
            this.maLop.ReadOnly = true;
            this.maLop.Size = new System.Drawing.Size(139, 34);
            this.maLop.TabIndex = 34;
            // 
            // vGETDSLOPBindingSource
            // 
            this.vGETDSLOPBindingSource.DataMember = "V_GETDSLOP";
            this.vGETDSLOPBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // vDSPMBindingSource
            // 
            this.vDSPMBindingSource.DataMember = "V_DSPM";
            this.vDSPMBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // v_GETDSLOPTableAdapter
            // 
            this.v_GETDSLOPTableAdapter.ClearBeforeFill = true;
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // sP_REPORT_DSSVTableAdapter
            // 
            this.sP_REPORT_DSSVTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // errorML
            // 
            this.errorML.ContainerControl = this;
            // 
            // ReportBDTongKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1801, 869);
            this.ControlBox = false;
            this.Controls.Add(this.inBtn2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportBDTongKet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Điểm Tổng Kết";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportBDTongKet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inBtn2)).EndInit();
            this.inBtn2.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGETDSLOPBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGETDSLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorML)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraBars.Navigation.TabPane inBtn2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton inBtnNhap;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.ComboBox cbKhoa;
        private DevExpress.XtraEditors.SimpleButton inBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.TextBox maLop;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource vGETDSLOPBindingSource;
        private QLDSVDataSetTableAdapters.V_GETDSLOPTableAdapter v_GETDSLOPTableAdapter;
        private System.Windows.Forms.BindingSource vDSPMBindingSource;
        private QLDSVDataSetTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private System.Windows.Forms.BindingSource vGETDSLOPBindingSource1;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private QLDSVDataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
        private QLDSVDataSetTableAdapters.SP_REPORT_DSSVTableAdapter sP_REPORT_DSSVTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit txMaLop;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private QLDSVDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.ErrorProvider errorML;
    }
}