namespace QLSV
{
    partial class FormMonHoc
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.tool = new System.Windows.Forms.ToolStrip();
            this.addBtn = new System.Windows.Forms.ToolStripButton();
            this.deleteBtn = new System.Windows.Forms.ToolStripButton();
            this.adjustBtn = new System.Windows.Forms.ToolStripButton();
            this.undoBtn = new System.Windows.Forms.ToolStripButton();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.exitBtn = new System.Windows.Forms.ToolStripButton();
            this.reloadBtn = new System.Windows.Forms.ToolStripButton();
            this.quitFormBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.qLDSVDataSet = new QLSV.QLDSVDataSet();
            this.sPREPORTDSSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_REPORT_DSSVTableAdapter = new QLSV.QLDSVDataSetTableAdapters.SP_REPORT_DSSVTableAdapter();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.qldsvDataSet1 = new QLSV.QLDSVDataSet();
            this.sinhvienTableAdapter1 = new QLSV.QLDSVDataSetTableAdapters.SINHVIENTableAdapter();
            this.qldsvDataSet2 = new QLSV.QLDSVDataSet();
            this.monhocTableAdapter1 = new QLSV.QLDSVDataSetTableAdapters.MONHOCTableAdapter();
            this.qldsvDataSet3 = new QLSV.QLDSVDataSet();
            this.monhocTableAdapter2 = new QLSV.QLDSVDataSetTableAdapters.MONHOCTableAdapter();
            this.tuyChinh = new System.Windows.Forms.Panel();
            this.groupEdit = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tenMon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maMon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.danhSachMon = new DevExpress.XtraGrid.GridControl();
            this.qldsvDataSet4 = new QLSV.QLDSVDataSet();
            this.viewDanhSachMon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.monhocTableAdapter3 = new QLSV.QLDSVDataSetTableAdapters.MONHOCTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.tool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTDSSVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsvDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsvDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsvDataSet3)).BeginInit();
            this.tuyChinh.SuspendLayout();
            this.groupEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsvDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDanhSachMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tool
            // 
            this.tool.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tool.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBtn,
            this.deleteBtn,
            this.adjustBtn,
            this.undoBtn,
            this.saveBtn,
            this.exitBtn,
            this.reloadBtn,
            this.quitFormBtn,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripComboBox1});
            this.tool.Location = new System.Drawing.Point(0, 0);
            this.tool.Name = "tool";
            this.tool.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.tool.Size = new System.Drawing.Size(1491, 27);
            this.tool.TabIndex = 1;
            this.tool.Text = "toolStrip1";
            // 
            // addBtn
            // 
            this.addBtn.Image = global::QLSV.Properties.Resources.add__1_;
            this.addBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addBtn.Name = "addBtn";
            this.addBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.addBtn.Size = new System.Drawing.Size(71, 24);
            this.addBtn.Text = "Thêm";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Image = global::QLSV.Properties.Resources.remove;
            this.deleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.deleteBtn.Size = new System.Drawing.Size(62, 24);
            this.deleteBtn.Text = "Xóa";
            // 
            // adjustBtn
            // 
            this.adjustBtn.Image = global::QLSV.Properties.Resources.pencil;
            this.adjustBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.adjustBtn.Name = "adjustBtn";
            this.adjustBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.adjustBtn.Size = new System.Drawing.Size(61, 24);
            this.adjustBtn.Text = "Sửa";
            this.adjustBtn.Click += new System.EventHandler(this.adjustBtn_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.Image = global::QLSV.Properties.Resources.curved_arrow;
            this.undoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.undoBtn.Size = new System.Drawing.Size(90, 24);
            this.undoBtn.Text = "Phục Hồi";
            // 
            // saveBtn
            // 
            this.saveBtn.Image = global::QLSV.Properties.Resources.cloud_computing;
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.saveBtn.Size = new System.Drawing.Size(58, 24);
            this.saveBtn.Text = "Ghi";
            // 
            // exitBtn
            // 
            this.exitBtn.Image = global::QLSV.Properties.Resources.stop;
            this.exitBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(61, 24);
            this.exitBtn.Text = "Hủy";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.Image = global::QLSV.Properties.Resources.refresh;
            this.reloadBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.reloadBtn.Size = new System.Drawing.Size(90, 24);
            this.reloadBtn.Text = "Làm Mới";
            // 
            // quitFormBtn
            // 
            this.quitFormBtn.Image = global::QLSV.Properties.Resources.power_button;
            this.quitFormBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.quitFormBtn.Name = "quitFormBtn";
            this.quitFormBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.quitFormBtn.Size = new System.Drawing.Size(72, 24);
            this.quitFormBtn.Text = "Thoát";
            this.quitFormBtn.Click += new System.EventHandler(this.quitFormBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 24);
            this.toolStripLabel1.Text = "Khoa:";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 27);
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.Locale = new System.Globalization.CultureInfo("en-US");
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "QLSV.Properties.Settings.QLDSVConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "SP_getPhieuDiem";
            queryParameter1.Name = "@MSSV";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "N17DCCN115";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "SP_getPhieuDiem";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlNQX2dldFBoaWV1RGllbSI+P" +
    "EZpZWxkIE5hbWU9IlRFTk1IIiBUeXBlPSJTdHJpbmciIC8+PEZpZWxkIE5hbWU9IkRJRU0iIFR5cGU9I" +
    "kRvdWJsZSIgLz48L1ZpZXc+PC9EYXRhU2V0Pg==";
            // 
            // qldsvDataSet1
            // 
            this.qldsvDataSet1.DataSetName = "QLDSVDataSet";
            this.qldsvDataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.qldsvDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhvienTableAdapter1
            // 
            this.sinhvienTableAdapter1.ClearBeforeFill = true;
            // 
            // qldsvDataSet2
            // 
            this.qldsvDataSet2.DataSetName = "QLDSVDataSet";
            this.qldsvDataSet2.Locale = new System.Globalization.CultureInfo("en-US");
            this.qldsvDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monhocTableAdapter1
            // 
            this.monhocTableAdapter1.ClearBeforeFill = true;
            // 
            // qldsvDataSet3
            // 
            this.qldsvDataSet3.DataSetName = "QLDSVDataSet";
            this.qldsvDataSet3.Locale = new System.Globalization.CultureInfo("en-US");
            this.qldsvDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monhocTableAdapter2
            // 
            this.monhocTableAdapter2.ClearBeforeFill = true;
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
            this.tuyChinh.Location = new System.Drawing.Point(1078, 27);
            this.tuyChinh.Name = "tuyChinh";
            this.tuyChinh.Size = new System.Drawing.Size(413, 422);
            this.tuyChinh.TabIndex = 3;
            // 
            // groupEdit
            // 
            this.groupEdit.Controls.Add(this.label2);
            this.groupEdit.Controls.Add(this.tenMon);
            this.groupEdit.Controls.Add(this.label3);
            this.groupEdit.Controls.Add(this.maMon);
            this.groupEdit.Enabled = false;
            this.groupEdit.Location = new System.Drawing.Point(0, 38);
            this.groupEdit.Name = "groupEdit";
            this.groupEdit.Size = new System.Drawing.Size(407, 178);
            this.groupEdit.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 100);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Môn Học:";
            // 
            // tenMon
            // 
            this.tenMon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenMon.Location = new System.Drawing.Point(20, 134);
            this.tenMon.Name = "tenMon";
            this.tenMon.Size = new System.Drawing.Size(373, 29);
            this.tenMon.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(112, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Môn Học:";
            // 
            // maMon
            // 
            this.maMon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maMon.Location = new System.Drawing.Point(20, 50);
            this.maMon.Name = "maMon";
            this.maMon.Size = new System.Drawing.Size(373, 29);
            this.maMon.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-5, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(110, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tùy Chỉnh";
            // 
            // danhSachMon
            // 
            this.danhSachMon.DataMember = "MONHOC";
            this.danhSachMon.DataSource = this.qldsvDataSet4;
            this.danhSachMon.Dock = System.Windows.Forms.DockStyle.Left;
            this.danhSachMon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhSachMon.Location = new System.Drawing.Point(0, 27);
            this.danhSachMon.MainView = this.viewDanhSachMon;
            this.danhSachMon.Name = "danhSachMon";
            this.danhSachMon.Size = new System.Drawing.Size(1075, 422);
            this.danhSachMon.TabIndex = 4;
            this.danhSachMon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDanhSachMon});
            // 
            // qldsvDataSet4
            // 
            this.qldsvDataSet4.DataSetName = "QLDSVDataSet";
            this.qldsvDataSet4.Locale = new System.Globalization.CultureInfo("en-US");
            this.qldsvDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewDanhSachMon
            // 
            this.viewDanhSachMon.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDanhSachMon.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.viewDanhSachMon.Appearance.HeaderPanel.Options.UseFont = true;
            this.viewDanhSachMon.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.viewDanhSachMon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
            this.viewDanhSachMon.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.viewDanhSachMon.GridControl = this.danhSachMon;
            this.viewDanhSachMon.Name = "viewDanhSachMon";
            this.viewDanhSachMon.OptionsBehavior.Editable = false;
            this.viewDanhSachMon.OptionsBehavior.ReadOnly = true;
            this.viewDanhSachMon.OptionsCustomization.AllowSort = false;
            this.viewDanhSachMon.OptionsMenu.EnableColumnMenu = false;
            this.viewDanhSachMon.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.True;
            this.viewDanhSachMon.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.viewDanhSachMon.OptionsView.RowAutoHeight = true;
            this.viewDanhSachMon.OptionsView.ShowGroupPanel = false;
            this.viewDanhSachMon.RowHeight = 30;
            this.viewDanhSachMon.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.viewDanhSachMon_FocusedRowChanged);
            // 
            // colMAMH
            // 
            this.colMAMH.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAMH.AppearanceCell.Options.UseFont = true;
            this.colMAMH.Caption = "Mã Môn Học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsFilter.AllowFilter = false;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENMH.AppearanceCell.Options.UseFont = true;
            this.colTENMH.Caption = "Tên Môn Học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsFilter.AllowFilter = false;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // monhocTableAdapter3
            // 
            this.monhocTableAdapter3.ClearBeforeFill = true;
            // 
            // FormMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 449);
            this.ControlBox = false;
            this.Controls.Add(this.danhSachMon);
            this.Controls.Add(this.tuyChinh);
            this.Controls.Add(this.tool);
            this.Name = "FormMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Môn Học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tool.ResumeLayout(false);
            this.tool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTDSSVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsvDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsvDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsvDataSet3)).EndInit();
            this.tuyChinh.ResumeLayout(false);
            this.tuyChinh.PerformLayout();
            this.groupEdit.ResumeLayout(false);
            this.groupEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsvDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDanhSachMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tool;
        private System.Windows.Forms.ToolStripButton addBtn;
        private System.Windows.Forms.ToolStripButton deleteBtn;
        private System.Windows.Forms.ToolStripButton adjustBtn;
        private System.Windows.Forms.ToolStripButton undoBtn;
        private System.Windows.Forms.ToolStripButton saveBtn;
        private System.Windows.Forms.ToolStripButton exitBtn;
        private System.Windows.Forms.ToolStripButton reloadBtn;
        private System.Windows.Forms.ToolStripButton quitFormBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.BindingSource sPREPORTDSSVBindingSource;
        private QLDSVDataSet qLDSVDataSet;
        private QLDSVDataSetTableAdapters.SP_REPORT_DSSVTableAdapter sP_REPORT_DSSVTableAdapter;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private QLDSVDataSet qldsvDataSet1;
        private QLDSVDataSetTableAdapters.SINHVIENTableAdapter sinhvienTableAdapter1;
        private QLDSVDataSet qldsvDataSet2;
        private QLDSVDataSetTableAdapters.MONHOCTableAdapter monhocTableAdapter1;
        private QLDSVDataSet qldsvDataSet3;
        private QLDSVDataSetTableAdapters.MONHOCTableAdapter monhocTableAdapter2;
        private System.Windows.Forms.Panel tuyChinh;
        private DevExpress.XtraGrid.GridControl danhSachMon;
        private QLDSVDataSet qldsvDataSet4;
        private DevExpress.XtraGrid.Views.Grid.GridView viewDanhSachMon;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private QLDSVDataSetTableAdapters.MONHOCTableAdapter monhocTableAdapter3;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tenMon;
        private System.Windows.Forms.TextBox maMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel groupEdit;
    }
}