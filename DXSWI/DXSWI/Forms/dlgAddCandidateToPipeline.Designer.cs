namespace DXSWI.Forms
{
    partial class dlgAddCandidateToPipeline
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.sbOK = new DevExpress.XtraEditors.SimpleButton();
            this.gcCandidates = new DevExpress.XtraGrid.GridControl();
            this.gvCandidates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeySkill = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesiredPay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInterviewNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCandidates)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.sbCancel);
            this.flowLayoutPanel1.Controls.Add(this.sbOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 668);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1135, 30);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // sbCancel
            // 
            this.sbCancel.Location = new System.Drawing.Point(1042, 3);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(90, 23);
            this.sbCancel.TabIndex = 0;
            this.sbCancel.Text = "Exit";
            this.sbCancel.Click += new System.EventHandler(this.sbCancel_Click);
            // 
            // sbOK
            // 
            this.sbOK.Location = new System.Drawing.Point(939, 3);
            this.sbOK.Name = "sbOK";
            this.sbOK.Size = new System.Drawing.Size(97, 23);
            this.sbOK.TabIndex = 1;
            this.sbOK.Text = "Add";
            this.sbOK.Click += new System.EventHandler(this.sbOK_Click);
            // 
            // gcCandidates
            // 
            this.gcCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCandidates.Location = new System.Drawing.Point(0, 0);
            this.gcCandidates.MainView = this.gvCandidates;
            this.gcCandidates.Name = "gcCandidates";
            this.gcCandidates.Size = new System.Drawing.Size(1135, 668);
            this.gcCandidates.TabIndex = 2;
            this.gcCandidates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCandidates});
            this.gcCandidates.DoubleClick += new System.EventHandler(this.gcCandidates_DoubleClick);
            // 
            // gvCandidates
            // 
            this.gvCandidates.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colKeySkill,
            this.colDesiredPay,
            this.colYear,
            this.colInterviewNotes});
            this.gvCandidates.GridControl = this.gcCandidates;
            this.gvCandidates.Name = "gvCandidates";
            this.gvCandidates.OptionsBehavior.Editable = false;
            this.gvCandidates.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 150;
            // 
            // colKeySkill
            // 
            this.colKeySkill.Caption = "Key skills";
            this.colKeySkill.FieldName = "KeySkills";
            this.colKeySkill.Name = "colKeySkill";
            this.colKeySkill.Visible = true;
            this.colKeySkill.VisibleIndex = 1;
            this.colKeySkill.Width = 150;
            // 
            // colDesiredPay
            // 
            this.colDesiredPay.Caption = "Desired Pay";
            this.colDesiredPay.FieldName = "DesiredPay";
            this.colDesiredPay.Name = "colDesiredPay";
            this.colDesiredPay.Visible = true;
            this.colDesiredPay.VisibleIndex = 2;
            this.colDesiredPay.Width = 87;
            // 
            // colYear
            // 
            this.colYear.Caption = "Year";
            this.colYear.FieldName = "Years";
            this.colYear.Name = "colYear";
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 3;
            this.colYear.Width = 135;
            // 
            // colInterviewNotes
            // 
            this.colInterviewNotes.Caption = "Interview Notes";
            this.colInterviewNotes.FieldName = "InterviewNotes";
            this.colInterviewNotes.Name = "colInterviewNotes";
            this.colInterviewNotes.Visible = true;
            this.colInterviewNotes.VisibleIndex = 4;
            this.colInterviewNotes.Width = 228;
            // 
            // dlgAddCandidateToPipeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 698);
            this.Controls.Add(this.gcCandidates);
            this.Controls.Add(this.flowLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "dlgAddCandidateToPipeline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Candidate To Pipeline";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dlgAddCandidateToPipeline_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCandidates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraEditors.SimpleButton sbOK;
        private DevExpress.XtraGrid.GridControl gcCandidates;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCandidates;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colKeySkill;
        private DevExpress.XtraGrid.Columns.GridColumn colDesiredPay;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colInterviewNotes;
    }
}