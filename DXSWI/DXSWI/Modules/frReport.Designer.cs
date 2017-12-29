namespace DXSWI.Modules
{
    partial class frReport
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
            this.gcUserReports = new DevExpress.XtraGrid.GridControl();
            this.gvUserReports = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserNewJobOrders = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserNewCandidates = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserNewCompanies = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserNewContacts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserNewSubmitssions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserNewPlacements = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcReports = new DevExpress.XtraGrid.GridControl();
            this.gvReports = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNewJobOrders = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewCandidates = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewCompanies = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewContacts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewSubmissions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewPlacements = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcActivites = new DevExpress.XtraGrid.GridControl();
            this.gvActivities = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegarding = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUserReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcActivites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcUserReports);
            this.layoutControl1.Controls.Add(this.gcReports);
            this.layoutControl1.Controls.Add(this.gcActivites);
            this.layoutControl1.Controls.Add(this.dateEdit1);
            this.layoutControl1.Controls.Add(this.dateEdit2);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1147, 591);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcUserReports
            // 
            this.gcUserReports.Location = new System.Drawing.Point(587, 318);
            this.gcUserReports.MainView = this.gvUserReports;
            this.gcUserReports.Name = "gcUserReports";
            this.gcUserReports.Size = new System.Drawing.Size(536, 249);
            this.gcUserReports.TabIndex = 9;
            this.gcUserReports.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUserReports});
            // 
            // gvUserReports
            // 
            this.gvUserReports.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserName,
            this.colUserNewJobOrders,
            this.colUserNewCandidates,
            this.colUserNewCompanies,
            this.colUserNewContacts,
            this.colUserNewSubmitssions,
            this.colUserNewPlacements});
            this.gvUserReports.GridControl = this.gcUserReports;
            this.gvUserReports.Name = "gvUserReports";
            this.gvUserReports.OptionsBehavior.Editable = false;
            this.gvUserReports.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "User Name";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 0;
            // 
            // colUserNewJobOrders
            // 
            this.colUserNewJobOrders.Caption = "New Job Orders";
            this.colUserNewJobOrders.Name = "colUserNewJobOrders";
            this.colUserNewJobOrders.Visible = true;
            this.colUserNewJobOrders.VisibleIndex = 1;
            // 
            // colUserNewCandidates
            // 
            this.colUserNewCandidates.Caption = "New Candidates";
            this.colUserNewCandidates.Name = "colUserNewCandidates";
            this.colUserNewCandidates.Visible = true;
            this.colUserNewCandidates.VisibleIndex = 2;
            // 
            // colUserNewCompanies
            // 
            this.colUserNewCompanies.Caption = "New Companies";
            this.colUserNewCompanies.Name = "colUserNewCompanies";
            this.colUserNewCompanies.Visible = true;
            this.colUserNewCompanies.VisibleIndex = 3;
            // 
            // colUserNewContacts
            // 
            this.colUserNewContacts.Caption = "New Contacts";
            this.colUserNewContacts.Name = "colUserNewContacts";
            this.colUserNewContacts.Visible = true;
            this.colUserNewContacts.VisibleIndex = 6;
            // 
            // colUserNewSubmitssions
            // 
            this.colUserNewSubmitssions.Caption = "New Submissions";
            this.colUserNewSubmitssions.Name = "colUserNewSubmitssions";
            this.colUserNewSubmitssions.Visible = true;
            this.colUserNewSubmitssions.VisibleIndex = 4;
            // 
            // colUserNewPlacements
            // 
            this.colUserNewPlacements.Caption = "New Placements";
            this.colUserNewPlacements.Name = "colUserNewPlacements";
            this.colUserNewPlacements.Visible = true;
            this.colUserNewPlacements.VisibleIndex = 5;
            // 
            // gcReports
            // 
            this.gcReports.Location = new System.Drawing.Point(24, 318);
            this.gcReports.MainView = this.gvReports;
            this.gcReports.Name = "gcReports";
            this.gcReports.Size = new System.Drawing.Size(535, 249);
            this.gcReports.TabIndex = 8;
            this.gcReports.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReports});
            // 
            // gvReports
            // 
            this.gvReports.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNewJobOrders,
            this.colNewCandidates,
            this.colNewCompanies,
            this.colNewContacts,
            this.colNewSubmissions,
            this.colNewPlacements});
            this.gvReports.GridControl = this.gcReports;
            this.gvReports.Name = "gvReports";
            this.gvReports.OptionsBehavior.Editable = false;
            this.gvReports.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colNewJobOrders
            // 
            this.colNewJobOrders.Caption = "New Job Orders";
            this.colNewJobOrders.Name = "colNewJobOrders";
            this.colNewJobOrders.Visible = true;
            this.colNewJobOrders.VisibleIndex = 0;
            // 
            // colNewCandidates
            // 
            this.colNewCandidates.Caption = "New Candidates";
            this.colNewCandidates.Name = "colNewCandidates";
            this.colNewCandidates.Visible = true;
            this.colNewCandidates.VisibleIndex = 1;
            // 
            // colNewCompanies
            // 
            this.colNewCompanies.Caption = "New Companies";
            this.colNewCompanies.Name = "colNewCompanies";
            this.colNewCompanies.Visible = true;
            this.colNewCompanies.VisibleIndex = 2;
            // 
            // colNewContacts
            // 
            this.colNewContacts.Caption = "New Contacts";
            this.colNewContacts.Name = "colNewContacts";
            this.colNewContacts.Visible = true;
            this.colNewContacts.VisibleIndex = 5;
            // 
            // colNewSubmissions
            // 
            this.colNewSubmissions.Caption = "New Submissions";
            this.colNewSubmissions.Name = "colNewSubmissions";
            this.colNewSubmissions.Visible = true;
            this.colNewSubmissions.VisibleIndex = 3;
            // 
            // colNewPlacements
            // 
            this.colNewPlacements.Caption = "New Placements";
            this.colNewPlacements.Name = "colNewPlacements";
            this.colNewPlacements.Visible = true;
            this.colNewPlacements.VisibleIndex = 4;
            // 
            // gcActivites
            // 
            this.gcActivites.Location = new System.Drawing.Point(24, 68);
            this.gcActivites.MainView = this.gvActivities;
            this.gcActivites.Name = "gcActivites";
            this.gcActivites.Size = new System.Drawing.Size(1099, 204);
            this.gcActivites.TabIndex = 7;
            this.gcActivites.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvActivities});
            // 
            // gvActivities
            // 
            this.gvActivities.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colType,
            this.colRegarding,
            this.colCreated,
            this.colUser});
            this.gvActivities.GridControl = this.gcActivites;
            this.gvActivities.Name = "gvActivities";
            this.gvActivities.OptionsBehavior.Editable = false;
            this.gvActivities.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colType
            // 
            this.colType.Caption = "Type";
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 0;
            // 
            // colRegarding
            // 
            this.colRegarding.Caption = "Regarding";
            this.colRegarding.FieldName = "Regarding";
            this.colRegarding.Name = "colRegarding";
            this.colRegarding.Visible = true;
            this.colRegarding.VisibleIndex = 1;
            // 
            // colCreated
            // 
            this.colCreated.Caption = "Created";
            this.colCreated.FieldName = "Created";
            this.colCreated.Name = "colCreated";
            this.colCreated.Visible = true;
            this.colCreated.VisibleIndex = 2;
            // 
            // colUser
            // 
            this.colUser.Caption = "User";
            this.colUser.FieldName = "UserName";
            this.colUser.Name = "colUser";
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 3;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(39, 12);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(410, 20);
            this.dateEdit1.StyleController = this.layoutControl1;
            this.dateEdit1.TabIndex = 4;
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(480, 12);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(389, 20);
            this.dateEdit2.StyleController = this.layoutControl1;
            this.dateEdit2.TabIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(873, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(262, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Get Data";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlGroup2,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlGroup3,
            this.layoutControlGroup4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1147, 591);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton1;
            this.layoutControlItem3.Location = new System.Drawing.Point(861, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(266, 26);
            this.layoutControlItem3.Text = "Show";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1127, 250);
            this.layoutControlGroup2.Text = "Activities";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gcActivites;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1103, 208);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dateEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(441, 26);
            this.layoutControlItem1.Text = "From";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(24, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dateEdit2;
            this.layoutControlItem2.Location = new System.Drawing.Point(441, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(420, 26);
            this.layoutControlItem2.Text = "To";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(24, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 276);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(563, 295);
            this.layoutControlGroup3.Text = "Reports";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gcReports;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(539, 253);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
            this.layoutControlGroup4.Location = new System.Drawing.Point(563, 276);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(564, 295);
            this.layoutControlGroup4.Text = "Users Activities";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gcUserReports;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(540, 253);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // frReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "frReport";
            this.Size = new System.Drawing.Size(1147, 591);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcUserReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcActivites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcUserReports;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUserReports;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserNewJobOrders;
        private DevExpress.XtraGrid.Columns.GridColumn colUserNewCandidates;
        private DevExpress.XtraGrid.Columns.GridColumn colUserNewCompanies;
        private DevExpress.XtraGrid.Columns.GridColumn colUserNewContacts;
        private DevExpress.XtraGrid.Columns.GridColumn colUserNewSubmitssions;
        private DevExpress.XtraGrid.Columns.GridColumn colUserNewPlacements;
        private DevExpress.XtraGrid.GridControl gcReports;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReports;
        private DevExpress.XtraGrid.Columns.GridColumn colNewJobOrders;
        private DevExpress.XtraGrid.Columns.GridColumn colNewCandidates;
        private DevExpress.XtraGrid.Columns.GridColumn colNewCompanies;
        private DevExpress.XtraGrid.Columns.GridColumn colNewContacts;
        private DevExpress.XtraGrid.Columns.GridColumn colNewSubmissions;
        private DevExpress.XtraGrid.Columns.GridColumn colNewPlacements;
        private DevExpress.XtraGrid.GridControl gcActivites;
        private DevExpress.XtraGrid.Views.Grid.GridView gvActivities;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colRegarding;
        private DevExpress.XtraGrid.Columns.GridColumn colCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
    }
}
