namespace DXSWI.Forms
{
    partial class dlgLogin
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::DXSWI.Forms.ssMain), true, true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgLogin));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.checkEditRememberMe = new DevExpress.XtraEditors.CheckEdit();
            this.sbLogin = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.textEditUserName = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditRememberMe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 100;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // checkEditRememberMe
            // 
            this.checkEditRememberMe.EditValue = true;
            this.checkEditRememberMe.Location = new System.Drawing.Point(227, 177);
            this.checkEditRememberMe.Name = "checkEditRememberMe";
            this.checkEditRememberMe.Properties.Caption = "Remember me";
            this.checkEditRememberMe.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.checkEditRememberMe.Size = new System.Drawing.Size(107, 19);
            this.checkEditRememberMe.TabIndex = 2;
            // 
            // sbLogin
            // 
            this.sbLogin.Location = new System.Drawing.Point(388, 175);
            this.sbLogin.Name = "sbLogin";
            this.sbLogin.Size = new System.Drawing.Size(117, 23);
            this.sbLogin.TabIndex = 3;
            this.sbLogin.Text = "Login";
            this.sbLogin.Click += new System.EventHandler(this.sbLogin_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(146, 131);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Password";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(146, 72);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "User Name";
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(227, 128);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.UseSystemPasswordChar = true;
            this.textEditPassword.Size = new System.Drawing.Size(278, 20);
            this.textEditPassword.TabIndex = 1;
            this.textEditPassword.EditValueChanged += new System.EventHandler(this.textEditPassword_EditValueChanged);
            this.textEditPassword.Enter += new System.EventHandler(this.textEditPassword_Enter);
            // 
            // textEditUserName
            // 
            this.textEditUserName.Location = new System.Drawing.Point(227, 69);
            this.textEditUserName.Name = "textEditUserName";
            this.textEditUserName.Size = new System.Drawing.Size(279, 20);
            this.textEditUserName.TabIndex = 0;
            this.textEditUserName.Enter += new System.EventHandler(this.textEditUserName_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.AutoSize = true;
            this.panelControl1.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl1.ContentImage")));
            this.panelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(535, 42);
            this.panelControl1.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 23);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Welcome";
            // 
            // dlgLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 238);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.checkEditRememberMe);
            this.Controls.Add(this.sbLogin);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditPassword);
            this.Controls.Add(this.textEditUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "dlgLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SWILife is Sweet Life";
            this.Load += new System.EventHandler(this.dlgLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dlgLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditRememberMe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.CheckEdit checkEditRememberMe;
        private DevExpress.XtraEditors.SimpleButton sbLogin;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.TextEdit textEditUserName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}