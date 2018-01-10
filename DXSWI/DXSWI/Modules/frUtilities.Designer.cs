namespace DXSWI.Modules
{
    partial class frUtilities
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.FileNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sbImport = new DevExpress.XtraEditors.SimpleButton();
            this.FileTypeComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.InfoMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.sbBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ImportFromFile = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciFileName = new DevExpress.XtraLayout.LayoutControlItem();
            this.FileType = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileTypeComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportFromFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFileName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.FileNameTextEdit);
            this.layoutControl1.Controls.Add(this.sbImport);
            this.layoutControl1.Controls.Add(this.FileTypeComboBoxEdit);
            this.layoutControl1.Controls.Add(this.InfoMemoEdit);
            this.layoutControl1.Controls.Add(this.sbBrowse);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1155, 629);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // FileNameTextEdit
            // 
            this.FileNameTextEdit.Location = new System.Drawing.Point(79, 42);
            this.FileNameTextEdit.Name = "FileNameTextEdit";
            this.FileNameTextEdit.Size = new System.Drawing.Size(673, 20);
            this.FileNameTextEdit.StyleController = this.layoutControl1;
            this.FileNameTextEdit.TabIndex = 4;
            // 
            // sbImport
            // 
            this.sbImport.Location = new System.Drawing.Point(977, 42);
            this.sbImport.Name = "sbImport";
            this.sbImport.Size = new System.Drawing.Size(154, 22);
            this.sbImport.StyleController = this.layoutControl1;
            this.sbImport.TabIndex = 5;
            this.sbImport.Text = "Start Import";
            this.sbImport.Click += new System.EventHandler(this.sbImport_Click);
            // 
            // FileTypeComboBoxEdit
            // 
            this.FileTypeComboBoxEdit.EditValue = "Candidate";
            this.FileTypeComboBoxEdit.Location = new System.Drawing.Point(878, 42);
            this.FileTypeComboBoxEdit.Name = "FileTypeComboBoxEdit";
            this.FileTypeComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FileTypeComboBoxEdit.Properties.Items.AddRange(new object[] {
            "Candidate",
            "Company",
            "Contact"});
            this.FileTypeComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.FileTypeComboBoxEdit.Size = new System.Drawing.Size(95, 20);
            this.FileTypeComboBoxEdit.StyleController = this.layoutControl1;
            this.FileTypeComboBoxEdit.TabIndex = 6;
            // 
            // InfoMemoEdit
            // 
            this.InfoMemoEdit.Location = new System.Drawing.Point(24, 84);
            this.InfoMemoEdit.Name = "InfoMemoEdit";
            this.InfoMemoEdit.Properties.ReadOnly = true;
            this.InfoMemoEdit.Size = new System.Drawing.Size(1107, 521);
            this.InfoMemoEdit.StyleController = this.layoutControl1;
            this.InfoMemoEdit.TabIndex = 7;
            // 
            // sbBrowse
            // 
            this.sbBrowse.Location = new System.Drawing.Point(756, 42);
            this.sbBrowse.Name = "sbBrowse";
            this.sbBrowse.Size = new System.Drawing.Size(63, 22);
            this.sbBrowse.StyleController = this.layoutControl1;
            this.sbBrowse.TabIndex = 8;
            this.sbBrowse.Text = "...";
            this.sbBrowse.Click += new System.EventHandler(this.sbBrowse_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ImportFromFile});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1155, 629);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // ImportFromFile
            // 
            this.ImportFromFile.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciFileName,
            this.FileType,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.ImportFromFile.Location = new System.Drawing.Point(0, 0);
            this.ImportFromFile.Name = "ImportFromFile";
            this.ImportFromFile.Size = new System.Drawing.Size(1135, 609);
            this.ImportFromFile.Text = "Import From File";
            // 
            // lciFileName
            // 
            this.lciFileName.Control = this.FileNameTextEdit;
            this.lciFileName.Location = new System.Drawing.Point(0, 0);
            this.lciFileName.Name = "lciFileName";
            this.lciFileName.Size = new System.Drawing.Size(732, 26);
            this.lciFileName.Text = "File Name";
            this.lciFileName.TextSize = new System.Drawing.Size(52, 13);
            // 
            // FileType
            // 
            this.FileType.Control = this.FileTypeComboBoxEdit;
            this.FileType.Location = new System.Drawing.Point(799, 0);
            this.FileType.Name = "FileType";
            this.FileType.Size = new System.Drawing.Size(154, 26);
            this.FileType.Text = "File Type";
            this.FileType.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbImport;
            this.layoutControlItem2.Location = new System.Drawing.Point(953, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(158, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.InfoMemoEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1111, 541);
            this.layoutControlItem1.Text = "Infomation";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbBrowse;
            this.layoutControlItem3.Location = new System.Drawing.Point(732, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(67, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // frUtilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "frUtilities";
            this.Size = new System.Drawing.Size(1155, 629);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FileNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileTypeComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportFromFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFileName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit FileNameTextEdit;
        private DevExpress.XtraEditors.SimpleButton sbImport;
        private DevExpress.XtraEditors.ComboBoxEdit FileTypeComboBoxEdit;
        private DevExpress.XtraEditors.MemoEdit InfoMemoEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup ImportFromFile;
        private DevExpress.XtraLayout.LayoutControlItem lciFileName;
        private DevExpress.XtraLayout.LayoutControlItem FileType;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton sbBrowse;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
