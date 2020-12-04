namespace QLSV
{
    partial class ReportBDMonHoc
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
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maMon = new System.Windows.Forms.TextBox();
            this.maLop = new System.Windows.Forms.TextBox();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new QLSV.QLDSVDataSet();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.vGETDSLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vDSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.v_DSPMTableAdapter = new QLSV.QLDSVDataSetTableAdapters.V_DSPMTableAdapter();
            this.v_GETDSLOPTableAdapter = new QLSV.QLDSVDataSetTableAdapters.V_GETDSLOPTableAdapter();
            this.kHOATableAdapter = new QLSV.QLDSVDataSetTableAdapters.KHOATableAdapter();
            this.mONHOCTableAdapter = new QLSV.QLDSVDataSetTableAdapters.MONHOCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGETDSLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(549, 460);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(210, 60);
            this.simpleButton2.TabIndex = 29;
            this.simpleButton2.Text = "Thoát";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(307, 460);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(210, 60);
            this.simpleButton1.TabIndex = 28;
            this.simpleButton1.Text = "In Báo Cáo";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSV.Properties.Resources.Data_report_bro;
            this.pictureBox1.Location = new System.Drawing.Point(955, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // maMon
            // 
            this.maMon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maMon.Location = new System.Drawing.Point(619, 289);
            this.maMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maMon.Name = "maMon";
            this.maMon.ReadOnly = true;
            this.maMon.Size = new System.Drawing.Size(139, 32);
            this.maMon.TabIndex = 26;
            // 
            // maLop
            // 
            this.maLop.Enabled = false;
            this.maLop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maLop.Location = new System.Drawing.Point(619, 218);
            this.maLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maLop.Name = "maLop";
            this.maLop.ReadOnly = true;
            this.maLop.Size = new System.Drawing.Size(139, 32);
            this.maLop.TabIndex = 25;
            // 
            // cbMon
            // 
            this.cbMon.DataSource = this.mONHOCBindingSource;
            this.cbMon.DisplayMember = "TENMH";
            this.cbMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(307, 289);
            this.cbMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(287, 32);
            this.cbMon.TabIndex = 23;
            this.cbMon.ValueMember = "MAMH";
            this.cbMon.SelectedIndexChanged += new System.EventHandler(this.cbMon_SelectedIndexChanged);
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.Locale = new System.Globalization.CultureInfo("en-US");
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbLop
            // 
            this.cbLop.DataSource = this.vGETDSLOPBindingSource;
            this.cbLop.DisplayMember = "TENLOP";
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(307, 218);
            this.cbLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(287, 32);
            this.cbLop.TabIndex = 22;
            this.cbLop.ValueMember = "MALOP";
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // vGETDSLOPBindingSource
            // 
            this.vGETDSLOPBindingSource.DataMember = "V_GETDSLOP";
            this.vGETDSLOPBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DataSource = this.kHOABindingSource;
            this.cbKhoa.DisplayMember = "TENKH";
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(307, 142);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(452, 32);
            this.cbKhoa.TabIndex = 21;
            this.cbKhoa.ValueMember = "MAKH";
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.qLDSVDataSet;
            // 
            // vDSPMBindingSource
            // 
            this.vDSPMBindingSource.DataMember = "V_DSPM";
            this.vDSPMBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Lần Thi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên Môn Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Khoa";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(307, 370);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 34);
            this.numericUpDown1.TabIndex = 30;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
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
            // ReportBDMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1771, 839);
            this.ControlBox = false;
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maMon);
            this.Controls.Add(this.maLop);
            this.Controls.Add(this.cbMon);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportBDMonHoc";
            this.Text = "Bảng Điểm Môn Học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportBDMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGETDSLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox maMon;
        private System.Windows.Forms.TextBox maLop;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource vDSPMBindingSource;
        private QLDSVDataSetTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private System.Windows.Forms.BindingSource vGETDSLOPBindingSource;
        private QLDSVDataSetTableAdapters.V_GETDSLOPTableAdapter v_GETDSLOPTableAdapter;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private QLDSVDataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLDSVDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
    }
}