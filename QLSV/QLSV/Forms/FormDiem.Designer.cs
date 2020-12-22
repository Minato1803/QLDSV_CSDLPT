namespace QLSV
{
    partial class FormDiem
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
            this.tool = new System.Windows.Forms.ToolStrip();
            this.deleteBtn = new System.Windows.Forms.ToolStripButton();
            this.adjustBtn = new System.Windows.Forms.ToolStripButton();
            this.undoBtn = new System.Windows.Forms.ToolStripButton();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.exitBtn = new System.Windows.Forms.ToolStripButton();
            this.reloadBtn = new System.Windows.Forms.ToolStripButton();
            this.quitFormBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.danhSachDiem = new DevExpress.XtraGrid.GridControl();
            this.viewDSDiem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new QLSV.QLDSVDataSet();
            this.tuyChinh = new System.Windows.Forms.Panel();
            this.groupEdit = new System.Windows.Forms.Panel();
            this.btnTiep = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.diem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.vDSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.startBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSPMTableAdapter = new QLSV.QLDSVDataSetTableAdapters.V_DSPMTableAdapter();
            this.dIEMTableAdapter = new QLSV.QLDSVDataSetTableAdapters.DIEMTableAdapter();
            this.mONHOCTableAdapter = new QLSV.QLDSVDataSetTableAdapters.MONHOCTableAdapter();
            this.lOPTableAdapter = new QLSV.QLDSVDataSetTableAdapters.LOPTableAdapter();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDSDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            this.tuyChinh.SuspendLayout();
            this.groupEdit.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tool
            // 
            this.tool.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tool.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteBtn,
            this.adjustBtn,
            this.undoBtn,
            this.saveBtn,
            this.exitBtn,
            this.reloadBtn,
            this.quitFormBtn,
            this.toolStripSeparator1});
            this.tool.Location = new System.Drawing.Point(0, 0);
            this.tool.Name = "tool";
            this.tool.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.tool.Size = new System.Drawing.Size(1881, 30);
            this.tool.TabIndex = 2;
            this.tool.Text = "toolStrip1";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Image = global::QLSV.Properties.Resources.remove;
            this.deleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.deleteBtn.Size = new System.Drawing.Size(70, 27);
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.Visible = false;
            // 
            // adjustBtn
            // 
            this.adjustBtn.Image = global::QLSV.Properties.Resources.pencil;
            this.adjustBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.adjustBtn.Name = "adjustBtn";
            this.adjustBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.adjustBtn.Size = new System.Drawing.Size(69, 27);
            this.adjustBtn.Text = "Sửa";
            this.adjustBtn.Visible = false;
            // 
            // undoBtn
            // 
            this.undoBtn.Image = global::QLSV.Properties.Resources.curved_arrow;
            this.undoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.undoBtn.Size = new System.Drawing.Size(110, 27);
            this.undoBtn.Text = "Phục Hồi";
            this.undoBtn.Visible = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Image = global::QLSV.Properties.Resources.cloud_computing;
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.saveBtn.Size = new System.Drawing.Size(67, 27);
            this.saveBtn.Text = "Ghi";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Image = global::QLSV.Properties.Resources.stop;
            this.exitBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(71, 27);
            this.exitBtn.Text = "Hủy";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.Image = global::QLSV.Properties.Resources.refresh;
            this.reloadBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.reloadBtn.Size = new System.Drawing.Size(107, 27);
            this.reloadBtn.Text = "Làm Mới";
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // quitFormBtn
            // 
            this.quitFormBtn.Image = global::QLSV.Properties.Resources.power_button;
            this.quitFormBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.quitFormBtn.Name = "quitFormBtn";
            this.quitFormBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.quitFormBtn.Size = new System.Drawing.Size(85, 27);
            this.quitFormBtn.Text = "Thoát";
            this.quitFormBtn.Click += new System.EventHandler(this.quitFormBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // danhSachDiem
            // 
            this.danhSachDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.danhSachDiem.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.danhSachDiem.Location = new System.Drawing.Point(0, 140);
            this.danhSachDiem.MainView = this.viewDSDiem;
            this.danhSachDiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.danhSachDiem.Name = "danhSachDiem";
            this.danhSachDiem.Size = new System.Drawing.Size(1399, 922);
            this.danhSachDiem.TabIndex = 4;
            this.danhSachDiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDSDiem});
            // 
            // viewDSDiem
            // 
            this.viewDSDiem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHOTEN,
            this.colDIEM});
            this.viewDSDiem.DetailHeight = 431;
            this.viewDSDiem.GridControl = this.danhSachDiem;
            this.viewDSDiem.Name = "viewDSDiem";
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowEdit = false;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 87;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 25;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.OptionsColumn.AllowEdit = false;
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            this.colHOTEN.Width = 94;
            // 
            // colDIEM
            // 
            this.colDIEM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDIEM.MinWidth = 25;
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.OptionsColumn.AllowEdit = false;
            this.colDIEM.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 2;
            this.colDIEM.Width = 87;
            // 
            // dIEMBindingSource
            // 
            this.dIEMBindingSource.DataMember = "DIEM";
            this.dIEMBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.Locale = new System.Globalization.CultureInfo("en-US");
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tuyChinh
            // 
            this.tuyChinh.AccessibleName = "";
            this.tuyChinh.BackColor = System.Drawing.Color.DodgerBlue;
            this.tuyChinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tuyChinh.Controls.Add(this.groupEdit);
            this.tuyChinh.Controls.Add(this.label1);
            this.tuyChinh.Dock = System.Windows.Forms.DockStyle.Right;
            this.tuyChinh.ForeColor = System.Drawing.Color.Gray;
            this.tuyChinh.Location = new System.Drawing.Point(1399, 30);
            this.tuyChinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tuyChinh.Name = "tuyChinh";
            this.tuyChinh.Size = new System.Drawing.Size(482, 1032);
            this.tuyChinh.TabIndex = 5;
            // 
            // groupEdit
            // 
            this.groupEdit.Controls.Add(this.btnTiep);
            this.groupEdit.Controls.Add(this.label8);
            this.groupEdit.Controls.Add(this.diem);
            this.groupEdit.Controls.Add(this.label2);
            this.groupEdit.Controls.Add(this.maSV);
            this.groupEdit.Controls.Add(this.label3);
            this.groupEdit.Controls.Add(this.hoTen);
            this.groupEdit.Enabled = false;
            this.groupEdit.Location = new System.Drawing.Point(0, 47);
            this.groupEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupEdit.Name = "groupEdit";
            this.groupEdit.Size = new System.Drawing.Size(475, 407);
            this.groupEdit.TabIndex = 5;
            // 
            // btnTiep
            // 
            this.btnTiep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiep.Location = new System.Drawing.Point(336, 337);
            this.btnTiep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(122, 34);
            this.btnTiep.TabIndex = 7;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 226);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(6);
            this.label8.Size = new System.Drawing.Size(74, 40);
            this.label8.TabIndex = 5;
            this.label8.Text = "Điểm:";
            // 
            // diem
            // 
            this.diem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diem.Location = new System.Drawing.Point(23, 268);
            this.diem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.diem.Name = "diem";
            this.diem.Size = new System.Drawing.Size(434, 34);
            this.diem.TabIndex = 6;
            this.diem.Validating += new System.ComponentModel.CancelEventHandler(this.diem_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 123);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(6);
            this.label2.Size = new System.Drawing.Size(170, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Số Sinh Viên:";
            // 
            // maSV
            // 
            this.maSV.Enabled = false;
            this.maSV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maSV.Location = new System.Drawing.Point(23, 165);
            this.maSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maSV.Name = "maSV";
            this.maSV.Size = new System.Drawing.Size(434, 34);
            this.maSV.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(6);
            this.label3.Size = new System.Drawing.Size(88, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên:";
            // 
            // hoTen
            // 
            this.hoTen.Enabled = false;
            this.hoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTen.Location = new System.Drawing.Point(23, 62);
            this.hoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hoTen.Name = "hoTen";
            this.hoTen.Size = new System.Drawing.Size(434, 34);
            this.hoTen.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-6, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6);
            this.label1.Size = new System.Drawing.Size(139, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tùy Chỉnh";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbKhoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1399, 55);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Khoa: ";
            // 
            // cbKhoa
            // 
            this.cbKhoa.DataSource = this.vDSPMBindingSource;
            this.cbKhoa.DisplayMember = "TENKHOA";
            this.cbKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(492, 5);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(460, 31);
            this.cbKhoa.TabIndex = 0;
            this.cbKhoa.ValueMember = "TENSERVER";
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // vDSPMBindingSource
            // 
            this.vDSPMBindingSource.DataMember = "V_DSPM";
            this.vDSPMBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.startBtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbLan);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbMon);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbLop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1399, 55);
            this.panel2.TabIndex = 7;
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(1050, 0);
            this.startBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(139, 43);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Bắt Đầu";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(691, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Lần Thi:";
            // 
            // cbLan
            // 
            this.cbLan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLan.FormattingEnabled = true;
            this.cbLan.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbLan.Location = new System.Drawing.Point(800, 0);
            this.cbLan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLan.Name = "cbLan";
            this.cbLan.Size = new System.Drawing.Size(186, 31);
            this.cbLan.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Môn Học:";
            // 
            // cbMon
            // 
            this.cbMon.DataSource = this.mONHOCBindingSource;
            this.cbMon.DisplayMember = "TENMH";
            this.cbMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(437, 0);
            this.cbMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(186, 31);
            this.cbMon.TabIndex = 2;
            this.cbMon.ValueMember = "MAMH";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lớp: ";
            // 
            // cbLop
            // 
            this.cbLop.DataSource = this.lOPBindingSource;
            this.cbLop.DisplayMember = "MALOP";
            this.cbLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(73, 1);
            this.cbLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(186, 31);
            this.cbLop.TabIndex = 0;
            this.cbLop.ValueMember = "MALOP";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
            // 
            // dIEMTableAdapter
            // 
            this.dIEMTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1881, 1062);
            this.ControlBox = false;
            this.Controls.Add(this.danhSachDiem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tuyChinh);
            this.Controls.Add(this.tool);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điểm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDiem_Load);
            this.tool.ResumeLayout(false);
            this.tool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDSDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            this.tuyChinh.ResumeLayout(false);
            this.tuyChinh.PerformLayout();
            this.groupEdit.ResumeLayout(false);
            this.groupEdit.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tool;
        private System.Windows.Forms.ToolStripButton adjustBtn;
        private System.Windows.Forms.ToolStripButton undoBtn;
        private System.Windows.Forms.ToolStripButton saveBtn;
        private System.Windows.Forms.ToolStripButton exitBtn;
        private System.Windows.Forms.ToolStripButton reloadBtn;
        private System.Windows.Forms.ToolStripButton quitFormBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraGrid.GridControl danhSachDiem;
        private DevExpress.XtraGrid.Views.Grid.GridView viewDSDiem;
        private System.Windows.Forms.Panel tuyChinh;
        private System.Windows.Forms.Panel groupEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbLan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox diem;
        private System.Windows.Forms.ToolStripButton deleteBtn;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button startBtn;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource vDSPMBindingSource;
        private QLDSVDataSetTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private System.Windows.Forms.BindingSource dIEMBindingSource;
        private QLDSVDataSetTableAdapters.DIEMTableAdapter dIEMTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLDSVDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}