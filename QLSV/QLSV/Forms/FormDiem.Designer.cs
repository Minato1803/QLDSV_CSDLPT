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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.qLDSVDataSet = new QLSV.QLDSVDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tuyChinh = new System.Windows.Forms.Panel();
            this.groupEdit = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.diem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maSinhien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.dIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIEMTableAdapter = new QLSV.QLDSVDataSetTableAdapters.DIEMTableAdapter();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLSV.QLDSVDataSetTableAdapters.LOPTableAdapter();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new QLSV.QLDSVDataSetTableAdapters.MONHOCTableAdapter();
            this.vDSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSPMTableAdapter = new QLSV.QLDSVDataSetTableAdapters.V_DSPMTableAdapter();
            this.tool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tuyChinh.SuspendLayout();
            this.groupEdit.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).BeginInit();
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
            this.tool.Size = new System.Drawing.Size(1769, 30);
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
            // 
            // adjustBtn
            // 
            this.adjustBtn.Image = global::QLSV.Properties.Resources.pencil;
            this.adjustBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.adjustBtn.Name = "adjustBtn";
            this.adjustBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.adjustBtn.Size = new System.Drawing.Size(69, 27);
            this.adjustBtn.Text = "Sửa";
            // 
            // undoBtn
            // 
            this.undoBtn.Image = global::QLSV.Properties.Resources.curved_arrow;
            this.undoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.undoBtn.Size = new System.Drawing.Size(110, 27);
            this.undoBtn.Text = "Phục Hồi";
            // 
            // saveBtn
            // 
            this.saveBtn.Image = global::QLSV.Properties.Resources.cloud_computing;
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.saveBtn.Size = new System.Drawing.Size(67, 27);
            this.saveBtn.Text = "Ghi";
            // 
            // exitBtn
            // 
            this.exitBtn.Image = global::QLSV.Properties.Resources.stop;
            this.exitBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(71, 27);
            this.exitBtn.Text = "Hủy";
            // 
            // reloadBtn
            // 
            this.reloadBtn.Image = global::QLSV.Properties.Resources.refresh;
            this.reloadBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.reloadBtn.Size = new System.Drawing.Size(107, 27);
            this.reloadBtn.Text = "Làm Mới";
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
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dIEMBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(0, 140);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1268, 922);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.Locale = new System.Globalization.CultureInfo("en-US");
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHoTen,
            this.colDIEM});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 87;
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "HỌ VÀ TÊN";
            this.colHoTen.MinWidth = 25;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            this.colHoTen.Width = 87;
            // 
            // colDIEM
            // 
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.MinWidth = 25;
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 2;
            this.colDIEM.Width = 87;
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
            this.tuyChinh.Location = new System.Drawing.Point(1287, 30);
            this.tuyChinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tuyChinh.Name = "tuyChinh";
            this.tuyChinh.Size = new System.Drawing.Size(482, 1032);
            this.tuyChinh.TabIndex = 5;
            // 
            // groupEdit
            // 
            this.groupEdit.Controls.Add(this.label8);
            this.groupEdit.Controls.Add(this.diem);
            this.groupEdit.Controls.Add(this.label2);
            this.groupEdit.Controls.Add(this.maSinhien);
            this.groupEdit.Controls.Add(this.label3);
            this.groupEdit.Controls.Add(this.hoTen);
            this.groupEdit.Enabled = false;
            this.groupEdit.Location = new System.Drawing.Point(0, 47);
            this.groupEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupEdit.Name = "groupEdit";
            this.groupEdit.Size = new System.Drawing.Size(475, 407);
            this.groupEdit.TabIndex = 5;
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
            // maSinhien
            // 
            this.maSinhien.Enabled = false;
            this.maSinhien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maSinhien.Location = new System.Drawing.Point(23, 165);
            this.maSinhien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maSinhien.Name = "maSinhien";
            this.maSinhien.Size = new System.Drawing.Size(434, 34);
            this.maSinhien.TabIndex = 4;
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
            this.panel1.Size = new System.Drawing.Size(1287, 55);
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
            this.cbKhoa.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(492, 5);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(460, 41);
            this.cbKhoa.TabIndex = 0;
            this.cbKhoa.ValueMember = "TENSERVER";
            // 
            // panel2
            // 
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
            this.panel2.Size = new System.Drawing.Size(1287, 55);
            this.panel2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(745, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Lần Thi:";
            // 
            // cbLan
            // 
            this.cbLan.DataSource = this.dIEMBindingSource;
            this.cbLan.DisplayMember = "LAN";
            this.cbLan.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLan.FormattingEnabled = true;
            this.cbLan.Location = new System.Drawing.Point(855, 4);
            this.cbLan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLan.Name = "cbLan";
            this.cbLan.Size = new System.Drawing.Size(186, 41);
            this.cbLan.TabIndex = 4;
            this.cbLan.ValueMember = "LAN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(359, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Môn Học:";
            // 
            // cbMon
            // 
            this.cbMon.DataSource = this.mONHOCBindingSource;
            this.cbMon.DisplayMember = "TENMH";
            this.cbMon.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(492, 4);
            this.cbMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(186, 41);
            this.cbMon.TabIndex = 2;
            this.cbMon.ValueMember = "MAMH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lớp: ";
            // 
            // cbLop
            // 
            this.cbLop.DataSource = this.lOPBindingSource;
            this.cbLop.DisplayMember = "TENLOP";
            this.cbLop.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(128, 5);
            this.cbLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(186, 41);
            this.cbLop.TabIndex = 0;
            this.cbLop.ValueMember = "MALOP";
            // 
            // dIEMBindingSource
            // 
            this.dIEMBindingSource.DataMember = "DIEM";
            this.dIEMBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // dIEMTableAdapter
            // 
            this.dIEMTableAdapter.ClearBeforeFill = true;
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
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // vDSPMBindingSource
            // 
            this.vDSPMBindingSource.DataMember = "V_DSPM";
            this.vDSPMBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
            // 
            // FormDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1769, 1062);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tuyChinh.ResumeLayout(false);
            this.tuyChinh.PerformLayout();
            this.groupEdit.ResumeLayout(false);
            this.groupEdit.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tool;
        private System.Windows.Forms.ToolStripButton deleteBtn;
        private System.Windows.Forms.ToolStripButton adjustBtn;
        private System.Windows.Forms.ToolStripButton undoBtn;
        private System.Windows.Forms.ToolStripButton saveBtn;
        private System.Windows.Forms.ToolStripButton exitBtn;
        private System.Windows.Forms.ToolStripButton reloadBtn;
        private System.Windows.Forms.ToolStripButton quitFormBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel tuyChinh;
        private System.Windows.Forms.Panel groupEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maSinhien;
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
        private QLDSVDataSet qLDSVDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private System.Windows.Forms.BindingSource dIEMBindingSource;
        private QLDSVDataSetTableAdapters.DIEMTableAdapter dIEMTableAdapter;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLDSVDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource vDSPMBindingSource;
        private QLDSVDataSetTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
    }
}