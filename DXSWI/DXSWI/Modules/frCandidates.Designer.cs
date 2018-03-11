namespace DXSWI.Modules
{
    partial class frCandidates
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleIconSet formatConditionRuleIconSet1 = new DevExpress.XtraEditors.FormatConditionRuleIconSet();
            DevExpress.XtraEditors.FormatConditionIconSet formatConditionIconSet1 = new DevExpress.XtraEditors.FormatConditionIconSet();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon1 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon2 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon3 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.viewWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gcCandidates = new DevExpress.XtraGrid.GridControl();
            this.gvCandidates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeySkills = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModified = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentEmployer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesiredPay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCellPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCandidates)).BeginInit();
            this.SuspendLayout();
            // 
            // colState
            // 
            this.colState.Caption = "State";
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "First Name";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 0;
            this.colFirstName.Width = 99;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.viewWebsiteToolStripMenuItem,
            this.refreshTableToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 126);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::DXSWI.Properties.Resources.Actionsusergroupnew1;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.newToolStripMenuItem.Text = "New Candidate";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DXSWI.Properties.Resources.Actionsusergroupproperties1;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.editToolStripMenuItem.Text = "Edit Candidate";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DXSWI.Properties.Resources.Actionsusergroupdelete1;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteToolStripMenuItem.Text = "Delete Candidate";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
            // 
            // viewWebsiteToolStripMenuItem
            // 
            this.viewWebsiteToolStripMenuItem.Image = global::DXSWI.Properties.Resources.Linkedinicon1;
            this.viewWebsiteToolStripMenuItem.Name = "viewWebsiteToolStripMenuItem";
            this.viewWebsiteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.viewWebsiteToolStripMenuItem.Text = "View Website";
            this.viewWebsiteToolStripMenuItem.Click += new System.EventHandler(this.viewWebsiteToolStripMenuItem_Click);
            // 
            // refreshTableToolStripMenuItem
            // 
            this.refreshTableToolStripMenuItem.Image = global::DXSWI.Properties.Resources.ButtonRefresh1;
            this.refreshTableToolStripMenuItem.Name = "refreshTableToolStripMenuItem";
            this.refreshTableToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.refreshTableToolStripMenuItem.Text = "Refresh Table";
            this.refreshTableToolStripMenuItem.Click += new System.EventHandler(this.refreshTableToolStripMenuItem_Click);
            // 
            // gcCandidates
            // 
            this.gcCandidates.ContextMenuStrip = this.contextMenuStrip1;
            this.gcCandidates.DataMember = "swilifecore_spGetCandidates";
            this.gcCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCandidates.Location = new System.Drawing.Point(0, 0);
            this.gcCandidates.MainView = this.gvCandidates;
            this.gcCandidates.Name = "gcCandidates";
            this.gcCandidates.Size = new System.Drawing.Size(897, 266);
            this.gcCandidates.TabIndex = 1;
            this.gcCandidates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCandidates});
            this.gcCandidates.DoubleClick += new System.EventHandler(this.gcCandidates_DoubleClick);
            // 
            // gvCandidates
            // 
            this.gvCandidates.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFirstName,
            this.colLastName,
            this.colKeySkills,
            this.colModified,
            this.colCurrentPosition,
            this.colCurrentEmployer,
            this.colDesiredPay,
            this.colEmail,
            this.colCellPhoneNumber,
            this.colLastStatus,
            this.colCity,
            this.colState});
            gridFormatRule1.Column = this.colState;
            gridFormatRule1.ColumnApplyTo = this.colFirstName;
            gridFormatRule1.Name = "Format0";
            formatConditionIconSet1.CategoryName = "Shapes";
            formatConditionIconSetIcon1.PredefinedName = "TrafficLights23_1.png";
            formatConditionIconSetIcon1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            formatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon2.PredefinedName = "RedToBlack4_3.png";
            formatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon3.PredefinedName = "TrafficLights23_3.png";
            formatConditionIconSetIcon3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            formatConditionIconSetIcon3.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon1);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon2);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon3);
            formatConditionIconSet1.Name = "TrafficLights3Unrimmed";
            formatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleIconSet1.IconSet = formatConditionIconSet1;
            gridFormatRule1.Rule = formatConditionRuleIconSet1;
            this.gvCandidates.FormatRules.Add(gridFormatRule1);
            this.gvCandidates.GridControl = this.gcCandidates;
            this.gvCandidates.Name = "gvCandidates";
            this.gvCandidates.OptionsBehavior.Editable = false;
            this.gvCandidates.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Last Name";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 1;
            this.colLastName.Width = 108;
            // 
            // colKeySkills
            // 
            this.colKeySkills.Caption = "Key Skills";
            this.colKeySkills.FieldName = "KeySkills";
            this.colKeySkills.Name = "colKeySkills";
            this.colKeySkills.Visible = true;
            this.colKeySkills.VisibleIndex = 2;
            this.colKeySkills.Width = 178;
            // 
            // colModified
            // 
            this.colModified.Caption = "Modified";
            this.colModified.FieldName = "Modified";
            this.colModified.Name = "colModified";
            this.colModified.Visible = true;
            this.colModified.VisibleIndex = 3;
            this.colModified.Width = 94;
            // 
            // colCurrentPosition
            // 
            this.colCurrentPosition.Caption = "Current Position";
            this.colCurrentPosition.FieldName = "CurrentPosition";
            this.colCurrentPosition.Name = "colCurrentPosition";
            this.colCurrentPosition.Visible = true;
            this.colCurrentPosition.VisibleIndex = 6;
            this.colCurrentPosition.Width = 121;
            // 
            // colCurrentEmployer
            // 
            this.colCurrentEmployer.Caption = "Current Employer";
            this.colCurrentEmployer.FieldName = "CurrentEmployer";
            this.colCurrentEmployer.Name = "colCurrentEmployer";
            this.colCurrentEmployer.Visible = true;
            this.colCurrentEmployer.VisibleIndex = 4;
            this.colCurrentEmployer.Width = 143;
            // 
            // colDesiredPay
            // 
            this.colDesiredPay.Caption = "Desired Pay";
            this.colDesiredPay.FieldName = "DesiredPay";
            this.colDesiredPay.Name = "colDesiredPay";
            this.colDesiredPay.Visible = true;
            this.colDesiredPay.VisibleIndex = 5;
            this.colDesiredPay.Width = 121;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 7;
            this.colEmail.Width = 112;
            // 
            // colCellPhoneNumber
            // 
            this.colCellPhoneNumber.Caption = "Cell Phone";
            this.colCellPhoneNumber.FieldName = "CellPhone";
            this.colCellPhoneNumber.Name = "colCellPhoneNumber";
            this.colCellPhoneNumber.Visible = true;
            this.colCellPhoneNumber.VisibleIndex = 8;
            this.colCellPhoneNumber.Width = 112;
            // 
            // colLastStatus
            // 
            this.colLastStatus.Caption = "Last Status";
            this.colLastStatus.FieldName = "LastStatus";
            this.colLastStatus.Name = "colLastStatus";
            this.colLastStatus.Visible = true;
            this.colLastStatus.VisibleIndex = 9;
            this.colLastStatus.Width = 137;
            // 
            // colCity
            // 
            this.colCity.Caption = "City";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 10;
            // 
            // frCandidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcCandidates);
            this.Name = "frCandidates";
            this.Size = new System.Drawing.Size(897, 266);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCandidates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem refreshTableToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl gcCandidates;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCandidates;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colKeySkills;
        private DevExpress.XtraGrid.Columns.GridColumn colModified;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentEmployer;
        private DevExpress.XtraGrid.Columns.GridColumn colDesiredPay;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colCellPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colLastStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private System.Windows.Forms.ToolStripMenuItem viewWebsiteToolStripMenuItem;
    }
}
