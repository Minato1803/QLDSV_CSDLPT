namespace QLSV
{
    partial class ReportBangDiemThi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new QLSV.QLDSVDataSet();
            this.vDSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.vGETDSLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lanThi = new System.Windows.Forms.NumericUpDown();
            this.maLop = new System.Windows.Forms.TextBox();
            this.maMon = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cNgayThi = new System.Windows.Forms.DateTimePicker();
            this.v_DSPMTableAdapter = new QLSV.QLDSVDataSetTableAdapters.V_DSPMTableAdapter();
            this.sPREPORTDSSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_REPORT_DSSVTableAdapter = new QLSV.QLDSVDataSetTableAdapters.SP_REPORT_DSSVTableAdapter();
            this.v_GETDSLOPTableAdapter = new QLSV.QLDSVDataSetTableAdapters.V_GETDSLOPTableAdapter();
            this.kHOATableAdapter = new QLSV.QLDSVDataSetTableAdapters.KHOATableAdapter();
            this.mONHOCTableAdapter = new QLSV.QLDSVDataSetTableAdapters.MONHOCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGETDSLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lanThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTDSSVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(927, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(901, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(859, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Môn Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1318, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lần";
            // 
            // cbKhoa
            // 
            this.cbKhoa.DataSource = this.kHOABindingSource;
            this.cbKhoa.DisplayMember = "TENKH";
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(1010, 132);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(452, 32);
            this.cbKhoa.TabIndex = 8;
            this.cbKhoa.ValueMember = "MAKH";
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.qLDSVDataSet;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.Locale = new System.Globalization.CultureInfo("en-US");
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vDSPMBindingSource
            // 
            this.vDSPMBindingSource.DataMember = "V_DSPM";
            this.vDSPMBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // cbLop
            // 
            this.cbLop.DataSource = this.vGETDSLOPBindingSource;
            this.cbLop.DisplayMember = "TENLOP";
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(1010, 208);
            this.cbLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(287, 32);
            this.cbLop.TabIndex = 9;
            this.cbLop.ValueMember = "MALOP";
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // vGETDSLOPBindingSource
            // 
            this.vGETDSLOPBindingSource.DataMember = "V_GETDSLOP";
            this.vGETDSLOPBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // cbMon
            // 
            this.cbMon.DataSource = this.mONHOCBindingSource;
            this.cbMon.DisplayMember = "TENMH";
            this.cbMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(1010, 279);
            this.cbMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(287, 32);
            this.cbMon.TabIndex = 10;
            this.cbMon.ValueMember = "MAMH";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // lanThi
            // 
            this.lanThi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lanThi.Location = new System.Drawing.Point(1370, 357);
            this.lanThi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lanThi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lanThi.Name = "lanThi";
            this.lanThi.Size = new System.Drawing.Size(93, 32);
            this.lanThi.TabIndex = 11;
            this.lanThi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maLop
            // 
            this.maLop.Enabled = false;
            this.maLop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maLop.Location = new System.Drawing.Point(1323, 208);
            this.maLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maLop.Name = "maLop";
            this.maLop.ReadOnly = true;
            this.maLop.Size = new System.Drawing.Size(139, 32);
            this.maLop.TabIndex = 12;
            // 
            // maMon
            // 
            this.maMon.Enabled = false;
            this.maMon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maMon.Location = new System.Drawing.Point(1323, 279);
            this.maMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maMon.Name = "maMon";
            this.maMon.ReadOnly = true;
            this.maMon.Size = new System.Drawing.Size(139, 32);
            this.maMon.TabIndex = 13;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Tomato;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(1010, 450);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(210, 60);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "In Báo Cáo";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(1253, 450);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(210, 60);
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "Thoát";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSV.Properties.Resources.Visual_data_pana;
            this.pictureBox1.Location = new System.Drawing.Point(143, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(891, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ngày Thi";
            // 
            // cNgayThi
            // 
            this.cNgayThi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNgayThi.Location = new System.Drawing.Point(1010, 357);
            this.cNgayThi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cNgayThi.Name = "cNgayThi";
            this.cNgayThi.Size = new System.Drawing.Size(287, 34);
            this.cNgayThi.TabIndex = 18;
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
            // 
            // sPREPORTDSSVBindingSource
            // 
            this.sPREPORTDSSVBindingSource.DataMember = "SP_REPORT_DSSV";
            this.sPREPORTDSSVBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // sP_REPORT_DSSVTableAdapter
            // 
            this.sP_REPORT_DSSVTableAdapter.ClearBeforeFill = true;
            // 
            // v_GETDSLOPTableAdapter
            // 
            this.v_GETDSLOPTableAdapter.ClearBeforeFill = true;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // ReportBangDiemThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1755, 823);
            this.ControlBox = false;
            this.Controls.Add(this.cNgayThi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maMon);
            this.Controls.Add(this.maLop);
            this.Controls.Add(this.lanThi);
            this.Controls.Add(this.cbMon);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportBangDiemThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bảng Điểm Thi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportBangDiemThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGETDSLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lanThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTDSSVBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.NumericUpDown lanThi;
        private System.Windows.Forms.TextBox maLop;
        private System.Windows.Forms.TextBox maMon;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker cNgayThi;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource vDSPMBindingSource;
        private QLDSVDataSetTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private System.Windows.Forms.BindingSource sPREPORTDSSVBindingSource;
        private QLDSVDataSetTableAdapters.SP_REPORT_DSSVTableAdapter sP_REPORT_DSSVTableAdapter;
        private System.Windows.Forms.BindingSource vGETDSLOPBindingSource;
        private QLDSVDataSetTableAdapters.V_GETDSLOPTableAdapter v_GETDSLOPTableAdapter;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private QLDSVDataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLDSVDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
    }
}