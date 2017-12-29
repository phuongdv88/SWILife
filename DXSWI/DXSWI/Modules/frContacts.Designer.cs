namespace DXSWI.Modules
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
            this.gcContacts = new DevExpress.XtraGrid.GridControl();
            this.gvContacts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModified = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // gcContacts
            // 
            this.gcContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcContacts.Location = new System.Drawing.Point(0, 0);
            this.gcContacts.MainView = this.gvContacts;
            this.gcContacts.Name = "gcContacts";
            this.gcContacts.Size = new System.Drawing.Size(1193, 629);
            this.gcContacts.TabIndex = 0;
            this.gcContacts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvContacts});
            // 
            // gvContacts
            // 
            this.gvContacts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFirstName,
            this.colLastName,
            this.colCompany,
            this.colPhoneNumber,
            this.colEmail,
            this.colOwner,
            this.colModified});
            this.gvContacts.GridControl = this.gcContacts;
            this.gvContacts.Name = "gvContacts";
            this.gvContacts.OptionsBehavior.Editable = false;
            this.gvContacts.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "First Name";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 0;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Last Name";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 1;
            // 
            // colCompany
            // 
            this.colCompany.Caption = "Company";
            this.colCompany.Name = "colCompany";
            this.colCompany.Visible = true;
            this.colCompany.VisibleIndex = 2;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Caption = "Phone Number";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 3;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            // 
            // colOwner
            // 
            this.colOwner.Caption = "Owner";
            this.colOwner.Name = "colOwner";
            this.colOwner.Visible = true;
            this.colOwner.VisibleIndex = 5;
            // 
            // colModified
            // 
            this.colModified.Caption = "Modified";
            this.colModified.Name = "colModified";
            this.colModified.Visible = true;
            this.colModified.VisibleIndex = 6;
            // 
            // frContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcContacts);
            this.Name = "frContacts";
            this.Size = new System.Drawing.Size(1193, 629);
            ((System.ComponentModel.ISupportInitialize)(this.gcContacts)).EndInit();
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
    }
}
