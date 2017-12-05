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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ucChangePageBar1 = new DXSWI.Controls.ucChangePageBar();
            this.ucCandidateManager1 = new DXSWI.Controls.ucCandidateManager();
            ((System.ComponentModel.ISupportInitialize)(this.gcCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcCandidates
            // 
            this.gcCandidates.DataMember = "swilifecore_spGetCandidates";
            this.gcCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCandidates.Location = new System.Drawing.Point(3, 43);
            this.gcCandidates.MainView = this.gridView1;
            this.gcCandidates.Name = "gcCandidates";
            this.gcCandidates.Size = new System.Drawing.Size(704, 563);
            this.gcCandidates.TabIndex = 0;
            this.gcCandidates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcCandidates.Click += new System.EventHandler(this.gcCandidates_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gridView1.OptionsFind.AlwaysVisible = true;
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
            // colKeySkills
            // 
            this.colKeySkills.Caption = "Key Skills";
            this.colKeySkills.FieldName = "KeySkills";
            this.colKeySkills.Name = "colKeySkills";
            this.colKeySkills.Visible = true;
            this.colKeySkills.VisibleIndex = 2;
            // 
            // colModified
            // 
            this.colModified.Caption = "Modified";
            this.colModified.FieldName = "Modified";
            this.colModified.Name = "colModified";
            this.colModified.Visible = true;
            this.colModified.VisibleIndex = 3;
            // 
            // colCurrentPosition
            // 
            this.colCurrentPosition.Caption = "Current Position";
            this.colCurrentPosition.FieldName = "CurrentPosition";
            this.colCurrentPosition.Name = "colCurrentPosition";
            this.colCurrentPosition.Visible = true;
            this.colCurrentPosition.VisibleIndex = 6;
            // 
            // colCurrentEmployer
            // 
            this.colCurrentEmployer.Caption = "Current Employer";
            this.colCurrentEmployer.FieldName = "CurrentEmployer";
            this.colCurrentEmployer.Name = "colCurrentEmployer";
            this.colCurrentEmployer.Visible = true;
            this.colCurrentEmployer.VisibleIndex = 4;
            // 
            // colDOBMarried
            // 
            this.colDOBMarried.Caption = "Born";
            this.colDOBMarried.FieldName = "DOBMarried";
            this.colDOBMarried.Name = "colDOBMarried";
            this.colDOBMarried.Visible = true;
            this.colDOBMarried.VisibleIndex = 7;
            // 
            // colDesiredPay
            // 
            this.colDesiredPay.Caption = "Desired Pay";
            this.colDesiredPay.FieldName = "DesiredPay";
            this.colDesiredPay.Name = "colDesiredPay";
            this.colDesiredPay.Visible = true;
            this.colDesiredPay.VisibleIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ucCandidateManager1, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1453, 635);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.gcCandidates, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ucChangePageBar1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(710, 609);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ucChangePageBar1
            // 
            this.ucChangePageBar1.CurrentPage = 0;
            this.ucChangePageBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucChangePageBar1.ItemCount = 0;
            this.ucChangePageBar1.Location = new System.Drawing.Point(3, 3);
            this.ucChangePageBar1.Name = "ucChangePageBar1";
            this.ucChangePageBar1.Size = new System.Drawing.Size(704, 34);
            this.ucChangePageBar1.TabIndex = 1;
            // 
            // ucCandidateManager1
            // 
            this.ucCandidateManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCandidateManager1.Location = new System.Drawing.Point(729, 13);
            this.ucCandidateManager1.Name = "ucCandidateManager1";
            this.ucCandidateManager1.Size = new System.Drawing.Size(710, 609);
            this.ucCandidateManager1.TabIndex = 2;
            this.ucCandidateManager1.Load += new System.EventHandler(this.ucCandidateManager1_Load);
            // 
            // frCandidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frCandidates";
            this.Size = new System.Drawing.Size(1453, 635);
            ((System.ComponentModel.ISupportInitialize)(this.gcCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colKeySkills;
        private DevExpress.XtraGrid.Columns.GridColumn colModified;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentEmployer;
        private DevExpress.XtraGrid.Columns.GridColumn colDesiredPay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Controls.ucChangePageBar ucChangePageBar1;
        private Controls.ucCandidateManager ucCandidateManager1;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colDOBMarried;
        private DevExpress.XtraGrid.GridControl gcCandidates;
    }
}
