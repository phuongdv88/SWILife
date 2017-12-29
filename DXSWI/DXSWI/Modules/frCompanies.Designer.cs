namespace DXSWI.Modules
{
    partial class frCompanies
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
            this.gcCompanies = new DevExpress.XtraGrid.GridControl();
            this.gvCompanies = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndustry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModified = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.viewContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.addJobOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCompanies)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcCompanies
            // 
            this.gcCompanies.ContextMenuStrip = this.contextMenuStrip1;
            this.gcCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCompanies.Location = new System.Drawing.Point(0, 0);
            this.gcCompanies.MainView = this.gvCompanies;
            this.gcCompanies.Name = "gcCompanies";
            this.gcCompanies.Size = new System.Drawing.Size(1117, 623);
            this.gcCompanies.TabIndex = 0;
            this.gcCompanies.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCompanies});
            this.gcCompanies.DoubleClick += new System.EventHandler(this.gcCompanies_DoubleClick);
            // 
            // gvCompanies
            // 
            this.gvCompanies.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colJobs,
            this.colCity,
            this.colIndustry,
            this.colContactName,
            this.colPhone,
            this.colOwner,
            this.colModified});
            this.gvCompanies.GridControl = this.gcCompanies;
            this.gvCompanies.Name = "gvCompanies";
            this.gvCompanies.OptionsBehavior.Editable = false;
            this.gvCompanies.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 189;
            // 
            // colJobs
            // 
            this.colJobs.Caption = "Jobs";
            this.colJobs.FieldName = "Jobs";
            this.colJobs.Name = "colJobs";
            this.colJobs.Visible = true;
            this.colJobs.VisibleIndex = 1;
            this.colJobs.Width = 54;
            // 
            // colCity
            // 
            this.colCity.Caption = "City";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 2;
            this.colCity.Width = 59;
            // 
            // colIndustry
            // 
            this.colIndustry.Caption = "Industry";
            this.colIndustry.FieldName = "Industry";
            this.colIndustry.Name = "colIndustry";
            this.colIndustry.Visible = true;
            this.colIndustry.VisibleIndex = 3;
            this.colIndustry.Width = 156;
            // 
            // colContactName
            // 
            this.colContactName.Caption = "Contact Name";
            this.colContactName.FieldName = "ContactName";
            this.colContactName.Name = "colContactName";
            this.colContactName.Visible = true;
            this.colContactName.VisibleIndex = 4;
            this.colContactName.Width = 156;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Work Phone";
            this.colPhone.FieldName = "WorkPhone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 5;
            this.colPhone.Width = 156;
            // 
            // colOwner
            // 
            this.colOwner.Caption = "Owner";
            this.colOwner.FieldName = "UserName";
            this.colOwner.Name = "colOwner";
            this.colOwner.Visible = true;
            this.colOwner.VisibleIndex = 6;
            this.colOwner.Width = 156;
            // 
            // colModified
            // 
            this.colModified.Caption = "Modified";
            this.colModified.FieldName = "Modified";
            this.colModified.Name = "colModified";
            this.colModified.Visible = true;
            this.colModified.VisibleIndex = 7;
            this.colModified.Width = 173;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCompanyToolStripMenuItem,
            this.editCompanyToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteCompanyToolStripMenuItem,
            this.toolStripSeparator2,
            this.viewContactToolStripMenuItem,
            this.addContactToolStripMenuItem,
            this.toolStripSeparator3,
            this.addJobOrderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 154);
            // 
            // newCompanyToolStripMenuItem
            // 
            this.newCompanyToolStripMenuItem.Name = "newCompanyToolStripMenuItem";
            this.newCompanyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.newCompanyToolStripMenuItem.Text = "New Company";
            this.newCompanyToolStripMenuItem.Click += new System.EventHandler(this.newCompanyToolStripMenuItem_Click);
            // 
            // editCompanyToolStripMenuItem
            // 
            this.editCompanyToolStripMenuItem.Name = "editCompanyToolStripMenuItem";
            this.editCompanyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editCompanyToolStripMenuItem.Text = "Edit Company";
            this.editCompanyToolStripMenuItem.Click += new System.EventHandler(this.editCompanyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // deleteCompanyToolStripMenuItem
            // 
            this.deleteCompanyToolStripMenuItem.Name = "deleteCompanyToolStripMenuItem";
            this.deleteCompanyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deleteCompanyToolStripMenuItem.Text = "Delete Company";
            this.deleteCompanyToolStripMenuItem.Click += new System.EventHandler(this.deleteCompanyToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // viewContactToolStripMenuItem
            // 
            this.viewContactToolStripMenuItem.Name = "viewContactToolStripMenuItem";
            this.viewContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.viewContactToolStripMenuItem.Text = "View Contact";
            this.viewContactToolStripMenuItem.Click += new System.EventHandler(this.viewContactToolStripMenuItem_Click);
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addContactToolStripMenuItem.Text = "Add Contact";
            this.addContactToolStripMenuItem.Click += new System.EventHandler(this.addContactToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(159, 6);
            // 
            // addJobOrderToolStripMenuItem
            // 
            this.addJobOrderToolStripMenuItem.Name = "addJobOrderToolStripMenuItem";
            this.addJobOrderToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addJobOrderToolStripMenuItem.Text = "Add Job Order";
            this.addJobOrderToolStripMenuItem.Click += new System.EventHandler(this.addJobOrderToolStripMenuItem_Click);
            // 
            // frCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcCompanies);
            this.Name = "frCompanies";
            this.Size = new System.Drawing.Size(1117, 623);
            ((System.ComponentModel.ISupportInitialize)(this.gcCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCompanies)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcCompanies;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCompanies;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colJobs;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colIndustry;
        private DevExpress.XtraGrid.Columns.GridColumn colContactName;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colOwner;
        private DevExpress.XtraGrid.Columns.GridColumn colModified;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem viewContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem addJobOrderToolStripMenuItem;
    }
}
