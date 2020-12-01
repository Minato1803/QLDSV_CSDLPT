namespace QLSV
{
    partial class ReportDSSinhVien
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
            this.inBtn = new DevExpress.XtraEditors.SimpleButton();
            this.maLop = new System.Windows.Forms.TextBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.vGETDSLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new QLSV.QLDSVDataSet();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.vDSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.v_DSPMTableAdapter = new QLSV.QLDSVDataSetTableAdapters.V_DSPMTableAdapter();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLSV.QLDSVDataSetTableAdapters.LOPTableAdapter();
            this.v_GETDSLOPTableAdapter = new QLSV.QLDSVDataSetTableAdapters.V_GETDSLOPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vGETDSLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(520, 357);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(210, 60);
            this.simpleButton2.TabIndex = 29;
            this.simpleButton2.Text = "Thoát";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // inBtn
            // 
            this.inBtn.Appearance.BackColor = System.Drawing.Color.MediumOrchid;
            this.inBtn.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.inBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inBtn.Appearance.Options.UseBackColor = true;
            this.inBtn.Appearance.Options.UseBorderColor = true;
            this.inBtn.Appearance.Options.UseFont = true;
            this.inBtn.Location = new System.Drawing.Point(278, 357);
            this.inBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inBtn.Name = "inBtn";
            this.inBtn.Size = new System.Drawing.Size(210, 60);
            this.inBtn.TabIndex = 28;
            this.inBtn.Text = "In Báo Cáo";
            this.inBtn.Click += new System.EventHandler(this.inBtn_Click);
            // 
            // maLop
            // 
            this.maLop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maLop.Location = new System.Drawing.Point(590, 255);
            this.maLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maLop.Name = "maLop";
            this.maLop.ReadOnly = true;
            this.maLop.Size = new System.Drawing.Size(139, 34);
            this.maLop.TabIndex = 25;
            // 
            // cbLop
            // 
            this.cbLop.DataSource = this.vGETDSLOPBindingSource;
            this.cbLop.DisplayMember = "TENLOP";
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(278, 255);
            this.cbLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(287, 36);
            this.cbLop.TabIndex = 22;
            this.cbLop.ValueMember = "MALOP";
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // vGETDSLOPBindingSource
            // 
            this.vGETDSLOPBindingSource.DataMember = "V_GETDSLOP";
            this.vGETDSLOPBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DataSource = this.vDSPMBindingSource;
            this.cbKhoa.DisplayMember = "TENKHOA";
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(278, 178);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(452, 36);
            this.cbKhoa.TabIndex = 21;
            this.cbKhoa.ValueMember = "TENSERVER";
            // 
            // vDSPMBindingSource
            // 
            this.vDSPMBindingSource.DataMember = "V_DSPM";
            this.vDSPMBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Khoa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSV.Properties.Resources.Business_Plan_amico;
            this.pictureBox1.Location = new System.Drawing.Point(947, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // v_GETDSLOPTableAdapter
            // 
            this.v_GETDSLOPTableAdapter.ClearBeforeFill = true;
            // 
            // ReportDSSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1739, 807);
            this.ControlBox = false;
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.inBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maLop);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportDSSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Sinh Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportDSSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vGETDSLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton inBtn;
        private System.Windows.Forms.TextBox maLop;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource vDSPMBindingSource;
        private QLDSVDataSetTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource vGETDSLOPBindingSource;
        private QLDSVDataSetTableAdapters.V_GETDSLOPTableAdapter v_GETDSLOPTableAdapter;
    }
}