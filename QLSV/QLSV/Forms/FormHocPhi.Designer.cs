namespace QLSV
{
    partial class FormHocPhi
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
            this.addBtn = new System.Windows.Forms.ToolStripButton();
            this.deleteBtn = new System.Windows.Forms.ToolStripButton();
            this.adjustBtn = new System.Windows.Forms.ToolStripButton();
            this.undoBtn = new System.Windows.Forms.ToolStripButton();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.exitBtn = new System.Windows.Forms.ToolStripButton();
            this.reloadBtn = new System.Windows.Forms.ToolStripButton();
            this.quitFormBtn = new System.Windows.Forms.ToolStripButton();
            this.tuyChinh = new System.Windows.Forms.Panel();
            this.groupEdit = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.daDong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hocPhi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hocKi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nienKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.hOCPHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new QLSV.QLDSVDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cTDONGHOCPHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sPREPORTDSDHPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCPHITableAdapter = new QLSV.QLDSVDataSetTableAdapters.HOCPHITableAdapter();
            this.sP_REPORT_DSDHPTableAdapter = new QLSV.QLDSVDataSetTableAdapters.SP_REPORT_DSDHPTableAdapter();
            this.cT_DONGHOCPHITableAdapter = new QLSV.QLDSVDataSetTableAdapters.CT_DONGHOCPHITableAdapter();
            this.tool.SuspendLayout();
            this.tuyChinh.SuspendLayout();
            this.groupEdit.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDONGHOCPHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTDSDHPBindingSource)).BeginInit();
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
            this.quitFormBtn});
            this.tool.Location = new System.Drawing.Point(0, 0);
            this.tool.Name = "tool";
            this.tool.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.tool.Size = new System.Drawing.Size(1557, 27);
            this.tool.TabIndex = 2;
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
            // tuyChinh
            // 
            this.tuyChinh.AccessibleName = "";
            this.tuyChinh.BackColor = System.Drawing.Color.DodgerBlue;
            this.tuyChinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tuyChinh.Controls.Add(this.groupEdit);
            this.tuyChinh.Controls.Add(this.label1);
            this.tuyChinh.Dock = System.Windows.Forms.DockStyle.Right;
            this.tuyChinh.ForeColor = System.Drawing.Color.Gray;
            this.tuyChinh.Location = new System.Drawing.Point(1144, 27);
            this.tuyChinh.Name = "tuyChinh";
            this.tuyChinh.Size = new System.Drawing.Size(413, 841);
            this.tuyChinh.TabIndex = 4;
            // 
            // groupEdit
            // 
            this.groupEdit.Controls.Add(this.label7);
            this.groupEdit.Controls.Add(this.dong);
            this.groupEdit.Controls.Add(this.label6);
            this.groupEdit.Controls.Add(this.daDong);
            this.groupEdit.Controls.Add(this.label5);
            this.groupEdit.Controls.Add(this.hocPhi);
            this.groupEdit.Controls.Add(this.label2);
            this.groupEdit.Controls.Add(this.hocKi);
            this.groupEdit.Controls.Add(this.label3);
            this.groupEdit.Controls.Add(this.nienKhoa);
            this.groupEdit.Enabled = false;
            this.groupEdit.Location = new System.Drawing.Point(0, 38);
            this.groupEdit.Name = "groupEdit";
            this.groupEdit.Size = new System.Drawing.Size(407, 423);
            this.groupEdit.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 344);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(61, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = "Đóng:";
            // 
            // dong
            // 
            this.dong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dong.Location = new System.Drawing.Point(20, 378);
            this.dong.Name = "dong";
            this.dong.Size = new System.Drawing.Size(373, 29);
            this.dong.TabIndex = 10;
            this.dong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 260);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(84, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "Đã Đóng:";
            // 
            // daDong
            // 
            this.daDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daDong.Location = new System.Drawing.Point(20, 294);
            this.daDong.Name = "daDong";
            this.daDong.Size = new System.Drawing.Size(373, 29);
            this.daDong.TabIndex = 8;
            this.daDong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 179);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(76, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Học Phí:";
            // 
            // hocPhi
            // 
            this.hocPhi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hocPhi.Location = new System.Drawing.Point(20, 213);
            this.hocPhi.Name = "hocPhi";
            this.hocPhi.Size = new System.Drawing.Size(373, 29);
            this.hocPhi.TabIndex = 6;
            this.hocPhi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 100);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(67, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Học Kì:";
            // 
            // hocKi
            // 
            this.hocKi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hocKi.Location = new System.Drawing.Point(20, 134);
            this.hocKi.Name = "hocKi";
            this.hocKi.Size = new System.Drawing.Size(373, 29);
            this.hocKi.TabIndex = 4;
            this.hocKi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(95, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Niên Khóa:";
            // 
            // nienKhoa
            // 
            this.nienKhoa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nienKhoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nienKhoa.Location = new System.Drawing.Point(20, 50);
            this.nienKhoa.Name = "nienKhoa";
            this.nienKhoa.Size = new System.Drawing.Size(373, 29);
            this.nienKhoa.TabIndex = 3;
            this.nienKhoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lookUpEdit1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 45);
            this.panel1.TabIndex = 6;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.EditValue = "";
            this.lookUpEdit1.Location = new System.Drawing.Point(422, 3);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MASV", "MASV", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit1.Properties.DataSource = this.hOCPHIBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "MASV";
            this.lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit1.Properties.ValueMember = "MASV";
            this.lookUpEdit1.Size = new System.Drawing.Size(308, 32);
            this.lookUpEdit1.TabIndex = 3;
            // 
            // hOCPHIBindingSource
            // 
            this.hOCPHIBindingSource.DataMember = "HOCPHI";
            this.hOCPHIBindingSource.DataSource = this.qLDSVDataSet;
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
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã Sinh Viên: ";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cTDONGHOCPHIBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(0, 72);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1138, 796);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cTDONGHOCPHIBindingSource
            // 
            this.cTDONGHOCPHIBindingSource.DataMember = "CT_DONGHOCPHI";
            this.cTDONGHOCPHIBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHOTEN,
            this.colHOCPHI,
            this.colSOTIENDONG});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 21;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 0;
            this.colHOTEN.Width = 81;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.MinWidth = 21;
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 1;
            this.colHOCPHI.Width = 81;
            // 
            // colSOTIENDONG
            // 
            this.colSOTIENDONG.FieldName = "SOTIENDONG";
            this.colSOTIENDONG.MinWidth = 21;
            this.colSOTIENDONG.Name = "colSOTIENDONG";
            this.colSOTIENDONG.Visible = true;
            this.colSOTIENDONG.VisibleIndex = 2;
            this.colSOTIENDONG.Width = 81;
            // 
            // sPREPORTDSDHPBindingSource
            // 
            this.sPREPORTDSDHPBindingSource.DataMember = "SP_REPORT_DSDHP";
            this.sPREPORTDSDHPBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // hOCPHITableAdapter
            // 
            this.hOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // sP_REPORT_DSDHPTableAdapter
            // 
            this.sP_REPORT_DSDHPTableAdapter.ClearBeforeFill = true;
            // 
            // cT_DONGHOCPHITableAdapter
            // 
            this.cT_DONGHOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // FormHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 868);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tuyChinh);
            this.Controls.Add(this.tool);
            this.Name = "FormHocPhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Học Phí";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHocPhi_Load);
            this.tool.ResumeLayout(false);
            this.tool.PerformLayout();
            this.tuyChinh.ResumeLayout(false);
            this.tuyChinh.PerformLayout();
            this.groupEdit.ResumeLayout(false);
            this.groupEdit.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDONGHOCPHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTDSDHPBindingSource)).EndInit();
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
        private System.Windows.Forms.Panel tuyChinh;
        private System.Windows.Forms.Panel groupEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hocKi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nienKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox daDong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hocPhi;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource hOCPHIBindingSource;
        private QLDSVDataSetTableAdapters.HOCPHITableAdapter hOCPHITableAdapter;
        private System.Windows.Forms.BindingSource sPREPORTDSDHPBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDONG;
        private QLDSVDataSetTableAdapters.SP_REPORT_DSDHPTableAdapter sP_REPORT_DSDHPTableAdapter;
        private System.Windows.Forms.BindingSource cTDONGHOCPHIBindingSource;
        private QLDSVDataSetTableAdapters.CT_DONGHOCPHITableAdapter cT_DONGHOCPHITableAdapter;
    }
}