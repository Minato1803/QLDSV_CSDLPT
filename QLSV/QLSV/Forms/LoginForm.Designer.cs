namespace QLSV
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.userName = new System.Windows.Forms.TextBox();
            this.passWord = new System.Windows.Forms.TextBox();
            this.comboBoxKhoa = new System.Windows.Forms.ComboBox();
            this.loginButton = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.epUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.qLDSVDataSet1 = new QLSV.QLDSVDataSet();
            this.vDSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSPMTableAdapter1 = new QLSV.QLDSVDataSetTableAdapters.V_DSPMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.userName.Location = new System.Drawing.Point(486, 96);
            this.userName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(242, 32);
            this.userName.TabIndex = 0;
            this.userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userName.Leave += new System.EventHandler(this.userName_Leave);
            // 
            // passWord
            // 
            this.passWord.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWord.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.passWord.Location = new System.Drawing.Point(486, 177);
            this.passWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passWord.Name = "passWord";
            this.passWord.PasswordChar = '●';
            this.passWord.Size = new System.Drawing.Size(242, 32);
            this.passWord.TabIndex = 1;
            this.passWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passWord.Leave += new System.EventHandler(this.passWord_Leave);
            // 
            // comboBoxKhoa
            // 
            this.comboBoxKhoa.BackColor = System.Drawing.Color.LightCyan;
            this.comboBoxKhoa.DataSource = this.vDSPMBindingSource;
            this.comboBoxKhoa.DisplayMember = "TENKHOA";
            this.comboBoxKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxKhoa.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKhoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comboBoxKhoa.FormattingEnabled = true;
            this.comboBoxKhoa.Location = new System.Drawing.Point(486, 256);
            this.comboBoxKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxKhoa.Name = "comboBoxKhoa";
            this.comboBoxKhoa.Size = new System.Drawing.Size(241, 31);
            this.comboBoxKhoa.TabIndex = 2;
            this.comboBoxKhoa.ValueMember = "TENSERVER";
            this.comboBoxKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // loginButton
            // 
            this.loginButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.loginButton.Appearance.Options.UseFont = true;
            this.loginButton.Appearance.Options.UseForeColor = true;
            this.loginButton.Location = new System.Drawing.Point(486, 373);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(243, 39);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Đăng Nhập";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSV.Properties.Resources.Campus1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(483, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(483, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(483, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Khoa";
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.svgImageBox1.Location = new System.Drawing.Point(700, 181);
            this.svgImageBox1.Margin = new System.Windows.Forms.Padding(6);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(24, 26);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.svgImageBox1.SvgImage = global::QLSV.Properties.Resources.blind;
            this.svgImageBox1.TabIndex = 8;
            this.svgImageBox1.Click += new System.EventHandler(this.svgImageBox1_Click);
            // 
            // epUsername
            // 
            this.epUsername.ContainerControl = this;
            this.epUsername.Icon = ((System.Drawing.Icon)(resources.GetObject("epUsername.Icon")));
            // 
            // epPassword
            // 
            this.epPassword.ContainerControl = this;
            this.epPassword.Icon = ((System.Drawing.Icon)(resources.GetObject("epPassword.Icon")));
            // 
            // qLDSVDataSet1
            // 
            this.qLDSVDataSet1.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vDSPMBindingSource
            // 
            this.vDSPMBindingSource.DataMember = "V_DSPM";
            this.vDSPMBindingSource.DataSource = this.qLDSVDataSet1;
            // 
            // v_DSPMTableAdapter1
            // 
            this.v_DSPMTableAdapter1.ClearBeforeFill = true;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.ActiveGlowColor = System.Drawing.Color.White;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 527);
            this.Controls.Add(this.svgImageBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.comboBoxKhoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.False;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("LoginForm.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.ComboBox comboBoxKhoa;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox passWord;
        private DevExpress.XtraEditors.SimpleButton loginButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private QLDSVDataSet qLDSVDataSet;
        private QLDSVDataSetTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private System.Windows.Forms.ErrorProvider epUsername;
        private System.Windows.Forms.ErrorProvider epPassword;
        private QLDSVDataSet qLDSVDataSet1;
        private System.Windows.Forms.BindingSource vDSPMBindingSource;
        private QLDSVDataSetTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter1;
    }
}