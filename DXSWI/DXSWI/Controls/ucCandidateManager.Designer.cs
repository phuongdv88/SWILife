﻿namespace DXSWI.Controls
{
    partial class ucCandidateManager
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
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCandidateManager));
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.swilifecoreDataSet = new DXSWI.swilifecoreDataSet();
            this.swilifecoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SecondaryEmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SkypeIMTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CellPhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.WorkPhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BestTimeToCallTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.WebSiteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SourceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CurrentPositionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CurrentEmployerTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.KeySkillsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CurrentPayTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DesiredPayTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DOBMarriedTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.InterviewNotesMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.UserIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MiscNotesMemoExEdit = new DevExpress.XtraEditors.MemoEdit();
            this.CreatedDateDateEdit = new DevExpress.XtraEditors.TextEdit();
            this.DateAvailableDateEdit = new DevExpress.XtraEditors.TextEdit();
            this.CanRelocateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.peAvatar = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForInterviewNotes = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMiscNotes = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSecondaryEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSkypeIM = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCellPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForWorkPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForWebSite = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCreatedDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUserId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBestTimeToCall = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSource = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForKeySkills = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCurrentPay = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDesiredPay = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDOBMarried = new DevExpress.XtraLayout.LayoutControlItem();
            this.CanRelocate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCurrentPosition = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCurrentEmployer = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDateAvailable = new DevExpress.XtraLayout.LayoutControlItem();
            this.locAvatar = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gcJobOrderPipeline = new DevExpress.XtraGrid.GridControl();
            this.gvJobOrderPipeline = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Match = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Company = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Owner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Added = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EnterBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Action = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.gcActivities = new DevExpress.XtraGrid.GridControl();
            this.gvActivities = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Entered = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Regarding = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Notes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ActionActivities = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.swilifecoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swilifecoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondaryEmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkypeIMTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellPhoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkPhoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestTimeToCallTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebSiteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPositionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentEmployerTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeySkillsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPayTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesiredPayTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOBMarriedTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterviewNotesMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiscNotesMemoExEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreatedDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateAvailableDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CanRelocateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAvatar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInterviewNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMiscNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSecondaryEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSkypeIM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCellPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWorkPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWebSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreatedDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBestTimeToCall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForKeySkills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCurrentPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDesiredPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDOBMarried)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CanRelocate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCurrentPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCurrentEmployer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDateAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcJobOrderPipeline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvJobOrderPipeline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DXSWI.Properties.Settings.swilifecoreConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "select * from candidate";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // swilifecoreDataSet
            // 
            this.swilifecoreDataSet.DataSetName = "swilifecoreDataSet";
            this.swilifecoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // swilifecoreDataSetBindingSource
            // 
            this.swilifecoreDataSetBindingSource.DataSource = this.swilifecoreDataSet;
            this.swilifecoreDataSetBindingSource.Position = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dataLayoutControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(976, 457);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Candidate Information";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SecondaryEmailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SkypeIMTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CellPhoneTextEdit);
            this.dataLayoutControl1.Controls.Add(this.WorkPhoneTextEdit);
            this.dataLayoutControl1.Controls.Add(this.BestTimeToCallTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AddressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.WebSiteTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SourceTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CurrentPositionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CurrentEmployerTextEdit);
            this.dataLayoutControl1.Controls.Add(this.KeySkillsTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CurrentPayTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DesiredPayTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DOBMarriedTextEdit);
            this.dataLayoutControl1.Controls.Add(this.InterviewNotesMemoEdit);
            this.dataLayoutControl1.Controls.Add(this.UserIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MiscNotesMemoExEdit);
            this.dataLayoutControl1.Controls.Add(this.CreatedDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.DateAvailableDateEdit);
            this.dataLayoutControl1.Controls.Add(this.CanRelocateTextEdit);
            this.dataLayoutControl1.Controls.Add(this.peAvatar);
            this.dataLayoutControl1.DataMember = "Query";
            this.dataLayoutControl1.DataSource = this.sqlDataSource1;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 20);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(517, 23, 450, 400);
            this.dataLayoutControl1.Root = this.layoutControlGroup2;
            this.dataLayoutControl1.Size = new System.Drawing.Size(972, 435);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "Query.Email", true));
            this.EmailTextEdit.Location = new System.Drawing.Point(316, 42);
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Properties.ReadOnly = true;
            this.EmailTextEdit.Size = new System.Drawing.Size(277, 20);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 7;
            // 
            // SecondaryEmailTextEdit
            // 
            this.SecondaryEmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "Query.SecondaryEmail", true));
            this.SecondaryEmailTextEdit.Location = new System.Drawing.Point(684, 42);
            this.SecondaryEmailTextEdit.Name = "SecondaryEmailTextEdit";
            this.SecondaryEmailTextEdit.Properties.ReadOnly = true;
            this.SecondaryEmailTextEdit.Size = new System.Drawing.Size(264, 20);
            this.SecondaryEmailTextEdit.StyleController = this.dataLayoutControl1;
            this.SecondaryEmailTextEdit.TabIndex = 8;
            // 
            // SkypeIMTextEdit
            // 
            this.SkypeIMTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "Query.SkypeIM", true));
            this.SkypeIMTextEdit.Location = new System.Drawing.Point(316, 90);
            this.SkypeIMTextEdit.Name = "SkypeIMTextEdit";
            this.SkypeIMTextEdit.Properties.ReadOnly = true;
            this.SkypeIMTextEdit.Size = new System.Drawing.Size(277, 20);
            this.SkypeIMTextEdit.StyleController = this.dataLayoutControl1;
            this.SkypeIMTextEdit.TabIndex = 9;
            // 
            // CellPhoneTextEdit
            // 
            this.CellPhoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "Query.CellPhone", true));
            this.CellPhoneTextEdit.Location = new System.Drawing.Point(316, 66);
            this.CellPhoneTextEdit.Name = "CellPhoneTextEdit";
            this.CellPhoneTextEdit.Properties.ReadOnly = true;
            this.CellPhoneTextEdit.Size = new System.Drawing.Size(277, 20);
            this.CellPhoneTextEdit.StyleController = this.dataLayoutControl1;
            this.CellPhoneTextEdit.TabIndex = 10;
            // 
            // WorkPhoneTextEdit
            // 
            this.WorkPhoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "Query.WorkPhone", true));
            this.WorkPhoneTextEdit.Location = new System.Drawing.Point(684, 66);
            this.WorkPhoneTextEdit.Name = "WorkPhoneTextEdit";
            this.WorkPhoneTextEdit.Properties.ReadOnly = true;
            this.WorkPhoneTextEdit.Size = new System.Drawing.Size(264, 20);
            this.WorkPhoneTextEdit.StyleController = this.dataLayoutControl1;
            this.WorkPhoneTextEdit.TabIndex = 11;
            // 
            // BestTimeToCallTextEdit
            // 
            this.BestTimeToCallTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "Query.BestTimeToCall", true));
            this.BestTimeToCallTextEdit.Location = new System.Drawing.Point(684, 90);
            this.BestTimeToCallTextEdit.Name = "BestTimeToCallTextEdit";
            this.BestTimeToCallTextEdit.Properties.ReadOnly = true;
            this.BestTimeToCallTextEdit.Size = new System.Drawing.Size(264, 20);
            this.BestTimeToCallTextEdit.StyleController = this.dataLayoutControl1;
            this.BestTimeToCallTextEdit.TabIndex = 12;
            // 
            // AddressTextEdit
            // 
            this.AddressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "Query.Address", true));
            this.AddressTextEdit.Location = new System.Drawing.Point(316, 138);
            this.AddressTextEdit.Name = "AddressTextEdit";
            this.AddressTextEdit.Properties.ReadOnly = true;
            this.AddressTextEdit.Size = new System.Drawing.Size(632, 20);
            this.AddressTextEdit.StyleController = this.dataLayoutControl1;
            this.AddressTextEdit.TabIndex = 13;
            // 
            // WebSiteTextEdit
            // 
            this.WebSiteTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "Query.WebSite", true));
            this.WebSiteTextEdit.Location = new System.Drawing.Point(316, 114);
            this.WebSiteTextEdit.Name = "WebSiteTextEdit";
            this.WebSiteTextEdit.Properties.ReadOnly = true;
            this.WebSiteTextEdit.Size = new System.Drawing.Size(632, 20);
            this.WebSiteTextEdit.StyleController = this.dataLayoutControl1;
            this.WebSiteTextEdit.TabIndex = 14;
            // 
            // SourceTextEdit
            // 
            this.SourceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "Query.Source", true));
            this.SourceTextEdit.Location = new System.Drawing.Point(775, 162);
            this.SourceTextEdit.Name = "SourceTextEdit";
            this.SourceTextEdit.Properties.ReadOnly = true;
            this.SourceTextEdit.Size = new System.Drawing.Size(173, 20);
            this.SourceTextEdit.StyleController = this.dataLayoutControl1;
            this.SourceTextEdit.TabIndex = 15;
            // 
            // CurrentPositionTextEdit
            // 
            this.CurrentPositionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "Query.CurrentPosition", true));
            this.CurrentPositionTextEdit.Location = new System.Drawing.Point(316, 300);
            this.CurrentPositionTextEdit.Name = "CurrentPositionTextEdit";
            this.CurrentPositionTextEdit.Properties.ReadOnly = true;
            this.CurrentPositionTextEdit.Size = new System.Drawing.Size(278, 20);
            this.CurrentPositionTextEdit.StyleController = this.dataLayoutControl1;
            this.CurrentPositionTextEdit.TabIndex = 16;
            // 
            // CurrentEmployerTextEdit
            // 
            this.CurrentEmployerTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "Query.CurrentEmployer", true));
            this.CurrentEmployerTextEdit.Location = new System.Drawing.Point(685, 300);
            this.CurrentEmployerTextEdit.Name = "CurrentEmployerTextEdit";
            this.CurrentEmployerTextEdit.Properties.ReadOnly = true;
            this.CurrentEmployerTextEdit.Size = new System.Drawing.Size(263, 20);
            this.CurrentEmployerTextEdit.StyleController = this.dataLayoutControl1;
            this.CurrentEmployerTextEdit.TabIndex = 18;
            // 
            // KeySkillsTextEdit
            // 
            this.KeySkillsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "Query.KeySkills", true));
            this.KeySkillsTextEdit.Location = new System.Drawing.Point(316, 228);
            this.KeySkillsTextEdit.Name = "KeySkillsTextEdit";
            this.KeySkillsTextEdit.Properties.ReadOnly = true;
            this.KeySkillsTextEdit.Size = new System.Drawing.Size(278, 20);
            this.KeySkillsTextEdit.StyleController = this.dataLayoutControl1;
            this.KeySkillsTextEdit.TabIndex = 19;
            // 
            // CurrentPayTextEdit
            // 
            this.CurrentPayTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "Query.CurrentPay", true));
            this.CurrentPayTextEdit.Location = new System.Drawing.Point(316, 252);
            this.CurrentPayTextEdit.Name = "CurrentPayTextEdit";
            this.CurrentPayTextEdit.Properties.ReadOnly = true;
            this.CurrentPayTextEdit.Size = new System.Drawing.Size(278, 20);
            this.CurrentPayTextEdit.StyleController = this.dataLayoutControl1;
            this.CurrentPayTextEdit.TabIndex = 21;
            // 
            // DesiredPayTextEdit
            // 
            this.DesiredPayTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "Query.DesiredPay", true));
            this.DesiredPayTextEdit.Location = new System.Drawing.Point(685, 252);
            this.DesiredPayTextEdit.Name = "DesiredPayTextEdit";
            this.DesiredPayTextEdit.Properties.ReadOnly = true;
            this.DesiredPayTextEdit.Size = new System.Drawing.Size(263, 20);
            this.DesiredPayTextEdit.StyleController = this.dataLayoutControl1;
            this.DesiredPayTextEdit.TabIndex = 22;
            // 
            // DOBMarriedTextEdit
            // 
            this.DOBMarriedTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "Query.DOBMarried", true));
            this.DOBMarriedTextEdit.Location = new System.Drawing.Point(316, 276);
            this.DOBMarriedTextEdit.Name = "DOBMarriedTextEdit";
            this.DOBMarriedTextEdit.Properties.ReadOnly = true;
            this.DOBMarriedTextEdit.Size = new System.Drawing.Size(278, 20);
            this.DOBMarriedTextEdit.StyleController = this.dataLayoutControl1;
            this.DOBMarriedTextEdit.TabIndex = 23;
            // 
            // InterviewNotesMemoEdit
            // 
            this.InterviewNotesMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "Query.InterviewNotes", true));
            this.InterviewNotesMemoEdit.Location = new System.Drawing.Point(99, 336);
            this.InterviewNotesMemoEdit.Name = "InterviewNotesMemoEdit";
            this.InterviewNotesMemoEdit.Properties.ReadOnly = true;
            this.InterviewNotesMemoEdit.Size = new System.Drawing.Size(861, 54);
            this.InterviewNotesMemoEdit.StyleController = this.dataLayoutControl1;
            this.InterviewNotesMemoEdit.TabIndex = 24;
            // 
            // UserIdTextEdit
            // 
            this.UserIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "Query.UserId", true));
            this.UserIdTextEdit.Location = new System.Drawing.Point(536, 162);
            this.UserIdTextEdit.Name = "UserIdTextEdit";
            this.UserIdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.UserIdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.UserIdTextEdit.Properties.Mask.EditMask = "N0";
            this.UserIdTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.UserIdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.UserIdTextEdit.Properties.ReadOnly = true;
            this.UserIdTextEdit.Size = new System.Drawing.Size(148, 20);
            this.UserIdTextEdit.StyleController = this.dataLayoutControl1;
            this.UserIdTextEdit.TabIndex = 28;
            // 
            // MiscNotesMemoExEdit
            // 
            this.MiscNotesMemoExEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "Query.MiscNotes", true));
            this.MiscNotesMemoExEdit.Location = new System.Drawing.Point(99, 394);
            this.MiscNotesMemoExEdit.Name = "MiscNotesMemoExEdit";
            this.MiscNotesMemoExEdit.Properties.ReadOnly = true;
            this.MiscNotesMemoExEdit.Size = new System.Drawing.Size(861, 29);
            this.MiscNotesMemoExEdit.StyleController = this.dataLayoutControl1;
            this.MiscNotesMemoExEdit.TabIndex = 26;
            // 
            // CreatedDateDateEdit
            // 
            this.CreatedDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "Query.CreatedDate", true));
            this.CreatedDateDateEdit.Location = new System.Drawing.Point(316, 162);
            this.CreatedDateDateEdit.Name = "CreatedDateDateEdit";
            this.CreatedDateDateEdit.Properties.DisplayFormat.FormatString = "d";
            this.CreatedDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.CreatedDateDateEdit.Properties.EditFormat.FormatString = "d";
            this.CreatedDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.CreatedDateDateEdit.Properties.Mask.EditMask = "d";
            this.CreatedDateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.CreatedDateDateEdit.Properties.ReadOnly = true;
            this.CreatedDateDateEdit.Size = new System.Drawing.Size(129, 20);
            this.CreatedDateDateEdit.StyleController = this.dataLayoutControl1;
            this.CreatedDateDateEdit.TabIndex = 27;
            // 
            // DateAvailableDateEdit
            // 
            this.DateAvailableDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "Query.DateAvailable", true));
            this.DateAvailableDateEdit.Location = new System.Drawing.Point(685, 228);
            this.DateAvailableDateEdit.Name = "DateAvailableDateEdit";
            this.DateAvailableDateEdit.Properties.DisplayFormat.FormatString = "d";
            this.DateAvailableDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateAvailableDateEdit.Properties.EditFormat.FormatString = "d";
            this.DateAvailableDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateAvailableDateEdit.Properties.Mask.EditMask = "d";
            this.DateAvailableDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.DateAvailableDateEdit.Properties.ReadOnly = true;
            this.DateAvailableDateEdit.Size = new System.Drawing.Size(263, 20);
            this.DateAvailableDateEdit.StyleController = this.dataLayoutControl1;
            this.DateAvailableDateEdit.TabIndex = 17;
            // 
            // CanRelocateTextEdit
            // 
            this.CanRelocateTextEdit.Location = new System.Drawing.Point(685, 276);
            this.CanRelocateTextEdit.Name = "CanRelocateTextEdit";
            this.CanRelocateTextEdit.Properties.ReadOnly = true;
            this.CanRelocateTextEdit.Size = new System.Drawing.Size(263, 20);
            this.CanRelocateTextEdit.StyleController = this.dataLayoutControl1;
            this.CanRelocateTextEdit.TabIndex = 30;
            // 
            // peAvatar
            // 
            this.peAvatar.Cursor = System.Windows.Forms.Cursors.Default;
            this.peAvatar.Location = new System.Drawing.Point(12, 47);
            this.peAvatar.Name = "peAvatar";
            this.peAvatar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peAvatar.Properties.ZoomAccelerationFactor = 1D;
            this.peAvatar.Size = new System.Drawing.Size(201, 285);
            this.peAvatar.StyleController = this.dataLayoutControl1;
            this.peAvatar.TabIndex = 31;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Size = new System.Drawing.Size(972, 435);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AllowDrawBackground = false;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForInterviewNotes,
            this.ItemForMiscNotes,
            this.layoutControlGroup4,
            this.layoutControlGroup6,
            this.locAvatar});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "autoGeneratedGroup0";
            this.layoutControlGroup3.Size = new System.Drawing.Size(952, 415);
            // 
            // ItemForInterviewNotes
            // 
            this.ItemForInterviewNotes.Control = this.InterviewNotesMemoEdit;
            this.ItemForInterviewNotes.Location = new System.Drawing.Point(0, 324);
            this.ItemForInterviewNotes.Name = "ItemForInterviewNotes";
            this.ItemForInterviewNotes.Size = new System.Drawing.Size(952, 58);
            this.ItemForInterviewNotes.StartNewLine = true;
            this.ItemForInterviewNotes.Text = "Interview Notes";
            this.ItemForInterviewNotes.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForMiscNotes
            // 
            this.ItemForMiscNotes.Control = this.MiscNotesMemoExEdit;
            this.ItemForMiscNotes.Location = new System.Drawing.Point(0, 382);
            this.ItemForMiscNotes.Name = "ItemForMiscNotes";
            this.ItemForMiscNotes.Size = new System.Drawing.Size(952, 33);
            this.ItemForMiscNotes.Text = "Misc Notes";
            this.ItemForMiscNotes.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForEmail,
            this.ItemForSecondaryEmail,
            this.ItemForSkypeIM,
            this.ItemForAddress,
            this.ItemForCellPhone,
            this.ItemForWorkPhone,
            this.ItemForWebSite,
            this.ItemForCreatedDate,
            this.ItemForUserId,
            this.ItemForBestTimeToCall,
            this.ItemForSource});
            this.layoutControlGroup4.Location = new System.Drawing.Point(205, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(747, 186);
            this.layoutControlGroup4.Text = "Contact Information";
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.Location = new System.Drawing.Point(0, 0);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(368, 24);
            this.ItemForEmail.Text = "Email";
            this.ItemForEmail.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForSecondaryEmail
            // 
            this.ItemForSecondaryEmail.Control = this.SecondaryEmailTextEdit;
            this.ItemForSecondaryEmail.Location = new System.Drawing.Point(368, 0);
            this.ItemForSecondaryEmail.Name = "ItemForSecondaryEmail";
            this.ItemForSecondaryEmail.Size = new System.Drawing.Size(355, 24);
            this.ItemForSecondaryEmail.Text = "Secondary Email";
            this.ItemForSecondaryEmail.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForSkypeIM
            // 
            this.ItemForSkypeIM.Control = this.SkypeIMTextEdit;
            this.ItemForSkypeIM.Location = new System.Drawing.Point(0, 48);
            this.ItemForSkypeIM.Name = "ItemForSkypeIM";
            this.ItemForSkypeIM.Size = new System.Drawing.Size(368, 24);
            this.ItemForSkypeIM.Text = "Skype IM";
            this.ItemForSkypeIM.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForAddress
            // 
            this.ItemForAddress.Control = this.AddressTextEdit;
            this.ItemForAddress.Location = new System.Drawing.Point(0, 96);
            this.ItemForAddress.Name = "ItemForAddress";
            this.ItemForAddress.Size = new System.Drawing.Size(723, 24);
            this.ItemForAddress.Text = "Address";
            this.ItemForAddress.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForCellPhone
            // 
            this.ItemForCellPhone.Control = this.CellPhoneTextEdit;
            this.ItemForCellPhone.Location = new System.Drawing.Point(0, 24);
            this.ItemForCellPhone.Name = "ItemForCellPhone";
            this.ItemForCellPhone.Size = new System.Drawing.Size(368, 24);
            this.ItemForCellPhone.Text = "Cell Phone";
            this.ItemForCellPhone.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForWorkPhone
            // 
            this.ItemForWorkPhone.Control = this.WorkPhoneTextEdit;
            this.ItemForWorkPhone.Location = new System.Drawing.Point(368, 24);
            this.ItemForWorkPhone.Name = "ItemForWorkPhone";
            this.ItemForWorkPhone.Size = new System.Drawing.Size(355, 24);
            this.ItemForWorkPhone.Text = "Work Phone";
            this.ItemForWorkPhone.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForWebSite
            // 
            this.ItemForWebSite.Control = this.WebSiteTextEdit;
            this.ItemForWebSite.Location = new System.Drawing.Point(0, 72);
            this.ItemForWebSite.Name = "ItemForWebSite";
            this.ItemForWebSite.Size = new System.Drawing.Size(723, 24);
            this.ItemForWebSite.Text = "Web Site";
            this.ItemForWebSite.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForCreatedDate
            // 
            this.ItemForCreatedDate.Control = this.CreatedDateDateEdit;
            this.ItemForCreatedDate.Location = new System.Drawing.Point(0, 120);
            this.ItemForCreatedDate.Name = "ItemForCreatedDate";
            this.ItemForCreatedDate.Size = new System.Drawing.Size(220, 24);
            this.ItemForCreatedDate.Text = "Created Date";
            this.ItemForCreatedDate.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForUserId
            // 
            this.ItemForUserId.Control = this.UserIdTextEdit;
            this.ItemForUserId.Location = new System.Drawing.Point(220, 120);
            this.ItemForUserId.Name = "ItemForUserId";
            this.ItemForUserId.Size = new System.Drawing.Size(239, 24);
            this.ItemForUserId.Text = "Owner";
            this.ItemForUserId.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForBestTimeToCall
            // 
            this.ItemForBestTimeToCall.Control = this.BestTimeToCallTextEdit;
            this.ItemForBestTimeToCall.Location = new System.Drawing.Point(368, 48);
            this.ItemForBestTimeToCall.Name = "ItemForBestTimeToCall";
            this.ItemForBestTimeToCall.Size = new System.Drawing.Size(355, 24);
            this.ItemForBestTimeToCall.Text = "Best Time To Call";
            this.ItemForBestTimeToCall.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForSource
            // 
            this.ItemForSource.Control = this.SourceTextEdit;
            this.ItemForSource.Location = new System.Drawing.Point(459, 120);
            this.ItemForSource.Name = "ItemForSource";
            this.ItemForSource.Size = new System.Drawing.Size(264, 24);
            this.ItemForSource.Text = "Source";
            this.ItemForSource.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForKeySkills,
            this.ItemForCurrentPay,
            this.ItemForDesiredPay,
            this.ItemForDOBMarried,
            this.CanRelocate,
            this.ItemForCurrentPosition,
            this.ItemForCurrentEmployer,
            this.ItemForDateAvailable});
            this.layoutControlGroup6.Location = new System.Drawing.Point(205, 186);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(747, 138);
            this.layoutControlGroup6.Text = "Candidate Information";
            // 
            // ItemForKeySkills
            // 
            this.ItemForKeySkills.Control = this.KeySkillsTextEdit;
            this.ItemForKeySkills.Location = new System.Drawing.Point(0, 0);
            this.ItemForKeySkills.Name = "ItemForKeySkills";
            this.ItemForKeySkills.Size = new System.Drawing.Size(369, 24);
            this.ItemForKeySkills.Text = "Key Skills";
            this.ItemForKeySkills.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForCurrentPay
            // 
            this.ItemForCurrentPay.Control = this.CurrentPayTextEdit;
            this.ItemForCurrentPay.Location = new System.Drawing.Point(0, 24);
            this.ItemForCurrentPay.Name = "ItemForCurrentPay";
            this.ItemForCurrentPay.Size = new System.Drawing.Size(369, 24);
            this.ItemForCurrentPay.Text = "Current Pay";
            this.ItemForCurrentPay.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForDesiredPay
            // 
            this.ItemForDesiredPay.Control = this.DesiredPayTextEdit;
            this.ItemForDesiredPay.Location = new System.Drawing.Point(369, 24);
            this.ItemForDesiredPay.Name = "ItemForDesiredPay";
            this.ItemForDesiredPay.Size = new System.Drawing.Size(354, 24);
            this.ItemForDesiredPay.Text = "Desired Pay";
            this.ItemForDesiredPay.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForDOBMarried
            // 
            this.ItemForDOBMarried.Control = this.DOBMarriedTextEdit;
            this.ItemForDOBMarried.Location = new System.Drawing.Point(0, 48);
            this.ItemForDOBMarried.Name = "ItemForDOBMarried";
            this.ItemForDOBMarried.Size = new System.Drawing.Size(369, 24);
            this.ItemForDOBMarried.Text = "DOB Married";
            this.ItemForDOBMarried.TextSize = new System.Drawing.Size(84, 13);
            // 
            // CanRelocate
            // 
            this.CanRelocate.Control = this.CanRelocateTextEdit;
            this.CanRelocate.Location = new System.Drawing.Point(369, 48);
            this.CanRelocate.Name = "CanRelocate";
            this.CanRelocate.Size = new System.Drawing.Size(354, 24);
            this.CanRelocate.Text = "Can Relocate";
            this.CanRelocate.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForCurrentPosition
            // 
            this.ItemForCurrentPosition.Control = this.CurrentPositionTextEdit;
            this.ItemForCurrentPosition.Location = new System.Drawing.Point(0, 72);
            this.ItemForCurrentPosition.Name = "ItemForCurrentPosition";
            this.ItemForCurrentPosition.Size = new System.Drawing.Size(369, 24);
            this.ItemForCurrentPosition.Text = "Current Position";
            this.ItemForCurrentPosition.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForCurrentEmployer
            // 
            this.ItemForCurrentEmployer.Control = this.CurrentEmployerTextEdit;
            this.ItemForCurrentEmployer.Location = new System.Drawing.Point(369, 72);
            this.ItemForCurrentEmployer.Name = "ItemForCurrentEmployer";
            this.ItemForCurrentEmployer.Size = new System.Drawing.Size(354, 24);
            this.ItemForCurrentEmployer.Text = "Current Employer";
            this.ItemForCurrentEmployer.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemForDateAvailable
            // 
            this.ItemForDateAvailable.Control = this.DateAvailableDateEdit;
            this.ItemForDateAvailable.Location = new System.Drawing.Point(369, 0);
            this.ItemForDateAvailable.Name = "ItemForDateAvailable";
            this.ItemForDateAvailable.Size = new System.Drawing.Size(354, 24);
            this.ItemForDateAvailable.Text = "Date Available";
            this.ItemForDateAvailable.TextSize = new System.Drawing.Size(84, 13);
            // 
            // locAvatar
            // 
            this.locAvatar.Control = this.peAvatar;
            this.locAvatar.Image = global::DXSWI.Properties.Resources.user_male_3;
            this.locAvatar.Location = new System.Drawing.Point(0, 0);
            this.locAvatar.Name = "locAvatar";
            this.locAvatar.Size = new System.Drawing.Size(205, 324);
            this.locAvatar.Text = "Name";
            this.locAvatar.TextLocation = DevExpress.Utils.Locations.Top;
            this.locAvatar.TextSize = new System.Drawing.Size(84, 32);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gcJobOrderPipeline);
            this.groupControl3.Location = new System.Drawing.Point(12, 540);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(976, 133);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Job Order Pipeline";
            // 
            // gcJobOrderPipeline
            // 
            this.gcJobOrderPipeline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcJobOrderPipeline.Location = new System.Drawing.Point(2, 20);
            this.gcJobOrderPipeline.MainView = this.gvJobOrderPipeline;
            this.gcJobOrderPipeline.Name = "gcJobOrderPipeline";
            this.gcJobOrderPipeline.Size = new System.Drawing.Size(972, 111);
            this.gcJobOrderPipeline.TabIndex = 0;
            this.gcJobOrderPipeline.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvJobOrderPipeline,
            this.gridView1});
            // 
            // gvJobOrderPipeline
            // 
            this.gvJobOrderPipeline.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Match,
            this.Title,
            this.Company,
            this.Owner,
            this.Added,
            this.EnterBy,
            this.Status,
            this.Action});
            this.gvJobOrderPipeline.GridControl = this.gcJobOrderPipeline;
            this.gvJobOrderPipeline.Name = "gvJobOrderPipeline";
            // 
            // Match
            // 
            this.Match.Caption = "Match";
            this.Match.Name = "Match";
            this.Match.Visible = true;
            this.Match.VisibleIndex = 0;
            // 
            // Title
            // 
            this.Title.Caption = "Title";
            this.Title.Name = "Title";
            this.Title.Visible = true;
            this.Title.VisibleIndex = 1;
            // 
            // Company
            // 
            this.Company.Caption = "Company";
            this.Company.Name = "Company";
            this.Company.Visible = true;
            this.Company.VisibleIndex = 2;
            // 
            // Owner
            // 
            this.Owner.Caption = "Owner";
            this.Owner.Name = "Owner";
            this.Owner.Visible = true;
            this.Owner.VisibleIndex = 3;
            // 
            // Added
            // 
            this.Added.Caption = "Added";
            this.Added.Name = "Added";
            this.Added.Visible = true;
            this.Added.VisibleIndex = 4;
            // 
            // EnterBy
            // 
            this.EnterBy.Caption = "EnterBy";
            this.EnterBy.Name = "EnterBy";
            this.EnterBy.Visible = true;
            this.EnterBy.VisibleIndex = 5;
            // 
            // Status
            // 
            this.Status.Caption = "Status";
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 6;
            // 
            // Action
            // 
            this.Action.Caption = "Action";
            this.Action.Name = "Action";
            this.Action.Visible = true;
            this.Action.VisibleIndex = 7;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcJobOrderPipeline;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.gcActivities);
            this.groupControl4.Location = new System.Drawing.Point(12, 677);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(976, 190);
            this.groupControl4.TabIndex = 0;
            this.groupControl4.Text = "Activities";
            // 
            // gcActivities
            // 
            this.gcActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcActivities.Location = new System.Drawing.Point(2, 20);
            this.gcActivities.MainView = this.gvActivities;
            this.gcActivities.Name = "gcActivities";
            this.gcActivities.Size = new System.Drawing.Size(972, 168);
            this.gcActivities.TabIndex = 0;
            this.gcActivities.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvActivities,
            this.gridView2});
            // 
            // gvActivities
            // 
            this.gvActivities.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Date,
            this.Type,
            this.Entered,
            this.Regarding,
            this.Notes,
            this.ActionActivities});
            this.gvActivities.GridControl = this.gcActivities;
            this.gvActivities.Name = "gvActivities";
            // 
            // Date
            // 
            this.Date.Caption = "Date";
            this.Date.Name = "Date";
            this.Date.Visible = true;
            this.Date.VisibleIndex = 0;
            // 
            // Type
            // 
            this.Type.Caption = "Type";
            this.Type.Name = "Type";
            this.Type.Visible = true;
            this.Type.VisibleIndex = 1;
            // 
            // Entered
            // 
            this.Entered.Caption = "Entered";
            this.Entered.Name = "Entered";
            this.Entered.Visible = true;
            this.Entered.VisibleIndex = 2;
            // 
            // Regarding
            // 
            this.Regarding.Caption = "Regarding";
            this.Regarding.Name = "Regarding";
            this.Regarding.Visible = true;
            this.Regarding.VisibleIndex = 3;
            // 
            // Notes
            // 
            this.Notes.Caption = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.Visible = true;
            this.Notes.VisibleIndex = 4;
            // 
            // ActionActivities
            // 
            this.ActionActivities.Caption = "Action";
            this.ActionActivities.Name = "ActionActivities";
            this.ActionActivities.Visible = true;
            this.ActionActivities.VisibleIndex = 5;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcActivities;
            this.gridView2.Name = "gridView2";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.flowLayoutPanel1);
            this.groupControl2.Location = new System.Drawing.Point(12, 473);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(976, 63);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Attachments";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(972, 41);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1000, 879);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(980, 461);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.groupControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 461);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(980, 67);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.groupControl3;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 528);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(980, 137);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.groupControl4;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 665);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(980, 194);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupControl2);
            this.layoutControl1.Controls.Add(this.groupControl4);
            this.layoutControl1.Controls.Add(this.groupControl3);
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1000, 879);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.Location = new System.Drawing.Point(100, 138);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(165, 66);
            // 
            // ucCandidateManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucCandidateManager";
            this.Size = new System.Drawing.Size(1000, 879);
            ((System.ComponentModel.ISupportInitialize)(this.swilifecoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swilifecoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondaryEmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkypeIMTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellPhoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkPhoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestTimeToCallTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebSiteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPositionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentEmployerTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeySkillsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPayTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesiredPayTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOBMarriedTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterviewNotesMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiscNotesMemoExEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreatedDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateAvailableDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CanRelocateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAvatar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInterviewNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMiscNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSecondaryEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSkypeIM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCellPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWorkPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWebSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreatedDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBestTimeToCall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForKeySkills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCurrentPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDesiredPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDOBMarried)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CanRelocate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCurrentPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCurrentEmployer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDateAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcJobOrderPipeline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvJobOrderPipeline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private swilifecoreDataSet swilifecoreDataSet;
        private System.Windows.Forms.BindingSource swilifecoreDataSetBindingSource;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.TextEdit SecondaryEmailTextEdit;
        private DevExpress.XtraEditors.TextEdit SkypeIMTextEdit;
        private DevExpress.XtraEditors.TextEdit CellPhoneTextEdit;
        private DevExpress.XtraEditors.TextEdit WorkPhoneTextEdit;
        private DevExpress.XtraEditors.TextEdit BestTimeToCallTextEdit;
        private DevExpress.XtraEditors.TextEdit AddressTextEdit;
        private DevExpress.XtraEditors.TextEdit WebSiteTextEdit;
        private DevExpress.XtraEditors.TextEdit SourceTextEdit;
        private DevExpress.XtraEditors.TextEdit CurrentPositionTextEdit;
        private DevExpress.XtraEditors.TextEdit CurrentEmployerTextEdit;
        private DevExpress.XtraEditors.TextEdit KeySkillsTextEdit;
        private DevExpress.XtraEditors.TextEdit CurrentPayTextEdit;
        private DevExpress.XtraEditors.TextEdit DesiredPayTextEdit;
        private DevExpress.XtraEditors.TextEdit DOBMarriedTextEdit;
        private DevExpress.XtraEditors.MemoEdit InterviewNotesMemoEdit;
        private DevExpress.XtraEditors.TextEdit UserIdTextEdit;
        private DevExpress.XtraEditors.MemoEdit MiscNotesMemoExEdit;
        private DevExpress.XtraEditors.TextEdit CreatedDateDateEdit;
        private DevExpress.XtraEditors.TextEdit DateAvailableDateEdit;
        private DevExpress.XtraEditors.TextEdit CanRelocateTextEdit;
        private DevExpress.XtraEditors.PictureEdit peAvatar;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCellPhone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForKeySkills;
        private DevExpress.XtraLayout.LayoutControlItem ItemForInterviewNotes;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMiscNotes;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSecondaryEmail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSkypeIM;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWorkPhone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBestTimeToCall;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCurrentEmployer;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDateAvailable;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCurrentPay;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDesiredPay;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCreatedDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSource;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUserId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWebSite;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDOBMarried;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCurrentPosition;
        private DevExpress.XtraLayout.LayoutControlItem CanRelocate;
        private DevExpress.XtraLayout.LayoutControlItem locAvatar;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gcJobOrderPipeline;
        private DevExpress.XtraGrid.Views.Grid.GridView gvJobOrderPipeline;
        private DevExpress.XtraGrid.Columns.GridColumn Match;
        private DevExpress.XtraGrid.Columns.GridColumn Title;
        private DevExpress.XtraGrid.Columns.GridColumn Company;
        private DevExpress.XtraGrid.Columns.GridColumn Owner;
        private DevExpress.XtraGrid.Columns.GridColumn Added;
        private DevExpress.XtraGrid.Columns.GridColumn EnterBy;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn Action;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl gcActivities;
        private DevExpress.XtraGrid.Views.Grid.GridView gvActivities;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraGrid.Columns.GridColumn Type;
        private DevExpress.XtraGrid.Columns.GridColumn Entered;
        private DevExpress.XtraGrid.Columns.GridColumn Regarding;
        private DevExpress.XtraGrid.Columns.GridColumn Notes;
        private DevExpress.XtraGrid.Columns.GridColumn ActionActivities;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAddress;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
    }
}
