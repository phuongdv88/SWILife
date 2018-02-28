namespace DXSWI.Forms
{
    partial class dlgCompanyEdit
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
            DevExpress.XtraEditors.FormatConditionRule2ColorScale formatConditionRule2ColorScale1 = new DevExpress.XtraEditors.FormatConditionRule2ColorScale();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgCompanyEdit));
            this.colIsHot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gcJobOrder = new DevExpress.XtraGrid.GridControl();
            this.gvJobOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubmitted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanInPipeLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLink = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcContact = new DevExpress.XtraGrid.GridControl();
            this.gvContact = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCellPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMisc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModified = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sbDownloadAttachment = new DevExpress.XtraEditors.SimpleButton();
            this.sbViewFile = new DevExpress.XtraEditors.SimpleButton();
            this.sbDeleteAttachment = new DevExpress.XtraEditors.SimpleButton();
            this.sbAttachFile = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sliAttachment = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrimaryPhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SecondaryPhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FaxNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CountryOfOriginTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.WebSiteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.KeyTechnologiesTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IndustryComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ABCTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IsActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.CityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.StateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PostalCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IsHotCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.ContractSigingTimeDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.MiscNotesTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.ServiceContractTermsTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.sbOK = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPrimaryPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFaxNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSecondaryPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCity = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForState = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForWebSite = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPostalCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIsActive = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIsHot = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCountryOfOrigin = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForKeyTechnologies = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIndustry = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForABC = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForContractSigingTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForServiceContractTerms = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMiscNotes = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcJobOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvJobOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliAttachment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimaryPhoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondaryPhoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaxNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryOfOriginTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebSiteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyTechnologiesTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndustryComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ABCTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostalCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsHotCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractSigingTimeDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractSigingTimeDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiscNotesTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceContractTermsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrimaryPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFaxNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSecondaryPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWebSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPostalCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsHot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountryOfOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForKeyTechnologies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIndustry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForABC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContractSigingTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForServiceContractTerms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMiscNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // colIsHot
            // 
            this.colIsHot.Caption = "Is Hot";
            this.colIsHot.FieldName = "IsHot";
            this.colIsHot.Name = "colIsHot";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Title";
            this.gridColumn1.FieldName = "Title";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 186;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gcJobOrder);
            this.dataLayoutControl1.Controls.Add(this.gcContact);
            this.dataLayoutControl1.Controls.Add(this.groupControl1);
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PrimaryPhoneTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SecondaryPhoneTextEdit);
            this.dataLayoutControl1.Controls.Add(this.FaxNumberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AddressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CountryOfOriginTextEdit);
            this.dataLayoutControl1.Controls.Add(this.WebSiteTextEdit);
            this.dataLayoutControl1.Controls.Add(this.KeyTechnologiesTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IndustryComboBoxEdit);
            this.dataLayoutControl1.Controls.Add(this.ABCTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IsActiveCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.CityTextEdit);
            this.dataLayoutControl1.Controls.Add(this.StateTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PostalCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IsHotCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.ContractSigingTimeDateEdit);
            this.dataLayoutControl1.Controls.Add(this.MiscNotesTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ServiceContractTermsTextEdit);
            this.dataLayoutControl1.Controls.Add(this.sbOK);
            this.dataLayoutControl1.Controls.Add(this.sbCancel);
            this.dataLayoutControl1.DataSource = this.companyBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(985, 683);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gcJobOrder
            // 
            this.gcJobOrder.Location = new System.Drawing.Point(24, 521);
            this.gcJobOrder.MainView = this.gvJobOrder;
            this.gcJobOrder.Name = "gcJobOrder";
            this.gcJobOrder.Size = new System.Drawing.Size(937, 112);
            this.gcJobOrder.TabIndex = 33;
            this.gcJobOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvJobOrder});
            // 
            // gvJobOrder
            // 
            this.gvJobOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colType,
            this.colStatus,
            this.colAge,
            this.colSubmitted,
            this.colCanInPipeLine,
            this.gridColumn2,
            this.gridColumn3,
            this.colLink,
            this.colIsHot});
            gridFormatRule1.Column = this.colIsHot;
            gridFormatRule1.ColumnApplyTo = this.gridColumn1;
            gridFormatRule1.Name = "Format0";
            formatConditionRule2ColorScale1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            formatConditionRule2ColorScale1.MaximumColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRule2ColorScale1.MaximumType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRule2ColorScale1.MinimumType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRule2ColorScale1.PredefinedName = "White, Green";
            gridFormatRule1.Rule = formatConditionRule2ColorScale1;
            this.gvJobOrder.FormatRules.Add(gridFormatRule1);
            this.gvJobOrder.GridControl = this.gcJobOrder;
            this.gvJobOrder.Name = "gvJobOrder";
            this.gvJobOrder.OptionsBehavior.Editable = false;
            this.gvJobOrder.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvJobOrder.OptionsView.ShowGroupPanel = false;
            this.gvJobOrder.DoubleClick += new System.EventHandler(this.gvJobOrder_DoubleClick);
            // 
            // colType
            // 
            this.colType.Caption = "Type";
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 1;
            this.colType.Width = 48;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 2;
            this.colStatus.Width = 50;
            // 
            // colAge
            // 
            this.colAge.Caption = "Days Old";
            this.colAge.FieldName = "DaysOld";
            this.colAge.Name = "colAge";
            this.colAge.Visible = true;
            this.colAge.VisibleIndex = 3;
            this.colAge.Width = 56;
            // 
            // colSubmitted
            // 
            this.colSubmitted.Caption = "Submitted";
            this.colSubmitted.FieldName = "Submitted";
            this.colSubmitted.Name = "colSubmitted";
            this.colSubmitted.Visible = true;
            this.colSubmitted.VisibleIndex = 4;
            this.colSubmitted.Width = 80;
            // 
            // colCanInPipeLine
            // 
            this.colCanInPipeLine.Caption = "Pipe Line";
            this.colCanInPipeLine.FieldName = "CanInPipeLine";
            this.colCanInPipeLine.Name = "colCanInPipeLine";
            this.colCanInPipeLine.Visible = true;
            this.colCanInPipeLine.VisibleIndex = 5;
            this.colCanInPipeLine.Width = 65;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Owner";
            this.gridColumn2.FieldName = "Owner";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            this.gridColumn2.Width = 54;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "City";
            this.gridColumn3.FieldName = "City";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 7;
            this.gridColumn3.Width = 49;
            // 
            // colLink
            // 
            this.colLink.Caption = "Link";
            this.colLink.FieldName = "Weblink";
            this.colLink.Name = "colLink";
            this.colLink.Visible = true;
            this.colLink.VisibleIndex = 8;
            this.colLink.Width = 137;
            // 
            // gcContact
            // 
            this.gcContact.Location = new System.Drawing.Point(24, 405);
            this.gcContact.MainView = this.gvContact;
            this.gcContact.Name = "gcContact";
            this.gcContact.Size = new System.Drawing.Size(937, 70);
            this.gcContact.TabIndex = 32;
            this.gcContact.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvContact});
            // 
            // gvContact
            // 
            this.gvContact.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFirstName,
            this.colLastName,
            this.colCellPhone,
            this.colTitle,
            this.colEmail,
            this.colCity,
            this.colMisc,
            this.colOwner,
            this.colModified});
            this.gvContact.GridControl = this.gcContact;
            this.gvContact.Name = "gvContact";
            this.gvContact.OptionsBehavior.Editable = false;
            this.gvContact.OptionsBehavior.ReadOnly = true;
            this.gvContact.OptionsView.ShowGroupPanel = false;
            this.gvContact.DoubleClick += new System.EventHandler(this.gvContact_DoubleClick);
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "First Name";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 0;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Last Name";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 1;
            // 
            // colCellPhone
            // 
            this.colCellPhone.Caption = "Cell Phone";
            this.colCellPhone.FieldName = "CellPhone";
            this.colCellPhone.Name = "colCellPhone";
            this.colCellPhone.Visible = true;
            this.colCellPhone.VisibleIndex = 2;
            // 
            // colTitle
            // 
            this.colTitle.Caption = "Title";
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 3;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            // 
            // colCity
            // 
            this.colCity.Caption = "City";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 5;
            // 
            // colMisc
            // 
            this.colMisc.Caption = "Misc";
            this.colMisc.FieldName = "MiscNotes";
            this.colMisc.Name = "colMisc";
            this.colMisc.Visible = true;
            this.colMisc.VisibleIndex = 6;
            // 
            // colOwner
            // 
            this.colOwner.Caption = "Owner";
            this.colOwner.FieldName = "Owner";
            this.colOwner.Name = "colOwner";
            this.colOwner.Visible = true;
            this.colOwner.VisibleIndex = 7;
            // 
            // colModified
            // 
            this.colModified.Caption = "Modified";
            this.colModified.FieldName = "Modified";
            this.colModified.Name = "colModified";
            this.colModified.Visible = true;
            this.colModified.VisibleIndex = 8;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 303);
            this.groupControl1.MaximumSize = new System.Drawing.Size(0, 70);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(961, 68);
            this.groupControl1.TabIndex = 31;
            this.groupControl1.Text = "Contract Attachment";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbDownloadAttachment);
            this.layoutControl1.Controls.Add(this.sbViewFile);
            this.layoutControl1.Controls.Add(this.sbDeleteAttachment);
            this.layoutControl1.Controls.Add(this.sbAttachFile);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 20);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup5;
            this.layoutControl1.Size = new System.Drawing.Size(957, 46);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sbDownloadAttachment
            // 
            this.sbDownloadAttachment.Enabled = false;
            this.sbDownloadAttachment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbDownloadAttachment.ImageOptions.Image")));
            this.sbDownloadAttachment.Location = new System.Drawing.Point(859, 12);
            this.sbDownloadAttachment.Name = "sbDownloadAttachment";
            this.sbDownloadAttachment.Size = new System.Drawing.Size(86, 22);
            this.sbDownloadAttachment.StyleController = this.layoutControl1;
            this.sbDownloadAttachment.TabIndex = 32;
            this.sbDownloadAttachment.Text = "Download";
            this.sbDownloadAttachment.Click += new System.EventHandler(this.sbDownloadAttachment_Click);
            // 
            // sbViewFile
            // 
            this.sbViewFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbViewFile.ImageOptions.Image")));
            this.sbViewFile.Location = new System.Drawing.Point(767, 12);
            this.sbViewFile.Name = "sbViewFile";
            this.sbViewFile.Size = new System.Drawing.Size(88, 22);
            this.sbViewFile.StyleController = this.layoutControl1;
            this.sbViewFile.TabIndex = 31;
            this.sbViewFile.Text = "View";
            this.sbViewFile.Click += new System.EventHandler(this.sbViewFile_Click);
            // 
            // sbDeleteAttachment
            // 
            this.sbDeleteAttachment.Enabled = false;
            this.sbDeleteAttachment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbDeleteAttachment.ImageOptions.Image")));
            this.sbDeleteAttachment.Location = new System.Drawing.Point(670, 12);
            this.sbDeleteAttachment.Name = "sbDeleteAttachment";
            this.sbDeleteAttachment.Size = new System.Drawing.Size(93, 22);
            this.sbDeleteAttachment.StyleController = this.layoutControl1;
            this.sbDeleteAttachment.TabIndex = 27;
            this.sbDeleteAttachment.Text = "Delete";
            this.sbDeleteAttachment.Click += new System.EventHandler(this.sbDeleteAttachment_Click);
            // 
            // sbAttachFile
            // 
            this.sbAttachFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAttachFile.ImageOptions.Image")));
            this.sbAttachFile.Location = new System.Drawing.Point(12, 12);
            this.sbAttachFile.Name = "sbAttachFile";
            this.sbAttachFile.Size = new System.Drawing.Size(87, 22);
            this.sbAttachFile.StyleController = this.layoutControl1;
            this.sbAttachFile.TabIndex = 26;
            this.sbAttachFile.Text = "Attach File";
            this.sbAttachFile.Click += new System.EventHandler(this.sbAttachFile_Click);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup5.GroupBordersVisible = false;
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.sliAttachment,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem4});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup5.Name = "Root";
            this.layoutControlGroup5.Size = new System.Drawing.Size(957, 46);
            this.layoutControlGroup5.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbAttachFile;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(91, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // sliAttachment
            // 
            this.sliAttachment.AllowHotTrack = false;
            this.sliAttachment.CustomizationFormText = "No file is chosen";
            this.sliAttachment.Location = new System.Drawing.Point(91, 0);
            this.sliAttachment.Name = "sliAttachment";
            this.sliAttachment.Size = new System.Drawing.Size(567, 26);
            this.sliAttachment.Text = "No file is chosen";
            this.sliAttachment.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbDeleteAttachment;
            this.layoutControlItem3.Location = new System.Drawing.Point(658, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(97, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.sbViewFile;
            this.layoutControlItem6.Location = new System.Drawing.Point(755, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(92, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sbDownloadAttachment;
            this.layoutControlItem4.Location = new System.Drawing.Point(847, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(90, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "Name", true));
            this.NameTextEdit.Location = new System.Drawing.Point(139, 42);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(654, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 4;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(SWIBLL.Models.Company);
            // 
            // PrimaryPhoneTextEdit
            // 
            this.PrimaryPhoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "PrimaryPhone", true));
            this.PrimaryPhoneTextEdit.Location = new System.Drawing.Point(139, 66);
            this.PrimaryPhoneTextEdit.Name = "PrimaryPhoneTextEdit";
            this.PrimaryPhoneTextEdit.Size = new System.Drawing.Size(138, 20);
            this.PrimaryPhoneTextEdit.StyleController = this.dataLayoutControl1;
            this.PrimaryPhoneTextEdit.TabIndex = 5;
            // 
            // SecondaryPhoneTextEdit
            // 
            this.SecondaryPhoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "SecondaryPhone", true));
            this.SecondaryPhoneTextEdit.Location = new System.Drawing.Point(396, 66);
            this.SecondaryPhoneTextEdit.Name = "SecondaryPhoneTextEdit";
            this.SecondaryPhoneTextEdit.Size = new System.Drawing.Size(136, 20);
            this.SecondaryPhoneTextEdit.StyleController = this.dataLayoutControl1;
            this.SecondaryPhoneTextEdit.TabIndex = 6;
            // 
            // FaxNumberTextEdit
            // 
            this.FaxNumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "FaxNumber", true));
            this.FaxNumberTextEdit.Location = new System.Drawing.Point(651, 66);
            this.FaxNumberTextEdit.Name = "FaxNumberTextEdit";
            this.FaxNumberTextEdit.Size = new System.Drawing.Size(142, 20);
            this.FaxNumberTextEdit.StyleController = this.dataLayoutControl1;
            this.FaxNumberTextEdit.TabIndex = 7;
            // 
            // AddressTextEdit
            // 
            this.AddressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "Address", true));
            this.AddressTextEdit.Location = new System.Drawing.Point(139, 90);
            this.AddressTextEdit.Name = "AddressTextEdit";
            this.AddressTextEdit.Size = new System.Drawing.Size(138, 20);
            this.AddressTextEdit.StyleController = this.dataLayoutControl1;
            this.AddressTextEdit.TabIndex = 8;
            // 
            // CountryOfOriginTextEdit
            // 
            this.CountryOfOriginTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "CountryOfOrigin", true));
            this.CountryOfOriginTextEdit.Location = new System.Drawing.Point(396, 114);
            this.CountryOfOriginTextEdit.Name = "CountryOfOriginTextEdit";
            this.CountryOfOriginTextEdit.Size = new System.Drawing.Size(136, 20);
            this.CountryOfOriginTextEdit.StyleController = this.dataLayoutControl1;
            this.CountryOfOriginTextEdit.TabIndex = 9;
            // 
            // WebSiteTextEdit
            // 
            this.WebSiteTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "WebSite", true));
            this.WebSiteTextEdit.Location = new System.Drawing.Point(139, 114);
            this.WebSiteTextEdit.Name = "WebSiteTextEdit";
            this.WebSiteTextEdit.Size = new System.Drawing.Size(138, 20);
            this.WebSiteTextEdit.StyleController = this.dataLayoutControl1;
            this.WebSiteTextEdit.TabIndex = 10;
            // 
            // KeyTechnologiesTextEdit
            // 
            this.KeyTechnologiesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "KeyTechnologies", true));
            this.KeyTechnologiesTextEdit.Location = new System.Drawing.Point(139, 138);
            this.KeyTechnologiesTextEdit.Name = "KeyTechnologiesTextEdit";
            this.KeyTechnologiesTextEdit.Size = new System.Drawing.Size(138, 20);
            this.KeyTechnologiesTextEdit.StyleController = this.dataLayoutControl1;
            this.KeyTechnologiesTextEdit.TabIndex = 11;
            // 
            // IndustryComboBoxEdit
            // 
            this.IndustryComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "Industry", true));
            this.IndustryComboBoxEdit.Location = new System.Drawing.Point(396, 138);
            this.IndustryComboBoxEdit.Name = "IndustryComboBoxEdit";
            this.IndustryComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IndustryComboBoxEdit.Properties.Items.AddRange(new object[] {
            "Computer Game",
            "Computer Hardware",
            "Computer Networking",
            "Sofware",
            "Consumer Electronics",
            "IT and Services",
            "Internet",
            "Nanotechnology",
            "Network Security",
            "Online Media",
            "Semiconductors",
            "Telecommunications",
            "End users",
            "Biotechnology",
            "Electrical/ Electrical Manufacturing",
            "Wireless",
            "Other"});
            this.IndustryComboBoxEdit.Size = new System.Drawing.Size(136, 20);
            this.IndustryComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.IndustryComboBoxEdit.TabIndex = 13;
            // 
            // ABCTextEdit
            // 
            this.ABCTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "ABC", true));
            this.ABCTextEdit.Location = new System.Drawing.Point(904, 138);
            this.ABCTextEdit.Name = "ABCTextEdit";
            this.ABCTextEdit.Size = new System.Drawing.Size(57, 20);
            this.ABCTextEdit.StyleController = this.dataLayoutControl1;
            this.ABCTextEdit.TabIndex = 14;
            // 
            // IsActiveCheckEdit
            // 
            this.IsActiveCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "IsActive", true));
            this.IsActiveCheckEdit.Location = new System.Drawing.Point(797, 42);
            this.IsActiveCheckEdit.Name = "IsActiveCheckEdit";
            this.IsActiveCheckEdit.Properties.Caption = "Is Active";
            this.IsActiveCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.IsActiveCheckEdit.Size = new System.Drawing.Size(164, 19);
            this.IsActiveCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsActiveCheckEdit.TabIndex = 15;
            // 
            // CityTextEdit
            // 
            this.CityTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "City", true));
            this.CityTextEdit.Location = new System.Drawing.Point(396, 90);
            this.CityTextEdit.Name = "CityTextEdit";
            this.CityTextEdit.Size = new System.Drawing.Size(136, 20);
            this.CityTextEdit.StyleController = this.dataLayoutControl1;
            this.CityTextEdit.TabIndex = 17;
            // 
            // StateTextEdit
            // 
            this.StateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "State", true));
            this.StateTextEdit.Location = new System.Drawing.Point(651, 90);
            this.StateTextEdit.Name = "StateTextEdit";
            this.StateTextEdit.Size = new System.Drawing.Size(310, 20);
            this.StateTextEdit.StyleController = this.dataLayoutControl1;
            this.StateTextEdit.TabIndex = 18;
            // 
            // PostalCodeTextEdit
            // 
            this.PostalCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "PostalCode", true));
            this.PostalCodeTextEdit.Location = new System.Drawing.Point(651, 114);
            this.PostalCodeTextEdit.Name = "PostalCodeTextEdit";
            this.PostalCodeTextEdit.Size = new System.Drawing.Size(310, 20);
            this.PostalCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.PostalCodeTextEdit.TabIndex = 19;
            // 
            // IsHotCheckEdit
            // 
            this.IsHotCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "IsHot", true));
            this.IsHotCheckEdit.Location = new System.Drawing.Point(797, 66);
            this.IsHotCheckEdit.Name = "IsHotCheckEdit";
            this.IsHotCheckEdit.Properties.Caption = "Is Hot";
            this.IsHotCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.IsHotCheckEdit.Size = new System.Drawing.Size(164, 19);
            this.IsHotCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsHotCheckEdit.TabIndex = 21;
            // 
            // ContractSigingTimeDateEdit
            // 
            this.ContractSigingTimeDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "ContractSigingTime", true));
            this.ContractSigingTimeDateEdit.EditValue = null;
            this.ContractSigingTimeDateEdit.Location = new System.Drawing.Point(651, 138);
            this.ContractSigingTimeDateEdit.Name = "ContractSigingTimeDateEdit";
            this.ContractSigingTimeDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ContractSigingTimeDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ContractSigingTimeDateEdit.Size = new System.Drawing.Size(134, 20);
            this.ContractSigingTimeDateEdit.StyleController = this.dataLayoutControl1;
            this.ContractSigingTimeDateEdit.TabIndex = 22;
            // 
            // MiscNotesTextEdit
            // 
            this.MiscNotesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "MiscNotes", true));
            this.MiscNotesTextEdit.Location = new System.Drawing.Point(486, 178);
            this.MiscNotesTextEdit.Name = "MiscNotesTextEdit";
            this.MiscNotesTextEdit.Size = new System.Drawing.Size(475, 109);
            this.MiscNotesTextEdit.StyleController = this.dataLayoutControl1;
            this.MiscNotesTextEdit.TabIndex = 16;
            // 
            // ServiceContractTermsTextEdit
            // 
            this.ServiceContractTermsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "ServiceContractTerms", true));
            this.ServiceContractTermsTextEdit.Location = new System.Drawing.Point(24, 178);
            this.ServiceContractTermsTextEdit.Name = "ServiceContractTermsTextEdit";
            this.ServiceContractTermsTextEdit.Size = new System.Drawing.Size(458, 109);
            this.ServiceContractTermsTextEdit.StyleController = this.dataLayoutControl1;
            this.ServiceContractTermsTextEdit.TabIndex = 12;
            // 
            // sbOK
            // 
            this.sbOK.Location = new System.Drawing.Point(738, 649);
            this.sbOK.Name = "sbOK";
            this.sbOK.Size = new System.Drawing.Size(113, 22);
            this.sbOK.StyleController = this.dataLayoutControl1;
            this.sbOK.TabIndex = 28;
            this.sbOK.Text = "OK";
            this.sbOK.Click += new System.EventHandler(this.sbOK_Click);
            // 
            // sbCancel
            // 
            this.sbCancel.Location = new System.Drawing.Point(855, 649);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(118, 22);
            this.sbCancel.StyleController = this.dataLayoutControl1;
            this.sbCancel.TabIndex = 29;
            this.sbCancel.Text = "Exit";
            this.sbCancel.Click += new System.EventHandler(this.sbCancel_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(985, 683);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlGroup4,
            this.layoutControlGroup6});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(965, 663);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForName,
            this.ItemForPrimaryPhone,
            this.ItemForFaxNumber,
            this.ItemForAddress,
            this.ItemForSecondaryPhone,
            this.ItemForCity,
            this.ItemForState,
            this.ItemForWebSite,
            this.ItemForPostalCode,
            this.ItemForIsActive,
            this.ItemForIsHot,
            this.ItemForCountryOfOrigin,
            this.ItemForKeyTechnologies,
            this.ItemForIndustry,
            this.ItemForABC,
            this.ItemForContractSigingTime,
            this.ItemForServiceContractTerms,
            this.ItemForMiscNotes});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(965, 291);
            this.layoutControlGroup3.Text = "Information";
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 0);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(773, 24);
            this.ItemForName.Text = "Name (*)";
            this.ItemForName.TextSize = new System.Drawing.Size(112, 13);
            // 
            // ItemForPrimaryPhone
            // 
            this.ItemForPrimaryPhone.Control = this.PrimaryPhoneTextEdit;
            this.ItemForPrimaryPhone.Location = new System.Drawing.Point(0, 24);
            this.ItemForPrimaryPhone.Name = "ItemForPrimaryPhone";
            this.ItemForPrimaryPhone.Size = new System.Drawing.Size(257, 24);
            this.ItemForPrimaryPhone.Text = "Primary Phone";
            this.ItemForPrimaryPhone.TextSize = new System.Drawing.Size(112, 13);
            // 
            // ItemForFaxNumber
            // 
            this.ItemForFaxNumber.Control = this.FaxNumberTextEdit;
            this.ItemForFaxNumber.Location = new System.Drawing.Point(512, 24);
            this.ItemForFaxNumber.Name = "ItemForFaxNumber";
            this.ItemForFaxNumber.Size = new System.Drawing.Size(261, 24);
            this.ItemForFaxNumber.Text = "Fax Number";
            this.ItemForFaxNumber.TextSize = new System.Drawing.Size(112, 13);
            // 
            // ItemForAddress
            // 
            this.ItemForAddress.Control = this.AddressTextEdit;
            this.ItemForAddress.Location = new System.Drawing.Point(0, 48);
            this.ItemForAddress.Name = "ItemForAddress";
            this.ItemForAddress.Size = new System.Drawing.Size(257, 24);
            this.ItemForAddress.Text = "Address";
            this.ItemForAddress.TextSize = new System.Drawing.Size(112, 13);
            // 
            // ItemForSecondaryPhone
            // 
            this.ItemForSecondaryPhone.Control = this.SecondaryPhoneTextEdit;
            this.ItemForSecondaryPhone.Location = new System.Drawing.Point(257, 24);
            this.ItemForSecondaryPhone.Name = "ItemForSecondaryPhone";
            this.ItemForSecondaryPhone.Size = new System.Drawing.Size(255, 24);
            this.ItemForSecondaryPhone.Text = "Secondary Phone";
            this.ItemForSecondaryPhone.TextSize = new System.Drawing.Size(112, 13);
            // 
            // ItemForCity
            // 
            this.ItemForCity.Control = this.CityTextEdit;
            this.ItemForCity.Location = new System.Drawing.Point(257, 48);
            this.ItemForCity.Name = "ItemForCity";
            this.ItemForCity.Size = new System.Drawing.Size(255, 24);
            this.ItemForCity.Text = "City";
            this.ItemForCity.TextSize = new System.Drawing.Size(112, 13);
            // 
            // ItemForState
            // 
            this.ItemForState.Control = this.StateTextEdit;
            this.ItemForState.Location = new System.Drawing.Point(512, 48);
            this.ItemForState.Name = "ItemForState";
            this.ItemForState.Size = new System.Drawing.Size(429, 24);
            this.ItemForState.Text = "State";
            this.ItemForState.TextSize = new System.Drawing.Size(112, 13);
            // 
            // ItemForWebSite
            // 
            this.ItemForWebSite.Control = this.WebSiteTextEdit;
            this.ItemForWebSite.Location = new System.Drawing.Point(0, 72);
            this.ItemForWebSite.Name = "ItemForWebSite";
            this.ItemForWebSite.Size = new System.Drawing.Size(257, 24);
            this.ItemForWebSite.Text = "Web Site";
            this.ItemForWebSite.TextSize = new System.Drawing.Size(112, 13);
            // 
            // ItemForPostalCode
            // 
            this.ItemForPostalCode.Control = this.PostalCodeTextEdit;
            this.ItemForPostalCode.Location = new System.Drawing.Point(512, 72);
            this.ItemForPostalCode.Name = "ItemForPostalCode";
            this.ItemForPostalCode.Size = new System.Drawing.Size(429, 24);
            this.ItemForPostalCode.Text = "Postal Code";
            this.ItemForPostalCode.TextSize = new System.Drawing.Size(112, 13);
            // 
            // ItemForIsActive
            // 
            this.ItemForIsActive.Control = this.IsActiveCheckEdit;
            this.ItemForIsActive.Location = new System.Drawing.Point(773, 0);
            this.ItemForIsActive.Name = "ItemForIsActive";
            this.ItemForIsActive.Size = new System.Drawing.Size(168, 24);
            this.ItemForIsActive.Text = "Is Active";
            this.ItemForIsActive.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIsActive.TextVisible = false;
            // 
            // ItemForIsHot
            // 
            this.ItemForIsHot.Control = this.IsHotCheckEdit;
            this.ItemForIsHot.Location = new System.Drawing.Point(773, 24);
            this.ItemForIsHot.Name = "ItemForIsHot";
            this.ItemForIsHot.Size = new System.Drawing.Size(168, 24);
            this.ItemForIsHot.Text = "Is Hot";
            this.ItemForIsHot.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIsHot.TextVisible = false;
            // 
            // ItemForCountryOfOrigin
            // 
            this.ItemForCountryOfOrigin.Control = this.CountryOfOriginTextEdit;
            this.ItemForCountryOfOrigin.Location = new System.Drawing.Point(257, 72);
            this.ItemForCountryOfOrigin.Name = "ItemForCountryOfOrigin";
            this.ItemForCountryOfOrigin.Size = new System.Drawing.Size(255, 24);
            this.ItemForCountryOfOrigin.Text = "Country Of Origin";
            this.ItemForCountryOfOrigin.TextSize = new System.Drawing.Size(112, 13);
            // 
            // ItemForKeyTechnologies
            // 
            this.ItemForKeyTechnologies.Control = this.KeyTechnologiesTextEdit;
            this.ItemForKeyTechnologies.Location = new System.Drawing.Point(0, 96);
            this.ItemForKeyTechnologies.Name = "ItemForKeyTechnologies";
            this.ItemForKeyTechnologies.Size = new System.Drawing.Size(257, 24);
            this.ItemForKeyTechnologies.Text = "Key Technologies";
            this.ItemForKeyTechnologies.TextSize = new System.Drawing.Size(112, 13);
            // 
            // ItemForIndustry
            // 
            this.ItemForIndustry.Control = this.IndustryComboBoxEdit;
            this.ItemForIndustry.Location = new System.Drawing.Point(257, 96);
            this.ItemForIndustry.Name = "ItemForIndustry";
            this.ItemForIndustry.Size = new System.Drawing.Size(255, 24);
            this.ItemForIndustry.Text = "Industry";
            this.ItemForIndustry.TextSize = new System.Drawing.Size(112, 13);
            // 
            // ItemForABC
            // 
            this.ItemForABC.Control = this.ABCTextEdit;
            this.ItemForABC.Location = new System.Drawing.Point(765, 96);
            this.ItemForABC.Name = "ItemForABC";
            this.ItemForABC.Size = new System.Drawing.Size(176, 24);
            this.ItemForABC.Text = "ABC";
            this.ItemForABC.TextSize = new System.Drawing.Size(112, 13);
            // 
            // ItemForContractSigingTime
            // 
            this.ItemForContractSigingTime.Control = this.ContractSigingTimeDateEdit;
            this.ItemForContractSigingTime.Location = new System.Drawing.Point(512, 96);
            this.ItemForContractSigingTime.Name = "ItemForContractSigingTime";
            this.ItemForContractSigingTime.Size = new System.Drawing.Size(253, 24);
            this.ItemForContractSigingTime.Text = "Contract Siging Time";
            this.ItemForContractSigingTime.TextSize = new System.Drawing.Size(112, 13);
            // 
            // ItemForServiceContractTerms
            // 
            this.ItemForServiceContractTerms.Control = this.ServiceContractTermsTextEdit;
            this.ItemForServiceContractTerms.Location = new System.Drawing.Point(0, 120);
            this.ItemForServiceContractTerms.Name = "ItemForServiceContractTerms";
            this.ItemForServiceContractTerms.Size = new System.Drawing.Size(462, 129);
            this.ItemForServiceContractTerms.Text = "Service Contract Terms";
            this.ItemForServiceContractTerms.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForServiceContractTerms.TextSize = new System.Drawing.Size(112, 13);
            // 
            // ItemForMiscNotes
            // 
            this.ItemForMiscNotes.Control = this.MiscNotesTextEdit;
            this.ItemForMiscNotes.Location = new System.Drawing.Point(462, 120);
            this.ItemForMiscNotes.Name = "ItemForMiscNotes";
            this.ItemForMiscNotes.Size = new System.Drawing.Size(479, 129);
            this.ItemForMiscNotes.Text = "Misc Notes";
            this.ItemForMiscNotes.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForMiscNotes.TextSize = new System.Drawing.Size(112, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 637);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(726, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.sbOK;
            this.layoutControlItem1.Location = new System.Drawing.Point(726, 637);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(117, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sbCancel;
            this.layoutControlItem5.Location = new System.Drawing.Point(843, 637);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(122, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.groupControl1;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 291);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(965, 72);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 479);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(965, 158);
            this.layoutControlGroup4.Text = "Job Orders";
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.gcJobOrder;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(941, 116);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 363);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(965, 116);
            this.layoutControlGroup6.Text = "Contacts";
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.gcContact;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(941, 74);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // dlgCompanyEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 683);
            this.Controls.Add(this.dataLayoutControl1);
            this.KeyPreview = true;
            this.Name = "dlgCompanyEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Edit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dlgCompanyEdit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcJobOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvJobOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliAttachment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimaryPhoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondaryPhoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaxNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryOfOriginTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebSiteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyTechnologiesTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndustryComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ABCTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostalCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsHotCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractSigingTimeDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractSigingTimeDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiscNotesTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceContractTermsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrimaryPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFaxNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSecondaryPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWebSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPostalCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsHot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountryOfOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForKeyTechnologies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIndustry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForABC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContractSigingTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForServiceContractTerms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMiscNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DevExpress.XtraEditors.TextEdit PrimaryPhoneTextEdit;
        private DevExpress.XtraEditors.TextEdit SecondaryPhoneTextEdit;
        private DevExpress.XtraEditors.TextEdit FaxNumberTextEdit;
        private DevExpress.XtraEditors.TextEdit AddressTextEdit;
        private DevExpress.XtraEditors.TextEdit CountryOfOriginTextEdit;
        private DevExpress.XtraEditors.TextEdit WebSiteTextEdit;
        private DevExpress.XtraEditors.TextEdit KeyTechnologiesTextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit IndustryComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit ABCTextEdit;
        private DevExpress.XtraEditors.CheckEdit IsActiveCheckEdit;
        private DevExpress.XtraEditors.TextEdit CityTextEdit;
        private DevExpress.XtraEditors.TextEdit StateTextEdit;
        private DevExpress.XtraEditors.TextEdit PostalCodeTextEdit;
        private DevExpress.XtraEditors.CheckEdit IsHotCheckEdit;
        private DevExpress.XtraEditors.DateEdit ContractSigingTimeDateEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPrimaryPhone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSecondaryPhone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFaxNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCountryOfOrigin;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWebSite;
        private DevExpress.XtraLayout.LayoutControlItem ItemForKeyTechnologies;
        private DevExpress.XtraLayout.LayoutControlItem ItemForServiceContractTerms;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIndustry;
        private DevExpress.XtraLayout.LayoutControlItem ItemForABC;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsActive;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMiscNotes;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCity;
        private DevExpress.XtraLayout.LayoutControlItem ItemForState;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPostalCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsHot;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContractSigingTime;
        private DevExpress.XtraEditors.MemoEdit MiscNotesTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraEditors.MemoEdit ServiceContractTermsTextEdit;
        private DevExpress.XtraEditors.SimpleButton sbOK;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraEditors.SimpleButton sbAttachFile;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton sbDownloadAttachment;
        private DevExpress.XtraEditors.SimpleButton sbViewFile;
        private DevExpress.XtraEditors.SimpleButton sbDeleteAttachment;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.SimpleLabelItem sliAttachment;
        private DevExpress.XtraGrid.GridControl gcContact;
        private DevExpress.XtraGrid.Views.Grid.GridView gvContact;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colCellPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colMisc;
        private DevExpress.XtraGrid.Columns.GridColumn colOwner;
        private DevExpress.XtraGrid.Columns.GridColumn colModified;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.GridControl gcJobOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gvJobOrder;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colAge;
        private DevExpress.XtraGrid.Columns.GridColumn colSubmitted;
        private DevExpress.XtraGrid.Columns.GridColumn colCanInPipeLine;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colLink;
        private DevExpress.XtraGrid.Columns.GridColumn colIsHot;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
    }
}