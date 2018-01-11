namespace DXSWI.Forms
{
    partial class dlgJobOrderEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgJobOrderEdit));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gcCandidatePipeline = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCandidateToPipelineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addActivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.emailToCandidateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToAllCandidatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteCandidateFromPipelineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvCandidatePipeline = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMatch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRatingControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemRatingControl();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdded = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastActivity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.TitleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.jobOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DepartmentTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SalaryTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.StateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.StartDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.DurationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TypeComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.OpeningsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IsHotCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.isPublicCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.ExperienceYearTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.StatusComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.WebLinkTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DescriptionMemoExEdit = new DevExpress.XtraEditors.MemoEdit();
            this.sbOK = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.sbDownload = new DevExpress.XtraEditors.SimpleButton();
            this.sbDelete = new DevExpress.XtraEditors.SimpleButton();
            this.sbAddAttachment = new DevExpress.XtraEditors.SimpleButton();
            this.meInternalNotes = new DevExpress.XtraEditors.MemoEdit();
            this.companyComboxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.contactComboboxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForIsHot = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCompany = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForContact = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForExperienceYear = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForType = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForisPublic = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForWebLink = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDuration = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForStartDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForOpenings = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDepartment = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSalary = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCity = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForState = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sliAttachment = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.editCandidateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCandidatePipeline)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCandidatePipeline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRatingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpeningsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsHotCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isPublicCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExperienceYearTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebLinkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionMemoExEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meInternalNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyComboxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactComboboxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsHot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExperienceYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForisPublic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWebLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOpenings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliAttachment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gcCandidatePipeline);
            this.dataLayoutControl1.Controls.Add(this.TitleTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DepartmentTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SalaryTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CityTextEdit);
            this.dataLayoutControl1.Controls.Add(this.StateTextEdit);
            this.dataLayoutControl1.Controls.Add(this.StartDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.DurationTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TypeComboBoxEdit);
            this.dataLayoutControl1.Controls.Add(this.OpeningsTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IsHotCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.isPublicCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.ExperienceYearTextEdit);
            this.dataLayoutControl1.Controls.Add(this.StatusComboBoxEdit);
            this.dataLayoutControl1.Controls.Add(this.WebLinkTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DescriptionMemoExEdit);
            this.dataLayoutControl1.Controls.Add(this.sbOK);
            this.dataLayoutControl1.Controls.Add(this.sbCancel);
            this.dataLayoutControl1.Controls.Add(this.sbDownload);
            this.dataLayoutControl1.Controls.Add(this.sbDelete);
            this.dataLayoutControl1.Controls.Add(this.sbAddAttachment);
            this.dataLayoutControl1.Controls.Add(this.meInternalNotes);
            this.dataLayoutControl1.Controls.Add(this.companyComboxEdit);
            this.dataLayoutControl1.Controls.Add(this.contactComboboxEdit);
            this.dataLayoutControl1.DataSource = this.jobOrderBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1333, 917);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gcCandidatePipeline
            // 
            this.gcCandidatePipeline.ContextMenuStrip = this.contextMenuStrip1;
            this.gcCandidatePipeline.Location = new System.Drawing.Point(585, 42);
            this.gcCandidatePipeline.MainView = this.gvCandidatePipeline;
            this.gcCandidatePipeline.Name = "gcCandidatePipeline";
            this.gcCandidatePipeline.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRatingControl1});
            this.gcCandidatePipeline.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gcCandidatePipeline.Size = new System.Drawing.Size(724, 851);
            this.gcCandidatePipeline.TabIndex = 27;
            this.gcCandidatePipeline.ToolTipController = this.toolTipController1;
            this.gcCandidatePipeline.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCandidatePipeline});
            this.gcCandidatePipeline.DoubleClick += new System.EventHandler(this.gcCandidatePipeline_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCandidateToPipelineToolStripMenuItem,
            this.addActivityToolStripMenuItem,
            this.toolStripSeparator2,
            this.editCandidateToolStripMenuItem,
            this.emailToCandidateToolStripMenuItem,
            this.emailToAllCandidatesToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteCandidateFromPipelineToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(251, 170);
            // 
            // addCandidateToPipelineToolStripMenuItem
            // 
            this.addCandidateToPipelineToolStripMenuItem.Name = "addCandidateToPipelineToolStripMenuItem";
            this.addCandidateToPipelineToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.addCandidateToPipelineToolStripMenuItem.Text = "Add Candidate To Pipeline";
            this.addCandidateToPipelineToolStripMenuItem.Click += new System.EventHandler(this.addCandidateToPipelineToolStripMenuItem_Click);
            // 
            // addActivityToolStripMenuItem
            // 
            this.addActivityToolStripMenuItem.Name = "addActivityToolStripMenuItem";
            this.addActivityToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.addActivityToolStripMenuItem.Text = "Add Activity";
            this.addActivityToolStripMenuItem.Click += new System.EventHandler(this.addActivityToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(247, 6);
            // 
            // emailToCandidateToolStripMenuItem
            // 
            this.emailToCandidateToolStripMenuItem.Name = "emailToCandidateToolStripMenuItem";
            this.emailToCandidateToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.emailToCandidateToolStripMenuItem.Text = "Email To Candidate";
            this.emailToCandidateToolStripMenuItem.Click += new System.EventHandler(this.emailToCandidateToolStripMenuItem_Click);
            // 
            // emailToAllCandidatesToolStripMenuItem
            // 
            this.emailToAllCandidatesToolStripMenuItem.Name = "emailToAllCandidatesToolStripMenuItem";
            this.emailToAllCandidatesToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.emailToAllCandidatesToolStripMenuItem.Text = "Email To All Candidates";
            this.emailToAllCandidatesToolStripMenuItem.Click += new System.EventHandler(this.emailToAllCandidatesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(247, 6);
            // 
            // deleteCandidateFromPipelineToolStripMenuItem
            // 
            this.deleteCandidateFromPipelineToolStripMenuItem.Name = "deleteCandidateFromPipelineToolStripMenuItem";
            this.deleteCandidateFromPipelineToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.deleteCandidateFromPipelineToolStripMenuItem.Text = "Remove Candidate From Pipeline";
            this.deleteCandidateFromPipelineToolStripMenuItem.Click += new System.EventHandler(this.deleteCandidateFromPipelineToolStripMenuItem_Click);
            // 
            // gvCandidatePipeline
            // 
            this.gvCandidatePipeline.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMatch,
            this.colFirstName,
            this.colLastName,
            this.colEmail,
            this.colCity,
            this.colAdded,
            this.colStatus,
            this.colLastActivity});
            this.gvCandidatePipeline.GridControl = this.gcCandidatePipeline;
            this.gvCandidatePipeline.Name = "gvCandidatePipeline";
            this.gvCandidatePipeline.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvCandidatePipeline.OptionsSelection.MultiSelect = true;
            // 
            // colMatch
            // 
            this.colMatch.Caption = "Match";
            this.colMatch.ColumnEdit = this.repositoryItemRatingControl1;
            this.colMatch.FieldName = "Match";
            this.colMatch.Name = "colMatch";
            this.colMatch.OptionsColumn.AllowEdit = false;
            this.colMatch.Visible = true;
            this.colMatch.VisibleIndex = 0;
            this.colMatch.Width = 115;
            // 
            // repositoryItemRatingControl1
            // 
            this.repositoryItemRatingControl1.AutoHeight = false;
            this.repositoryItemRatingControl1.Name = "repositoryItemRatingControl1";
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "First Name";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            this.colFirstName.Width = 76;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Last Name";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            this.colLastName.Width = 69;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            this.colEmail.Width = 88;
            // 
            // colCity
            // 
            this.colCity.Caption = "City";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 4;
            this.colCity.Width = 77;
            // 
            // colAdded
            // 
            this.colAdded.Caption = "Added";
            this.colAdded.FieldName = "Added";
            this.colAdded.Name = "colAdded";
            this.colAdded.Visible = true;
            this.colAdded.VisibleIndex = 5;
            this.colAdded.Width = 77;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 6;
            this.colStatus.Width = 83;
            // 
            // colLastActivity
            // 
            this.colLastActivity.Caption = "Last Activity";
            this.colLastActivity.FieldName = "LastActivity";
            this.colLastActivity.Name = "colLastActivity";
            this.colLastActivity.Visible = true;
            this.colLastActivity.VisibleIndex = 7;
            this.colLastActivity.Width = 120;
            // 
            // toolTipController1
            // 
            this.toolTipController1.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.toolTipController1_GetActiveObjectInfo);
            // 
            // TitleTextEdit
            // 
            this.TitleTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "Title", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TitleTextEdit.Location = new System.Drawing.Point(105, 90);
            this.TitleTextEdit.Name = "TitleTextEdit";
            this.TitleTextEdit.Size = new System.Drawing.Size(158, 20);
            this.TitleTextEdit.StyleController = this.dataLayoutControl1;
            this.TitleTextEdit.TabIndex = 4;
            // 
            // jobOrderBindingSource
            // 
            this.jobOrderBindingSource.DataSource = typeof(SWIBLL.Models.JobOrder);
            // 
            // DepartmentTextEdit
            // 
            this.DepartmentTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "Department", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DepartmentTextEdit.Location = new System.Drawing.Point(348, 90);
            this.DepartmentTextEdit.Name = "DepartmentTextEdit";
            this.DepartmentTextEdit.Size = new System.Drawing.Size(209, 20);
            this.DepartmentTextEdit.StyleController = this.dataLayoutControl1;
            this.DepartmentTextEdit.TabIndex = 5;
            // 
            // SalaryTextEdit
            // 
            this.SalaryTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "Salary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SalaryTextEdit.Location = new System.Drawing.Point(105, 138);
            this.SalaryTextEdit.Name = "SalaryTextEdit";
            this.SalaryTextEdit.Size = new System.Drawing.Size(158, 20);
            this.SalaryTextEdit.StyleController = this.dataLayoutControl1;
            this.SalaryTextEdit.TabIndex = 6;
            // 
            // CityTextEdit
            // 
            this.CityTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "City", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CityTextEdit.Location = new System.Drawing.Point(105, 114);
            this.CityTextEdit.Name = "CityTextEdit";
            this.CityTextEdit.Size = new System.Drawing.Size(158, 20);
            this.CityTextEdit.StyleController = this.dataLayoutControl1;
            this.CityTextEdit.TabIndex = 9;
            // 
            // StateTextEdit
            // 
            this.StateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "State", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.StateTextEdit.Location = new System.Drawing.Point(348, 114);
            this.StateTextEdit.Name = "StateTextEdit";
            this.StateTextEdit.Size = new System.Drawing.Size(209, 20);
            this.StateTextEdit.StyleController = this.dataLayoutControl1;
            this.StateTextEdit.TabIndex = 10;
            // 
            // StartDateDateEdit
            // 
            this.StartDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "StartDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.StartDateDateEdit.EditValue = null;
            this.StartDateDateEdit.Location = new System.Drawing.Point(348, 186);
            this.StartDateDateEdit.Name = "StartDateDateEdit";
            this.StartDateDateEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.StartDateDateEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.StartDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StartDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StartDateDateEdit.Size = new System.Drawing.Size(209, 20);
            this.StartDateDateEdit.StyleController = this.dataLayoutControl1;
            this.StartDateDateEdit.TabIndex = 13;
            // 
            // DurationTextEdit
            // 
            this.DurationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "Duration", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DurationTextEdit.Location = new System.Drawing.Point(105, 162);
            this.DurationTextEdit.Name = "DurationTextEdit";
            this.DurationTextEdit.Size = new System.Drawing.Size(158, 20);
            this.DurationTextEdit.StyleController = this.dataLayoutControl1;
            this.DurationTextEdit.TabIndex = 14;
            // 
            // TypeComboBoxEdit
            // 
            this.TypeComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "Type", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TypeComboBoxEdit.EditValue = "Hire";
            this.TypeComboBoxEdit.Location = new System.Drawing.Point(105, 66);
            this.TypeComboBoxEdit.Name = "TypeComboBoxEdit";
            this.TypeComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TypeComboBoxEdit.Properties.Items.AddRange(new object[] {
            "Hire",
            "Contract To Hire",
            "Freelance",
            "Contract",
            "Other"});
            this.TypeComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.TypeComboBoxEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TypeComboBoxEdit.Size = new System.Drawing.Size(158, 20);
            this.TypeComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.TypeComboBoxEdit.TabIndex = 15;
            // 
            // OpeningsTextEdit
            // 
            this.OpeningsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "Openings", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OpeningsTextEdit.Location = new System.Drawing.Point(348, 162);
            this.OpeningsTextEdit.Name = "OpeningsTextEdit";
            this.OpeningsTextEdit.Properties.Mask.EditMask = "N0";
            this.OpeningsTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.OpeningsTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.OpeningsTextEdit.Size = new System.Drawing.Size(209, 20);
            this.OpeningsTextEdit.StyleController = this.dataLayoutControl1;
            this.OpeningsTextEdit.TabIndex = 16;
            // 
            // IsHotCheckEdit
            // 
            this.IsHotCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "IsHot", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IsHotCheckEdit.Location = new System.Drawing.Point(458, 42);
            this.IsHotCheckEdit.Name = "IsHotCheckEdit";
            this.IsHotCheckEdit.Properties.Caption = "Is Hot";
            this.IsHotCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.IsHotCheckEdit.Size = new System.Drawing.Size(99, 19);
            this.IsHotCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsHotCheckEdit.TabIndex = 17;
            // 
            // isPublicCheckEdit
            // 
            this.isPublicCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "isPublic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.isPublicCheckEdit.Location = new System.Drawing.Point(458, 66);
            this.isPublicCheckEdit.Name = "isPublicCheckEdit";
            this.isPublicCheckEdit.Properties.Caption = "Is Public";
            this.isPublicCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.isPublicCheckEdit.Size = new System.Drawing.Size(99, 19);
            this.isPublicCheckEdit.StyleController = this.dataLayoutControl1;
            this.isPublicCheckEdit.TabIndex = 18;
            // 
            // ExperienceYearTextEdit
            // 
            this.ExperienceYearTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "ExperienceYear", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ExperienceYearTextEdit.Location = new System.Drawing.Point(348, 138);
            this.ExperienceYearTextEdit.Name = "ExperienceYearTextEdit";
            this.ExperienceYearTextEdit.Properties.Mask.EditMask = "N0";
            this.ExperienceYearTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ExperienceYearTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ExperienceYearTextEdit.Size = new System.Drawing.Size(209, 20);
            this.ExperienceYearTextEdit.StyleController = this.dataLayoutControl1;
            this.ExperienceYearTextEdit.TabIndex = 22;
            // 
            // StatusComboBoxEdit
            // 
            this.StatusComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "Status", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.StatusComboBoxEdit.EditValue = "Active";
            this.StatusComboBoxEdit.Location = new System.Drawing.Point(348, 66);
            this.StatusComboBoxEdit.Name = "StatusComboBoxEdit";
            this.StatusComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StatusComboBoxEdit.Properties.Items.AddRange(new object[] {
            "Active",
            "Upcoming",
            "Prospective / lead",
            "On hold",
            "Full",
            "Close",
            "Canceled"});
            this.StatusComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.StatusComboBoxEdit.Size = new System.Drawing.Size(106, 20);
            this.StatusComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.StatusComboBoxEdit.TabIndex = 23;
            // 
            // WebLinkTextEdit
            // 
            this.WebLinkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "WebLink", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.WebLinkTextEdit.Location = new System.Drawing.Point(105, 186);
            this.WebLinkTextEdit.Name = "WebLinkTextEdit";
            this.WebLinkTextEdit.Size = new System.Drawing.Size(158, 20);
            this.WebLinkTextEdit.StyleController = this.dataLayoutControl1;
            this.WebLinkTextEdit.TabIndex = 24;
            // 
            // DescriptionMemoExEdit
            // 
            this.DescriptionMemoExEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DescriptionMemoExEdit.Location = new System.Drawing.Point(12, 238);
            this.DescriptionMemoExEdit.Name = "DescriptionMemoExEdit";
            this.DescriptionMemoExEdit.Size = new System.Drawing.Size(557, 425);
            this.DescriptionMemoExEdit.StyleController = this.dataLayoutControl1;
            this.DescriptionMemoExEdit.TabIndex = 19;
            // 
            // sbOK
            // 
            this.sbOK.Location = new System.Drawing.Point(325, 883);
            this.sbOK.Name = "sbOK";
            this.sbOK.Size = new System.Drawing.Size(118, 22);
            this.sbOK.StyleController = this.dataLayoutControl1;
            this.sbOK.TabIndex = 25;
            this.sbOK.Text = "OK";
            this.sbOK.Click += new System.EventHandler(this.sbOK_Click);
            // 
            // sbCancel
            // 
            this.sbCancel.Location = new System.Drawing.Point(447, 883);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(122, 22);
            this.sbCancel.StyleController = this.dataLayoutControl1;
            this.sbCancel.TabIndex = 26;
            this.sbCancel.Text = "Exit";
            this.sbCancel.Click += new System.EventHandler(this.sbCancel_Click);
            // 
            // sbDownload
            // 
            this.sbDownload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbDownload.ImageOptions.Image")));
            this.sbDownload.Location = new System.Drawing.Point(469, 845);
            this.sbDownload.Name = "sbDownload";
            this.sbDownload.Size = new System.Drawing.Size(88, 22);
            this.sbDownload.StyleController = this.dataLayoutControl1;
            this.sbDownload.TabIndex = 28;
            this.sbDownload.Text = "Download";
            this.sbDownload.Click += new System.EventHandler(this.sbDownload_Click);
            // 
            // sbDelete
            // 
            this.sbDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbDelete.ImageOptions.Image")));
            this.sbDelete.Location = new System.Drawing.Point(365, 845);
            this.sbDelete.Name = "sbDelete";
            this.sbDelete.Size = new System.Drawing.Size(100, 22);
            this.sbDelete.StyleController = this.dataLayoutControl1;
            this.sbDelete.TabIndex = 29;
            this.sbDelete.Text = "Delete";
            this.sbDelete.Click += new System.EventHandler(this.sbDelete_Click);
            // 
            // sbAddAttachment
            // 
            this.sbAddAttachment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAddAttachment.ImageOptions.Image")));
            this.sbAddAttachment.Location = new System.Drawing.Point(24, 845);
            this.sbAddAttachment.Name = "sbAddAttachment";
            this.sbAddAttachment.Size = new System.Drawing.Size(112, 22);
            this.sbAddAttachment.StyleController = this.dataLayoutControl1;
            this.sbAddAttachment.TabIndex = 33;
            this.sbAddAttachment.Text = "Add Attachment";
            this.sbAddAttachment.Click += new System.EventHandler(this.sbAttachment_Click);
            // 
            // meInternalNotes
            // 
            this.meInternalNotes.Location = new System.Drawing.Point(12, 683);
            this.meInternalNotes.Name = "meInternalNotes";
            this.meInternalNotes.Size = new System.Drawing.Size(557, 128);
            this.meInternalNotes.StyleController = this.dataLayoutControl1;
            this.meInternalNotes.TabIndex = 34;
            // 
            // companyComboxEdit
            // 
            this.companyComboxEdit.Location = new System.Drawing.Point(105, 42);
            this.companyComboxEdit.Name = "companyComboxEdit";
            this.companyComboxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.companyComboxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.companyComboxEdit.Size = new System.Drawing.Size(158, 20);
            this.companyComboxEdit.StyleController = this.dataLayoutControl1;
            this.companyComboxEdit.TabIndex = 31;
            this.companyComboxEdit.SelectedValueChanged += new System.EventHandler(this.companyComboxEdit_SelectedValueChanged);
            // 
            // contactComboboxEdit
            // 
            this.contactComboboxEdit.Location = new System.Drawing.Point(348, 42);
            this.contactComboboxEdit.Name = "contactComboboxEdit";
            this.contactComboboxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.contactComboboxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.contactComboboxEdit.Size = new System.Drawing.Size(106, 20);
            this.contactComboboxEdit.StyleController = this.dataLayoutControl1;
            this.contactComboboxEdit.TabIndex = 32;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1333, 917);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForDescription,
            this.layoutControlGroup3,
            this.layoutControlGroup4,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem7,
            this.layoutControlGroup5});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1313, 897);
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.Control = this.DescriptionMemoExEdit;
            this.ItemForDescription.Location = new System.Drawing.Point(0, 210);
            this.ItemForDescription.Name = "ItemForDescription";
            this.ItemForDescription.Size = new System.Drawing.Size(561, 445);
            this.ItemForDescription.Text = "Description";
            this.ItemForDescription.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForDescription.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForIsHot,
            this.ItemForCompany,
            this.ItemForContact,
            this.ItemForExperienceYear,
            this.ItemForType,
            this.ItemForStatus,
            this.ItemForisPublic,
            this.ItemForWebLink,
            this.ItemForDuration,
            this.ItemForStartDate,
            this.ItemForOpenings,
            this.ItemForTitle,
            this.ItemForDepartment,
            this.ItemForSalary,
            this.ItemForCity,
            this.ItemForState});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(561, 210);
            this.layoutControlGroup3.Text = "Information";
            // 
            // ItemForIsHot
            // 
            this.ItemForIsHot.Control = this.IsHotCheckEdit;
            this.ItemForIsHot.Location = new System.Drawing.Point(434, 0);
            this.ItemForIsHot.Name = "ItemForIsHot";
            this.ItemForIsHot.Size = new System.Drawing.Size(103, 24);
            this.ItemForIsHot.Text = "Is Hot";
            this.ItemForIsHot.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIsHot.TextVisible = false;
            // 
            // ItemForCompany
            // 
            this.ItemForCompany.Control = this.companyComboxEdit;
            this.ItemForCompany.Location = new System.Drawing.Point(0, 0);
            this.ItemForCompany.Name = "ItemForCompany";
            this.ItemForCompany.Size = new System.Drawing.Size(243, 24);
            this.ItemForCompany.Text = "Company";
            this.ItemForCompany.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForContact
            // 
            this.ItemForContact.Control = this.contactComboboxEdit;
            this.ItemForContact.Location = new System.Drawing.Point(243, 0);
            this.ItemForContact.Name = "ItemForContact";
            this.ItemForContact.Size = new System.Drawing.Size(191, 24);
            this.ItemForContact.Text = "Contact";
            this.ItemForContact.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForExperienceYear
            // 
            this.ItemForExperienceYear.Control = this.ExperienceYearTextEdit;
            this.ItemForExperienceYear.Location = new System.Drawing.Point(243, 96);
            this.ItemForExperienceYear.Name = "ItemForExperienceYear";
            this.ItemForExperienceYear.Size = new System.Drawing.Size(294, 24);
            this.ItemForExperienceYear.Text = "Experience Year";
            this.ItemForExperienceYear.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForType
            // 
            this.ItemForType.Control = this.TypeComboBoxEdit;
            this.ItemForType.Location = new System.Drawing.Point(0, 24);
            this.ItemForType.Name = "ItemForType";
            this.ItemForType.Size = new System.Drawing.Size(243, 24);
            this.ItemForType.Text = "Type";
            this.ItemForType.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForStatus
            // 
            this.ItemForStatus.Control = this.StatusComboBoxEdit;
            this.ItemForStatus.Location = new System.Drawing.Point(243, 24);
            this.ItemForStatus.Name = "ItemForStatus";
            this.ItemForStatus.Size = new System.Drawing.Size(191, 24);
            this.ItemForStatus.Text = "Status";
            this.ItemForStatus.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForisPublic
            // 
            this.ItemForisPublic.Control = this.isPublicCheckEdit;
            this.ItemForisPublic.Location = new System.Drawing.Point(434, 24);
            this.ItemForisPublic.Name = "ItemForisPublic";
            this.ItemForisPublic.Size = new System.Drawing.Size(103, 24);
            this.ItemForisPublic.Text = "is Public";
            this.ItemForisPublic.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForisPublic.TextVisible = false;
            // 
            // ItemForWebLink
            // 
            this.ItemForWebLink.Control = this.WebLinkTextEdit;
            this.ItemForWebLink.Location = new System.Drawing.Point(0, 144);
            this.ItemForWebLink.Name = "ItemForWebLink";
            this.ItemForWebLink.Size = new System.Drawing.Size(243, 24);
            this.ItemForWebLink.Text = "Web Link";
            this.ItemForWebLink.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForDuration
            // 
            this.ItemForDuration.Control = this.DurationTextEdit;
            this.ItemForDuration.Location = new System.Drawing.Point(0, 120);
            this.ItemForDuration.Name = "ItemForDuration";
            this.ItemForDuration.Size = new System.Drawing.Size(243, 24);
            this.ItemForDuration.Text = "Duration";
            this.ItemForDuration.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForStartDate
            // 
            this.ItemForStartDate.Control = this.StartDateDateEdit;
            this.ItemForStartDate.Location = new System.Drawing.Point(243, 144);
            this.ItemForStartDate.Name = "ItemForStartDate";
            this.ItemForStartDate.Size = new System.Drawing.Size(294, 24);
            this.ItemForStartDate.Text = "Start Date";
            this.ItemForStartDate.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForOpenings
            // 
            this.ItemForOpenings.Control = this.OpeningsTextEdit;
            this.ItemForOpenings.Location = new System.Drawing.Point(243, 120);
            this.ItemForOpenings.Name = "ItemForOpenings";
            this.ItemForOpenings.Size = new System.Drawing.Size(294, 24);
            this.ItemForOpenings.Text = "Openings";
            this.ItemForOpenings.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForTitle
            // 
            this.ItemForTitle.Control = this.TitleTextEdit;
            this.ItemForTitle.Location = new System.Drawing.Point(0, 48);
            this.ItemForTitle.Name = "ItemForTitle";
            this.ItemForTitle.Size = new System.Drawing.Size(243, 24);
            this.ItemForTitle.Text = "Title";
            this.ItemForTitle.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForDepartment
            // 
            this.ItemForDepartment.Control = this.DepartmentTextEdit;
            this.ItemForDepartment.Location = new System.Drawing.Point(243, 48);
            this.ItemForDepartment.Name = "ItemForDepartment";
            this.ItemForDepartment.Size = new System.Drawing.Size(294, 24);
            this.ItemForDepartment.Text = "Department";
            this.ItemForDepartment.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForSalary
            // 
            this.ItemForSalary.Control = this.SalaryTextEdit;
            this.ItemForSalary.Location = new System.Drawing.Point(0, 96);
            this.ItemForSalary.Name = "ItemForSalary";
            this.ItemForSalary.Size = new System.Drawing.Size(243, 24);
            this.ItemForSalary.Text = "Salary";
            this.ItemForSalary.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForCity
            // 
            this.ItemForCity.Control = this.CityTextEdit;
            this.ItemForCity.Location = new System.Drawing.Point(0, 72);
            this.ItemForCity.Name = "ItemForCity";
            this.ItemForCity.Size = new System.Drawing.Size(243, 24);
            this.ItemForCity.Text = "City";
            this.ItemForCity.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForState
            // 
            this.ItemForState.Control = this.StateTextEdit;
            this.ItemForState.Location = new System.Drawing.Point(243, 72);
            this.ItemForState.Name = "ItemForState";
            this.ItemForState.Size = new System.Drawing.Size(294, 24);
            this.ItemForState.Text = "State";
            this.ItemForState.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.sliAttachment,
            this.layoutControlItem6});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 803);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(561, 68);
            this.layoutControlGroup4.Text = "Attachment";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sbDelete;
            this.layoutControlItem5.Location = new System.Drawing.Point(341, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(104, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sbDownload;
            this.layoutControlItem4.Location = new System.Drawing.Point(445, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(92, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // sliAttachment
            // 
            this.sliAttachment.AllowHotTrack = false;
            this.sliAttachment.Location = new System.Drawing.Point(116, 0);
            this.sliAttachment.Name = "sliAttackment";
            this.sliAttachment.Size = new System.Drawing.Size(225, 26);
            this.sliAttachment.Text = "No file is chosen";
            this.sliAttachment.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.sbAddAttachment;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(116, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.sbOK;
            this.layoutControlItem1.Location = new System.Drawing.Point(313, 871);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(122, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbCancel;
            this.layoutControlItem2.Location = new System.Drawing.Point(435, 871);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(126, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 871);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(313, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.meInternalNotes;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 655);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(561, 148);
            this.layoutControlItem7.Text = "Internal Notes";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup5.Location = new System.Drawing.Point(561, 0);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(752, 897);
            this.layoutControlGroup5.Text = "Candidates in pipeline";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gcCandidatePipeline;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(728, 855);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // editCandidateToolStripMenuItem
            // 
            this.editCandidateToolStripMenuItem.Name = "editCandidateToolStripMenuItem";
            this.editCandidateToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.editCandidateToolStripMenuItem.Text = "Edit Candidate";
            this.editCandidateToolStripMenuItem.Click += new System.EventHandler(this.editCandidateToolStripMenuItem_Click);
            // 
            // dlgJobOrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 917);
            this.Controls.Add(this.dataLayoutControl1);
            this.KeyPreview = true;
            this.Name = "dlgJobOrderEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Order";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dlgJobOrderEdit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCandidatePipeline)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCandidatePipeline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRatingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpeningsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsHotCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isPublicCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExperienceYearTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebLinkTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionMemoExEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meInternalNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyComboxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactComboboxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsHot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExperienceYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForisPublic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWebLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOpenings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliAttachment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit TitleTextEdit;
        private System.Windows.Forms.BindingSource jobOrderBindingSource;
        private DevExpress.XtraEditors.TextEdit DepartmentTextEdit;
        private DevExpress.XtraEditors.TextEdit SalaryTextEdit;
        private DevExpress.XtraEditors.TextEdit CityTextEdit;
        private DevExpress.XtraEditors.TextEdit StateTextEdit;
        private DevExpress.XtraEditors.DateEdit StartDateDateEdit;
        private DevExpress.XtraEditors.TextEdit DurationTextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit TypeComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit OpeningsTextEdit;
        private DevExpress.XtraEditors.CheckEdit IsHotCheckEdit;
        private DevExpress.XtraEditors.CheckEdit isPublicCheckEdit;
        private DevExpress.XtraEditors.TextEdit ExperienceYearTextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit StatusComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit WebLinkTextEdit;
        private DevExpress.XtraEditors.MemoEdit DescriptionMemoExEdit;
        private DevExpress.XtraEditors.SimpleButton sbOK;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDescription;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTitle;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDepartment;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSalary;
        private DevExpress.XtraLayout.LayoutControlItem ItemForType;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsHot;
        private DevExpress.XtraLayout.LayoutControlItem ItemForisPublic;
        private DevExpress.XtraLayout.LayoutControlItem ItemForOpenings;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCity;
        private DevExpress.XtraLayout.LayoutControlItem ItemForState;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDuration;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStartDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForExperienceYear;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWebLink;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStatus;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.GridControl gcCandidatePipeline;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCandidatePipeline;
        private DevExpress.XtraEditors.SimpleButton sbDownload;
        private DevExpress.XtraEditors.SimpleButton sbDelete;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colMatch;
        private DevExpress.XtraEditors.Repository.RepositoryItemRatingControl repositoryItemRatingControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colAdded;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colLastActivity;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContact;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompany;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addCandidateToPipelineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCandidateFromPipelineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToCandidateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToAllCandidatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addActivityToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraLayout.SimpleLabelItem sliAttachment;
        private DevExpress.XtraEditors.SimpleButton sbAddAttachment;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.MemoEdit meInternalNotes;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.ComboBoxEdit companyComboxEdit;
        private DevExpress.XtraEditors.ComboBoxEdit contactComboboxEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.ToolStripMenuItem editCandidateToolStripMenuItem;
    }
}