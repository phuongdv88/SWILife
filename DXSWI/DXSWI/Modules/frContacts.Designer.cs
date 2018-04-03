﻿namespace DXSWI.Modules
{
    partial class frContacts
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
            this.gcContacts = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvContacts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModified = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMisc = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcContacts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // gcContacts
            // 
            this.gcContacts.ContextMenuStrip = this.contextMenuStrip1;
            this.gcContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcContacts.Location = new System.Drawing.Point(0, 0);
            this.gcContacts.MainView = this.gvContacts;
            this.gcContacts.Name = "gcContacts";
            this.gcContacts.Size = new System.Drawing.Size(930, 309);
            this.gcContacts.TabIndex = 0;
            this.gcContacts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvContacts});
            this.gcContacts.DoubleClick += new System.EventHandler(this.gcContacts_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newContactToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteContactToolStripMenuItem,
            this.toolStripSeparator2,
            this.refreshContactsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 104);
            // 
            // newContactToolStripMenuItem
            // 
            this.newContactToolStripMenuItem.Image = global::DXSWI.Properties.Resources.newcontact1;
            this.newContactToolStripMenuItem.Name = "newContactToolStripMenuItem";
            this.newContactToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.newContactToolStripMenuItem.Text = "New Contact";
            this.newContactToolStripMenuItem.Click += new System.EventHandler(this.newContactToolStripMenuItem_Click);
            // 
            // editContactToolStripMenuItem
            // 
            this.editContactToolStripMenuItem.Image = global::DXSWI.Properties.Resources.editcontact1;
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.editContactToolStripMenuItem.Text = "Edit Contact";
            this.editContactToolStripMenuItem.Click += new System.EventHandler(this.editContactToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // deleteContactToolStripMenuItem
            // 
            this.deleteContactToolStripMenuItem.Image = global::DXSWI.Properties.Resources.deletevcard1;
            this.deleteContactToolStripMenuItem.Name = "deleteContactToolStripMenuItem";
            this.deleteContactToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.deleteContactToolStripMenuItem.Text = "Delete Contact";
            this.deleteContactToolStripMenuItem.Click += new System.EventHandler(this.deleteContactToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(160, 6);
            // 
            // refreshContactsToolStripMenuItem
            // 
            this.refreshContactsToolStripMenuItem.Image = global::DXSWI.Properties.Resources.ButtonRefresh1;
            this.refreshContactsToolStripMenuItem.Name = "refreshContactsToolStripMenuItem";
            this.refreshContactsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.refreshContactsToolStripMenuItem.Text = "Refresh Contacts";
            this.refreshContactsToolStripMenuItem.Click += new System.EventHandler(this.refreshContactsToolStripMenuItem_Click);
            // 
            // gvContacts
            // 
            this.gvContacts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFirstName,
            this.colLastName,
            this.colCompany,
            this.colPhoneNumber,
            this.colTitle,
            this.colEmail,
            this.colCity,
            this.colOwner,
            this.colModified,
            this.colMisc});
            this.gvContacts.GridControl = this.gcContacts;
            this.gvContacts.Name = "gvContacts";
            this.gvContacts.OptionsBehavior.Editable = false;
            this.gvContacts.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "First Name";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 0;
            this.colFirstName.Width = 74;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Last Name";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 1;
            this.colLastName.Width = 58;
            // 
            // colCompany
            // 
            this.colCompany.Caption = "Company";
            this.colCompany.FieldName = "CompanyName";
            this.colCompany.Name = "colCompany";
            this.colCompany.Visible = true;
            this.colCompany.VisibleIndex = 2;
            this.colCompany.Width = 118;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Caption = "Cell Phone";
            this.colPhoneNumber.FieldName = "CellPhone";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 3;
            this.colPhoneNumber.Width = 86;
            // 
            // colTitle
            // 
            this.colTitle.Caption = "Title";
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 4;
            this.colTitle.Width = 124;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            this.colEmail.Width = 124;
            // 
            // colCity
            // 
            this.colCity.Caption = "City";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 6;
            // 
            // colOwner
            // 
            this.colOwner.Caption = "Owner";
            this.colOwner.FieldName = "Owner";
            this.colOwner.Name = "colOwner";
            this.colOwner.Visible = true;
            this.colOwner.VisibleIndex = 8;
            this.colOwner.Width = 54;
            // 
            // colModified
            // 
            this.colModified.Caption = "Modified";
            this.colModified.DisplayFormat.FormatString = "yyyy/MM/dd HH:mm:ss";
            this.colModified.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colModified.FieldName = "Modified";
            this.colModified.Name = "colModified";
            this.colModified.Visible = true;
            this.colModified.VisibleIndex = 9;
            this.colModified.Width = 73;
            // 
            // colMisc
            // 
            this.colMisc.Caption = "Misc";
            this.colMisc.FieldName = "MiscNotes";
            this.colMisc.Name = "colMisc";
            this.colMisc.Visible = true;
            this.colMisc.VisibleIndex = 7;
            this.colMisc.Width = 201;
            // 
            // frContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcContacts);
            this.Name = "frContacts";
            this.Size = new System.Drawing.Size(930, 309);
            this.Load += new System.EventHandler(this.frContacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcContacts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvContacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcContacts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvContacts;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colOwner;
        private DevExpress.XtraGrid.Columns.GridColumn colModified;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteContactToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private System.Windows.Forms.ToolStripMenuItem refreshContactsToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colMisc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
    }
}
