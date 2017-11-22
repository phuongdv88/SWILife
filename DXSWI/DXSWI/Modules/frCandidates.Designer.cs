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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcKeySkills = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcModified = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDesiredPay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucChangePageBar1 = new DXSWI.Controls.ucChangePageBar();
            this.ucCandidateEdit1 = new DXSWI.Controls.ucCandidateEdit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ucCandidateEdit1, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1177, 635);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ucChangePageBar1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(572, 609);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(566, 563);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcFirstName,
            this.gcLastName,
            this.gcKeySkills,
            this.gcModified,
            this.gcAddress,
            this.gcDesiredPay});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // gcFirstName
            // 
            this.gcFirstName.Caption = "First Name";
            this.gcFirstName.Name = "gcFirstName";
            this.gcFirstName.Visible = true;
            this.gcFirstName.VisibleIndex = 0;
            // 
            // gcLastName
            // 
            this.gcLastName.Caption = "Last Name";
            this.gcLastName.Name = "gcLastName";
            this.gcLastName.Visible = true;
            this.gcLastName.VisibleIndex = 1;
            // 
            // gcKeySkills
            // 
            this.gcKeySkills.Caption = "Key Skills";
            this.gcKeySkills.Name = "gcKeySkills";
            this.gcKeySkills.Visible = true;
            this.gcKeySkills.VisibleIndex = 2;
            // 
            // gcModified
            // 
            this.gcModified.Caption = "Modified";
            this.gcModified.Name = "gcModified";
            this.gcModified.Visible = true;
            this.gcModified.VisibleIndex = 3;
            // 
            // gcAddress
            // 
            this.gcAddress.Caption = "Address";
            this.gcAddress.Name = "gcAddress";
            this.gcAddress.Visible = true;
            this.gcAddress.VisibleIndex = 4;
            // 
            // gcDesiredPay
            // 
            this.gcDesiredPay.Caption = "Desired Pay";
            this.gcDesiredPay.Name = "gcDesiredPay";
            this.gcDesiredPay.Visible = true;
            this.gcDesiredPay.VisibleIndex = 5;
            // 
            // ucChangePageBar1
            // 
            this.ucChangePageBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucChangePageBar1.Location = new System.Drawing.Point(3, 3);
            this.ucChangePageBar1.Name = "ucChangePageBar1";
            this.ucChangePageBar1.Size = new System.Drawing.Size(566, 34);
            this.ucChangePageBar1.TabIndex = 1;
            // 
            // ucCandidateEdit1
            // 
            this.ucCandidateEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCandidateEdit1.Location = new System.Drawing.Point(591, 13);
            this.ucCandidateEdit1.Name = "ucCandidateEdit1";
            this.ucCandidateEdit1.Size = new System.Drawing.Size(572, 609);
            this.ucCandidateEdit1.TabIndex = 2;
            // 
            // frCandidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frCandidates";
            this.Size = new System.Drawing.Size(1177, 635);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gcFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn gcLastName;
        private DevExpress.XtraGrid.Columns.GridColumn gcKeySkills;
        private DevExpress.XtraGrid.Columns.GridColumn gcModified;
        private DevExpress.XtraGrid.Columns.GridColumn gcAddress;
        private DevExpress.XtraGrid.Columns.GridColumn gcDesiredPay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Controls.ucChangePageBar ucChangePageBar1;
        private Controls.ucCandidateEdit ucCandidateEdit1;
    }
}
