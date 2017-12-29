namespace DXSWI.Modules
{
    partial class frJobOrders
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
            this.gcJobOrder = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newJobOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvJobOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubmitted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanInPipeLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLink = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteJobOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcJobOrder)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvJobOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // gcJobOrder
            // 
            this.gcJobOrder.ContextMenuStrip = this.contextMenuStrip1;
            this.gcJobOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcJobOrder.Location = new System.Drawing.Point(0, 0);
            this.gcJobOrder.MainView = this.gvJobOrder;
            this.gcJobOrder.Name = "gcJobOrder";
            this.gcJobOrder.Size = new System.Drawing.Size(933, 618);
            this.gcJobOrder.TabIndex = 5;
            this.gcJobOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvJobOrder});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newJobOrderToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteJobOrderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 98);
            // 
            // newJobOrderToolStripMenuItem
            // 
            this.newJobOrderToolStripMenuItem.Name = "newJobOrderToolStripMenuItem";
            this.newJobOrderToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newJobOrderToolStripMenuItem.Text = "New Job Order";
            this.newJobOrderToolStripMenuItem.Click += new System.EventHandler(this.newJobOrderToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.editToolStripMenuItem.Text = "Edit Job Order";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // gvJobOrder
            // 
            this.gvJobOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTitle,
            this.colCompany,
            this.colType,
            this.colStatus,
            this.colAge,
            this.colSubmitted,
            this.colCanInPipeLine,
            this.colOwner,
            this.colCity,
            this.colLink});
            this.gvJobOrder.GridControl = this.gcJobOrder;
            this.gvJobOrder.Name = "gvJobOrder";
            this.gvJobOrder.OptionsBehavior.Editable = false;
            this.gvJobOrder.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvJobOrder.DoubleClick += new System.EventHandler(this.gvJobOrder_DoubleClick);
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "JobOrderId";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 33;
            // 
            // colTitle
            // 
            this.colTitle.Caption = "Title";
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 1;
            this.colTitle.Width = 186;
            // 
            // colCompany
            // 
            this.colCompany.Caption = "Company";
            this.colCompany.FieldName = "CompanyName";
            this.colCompany.Name = "colCompany";
            this.colCompany.Visible = true;
            this.colCompany.VisibleIndex = 2;
            this.colCompany.Width = 185;
            // 
            // colType
            // 
            this.colType.Caption = "Type";
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 3;
            this.colType.Width = 25;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 4;
            this.colStatus.Width = 30;
            // 
            // colAge
            // 
            this.colAge.Caption = "Days Old";
            this.colAge.FieldName = "DaysOld";
            this.colAge.Name = "colAge";
            this.colAge.Visible = true;
            this.colAge.VisibleIndex = 5;
            this.colAge.Width = 60;
            // 
            // colSubmitted
            // 
            this.colSubmitted.Caption = "Submitted";
            this.colSubmitted.FieldName = "Submitted";
            this.colSubmitted.Name = "colSubmitted";
            this.colSubmitted.Visible = true;
            this.colSubmitted.VisibleIndex = 6;
            this.colSubmitted.Width = 59;
            // 
            // colCanInPipeLine
            // 
            this.colCanInPipeLine.Caption = "Pipe Line";
            this.colCanInPipeLine.FieldName = "CanInPipeLine";
            this.colCanInPipeLine.Name = "colCanInPipeLine";
            this.colCanInPipeLine.Visible = true;
            this.colCanInPipeLine.VisibleIndex = 7;
            this.colCanInPipeLine.Width = 49;
            // 
            // colOwner
            // 
            this.colOwner.Caption = "Owner";
            this.colOwner.FieldName = "Owner";
            this.colOwner.Name = "colOwner";
            this.colOwner.Visible = true;
            this.colOwner.VisibleIndex = 8;
            this.colOwner.Width = 36;
            // 
            // colCity
            // 
            this.colCity.Caption = "City";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 9;
            this.colCity.Width = 38;
            // 
            // colLink
            // 
            this.colLink.Caption = "Link";
            this.colLink.FieldName = "Weblink";
            this.colLink.Name = "colLink";
            this.colLink.Visible = true;
            this.colLink.VisibleIndex = 10;
            this.colLink.Width = 214;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // deleteJobOrderToolStripMenuItem
            // 
            this.deleteJobOrderToolStripMenuItem.Name = "deleteJobOrderToolStripMenuItem";
            this.deleteJobOrderToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deleteJobOrderToolStripMenuItem.Text = "Delete Job Order";
            this.deleteJobOrderToolStripMenuItem.Click += new System.EventHandler(this.deleteJobOrderToolStripMenuItem_Click);
            // 
            // frJobOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcJobOrder);
            this.Name = "frJobOrders";
            this.Size = new System.Drawing.Size(933, 618);
            ((System.ComponentModel.ISupportInitialize)(this.gcJobOrder)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvJobOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcJobOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gvJobOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colAge;
        private DevExpress.XtraGrid.Columns.GridColumn colSubmitted;
        private DevExpress.XtraGrid.Columns.GridColumn colCanInPipeLine;
        private DevExpress.XtraGrid.Columns.GridColumn colOwner;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colLink;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newJobOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteJobOrderToolStripMenuItem;
    }
}
