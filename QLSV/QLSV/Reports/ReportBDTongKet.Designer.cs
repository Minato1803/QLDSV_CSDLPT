namespace QLSV
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inBtn2 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txMaLop = new System.Windows.Forms.TextBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.inBtnNhap = new DevExpress.XtraEditors.SimpleButton();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.inBtn = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.maLop = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inBtn2)).BeginInit();
            this.inBtn2.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSV.Properties.Resources.At_the_office_pana;
            this.pictureBox1.Location = new System.Drawing.Point(56, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(661, 652);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // inBtn2
            // 
            this.inBtn2.Controls.Add(this.tabNavigationPage1);
            this.inBtn2.Controls.Add(this.tabNavigationPage2);
            this.inBtn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inBtn2.Location = new System.Drawing.Point(779, 76);
            this.inBtn2.Name = "inBtn2";
            this.inBtn2.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.inBtn2.RegularSize = new System.Drawing.Size(612, 292);
            this.inBtn2.SelectedPage = this.tabNavigationPage1;
            this.inBtn2.Size = new System.Drawing.Size(612, 292);
            this.inBtn2.TabIndex = 39;
            this.inBtn2.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Nhập Mã";
            this.tabNavigationPage1.Controls.Add(this.label4);
            this.tabNavigationPage1.Controls.Add(this.txMaLop);
            this.tabNavigationPage1.Controls.Add(this.simpleButton3);
            this.tabNavigationPage1.Controls.Add(this.inBtnNhap);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(612, 255);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 43;
            this.label4.Text = "Mã Lớp";
            // 
            // txMaLop
            // 
            this.txMaLop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMaLop.Location = new System.Drawing.Point(249, 97);
            this.txMaLop.Name = "txMaLop";
            this.txMaLop.Size = new System.Drawing.Size(283, 29);
            this.txMaLop.TabIndex = 40;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(352, 206);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(180, 49);
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
            this.inBtnNhap.Location = new System.Drawing.Point(144, 206);
            this.inBtnNhap.Name = "inBtnNhap";
            this.inBtnNhap.Size = new System.Drawing.Size(180, 49);
            this.inBtnNhap.TabIndex = 41;
            this.inBtnNhap.Text = "In Báo Cáo";
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
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(612, 255);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(352, 206);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(180, 49);
            this.simpleButton2.TabIndex = 37;
            this.simpleButton2.Text = "Thoát";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // cbKhoa
            // 
            this.cbKhoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(144, 40);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(388, 29);
            this.cbKhoa.TabIndex = 32;
            // 
            // inBtn
            // 
            this.inBtn.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.inBtn.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.inBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inBtn.Appearance.Options.UseBackColor = true;
            this.inBtn.Appearance.Options.UseBorderColor = true;
            this.inBtn.Appearance.Options.UseFont = true;
            this.inBtn.Location = new System.Drawing.Point(144, 206);
            this.inBtn.Name = "inBtn";
            this.inBtn.Size = new System.Drawing.Size(180, 49);
            this.inBtn.TabIndex = 36;
            this.inBtn.Text = "In Báo Cáo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tên Lớp";
            // 
            // cbLop
            // 
            this.cbLop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(144, 102);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(247, 29);
            this.cbLop.TabIndex = 33;
            // 
            // maLop
            // 
            this.maLop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maLop.Location = new System.Drawing.Point(412, 102);
            this.maLop.Name = "maLop";
            this.maLop.Size = new System.Drawing.Size(120, 29);
            this.maLop.TabIndex = 34;
            // 
            // ReportBDTongKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 656);
            this.ControlBox = false;
            this.Controls.Add(this.inBtn2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ReportBDTongKet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Điểm Tổng Kết";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inBtn2)).EndInit();
            this.inBtn2.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraBars.Navigation.TabPane inBtn2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txMaLop;
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
    }
}