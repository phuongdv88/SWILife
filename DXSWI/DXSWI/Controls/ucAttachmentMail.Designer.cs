namespace DXSWI.Controls
{
    partial class ucAttachmentMail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lcAttachment = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgAttachment = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.lcAttachment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAttachment)).BeginInit();
            this.SuspendLayout();
            // 
            // lcAttachment
            // 
            this.lcAttachment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcAttachment.Location = new System.Drawing.Point(0, 0);
            this.lcAttachment.Name = "lcAttachment";
            this.lcAttachment.Root = this.layoutControlGroup1;
            this.lcAttachment.Size = new System.Drawing.Size(933, 100);
            this.lcAttachment.TabIndex = 0;
            this.lcAttachment.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgAttachment});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(933, 100);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcgAttachment
            // 
            this.lcgAttachment.DefaultLayoutType = DevExpress.XtraLayout.Utils.LayoutType.Horizontal;
            this.lcgAttachment.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Flow;
            this.lcgAttachment.Location = new System.Drawing.Point(0, 0);
            this.lcgAttachment.Name = "lcgAttachment";
            this.lcgAttachment.Size = new System.Drawing.Size(913, 80);
            this.lcgAttachment.Text = "Attachments";
            // 
            // ucAttachmentMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcAttachment);
            this.Name = "ucAttachmentMail";
            this.Size = new System.Drawing.Size(933, 100);
            ((System.ComponentModel.ISupportInitialize)(this.lcAttachment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAttachment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        public DevExpress.XtraLayout.LayoutControlGroup lcgAttachment;
        public DevExpress.XtraLayout.LayoutControl lcAttachment;
    }
}
