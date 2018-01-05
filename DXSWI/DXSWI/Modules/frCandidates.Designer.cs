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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ucCandidateManager1 = new DXSWI.Controls.ucCandidateManager();
            this.gcCandidates = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeySkills = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModified = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentEmployer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOBMarried = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesiredPay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 76);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.newToolStripMenuItem.Text = "New Candidate";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
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
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteToolStripMenuItem.Text = "Delete Candidate";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.Controls.Add(this.ucCandidateManager1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.gcCandidates, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1243, 839);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ucCandidateManager1
            // 
            this.ucCandidateManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCandidateManager1.Location = new System.Drawing.Point(624, 13);
            this.ucCandidateManager1.Name = "ucCandidateManager1";
            this.ucCandidateManager1.Size = new System.Drawing.Size(605, 813);
            this.ucCandidateManager1.TabIndex = 2;
            this.ucCandidateManager1.Load += new System.EventHandler(this.ucCandidateManager1_Load);
            // 
            // gcCandidates
            // 
            this.gcCandidates.ContextMenuStrip = this.contextMenuStrip1;
            this.gcCandidates.DataMember = "swilifecore_spGetCandidates";
            this.gcCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCandidates.Location = new System.Drawing.Point(13, 13);
            this.gcCandidates.MainView = this.gridView1;
            this.gcCandidates.Name = "gcCandidates";
            this.gcCandidates.Size = new System.Drawing.Size(605, 813);
            this.gcCandidates.TabIndex = 0;
            this.gcCandidates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcCandidates.Click += new System.EventHandler(this.gcCandidates_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFirstName,
            this.colLastName,
            this.colKeySkills,
            this.colModified,
            this.colCurrentPosition,
            this.colCurrentEmployer,
            this.colDOBMarried,
            this.colDesiredPay});
            this.gridView1.GridControl = this.gcCandidates;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.ColumnFilterChanged += new System.EventHandler(this.gridView1_ColumnFilterChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "First Name";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            this.colFirstName.Width = 85;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Last Name";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            this.colLastName.Width = 85;
            // 
            // colKeySkills
            // 
            this.colKeySkills.Caption = "Key Skills";
            this.colKeySkills.FieldName = "KeySkills";
            this.colKeySkills.Name = "colKeySkills";
            this.colKeySkills.Visible = true;
            this.colKeySkills.VisibleIndex = 3;
            this.colKeySkills.Width = 85;
            // 
            // colModified
            // 
            this.colModified.Caption = "Modified";
            this.colModified.FieldName = "Modified";
            this.colModified.Name = "colModified";
            this.colModified.Visible = true;
            this.colModified.VisibleIndex = 4;
            this.colModified.Width = 85;
            // 
            // colCurrentPosition
            // 
            this.colCurrentPosition.Caption = "Current Position";
            this.colCurrentPosition.FieldName = "CurrentPosition";
            this.colCurrentPosition.Name = "colCurrentPosition";
            this.colCurrentPosition.Visible = true;
            this.colCurrentPosition.VisibleIndex = 7;
            this.colCurrentPosition.Width = 81;
            // 
            // colCurrentEmployer
            // 
            this.colCurrentEmployer.Caption = "Current Employer";
            this.colCurrentEmployer.FieldName = "CurrentEmployer";
            this.colCurrentEmployer.Name = "colCurrentEmployer";
            this.colCurrentEmployer.Visible = true;
            this.colCurrentEmployer.VisibleIndex = 5;
            this.colCurrentEmployer.Width = 95;
            // 
            // colDOBMarried
            // 
            this.colDOBMarried.Caption = "DOBMarried";
            this.colDOBMarried.FieldName = "DOBMarried";
            this.colDOBMarried.Name = "colDOBMarried";
            this.colDOBMarried.Visible = true;
            this.colDOBMarried.VisibleIndex = 8;
            this.colDOBMarried.Width = 89;
            // 
            // colDesiredPay
            // 
            this.colDesiredPay.Caption = "Desired Pay";
            this.colDesiredPay.FieldName = "DesiredPay";
            this.colDesiredPay.Name = "colDesiredPay";
            this.colDesiredPay.Visible = true;
            this.colDesiredPay.VisibleIndex = 6;
            this.colDesiredPay.Width = 81;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "CandidateId";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // frCandidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frCandidates";
            this.Size = new System.Drawing.Size(1243, 839);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.ucCandidateManager ucCandidateManager1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl gcCandidates;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colKeySkills;
        private DevExpress.XtraGrid.Columns.GridColumn colModified;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentEmployer;
        private DevExpress.XtraGrid.Columns.GridColumn colDOBMarried;
        private DevExpress.XtraGrid.Columns.GridColumn colDesiredPay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}
