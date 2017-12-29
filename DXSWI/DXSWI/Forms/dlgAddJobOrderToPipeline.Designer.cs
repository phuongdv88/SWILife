namespace DXSWI.Forms
{
    partial class dlgAddJobOrderToPipeline
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sbAdd = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gcJobOrder = new DevExpress.XtraGrid.GridControl();
            this.gvJobOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModified = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcJobOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvJobOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAdd
            // 
            this.sbAdd.Location = new System.Drawing.Point(805, 3);
            this.sbAdd.Name = "sbAdd";
            this.sbAdd.Size = new System.Drawing.Size(75, 23);
            this.sbAdd.TabIndex = 1;
            this.sbAdd.Text = "Add";
            this.sbAdd.Click += new System.EventHandler(this.sbAdd_Click);
            // 
            // sbCancel
            // 
            this.sbCancel.Location = new System.Drawing.Point(886, 3);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(75, 23);
            this.sbCancel.TabIndex = 1;
            this.sbCancel.Text = "Cancel";
            this.sbCancel.Click += new System.EventHandler(this.sbCancel_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.sbCancel);
            this.flowLayoutPanel1.Controls.Add(this.sbAdd);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 592);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(964, 27);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // gcJobOrder
            // 
            this.gcJobOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcJobOrder.Location = new System.Drawing.Point(0, 0);
            this.gcJobOrder.MainView = this.gvJobOrder;
            this.gcJobOrder.Name = "gcJobOrder";
            this.gcJobOrder.Size = new System.Drawing.Size(964, 592);
            this.gcJobOrder.TabIndex = 3;
            this.gcJobOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvJobOrder});
            // 
            // gvJobOrder
            // 
            this.gvJobOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTitle,
            this.colCompany,
            this.colSalary,
            this.colCity,
            this.colModified});
            this.gvJobOrder.GridControl = this.gcJobOrder;
            this.gvJobOrder.Name = "gvJobOrder";
            this.gvJobOrder.OptionsBehavior.Editable = false;
            this.gvJobOrder.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colTitle
            // 
            this.colTitle.Caption = "Title";
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 0;
            // 
            // colCompany
            // 
            this.colCompany.Caption = "Company";
            this.colCompany.FieldName = "CompanyName";
            this.colCompany.Name = "colCompany";
            this.colCompany.Visible = true;
            this.colCompany.VisibleIndex = 1;
            // 
            // colSalary
            // 
            this.colSalary.Caption = "Salary";
            this.colSalary.FieldName = "Salary";
            this.colSalary.Name = "colSalary";
            this.colSalary.Visible = true;
            this.colSalary.VisibleIndex = 2;
            // 
            // colCity
            // 
            this.colCity.Caption = "City";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 3;
            // 
            // colModified
            // 
            this.colModified.Caption = "Modified";
            this.colModified.FieldName = "Modified";
            this.colModified.Name = "colModified";
            this.colModified.Visible = true;
            this.colModified.VisibleIndex = 4;
            // 
            // dlgAddJobOrderToPipeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 619);
            this.Controls.Add(this.gcJobOrder);
            this.Controls.Add(this.flowLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "dlgAddJobOrderToPipeline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Job Order";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dlgAddJobOrderToPipeline_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcJobOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvJobOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton sbAdd;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gcJobOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gvJobOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colSalary;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colModified;
    }
}