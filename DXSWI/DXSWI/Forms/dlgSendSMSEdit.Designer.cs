namespace DXSWI.Forms
{
    partial class dlgSendSMSEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgSendSMSEdit));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tePhoneNumbers = new DevExpress.XtraEditors.TextEdit();
            this.cbeTemplates = new DevExpress.XtraEditors.ComboBoxEdit();
            this.meMessage = new DevExpress.XtraEditors.MemoEdit();
            this.sbSend = new DevExpress.XtraEditors.SimpleButton();
            this.sbSaveTemplate = new DevExpress.XtraEditors.SimpleButton();
            this.sbHelp = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciContent = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tePhoneNumbers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeTemplates.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meMessage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tePhoneNumbers);
            this.layoutControl1.Controls.Add(this.cbeTemplates);
            this.layoutControl1.Controls.Add(this.meMessage);
            this.layoutControl1.Controls.Add(this.sbSend);
            this.layoutControl1.Controls.Add(this.sbSaveTemplate);
            this.layoutControl1.Controls.Add(this.sbHelp);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(580, 407);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tePhoneNumbers
            // 
            this.tePhoneNumbers.Location = new System.Drawing.Point(89, 38);
            this.tePhoneNumbers.Name = "tePhoneNumbers";
            this.tePhoneNumbers.Size = new System.Drawing.Size(479, 20);
            this.tePhoneNumbers.StyleController = this.layoutControl1;
            this.tePhoneNumbers.TabIndex = 4;
            // 
            // cbeTemplates
            // 
            this.cbeTemplates.EditValue = "None";
            this.cbeTemplates.Location = new System.Drawing.Point(89, 12);
            this.cbeTemplates.Name = "cbeTemplates";
            this.cbeTemplates.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeTemplates.Properties.Items.AddRange(new object[] {
            "None"});
            this.cbeTemplates.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeTemplates.Size = new System.Drawing.Size(440, 20);
            this.cbeTemplates.StyleController = this.layoutControl1;
            this.cbeTemplates.TabIndex = 6;
            this.cbeTemplates.EditValueChanged += new System.EventHandler(this.cbeTemplates_EditValueChanged);
            // 
            // meMessage
            // 
            this.meMessage.Location = new System.Drawing.Point(12, 78);
            this.meMessage.Name = "meMessage";
            this.meMessage.Properties.MaxLength = 160;
            this.meMessage.Size = new System.Drawing.Size(556, 291);
            this.meMessage.StyleController = this.layoutControl1;
            this.meMessage.TabIndex = 8;
            this.meMessage.EditValueChanged += new System.EventHandler(this.meMessage_EditValueChanged);
            // 
            // sbSend
            // 
            this.sbSend.Location = new System.Drawing.Point(292, 373);
            this.sbSend.Name = "sbSend";
            this.sbSend.Size = new System.Drawing.Size(276, 22);
            this.sbSend.StyleController = this.layoutControl1;
            this.sbSend.TabIndex = 9;
            this.sbSend.Text = "Send";
            this.sbSend.Click += new System.EventHandler(this.sbSend_Click);
            // 
            // sbSaveTemplate
            // 
            this.sbSaveTemplate.Location = new System.Drawing.Point(12, 373);
            this.sbSaveTemplate.Name = "sbSaveTemplate";
            this.sbSaveTemplate.Size = new System.Drawing.Size(276, 22);
            this.sbSaveTemplate.StyleController = this.layoutControl1;
            this.sbSaveTemplate.TabIndex = 10;
            this.sbSaveTemplate.Text = "Save Template";
            this.sbSaveTemplate.Click += new System.EventHandler(this.sbSaveTemplate_Click);
            // 
            // sbHelp
            // 
            this.sbHelp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbHelp.ImageOptions.Image")));
            this.sbHelp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sbHelp.Location = new System.Drawing.Point(533, 12);
            this.sbHelp.Name = "sbHelp";
            this.sbHelp.Size = new System.Drawing.Size(35, 22);
            this.sbHelp.StyleController = this.layoutControl1;
            this.sbHelp.TabIndex = 11;
            this.sbHelp.Click += new System.EventHandler(this.sbHelp_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.lciContent,
            this.layoutControlItem6,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(580, 407);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbeTemplates;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(521, 26);
            this.layoutControlItem3.Text = "Template:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(74, 13);
            // 
            // lciContent
            // 
            this.lciContent.Control = this.meMessage;
            this.lciContent.Location = new System.Drawing.Point(0, 50);
            this.lciContent.Name = "lciContent";
            this.lciContent.Size = new System.Drawing.Size(560, 311);
            this.lciContent.Text = "Message [160]";
            this.lciContent.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciContent.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.sbSend;
            this.layoutControlItem6.Location = new System.Drawing.Point(280, 361);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(280, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tePhoneNumbers;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(560, 24);
            this.layoutControlItem1.Text = "Phone Number:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbSaveTemplate;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 361);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(280, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sbHelp;
            this.layoutControlItem4.Location = new System.Drawing.Point(521, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(39, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // dlgSendSMSEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 407);
            this.Controls.Add(this.layoutControl1);
            this.KeyPreview = true;
            this.Name = "dlgSendSMSEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send SMS Editor";
            this.Load += new System.EventHandler(this.dlgSendSMSEdit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dlgSendSMSEdit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tePhoneNumbers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeTemplates.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meMessage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit tePhoneNumbers;
        private DevExpress.XtraEditors.ComboBoxEdit cbeTemplates;
        private DevExpress.XtraEditors.MemoEdit meMessage;
        private DevExpress.XtraEditors.SimpleButton sbSend;
        private DevExpress.XtraEditors.SimpleButton sbSaveTemplate;
        private DevExpress.XtraEditors.SimpleButton sbHelp;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem lciContent;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}