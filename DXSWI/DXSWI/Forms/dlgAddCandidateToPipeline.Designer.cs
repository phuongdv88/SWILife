namespace DXSWI.Forms
{
    partial class dlgAddCandidateToPipeline
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleIconSet formatConditionRuleIconSet1 = new DevExpress.XtraEditors.FormatConditionRuleIconSet();
            DevExpress.XtraEditors.FormatConditionIconSet formatConditionIconSet1 = new DevExpress.XtraEditors.FormatConditionIconSet();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon1 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon2 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon3 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.sbOK = new DevExpress.XtraEditors.SimpleButton();
            this.gcCandidates = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvCandidates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKeySkill = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentEmployer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesiredPay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCellPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInterviewNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModified = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbiCreateNewCandidate = new DevExpress.XtraBars.BarButtonItem();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCandidates)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // colState
            // 
            this.colState.Caption = "State";
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 121;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.sbCancel);
            this.flowLayoutPanel1.Controls.Add(this.sbOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 631);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(993, 30);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // sbCancel
            // 
            this.sbCancel.Location = new System.Drawing.Point(900, 3);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(90, 23);
            this.sbCancel.TabIndex = 0;
            this.sbCancel.Text = "Exit";
            this.sbCancel.Click += new System.EventHandler(this.sbCancel_Click);
            // 
            // sbOK
            // 
            this.sbOK.Location = new System.Drawing.Point(797, 3);
            this.sbOK.Name = "sbOK";
            this.sbOK.Size = new System.Drawing.Size(97, 23);
            this.sbOK.TabIndex = 1;
            this.sbOK.Text = "Add";
            this.sbOK.Click += new System.EventHandler(this.sbOK_Click);
            // 
            // gcCandidates
            // 
            this.gcCandidates.ContextMenuStrip = this.contextMenuStrip1;
            this.gcCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCandidates.Location = new System.Drawing.Point(0, 40);
            this.gcCandidates.MainView = this.gvCandidates;
            this.gcCandidates.Name = "gcCandidates";
            this.gcCandidates.Size = new System.Drawing.Size(993, 591);
            this.gcCandidates.TabIndex = 2;
            this.gcCandidates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCandidates});
            this.gcCandidates.DoubleClick += new System.EventHandler(this.gcCandidates_DoubleClick);
            this.gcCandidates.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcCandidates_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyEmailToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 26);
            // 
            // copyEmailToolStripMenuItem
            // 
            this.copyEmailToolStripMenuItem.Image = global::DXSWI.Properties.Resources.Copyicon;
            this.copyEmailToolStripMenuItem.Name = "copyEmailToolStripMenuItem";
            this.copyEmailToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.copyEmailToolStripMenuItem.Text = "Copy Email";
            this.copyEmailToolStripMenuItem.Click += new System.EventHandler(this.copyEmailToolStripMenuItem_Click);
            // 
            // gvCandidates
            // 
            this.gvCandidates.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colKeySkill,
            this.colCurrentPosition,
            this.colCurrentEmployer,
            this.colDesiredPay,
            this.colCellPhone,
            this.colEmail,
            this.colYear,
            this.colInterviewNotes,
            this.colCity,
            this.colModified,
            this.colState});
            gridFormatRule1.Column = this.colState;
            gridFormatRule1.ColumnApplyTo = this.colName;
            gridFormatRule1.Name = "FormatValidate";
            formatConditionIconSet1.CategoryName = "Symbols";
            formatConditionIconSetIcon1.PredefinedName = "Signs3_1.png";
            formatConditionIconSetIcon1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            formatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon2.PredefinedName = "RedToBlack4_3.png";
            formatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon3.PredefinedName = "RedToBlack4_1.png";
            formatConditionIconSetIcon3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            formatConditionIconSetIcon3.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon1);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon2);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon3);
            formatConditionIconSet1.Name = "Symbols3Circled";
            formatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleIconSet1.IconSet = formatConditionIconSet1;
            gridFormatRule1.Rule = formatConditionRuleIconSet1;
            this.gvCandidates.FormatRules.Add(gridFormatRule1);
            this.gvCandidates.GridControl = this.gcCandidates;
            this.gvCandidates.Name = "gvCandidates";
            this.gvCandidates.OptionsBehavior.Editable = false;
            this.gvCandidates.OptionsFind.AlwaysVisible = true;
            this.gvCandidates.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.FindClick;
            this.gvCandidates.OptionsSelection.MultiSelect = true;
            this.gvCandidates.ColumnFilterChanged += new System.EventHandler(this.gvCandidates_ColumnFilterChanged);
            // 
            // colKeySkill
            // 
            this.colKeySkill.Caption = "Key skills";
            this.colKeySkill.FieldName = "KeySkills";
            this.colKeySkill.Name = "colKeySkill";
            this.colKeySkill.Visible = true;
            this.colKeySkill.VisibleIndex = 3;
            this.colKeySkill.Width = 112;
            // 
            // colCurrentPosition
            // 
            this.colCurrentPosition.Caption = "Current Position";
            this.colCurrentPosition.FieldName = "CurrentPosition";
            this.colCurrentPosition.Name = "colCurrentPosition";
            this.colCurrentPosition.Visible = true;
            this.colCurrentPosition.VisibleIndex = 2;
            this.colCurrentPosition.Width = 98;
            // 
            // colCurrentEmployer
            // 
            this.colCurrentEmployer.Caption = "Current Employer";
            this.colCurrentEmployer.FieldName = "CurrentEmployer";
            this.colCurrentEmployer.Name = "colCurrentEmployer";
            this.colCurrentEmployer.Visible = true;
            this.colCurrentEmployer.VisibleIndex = 1;
            this.colCurrentEmployer.Width = 98;
            // 
            // colDesiredPay
            // 
            this.colDesiredPay.Caption = "Desired Pay";
            this.colDesiredPay.FieldName = "DesiredPay";
            this.colDesiredPay.Name = "colDesiredPay";
            this.colDesiredPay.Visible = true;
            this.colDesiredPay.VisibleIndex = 4;
            this.colDesiredPay.Width = 66;
            // 
            // colCellPhone
            // 
            this.colCellPhone.Caption = "CellPhone";
            this.colCellPhone.FieldName = "CellPhone";
            this.colCellPhone.Name = "colCellPhone";
            this.colCellPhone.Visible = true;
            this.colCellPhone.VisibleIndex = 5;
            this.colCellPhone.Width = 67;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 6;
            this.colEmail.Width = 69;
            // 
            // colYear
            // 
            this.colYear.Caption = "Year";
            this.colYear.FieldName = "Years";
            this.colYear.Name = "colYear";
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 7;
            this.colYear.Width = 42;
            // 
            // colInterviewNotes
            // 
            this.colInterviewNotes.Caption = "Interview Notes";
            this.colInterviewNotes.FieldName = "InterviewNotes";
            this.colInterviewNotes.Name = "colInterviewNotes";
            this.colInterviewNotes.Visible = true;
            this.colInterviewNotes.VisibleIndex = 8;
            this.colInterviewNotes.Width = 144;
            // 
            // colCity
            // 
            this.colCity.Caption = "City";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 9;
            this.colCity.Width = 56;
            // 
            // colModified
            // 
            this.colModified.Caption = "Modified";
            this.colModified.FieldName = "Modified";
            this.colModified.Name = "colModified";
            this.colModified.Visible = true;
            this.colModified.VisibleIndex = 10;
            this.colModified.Width = 102;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiCreateNewCandidate});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(993, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 661);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(993, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 621);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(993, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 621);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiCreateNewCandidate)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bbiCreateNewCandidate
            // 
            this.bbiCreateNewCandidate.Caption = "Create New Candidate";
            this.bbiCreateNewCandidate.Id = 1;
            this.bbiCreateNewCandidate.ImageOptions.Image = global::DXSWI.Properties.Resources.Actionsusergroupnew;
            this.bbiCreateNewCandidate.Name = "bbiCreateNewCandidate";
            this.bbiCreateNewCandidate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCreateNewCandidate_ItemClick);
            // 
            // dlgAddCandidateToPipeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 661);
            this.Controls.Add(this.gcCandidates);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Name = "dlgAddCandidateToPipeline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Candidate To Pipeline";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dlgAddCandidateToPipeline_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCandidates)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraEditors.SimpleButton sbOK;
        private DevExpress.XtraGrid.GridControl gcCandidates;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCandidates;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colKeySkill;
        private DevExpress.XtraGrid.Columns.GridColumn colDesiredPay;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colInterviewNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentEmployer;
        private DevExpress.XtraGrid.Columns.GridColumn colCellPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colModified;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyEmailToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiCreateNewCandidate;
    }
}