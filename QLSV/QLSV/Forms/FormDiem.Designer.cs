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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tuyChinh = new System.Windows.Forms.Panel();
            this.groupEdit = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tenMon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maMon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLan = new System.Windows.Forms.ComboBox();
            this.tool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tuyChinh.SuspendLayout();
            this.groupEdit.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.tool.Size = new System.Drawing.Size(1491, 27);
            this.tool.TabIndex = 2;
            this.tool.Text = "toolStrip1";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(0, 117);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1075, 737);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
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
            this.tuyChinh.Size = new System.Drawing.Size(413, 827);
            this.tuyChinh.TabIndex = 5;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbKhoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 45);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Khoa: ";
            // 
            // cbKhoa
            // 
            this.cbKhoa.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(422, 4);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(395, 35);
            this.cbKhoa.TabIndex = 0;
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
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1078, 45);
            this.panel2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lớp: ";
            // 
            // cbLop
            // 
            this.cbLop.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(110, 4);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(160, 35);
            this.cbLop.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(316, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Môn Học:";
            // 
            // cbMon
            // 
            this.cbMon.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(422, 3);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(160, 35);
            this.cbMon.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(646, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Lần Thi:";
            // 
            // cbLan
            // 
            this.cbLan.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLan.FormattingEnabled = true;
            this.cbLan.Location = new System.Drawing.Point(733, 3);
            this.cbLan.Name = "cbLan";
            this.cbLan.Size = new System.Drawing.Size(160, 35);
            this.cbLan.TabIndex = 4;
            // 
            // FormDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 854);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tuyChinh);
            this.Controls.Add(this.tool);
            this.Name = "FormDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điểm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tool.ResumeLayout(false);
            this.tool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tuyChinh.ResumeLayout(false);
            this.tuyChinh.PerformLayout();
            this.groupEdit.ResumeLayout(false);
            this.groupEdit.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TextBox tenMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maMon;
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
    }
}