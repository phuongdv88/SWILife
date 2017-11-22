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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcKeySkills = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcModified = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDesiredPay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucChangePageBar1 = new DXSWI.Controls.ucChangePageBar();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1193, 629);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(580, 562);
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
            this.ucChangePageBar1.Location = new System.Drawing.Point(3, 3);
            this.ucChangePageBar1.Name = "ucChangePageBar1";
            this.ucChangePageBar1.Size = new System.Drawing.Size(551, 32);
            this.ucChangePageBar1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.ucChangePageBar1);
            this.flowLayoutPanel2.Controls.Add(this.gridControl1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(580, 603);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // frContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frContacts";
            this.Size = new System.Drawing.Size(1193, 629);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Controls.ucChangePageBar ucChangePageBar1;
    }
}
