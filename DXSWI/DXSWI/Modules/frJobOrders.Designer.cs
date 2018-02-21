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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRule2ColorScale formatConditionRule2ColorScale1 = new DevExpress.XtraEditors.FormatConditionRule2ColorScale();
            this.colIsHot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcJobOrder = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newJobOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteJobOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvJobOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubmitted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanInPipeLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLink = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcJobOrder)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvJobOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // colIsHot
            // 
            this.colIsHot.Caption = "Is Hot";
            this.colIsHot.FieldName = "IsHot";
            this.colIsHot.Name = "colIsHot";
            // 
            // colTitle
            // 
            this.colTitle.Caption = "Title";
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 0;
            this.colTitle.Width = 186;
            // 
            // gcJobOrder
            // 
            this.gcJobOrder.ContextMenuStrip = this.contextMenuStrip1;
            this.gcJobOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcJobOrder.Location = new System.Drawing.Point(0, 0);
            this.gcJobOrder.MainView = this.gvJobOrder;
            this.gcJobOrder.Name = "gcJobOrder";
            this.gcJobOrder.Size = new System.Drawing.Size(904, 317);
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
            this.deleteJobOrderToolStripMenuItem,
            this.toolStripSeparator2,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 104);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // newJobOrderToolStripMenuItem
            // 
            this.newJobOrderToolStripMenuItem.Image = global::DXSWI.Properties.Resources.new_job1;
            this.newJobOrderToolStripMenuItem.Name = "newJobOrderToolStripMenuItem";
            this.newJobOrderToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.newJobOrderToolStripMenuItem.Text = "New Job Order";
            this.newJobOrderToolStripMenuItem.Click += new System.EventHandler(this.newJobOrderToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DXSWI.Properties.Resources.edit1;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.editToolStripMenuItem.Text = "Edit Job Order";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // deleteJobOrderToolStripMenuItem
            // 
            this.deleteJobOrderToolStripMenuItem.Image = global::DXSWI.Properties.Resources.delete1;
            this.deleteJobOrderToolStripMenuItem.Name = "deleteJobOrderToolStripMenuItem";
            this.deleteJobOrderToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.deleteJobOrderToolStripMenuItem.Text = "Delete Job Order";
            this.deleteJobOrderToolStripMenuItem.Click += new System.EventHandler(this.deleteJobOrderToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::DXSWI.Properties.Resources.ButtonRefresh1;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.refreshToolStripMenuItem.Text = "Refresh Job Orders";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // gvJobOrder
            // 
            this.gvJobOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTitle,
            this.colCompany,
            this.colType,
            this.colStatus,
            this.colAge,
            this.colSubmitted,
            this.colCanInPipeLine,
            this.colOwner,
            this.colCity,
            this.colLink,
            this.colIsHot});
            gridFormatRule1.Column = this.colIsHot;
            gridFormatRule1.ColumnApplyTo = this.colTitle;
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
            this.gvJobOrder.DoubleClick += new System.EventHandler(this.gvJobOrder_DoubleClick);
            // 
            // colCompany
            // 
            this.colCompany.Caption = "Company";
            this.colCompany.FieldName = "CompanyName";
            this.colCompany.Name = "colCompany";
            this.colCompany.Visible = true;
            this.colCompany.VisibleIndex = 1;
            this.colCompany.Width = 161;
            // 
            // colType
            // 
            this.colType.Caption = "Type";
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 2;
            this.colType.Width = 48;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            this.colStatus.Width = 50;
            // 
            // colAge
            // 
            this.colAge.Caption = "Days Old";
            this.colAge.FieldName = "DaysOld";
            this.colAge.Name = "colAge";
            this.colAge.Visible = true;
            this.colAge.VisibleIndex = 4;
            this.colAge.Width = 56;
            // 
            // colSubmitted
            // 
            this.colSubmitted.Caption = "Submitted";
            this.colSubmitted.FieldName = "Submitted";
            this.colSubmitted.Name = "colSubmitted";
            this.colSubmitted.Visible = true;
            this.colSubmitted.VisibleIndex = 5;
            this.colSubmitted.Width = 80;
            // 
            // colCanInPipeLine
            // 
            this.colCanInPipeLine.Caption = "Pipe Line";
            this.colCanInPipeLine.FieldName = "CanInPipeLine";
            this.colCanInPipeLine.Name = "colCanInPipeLine";
            this.colCanInPipeLine.Visible = true;
            this.colCanInPipeLine.VisibleIndex = 6;
            this.colCanInPipeLine.Width = 65;
            // 
            // colOwner
            // 
            this.colOwner.Caption = "Owner";
            this.colOwner.FieldName = "Owner";
            this.colOwner.Name = "colOwner";
            this.colOwner.Visible = true;
            this.colOwner.VisibleIndex = 7;
            this.colOwner.Width = 54;
            // 
            // colCity
            // 
            this.colCity.Caption = "City";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 8;
            this.colCity.Width = 49;
            // 
            // colLink
            // 
            this.colLink.Caption = "Link";
            this.colLink.FieldName = "Weblink";
            this.colLink.Name = "colLink";
            this.colLink.Visible = true;
            this.colLink.VisibleIndex = 9;
            this.colLink.Width = 137;
            // 
            // frJobOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcJobOrder);
            this.Name = "frJobOrders";
            this.Size = new System.Drawing.Size(904, 317);
            ((System.ComponentModel.ISupportInitialize)(this.gcJobOrder)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvJobOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcJobOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gvJobOrder;
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
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DevExpress.XtraGrid.Columns.GridColumn colIsHot;
    }
}
