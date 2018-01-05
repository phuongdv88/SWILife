namespace DXSWI.Forms
{
    partial class dlgImportFromClipboard
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.meInfo = new DevExpress.XtraEditors.MemoEdit();
            this.lciClipboardInfo = new DevExpress.XtraLayout.LayoutControlItem();
            this.sbImport = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClipboardInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.meInfo);
            this.layoutControl1.Controls.Add(this.sbImport);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1103, 580);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciClipboardInfo,
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1103, 580);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // meInfo
            // 
            this.meInfo.Location = new System.Drawing.Point(12, 28);
            this.meInfo.Name = "meInfo";
            this.meInfo.Size = new System.Drawing.Size(1079, 514);
            this.meInfo.StyleController = this.layoutControl1;
            this.meInfo.TabIndex = 4;
            // 
            // lciClipboardInfo
            // 
            this.lciClipboardInfo.Control = this.meInfo;
            this.lciClipboardInfo.Location = new System.Drawing.Point(0, 0);
            this.lciClipboardInfo.Name = "lciClipboardInfo";
            this.lciClipboardInfo.Size = new System.Drawing.Size(1083, 534);
            this.lciClipboardInfo.Text = "Clipboard Info";
            this.lciClipboardInfo.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciClipboardInfo.TextSize = new System.Drawing.Size(68, 13);
            // 
            // sbImport
            // 
            this.sbImport.Location = new System.Drawing.Point(885, 546);
            this.sbImport.Name = "sbImport";
            this.sbImport.Size = new System.Drawing.Size(206, 22);
            this.sbImport.StyleController = this.layoutControl1;
            this.sbImport.TabIndex = 5;
            this.sbImport.Text = "Import";
            this.sbImport.Click += new System.EventHandler(this.sbImport_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbImport;
            this.layoutControlItem2.Location = new System.Drawing.Point(873, 534);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(210, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 534);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(873, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // dlgImportFromClipboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 580);
            this.Controls.Add(this.layoutControl1);
            this.KeyPreview = true;
            this.Name = "dlgImportFromClipboard";
            this.Text = "Import From Clipboard";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dlgImportFromClipboard_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClipboardInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.MemoEdit meInfo;
        private DevExpress.XtraEditors.SimpleButton sbImport;
        private DevExpress.XtraLayout.LayoutControlItem lciClipboardInfo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}